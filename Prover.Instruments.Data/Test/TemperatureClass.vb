
Public Class TemperatureClass
    Inherits FactorClass

    Public Enum UnitsEnum
        C = 1
        F = 0
        R = 2
        K = 3
    End Enum
    Public Enum TemperatureItems
        GasTemp = 26
        BaseTemp = 34
        TempFactor = 45
        TempUnits = 89
        FixedTempFactor = 111
    End Enum


    Private _PreviousUnits As UnitsEnum

    Private TempCorrection As Double = 459.67
    Private MetericTempCorrection As Double = 273.15

    Sub New()
        MyBase.New()
    End Sub

#Region "Properties"

    Public ReadOnly Property TemperatureUnits() As UnitsEnum
        Get
            Return Items(TemperatureItems.TempUnits)
        End Get

    End Property

    Public Property GaugeTemperature() As Double


    Public ReadOnly Property EVCTemperature() As Double
        Get
            Return Items(TemperatureItems.GasTemp)
        End Get
    End Property

    Public ReadOnly Property EVCFactor() As Double
        Get
            Return Items(TemperatureItems.TempFactor)
        End Get
    End Property

    Public ReadOnly Property BaseTemperature() As Double
        Get
            Return Items(TemperatureItems.BaseTemp)
        End Get

    End Property

    Public ReadOnly Property TemperatureFactor() As Double
        Get
            If TemperatureUnits = UnitsEnum.C Or TemperatureUnits = UnitsEnum.K Then
                Return (MetericTempCorrection + BaseTemperature) / (GaugeTemperature + MetericTempCorrection)
            ElseIf TemperatureUnits = UnitsEnum.F Or TemperatureUnits = UnitsEnum.R Then
                Return (TempCorrection + BaseTemperature) / (GaugeTemperature + TempCorrection)
            End If

            Return 0
        End Get
    End Property

    Public ReadOnly Property PercentError() As Double
        Get
            Return ((EVCFactor - TemperatureFactor) / TemperatureFactor) * 100
        End Get
    End Property
#End Region

#Region "Methods"

    Public Function Convert(ByVal Value As Double) As Double

        'Convert to Fahrenheit first
        Select Case _PreviousUnits
            Case UnitsEnum.C
                Value = (Value * 1.8) + 32
            Case UnitsEnum.F
                Value = Value / 1
            Case UnitsEnum.K
                Value = ((Value - 273.15) * 1.8) + 32
            Case UnitsEnum.R
                Value = Value - 459.67
        End Select

        'And then to the current Units
        Select Case TemperatureUnits
            Case UnitsEnum.C
                Value = (Value - 32) / 1.8
            Case UnitsEnum.F
                Value = Value * 1
            Case UnitsEnum.K
                Value = ((Value - 32) / 1.8) + 273.15
            Case UnitsEnum.R
                Value = Value + 459.67
        End Select

        Return Math.Round(Value, 2)
    End Function

    Public Function ConvertToF(ByVal Value As Double, ByVal FromUnit As UnitsEnum) As Double
        'Convert to Fahrenheit first
        Select Case FromUnit
            Case UnitsEnum.C
                Value = (Value * 1.8) + 32
            Case UnitsEnum.F
                Value = Value / 1
            Case UnitsEnum.K
                Value = ((Value - 273.15) * 1.8) + 32
            Case UnitsEnum.R
                Value = Value - 459.67
        End Select
        Return Value
    End Function


#End Region

End Class
