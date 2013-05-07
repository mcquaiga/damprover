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

    Public Property BaudRate As miSerialProtocol.BaudRateEnum Implements IBaseInstrument.BaudRate
    Public Property CommPort As String Implements IBaseInstrument.CommPort
    Public Property InstrumentType As miSerialProtocol.InstrumentTypeCode Implements IBaseInstrument.InstrumentType

    Public ReadOnly Property InstrumenGuID() As Guid Implements IBaseInstrument.InstrumentGuid
        Get
            Return _instrument.instr_id
        End Get
    End Property

    Public Property InstrumentDriveType() As IBaseInstrument.DriveType Implements IBaseInstrument.InstrumentDriveType
    Public Property ItemFile As XElement Implements IBaseInstrument.ItemFile
    Public Property InspectionID As Integer Implements IBaseInstrument.InspectionID

    Public ReadOnly Property SerialNumber As String Implements IBaseInstrument.SerialNumber
        Get
            If _instrument Is Nothing Then
                Return GetItemValue(62)
            Else
                Return _instrument.serial_number
            End If
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

        'Dim instrument As XElement
        'Dim instrument = .FirstOrDefault()
        Dim y As XElement

        Try
            y = (From x In ItemFile.Elements("item") Where x.Attribute("number").Value = CStr(ItemNumber) And x IsNot Nothing Select x).First
        Catch ex As Exception
            Return Nothing
        End Try

        Return y.Attribute("value").Value

    End Function
#End Region


End Class

