Imports System.Windows.Input
Imports System.Collections.ObjectModel
Imports Prover.Instruments.Data
Imports System.ComponentModel

Namespace ViewModels


    Public Interface IInstrumentsListPageVM
        Inherits INotifyPropertyChanged

        ReadOnly Property Instruments As ObservableCollection(Of IBaseInstrument)

        ReadOnly Property OneWeekFilterCommand As ICommand
        ReadOnly Property OneMonthFilterCommand As ICommand

        ReadOnly Property OnSerialFilterChange As ICommand

        Property SelectedJob As IBaseInstrument

        Sub UnselectJob()

    End Interface
End Namespace

