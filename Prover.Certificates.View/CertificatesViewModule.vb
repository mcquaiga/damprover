Imports Microsoft.Practices.Unity
Imports Microsoft.Practices.Prism
Imports Microsoft.Practices.Prism.Regions
Imports Microsoft.Practices.Prism.Modularity
Imports Microsoft.Practices.Prism.Events
Imports Prover.Certificates.View.ViewModels

<Modularity.Module(ModuleName:="CertificatesView", OnDemand:=False)> _
Public Class CertificatesViewModule
    Implements IModule, IProverModule


    Private NewCertificate As ProverModule
    Private ViewCertificates As ProverModule

    Private _container As IUnityContainer
    Private _regionManager As IRegionManager
    Private _events As IEventAggregator
    Private _moduleItems As List(Of IProverModule)

    Private _Title

    Private _startCommand As New Microsoft.Practices.Prism.Commands.DelegateCommand(Of Object)(AddressOf ShowCertificatesSubMenu, AddressOf CanStartCertificatesListView)

    Private _startNewCertCommand As New Microsoft.Practices.Prism.Commands.DelegateCommand(Of Object)(AddressOf StartNewCertCommand)
    Private _startViewCertCommand As New Microsoft.Practices.Prism.Commands.DelegateCommand(Of Object)(AddressOf StartViewTestCommand)

    Public Sub New(Container As IUnityContainer, RegionManager As IRegionManager, events As IEventAggregator)
        _container = Container
        _regionManager = RegionManager
        _events = events
    End Sub

    Protected Overridable Sub RegisterTypes()
        ''Create New Certificates
        _container.RegisterType(Of ICreateCertificateListVM, CreateCertificatesListVM)()
        _container.RegisterType(Of IView(Of ICreateCertificateListVM), CreateCertificatesView)()
        _container.RegisterType(Of Object, CreateCertificatesView)("CreateCertificates")

        '_container.RegisterType(Of IInstrumentsListPageVM, InstrumentsListPageVM)()
        '_container.RegisterType(Of IView(Of IInstrumentsListPageVM), InstrumentsListPage)()
        '_container.RegisterType(Of Object, InstrumentsListPage)("InstrumentsList")

    End Sub

    Public Sub Initialize() Implements IModule.Initialize

        RegisterTypes()

        NewCertificate = New ProverModule("Create New Certificate", _startNewCertCommand, "Create a new certificate.", Nothing)
        ViewCertificates = New ProverModule("View Certificates", _startViewCertCommand, "View and Search Certificates.", Nothing)

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
            Return "Certificates"
        End Get
    End Property


    Private Sub ShowCertificatesSubMenu()
        '_regionManager.RequestNavigate(RegionNames.SubMenuRegion, New Uri("Certificates
        '_regionManager.Regions(RegionNames.SubMenuRegion).RequestNavigate(
        _regionManager.Regions(RegionNames.SubMenuRegion).Add(NewCertificate)
        _regionManager.Regions(RegionNames.SubMenuRegion).Add(ViewCertificates)
    End Sub

    Private Sub StartNewCertCommand()
        _regionManager.RequestNavigate(RegionNames.MainRegion, New Uri("CreateCertificates", UriKind.Relative))
    End Sub

    Private Function CanStartCertificatesListView() As Boolean
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

    Private Sub StartViewTestCommand()

    End Sub


End Class

