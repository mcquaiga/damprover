Imports Microsoft.Office.Core

Public Class ExcelWriterClass

    Private WithEvents app As New Interop.Excel.ApplicationClass
    Private instr As Instrument
    Friend owner As Windows.Forms.IWin32Window

    Public Event InstrumentSaved()

    Private meterType
    Private unCorMul
    Private CorMul

    Sub New(ByRef Owner As IWin32Window, ByVal instrument As Instrument)
        Me.New(instrument)
        Me.owner = Owner
    End Sub

    Sub New(ByVal instrument As Instrument)

        Dim P As Boolean = False
        Dim T As Boolean = False

        Me.instr = instrument
        With app
            Try
                If instrument.InstrumentDriveType = DAM_Prover.Instrument.DriveType.Rotary Then
                    If instrument.GetTemperatureObject(TestClass.TemperatureLevels.Low).TemperatureUnits = TemperatureClass.UnitsEnum.C _
                            Or instrument.GetPressureObject(TestClass.PressureLevels.High).PressureUnits = PressureFactorClass.UnitsEnum.kPa Then
                        .Workbooks.Open(My.Settings.RotaryMetricExcel)
                    Else
                        .Workbooks.Open(My.Settings.ExcelLocation)
                    End If
                    .Range("I6").Value = instrument.GetItemValue(RotaryVolumeClass.GeneralVolumeItems.MeterDisplacement).value
                    instrument.Volume.MeterTypeNumber = instrument.GetItemValue(RotaryVolumeClass.GeneralVolumeItems.MeterType).value
                    .Range("I9").Value = instrument.Volume.MeterTypeName
                ElseIf instrument.InstrumentDriveType = DAM_Prover.Instrument.DriveType.Mechanical Then
                    If instrument.GetTemperatureObject(TestClass.TemperatureLevels.Low).TemperatureUnits = TemperatureClass.UnitsEnum.C _
                                Or instrument.GetPressureObject(TestClass.PressureLevels.High).PressureUnits = PressureFactorClass.UnitsEnum.kPa Then
                        .Workbooks.Open(My.Settings.MechMetricExcel)
                    Else
                        .Workbooks.Open(My.Settings.MechExcel)
                    End If
                    .Range("I6").Value = 1
                End If
                .Range("A1").Value = instrument.InstrumentID
                .Range("I5").Value = CStr(instrument.GetItemValue(62).value)
                .Range("G5").Value = CStr(instrument.GetItemValue(201).value)
                .Range("E19").Value = CStr(instrument.GetItemValue(13).value)
                .Range("I19").Value = CStr(instrument.GetItemValue(34).value)
                .Range("D36").Value = CStr(instrument.GetItemValue(53).value)
                .Range("D37").Value = CStr(instrument.GetItemValue(54).value)
                .Range("D38").Value = CStr(instrument.GetItemValue(55).value)
                .Range("D8").Value = CStr(instrument.GetItemValue(138).value)
                If Not IsNothing(instrument.Energy) Then
                    .Range("d14").Value = instrument.Energy.GasValue
                    .Range("d13").Value = instrument.Energy.Units
                    .Range("f52").Value = instrument.Energy.StartReading
                    .Range("F53").Value = instrument.Energy.EndReading
                End If
                .Range("c44").Value = 0
                .Range("c45").Value = 0

                .Range("I2").Value = Date.Now

                .Range("I7").Value = CStr(instrument.GetItemValue(122).value)
                .Range("C16").Value = CStr(instrument.GetItemValue(56).value)
                .Range("F16").Value = CStr(instrument.GetItemValue(57).value)
                .Range("C40").Value = instrument.Volume.GetMeterIndexRate(instrument.GetItemValue(Volume.GeneralVolumeItems.MeterIndexRate).value)

                .Range("c42").Value = instrument.Volume.GetVolumeMultipliers(instrument.GetItemValue(Volume.GeneralVolumeItems.CorrectedMultiplier).value)
                CorMul = instrument.Volume.GetVolumeMultipliers(instrument.GetItemValue(Volume.GeneralVolumeItems.CorrectedMultiplier).value)
                .Range("f42").Value = instrument.Volume.GetVolumeMultipliers(instrument.GetItemValue(Volume.GeneralVolumeItems.UnCorrectedMultiplier).value)
                unCorMul = instrument.Volume.GetVolumeMultipliers(instrument.GetItemValue(Volume.GeneralVolumeItems.UnCorrectedMultiplier).value)
                .Range("f44").Value = CStr(instrument.Volume.EndCorrected)
                .Range("f48").Value = CStr(instrument.Volume.AppliedInput)
                .Range("f46").Value = CStr(instrument.Volume.EndUnCorrected)

                .Range("g57").Value = instrument.Volume.PulserA
                .Range("h57").Value = instrument.Volume.PulserB
                If instrument.InstrumentType <> miSerialProtocol.InstrumentTypeCode.TCI Then
                    If instrument.GetItemValue(instrument.FixedFactorItems.FixedPressure).value = instrument.FixedFactors.Live Then
                        P = True
                        .Range("C6").Value = instrument.GetPressureObject(TestClass.PressureLevels.High).Convert(instrument.GetItemValue(25).value) _
                        & " " & instrument.GetPressureObject(TestClass.PressureLevels.High).PressureUnits.ToString _
                        & " " & instrument.GetPressureObject(TestClass.PressureLevels.High).Transducer.ToString

                        .Range("b23").Value = instrument.GetPressureObject(TestClass.PressureLevels.Low).GaugePressure
                        .Range("c23").Value = instrument.GetPressureObject(TestClass.PressureLevels.Low).AtmosphericPressure
                        .Range("d23").Value = instrument.GetPressureObject(TestClass.PressureLevels.Low).EVCPressure
                        .Range("e23").Value = instrument.GetPressureObject(TestClass.PressureLevels.Low).EVCFactor
                        .Range("f23").Value = instrument.GetPressureObject(TestClass.PressureLevels.Low).EVCUnsqr

                        .Range("b24").Value = instrument.GetPressureObject(TestClass.PressureLevels.Mid).GaugePressure
                        .Range("c24").Value = instrument.GetPressureObject(TestClass.PressureLevels.Mid).AtmosphericPressure
                        .Range("d24").Value = instrument.GetPressureObject(TestClass.PressureLevels.Mid).EVCPressure
                        .Range("e24").Value = instrument.GetPressureObject(TestClass.PressureLevels.Mid).EVCFactor
                        .Range("f24").Value = instrument.GetPressureObject(TestClass.PressureLevels.Mid).EVCUnsqr

                        .Range("c49").Value = instrument.GetPressureObject(TestClass.PressureLevels.High).GaugePressure
                        .Range("c48").Value = instrument.GetPressureObject(TestClass.PressureLevels.High).AtmosphericPressure
                        .Range("d25").Value = instrument.GetPressureObject(TestClass.PressureLevels.High).EVCPressure
                        .Range("e25").Value = instrument.GetPressureObject(TestClass.PressureLevels.High).EVCFactor
                        .Range("f25").Value = instrument.GetPressureObject(TestClass.PressureLevels.High).EVCUnsqr
                    End If
                End If

                If instrument.GetItemValue(instrument.FixedFactorItems.FixedTempFactor).value = instrument.FixedFactors.Live Then
                    T = True
                    .Range("c29").Value = instrument.GetTemperatureObject(TestClass.TemperatureLevels.High).GaugeTemperature
                    .Range("d29").Value = instrument.GetTemperatureObject(TestClass.TemperatureLevels.High).EVCTemperature
                    .Range("e29").Value = instrument.GetTemperatureObject(TestClass.TemperatureLevels.High).EVCFactor

                    .Range("c30").Value = instrument.GetTemperatureObject(TestClass.TemperatureLevels.Mid).GaugeTemperature
                    .Range("d30").Value = instrument.GetTemperatureObject(TestClass.TemperatureLevels.Mid).EVCTemperature
                    .Range("e30").Value = instrument.GetTemperatureObject(TestClass.TemperatureLevels.Mid).EVCFactor

                    .Range("c50").Value = instrument.GetTemperatureObject(TestClass.TemperatureLevels.Low).GaugeTemperature
                    .Range("d31").Value = instrument.GetTemperatureObject(TestClass.TemperatureLevels.Low).EVCTemperature
                    .Range("e31").Value = instrument.GetTemperatureObject(TestClass.TemperatureLevels.Low).EVCFactor
                End If


                If instrument.PulseASelect = DAM_Prover.Instrument.PulseOutputValues.CorVol Then
                    .Range("A55").Value = "Cor Vol"
                ElseIf instrument.PulseASelect = DAM_Prover.Instrument.PulseOutputValues.UncVol Then
                    .Range("A55").Value = "Unc Vol"
                ElseIf instrument.PulseASelect = DAM_Prover.Instrument.PulseOutputValues.NoOut Then
                    .Range("A55").Value = "No Out"
                Else
                    .Range("A55").Value = instrument.PulseASelect.ToString
                End If
                If instrument.PulseBSelect = DAM_Prover.Instrument.PulseOutputValues.CorVol Then
                    .Range("B55").Value = "Cor Vol"
                ElseIf instrument.PulseBSelect = DAM_Prover.Instrument.PulseOutputValues.UncVol Then
                    .Range("B55").Value = "Unc Vol"
                ElseIf instrument.PulseBSelect = DAM_Prover.Instrument.PulseOutputValues.NoOut Then
                    .Range("B55").Value = "No Out"
                Else
                    .Range("B55").Value = instrument.PulseBSelect.ToString
                End If



                If P = True And T = True Then
                    .Range("H8").Value = "Pressure and Temperature"
                ElseIf P = True Then
                    .Range("H8").Value = "Pressure only"
                ElseIf T = True Then
                    .Range("H8").Value = "Temperature"
                End If
                .Visible = True

                .EnableEvents = True
                .DisplayAlerts = False

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End With

    End Sub

    Public Sub BeforeClose(ByVal Workbook As Interop.Excel.Workbook, ByRef Cancel As Boolean) Handles app.WorkbookBeforeClose

        If Me.instr.InstrumentID <> 0 Then
            app.Visible = False

            Dim save As DialogResult = MessageBox.Show("Would you like to save this back to the database?", "Save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
            If save = DialogResult.Yes Then
                SaveInstrumentFromExcel()
                Cancel = False
            ElseIf save = DialogResult.No Then
                Cancel = False
                app.Quit()
                app = Nothing
            Else
                Cancel = True
            End If
        End If

    End Sub

    Public Sub SaveInstrumentFromExcel()

        With app
            Try
                instr.SaveItemValue(62, .Range("I5").Value)
                instr.SaveItemValue(201, .Range("G5").Value)
                instr.SaveItemValue(13, .Range("e19").Value)
                instr.SaveItemValue(34, .Range("i19").Value)
                'Super Factors
                instr.SaveItemValue(53, .Range("D36").Value)
                instr.SaveItemValue(54, .Range("D37").Value)
                instr.SaveItemValue(55, .Range("D38").Value)

                instr.SaveItemValue(138, .Range("D8").Value)
                instr.SaveItemValue(140, .Range("f53").Value)

                instr.SaveItemValue(122, .Range("I7").Value)
                instr.SaveItemValue(56, .Range("C16").Value)
                instr.SaveItemValue(57, .Range("F16").Value)

                'Meter Index Codes
                'instr.SaveItemValue(Volume.GeneralVolumeItems.MeterIndexRate, )
                '.Range("C40").Value = instr.Volume.GetMeterIndexRate(instr.GetItemValue().value)
                'Cor and UnCor Mulitpliers
                '.Range("c42").Value = Instrument.Volume.GetVolumeMultipliers(Instrument.GetItemValue(Volume.GeneralVolumeItems.CorrectedMultiplier).value)
                '.Range("f42").Value = Instrument.Volume.GetVolumeMultipliers(Instrument.GetItemValue(Volume.GeneralVolumeItems.UnCorrectedMultiplier).value)
                If IsNothing(instr.Volume) Then
                    If instr.InstrumentDriveType = Instrument.DriveType.Rotary Then
                        instr.Volume = New RotaryVolumeClass()
                    Else
                        instr.Volume = New Volume()
                    End If

                End If
                instr.Volume.EndCorrected = .Range("f44").Value
                instr.Volume.AppliedInput = .Range("f48").Value
                instr.Volume.EndUnCorrected = .Range("f46").Value
                instr.Volume.PulserA = .Range("g57").Value
                instr.Volume.PulserB = .Range("h57").Value
                instr.Volume.UnCorrectedMultiplier = Me.unCorMul
                instr.Volume.CorrectedMultiplier = Me.CorMul
                instr.Volume.MeterDisplacement = .Range("I6").Value

                If instr.LivePressure = Instrument.FixedFactors.Live Then
                    Dim x As Integer = 1
                    instr.Pressures.Clear()
                    Do While x <= 3
                        Dim press As New PressureFactorClass
                        press.BasePressure = .Range("E19").Value
                        press.GaugePressure = .Range("b" & 22 + x).Value
                        press.AtmosphericPressure = .Range("c" & 22 + x).Value
                        press.EVCPressure = .Range("d" & 22 + x).Value
                        press.EVCFactor = .Range("e" & 22 + x).Value
                        press.EVCUnsqr = .Range("f" & 22 + x).Value
                        instr.Pressures.Add(press, x)
                        x += 1
                    Loop
                End If

                If instr.LiveTemp = Instrument.FixedFactors.Live Then
                    Dim x As Integer = 1
                    instr.Temperatures.Clear()
                    Do While x <= 3
                        Dim temp As New TemperatureClass
                        temp.BaseTemperature = .Range("I19").Value
                        temp.GaugeTemperature = .Range("c" & 28 + x).Value
                        temp.EVCTemperature = .Range("d" & 28 + x).Value
                        temp.EVCFactor = .Range("e" & 28 + x).Value
                        instr.Temperatures.Add(temp, x)
                        x += 1
                    Loop
                End If

                app.Quit()
                app = Nothing
                instr.SaveInstrument()
                RaiseEvent InstrumentSaved()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End With
    End Sub

End Class
