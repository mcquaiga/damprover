Imports Prover.Instruments.Data
Imports System.ComponentModel
Imports System.Collections.ObjectModel
Imports Microsoft.Practices.Prism.Events


Namespace ViewModels
    Public Class InstrumentsListPageVM
        Implements IInstrumentsListPageVM, INotifyPropertyChanged

        Dim oneMonth As New TimeSpan(30, 0, 0, 0)
        Dim oneWeek As New TimeSpan(7, 0, 0, 0)
        Dim _InstrumentProvider As InstrumentDataProvider

        Private _events As IEventAggregator
        Private _instrs As ObservableCollection(Of IBaseInstrument)

        Public ReadOnly Property Instruments As ObservableCollection(Of IBaseInstrument) Implements IInstrumentsListPageVM.Instruments
            Get
                Return _instrs
            End Get
        End Property

        Sub New(events As IEventAggregator)
            _events = events
            _InstrumentProvider = New InstrumentDataProvider
            _instrs = New ObservableCollection(Of IBaseInstrument)
            'MiniMaxInstrument()
        End Sub

        Public Sub MiniMaxInstrument()
            Dim items As IEnumerable(Of IBaseInstrument) = _InstrumentProvider.GetMiniMaxInstruments("MiniMaxInstruments")

            _instrs.Clear()

            For Each i In items
                _instrs.Add(i)
            Next
            NotifyPropertyChanged("BaseInstruments")
        End Sub

        Public Sub OneWeekFilterClick()
            Dim items As IEnumerable(Of IBaseInstrument) = _InstrumentProvider.GetInstrumentDateCreated(Now.Subtract(oneWeek))

            _instrs.Clear()

            For Each i In items
                _instrs.Add(i)
            Next
            NotifyPropertyChanged("BaseInstruments")
        End Sub

        Public Sub OneMonthFilterClick()

            Dim items As IEnumerable(Of IBaseInstrument) = _InstrumentProvider.GetInstrumentDateCreated(Now.Subtract(oneMonth))

            _instrs.Clear()
            For Each i In items
                _instrs.Add(i)
            Next
            NotifyPropertyChanged("BaseInstruments")
        End Sub

        Public Sub UpdateSerialFilter()

            Dim items As IEnumerable(Of IBaseInstrument) = _InstrumentProvider.GetInstrumentsBySerialNumber("")

            _instrs.Clear()
            For Each i In items
                _instrs.Add(i)
            Next
            NotifyPropertyChanged("BaseInstruments")
        End Sub

        Public Sub AddNewTestClick()
            _events.GetEvent(Of SelectedInstrumentChangedEvent).Publish(Nothing)
        End Sub

#Region "commands"

        Private _oneWeekFilterCommand = New Microsoft.Practices.Prism.Commands.DelegateCommand(AddressOf OneWeekFilterClick)
        Public ReadOnly Property OneWeekFilterCommand As System.Windows.Input.ICommand Implements IInstrumentsListPageVM.OneWeekFilterCommand
            Get
                Return _oneWeekFilterCommand
            End Get
        End Property

        Private _oneMonthFilterCommand = New Microsoft.Practices.Prism.Commands.DelegateCommand(AddressOf OneMonthFilterClick)
        Public ReadOnly Property OneMonthFilterCommand As System.Windows.Input.ICommand Implements IInstrumentsListPageVM.OneMonthFilterCommand
            Get
                Return _oneMonthFilterCommand
            End Get
        End Property

        Private _onSerialFilterCommand = New Microsoft.Practices.Prism.Commands.DelegateCommand(AddressOf OneMonthFilterClick)
        Public ReadOnly Property OnSerialFilterChange As System.Windows.Input.ICommand Implements IInstrumentsListPageVM.OnSerialFilterChange

            Get
                Return _oneMonthFilterCommand
            End Get
        End Property

        Private _addNewCommand = New Microsoft.Practices.Prism.Commands.DelegateCommand(AddressOf AddNewTestClick)
        Public ReadOnly Property AddNewTestCommand As System.Windows.Input.ICommand Implements IInstrumentsListPageVM.AddNewCommand

            Get
                Return _addNewCommand
            End Get
        End Property

#End Region

        Public Event PropertyChanged(ByVal sender As Object, ByVal e As System.ComponentModel.PropertyChangedEventArgs) Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        Private Sub NotifyPropertyChanged(ByVal propname As String)
            RaiseEvent PropertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propname))
        End Sub

        Private _selectedInstrument As IBaseInstrument

        Public Property SelectedInstrument As IBaseInstrument Implements IInstrumentsListPageVM.SelectedJob
            Get
                Return _selectedInstrument
            End Get
            Set(ByVal value As IBaseInstrument)
                If Not value Is _selectedInstrument Then


                    _selectedInstrument = value

                    _events.GetEvent(Of SelectedInstrumentChangedEvent).Publish(_selectedInstrument)
                    NotifyPropertyChanged("SelectedInstrument")
                End If
            End Set
        End Property

        Public Sub UnselectInstrument() Implements IInstrumentsListPageVM.UnselectJob
            _selectedInstrument = Nothing
            NotifyPropertyChanged("SelectedInstrument")
        End Sub



    End Class
End Namespace


