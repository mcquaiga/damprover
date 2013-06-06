Imports Microsoft.Practices.Unity
Imports Microsoft.Practices.Prism
Imports Microsoft.Practices.Prism.Regions
Imports Microsoft.Practices.Prism.Modularity
Imports Prover
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
        '_container.RegisterType(Of IInstrumentDetailsVM, InstrumentDetailsVM)("InstrumentDetails")
    End Sub

    Public Sub Initialize() Implements IModule.Initialize

    End Sub
End Class
