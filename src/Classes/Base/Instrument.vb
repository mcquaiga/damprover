Imports DamProverModel
Imports miSerialProtocol
Public Class Instrument
    Implements IDisposable

#Region "Enums"
    Public Enum ItemsEnum
        SerialNumber = 62
        BasePressure = 13
        AtmosphericPressure = 14
        BaseTemp = 34
        PressureUnits = 87
        TempUnits = 89
        TransducerType = 112
        Firmware = 122
        SuperTable = 147
        CompanyNumber1 = 200
        CompanyNumber2 = 201

    End Enum

    Public Enum PulseOutputItems
        PulserA = 93
        PulserB = 94
    End Enum

    Public Enum PulseOutputValues
        CorVol = 0
        PCorVol = 1
        UncVol = 2
        NoOut = 3
        Time = 4
    End Enum

    Public Enum FixedFactorItems
        FixedPressure = 109
        FixedSuperFactor = 110
        FixedTempFactor = 111
    End Enum

    Public Enum FixedFactors
        Live = 0
        Fixed = 1
        Super = 2
    End Enum

    Public Enum DriveType
        Rotary = 1
        Mechanical = 2
    End Enum

    Public Enum DateFormat
        MMDDYY = 0
        DDMMYY = 1
        YYMMDD = 2
    End Enum
#End Region


    'This is the base class for all the Mercury Instruments
    'Seperate classes for each instrument must be created and inherited from this class
    'Only the properties and methods common to all instruments are created in this class
    'i.e. Mini-Max Rotary has Proving modes that must be set before testing

    'This class is responsible for holding values downloaded from the instrument and Temperature and Pressure Classes

    ' Private sqlCommand As New MySqlCommand
    Public Shared Event TotalItems(ByVal Total As Integer)
    Public Shared Event ItemStored(ByVal ItemNumber As Integer)

    Private tPulseASelect As PulseOutputValues
    Private tPulseBSelect As PulseOutputValues
    Protected iSerial As miSerialProtocol.miSerialProtocolClass
    Protected iCustomer As Customer
    Protected iID As Integer
    Protected iTemp As New Collection
    Protected iPressure As New Collection
    Protected iVolume As New Volume
    Protected iSuperFactors As New Collection
    Protected iAllItemNumbers As New Collection
    Protected iAllItemDesc As New Collection
    Protected iAllItemValues As New Collection
    Protected iLiveTemp As FixedFactors
    Protected iLivePressure As FixedFactors
    Protected iLiveSuper As FixedFactors
    Protected iDriveType As DriveType
    Protected iEnergy As EnergyClass

    Protected iInstrumentType As miSerialProtocol.InstrumentTypeCode

    Sub New()

    End Sub
    Sub New(ByVal InstrumentType As miSerialProtocol.InstrumentTypeCode)
        Me.InstrumentType = InstrumentType
    End Sub
    Public Overloads Sub Dispose() Implements IDisposable.Dispose
        Dispose(True)
        ' Take yourself off of the finalization queue
        ' to prevent finalization code for this object
        ' from executing a second time.
        GC.SuppressFinalize(Me)
    End Sub
    Protected Overridable Overloads Sub Dispose(ByVal disposing As Boolean)
        'clean up our resources
        If (disposing) Then
            'mySQL.Dispose()
            If Not Me.InstrumentSrl Is Nothing Then
                InstrumentSrl.Dispose()
            End If
            Me.AllItems.Clear()
            iPressure.Clear()
            iTemp.Clear()
            iVolume = Nothing
            iSuperFactors.Clear()
        End If

    End Sub

#Region "Properties"
    Public Property InstrumentID() As Integer
        Get
            Return iID
        End Get
        Set(ByVal value As Integer)
            iID = value
        End Set
    End Property

    Public Property Customer() As Customer
        Get
            Return iCustomer
        End Get
        Set(ByVal value As Customer)
            iCustomer = value
        End Set
    End Property

    Public Overridable Property InstrumentSrl() As miSerialProtocol.miSerialProtocolClass
        Get
            Return Me.iSerial
        End Get
        Set(ByVal value As miSerialProtocol.miSerialProtocolClass)
            iSerial = value
        End Set
    End Property

    Public Property InstrumentType() As miSerialProtocol.InstrumentTypeCode
        Get
            Return iInstrumentType
        End Get
        Set(ByVal value As miSerialProtocol.InstrumentTypeCode)
            iInstrumentType = value
        End Set
    End Property

    Public Property InstrumentDriveType() As DriveType
        Get
            Return iDriveType
        End Get
        Set(ByVal value As DriveType)
            iDriveType = value
        End Set
    End Property

    Public Property AllItems() As Collection
        Get
            Return iAllItemNumbers
        End Get
        Set(ByVal value As Collection)
            iAllItemNumbers = value
        End Set
    End Property

    Public Property SuperFactors() As Collection
        Get
            Return iSuperFactors
        End Get
        Set(ByVal value As Collection)
            iSuperFactors = value
        End Set
    End Property

    Public ReadOnly Property LiveTemp() As FixedFactors
        Get
            Return Me.GetItemValue(FixedFactorItems.FixedTempFactor).value
        End Get
    End Property

    Public Property Temperatures() As Collection
        Get
            Return iTemp
        End Get
        Set(ByVal value As Collection)
            iTemp = value
        End Set
    End Property

    Public ReadOnly Property GetTemperatureObject(ByVal Index As TestClass.TemperatureLevels) As TemperatureClass
        Get
            Try
                Return iTemp.Item(Index)
            Catch ex As IndexOutOfRangeException
                Dim temp As New TemperatureClass
                Return temp
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try

        End Get
    End Property

    Public ReadOnly Property GetPressureObject(ByVal Index As TestClass.PressureLevels) As PressureFactorClass
        Get
            Try
                Return iPressure(Index)
            Catch ex As IndexOutOfRangeException
                Dim pressure As New PressureFactorClass
                Return pressure
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Get
    End Property

    Public ReadOnly Property GetSuperObject(ByVal index As TestClass.SuperLevels) As SuperFactorClass
        Get
            Try
                Return iSuperFactors(index)
            Catch ex As IndexOutOfRangeException
                Dim supers As New SuperFactorClass
                Return supers
            Catch ex As Exception
                Throw New Exception(ex.Message, ex)

            End Try
        End Get
    End Property

    Public ReadOnly Property LiveSuper() As FixedFactors
        Get
            If InstrumentType = miSerialProtocol.InstrumentTypeCode.TCI Then
                Return FixedFactors.Fixed
            Else
                Return Me.GetItemValue(FixedFactorItems.FixedSuperFactor).value
            End If
        End Get
    End Property

    Public ReadOnly Property LivePressure() As FixedFactors
        Get
            If InstrumentType = miSerialProtocol.InstrumentTypeCode.TCI Then
                Return FixedFactors.Fixed
            Else
                Return Me.GetItemValue(FixedFactorItems.FixedPressure).value
            End If
        End Get
    End Property

    Public Property Pressures() As Collection
        Get
            Return iPressure
        End Get
        Set(ByVal value As Collection)
            iPressure.Add(value)
        End Set
    End Property

    Public Overridable Property Volume() As Volume
        Get
            Return iVolume
        End Get
        Set(ByVal value As Volume)
            iVolume = value
        End Set
    End Property

    Public Overridable Property PulseASelect() As Instrument.PulseOutputValues
        Get
            Return tPulseASelect
        End Get
        Set(ByVal value As Instrument.PulseOutputValues)
            tPulseASelect = value
        End Set
    End Property

    Public Overridable Property PulseBSelect() As Instrument.PulseOutputValues
        Get
            Return tPulseBSelect
        End Get
        Set(ByVal value As Instrument.PulseOutputValues)
            tPulseBSelect = value
        End Set
    End Property

    Public Overridable Property Energy() As EnergyClass
        Get
            Return iEnergy
        End Get
        Set(ByVal value As EnergyClass)
            iEnergy = value
        End Set
    End Property
#End Region

#Region "Methods"

    Public Overridable Sub Connect()
        InstrumentSrl.Connect()
    End Sub

    Public Overridable Sub Disconnect()
        InstrumentSrl.Disconnect()
    End Sub

    Public Overridable Function DownloadItems(ByVal Items As Collection) As Collection
        Dim ItemValues As New Collection
        Dim x As Integer = 1

        InstrumentSrl.RG(Items, ItemValues)

        Return ItemValues
    End Function

    Public Overridable Function LiveRead(ByVal ItemNumber As Integer) As Double
        If Not IsNothing(InstrumentSrl) Then
            Return InstrumentSrl.LR(ItemNumber)
        Else
            Return 0
        End If

    End Function

    Public Function SetInstrumentDateTime()
        Dim DateFormat As DateFormat
        Dim CurrentDate As Date = My.Computer.Clock.LocalTime
        Dim NewDate As String = ""
        Dim miErr As miSerialProtocol.InstrumentErrorsEnum

        Try
            'Get Date format from instrument (YY-MM-DD, MM-DD-YY
            DateFormat = InstrumentSrl.RD(262)
            If DateFormat = Instrument.DateFormat.DDMMYY Then
                NewDate = Format(CurrentDate, "dd-MM-yy")
            ElseIf DateFormat = Instrument.DateFormat.MMDDYY Then
                NewDate = Format(CurrentDate, "MM-dd-yy")
            ElseIf DateFormat = Instrument.DateFormat.YYMMDD Then
                NewDate = Format(CurrentDate, "yy-MM-dd")
            End If

            miErr = InstrumentSrl.WD(204, NewDate)

            If miErr <> miSerialProtocol.InstrumentErrorsEnum.NoError Then Throw New Exception(miErr.ToString)

            NewDate = Format(CurrentDate, "HH mm ss")
            miErr = InstrumentSrl.WD(203, NewDate)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    'The Items collection that is passed into this function MUST have keys that hold the item while the value of the collection is the value
    'to reset the item to
    Public Function WriteItems(ByVal ItemNumbers As Collection, ByVal ItemValues As Collection) As miSerialProtocol.InstrumentErrorsEnum
        Dim Item As Integer
        Dim x As Integer = 1

        Dim srlError As miSerialProtocol.InstrumentErrorsEnum

        If ItemNumbers.Count = ItemValues.Count Then
            For Each Item In ItemNumbers
                Try
                    srlError = InstrumentSrl.WD(CInt(Item), CStr(ItemValues(x))) <> miSerialProtocol.InstrumentErrorsEnum.NoError
                    If srlError <> miSerialProtocol.InstrumentErrorsEnum.NoError Then
                        Console.Write(srlError & vbNewLine)
                    End If
                    x += 1
                Catch ex As Exception
                End Try
            Next
        End If

    End Function

    'Load all items from the Database based on the instrument type
    Public Overridable Sub LoadInstrumentItems()
        'Dim myDataReader As MySqlDataReader = Nothing

        'Try
        '    Using mysql As New MySQLLibrary.Database
        '        Using mysqlcommand As New MySqlCommand
        '            With mysqlcommand
        '                .Connection = mysql.OpenMySQL
        '                .CommandText = "SELECT item_num, item_desc FROM items WHERE instr_type_id = " & Me.InstrumentType
        '                .CommandType = CommandType.Text
        '                myDataReader = .ExecuteReader(CommandBehavior.Default)

        '                If myDataReader.HasRows Then
        '                    While myDataReader.Read
        '                        iAllItemNumbers.Add(myDataReader.GetUInt32("item_num"), myDataReader.GetString("item_desc"))
        '                    End While
        '                Else
        '                    iAllItemNumbers = Nothing
        '                End If
        '                .Connection.Close()
        '            End With
        '        End Using
        '    End Using
        'Catch ex As Exception
        '    Throw New Exception(ex.Message)
        'Finally
        '    If Not myDataReader.IsClosed Then
        '        myDataReader.Close()
        '    End If
        'End Try

        'Dim context = New DamProverModel.DAMProverEntities
        'Dim query = From i In context.item Where i.instr_type_id = Me.InstrumentType
        'Dim items = query.ToList()


    End Sub

    'Will return a item value for a requested item
    Public Function GetItemValue(ByVal Item As Integer) As miSerialProtocol.ItemClass
        Dim x As Integer = 1
        Dim ItemString As String

        ItemString = CStr(Item)
        Try
            If Not AllItems Is Nothing Then
                Return AllItems.Item(ItemString)
            Else
                Throw New Exception("Item not found in collection.")
            End If
        Catch ex As Exception
            Dim temp_item As New miSerialProtocol.ItemClass
            temp_item.item = -1
            temp_item.value = 0
            Return temp_item
        End Try
    End Function

    Public Sub SaveItemValue(ByVal ItemNum As Integer, ByVal Value As Double)
        Dim x As Integer = 1
        Dim itemString = CStr(ItemNum)

        Try
            If Not AllItems Is Nothing Then
                Dim temp_item As New miSerialProtocol.ItemClass
                temp_item.item = ItemNum
                temp_item.value = Value
                If GetItemValue(ItemNum).item <> -1 Then
                    iAllItemNumbers.Remove(itemString)
                    iAllItemNumbers.Add(temp_item, itemString)
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub LoadFromDB(ByVal InstrID As Integer)
        Dim myDataReader As MySqlDataReader
        Dim myCollection As New Collection

        Me.InstrumentID = InstrID
        Try
            Using mysql As New MySQLLibrary.Database
                Using mySqlCommand As New MySqlCommand
                    With mySqlCommand
                        .Connection = mysql.OpenMySQL
                        .CommandText = "SELECT * FROM instr_info i WHERE i.instr_id =" & InstrumentID
                        .CommandType = CommandType.Text
                        myDataReader = .ExecuteReader(CommandBehavior.Default)
                        If myDataReader.HasRows Then
                            While myDataReader.Read
                                Dim item As New miSerialProtocol.ItemClass
                                item.item = myDataReader.GetString("item_number")
                                item.value = myDataReader.GetString("item_value")
                                Me.iAllItemNumbers.Add(item, item.item)
                            End While
                        End If
                        myDataReader.Close()

                        .CommandText = "SELECT * FROm instr WHERE instr_id = " & InstrumentID
                        .CommandType = CommandType.Text
                        myDataReader = .ExecuteReader
                        If myDataReader.HasRows Then
                            myDataReader.Read()
                            Me.Customer = New Customer(myDataReader.GetInt32("customer_id"))
                            Me.Customer.InspectionID = myDataReader.GetInt32("inspection_id")
                        End If
                        myDataReader.Close()


                        .CommandText = "SELECT * FROM volume_test WHERE instr_id = " & InstrumentID
                        .CommandType = CommandType.Text
                        myDataReader = .ExecuteReader(CommandBehavior.Default)
                        If myDataReader.HasRows Then
                            myDataReader.Read()
                            Me.Volume = New Volume()
                            Me.InstrumentType = Me.GetItemValue(127).value
                            Me.Volume.UncCorMultiplerCode = Me.GetItemValue(Volume.GeneralVolumeItems.UnCorrectedMultiplier).value
                            Me.Volume.CorrectedMultiplier = Me.Volume.GetVolumeMultipliers(Me.GetItemValue(Volume.GeneralVolumeItems.CorrectedMultiplier).value)
                            Me.Volume.UnCorrectedMultiplier = Me.Volume.GetVolumeMultipliers(Me.GetItemValue(Volume.GeneralVolumeItems.UnCorrectedMultiplier).value)
                            If Me.Volume.GetMeterIndexRate(Me.GetItemValue(Volume.GeneralVolumeItems.MeterIndexRate).value) = 14 Or Me.InstrumentType = miSerialProtocol.InstrumentTypeCode.TCI Then
                                Volume.MeterTypeNumber = GetItemValue(RotaryVolumeClass.GeneralVolumeItems.MeterType).value
                                Me.Volume.DriveRate = Me.GetItemValue(RotaryVolumeClass.GeneralVolumeItems.MeterDisplacement).value
                                Dim metername As String = Me.Volume.MeterTypeName
                                If Me.Volume.IsMetric(Me.Volume.UncCorMultiplerCode) Then
                                    Me.Volume.DriveRate *= 0.0283168466
                                    Me.Volume.EVCMeterDisplacement = Me.Volume.DriveRate
                                    Me.Volume.MeterDisplacement *= 0.0283168466
                                Else
                                    Me.Volume.EVCMeterDisplacement = Me.Volume.DriveRate
                                End If

                                Me.InstrumentDriveType = DriveType.Rotary
                            Else
                                Me.Volume.DriveRate = Me.Volume.GetMeterIndexRate((Me.GetItemValue(MiniATVolumeClass.GeneralVolumeItems.DriveRate).value))
                                Me.InstrumentDriveType = DriveType.Mechanical
                            End If
                            Me.Volume.StartCorrected = 0
                            Me.Volume.StartUncorrected = 0
                            Me.Volume.PulserA = myDataReader.GetDouble("pulser_a")
                            Me.Volume.PulserB = myDataReader.GetDouble("pulser_b")
                            Me.PulseASelect = GetItemValue(Instrument.PulseOutputItems.PulserA).value
                            Me.PulseBSelect = GetItemValue(Instrument.PulseOutputItems.PulserB).value
                            Me.Volume.EndUnCorrected = myDataReader.GetDouble("end_uncor")
                            Me.Volume.EndCorrected = myDataReader.GetDouble("end_cor")
                            Me.Volume.AppliedInput = myDataReader.GetDouble("pulse_input")
                            If InstrumentDriveType = DriveType.Mechanical Then
                                Me.Energy = New EnergyClass(0, myDataReader.GetDouble("energy"), Volume.EvcCorrected, GetItemValue(EnergyClass.EnergyItems.EnergyUnits).value, GetItemValue(EnergyClass.EnergyItems.GasEnergyValue).value)
                                Me.Volume.MechanicalReading = myDataReader.GetInt32("mech_read")
                            End If
                        End If
                        myDataReader.Close()

                        If LiveTemp = FixedFactors.Live Then
                            .CommandText = "SELECT * FROM temperature WHERE instr_id = " & InstrumentID
                            .CommandType = CommandType.Text
                            myDataReader = .ExecuteReader(CommandBehavior.Default)
                            If myDataReader.HasRows Then
                                Do While myDataReader.Read
                                    Dim temp As New TemperatureClass
                                    temp.BaseTemperature = Me.GetItemValue(ItemsEnum.BaseTemp).value
                                    temp.GaugeTemperature = myDataReader.GetDouble("gauge_temp")
                                    temp.EVCTemperature = myDataReader.GetDouble("evc_temp")
                                    temp.EVCFactor = myDataReader.GetDouble("evc_factor")
                                    temp.TemperatureUnits = GetItemValue(ItemsEnum.TempUnits).value
                                    Me.Temperatures.Add(temp, myDataReader.GetInt32("t_level"))
                                Loop
                            End If
                            Me.Volume.EVCType = DAM_Prover.Volume.EVCTypeEnum.Temperature
                            Me.Volume.TempFactor = Me.GetTemperatureObject(TestClass.TemperatureLevels.Low).TemperatureFactor
                        End If
                        myDataReader.Close()

                        If Me.LivePressure = FixedFactors.Live Then
                            .CommandText = "SELECT * FROM pressure WHERE instr_id = " & InstrumentID
                            .CommandType = CommandType.Text
                            myDataReader = .ExecuteReader(CommandBehavior.Default)
                            If myDataReader.HasRows Then
                                Do While myDataReader.Read
                                    Dim pressure As New PressureFactorClass
                                    pressure.GaugePressure = myDataReader.GetDouble("gauge_pressure")
                                    pressure.AtmosphericPressure = myDataReader.GetDouble("atm_pressure")
                                    pressure.EVCPressure = myDataReader.GetDouble("evc_pressure")
                                    pressure.EVCFactor = myDataReader.GetDouble("evc_pfactor")
                                    pressure.EVCUnsqr = myDataReader.GetDouble("evc_unsqr_super")
                                    pressure.BasePressure = GetItemValue(ItemsEnum.BasePressure).value
                                    pressure.PressureUnits = GetItemValue(ItemsEnum.PressureUnits).value
                                    Me.Pressures.Add(pressure, myDataReader.GetInt32("p_level"))
                                Loop
                            End If
                            myDataReader.Close()
                            Me.Volume.EVCType = DAM_Prover.Volume.EVCTypeEnum.Pressure
                            Me.Volume.PressureFactor = Me.GetPressureObject(TestClass.PressureLevels.High).ActualPressureFactor
                        End If

                        Dim x As Integer = 1
                        If LivePressure = FixedFactors.Live And LiveTemp = FixedFactors.Live Then
                            Me.Volume.EVCType = DAM_Prover.Volume.EVCTypeEnum.PressureTemperature
                            For Each item As PressureFactorClass In Pressures
                                Dim super As New SuperFactorClass
                                super.CO2 = GetItemValue(SuperFactorClass.SuperFactorItems.CO2).value
                                super.N2 = GetItemValue(SuperFactorClass.SuperFactorItems.N2).value
                                super.SpecGr = GetItemValue(SuperFactorClass.SuperFactorItems.SpecGR).value
                                super.GaugeTemp = Me.GetTemperatureObject(x).ConvertToF(Me.GetTemperatureObject(x).GaugeTemperature, Me.GetTemperatureObject(x).TemperatureUnits)
                                super.GaugePressure = item.ConvertToPSI(Me.GetPressureObject(x).GaugePressure, Me.GetPressureObject(x).PressureUnits)
                                super.EVCUnsqrSuper = Me.GetPressureObject(x).EVCUnsqr
                                Me.SuperFactors.Add(super, x)
                                x += 1
                            Next
                            Me.Volume.EVCType = DAM_Prover.Volume.EVCTypeEnum.PressureTemperature
                            Me.Volume.Fpv2Factor = GetSuperObject(TestClass.SuperLevels.HighPLowT).SuperFactorSquared
                        End If
                        .Connection.Close()
                        .Connection.Dispose()
                    End With
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub FillInstrumentVolume()

        Me.InstrumentType = Me.GetItemValue(127).value
        Me.Volume.CorrectedMultiplier = Me.Volume.GetVolumeMultipliers(Me.GetItemValue(Volume.GeneralVolumeItems.CorrectedMultiplier).value)
        Me.Volume.UnCorrectedMultiplier = Me.Volume.GetVolumeMultipliers(Me.GetItemValue(Volume.GeneralVolumeItems.UnCorrectedMultiplier).value)
        Me.Volume.UncCorMultiplerCode = Me.Volume.GetVolumeMultipliers(Me.GetItemValue(Volume.GeneralVolumeItems.UnCorrectedMultiplier).value)
        Me.Volume.CorMultiplierCode = Me.Volume.GetVolumeMultipliers(Me.GetItemValue(Volume.GeneralVolumeItems.CorrectedMultiplier).value)
        Me.PulseASelect = GetItemValue(Instrument.PulseOutputItems.PulserA).value
        Me.PulseBSelect = GetItemValue(Instrument.PulseOutputItems.PulserB).value

        If Me.Volume.GetMeterIndexRate(Me.GetItemValue(Volume.GeneralVolumeItems.MeterIndexRate).value) = 14 Or Me.InstrumentType = miSerialProtocol.InstrumentTypeCode.TCI Then
            Me.Volume.DriveRate = Me.Volume.MeterDisplacement
            Me.InstrumentDriveType = DriveType.Rotary
        Else
            Me.Volume.DriveRate = Me.Volume.GetMeterIndexRate((Me.GetItemValue(MiniATVolumeClass.GeneralVolumeItems.DriveRate).value))
            Me.InstrumentDriveType = DriveType.Mechanical

        End If
        Me.Volume.StartCorrected = 0
        Me.Volume.StartUncorrected = 0
        If Me.LiveTemp = FixedFactors.Live And Me.LivePressure = FixedFactors.Live Then
            Me.Volume.EVCType = Volume.EVCTypeEnum.PressureTemperature
            Volume.PressureFactor = Me.GetPressureObject(TestClass.PressureLevels.High).ActualPressureFactor
            Volume.TempFactor = Me.GetTemperatureObject(TestClass.TemperatureLevels.Low).TemperatureFactor
            Volume.Fpv2Factor = Me.GetSuperObject(TestClass.SuperLevels.HighPLowT).SuperFactorSquared
        ElseIf LiveTemp = FixedFactors.Live Then
            Me.Volume.EVCType = Volume.EVCTypeEnum.Temperature
            Volume.TempFactor = GetTemperatureObject(TestClass.TemperatureLevels.Low).TemperatureFactor
        ElseIf LivePressure = FixedFactors.Live Then
            Me.Volume.EVCType = Volume.EVCTypeEnum.Pressure
            Volume.PressureFactor = GetPressureObject(TestClass.PressureLevels.High).ActualPressureFactor
        End If

    End Sub

    Public Overridable Function GetPulseSelect(ByVal PulserChannelValue As Integer) As PulseOutputValues

    End Function

    Public Sub SaveInstrument()
        Dim x As Integer = 0
        Dim myDataReader As MySqlDataReader = Nothing
        Dim saveFrm As New SaveInstrumentForm
        Dim trans As MySqlTransaction = Nothing

        saveFrm.Show()

        Using mysql As New MySQLLibrary.Database
            Using mySqlCommand As New MySqlCommand
                With mySqlCommand
                    Try
                        .Connection = mysql.OpenMySQL
                        .CommandText = "SELECT * FROM instr WHERE instr_id = " & Me.InstrumentID
                        myDataReader = .ExecuteReader
                        If myDataReader.HasRows Then
                            myDataReader.Close()
                            .CommandText = "UPDATE instr SET inspection_id = -1 WHERE instr_id = " & Me.InstrumentID
                            .CommandType = CommandType.Text
                            .ExecuteNonQuery()
                        End If
                        myDataReader.Close()

                        trans = mysql.OpenMySQL.BeginTransaction
                        mySqlCommand.Transaction = trans

                        .CommandText = "save_instrument"
                        .CommandType = CommandType.StoredProcedure

                        Dim paramCustomerID = New MySqlParameter("?customer_id", Me.Customer.CustomerID)
                        paramCustomerID.Direction = ParameterDirection.Input
                        mySqlCommand.Parameters.Add(paramCustomerID)

                        Dim paramSerialNumber = New MySqlParameter("?serial_number", GetItemValue(Instrument.ItemsEnum.SerialNumber).value)
                        paramSerialNumber.Direction = ParameterDirection.Input
                        mySqlCommand.Parameters.Add(paramSerialNumber)

                        Dim paramApprover = New MySqlParameter("?approver", My.Settings.UserID)
                        paramApprover.Direction = ParameterDirection.Input
                        mySqlCommand.Parameters.Add(paramApprover)

                        Dim paramInstrType = New MySqlParameter("?instr_type_id", InstrumentType)
                        paramInstrType.Direction = ParameterDirection.Input
                        mySqlCommand.Parameters.Add(paramInstrType)

                        Dim paramInspectionID = New MySqlParameter("?inspection_id", Customer.InspectionID)
                        paramInspectionID.Direction = ParameterDirection.Input
                        mySqlCommand.Parameters.Add(paramInspectionID)

                        Dim paramInstrumentID = New MySqlParameter("?instrument_id", MySqlDbType.Int32)
                        paramInstrumentID.direction = ParameterDirection.Output
                        mySqlCommand.Parameters.Add(paramInstrumentID)

                        .ExecuteNonQuery()
                        Me.InstrumentID = paramInstrumentID.value

                        RaiseEvent TotalItems(AllItems.Count)
                        For Each kvp As miSerialProtocol.ItemClass In AllItems
                            .CommandText = "INSERT INTO instr_info VALUES (" & paramInstrumentID.value & ", " & kvp.item & ", '" & kvp.value & "')"
                            .CommandType = CommandType.Text
                            .ExecuteNonQuery()
                            x += 1
                            RaiseEvent ItemStored(x)
                        Next

                        If Me.InstrumentDriveType = DriveType.Rotary Then
                            .CommandText = "UPDATE instr SET meter_index_id = " & GetItemValue(432).value & " WHERE instr_id = " & Me.InstrumentID
                            .CommandType = CommandType.Text
                            .ExecuteNonQuery()
                        End If


                        'Volume Items
                        RaiseEvent TotalItems(1)
                        .CommandText = "INSERT INTO volume_test (instr_id, pulse_input, pulser_a, pulser_b, end_uncor, end_cor) VALUES (" & paramInstrumentID.value & "," & Volume.AppliedInput _
                                & "," & Volume.PulserA & "," & Volume.PulserB & "," & Volume.EndUnCorrected _
                                & "," & Volume.EndCorrected & ")"
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()

                        'Save energy values
                        If Me.InstrumentDriveType = DriveType.Mechanical Then
                            .CommandText = "Update volume_test SET energy = " & Me.Energy.EndReading & " WHERE instr_id = " & paramInstrumentID.value
                            .CommandType = CommandType.Text
                            .ExecuteNonQuery()
                            .CommandText = "Update volume_test SET mech_read = " & Me.Volume.MechanicalReading & " WHERE instr_id = " & paramInstrumentID.value
                            .CommandType = CommandType.Text
                            .ExecuteNonQuery()
                        End If

                        RaiseEvent ItemStored(1)

                        'Temperature
                        x = 1

                        If LiveTemp = DAM_Prover.Instrument.FixedFactors.Live Then
                            RaiseEvent TotalItems(3)
                            For Each item As DAM_Prover.TemperatureClass In Temperatures
                                .CommandText = "INSERT INTO temperature VALUES (" & paramInstrumentID.value & "," & x _
                                    & "," & item.GaugeTemperature & "," & item.EVCTemperature & "," _
                                    & item.EVCFactor & ")"
                                .CommandType = CommandType.Text
                                .ExecuteNonQuery()
                                x += 1
                                RaiseEvent ItemStored(x)
                            Next
                        End If


                        'Pressure
                        x = 1

                        If LivePressure = DAM_Prover.Instrument.FixedFactors.Live Then
                            RaiseEvent TotalItems(3)
                            For Each item As PressureFactorClass In Pressures
                                .CommandText = "INSERT INTO pressure VALUES (" & paramInstrumentID.value & "," & x _
                                    & "," & item.GaugePressure & "," & item.AtmosphericPressure _
                                    & "," & item.EVCPressure & "," & item.EVCFactor _
                                    & "," & item.EVCUnsqr & ")"
                                .CommandType = CommandType.Text
                                .ExecuteNonQuery()
                                x += 1
                                RaiseEvent ItemStored(x)
                            Next
                        End If
                        RaiseEvent ItemStored(x)

                        trans.Commit()


                        saveFrm.Close()

                    Catch ex As Exception
                        trans.Rollback()
                        saveFrm.Close()
                        If MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False) = DialogResult.Retry Then
                            Me.SaveInstrument()
                        Else
                            Throw New Exception(ex.Message)
                        End If
                    End Try
                End With
            End Using
        End Using

    End Sub

#End Region
End Class

Public Class CalculatedValues
    Public Name As String
    Public Value As Double
End Class

