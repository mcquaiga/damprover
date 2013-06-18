
Public Interface ITemperatureClass
    Enum UnitsEnum
        C = 1
        F = 0
        R = 2
        K = 3
    End Enum
    Enum TemperatureItems
        GasTemp = 26
        BaseTemp = 34
        TempFactor = 45
        TempUnits = 89
        FixedTempFactor = 111
    End Enum

    Property Items As Dictionary(Of Integer, String)
    ReadOnly Property TemperatureUnits() As UnitsEnum
    Property GaugeTemperature() As Double
    ReadOnly Property EVCTemperature() As Double
    ReadOnly Property EVCFactor() As Double
    ReadOnly Property BaseTemperature() As Double
    ReadOnly Property TemperatureFactor() As Double
    ReadOnly Property PercentError() As Double
    ReadOnly Property hasPassed As Boolean

    ReadOnly Property LevelIndex As Integer

    ReadOnly Property LevelDescription As String



End Interface
