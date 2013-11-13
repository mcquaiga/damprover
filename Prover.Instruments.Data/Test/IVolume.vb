Imports Raven.Imports.Newtonsoft.Json

Public Interface IVolume


#Region "Enums"
    Enum EVCTypeEnum
        Pressure
        Temperature
        PressureTemperature
    End Enum

    Enum GeneralVolumeItems
        CorrectedMultiplier = 90
        UnCorrectedMultiplier = 92
        MeterIndexRate = 98
    End Enum

    Enum VolumeTestItems
        UnCorrectedVolume = 2
        CorrectedVolume = 0
        HighResCorrected = 113
        Energy = 140
        HighResUnCorrected = 892
    End Enum

    Enum InstrumentVolumeUnitsEnum
        CuFT = 0
        CuFTx10 = 1
        CuFTx100 = 2
        CF = 3
        CFx10 = 4
        CFx100 = 5
        CFx1000 = 6
        CCF = 7
        MCF = 8
        m3xPoint1 = 9
        m3 = 10
        m3x10 = 11
        m3x100 = 12
        m3x1000 = 13
        CFx10000 = 14
        Therms = 15
        DecaTherms = 16
        MegaJoules = 17
        GigaJoules = 18
        KiloCals = 19
        KiloWattHrs = 20
    End Enum

    Enum InstrumentMeterIndexCodesEnum
        CF1 = 0
        CF5 = 1
        CF10 = 2
        CF100 = 3
        CF1000 = 4
        m3Point1 = 5
        m31 = 6
        m310 = 7
        m3100 = 8
        m31000 = 9
        CF10000 = 10
        CF0 = 11
        CF50 = 12
        CF500 = 13
        RotaryIntegeralMount = 14

    End Enum
#End Region

    Function RunTest(InstrumentType As miSerialProtocol.InstrumentTypeCode, TemperatureTest As ITemperatureTestClass) As Task



    <JsonIgnore>
    Property BeforeItems As List(Of ItemClass)
    <JsonIgnore>
    Property AfterItems As List(Of ItemClass)

    ReadOnly Property TrueCorrected As Double 'Calculated Corrected Volume = (TempFactor * PressureFactor * Fpv2Factor * InputUncVolume)
    ReadOnly Property EvcCorrected As Double 'End Reading - Start Reading / Corrected Multiplier
    Property PressureFactor As Double
    Property Fpv2 As Double
    ReadOnly Property InputUncVolume As Double

    ReadOnly Property StartunCorrected As Double
    ReadOnly Property EndCorrected As Double

    ReadOnly Property StartCorrected As Double
    ReadOnly Property EndUnCorrected As Double

    ReadOnly Property CorrectedMultiplier As Decimal
    ReadOnly Property UncorrectedMutliplier As Decimal
    ReadOnly Property MaxUnCorrected As Double

    Property AppliedInput As Double
    Property DriveRate As Double '
    Property EVCType As EVCTypeEnum


    Property PulserACount As Double
    Property PulserBCount As Double
    Property MeterDisplacement As Double
    Property EvcMeterDisplacement As Double
    Property MeterTypeNumber As Integer
    Property MeterTypeString As String
    Property MechReading As Integer

    Property TemperatureTest As TemperatureTestClass

    <JsonIgnore>
    Property OutputBoard As IBoard
    <JsonIgnore>
    Property InputABoard As IBoard
    <JsonIgnore>
    Property InputBBoard As IBoard


End Interface
