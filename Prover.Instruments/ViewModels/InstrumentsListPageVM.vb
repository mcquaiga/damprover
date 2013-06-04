Imports Prover.Instruments.Data
Imports System.Collections.ObjectModel

Namespace ViewModels
    Public Class InstrumentsListPageVM
        Implements IInstrumentsListPageVM

        Dim oneMonth As New TimeSpan(30, 0, 0, 0)
        Dim oneWeek As New TimeSpan(7, 0, 0, 0)
        Dim _InstrumentProvider As InstrumentDataProvider

        Private _instrs As ObservableCollection(Of IBaseInstrument)

        Public ReadOnly Property Instruments As ObservableCollection(Of IBaseInstrument) Implements IInstrumentsListPageVM.Instruments
            Get
                Return _instrs
            End Get
        End Property

        Sub New()
            _InstrumentProvider = New InstrumentDataProvider
            _instrs = New ObservableCollection(Of IBaseInstrument)
            MiniMaxInstrument()
        End Sub

        Public Sub MiniMaxInstrument()
            Dim items As IEnumerable(Of IBaseInstrument) = _InstrumentProvider.GetInstrumentByInstrumentType("MiniMaxInstruments")

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

#End Region

        Public Event PropertyChanged(ByVal sender As Object, ByVal e As System.ComponentModel.PropertyChangedEventArgs) Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        Private Sub NotifyPropertyChanged(ByVal propname As String)
            RaiseEvent PropertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propname))
        End Sub




    End Class
End Namespace


