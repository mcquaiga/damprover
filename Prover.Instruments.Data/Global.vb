Module ProverGlobal


    Public Enum TemperatureLevels
        Low = 3
        Mid = 2
        High = 1
    End Enum

    Public Enum PressureLevels
        High = 3
        Mid = 2
        Low = 1
    End Enum

    Public Enum SuperLevels
        HighPLowT = 3
        MidPMidT = 2
        LowPHighT = 1
    End Enum

    Public Enum TestLevels
        Before = 1
        After = 2
    End Enum

    Public Enum SuperFactorItemsEnum
        AuxFactor = 46
        UnSquaredSuperFactor = 47
    End Enum

    Public Enum TransducerTypesEnum
        Gauge = 0
        Absolute = 1
    End Enum

    Public Enum ItemsToSet
        CorrectedVolume = 0
        UnCorrectedVolume = 2
        PulseAWaiting = 5
        PulseBWaiting = 6
        Energy = 140
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
End Module
