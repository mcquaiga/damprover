Imports Microsoft.Practices.Unity

Public Class MainWindow
    Implements IView(Of IMainVM)

    Private _container As IUnityContainer
    Sub New()
        InitializeComponent()
    End Sub

    Sub New(Container As IUnityContainer, viewModel As IMainVM)
        DataContext = viewModel
        _container = Container
        InitializeComponent()
    End Sub

    Public Property DataContext1 As IMainVM Implements IView(Of IMainVM).DataContext

    Private Sub MainWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        _container.Resolve(Of NotificationsView)()
    End Sub
End Class
