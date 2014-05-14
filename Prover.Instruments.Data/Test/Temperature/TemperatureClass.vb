Imports Prover.Instruments.Data
Imports miSerialProtocol
Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Public Class TemperatureClass
    Implements INotifyPropertyChanged

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

    Public Property HasPassed As Boolean
        Get
            Return Tests(0).hasPassed And Tests(1).hasPassed And Tests(2).hasPassed
        End Get
        Set(value As Boolean)

        End Set
    End Property

    Public ReadOnly Property Range As String
        Get
            Return "-40 - 150 " + TemperatureUnits
        End Get
    End Property

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
        NotifyPropertyChanged("Tests")
    End Function



    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    ' This method is called by the Set accessor of each property. 
    ' The CallerMemberName attribute that is applied to the optional propertyName 
    ' parameter causes the property name of the caller to be substituted as an argument. 
    Private Sub NotifyPropertyChanged(<CallerMemberName()> Optional ByVal propertyName As String = Nothing)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub
End Class
