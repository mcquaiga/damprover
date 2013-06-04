Imports System.Windows.Input
Imports System.Collections.ObjectModel
Imports Prover.Instruments.Data
Imports System.ComponentModel

Public Interface IInstrumentsListPageVM
    Inherits INotifyPropertyChanged

    ReadOnly Property Instruments As ObservableCollection(Of IBaseInstrument)

    ReadOnly Property OneWeekFilterCommand As ICommand
    ReadOnly Property OneMonthFilterCommand As ICommand

    ReadOnly Property OnSerialFilterChange As ICommand



End Interface


