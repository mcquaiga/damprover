Imports Microsoft.Practices.Unity
Imports Microsoft.Practices.Prism
Imports Microsoft.Practices.Prism.Regions
Imports Microsoft.Practices.Prism.Modularity
Imports Microsoft.Practices.Prism.Events
Imports Prover

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

    Private _startCommand As New Microsoft.Practices.Prism.Commands.DelegateCommand(Of Object)(AddressOf ShowInstrumentsSubMenu, AddressOf CanStartInstrumentListView)

    Private _startNewTestCommand As New Microsoft.Practices.Prism.Commands.DelegateCommand(Of Object)(AddressOf StartNewTestCommand)
    Private _startViewTestCommand As New Microsoft.Practices.Prism.Commands.DelegateCommand(Of Object)(AddressOf StartViewTestCommand)

    Public Sub New(Container As IUnityContainer, RegionManager As IRegionManager, events As IEventAggregator)
        _container = Container
        _regionManager = RegionManager
        _events = events
    End Sub

    Protected Overridable Sub RegisterTypes()
        'Test and Details


    End Sub

    Public Sub Initialize() Implements IModule.Initialize

        RegisterTypes()

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


    Private Sub ShowInstrumentsSubMenu()
        _regionManager.Regions(RegionNames.SubMenuRegion).Add(NewCertificate)
        _regionManager.Regions(RegionNames.SubMenuRegion).Add(ViewCertificates)
    End Sub

    Private Sub StartNewTestCommand()

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

    Private Sub StartViewTestCommand()

    End Sub


End Class