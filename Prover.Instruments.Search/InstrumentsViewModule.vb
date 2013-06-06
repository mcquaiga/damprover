Imports Microsoft.Practices.Unity
Imports Microsoft.Practices.Prism
Imports Microsoft.Practices.Prism.Regions
Imports Microsoft.Practices.Prism.Modularity
Imports Microsoft.Practices.Prism.Events
Imports Prover
Imports Prover.Instruments.View.ViewModels

<Modularity.Module(ModuleName:="InstrumentsView", OnDemand:=False)> _
Public Class InstrumentsViewModule
    Implements IModule

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
        _container.RegisterType(Of IInstrumentsListPageVM, InstrumentsListPageVM)()
        _container.RegisterType(Of IView(Of IInstrumentsListPageVM), InstrumentsListPage)()

        _container.RegisterType(Of IInstrumentDetailsVM, InstrumentDetailsVM)()
        _container.RegisterType(Of IView(Of IInstrumentDetailsVM), InstrumentDetails)()
    End Sub

    Public Sub Initialize() Implements IModule.Initialize

        RegisterTypes()
        'Dim myView = _container.Resolve(Of IInstrumentsListPageVM)()

        '_regionManager.Regions(RegionNames.ContentRegion).Add(myView)
        '_regionManager.Regions(RegionNames.ContentRegion).Activate(myView)
        _regionManager.RegisterViewWithRegion(RegionNames.InstrumentsRegion, GetType(InstrumentsListPage))
        _regionManager.RegisterViewWithRegion(RegionNames.ToolbarRegion, GetType(InstrumentDetails))
    End Sub
End Class