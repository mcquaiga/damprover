Imports System.Windows.Input
Imports System.Collections.ObjectModel
Imports Prover.Instruments.Data
Imports System.ComponentModel

Namespace ViewModels
    Public Interface ICreateCertificateListVM
        Inherits INotifyPropertyChanged

        ReadOnly Property Instruments As ObjectModel.ObservableCollection(Of IBaseInstrument)


        ReadOnly Property AddNewCommand As ICommand

        ReadOnly Property OneMonthFilterCommand As ICommand

        ReadOnly Property OnSerialFilterChange As ICommand

        ReadOnly Property OneWeekFilterCommand As ICommand

        WriteOnly Property UnselectJob As IBaseInstrument

        WriteOnly Property SelectedInstrument As IBaseInstrument



    End Interface
End Namespace
