Imports MySql.Data.MySqlClient
Public Class CSVWriterClass

    Dim InspectionID As Integer
    Dim db As New MySQLLibrary.Database
    Dim EnbridgeFileName As String
    Dim StandardFileName As String
    Dim NewIC As Boolean = False


    Sub New(ByVal InspectionID As Integer)
        Me.InspectionID = InspectionID
        EnbridgeFileName = "\\crwall-01\company\Enbridge CSV files\Instr_CR_Wall_" & InspectionID & "_" & Format(Date.Now(), "MMddyyyy") & ".csv"
        StandardFileName = "\\crwall-01\company\Enbridge CSV files\Instr_CR_Wall_" & InspectionID & "_" & Format(Date.Now(), "MMddyyyy") & ".csv"
    End Sub


    Public Sub WriteOldEnbridgeCSVFile()
        Dim myDataReader As MySqlDataReader
        Dim txtWriter As IO.StreamWriter
        Dim SizeCode As String
        Dim InspecType As String = "N"

        Try
            txtWriter = New IO.StreamWriter(EnbridgeFileName)

            Using mySqlCommand As New MySqlCommand
                With mySqlCommand
                    .Connection = db.OpenMySQL
                    .CommandText = "SELECT * FROM inspection_cert WHERE inspection_id = " & InspectionID
                    myDataReader = .ExecuteReader(CommandBehavior.Default)
                    If myDataReader.HasRows Then
                        myDataReader.Read()
                        InspecType = myDataReader.GetString("insp_type")
                    End If
                    myDataReader.Close()
                    .CommandText = "SELECT * FROM instr WHERE inspection_id = " & InspectionID
                    myDataReader = .ExecuteReader(CommandBehavior.Default)
                    If myDataReader.HasRows Then
                        Do While myDataReader.Read
                            Dim Instrument As New Instrument
                            Instrument.LoadFromDB(myDataReader.GetInt32("instr_id"))

                            If Instrument.InstrumentDriveType = DAM_Prover.Instrument.DriveType.Rotary Then
                                SizeCode = "MIN"
                                Select Case Instrument.Volume.MeterTypeNumber
                                    Case 1 Or 13    'Roots 2M LMMA or Romet RM2000
                                        SizeCode = "MMA"
                                    Case 2 Or 14    'Roots 3M LMMA or Romet RM3000
                                        SizeCode = "MMB"
                                    Case 3 Or 15    'Roots 5M LMMA or Romet RM5000
                                        SizeCode = "MMC"
                                    Case 4 Or 16    'Roots 7M LMMA or Romet RM7000
                                        SizeCode = "MMD"
                                    Case 5 Or 17    'Roots 11M LMMA or Romet RM11000
                                        SizeCode = "MME"
                                    Case 6 Or 18    'Roots 16M LMMA or Romet RM16000
                                        SizeCode = "MMF"
                                End Select
                            Else
                                SizeCode = "MIN"
                            End If
                            Dim Value = ",,"
                            If Instrument.GetItemValue(Instrument.FixedFactorItems.FixedPressure).value = Instrument.FixedFactors.Live And Instrument.GetItemValue(Instrument.FixedFactorItems.FixedTempFactor).value = Instrument.FixedFactors.Live Then
                                Value = "0.00" & "," & Format(Instrument.GetPressureObject(TestClass.PressureLevels.Mid).PercentError, "0.00") & "," & Format(Instrument.GetTemperatureObject(TestClass.TemperatureLevels.Mid).PercentError, "0.00")
                            ElseIf Instrument.GetItemValue(Instrument.FixedFactorItems.FixedTempFactor).value = Instrument.FixedFactors.Live Then
                                Value = Format(Instrument.GetTemperatureObject(TestClass.TemperatureLevels.Low).PercentError, "0.00") & "," & Format(Instrument.GetTemperatureObject(TestClass.TemperatureLevels.Mid).PercentError, "0.00") & "," & Format(Instrument.GetTemperatureObject(TestClass.TemperatureLevels.High).PercentError, "0.00")
                            End If
                            Dim txt As String = Instrument.GetItemValue(201).value & "," & Instrument.GetItemValue(62).value _
                                & "," & SizeCode & "," & Value & "," & Format(Date.Now(), "MM") & "/" & Format(Date.Now(), "dd") _
                                & "/" & Date.Now().Year() & "," & InspecType & "," & "74"
                            txtWriter.Write(txt)

                            If NewIC = True Then
                                txtWriter.Write("," & "13" & "," & "S3" & "," & "200701")
                            End If
                            txtWriter.WriteLine()
                        Loop
                        txtWriter.Flush()
                        txtWriter.Close()
                    End If
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub WriteNewEnbridgeCSVFile()
        NewIC = True
        WriteOldEnbridgeCSVFile()

    End Sub

    Public Sub WriteStandardCSVFile()
        Dim txtWriter As IO.StreamWriter

        Try
            Dim myDataReader As MySqlDataReader
            txtWriter = New IO.StreamWriter(StandardFileName)
            Dim InspecType As String = "N"
            Using mySqlCommand As New MySqlCommand
                With mySqlCommand
                    txtWriter.WriteLine("SerialNumber, Item200, Item201, Instr.Type, MeterType, Comp., " _
                                    & "Temp Low Error, Temp Mid Error, Temp High Error, " _
                                    & "Pressure Low Error, Pressure Mid Error, Pressure High Error," _
                                    & "Super Low Error, Super Mid Error, Super High Error," _
                                    & "UnCorrected Error, Corrected Error, " _
                                    & "Meter/Mech. Displacement, P. Range, T. Range, " _
                                    & "Firm. Ver., CorrectedMulti, UnCorrectedMulti, Prg.Atm, " _
                                    & "SG, N2, CO2, Base-P,  Base-T, FPV Method")
                    .Connection = db.OpenMySQL
                    .CommandText = "SELECT * FROM inspection_cert WHERE inspection_id = " & InspectionID
                    myDataReader = .ExecuteReader(CommandBehavior.Default)
                    If myDataReader.HasRows Then
                        myDataReader.Read()
                        InspecType = myDataReader.GetString("insp_type")
                    End If
                    myDataReader.Close()
                    .CommandText = "SELECT * FROM instr WHERE inspection_id = " & InspectionID
                    myDataReader = .ExecuteReader(CommandBehavior.Default)
                    If myDataReader.HasRows Then
                        Do While myDataReader.Read
                            Dim Instrument As New Instrument
                            Instrument.LoadFromDB(myDataReader.GetInt32("instr_id"))

                            Dim SerialNumber = Instrument.GetItemValue(62).value
                            Dim item200 = Instrument.GetItemValue(200).value
                            Dim Item201 = Instrument.GetItemValue(201).value
                            Dim InstrType = Instrument.InstrumentType.ToString
                            Instrument.Volume.MeterTypeNumber = Instrument.GetItemValue(432).value
                            Dim MeterType = Instrument.Volume.MeterTypeName
                            Dim Comp As String
                            If Instrument.LiveTemp = DAM_Prover.Instrument.FixedFactors.Live And Instrument.LivePressure = DAM_Prover.Instrument.FixedFactors.Live Then
                                Comp = "PTZ"
                            ElseIf Instrument.LivePressure = DAM_Prover.Instrument.FixedFactors.Live Then
                                Comp = "P"
                            ElseIf Instrument.LiveTemp = DAM_Prover.Instrument.FixedFactors.Live Then
                                Comp = "T"
                            End If

                            Dim LowTempError = Instrument.GetTemperatureObject(TestClass.TemperatureLevels.Low).PercentError
                            Dim MidTempError = Instrument.GetTemperatureObject(TestClass.TemperatureLevels.Mid).PercentError
                            Dim HighTempError = Instrument.GetTemperatureObject(TestClass.TemperatureLevels.High).PercentError

                            Dim LowPressureError = Instrument.GetPressureObject(TestClass.PressureLevels.Low).PercentError
                            Dim MidPressureError = Instrument.GetPressureObject(TestClass.PressureLevels.Mid).PercentError
                            Dim HighPressureError = Instrument.GetPressureObject(TestClass.PressureLevels.High).PercentError

                            Dim LowSuperError = Instrument.GetSuperObject(TestClass.SuperLevels.LowPHighT).CalculatePercentError
                            Dim MidSuperError = Instrument.GetSuperObject(TestClass.SuperLevels.MidPMidT).CalculatePercentError
                            Dim HighSuperError = Instrument.GetSuperObject(TestClass.SuperLevels.HighPLowT).CalculatePercentError

                            Dim UnCorrectedError = Instrument.Volume.UnCorrectedPercentError
                            Dim CorrectedError = Instrument.Volume.CorrectedPercentError

                            Dim MeterMechDisplacement = Instrument.Volume.MeterDisplacement
                            Dim FirmVer = Instrument.GetItemValue(122).value
                            Dim PRange = Instrument.GetItemValue(25).value
                            Dim TRange As String = "-40 to 150"
                            Dim CorrectedMulti = Instrument.Volume.CorrectedMultiplier
                            Dim UnCorrectedMulti = Instrument.Volume.UnCorrectedMultiplier
                            Dim PrgAtm = Instrument.GetItemValue(14).value
                            Dim SG = Instrument.GetItemValue(53).value
                            Dim N2 = Instrument.GetItemValue(54).value
                            Dim CO2 = Instrument.GetItemValue(55).value
                            Dim BaseT = Instrument.GetItemValue(34).value
                            Dim BaseP = Instrument.GetItemValue(13).value
                            Dim FPVMethod As String = "NX-19"

                            '"SerialNumber, CompanyNumber, Instr.Type, MeterType, Comp., " _
                            '        & "Temp Low Error, Temp Mid Error, Temp High Error, " _
                            '        & "Pressure Low Error, Pressure Mid Error, Pressure High Error," _
                            '        & "Super Low Error, Super Mid Error, Super High Error," _
                            '        & "UnCorrected Error, Corrected Error, " _
                            '        & "Meter/Mech. Displacement, P. Range, T. Range, " _
                            '        & "Firm. Ver., CorrectedMulti, UnCorrectedMulti, Prg.Atm, " _
                            '        & "SG, N2, CO2, Base-P,  Base-T, FPV Method")
                            txtWriter.WriteLine(SerialNumber & "," & item200 & "," & Item201 & "," & InstrType & "," & MeterType & "," & Comp & "," _
                                                         & LowTempError & "," & MidTempError & "," & HighTempError & "," _
                                                                & LowPressureError & "," & MidPressureError & "," & HighPressureError & "," _
                                                                & LowSuperError & "," & MidSuperError & "," & HighSuperError & "," _
                                                                & UnCorrectedError & "," & CorrectedError & "," _
                                                                & MeterMechDisplacement & "," & PRange & "," & TRange & "," _
                                                                & FirmVer & "," & CorrectedMulti & "," & UnCorrectedMulti & "," & PrgAtm & "," _
                                                                & SG & "," & N2 & "," & CO2 & "," & BaseP & "," & BaseT & "," & FPVMethod)
                        Loop
                    End If
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If Not txtWriter Is Nothing Then
                txtWriter.Flush()
                txtWriter.Close()
            End If
        End Try
    End Sub
End Class
