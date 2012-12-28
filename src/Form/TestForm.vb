Public Class TestForm

    Public Enum ItemNum
        TempItem = 26
        PressureItem = 8
        SerialNumber = 62
    End Enum

    'With these public we can receive events from them in our form
    Public CustomerID As Integer
    Public Test As TestClass
    Private WithEvents InstrumentSrl As miSerialProtocol.miSerialProtocolClass

    'Public Event InstrumentEvents As miSerialProtocol.miSerialProtocolClass.CommStateChangedEventHandler
    'Public Event InstrumentItems As miSerialProtocol.miSerialProtocolClass.ItemCountEventHandler
    'Public Event InstrumentItemProgress As miSerialProtocol.miSerialProtocolClass.CurrentItemProgressEventHandler
    Public WithEvents Instrument As Instrument

    Public InstrumentType As miSerialProtocol.InstrumentTypeCode
    Public DriveType As Instrument.DriveType
    Private State As miSerialProtocol.CommStateEnum
    Private TestStarted = False
    Private TestComplete As Boolean = False

    Private Sub TestForm_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        If Not IsNothing(Test) Then
            Test.Dispose()
        End If
    End Sub

    Private Sub TestForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If TestComplete = False Then
            If MessageBox.Show("Are you sure you want to cancel the test?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) _
                   = Windows.Forms.DialogResult.Yes Then
                Me.TestStarted = False
                If Not Test Is Nothing Then
                    Test.Instrument.Disconnect()
                    Test.Dispose()
                End If
            Else
                e.Cancel = True
            End If
        Else
            Test.Dispose()
        End If
    End Sub

    Private Sub Test_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Try
            Application.DoEvents()
            'StartPreButton.PerformClick()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub StartButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartPreButton.Click

        AddHandler miSerialProtocol.miSerialProtocolClass.CommStateChanged, AddressOf Instrument_Events
        AddHandler miSerialProtocol.miSerialProtocolClass.CurrentItemProgress, AddressOf ItemProgress
        AddHandler miSerialProtocol.miSerialProtocolClass.ItemCount, AddressOf Items
        AddHandler TestClass.RcvPulseA, AddressOf PulseACount
        AddHandler TestClass.RcvPulseB, AddressOf PulseBCount
        AddHandler TestClass.RcvUncorrected, AddressOf UnCorrectedPulse
        AddHandler TestClass.UnCorrectedPulses, AddressOf UnCorrectedTotal

        Try
            StartPreButton.Enabled = False
            If InstrumentType = miSerialProtocol.InstrumentTypeCode.MiniMax Then
                If DriveType = DAM_Prover.Instrument.DriveType.Rotary Then
                    Test = New MiniMaxRotaryTestClass(CustomerID)
                Else
                    Test = New MiniMaxTestClass(CustomerID)
                End If
            ElseIf InstrumentType = miSerialProtocol.InstrumentTypeCode.TCI Then
                Test = New TCITestClass(CustomerID)
            Else
                Test = New MiniATTestClass(CustomerID)
            End If

            Test.Instrument.Customer = Test.Customer
            Test.PreTest()

            Me.SerialNumberTextBox.Text = Test.Instrument.GetItemValue(ItemNum.SerialNumber).value
            Me.PulserALabel.Text = Me.PulserALabel.Text & vbNewLine & Test.Instrument.PulseASelect.ToString
            Me.PulserBLabel.Text = Me.PulserBLabel.Text & vbNewLine & Test.Instrument.PulseBSelect.ToString

            Test.Instrument.Volume.MeterTypeNumber = Test.Instrument.GetItemValue(RotaryVolumeClass.GeneralVolumeItems.MeterType).value
            Me.MeterTypeTextBox.Text = Test.Instrument.Volume.MeterTypeName
            Me.EVCMeterDisplacementTextBox.Text = Test.Instrument.Volume.EVCMeterDisplacement
            Me.TrueMeterDisplacementTextBox.Text = Test.Instrument.Volume.MeterDisplacement
            Me.UnCorMultiTextBox.Text = Test.Instrument.Volume.GetVolumeMultipliers(Test.Instrument.GetItemValue(92).value)
            Test.Instrument.Volume.UnCorrectedMultiplier = UnCorMultiTextBox.Text
            Me.CorMultiTextBox.Text = Test.Instrument.Volume.GetVolumeMultipliers(Test.Instrument.GetItemValue(90).value)
            Me.PercentMeterLabel.Text = "Displacement Percent Error: " & Format((((Test.Instrument.Volume.EVCMeterDisplacement - Test.Instrument.Volume.MeterDisplacement) / Test.Instrument.Volume.MeterDisplacement) * 100), "#0.0000") & "  %"
            Me.Item200TextBox.Text = Test.Instrument.GetItemValue(200).value
            Me.Item201TextBox.Text = Test.Instrument.GetItemValue(201).value

            If Test.Instrument.LivePressure = DAM_Prover.Instrument.FixedFactors.Live Then
                Me.PressureRangeTextBox.Text = Trim(Test.Instrument.GetItemValue(25).value) & " PSI"
            Else
                Me.PressureRangeTextBox.Text = "N/A"
            End If

            Me.StartTestButton.Visible = True
            Me.StartPreButton.Visible = False

            Dim x As Integer
            For Each item As miSerialProtocol.ItemClass In Me.Test.Instrument.AllItems
                ItemsListView.Items.Add(item.item)
                ItemsListView.Items(x).SubItems.Add(item.value)
                x += 1
            Next

            PreVolumeTest()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Test.Dispose()
            Me.Close()
        End Try
    End Sub

    Public Sub PreVolumeTest()
        'If this is cancelled then we dont want the test to be cancelled
        Try
            Test.Instrument.InstrumentSrl.Connect()
            WaitForStart()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Instrument_Events(ByVal State As miSerialProtocol.CommStateEnum)
        Try
            CurrentLabel.Text = "Currently: " & State.ToString
            Me.State = State
        Catch ex As Exception
            Console.Write(ex.Message)
        End Try
    End Sub

    Private Sub Items(ByVal Count As Integer)
        ProgressBar.Value = 0
        Me.ProgressBar.Maximum = Count
        Application.DoEvents()
    End Sub

    Private Sub WaitForStart()
        Dim TempPressureOkay As Boolean = False
        Dim TempUnits As TemperatureClass.UnitsEnum
        Dim PressureUnits As PressureFactorClass.UnitsEnum

        If State = miSerialProtocol.CommStateEnum.LinkedIdle Then
            PressureUnits = Test.Instrument.GetItemValue(PressureFactorClass.PressureItemsEnum.PressureUnits).value
            TempUnits = Test.Instrument.GetItemValue(TemperatureClass.TemperatureItems.TempUnits).value
            PressureUnitsLabel.Text = PressureUnits.ToString
            TempUnitsLabel.Text = TempUnits.ToString
            Do
                Application.DoEvents()
                If Test.Instrument.LiveTemp = DAM_Prover.Instrument.FixedFactors.Live Then
                    Me.TempTextBox.Text = Test.Instrument.LiveRead(26)
                    If TempTextBox.Text > 34 Then
                        TempTextBox.BackColor = Color.Red
                    Else
                        TempTextBox.BackColor = Color.White
                    End If
                End If
                If Test.Instrument.LivePressure = DAM_Prover.Instrument.FixedFactors.Live Then
                    Me.PressureTextBox.Text = Test.Instrument.LiveRead(8)
                    If PressureTextBox.Text < (Test.Instrument.GetItemValue(25).value * 0.75) Then
                        PressureTextBox.BackColor = Color.Red
                    Else
                        PressureTextBox.BackColor = Color.White
                    End If
                End If
                Application.DoEvents()
            Loop Until TestStarted
        End If
    End Sub

    Private Sub ItemProgress(ByVal NumItems As Integer) Handles InstrumentSrl.CurrentItemProgress
        Try
            Me.ProgressBar.Value += NumItems
            Application.DoEvents()
        Catch ex As Exception
            Me.ProgressBar.Value = 0
        End Try
    End Sub

    Private Sub PulseACount(ByVal Count As Integer)
        Me.PulseATextBox.Text = Count
    End Sub

    Private Sub PulseBCount(ByVal Count As Integer)
        Me.PulseBTextBox.Text = Count
    End Sub

    Public Sub UnCorrectedPulse(ByVal Count As Integer)
        ProgressBar.Value = Count
        If Not Me.Test.Instrument.Volume Is Nothing Then
            Me.TachTextBox.Text = Format(Me.Test.Instrument.Volume.IdealAppliedInput(Count), "######0")
        End If

    End Sub

    Public Sub UnCorrectedTotal(ByVal Total As Integer)
        ProgressBar.Value = 0
        ProgressBar.Maximum = Total
    End Sub


    Private Sub StartTestButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartTestButton.Click
        Try
            'If Test.Instrument.LiveTemp = DAM_Prover.Instrument.FixedFactors.Live Then
            '    If Me.TempTextBox.Text > My.Settings.TempLimit Then
            '        MessageBox.Show("Temperature is above the test limit." & vbNewLine & "Please place in appropriate bath.", "Temp High", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '        WaitForStart()
            '    End If
            'End If

            'If Test.Instrument.LivePressure = DAM_Prover.Instrument.FixedFactors.Live Then
            '    If Me.PressureTextBox.Text < My.Settings.PressureLimit Then
            '        MessageBox.Show("Pressure is below the test limit." & vbNewLine & "Please apply pressure above " & My.Settings.PressureLimit & ".", "Pressure Low", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '        WaitForStart()
            '    End If
            'End If
            If Test.Instrument.InstrumentDriveType = DAM_Prover.Instrument.DriveType.Rotary Then
                Dim input = InputBox("Enter Number of Uncorrected Pulses to Run..." & vbNewLine & "Meter Type: " & Test.Instrument.Volume.MeterTypeName)
                If IsNumeric(input) Then
                    LiveReadButton.Enabled = False
                    DisconnectButton.Enabled = False
                    Me.StartTestButton.Enabled = False
                    TestStarted = True

                    Test.Instrument.Disconnect()

                    Test.Instrument.Volume.MaxUnCorrected = input
                    If Test.Test() = Windows.Forms.DialogResult.Cancel Then
                        Me.StartTestButton.Enabled = True
                        PreVolumeTest()
                    End If
                    If Test.PostTest() = Windows.Forms.DialogResult.Retry Then
                        Me.StartTestButton.Enabled = True
                        TestStarted = False
                        Me.PreVolumeTest()
                    Else
                        TestComplete = True
                        Me.Close()
                    End If
                End If
            Else
                LiveReadButton.Enabled = False
                DisconnectButton.Enabled = False
                Me.StartTestButton.Enabled = False
                TestStarted = True

                Test.Instrument.Disconnect()
                If Test.Test() = Windows.Forms.DialogResult.Cancel Then
                    Me.StartTestButton.Enabled = True
                    PreVolumeTest()
                End If
                If Test.PostTest() = Windows.Forms.DialogResult.Retry Then
                    Me.Close()
                    Me.StartTestButton.Enabled = True
                    TestStarted = False
                    Test.PreTest(True)
                    Me.PreVolumeTest()
                Else
                    TestComplete = True
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbNewLine & ex.InnerException.Message, "Error")
        End Try

    End Sub

    Private Sub ProgressBar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar.Click

    End Sub

    Private Sub LiveReadButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LiveReadButton.Click

        Try
            Test.Instrument.InstrumentSrl.Connect()
            WaitForStart()
        Catch ex As Exception

        End Try


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisconnectButton.Click

        Try
            Test.Instrument.InstrumentSrl.Disconnect()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub GroupBox4_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox4.Enter

    End Sub
End Class