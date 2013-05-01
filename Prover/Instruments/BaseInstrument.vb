Imports miSerialProtocol
Public Class BaseInstrument
    Implements IBaseInstrument

    'This is the base class for all the Mercury Instruments
    'Seperate classes for each instrument must be created and inherited from this class
    'Only the properties and methods common to all instruments are created in this class
    'i.e. Mini-Max Rotary has Proving modes that must be set before testing

    'This class is responsible for holding values downloaded from the instrument and Temperature and Pressure Classes

    Protected _instrumentXml As XDocument
    Protected _instrumentXmlNode As XElement
    Private _instrument As Model.instr



    Protected Sub New(instrument As Model.instr)
        _instrument = instrument
        _instrumentXml = XDocument.Parse(_instrument.data)
        _instrumentXmlNode = _instrumentXml.<Instrument>.FirstOrDefault
    End Sub

#Region "Properties"


    Public ReadOnly Property InstrumenGuID() As Guid Implements IBaseInstrument.InstrumentGuid
        Get
            Return _instrument.instr_id
        End Get
    End Property

    Public ReadOnly Property InstrumentDriveType() As IBaseInstrument.DriveType Implements IBaseInstrument.InstrumentDriveType
        Get
            Return _instrument.meter_index_id
        End Get
    End Property

    Public ReadOnly Property SerialNumber As String Implements IBaseInstrument.SerialNumber
        Get
            Return _instrument.serial_number
        End Get
    End Property

    Public ReadOnly Property InspectionID As Integer Implements IBaseInstrument.InspectionID
        Get
            Return _instrument.inspection_id
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
#End Region


End Class

