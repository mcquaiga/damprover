Imports System.Collections.ObjectModel

Public Interface ICreateCertificateListVM


    ReadOnly Property Instruments As ObjectModel.ObservableCollection(Of IBaseInstrument)


    ReadOnly Property AddNewCommand As ICommand

    ReadOnly Property OneMonthFilterCommand As ICommand

    ReadOnly Property OnSerialFilterChange As ICommand

    ReadOnly Property OneWeekFilterCommand As ICommand

    WriteOnly Property UnselectJob As IBaseInstrument

    WriteOnly Property SelectedInstrument As IBaseInstrument



End Interface
