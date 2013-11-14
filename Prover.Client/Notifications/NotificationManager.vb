Imports Microsoft.Practices.Prism.Regions
Imports Microsoft.Practices.Unity
Imports System.ComponentModel
Imports Microsoft.Practices.Unity.UnityContainerExtensions
Imports Microsoft.Practices.Prism.Events

Public Class NotificationManager
    Implements INotificationManager

    Private _regions As IRegionManager
    Private _container As IUnityContainer
    Private _events As IEventAggregator

    Property Message As String


    Public Sub New(Container As IUnityContainer, RegionManager As IRegionManager, Events As IEventAggregator)
        _container = Container
        _regions = RegionManager
        _events = Events

        _events.GetEvent(Of ProverNotification).Subscribe(AddressOf UpdateNotifications(Of INotification))

        RegionManager.Regions(RegionNames.NotificationRegion).Add(Me)
        RegionManager.Regions(RegionNames.NotificationRegion).Activate(Me)
    End Sub


    Private Sub UpdateNotifications(Of INotification)()

    End Sub


#Region "Properties"


#End Region
End Class
