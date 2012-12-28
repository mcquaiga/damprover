Imports MySql.Data.MySqlClient
Imports System.Xml

Public Class XMLWriterClass

    'Creates an XML file with all the instruments from the requested Inspection Certificate
    Dim GeneralItems As Array

    Private mySQL As New MySQLLibrary.Database
    Private db As New MySqlConnection
    Private sqlCommand As New MySqlCommand

    Private settings As New XmlWriterSettings()
    Private writer As XmlWriter
    Private xInspectionID As Integer
    Private xCustomer As Customer

    Sub New(ByVal InspectionID As Integer)
        settings.Indent = True
        settings.IndentChars = "    "
        writer = XmlWriter.Create(Application.StartupPath & "\ic3.xml", settings)

        db = mySQL.OpenMySQL

        Me.InspectionID = InspectionID
    End Sub

    Sub New(ByVal Customer As Customer, ByVal InspectionID As Integer)
        Me.New(InspectionID)
        Customer = Customer
    End Sub

    Public Property InspectionID() As Integer
        Get
            Return xInspectionID
        End Get
        Set(ByVal value As Integer)
            xInspectionID = value
        End Set
    End Property

    Public Property Customer() As Customer
        Get
            Return xCustomer
        End Get
        Set(ByVal value As Customer)
            xCustomer = value
        End Set
    End Property

    Public Sub LoadInstrumentsAndWriteXML()
        Dim myDataReader As MySqlDataReader

        Try
            If Customer Is Nothing Then
                Using mysqlcommand As New MySqlCommand
                    With mysqlcommand
                        .Connection = db
                        .CommandText = "SELECT c.customer_id FROM customers c, instr i WHERE i.customer_id = c.customer_id AND i.inspection_id = " & Me.InspectionID
                        myDataReader = .ExecuteReader

                        'if no customer is found, should we quit the xml writer?
                        If myDataReader.HasRows Then
                            myDataReader.Read()
                            Dim customer As New Customer(myDataReader.GetInt32("customer_id"))
                            customer.LoadCustomerInformation()
                            Me.Customer = customer
                        End If
                        .Connection.Close()
                        .Connection.Dispose()
                    End With
                    myDataReader.Close()
                End Using
            End If
            StartXML()
            Using mySqlCommand As New MySqlCommand
                With mySqlCommand
                    .Connection = db
                    .CommandText = "SELECT * FROM instr WHERE inspection_id = " & InspectionID
                    myDataReader = .ExecuteReader(CommandBehavior.Default)

                    If myDataReader.HasRows Then
                        Do While myDataReader.Read
                            Dim Instrument As New Instrument
                            Instrument.LoadFromDB(myDataReader.GetInt32("instr_id"))
                            WriteNode(Instrument)
                        Loop
                    End If
                    .Connection.Close()
                    .Connection.Dispose()
                End With

                writer.WriteEndElement()
                writer.WriteEndDocument()
                writer.Flush()
                writer.Close()

            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub StartXML()
        Dim myDataReader As MySqlDataReader

        writer.WriteStartDocument()
        writer.WriteStartElement("InspectionCertificate")
        writer.WriteElementString("InspectionID", Me.InspectionID)

        Using mysqlcommand As New MySqlCommand
            With mysqlcommand
                .Connection = db
                .CommandText = "SELECT * FROM inspection_cert WHERE inspection_id = " & Me.InspectionID
                myDataReader = .ExecuteReader
                If myDataReader.HasRows Then
                    myDataReader.Read()
                    writer.WriteElementString("Apparatus", myDataReader.GetString("apparatus"))
                    writer.WriteElementString("Date", myDataReader.GetString("date"))
                End If
            End With
            myDataReader.Close()
        End Using

        writer.WriteStartElement("Customer")

        writer.WriteElementString("Name", Customer.CustomerName)
        writer.WriteElementString("Address", Customer.CustomerAddress)
        writer.WriteElementString("PostalCode", Customer.PostalCode)
        writer.WriteElementString("RegNumber", Customer.RegNumber)

        writer.WriteEndElement()

    End Sub

    Public Sub WriteNode(ByVal Instrument As Instrument)


        'This will count when we have an item that passes
        'If the instrument is temperature this value will only be 5, same thing for the pressure
        'If it is a PT then it will be 11
        Dim ConfirmStatusCounter As Integer


        Dim myItems = System.Enum.GetValues(GetType(DAM_Prover.Instrument.ItemsEnum))
        Dim myVolume = System.Enum.GetValues(GetType(DAM_Prover.Volume.GeneralVolumeItems))
        Dim PT As String = ""  'Will hold whether the instrument is pressure, temp
        With writer
            .WriteStartElement("instrument")

            '''''''''''''''''''''''''''Volume''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            .WriteStartElement("volume")
            For Each item As Integer In myVolume
                .WriteElementString("Item" & CStr(item), CStr(Instrument.GetItemValue(item).value))
            Next
            .WriteElementString("ApppliedInput", CStr(Instrument.Volume.AppliedInput))
            .WriteElementString("CorrectedMultiplier", CStr(Instrument.Volume.CorrectedMultiplier))
            .WriteElementString("CorrectedPercentError", Math.Round(Instrument.Volume.CorrectedPercentError, 4))
            If Instrument.Volume.CorrectedPercentError < 1 And Instrument.Volume.CorrectedPercentError > -1 Then
                ConfirmStatusCounter += 1
            End If
            If Instrument.GetItemValue(Volume.GeneralVolumeItems.MeterIndexRate).value = 14 Then
                .WriteElementString("MeterDisplacement", Instrument.GetItemValue(RotaryVolumeClass.GeneralVolumeItems.MeterDisplacement).value)
                .WriteElementString("DriveRate", 0)
                Instrument.Volume.MeterTypeNumber = Instrument.GetItemValue(RotaryVolumeClass.GeneralVolumeItems.MeterType).value
                .WriteElementString("MeterType", Instrument.Volume.MeterTypeName)
            Else
                .WriteElementString("MeterDisplacement", 0)
                .WriteElementString("DriveRate", Instrument.Volume.GetMeterIndexRate(Instrument.GetItemValue(Volume.GeneralVolumeItems.MeterIndexRate).value))
                .WriteElementString("MeterType", 0)
            End If
            .WriteElementString("EndCorrected", CStr(Instrument.Volume.EndCorrected))
            .WriteElementString("EndUnCorrected", CStr(Instrument.Volume.EvcUnCorrected))
            .WriteElementString("Fpv2Factor", CStr(Instrument.Volume.Fpv2Factor))
            .WriteElementString("InputUncVolume", CStr(Instrument.Volume.InputUncVolume))
            .WriteElementString("PressureFactor", CStr(Instrument.Volume.PressureFactor))
            .WriteElementString("PulserA", CStr(Instrument.Volume.PulserA))
            Dim PulseSelect As Instrument.PulseOutputValues
            PulseSelect = Instrument.GetItemValue(Instrument.PulseOutputItems.PulserA).value
            .WriteElementString("PulserASelect", PulseSelect.ToString)
            .WriteElementString("PulserB", CStr(Instrument.Volume.PulserB))
            PulseSelect = Instrument.GetItemValue(Instrument.PulseOutputItems.PulserB).value
            .WriteElementString("PulserBSelect", PulseSelect.ToString)
            .WriteElementString("StartCorrected", CStr(Instrument.Volume.StartCorrected))
            .WriteElementString("StartUnCorrected", CStr(Instrument.Volume.StartUncorrected))

            Try
                If Instrument.GetItemValue(Instrument.FixedFactorItems.FixedTempFactor).value = Instrument.FixedFactors.Live Then
                    .WriteElementString("TempFactor", Instrument.GetTemperatureObject(TestClass.TemperatureLevels.Low).TemperatureFactor)
                Else
                    .WriteElementString("TempFactor", 0)
                End If
            Catch ex As Exception
                .WriteElementString("TempFactor", 0)
            End Try

            Try
                If Instrument.GetItemValue(Instrument.FixedFactorItems.FixedPressure).value = Instrument.FixedFactors.Live Then
                    .WriteElementString("PressureFactor", Instrument.GetPressureObject(TestClass.PressureLevels.High).ActualPressureFactor)
                Else
                    .WriteElementString("PressureFactor", 0)
                End If
            Catch ex As Exception
                .WriteElementString("PressureFactor", 0)
            End Try
            .WriteElementString("TrueCorrected", CStr(Instrument.Volume.TrueCorrected))
            .WriteElementString("UnCorrectedMultiplier", CStr(Instrument.Volume.UnCorrectedMultiplier))
            .WriteElementString("UnCorrectedPercentError", Math.Round(Instrument.Volume.UnCorrectedPercentError, 4))
            If Instrument.Volume.UnCorrectedPercentError < 1 And Instrument.Volume.UnCorrectedPercentError > -1 Then
                ConfirmStatusCounter += 1
            End If
            'EndVolume
            .WriteEndElement()
            '''''''''''''''''''''''''''''Volume'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            '''''''''''''''''''Temp'''''''''''''''''''''''''''''''''''''''''
            .WriteStartElement("Temperature")
            For Each item As Integer In System.Enum.GetValues(GetType(DAM_Prover.TemperatureClass.TemperatureItems))
                .WriteElementString("Item" & CStr(item), CStr(Instrument.GetItemValue(item).value))
            Next

            Dim x As Integer = 1

            Try
                If Instrument.GetItemValue(Instrument.FixedFactorItems.FixedTempFactor).value = Instrument.FixedFactors.Live Then
                    PT = "T"
                    .WriteElementString("TRange", Instrument.GetTemperatureObject(TestClass.TemperatureLevels.Low).Convert(-40) & " to " _
                                & Instrument.GetTemperatureObject(TestClass.TemperatureLevels.Low).Convert(150) & " " _
                                & Instrument.GetTemperatureObject(TestClass.TemperatureLevels.Low).TemperatureUnits.ToString)
                    For Each item As TemperatureClass In Instrument.Temperatures
                        .WriteStartElement("Temp" & x)
                        .WriteElementString("TempPercError", Math.Round(item.PercentError, 3))
                        If item.PercentError < 1 And item.PercentError > -1 Then
                            ConfirmStatusCounter += 1
                        End If
                        '.WriteElementString("EVCTemperature", CStr(item.EVCTemperature))
                        '.WriteElementString("GaugeTemperature", CStr(item.GaugeTemperature))
                        '.WriteElementString("EVCFactor", CStr(item.EvcFactor))
                        '.WriteElementString("TempFactor", CStr(item.))
                        '.WriteElementString("TempUnits", item.TemperatureUnits.ToString)
                        .WriteEndElement()
                        x += 1
                    Next
                Else
                    Do While x <= 3
                        .WriteStartElement("Temp" & x)
                        .WriteElementString("TempPercError", "Fixed")
                        .WriteEndElement()
                        x += 1
                    Loop
                End If
                .WriteEndElement()
            Catch ex As Exception
                Do While x <= 3
                    .WriteStartElement("Temp" & x)
                    .WriteElementString("TempPercError", "Fixed")
                    .WriteEndElement()
                    x += 1
                Loop
            End Try
            ''''''''''''''''''''''''''''Temp''''''''''''''''''''''''''''''''''''''''


            '''''''''''''''''Pressure''''''''''''''''''''''''''''''''''''''''''''''''
            Try
                .WriteStartElement("Pressure")
                For Each item As Integer In System.Enum.GetValues(GetType(DAM_Prover.PressureFactorClass.PressureItemsEnum))
                    .WriteElementString("Item" & CStr(item), CStr(Instrument.GetItemValue(item).value))
                Next
                x = 1
                If Instrument.InstrumentType <> miSerialProtocol.InstrumentTypeCode.TCI Or _
                    Instrument.GetItemValue(Instrument.FixedFactorItems.FixedPressure).value = Instrument.FixedFactors.Live Then
                    PT = "P" & PT
                    .WriteElementString("PRange", Instrument.GetPressureObject(TestClass.PressureLevels.High).Convert(Instrument.GetItemValue(25).value) _
                                           & " " & Instrument.GetPressureObject(TestClass.PressureLevels.High).PressureUnits.ToString _
                                           & " " & Instrument.GetPressureObject(TestClass.PressureLevels.High).Transducer.ToString)

                    For Each item As PressureFactorClass In Instrument.Pressures
                        .WriteStartElement("Pressure" & x)
                        .WriteElementString("PressurePercentError", Math.Round(item.PercentError(), 4))
                        If item.PercentError < 1 And item.PercentError > -1 Then
                            ConfirmStatusCounter += 1
                        End If
                        '.WriteElementString("EVCPressure", CStr(item.EvcPressure))
                        '.WriteElementString("GaugePressure", CStr(item.GaugePressure))
                        '.WriteElementString("EVCFactor", CStr(item.EVCFactor))
                        '.WriteElementString("PressureFactor", CStr(item.ActualPressureFactor))
                        '.WriteElementString("PressureUnits", item.PressureUnits.ToString)
                        '.WriteElementString("Transducer", item.Transducer.ToString)
                        '.WriteElementString("ATMPressure", item.AtmosphericPressure)
                        '.WriteElementString("EvcUnsqrSuper", item.EVCUnsqrSuper)
                        .WriteEndElement()
                        x += 1
                    Next
                Else
                    Do While x <= 3
                        .WriteStartElement("Pressure" & x)
                        .WriteElementString("PressurePercentError", "Fixed")
                        .WriteEndElement()
                        x += 1
                    Loop
                End If
            Catch ex As Exception
                Do While x <= 3
                    .WriteStartElement("Pressure" & x)
                    .WriteElementString("PressurePercentError", "Fixed")
                    .WriteEndElement()
                    x += 1
                Loop
            End Try
            .WriteEndElement()

            'End PRessure

                    ''''''''''''''''''''''''''''''Pressure'''''''''''''''''''''''''''''''''''

                    ''''''''''''''''''''''''''''Super Factors'''''''''''''''''''''''''''''''
                    .WriteStartElement("SuperFactor")
                    For Each item As Integer In System.Enum.GetValues(GetType(DAM_Prover.SuperFactorClass.SuperFactorItems))
                        .WriteElementString("Item" & CStr(item), CStr(Instrument.GetItemValue(item).value))
                    Next
                    Dim SuperTable As SuperFactorClass.SuperTables
                    SuperTable = Instrument.GetItemValue(Instrument.ItemsEnum.SuperTable).value
                    .WriteElementString("SuperTable", SuperTable.ToString)

                    x = 1


                    If Instrument.GetItemValue(Instrument.FixedFactorItems.FixedPressure).value = Instrument.FixedFactors.Live _
                        And Instrument.GetItemValue(Instrument.FixedFactorItems.FixedTempFactor).value = Instrument.FixedFactors.Live Then
                        For Each item As SuperFactorClass In Instrument.SuperFactors
                            .WriteStartElement("Super" & x)
                            .WriteElementString("SuperPercentError", Math.Round(item.CalculatePercentError, 4))
                            If item.CalculatePercentError < 1 And item.CalculatePercentError > -1 Then
                                ConfirmStatusCounter += 1
                            End If
                            .WriteEndElement()
                            x += 1
                        Next
                    Else
                        Do While x <= 3
                            .WriteStartElement("Super" & x)
                            .WriteElementString("SuperPercentError", "Fixed")
                            .WriteEndElement()
                            x += 1
                        Loop
                    End If
                    .WriteEndElement()
                    ''''''''''''''''''''''''''''''SuperFactors'''''''''''''''''''''''''''

                    '''''''''General ITems

                    .WriteStartElement("general")
                    ' Write XML data.
                    For Each item As Integer In myItems
                        .WriteElementString("Item" & CStr(item), CStr(Instrument.GetItemValue(item).value))
                    Next
                    If ConfirmStatusCounter = 5 Then
                        .WriteElementString("ConfirmedStatus", "PASS")
                    ElseIf ConfirmStatusCounter = 11 Then
                        .WriteElementString("ConfirmedStatus", "PASS")
                    Else
                        .WriteElementString("ConfirmedStatus", "FAIL")
                    End If
                    Instrument.InstrumentType = Instrument.GetItemValue(127).value
                    .WriteElementString("InstrumentType", Instrument.InstrumentType.ToString)
                    .WriteElementString("PT", PT)
                    .WriteEndElement()
                    ''''''''''''End General''''''''''''''''''''''

                    'End Instrument
                    .WriteEndElement()


        End With

    End Sub
End Class
