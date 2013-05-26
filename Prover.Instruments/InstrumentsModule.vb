Imports Microsoft.Practices.Prism.Regions
Imports Microsoft.Practices.Unity
Imports Microsoft.Practices.Prism.Modularity
Imports Prover


Public Class InstrumentsModule
    Implements IModule

    Private _container As IUnityContainer
    Private _regionManager As IRegionManager

    Public Sub New(Container As IUnityContainer, RegionManager As IRegionManager)
        _container = Container
        _regionManager = RegionManager
    End Sub

    Protected Overridable Sub RegisterTypes()
    End Sub

    Public Sub Initialize() Implements IModule.Initialize
        Dim toolbar As IToolBarVM = _container.Resolve(Of IToolBarVM)()
        _regionManager.Regions(RegionNames.ToolbarRegion).Add(toolbar)
        _regionManager.Regions(RegionNames.ToolbarRegion).Activate(toolbar)

        ' _regionManager.RegisterViewWithRegion(RegionNames.ToolbarRegion, GetType(ToolbarView))
        _regionManager.RegisterViewWithRegion(RegionNames.ContentRegion, GetType(InstrumentsListPage))
    End Sub
End Class
