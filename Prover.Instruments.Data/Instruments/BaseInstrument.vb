Imports miSerialProtocol
Public Class BaseInstrument
    Implements IBaseInstrument

    'This is the base class for all the Mercury Instruments
    'Seperate classes for each instrument must be created and inherited from this class
    'Only the properties and methods common to all instruments are created in this class
    'i.e. Mini-Max Rotary has Proving modes that must be set before testing

    'This class is responsible for holding values downloaded from the instrument and Temperature and Pressure Classes
    Protected _instrumentXml As XDocument
    Private _instrument As Model.instr

    Sub New()
    End Sub

    Sub New(CommPort As String, BaudRate As BaudRateEnum)
        Me.BaudRate = BaudRate
        Me.CommPort = CommPort
    End Sub

    Protected Sub New(instrument As Model.instr)
        _instrument = instrument
        _instrumentType = _instrument.instr_type_id
        _instrumentXml = XDocument.Parse(_instrument.data)
        ItemFile = _instrumentXml.<instrumentFile>.FirstOrDefault()
    End Sub

#Region "Properties"

    Public Property Items As List(Of ItemClass) Implements IBaseInstrument.Items
    Public Property BaudRate As miSerialProtocol.BaudRateEnum Implements IBaseInstrument.BaudRate
    Public Property CommPort As String Implements IBaseInstrument.CommPort
    Public Property InstrumentType As miSerialProtocol.InstrumentTypeCode Implements IBaseInstrument.InstrumentType

    Public ReadOnly Property InstrumenGuID() As Guid Implements IBaseInstrument.InstrumentGuid
        Get
            If _instrument IsNot Nothing Then
                Return _instrument.instr_id
            Else
                Return Guid.Empty
            End If
        End Get
    End Property

    Public ReadOnly Property AlarmItems As List(Of ItemClass)
        Get
            Return (From alarms In Items Where alarms.IsAlarm = True)
        End Get
    End Property

    Public Property InstrumentDriveType() As IBaseInstrument.DriveType Implements IBaseInstrument.InstrumentDriveType
    Public Property ItemFile As XElement Implements IBaseInstrument.ItemFile
    Public Property InspectionID As Integer Implements IBaseInstrument.InspectionID

    Public ReadOnly Property SerialNumber As String Implements IBaseInstrument.SerialNumber
        Get
            Return GetItemValue(GetItemNumberByCode("SERIALNUM"))
        End Get
    End Property


    Public ReadOnly Property PulseASelect() As IBaseInstrument.PulseOutputValues Implements IBaseInstrument.PulseASelect
        Get
            Return Nothing
        End Get
    End Property

    Public ReadOnly Property PulseBSelect() As IBaseInstrument.PulseOutputValues Implements IBaseInstrument.PulseBSelect
        Get
            Return Nothing
        End Get
    End Property

    Public Function GetItemValue(ItemNumber As Integer) As String Implements IBaseInstrument.GetItemValue
        Dim y As XElement
        Try
            y = (From x In ItemFile.Elements("item") Where x.Attribute("number").Value = CStr(ItemNumber) And x IsNot Nothing Select x).First
        Catch ex As Exception
            Return Nothing
        End Try
        Return y.Attribute("value").Value

    End Function

    Public Function GetItemNumberByCode(Code As String) As Integer
        Try
            Return ((From i In Items Where i.Code = CStr(Code) And i IsNot Nothing Select i).First).Number
        Catch ex As Exception
            Return Nothing
        End Try
    End Function


#Region "Shared Stuff"

    Public Shared Function GetItemNumberByCode(Items As List(Of ItemClass), Code As String) As Integer
        Try
            Return ((From i In Items Where i.Code = CStr(Code) And i IsNot Nothing Select i).First).Number
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    'This will set _instrumentItems with attributes from our specific instrument xml files
    Public Shared Function LoadInstrumentItems(xmlPath As String) As List(Of ItemClass)
        If xmlPath Is Nothing OrElse xmlPath = "" Then
            Throw New Exception("Could not load instrument items.")
        End If

        Dim _xmlElement = XDocument.Load(xmlPath)
        Return (From x In _xmlElement.<InstrumentItems>.Elements("item") Select New ItemClass(x.@number, x.@code, x.@shortDescription, x.@Description, Not IsNothing(x.@isAlarm))).ToList
    End Function
#End Region


#End Region


End Class

