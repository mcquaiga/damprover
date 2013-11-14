Imports Microsoft.Practices.Prism.Regions

Public Class NotificationsView
    Implements IView(Of INotificationManager), IRegionMemberLifetime

    Sub New()
        InitializeComponent()
    End Sub

    Sub New(viewModel As INotificationManager)
        DataContext = viewModel
        InitializeComponent()
    End Sub

    Public Property DataContext2 As INotificationManager Implements IView(Of INotificationManager).DataContext

    Public ReadOnly Property KeepAlive As Boolean Implements IRegionMemberLifetime.KeepAlive
        Get
            Return True
        End Get
    End Property
End Class
