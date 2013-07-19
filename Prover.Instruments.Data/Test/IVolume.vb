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
    Property BeforeItems As Dictionary(Of Integer, String)
    Property AfterItems As Dictionary(Of Integer, String)

    ReadOnly Property TrueCorrected As Double 'Calculated Corrected Volume = (TempFactor * PressureFactor * Fpv2Factor * InputUncVolume)
    ReadOnly Property EvcCorrected As Double 'End Reading - Start Reading / Corrected Multiplier
    Property TempFactor As Double
    Property PressureFactor As Double
    Property Fpv2 As Double
    ReadOnly Property InputUncVolume As Double
    ReadOnly Property EndCorrected As Double
    ReadOnly Property StartCorrected As Double
    ReadOnly Property CorrectedMultiplier As Double
    ReadOnly Property UncorrectedMutliplier As Double
    Property AppliedInput As Double
    Property DriveRate As Double '
    Property EVCType As EVCTypeEnum
    ReadOnly Property StartunCorrected As Double
    ReadOnly Property EndUnCorrected As Double
    Property PulserA As Double
    Property PulserB As Double
    Property MeterDisplacement As Double
    Property EvcMeterDisplacement As Double
    Property MaxUnCorrected As Double
    Property MeterTypeNumber As Integer
    Property MeterTypeString As String
    Property UnCorCode As InstrumentVolumeUnitsEnum
    Property CorCode As InstrumentVolumeUnitsEnum
    Property MechReading As Integer
    Property VolumeData As String

End Interface
