Imports Microsoft.Practices.Unity
Imports Microsoft.Practices.Prism
Imports Microsoft.Practices.Prism.Regions
Imports Microsoft.Practices.Prism.Modularity
Imports Microsoft.Practices.Prism.Events
Imports Prover
Imports Prover.Instruments.View.ViewModels

<Modularity.Module(ModuleName:="Dashboard", OnDemand:=False)> _
Public Class DashboardModule
    Implements IModule, IProverModule


    Private _container As IUnityContainer
    Private _regionManager As IRegionManager
    Private _events As IEventAggregator
    Private _moduleItems As List(Of IProverModule)

    Public Sub New(Container As IUnityContainer, RegionManager As IRegionManager, events As IEventAggregator)
        _container = Container
        _regionManager = RegionManager
        _events = events
    End Sub

    Protected Overridable Sub RegisterTypes()
    End Sub

    Public Sub Initialize() Implements IModule.Initialize
        'RegisterTypes()
        _regionManager.Regions(RegionNames.MenuRegion).Add(Me)
        _regionManager.Regions(RegionNames.MenuRegion).Activate(Me)
    End Sub



    Public ReadOnly Property Icon As String Implements IProverModule.Icon
        Get
            Return Nothing
        End Get
    End Property

    Public ReadOnly Property StartCommand As ICommand Implements IProverModule.StartCommand
        Get
            Return Nothing
        End Get
    End Property

    Public ReadOnly Property Title As String Implements IProverModule.Title
        Get
            Return "Dashboard"
        End Get
    End Property

    Public ReadOnly Property ToolTipText As String Implements IProverModule.ToolTipText
        Get
            Return "Home Dashboard"
        End Get
    End Property
End Class
