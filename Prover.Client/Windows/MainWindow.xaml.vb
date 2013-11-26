Imports Microsoft.Practices.Unity
Imports Microsoft.Practices.Prism.Regions

Public Class MainWindow
    Implements IView(Of IMainVM)

    Private _container As IUnityContainer
    Private _regionManager As IRegionManager

    Sub New()

        InitializeComponent()
    End Sub

    Sub New(Container As IUnityContainer, RegionManager As IRegionManager, viewModel As IMainVM)
        DataContext = viewModel
        _container = Container
        _regionManager = RegionManager
        InitializeComponent()
    End Sub

    Public Property DataContext1 As IMainVM Implements IView(Of IMainVM).DataContext

    Private Sub MainWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        ' _container.Resolve(Of NotificationsView)()
        '_regionManager.Regions(RegionNames.NotificationRegion).Add(_container.Resolve(Of INotificationManager))
        '_regionManager.Regions(RegionNames.NotificationRegion).Activate(_container.Resolve(Of INotificationManager))
    End Sub
End Class
