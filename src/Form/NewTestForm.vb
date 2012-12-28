Imports MySql.Data.MySqlClient

Public Class NewTestForm

    Dim motor As DABoard

    Private Sub StartButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartButton.Click, InstrumentsListView.DoubleClick
        Dim frm As New TestForm
        Try
            My.Settings.Save()
            frm.CustomerID = Me.CustomerComboBox.SelectedIndex + 1

            With InstrumentsListView.SelectedItems
                If .Item(0).Text = "Mini-Max" Then
                    frm.DriveType = Instrument.DriveType.Mechanical
                    frm.InstrumentType = miSerialProtocol.InstrumentTypeCode.MiniMax
                    frm.ShowDialog()
                ElseIf .Item(0).Text = "Rotary" Then
                    frm.DriveType = Instrument.DriveType.Rotary
                    frm.InstrumentType = miSerialProtocol.InstrumentTypeCode.MiniMax
                    frm.ShowDialog()
                ElseIf .Item(0).Text = "Mini-AT" Then
                    frm.InstrumentType = miSerialProtocol.InstrumentTypeCode.MiniAT
                    frm.ShowDialog()
                ElseIf .Item(0).Text = "TCI" Then
                    frm.InstrumentType = miSerialProtocol.InstrumentTypeCode.TCI
                    frm.ShowDialog()
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub NewTestForm_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        My.Settings.Save()
    End Sub

    Private Sub NewTestForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CustomerItemsDataSet.customers' table. You can move, or remove it, as needed.
        Try '
            Me.Text = "DAM Prover - C.R. Wall & Co. Inc. " & String.Format("Version {0}", My.Settings.version)
            Me.CustomersTableAdapter.Fill(Me.CustomerItemsDataSet.customers)
            'Dim customer As New Customer

            Dim BaudRates As Array = System.Enum.GetValues(GetType(miSerialProtocol.BaudRateEnum))
            Dim BaudRate As Integer

            Dim DABoardTypes As Array = System.Enum.GetValues(GetType(DABoard.BoardType))
            Dim Board As DABoard.BoardType

            Dim comm
            For Each comm In My.Computer.Ports.SerialPortNames
                Me.InstCommComboBox.Items.Add(comm)
                Me.TachSerialComboBox.Items.Add(comm)
            Next
            InstCommComboBox.Sorted = True
            TachSerialComboBox.Sorted = True

            CustomerComboBox.SelectedValue = My.Settings.CustomerId
            InstCommComboBox.Sorted = True

            TempPercentErrorTextBox.Text = My.Settings.TempPercentageMax
            PressurePercentErrorTextBox.Text = My.Settings.PressurePercentageMax
            PressureLimitTextBox.Text = My.Settings.PressureLimit
            TempLimitTextBox.Text = My.Settings.TempLimit

            If My.Settings.UncVolumeOnly = True Then
                UncOnlyTestCheckBox.Checked = True
            Else
                UncOnlyTestCheckBox.Checked = False
            End If

            For Each BaudRate In BaudRates
                InstBaudComboBox.Items.Add(BaudRate)
            Next

            For Each Board In DABoardTypes
                DABoardComboBox.Items.Add(Board)
            Next

            InstrumentsListView.Items(0).Selected = True
            DABoardComboBox.SelectedIndex = My.Settings.BoardType - 1
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TestButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TestButton.Click
        Try
            Dim instrumentSrl As miSerialProtocol.miSerialProtocolClass = Nothing

            'ComboBox.selectedindex is zero based
            With InstrumentsListView.SelectedItems
                If .Count = 1 Then
                    If .Item(0).Text = "Mini-Max" Then
                        instrumentSrl = New miSerialProtocol.MiniMaxClass(Mid(InstCommComboBox.Text, 4), Me.InstBaudComboBox.Text)
                        instrumentSrl.Connect()
                    ElseIf .Item(0).Text = "Rotary" Then
                        instrumentSrl = New miSerialProtocol.MiniMaxClass(Mid(InstCommComboBox.Text, 4), Me.InstBaudComboBox.Text)
                        instrumentSrl.Connect()
                    ElseIf .Item(0).Text = "Mini-AT" Then
                        instrumentSrl = New miSerialProtocol.MiniATClass(Mid(InstCommComboBox.Text, 4), Me.InstBaudComboBox.Text)
                        instrumentSrl.Connect()
                    ElseIf .Item(0).Text = "TCI" Then
                        instrumentSrl = New miSerialProtocol.TCIClass(Mid(InstCommComboBox.Text, 4), Me.InstBaudComboBox.Text)
                        instrumentSrl.Connect()
                    End If
                    If Not instrumentSrl Is Nothing Then
                        If instrumentSrl.InstrumentError = miSerialProtocol.InstrumentErrorsEnum.NoError Then
                            MessageBox.Show("Connection Successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            instrumentSrl.Disconnect()
                        Else
                            MessageBox.Show("Connection failed.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End If
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub EditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditButton.Click
        Dim frm As New CustomerItems
        Dim c As DataRowView = CustomerComboBox.SelectedItem
        frm.Customer = New Customer(CInt(c("customer_id")))
        frm.ShowDialog()

    End Sub

    Private Sub TempPercentErrorTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TempPercentErrorTextBox.TextChanged
        Try
            My.Settings.TempPercentageMax = CDbl(TempPercentErrorTextBox.Text)
        Catch ex As Exception
            MessageBox.Show("Percent Error must be a number.")
            TempPercentErrorTextBox.Select()
        End Try

    End Sub

    Private Sub PressurePercentErrorTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PressurePercentErrorTextBox.TextChanged
        Try
            My.Settings.PressurePercentageMax = CDbl(PressurePercentErrorTextBox.Text)
        Catch ex As Exception
            MessageBox.Show("Percent Error must be a number.")
            TempPercentErrorTextBox.Select()
        End Try

    End Sub

    Private Sub CustomerComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerComboBox.SelectedIndexChanged
        If CustomerComboBox.SelectedItem IsNot Nothing Then
            Dim d As DataRowView = CustomerComboBox.SelectedItem
            My.Settings.CustomerId = d("customer_id")
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub TempLimitTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TempLimitTextBox.TextChanged
        Try
            My.Settings.TempLimit = CDbl(TempLimitTextBox.Text)
        Catch ex As Exception
            MessageBox.Show("Must be a number.")
            TempLimitTextBox.Select()
        End Try
    End Sub

    Private Sub PressureLimitTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PressureLimitTextBox.TextChanged
        Try
            My.Settings.PressureLimit = CDbl(PressureLimitTextBox.Text)
        Catch ex As Exception
            MessageBox.Show("Must be a number.")
            PressureLimitTextBox.Select()
        End Try
    End Sub



    Private Sub TestDBButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TestDBButton.Click
        Dim db As New MySQLLibrary.Database()
        Try
            db.OpenMySQL()
            MessageBox.Show("Connection Successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            db.CloseMySQL()
        End Try
    End Sub

    Private Sub EditInstrumentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim frm As New EditInstrumentForm
        'frm.ShowDialog()
        Dim instrument As New Instrument()
        instrument.LoadFromDB(InputBox("Instrument Id:"))
        Dim excel As New ExcelWriterClass(instrument)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TestTachButton.Click
        Dim tachTest As New TachometerClass(Mid(My.Settings.TachCommPort, 4))
        MessageBox.Show("The following should match whats on the tachometer display: " & vbNewLine & "Input:" & tachTest.ReadTach(), "Tach", MessageBoxButtons.OK, MessageBoxIcon.Information)
        tachTest.Dispose()
    End Sub

    Private Sub DToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim inputString As String = InputBox("Enter Inspection ID")
        Try
            If IsNumeric(inputString) Then
                Dim csv As New CSVWriterClass(inputString)
                csv.WriteOldEnbridgeCSVFile()
                csv = Nothing
            End If
        Catch ex As InvalidCastException
            MessageBox.Show(ex.Message)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        Dim frm As New ViewInspectionForm
        frm.ShowDialog()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Dim frm As New InspecForm
        frm.ShowDialog()
    End Sub
    Private Sub DABoardComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DABoardComboBox.SelectedIndexChanged

        My.Settings.BoardType = DABoardComboBox.SelectedItem
    End Sub

    Private Sub StartMotorButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartMotorButton.Click

        If motor Is Nothing Then
            If My.Settings.BoardType = DABoard.BoardType.PCI Then
                motor = New PCIDataAcqClass("DT335(00)", OpenLayers.Base.SubsystemType.DigitalOutput, 1, My.Settings.PulserOutDataFlow)
            Else
                motor = New USBDataAcqClass(0, 0, 0)
            End If
        End If
        motor.PulseOut(motor.StartMotor)
    End Sub

    Private Sub StopMotorButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StopMotorButton.Click

        If motor Is Nothing Then
            If My.Settings.BoardType = DABoard.BoardType.PCI Then
                motor = New PCIDataAcqClass("DT335(00)", OpenLayers.Base.SubsystemType.DigitalOutput, 1, My.Settings.PulserOutDataFlow)
            Else
                motor = New USBDataAcqClass(0, 0, My.Settings.PulserOutDataFlow)
            End If
        End If
        motor.PulseOut(motor.StopMotor)

        motor.Dispose(True)
        motor = Nothing

    End Sub

    Private Sub InstrumentsListView_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InstrumentsListView.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click

        AboutBox.ShowDialog()
    End Sub

    Private Sub RestartIrDAServiceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestartIrDAServiceToolStripMenuItem.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim irdMon As ServiceProcess.ServiceController = New ServiceProcess.ServiceController("Infrared Monitor")
            If irdMon.Status = ServiceProcess.ServiceControllerStatus.Running Then
                irdMon.Stop()
            End If
            System.Threading.Thread.Sleep(4000)
            irdMon.Start()
            MessageBox.Show("Status of Infrared Monitor:" & irdMon.Status.ToString, "Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.Cursor = Cursors.Default

        End Try
    End Sub

    Private Sub SetInstrumentDateAndTimeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetInstrumentDateAndTimeToolStripMenuItem.Click
        Dim instrumentSrl As miSerialProtocol.miSerialProtocolClass = Nothing
        Dim instr As New Instrument

        Me.Cursor = Cursors.WaitCursor
        Try
            With InstrumentsListView.SelectedItems
                If .Count = 1 Then
                    If .Item(0).Text = "Mini-Max" Then
                        instrumentSrl = New miSerialProtocol.MiniMaxClass(Mid(InstCommComboBox.Text, 4), Me.InstBaudComboBox.Text)

                    ElseIf .Item(0).Text = "Rotary" Then
                        instrumentSrl = New miSerialProtocol.MiniMaxClass(Mid(InstCommComboBox.Text, 4), Me.InstBaudComboBox.Text)

                    ElseIf .Item(0).Text = "Mini-AT" Then
                        instrumentSrl = New miSerialProtocol.MiniATClass(Mid(InstCommComboBox.Text, 4), Me.InstBaudComboBox.Text)

                    ElseIf .Item(0).Text = "TCI" Then
                        instrumentSrl = New miSerialProtocol.TCIClass(Mid(InstCommComboBox.Text, 4), Me.InstBaudComboBox.Text)

                    End If

                    instr.InstrumentSrl = instrumentSrl
                    instr.InstrumentSrl.Connect()
                    If instr.SetInstrumentDateTime() = True Then
                        MessageBox.Show("Instrument date and time successfully set.", "Date and Time", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Failed to set instrument date and time.", "Date and Time", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            instr.InstrumentSrl.Disconnect()
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub RawItemAccessToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RawItemAccessToolStripMenuItem.Click
        Dim frm As New RawItemDialog
        Dim instrumentSrl As miSerialProtocol.miSerialProtocolClass = Nothing
        Try


            With InstrumentsListView.SelectedItems
                If .Count = 1 Then
                    If .Item(0).Text = "Mini-Max" Then
                        instrumentSrl = New miSerialProtocol.MiniMaxClass(Mid(InstCommComboBox.Text, 4), Me.InstBaudComboBox.Text)
                        instrumentSrl.Connect()
                    ElseIf .Item(0).Text = "Rotary" Then
                        instrumentSrl = New miSerialProtocol.MiniMaxClass(Mid(InstCommComboBox.Text, 4), Me.InstBaudComboBox.Text)
                        instrumentSrl.Connect()
                    ElseIf .Item(0).Text = "Mini-AT" Then
                        instrumentSrl = New miSerialProtocol.MiniATClass(Mid(InstCommComboBox.Text, 4), Me.InstBaudComboBox.Text)
                        instrumentSrl.Connect()
                    ElseIf .Item(0).Text = "TCI" Then
                        instrumentSrl = New miSerialProtocol.TCIClass(Mid(InstCommComboBox.Text, 4), Me.InstBaudComboBox.Text)
                        instrumentSrl.Connect()
                    End If
                    If instrumentSrl.InstrumentError = miSerialProtocol.InstrumentErrorsEnum.NoError Then
                        frm.instrument = instrumentSrl
                        frm.ShowDialog()
                    Else
                        MessageBox.Show("Connection failed.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddCustomerButton.Click
        Dim frm As New AddCustomerForm
        frm.ShowDialog()
        Me.CustomersTableAdapter.Fill(Me.CustomerItemsDataSet.customers)
    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub EditRotaryMeterTypesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditRotaryMeterTypesToolStripMenuItem.Click
        Dim lgnForm As New LoginForm
        lgnForm.ShowDialog()
        If lgnForm.DialogResult = Windows.Forms.DialogResult.OK Then
            Dim meter As New MeterTypesForm
            meter.ShowDialog()
        End If
    End Sub

    Private Sub RotaryEnglishExcelTextBox_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RotaryEnglishExcelTextBox.MouseClick, RotaryMetricExcelTextBox.MouseClick, MechExcelTextBox.MouseClick, MechMetricExcelTextBox.MouseClick
        If Me.OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            sender.text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim frm As Windows.Forms.Form

        If DABoardComboBox.Text = "PCI" Then
            frm = New PCIBoardOptionsForm
            frm.ShowDialog()
        Else

        End If
    End Sub

    Private Sub UncOnlyTestCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UncOnlyTestCheckBox.CheckedChanged

    End Sub

    Private Sub TestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MechanicalInputDialog.ShowDialog()
    End Sub

    Private Sub StandardCSVToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        Dim inputString As String = InputBox("Enter Inspection ID")
        Try

            If IsNumeric(inputString) Then
                Dim csv As New CSVWriterClass(CInt(inputString))
                csv.WriteStandardCSVFile()
            End If
        Catch ex As InvalidCastException
            MessageBox.Show(ex.Message)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub RotaryEnglishExcelTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RotaryEnglishExcelTextBox.TextChanged

    End Sub

    Private Sub DataAcqWiringDiagramsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataAcqWiringDiagramsToolStripMenuItem.Click
        WiringDialog.ShowDialog()
    End Sub
End Class