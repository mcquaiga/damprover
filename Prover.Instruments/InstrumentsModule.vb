Imports Microsoft.Practices.Prism.Regions
Imports Microsoft.Practices.Unity
Imports Microsoft.Practices.Prism.Modularity
Imports Prover
Imports Microsoft.Practices.Prism
Imports Prover.Instruments.ViewModels

<Modularity.Module(ModuleName:="Instruments", OnDemand:=False)> _
Public Class InstrumentsModule
    Implements IModule

    Private _container As IUnityContainer
    Private _regionManager As IRegionManager
    Private _moduleItems As List(Of IProverModule)

    Public Sub New(Container As IUnityContainer, RegionManager As IRegionManager)
        _container = Container
        _regionManager = RegionManager
    End Sub

    Protected Overridable Sub RegisterTypes()
        ' _container.RegisterType(Of IInstrumentsListPageVM, InstrumentsListPageVM)()
        _container.RegisterType(Of IInstrumentDetailsVM, InstrumentDetailsVM)("InstrumentDetails")
    End Sub

    Public Sub Initialize() Implements IModule.Initialize
        '_container.RegisterType(Of IToolBarVM, ToolbarVM)()
        '_container.RegisterType(Of IView(Of IToolBarVM), Toolbar)()
        '_container.RegisterInstance(Of IToolBarVM, ToolbarVM)()
        '_container.RegisterType(Of IToolBarVM, ToolbarVM)()

        ' _container.RegisterType(InstrumentsListPageVM, TypeOf(InstrumentsListPage))
        ' _regionManager.RegisterViewWithRegion(RegionNames.InstrumentsRegion, GetType(ToolbarView))
        RegisterTypes()
        _regionManager.RegisterViewWithRegion(RegionNames.ContentRegion, GetType(InstrumentsListPage))


        'Dim tools As IToolBarVM = _container.Resolve(Of IToolBarVM)()
        '_regionManager.Regions(RegionNames.InstrumentsRegion).Add(tools)
        '_regionManager.Regions(RegionNames.InstrumentsRegion).Activate(tools)

    End Sub
End Class
