Imports Microsoft.Practices.Prism.Events
Imports Microsoft.Practices.Unity
Imports Microsoft.Practices.Prism.Regions

Namespace ViewModels
    Public Class MainMenuVM
        Implements IMainMenuVM

        Private _events As IEventAggregator
        Private _container As IUnityContainer
        Private _regionManager As IRegionManager

        Sub New(Container As IUnityContainer, RegionManager As IRegionManager, events As IEventAggregator)
            _events = events
            _regionManager = RegionManager
            _container = Container

            _container.RegisterType(Of IInstrumentsListPageVM, InstrumentsListPageVM)("InstrumentsListPageVM")
            _container.RegisterType(Of IView(Of IInstrumentsListPageVM), InstrumentsListPage)("InstrumentsListPageView")

 
        End Sub

        Private _startNewTestCommand = New Microsoft.Practices.Prism.Commands.DelegateCommand(AddressOf StartNewTestView)
        Public ReadOnly Property StartNewTestCommand As ICommand Implements IMainMenuVM.StartNewTestView
            Get
                Return _startNewTestCommand
            End Get
        End Property

        Private Sub StartNewTestView()
            _container.RegisterType(Of IInstrumentDetailsVM, InstrumentDetailsVM)()
            _container.RegisterType(Of IView(Of IInstrumentDetailsVM), InstrumentDetails)()
            _container.RegisterType(Of Object, InstrumentDetails)("Details")

            _regionManager.Regions(RegionNames.MainRegion).RequestNavigate(New Uri("Details", UriKind.Relative))
        End Sub

        Private _startViewInstrumentsCommand = New Microsoft.Practices.Prism.Commands.DelegateCommand(AddressOf StartViewInstruments)
        Public ReadOnly Property StartViewInstrumentsCommand As ICommand Implements IMainMenuVM.StartViewInstrumentsCommand
            Get
                Return _startViewInstrumentsCommand

            End Get
        End Property

        Private Sub StartViewInstruments()
            _container.RegisterType(Of IInstrumentsListPageVM, InstrumentsListPageVM)()
            _container.RegisterType(Of IView(Of IInstrumentsListPageVM), InstrumentsListPage)()
            _container.RegisterType(Of Object, InstrumentListAndDetails)("ViewInstruments")

            _regionManager.Regions(RegionNames.MainRegion).RequestNavigate(New Uri("ViewInstruments", UriKind.Relative))
        End Sub

    End Class
End Namespace

