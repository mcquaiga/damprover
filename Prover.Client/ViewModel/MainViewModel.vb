Imports Microsoft.Practices.Prism.Events
Imports Microsoft.Practices.Unity
Imports Microsoft.Practices.Prism.Regions

Public Class MainViewModel
    Implements IMainVM


    Private _events As IEventAggregator
    Private _container As IUnityContainer
    Private _regionManager As IRegionManager
    Private _regionNavigationService As IRegionNavigationService


    Public Sub New(Container As IUnityContainer, RegionManager As IRegionManager, events As IEventAggregator)
        _events = events
        _container = Container
        _regionManager = RegionManager


        '_regionManager.Regions(RegionNames.NotificationRegion).Add(Container.Resolve(Of INotificationManager))
        '_regionManager.Regions(RegionNames.NotificationRegion).Activate(Container.Resolve(Of INotificationManager))
    End Sub


    Private _homeCommand = New Microsoft.Practices.Prism.Commands.DelegateCommand(Of String)(AddressOf HomeExecute)

    Public ReadOnly Property HomeCommand As ICommand Implements IMainVM.HomeCommand
        Get
            Return _homeCommand
        End Get
    End Property

    Sub HomeExecute()
        ' _regionManager.Regions(RegionNames.InstrumentsRegion).RequestNavigate(New Uri("InstrumentsMainMenu", UriKind.RelativeOrAbsolute))
    End Sub

End Class
