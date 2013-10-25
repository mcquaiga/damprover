Imports Prover.Instruments.Data
Imports miSerialProtocol
Imports System.Collections.ObjectModel

Public Class TemperatureClass

    Public Property TemperatureItems As List(Of ItemClass)
    Public Property Tests As ObservableCollection(Of ITemperatureTestClass)

    Sub New(Items As List(Of ItemClass))
        Tests = New ObservableCollection(Of ITemperatureTestClass)
        If Not Items Is Nothing Then
            Me.TemperatureItems = Items.Where(Function(x) x.IsTemperature = True).ToList
            Tests.Add(New TemperatureTestClass(0, Items, TemperatureUnits, BaseTemperature))
            Tests.Add(New TemperatureTestClass(1, Items, TemperatureUnits, BaseTemperature))
            Tests.Add(New TemperatureTestClass(2, Items, TemperatureUnits, BaseTemperature))
        End If
    End Sub


    Public ReadOnly Property TemperatureUnits() As String
        Get
            If TemperatureItems IsNot Nothing Then Return TemperatureItems.Where(Function(x) x.Number = ITemperatureTestClass.TemperatureItems.TempUnits).SingleOrDefault.DescriptionValue
            Return Nothing
        End Get

    End Property

    Public ReadOnly Property BaseTemperature() As Double
        Get
            If TemperatureItems IsNot Nothing Then Return TemperatureItems.Where(Function(x) x.Number = ITemperatureTestClass.TemperatureItems.BaseTemp).SingleOrDefault.NumericValue
            Return Nothing
        End Get
    End Property

    Public Async Function DownloadTemperatureItems(InstrumentType) As Task
        Me.TemperatureItems = Await BaseInstrument.DownloadItems(InstrumentType, Me.TemperatureItems)
    End Function

    Public Async Function DownloadTemperatureTestItems(InstrumentType As InstrumentTypeCode, LevelIndex As Integer) As Task
        Await Tests(LevelIndex).DownloadTestItems(InstrumentType)
    End Function
End Class
