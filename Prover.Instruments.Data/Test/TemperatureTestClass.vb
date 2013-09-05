Imports Prover.Instruments.Data
Imports miSerialProtocol

Public Class TemperatureTestClass
    Implements ITemperatureTestClass

    Const TempCorrection As Double = 459.67
    Const MetericTempCorrection As Double = 273.15

    Private _levelIndex As Integer

    Sub New(Level As Integer, Items As List(Of ItemClass), Units As String, BaseTemperature As Double)
        MyBase.New()
        _levelIndex = Level

        Me.TestItems = New List(Of ItemClass)
        Me.TestItems = Items.Where(Function(x) x.IsTemperatureTest = True).ToList
        Me.Units = Units
        Me.BaseTemperature = BaseTemperature
    End Sub

#Region "Properties"

    Public Property TestItems As List(Of ItemClass) Implements ITemperatureTestClass.Items
    Public Property Units As String Implements ITemperatureTestClass.TemperatureUnits
    Public Property BaseTemperature As Double Implements ITemperatureTestClass.BaseTemperature
    Public Property GaugeTemperature() As Double Implements ITemperatureTestClass.GaugeTemperature


    Public ReadOnly Property EVCTemperature() As Double Implements ITemperatureTestClass.EVCTemperature
        Get
            If TestItems IsNot Nothing Then Return TestItems.Where(Function(x) x.Number = ITemperatureTestClass.TemperatureItems.GasTemp).SingleOrDefault.NumericValue
            Return Nothing
        End Get
    End Property

    Public ReadOnly Property EVCFactor() As Double Implements ITemperatureTestClass.EVCFactor
        Get
            If TestItems IsNot Nothing Then Return TestItems.Where(Function(x) x.Number = ITemperatureTestClass.TemperatureItems.TempFactor).SingleOrDefault.NumericValue
            Return Nothing
        End Get
    End Property

    Public ReadOnly Property TemperatureFactor() As Double Implements ITemperatureTestClass.TemperatureFactor
        Get
            If Units = "C" Or Units = "K" Then
                Return Math.Round((MetericTempCorrection + BaseTemperature) / (GaugeTemperature + MetericTempCorrection), 4)
            ElseIf Units = "F" Or Units = "R" Then
                Return Math.Round((TempCorrection + BaseTemperature) / (GaugeTemperature + TempCorrection), 4)
            End If

            Return 0
        End Get
    End Property

    Public ReadOnly Property PercentError() As Double Implements ITemperatureTestClass.PercentError
        Get
            Return Math.Round(((EVCFactor - TemperatureFactor) / TemperatureFactor) * 100, 2)
        End Get
    End Property

    ReadOnly Property hasPassed As Boolean Implements ITemperatureTestClass.hasPassed
        Get
            If PercentError < 1 And PercentError > -1 Then
                Return True
            Else
                Return False
            End If
        End Get
    End Property

    Public ReadOnly Property LevelIndex As Integer Implements ITemperatureTestClass.LevelIndex
        Get
            Return _levelIndex
        End Get
    End Property

    Public ReadOnly Property LevelDescription As String Implements ITemperatureTestClass.LevelDescription
        Get
            Return "T" + CStr(_levelIndex)
        End Get
    End Property

#End Region

#Region "Methods"

    Public Async Function DownloadTemperatureTestItems(InstrumentType As InstrumentTypeCode) As Task Implements ITemperatureTestClass.DownloadTestItems
        Me.TestItems = Await BaseInstrument.DownloadItems(InstrumentType, Me.TestItems)
    End Function


#End Region


End Class
