
Imports Prover.Instruments.Data
Imports System.Object
Imports System.ComponentModel
Imports System.Collections.ObjectModel
Imports Microsoft.Practices.Prism.Events
Imports Prover.Certificates.Data
Imports Raven.Client.Document
Imports Raven.Client.Linq
Imports Microsoft.Practices.Unity
Imports Microsoft.Practices.Prism
Imports Microsoft.Practices.Prism.Regions
Imports Microsoft.Practices.Prism.Modularity
Imports System.Windows.Xps
Imports System.Windows.Xps.Packaging
Imports System.IO


Namespace ViewModels
    Public Class CertificateFootViewModel
        Implements ICertificateFootViewModel, INotifyPropertyChanged

        Public Property Certificate As ICertificate


        Private _events As IEventAggregator
        Private _instrs As ObservableCollection(Of InstrumentsListViewModel)
        Private _container As IUnityContainer
        Private _regionManager As IRegionManager

        Sub New(Container As IUnityContainer, RegionManager As IRegionManager, events As IEventAggregator)
            _events = events
            _instrs = New ObservableCollection(Of InstrumentsListViewModel)
            _container = Container
            _regionManager = RegionManager
        End Sub

        Public ReadOnly Property InstrumentCount As Integer
            Get
                Return Certificate.Instruments.Count
            End Get
        End Property

        Public Event PropertyChanged(sender As Object, e As PropertyChangedEventArgs) Implements INotifyPropertyChanged.PropertyChanged
    End Class
End Namespace

