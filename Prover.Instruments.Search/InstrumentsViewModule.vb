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

    Private _Title

    Private _startCommand As New Microsoft.Practices.Prism.Commands.DelegateCommand(Of Object)(AddressOf StartInstrumentListView, AddressOf CanStartInstrumentListView)



    Public Sub New(Container As IUnityContainer, RegionManager As IRegionManager, events As IEventAggregator)
        _container = Container
        _regionManager = RegionManager
        _events = events
    End Sub

    Protected Overridable Sub RegisterTypes()
        _container.RegisterType(Of IInstrumentsListPageVM, InstrumentsListPageVM)("InstrumentsListPageVM")
        _container.RegisterType(Of IView(Of IInstrumentsListPageVM), InstrumentsListPage)("InstrumentsListPageView")

        _container.RegisterType(Of IInstrumentDetailsVM, InstrumentDetailsVM)()
        _container.RegisterType(Of IView(Of IInstrumentDetailsVM), InstrumentDetails)("InstrumentDetailsView")

        _container.RegisterType(Of IToolBarVM, ToolBarVM)("ToolBar")
        _container.RegisterType(Of IView(Of IToolBarVM), ToolBar)("ToolBarview")

    End Sub

    Public Sub Initialize() Implements IModule.Initialize

        RegisterTypes()
        'Dim myView = _container.Resolve(Of IInstrumentsListPageVM)()

        '_regionManager.RegisterViewWithRegion(RegionNames.InstrumentsRegion, GetType(InstrumentsListPage))
        _regionManager.RegisterViewWithRegion(RegionNames.InstrumentsRegion, GetType(ToolBar))

    End Sub


    Public ReadOnly Property StartCommand() As System.Windows.Input.ICommand
        Get
            Return _startCommand
        End Get
    End Property

    Public ReadOnly Property Title As String
        Get
            Return "New Test"
        End Get
    End Property


    Private Sub StartInstrumentListView()
        _regionManager.RequestNavigate(RegionNames.ContentRegion, New Uri("InstrumentDetails", UriKind.Relative))
    End Sub

    Private Function CanStartInstrumentListView() As Boolean
        Return True
    End Function

End Class