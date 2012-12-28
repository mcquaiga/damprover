Public Class TCITestClass
    Inherits RotaryTestClass
    Implements IDisposable

#Region "Enums"
    Public Enum ItemsToSet
        CorrectedVolume = 0
        UnCorrectedVolume = 2
    End Enum

    Public Enum ProverType
        InputVolumeType = 433
    End Enum

    Public Enum REIVolumeTypeCodes
        InstrumentDrive = 0
        RotaryType1 = 1
        Type1Proving = 3
        BiDirectional = 4
        RotaryType2 = 9
        Type2Proving = 11
    End Enum

    Public Enum PulseFunctions
        StartMotor = 254
        StopMotor = 255
    End Enum
#End Region

    'The rotary test differs from all the others because it is automatic,
    'We must start and stop the motor, read in pulses from the instrument and read the tachometer when it is finished
    Private tPulseA As DABoard
    Private tPulseB As DABoard
    Private tPulseOut As DABoard
    Private tTach As TachometerClass
    Shadows tPulserACount As Integer
    Shadows tPulserBCount As Integer
    Shadows tUnCorPulseCount As Integer
    Private tPulseASelect As Instrument.PulseOutputValues
    Private tPulseBSelect As Instrument.PulseOutputValues


    Sub New(ByVal CustomerID As Integer)

        MyBase.New(CustomerID)

        Instrument = New TCIInstrument()
        Me.Customer.Instrument = Me.Instrument

    End Sub

    
  

#Region "Properties"

    Public Shadows Property Instrument() As TCIInstrument
        Get
            Return tInstrument
        End Get
        Set(ByVal value As TCIInstrument)
            tInstrument = value
        End Set
    End Property

#End Region

#Region "Methods"

    Public Overrides Sub PreTest(Optional ByVal Retest As Boolean = False)
        MyBase.PreTest(Retest)

        'Set instrument to proving mode and put the display screen to HighResUnCorrected
        Instrument.InstrumentSrl.Connect()
        Instrument.InstrumentSrl.WD(433, 2)
        Instrument.InstrumentSrl.WD(482, 892)
        Instrument.InstrumentSrl.Disconnect()
    End Sub

#End Region


End Class
