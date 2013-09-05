Imports miSerialProtocol

Public Interface ITemperatureTestClass

    Enum TemperatureItems
        GasTemp = 26
        BaseTemp = 34
        TempFactor = 45
        TempUnits = 89
        FixedTempFactor = 111
    End Enum


    Property Items As List(Of ItemClass)
    Property TemperatureUnits() As String
    Property BaseTemperature() As Double

    Property GaugeTemperature() As Double
    ReadOnly Property EVCTemperature() As Double
    ReadOnly Property EVCFactor() As Double

    ReadOnly Property TemperatureFactor() As Double
    ReadOnly Property PercentError() As Double
    ReadOnly Property hasPassed As Boolean

    ReadOnly Property LevelIndex As Integer
    ReadOnly Property LevelDescription As String

    Function DownloadTestItems(InstrumentTypeCode As InstrumentTypeCode) As Task


End Interface
