Imports Microsoft.Practices.Prism.Regions
Imports Microsoft.Practices.Unity
Imports System.ComponentModel
Imports Microsoft.Practices.Unity.UnityContainerExtensions
Imports Microsoft.Practices.Prism.Events

Public Class NotificationManager
    Implements INotificationManager

#Region "Properties"

    Private _regionManager As IRegionManager
    Private _regions As IRegionCollection
    Private _container As IUnityContainer
    Private _events As IEventAggregator

    Public Property Message As String

#End Region



    Public Sub New(RegionManager As IRegionManager, EventAggregator As IEventAggregator)
        _regionManager = RegionManager

        If _regions Is Nothing Then
            _regions = _regionManager.Regions
        End If

        EventAggregator.GetEvent(Of GlobalNotificationEvent).Subscribe(New Action(Of String)(AddressOf UpdateNotificationArea), ThreadOption.UIThread)
        Me.Message = "HELLO ADAM"
    End Sub

    Private Sub UpdateNotificationArea(NotificationMessage As String)
        Message = NotificationMessage
    End Sub







End Class
