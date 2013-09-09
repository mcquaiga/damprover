Imports Prover.Data.ProviderModel
Imports miSerialProtocol.InstrumentTypeCode
Imports miSerialProtocol.BaudRateEnum
Imports System.Collections.ObjectModel
Imports System.IO.Ports
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq


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

    Function StartRotaryTest() As Task

    Property PressureTests As List(Of IPressureFactorClass)
    Property Temperature As TemperatureClass
    Property VolumeTest As IVolume

    ReadOnly Property FirmwareVersion As String

    ReadOnly Property PulseAScaling As Double
    ReadOnly Property PulseBScaling As Double

    Function IsLiveSuper() As FixedFactors
    Function IsLivePressure() As FixedFactors
    Function IsLiveTemperate() As FixedFactors

    Property InstrumentType As miSerialProtocol.InstrumentTypeCode
    ReadOnly Property InstrumentGuid As Guid

    ReadOnly Property SerialNumber As String
    ReadOnly Property SiteNumber1 As String
    ReadOnly Property SiteNumber2 As String

    Property InstrumentDriveType As DriveType

    Property CreatedDate As DateTime?

    Property Items As List(Of ItemClass)

    ReadOnly Property PulseASelect As String
    ReadOnly Property PulseBSelect As String
    Property InspectionID As Integer?

    Function DownloadSiteInformation() As Task
    Function DownloadTemperatureItems() As Task
    Function DownloadTemperatureTestItems(LevelIndex As Integer) As Task

End Interface
