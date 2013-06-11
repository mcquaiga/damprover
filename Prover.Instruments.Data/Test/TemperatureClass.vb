
Public Class TemperatureClass
    Inherits FactorClass
    Implements ITemperatureClass

    Private _PreviousUnits As ITemperatureClass.UnitsEnum

    Const TempCorrection As Double = 459.67
    Private MetericTempCorrection As Double = 273.15

    Sub New()
        MyBase.New()
    End Sub

#Region "Properties"

    Public ReadOnly Property TemperatureUnits() As ITemperatureClass.UnitsEnum Implements ITemperatureClass.TemperatureUnits
        Get
            Return Items(ITemperatureClass.TemperatureItems.TempUnits)
        End Get

    End Property

    Public Property GaugeTemperature() As Double Implements ITemperatureClass.GaugeTemperature


    Public ReadOnly Property EVCTemperature() As Double Implements ITemperatureClass.EVCTemperature
        Get
            Return Items(ITemperatureClass.TemperatureItems.GasTemp)
        End Get
    End Property

    Public ReadOnly Property EVCFactor() As Double Implements ITemperatureClass.EVCFactor
        Get
            Return Items(ITemperatureClass.TemperatureItems.TempFactor)
        End Get
    End Property

    Public ReadOnly Property BaseTemperature() As Double Implements ITemperatureClass.BaseTemperature
        Get
            Return Items(ITemperatureClass.TemperatureItems.BaseTemp)
        End Get

    End Property

    Public ReadOnly Property TemperatureFactor() As Double Implements ITemperatureClass.TemperatureFactor
        Get
            If TemperatureUnits = ITemperatureClass.UnitsEnum.C Or TemperatureUnits = ITemperatureClass.UnitsEnum.K Then
                Return (MetericTempCorrection + BaseTemperature) / (GaugeTemperature + MetericTempCorrection)
            ElseIf TemperatureUnits = ITemperatureClass.UnitsEnum.F Or TemperatureUnits = ITemperatureClass.UnitsEnum.R Then
                Return (TempCorrection + BaseTemperature) / (GaugeTemperature + TempCorrection)
            End If

            Return 0
        End Get
    End Property

    Public ReadOnly Property PercentError() As Double Implements ITemperatureClass.PercentError
        Get
            Return ((EVCFactor - TemperatureFactor) / TemperatureFactor) * 100
        End Get
    End Property

    ReadOnly Property hasPassed As Boolean Implements ITemperatureClass.hasPassed
        Get
            If PercentError < 1 And PercentError > -1 Then
                Return True
            Else
                Return False
            End If
        End Get
    End Property

#End Region

#Region "Methods"

    Public Function Convert(ByVal Value As Double) As Double

        'Convert to Fahrenheit first
        Select Case _PreviousUnits
            Case ITemperatureClass.UnitsEnum.C
                Value = (Value * 1.8) + 32
            Case ITemperatureClass.UnitsEnum.F
                Value = Value / 1
            Case ITemperatureClass.UnitsEnum.K
                Value = ((Value - 273.15) * 1.8) + 32
            Case ITemperatureClass.UnitsEnum.R
                Value = Value - 459.67
        End Select

        'And then to the current Units
        Select Case TemperatureUnits
            Case ITemperatureClass.UnitsEnum.C
                Value = (Value - 32) / 1.8
            Case ITemperatureClass.UnitsEnum.F
                Value = Value * 1
            Case ITemperatureClass.UnitsEnum.K
                Value = ((Value - 32) / 1.8) + 273.15
            Case ITemperatureClass.UnitsEnum.R
                Value = Value + 459.67
        End Select

        Return Math.Round(Value, 2)
    End Function

    Public Function ConvertToF(ByVal Value As Double, ByVal FromUnit As ITemperatureClass.UnitsEnum) As Double
        'Convert to Fahrenheit first
        Select Case FromUnit
            Case ITemperatureClass.UnitsEnum.C
                Value = (Value * 1.8) + 32
            Case ITemperatureClass.UnitsEnum.F
                Value = Value / 1
            Case ITemperatureClass.UnitsEnum.K
                Value = ((Value - 273.15) * 1.8) + 32
            Case ITemperatureClass.UnitsEnum.R
                Value = Value - 459.67
        End Select
        Return Value
    End Function


#End Region

End Class
