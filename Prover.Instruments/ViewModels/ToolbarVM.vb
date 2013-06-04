Imports Microsoft.Practices.Prism
Imports Microsoft.Practices.Prism.Events
Imports Microsoft.Practices.Prism.Regions
Imports Microsoft.Practices.Unity
Imports Microsoft.Practices.Prism.Modularity
Imports ReactiveUI


Namespace ViewModels

    Public Class ToolbarVM
        Implements IToolBarVM

        Private _container As UnityContainer
        Private _regionManager As RegionManager
        Private _moduleItems As List(Of IProverModule)

        Protected _testPage As ReactiveObject
        Protected _searchPage As ReactiveObject

        Public Event PropertyChanged(ByVal sender As Object, ByVal e As System.ComponentModel.PropertyChangedEventArgs) Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        Private Sub NotifyPropertyChanged(ByVal propname As String)
            RaiseEvent PropertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propname))
        End Sub

        Sub New()
            LoadModuleItems()
        End Sub

        'Sub New(events As IEventAggregator)

        'End Sub

        'Sub New(Container As IUnityContainer, RegionManager As IRegionManager)
        '    _container = Container
        '    _regionManager = RegionManager
        '    LoadModuleItems()
        'End Sub

        Protected Sub StartTestPage(ByVal param As Object)
            '_searchPage = New InstrumentsListPageVM()

            '_regionManager.Regions.Add(RegionNames.ContentRegion, InstrumentTest)
        End Sub

        Protected Sub StartSearchPage(ByVal param As Object)
            Dim InstrumentSearch = _container.Resolve(Of IInstrumentsListPageVM)()
            _regionManager.RegisterViewWithRegion(RegionNames.ContentRegion, GetType(InstrumentsListPage))
        End Sub

        Private _startsearch As New Commands.DelegateCommand(Of Object)(AddressOf StartSearchPage, Function(o) (True))
        Public ReadOnly Property StartSearchCommand() As System.Windows.Input.ICommand
            Get
                Return _startsearch
            End Get
        End Property

        Private _startTests As New Commands.DelegateCommand(Of Object)(AddressOf StartTestPage, Function(o) (True))
        Public ReadOnly Property StartTestCommand() As System.Windows.Input.ICommand
            Get
                Return _startTests
            End Get
        End Property

        Private Sub LoadModuleItems()
            _moduleItems = New List(Of IProverModule)

            _moduleItems.Add(New ProverModule("Run Test", "/Prover.Instruments;component/Themes/Test.png", "Run an Instrument Test", StartTestCommand))
            _moduleItems.Add(New ProverModule("Search", "/Prover.Instruments;component/Themes/Search.png", "Search for an Instrument", StartSearchCommand))

        End Sub

        Public ReadOnly Property ModuleItems As List(Of IProverModule)
            Get
                Return _moduleItems
            End Get
        End Property
    End Class
End Namespace