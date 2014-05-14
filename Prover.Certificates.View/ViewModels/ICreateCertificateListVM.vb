Imports System.Windows.Input
Imports System.Collections.ObjectModel
Imports Prover.Instruments.Data
Imports System.ComponentModel

Namespace ViewModels
    Public Interface ICreateCertificateListVM
        Inherits INotifyPropertyChanged


        ReadOnly Property OneMonthFilterCommand As ICommand

        ReadOnly Property OnSerialFilterChange As ICommand

        ReadOnly Property OneWeekFilterCommand As ICommand

        Property CreatedBy As String

        ReadOnly Property MiniMaxFilterCommand As ICommand

        ReadOnly Property EC300FilterCommand As ICommand

        Property Instruments As ObservableCollection(Of InstrumentsListViewModel)

        ReadOnly Property CreateNewCertCommand As ICommand

        ReadOnly Property ResetFilterCommand As ICommand

        Property VerificationType As String

        ReadOnly Property SealExpirationDate As String

    End Interface
End Namespace
