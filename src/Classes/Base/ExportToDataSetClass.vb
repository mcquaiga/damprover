Imports DAM_Prover.Instrument

Public Class ExportToDataSetClass

    'Private mySQL As New MySQLLibrary.Database
    Private aCustomer As Customer
    Private inspID As Integer
    Private db As New MySqlConnection
    Private sqlCommand As New MySqlCommand
    Dim ds As DataSet

    Dim instr_id As Integer = 0

    Sub New(ByVal InspectionID As Integer)
        inspID = InspectionID
    End Sub

    Public Sub FillDataSet(ByVal DataSet As DataSet)
        Dim ConfirmStatusCounter As Integer = 0
        Dim myDataReader As MySqlDataReader
        ds = DataSet
        Try
            If aCustomer Is Nothing Then
                Using mySQL As New MySQLLibrary.Database
                    Using mysqlcommand As New MySqlCommand
                        With mysqlcommand
                            .Connection = mySQL.OpenMySQL
                            .CommandText = "SELECT c.customer_id FROM customers c, inspection_cert i WHERE i.customer_id = c.customer_id AND i.inspection_id = " & Me.inspID
                            myDataReader = .ExecuteReader

                            'if no customer is found, should we quit the xml writer?
                            If myDataReader.HasRows Then
                                myDataReader.Read()
                                Dim customer As New Customer(myDataReader.GetInt32("customer_id"))
                                customer.LoadCustomerInformation()
                                Me.aCustomer = customer
                                myDataReader.Close()
                                AddCustomer()
                            End If

                        End With
                        myDataReader.Close()
                    End Using
                End Using
            End If

            Using mySQL As New MySQLLibrary.Database
                Using mySqlCommand As New MySqlCommand
                    With mySqlCommand
                        .Connection = mySQL.OpenMySQL
                        .CommandText = "SELECT * FROM instr WHERE inspection_id = " & inspID & " ORDER BY serial_number ASC"
                        myDataReader = .ExecuteReader(CommandBehavior.Default)
                        If myDataReader.HasRows Then
                            Do While myDataReader.Read
                                Dim Instrument As New Instrument
                                Instrument.LoadFromDB(myDataReader.GetInt32("instr_id"))
                                AddInstrument(Instrument)
                            Loop
                        End If
                        mySQL.CloseMySQL()
                    End With
                    myDataReader.Close()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub AddCustomer()
        Dim apparatusString As String = ""
        Dim myDataReader As MySqlDataReader
        Dim row As DataRow


        Try
            row = ds.Tables("Inspection_Certificate").NewRow

            row("InspectionID") = Me.inspID

            Using mySql As New MySQLLibrary.Database
                Using mysqlcommand As New MySqlCommand
                    With mysqlcommand
                        .Connection = mySql.OpenMySQL
                        .CommandText = "SELECT * FROM inspection_cert WHERE inspection_id = " & Me.inspID
                        myDataReader = .ExecuteReader
                        If myDataReader.HasRows Then
                            myDataReader.Read()
                            row("Event_Log") = myDataReader.GetBoolean("event_log")
                            row("Date") = myDataReader.GetString("date")
                            Try
                                row("InspType") = myDataReader.GetString("insp_type")
                            Catch ex As Exception
                                row("InspType") = ""
                            End Try

                            Try
                                row("Comments") = myDataReader.GetString("comments")
                            Catch ex As Exception
                                row("Comments") = ""
                            End Try
                        End If
                    End With
                    myDataReader.Close()
                End Using
            End Using

            Using mysql As New MySQLLibrary.Database
                Using mySqlcmd As New MySqlCommand

                    With mySqlcmd
                        .Connection = mysql.OpenMySQL
                        .CommandText = "SELECT * FROM inspection_equipement ie INNER JOIN equipement e ON ie.equip_id = e.id WHERE ie.inspec_id = " & inspID
                        myDataReader = .ExecuteReader
                        If myDataReader.HasRows() Then
                            Do While myDataReader.Read
                                apparatusString = apparatusString & myDataReader.GetString("code") & ","
                            Loop
                        End If
                        Try
                            apparatusString = apparatusString.Remove(apparatusString.Length - 1)
                        Catch ex As Exception
                            apparatusString = ""
                        End Try
                        row("Apparatus") = apparatusString

                        myDataReader.Close()
                    End With
                End Using
            End Using

            ds.Tables("Inspection_Certificate").Rows.Add(row)

            row = ds.Tables("Customer").NewRow
            row("Name") = aCustomer.CustomerName
            row("Address") = aCustomer.CustomerAddress
            row("PostalCode") = aCustomer.PostalCode
            row("RegNumber") = aCustomer.RegNumber

            ds.Tables("Customer").Rows.Add(row)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AddInstrument(ByVal Instrument As Instrument)
        Dim ConfirmStatusCounter As Integer

        Dim myItems = System.Enum.GetValues(GetType(ItemsEnum))
        Dim myVolume = System.Enum.GetValues(GetType(Volume.GeneralVolumeItems))
        Dim PT As String = ""  'Will hold whether the instrument is pressure, temp

        Dim row As DataRow

        instr_id += 1

        'row = ds.Tables("Instrument").NewRow
        'row("instrument_id") = instr_id
        'ds.Tables("instrument").Rows.Add(row
        ''''''''''''''''''''''''''Volume''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        row = ds.Tables("volume").NewRow
        row("id") = instr_id
        For Each item As Integer In myVolume
            row("Item" & CStr(item)) = CStr(Instrument.GetItemValue(item).value)
        Next
        row("AppliedInput") = CStr(Instrument.Volume.AppliedInput)
        row("CorrectedMultiplier") = CStr(Instrument.Volume.CorrectedMultiplier)
        row("CorrectedPercentError") = Math.Round(Instrument.Volume.CorrectedPercentError, 4)
        If Instrument.Volume.CorrectedPercentError < My.Settings.CorVolumeTolerance And Instrument.Volume.CorrectedPercentError > -(My.Settings.CorVolumeTolerance) Then
            ConfirmStatusCounter += 1
        End If

        'If Instrument.GetItemValue(Volume.GeneralVolumeItems.MeterIndexRate).value = 14 Then

        row("MeterDisplacement") = Instrument.GetItemValue(RotaryVolumeClass.GeneralVolumeItems.MeterDisplacement).value
        'row("DriveRate") = 0
        Instrument.Volume.MeterTypeNumber = CInt(Instrument.GetItemValue(RotaryVolumeClass.GeneralVolumeItems.MeterType).value)
        row("MeterType") = Instrument.Volume.MeterTypeName
        'Else
        'row("MeterDisplacement") = 0
        row("DriveRate") = Instrument.Volume.GetMeterIndexRate(Instrument.GetItemValue(Volume.GeneralVolumeItems.MeterIndexRate).value)
        'row("MeterType") = 0
        'End If
        row("EndCorrected") = CStr(Instrument.Volume.EndCorrected)
        row("EndUnCorrected") = CStr(Instrument.Volume.EvcUnCorrected)
        row("Fpv2Factor") = CStr(Instrument.Volume.Fpv2Factor)
        row("InputUncVolume") = CStr(Instrument.Volume.InputUncVolume)
        row("PressureFactor") = CStr(Instrument.Volume.PressureFactor)
        row("PulserA") = CStr(Instrument.Volume.PulserA)
        Dim PulseSelect As Instrument.PulseOutputValues
        PulseSelect = Instrument.GetItemValue(Instrument.PulseOutputItems.PulserA).value
        row("PulserASelect") = PulseSelect.ToString
        row("PulserB") = CStr(Instrument.Volume.PulserB)
        PulseSelect = Instrument.GetItemValue(Instrument.PulseOutputItems.PulserB).value
        row("PulserBSelect") = PulseSelect.ToString
        row("StartCorrected") = CStr(Instrument.Volume.StartCorrected)
        row("StartUnCorrected") = CStr(Instrument.Volume.StartUncorrected)

        If Instrument.InstrumentDriveType = Instrument.DriveType.Mechanical Then
            If Instrument.Energy.PercentError < 1 And Instrument.Energy.PercentError > -1 Then
                row("Energy") = "Y"
            Else
                row("Energy") = "N"
            End If

            If Instrument.Volume.MechanicalPass = True Then
                row("mech_unc") = "Y"
            Else
                row("mech_unc") = "N"
            End If
        Else
            row("energy") = "--"
            row("mech_unc") = "--"
        End If

        Dim APulses As Integer
        Dim BPulses As Integer
        If Instrument.PulseASelect = Instrument.PulseOutputValues.CorVol Then
            APulses = Int(Instrument.Volume.EndCorrected)
        ElseIf Instrument.PulseASelect = Instrument.PulseOutputValues.UncVol Then
            APulses = Int(Instrument.Volume.EndUnCorrected)
        End If

        If Instrument.PulseBSelect = Instrument.PulseOutputValues.CorVol Then
            BPulses = Int(Instrument.Volume.EndCorrected)
        ElseIf Instrument.PulseBSelect = Instrument.PulseOutputValues.UncVol Then
            BPulses = Int(Instrument.Volume.EndUnCorrected)
        End If

        Dim ADifference = Math.Abs(APulses - Instrument.Volume.PulserA)
        Dim BDifference = Math.Abs(BPulses - Instrument.Volume.PulserB)

        If ADifference < 3 And BDifference < 3 Then
            row("pulses_accepted") = "Y"
            ConfirmStatusCounter += 1
        Else
            row("pulses_accepted") = "N"
        End If

        Try
            If Instrument.GetItemValue(Instrument.FixedFactorItems.FixedTempFactor).value = Instrument.FixedFactors.Live Then
                row("TempFactor") = Instrument.GetTemperatureObject(TestClass.TemperatureLevels.Low).TemperatureFactor
            Else
                row("TempFactor") = 0
            End If
        Catch ex As Exception
            row("TempFactor") = 0
        End Try

        Try
            If Instrument.GetItemValue(Instrument.FixedFactorItems.FixedPressure).value = Instrument.FixedFactors.Live Then
                row("PressureFactor") = Instrument.GetPressureObject(TestClass.PressureLevels.High).ActualPressureFactor
            Else
                row("PressureFactor") = 0
            End If
        Catch ex As Exception
            row("PressureFactor") = 0
        End Try
        row("TrueCorrected") = CStr(Instrument.Volume.TrueCorrected)
        row("UnCorrectedMultiplier") = CStr(Instrument.Volume.UnCorrectedMultiplier)
        row("UnCorrectedPercentError") = Math.Round(Instrument.Volume.UnCorrectedPercentError, 4)
        If Instrument.Volume.UnCorrectedPercentError < My.Settings.UncVolumeTolerance And Instrument.Volume.UnCorrectedPercentError > -(My.Settings.UncVolumeTolerance) Then
            ConfirmStatusCounter += 1
        End If
        'EndVolume
        ds.Tables("volume").Rows.Add(row)
        '''''''''''''''''''''''''''''Volume'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        '''''''''''''''''''Temp'''''''''''''''''''''''''''''''''''''''''
        row = ds.Tables("Temperature").NewRow
        row("id") = instr_id
        For Each item As Integer In System.Enum.GetValues(GetType(TemperatureClass.TemperatureItems))
            row("Item" & CStr(item)) = CStr(Instrument.GetItemValue(item).value)
        Next

        Dim x As Integer = 1

        Try
            If Instrument.LiveTemp = Instrument.FixedFactors.Live Then
                PT = "T"
                If Instrument.GetTemperatureObject(TestClass.TemperatureLevels.Low).TemperatureUnits = TemperatureClass.UnitsEnum.F Then
                    row("TRange") = "-40 to 150 F"
                ElseIf Instrument.GetTemperatureObject(TestClass.TemperatureLevels.Low).TemperatureUnits = TemperatureClass.UnitsEnum.C Then
                    row("TRange") = "-40 to 76 C"
                End If
                For Each item As TemperatureClass In Instrument.Temperatures
                    row("Temp" & x) = Math.Round(item.PercentError, 3)
                    If item.PercentError < My.Settings.TemperatureTolerance And item.PercentError > -(My.Settings.TemperatureTolerance) Then
                        ConfirmStatusCounter += 1
                    End If
                    x += 1
                Next
            Else
                Do While x <= 3
                    row("Temp" & x) = -999
                    x += 1
                Loop
            End If
            ds.Tables("temperature").Rows.Add(row)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        ''''''''''''''''''''''''''''Temp''''''''''''''''''''''''''''''''''''''''

        x = 1

        '''''''''''''''''Pressure''''''''''''''''''''''''''''''''''''''''''''''''
        Try
            row = ds.Tables("Pressure").NewRow
            row("id") = instr_id
            If Instrument.LivePressure = Instrument.FixedFactors.Live Then
                For Each item As Integer In System.Enum.GetValues(GetType(PressureFactorClass.PressureItemsEnum))
                    row("Item" & CStr(item)) = CStr(Instrument.GetItemValue(item).value)
                Next
                x = 1
                PT = "P" & PT
                If Instrument.GetPressureObject(TestClass.PressureLevels.High).PressureUnits = PressureFactorClass.UnitsEnum.PSIA Or Instrument.GetPressureObject(TestClass.PressureLevels.High).PressureUnits = PressureFactorClass.UnitsEnum.PSIG Then
                    row("PRange") = FormatNumber(Instrument.GetPressureObject(TestClass.PressureLevels.High).Convert(Instrument.GetItemValue(25).value), 0) _
                                           & " " & Left(Instrument.GetPressureObject(TestClass.PressureLevels.High).PressureUnits.ToString, 1)
                Else
                    row("PRange") = FormatNumber(Instrument.GetPressureObject(TestClass.PressureLevels.High).Convert(Instrument.GetItemValue(25).value), 0) _
                                            & " " & Instrument.GetPressureObject(TestClass.PressureLevels.High).PressureUnits.ToString _
                                            & " " & Left(Instrument.GetPressureObject(TestClass.PressureLevels.High).Transducer.ToString, 1)
                End If
                For Each item As PressureFactorClass In Instrument.Pressures
                    row("Pressure" & x) = Math.Round(item.PercentError(), 4)

                    If item.PercentError < My.Settings.PressureTolerance And item.PercentError > -(My.Settings.PressureTolerance) Then
                        ConfirmStatusCounter += 1
                    End If
                    x += 1
                Next
            Else
                For Each item As Integer In System.Enum.GetValues(GetType(PressureFactorClass.PressureItemsEnum))
                    row("Item" & CStr(item)) = 0
                Next
                row("PRange") = "N/A"
                Do While x <= 3
                    row("Pressure" & x) = -999
                    x += 1
                Loop
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        ds.Tables("pressure").Rows.Add(row)

        'End Pressure

        ''''''''''''''''''''''''''''''Pressure'''''''''''''''''''''''''''''''''''

        ''''''''''''''''''''''''''''Super Factors'''''''''''''''''''''''''''''''
        row = ds.Tables("SuperFactor").NewRow
        row("id") = instr_id
        If Instrument.LivePressure = Instrument.FixedFactors.Live And Instrument.LiveTemp = Instrument.FixedFactors.Live Then
            For Each item As Integer In System.Enum.GetValues(GetType(SuperFactorClass.SuperFactorItems))
                row("Item" & CStr(item)) = CStr(Instrument.GetItemValue(item).value)
            Next
            Dim SuperTable As SuperFactorClass.SuperTables
            SuperTable = Instrument.GetItemValue(Instrument.ItemsEnum.SuperTable).value
            row("SuperTable") = SuperTable.ToString
            x = 1

            For Each item As SuperFactorClass In Instrument.SuperFactors
                row("Super" & x) = Math.Round(item.CalculatePercentError, 4)

                If item.CalculatePercentError < My.Settings.SuperTolerance And item.CalculatePercentError > -(My.Settings.SuperTolerance) Then
                    ConfirmStatusCounter += 1
                End If
                x += 1
            Next
        Else
            For Each item As Integer In System.Enum.GetValues(GetType(SuperFactorClass.SuperFactorItems))
                row("Item" & CStr(item)) = 0
            Next
            x = 1
            Do While x <= 3
                row("Super" & x) = -999
                x += 1
            Loop
            row("SuperTable") = "N/A"
        End If
        ds.Tables("SuperFactor").Rows.Add(row)
        ''''''''''''''''''''''''''''''SuperFactors'''''''''''''''''''''''''''

        '''''''''General ITems

        row = ds.Tables("general").NewRow
        row("id") = instr_id
        ' Write XML data.
        For Each item As Integer In myItems
            row("Item" & CStr(item)) = CStr(Instrument.GetItemValue(item).value)
        Next
        If ConfirmStatusCounter = 6 Then
            row("ConfirmedStatus") = "PASS"
        ElseIf ConfirmStatusCounter = 12 Then
            row("ConfirmedStatus") = "PASS"
        Else
            row("ConfirmedStatus") = "FAIL"
        End If
        Instrument.InstrumentType = Instrument.GetItemValue(127).value
        row("InstrumentType") = Instrument.InstrumentType.ToString
        If Instrument.InstrumentDriveType = Instrument.DriveType.Rotary Then
            row("InstrumentType") = Instrument.InstrumentType.ToString & vbNewLine & Instrument.InstrumentDriveType.ToString
        End If
        row("PT") = PT

        ds.Tables("general").Rows.Add(row)
        ''''''''''''End General''''''''''''''''''''''
        OutputDataSetAsXML(ds)

        ds.Dispose()

    End Sub

    Private Sub OutputDataSetAsXML(ByRef dsSource As System.Data.DataSet)
        Dim xmlSchema As String = "schema.xml"
        Dim xml_file As String = "dataset_.xml"

        ' setup response
        dsSource.WriteXmlSchema(xmlSchema)
        dsSource.WriteXml(xml_file)

    End Sub


End Class