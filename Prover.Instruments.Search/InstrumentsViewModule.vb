Imports Microsoft.Practices.Unity
Imports Microsoft.Practices.Prism
Imports Microsoft.Practices.Prism.Regions
Imports Microsoft.Practices.Prism.Modularity
Imports Microsoft.Practices.Prism.Events
Imports Prover
Imports Prover.Instruments.View.ViewModels

<Modularity.Module(ModuleName:="InstrumentsView", OnDemand:=False)> _
Public Class InstrumentsViewModule
    Implements IModule, IProverModule



    Private _container As IUnityContainer
    Private _regionManager As IRegionManager
    Private _events As IEventAggregator
    Private _moduleItems As List(Of IProverModule)

    Private _Title

    Private _startCommand As New Microsoft.Practices.Prism.Commands.DelegateCommand(Of Object)(AddressOf ShowInstrumentsSubMenu, AddressOf CanStartInstrumentListView)

    Private _startNewTestCommand As New Microsoft.Practices.Prism.Commands.DelegateCommand(Of Object)(AddressOf StartNewTestCommand)

    Public Sub New(Container As IUnityContainer, RegionManager As IRegionManager, events As IEventAggregator)
        _container = Container
        _regionManager = RegionManager
        _events = events
    End Sub

    Protected Overridable Sub RegisterTypes()
        _container.RegisterType(Of IMainMenuVM, MainMenuVM)()
        _container.RegisterType(Of IView(Of IMainMenuVM), MainMenu)("InstrumentsMainMenu")

        _container.RegisterType(Of IInstrumentDetailsVM, InstrumentDetailsVM)()
        _container.RegisterType(Of IView(Of IInstrumentDetailsVM), InstrumentDetails)()
        _container.RegisterType(Of Object, InstrumentDetails)("InstrumentDetails")

    End Sub

    Public Sub Initialize() Implements IModule.Initialize

        RegisterTypes()
        '_regionManager.RegisterViewWithRegion(RegionNames.MainRegion, GetType(MainMenu))
        _regionManager.Regions(RegionNames.MenuRegion).Add(Me)
        _regionManager.Regions(RegionNames.MenuRegion).Activate(Me)

    End Sub


    Public ReadOnly Property StartCommand() As System.Windows.Input.ICommand Implements IProverModule.StartCommand
        Get
            Return _startCommand
        End Get
    End Property

    Public ReadOnly Property Title As String Implements IProverModule.Title
        Get
            Return "Instruments"
        End Get
    End Property


    Private Sub ShowInstrumentsSubMenu()
        Dim NewTest As ProverModule = New ProverModule("New Test", _startNewTestCommand, "Begin testing a new instrument.", Nothing)
        _regionManager.Regions(RegionNames.SubMenuRegion).Add(NewTest)
    End Sub

    Private Sub StartNewTestCommand()
        _regionManager.RequestNavigate(RegionNames.MainRegion, New Uri("InstrumentDetails", UriKind.Relative))
    End Sub

    Private Function CanStartInstrumentListView() As Boolean
        Return True
    End Function

    Public ReadOnly Property IconUri As String Implements IProverModule.Icon
        Get
            Return Nothing
        End Get
    End Property

    Public ReadOnly Property ToolTipText As String Implements IProverModule.ToolTipText
        Get
            Return Nothing
        End Get
    End Property
End Class