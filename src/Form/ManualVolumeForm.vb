Public Class ManualVolumeForm

    Private Pressure As New PressureFactorClass
    Private Temperature As New TemperatureClass
    Private SuperFactor As New SuperFactorClass
    Private MechanicalVolume As New Volume
    Private RotaryVolume As New RotaryVolumeClass

    Private Sub PressureTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PressureTextBox.TextChanged
        Calc()
    End Sub

    Private Sub Calc()
        Try
            If PressureRadioButton.Checked Or PTRadioButton.Checked Then
                'Assign values to Pressure class
                Pressure.PressureUnits = Me.PressureUnitsComboBox.SelectedIndex
                Pressure.GaugePressure = Me.PressureTextBox.Text
                Pressure.AtmosphericPressure = Me.ATMTextBox.Text
                Pressure.BasePressure = Me.BasePressureTextBox.Text
            End If

            If TempRadioButton.Checked Or PTRadioButton.Checked Then
                'Assign values to Temp Class
                Temperature.TemperatureUnits = Me.TempUnitsComboBox.SelectedIndex
                Temperature.GaugeTemperature = Me.TempTextBox.Text
                Temperature.BaseTemperature = Me.BaseTempTextBox.Text
            End If

            If YesSuperRadioButton.Checked Then
                'Assign values to Super class
                SuperFactor.GaugePressure = Pressure.ConvertToPSI(Me.PressureTextBox.Text, Me.PressureUnitsComboBox.SelectedIndex)
                SuperFactor.GaugeTemp = Temperature.ConvertToF(Me.TempTextBox.Text, Me.TempUnitsComboBox.SelectedIndex)
                SuperFactor.SpecGr = Me.SpecGrTextBox.Text
                SuperFactor.CO2 = Me.CO2TextBox.Text
                SuperFactor.N2 = Me.N2TextBox.Text
            End If


            If MechanicalRadioButton.Checked = True Then
                SetVolume(MechanicalVolume)

                If PTRadioButton.Checked = True Then
                    MechanicalVolume.EVCType = Volume.EVCTypeEnum.PressureTemperature
                ElseIf TempRadioButton.Checked = True Then
                    MechanicalVolume.EVCType = Volume.EVCTypeEnum.Temperature
                ElseIf PressureRadioButton.Checked = True Then
                    MechanicalVolume.EVCType = Volume.EVCTypeEnum.Pressure
                End If

                Me.InstrumentTotalCorrectionFactorLabel.Text = MechanicalVolume.EvcCorrected
                Me.CalcTotalCorrectionLabel.Text = MechanicalVolume.TrueCorrected
                Me.PercErrorLabel.Text = MechanicalVolume.UnCorrectedPercentError
            Else
                SetVolume(RotaryVolume)
                If PTRadioButton.Checked = True Then
                    RotaryVolume.EVCType = Volume.EVCTypeEnum.PressureTemperature
                ElseIf TempRadioButton.Checked = True Then
                    RotaryVolume.EVCType = Volume.EVCTypeEnum.Temperature
                ElseIf PressureRadioButton.Checked = True Then
                    RotaryVolume.EVCType = Volume.EVCTypeEnum.Pressure
                End If
                RotaryVolume.MeterDisplacement = Me.MeterDisplacementTextBox.Text
                Me.InstrumentTotalCorrectionFactorLabel.Text = RotaryVolume.EvcCorrected
                Me.CalcTotalCorrectionLabel.Text = RotaryVolume.TrueCorrected
                Me.PercErrorLabel.Text = RotaryVolume.UnCorrectedPercentError
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ManualVolumeForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim TempUnits As Array = System.Enum.GetValues(GetType(TemperatureClass.UnitsEnum))
        Dim PressureUnits As Array = System.Enum.GetValues(GetType(PressureFactorClass.UnitsEnum))

        Dim Unit
        For Each Unit In TempUnits
            Me.TempUnitsComboBox.Items.Add(Unit)
        Next

        For Each Unit In PressureUnits
            Me.PressureUnitsComboBox.Items.Add(Unit)
        Next

        FillBoxes()
    End Sub

    Private Sub AnyTextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ATMTextBox.TextChanged, BasePressureTextBox.TextChanged, _
                                    ActualInputTextBox.TextChanged, BaseTempTextBox.TextChanged, CO2TextBox.TextChanged, CorMultiTextBox.TextChanged, EndCorrectedTextBox.TextChanged, _
                                    EndCorrectedTextBox.TextChanged, EndUncorrectedTextBox.TextChanged, N2TextBox.TextChanged, PressureTextBox.TextChanged, _
                                     SpecGrTextBox.TextChanged, StartCorrectedTextBox.TextChanged, StartUncorrectedTextBox.TextChanged, TempTextBox.TextChanged, _
                                      UnCorMultiplierTextBox.TextChanged
        Calc()

    End Sub

    Private Sub TempRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TempRadioButton.CheckedChanged
        Me.PressureGroupBox.Enabled = False
        Me.TemperatureGroupBox.Enabled = True
        Me.NoSuperRadioButton.Checked = True
    End Sub

    Private Sub PressureRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PressureRadioButton.CheckedChanged
        Me.TemperatureGroupBox.Enabled = False
        Me.PressureGroupBox.Enabled = True
        Me.NoSuperRadioButton.Checked = True
    End Sub

    Private Sub PTRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PTRadioButton.CheckedChanged
        Me.TemperatureGroupBox.Enabled = True
        Me.PressureGroupBox.Enabled = True
        Me.YesSuperRadioButton.Checked = True
    End Sub

    Private Sub MechanicalRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MechanicalRadioButton.CheckedChanged

    End Sub

    Private Sub RotaryRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RotaryRadioButton.CheckedChanged

    End Sub

    Private Sub SetVolume(ByRef Volume As Volume)
        Try
            Volume.AppliedInput = Me.ActualInputTextBox.Text
            Volume.CorrectedMultiplier = Me.CorMultiTextBox.Text
            Volume.UnCorrectedMultiplier = Me.UnCorMultiplierTextBox.Text
            Volume.DriveRate = Me.UnCorMultiplierTextBox.Text
            Volume.TempFactor = Me.Temperature.TemperatureFactor
            Volume.PressureFactor = Me.Pressure.ActualPressureFactor
            Volume.StartCorrected = Me.StartCorrectedTextBox.Text
            Volume.EndCorrected = Me.EndCorrectedTextBox.Text
            Volume.StartUncorrected = Me.StartUncorrectedTextBox.Text
            Volume.EndUnCorrected = Me.EndUncorrectedTextBox.Text
            Volume.Fpv2Factor = Me.SuperFactor.SuperFactor
        Catch ex As Exception
            Console.Write(ex.Message)
        End Try

    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByVal Volume As Volume, ByVal Temp As TemperatureClass, ByVal pressure As PressureFactorClass, ByVal SuperFactor As SuperFactorClass)
        InitializeComponent()
        MechanicalVolume = Volume
        Me.Temperature = Temp
        Me.Pressure = pressure
        Me.SuperFactor = SuperFactor

        Me.MechanicalRadioButton.Checked = True

    End Sub

    Public Sub New(ByVal Volume As RotaryVolumeClass, ByVal temp As TemperatureClass, ByVal pressure As PressureFactorClass, ByVal super As SuperFactorClass)
        Me.New()

        RotaryVolume = Volume
        Me.Temperature = temp
        Me.Pressure = pressure
        Me.SuperFactor = super

        Me.RotaryRadioButton.Checked = True


    End Sub


    Public Sub FillBoxes()

        If RotaryRadioButton.Checked Then
            With Me.RotaryVolume
                DriveRateTextBox.Text = .GetMeterIndexRate(.DriveRate)
                UnCorMultiplierTextBox.Text = .GetVolumeMultipliers(.UnCorrectedMultiplier)
                CorMultiTextBox.Text = .GetVolumeMultipliers(.CorrectedMultiplier)
                MeterDisplacementTextBox.Text = .MeterDisplacement
                StartCorrectedTextBox.Text = .StartCorrected
                StartUncorrectedTextBox.Text = .StartUncorrected
                EndCorrectedTextBox.Text = .EndCorrected
                EndUncorrectedTextBox.Text = .EndUnCorrected
                ActualInputTextBox.Text = .AppliedInput
            End With
        Else
            With MechanicalVolume
                DriveRateTextBox.Text = .DriveRate
                UnCorMultiplierTextBox.Text = .UnCorrectedMultiplier
                CorMultiTextBox.Text = .CorrectedMultiplier
                StartCorrectedTextBox.Text = .StartCorrected
                StartUncorrectedTextBox.Text = .StartUncorrected
                EndCorrectedTextBox.Text = .EndCorrected
                EndUncorrectedTextBox.Text = .EndUnCorrected
                ActualInputTextBox.Text = .AppliedInput
            End With
        End If

        PTRadioButton.Checked = True
        With Temperature
            If Not Temperature Is Nothing Then
                TempTextBox.Text = .GaugeTemperature
                BaseTempTextBox.Text = .BaseTemperature
                TempUnitsComboBox.SelectedIndex = .TemperatureUnits + 1
            Else
                PressureRadioButton.Checked = True
            End If

        End With

        With Pressure
            If Not Pressure Is Nothing Then
                PressureTextBox.Text = .GaugePressure
                ATMTextBox.Text = .AtmosphericPressure
                PressureUnitsComboBox.SelectedIndex = .PressureUnits
                BasePressureTextBox.Text = .BasePressure
            Else
                TempRadioButton.Checked = True
            End If
        End With

        With SuperFactor
            If Not SuperFactor Is Nothing Then
                SpecGrTextBox.Text = .SpecGr
                N2TextBox.Text = .N2
                CO2TextBox.Text = .CO2
            End If
        End With

        Calc()
    End Sub

End Class