Imports Prover.Data.ProviderModel
Imports miSerialProtocol.InstrumentTypeCode

Public Interface IBaseInstrument

#Region "Enums"
    Enum ItemsEnum
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

    Enum PulseOutputItems
        PulserA = 93
        PulserB = 94
    End Enum

    Enum PulseOutputValues
        CorVol = 0
        PCorVol = 1
        UncVol = 2
        NoOut = 3
        Time = 4
    End Enum

    Enum FixedFactorItems
        FixedPressure = 109
        FixedSuperFactor = 110
        FixedTempFactor = 111
    End Enum

    Enum FixedFactors
        Live = 0
        Fixed = 1
        Super = 2
    End Enum

    Enum DriveType
        Rotary = 1
        Mechanical = 2
    End Enum

    Enum DateFormat
        MMDDYY = 0
        DDMMYY = 1
        YYMMDD = 2
    End Enum
#End Region


    ReadOnly Property InstrumentGuid As Guid
    ReadOnly Property InstrumentDriveType As DriveType

    ReadOnly Property SerialNumber As String
    ReadOnly Property InspectionID As Integer

    ReadOnly Property PulseASelect As PulseOutputValues
    ReadOnly Property PulseBSelect As PulseOutputValues

    Function GetItemValue(ItemNumber As Integer) As String

End Interface
