Imports System.ComponentModel
Imports System.Collections.ObjectModel
Imports Microsoft.Practices.Prism.Events
Imports Prover.Instruments.Data
Imports miSerialProtocol


Namespace ViewModels
    Public Interface IInstrumentDetailsVM
        Inherits INotifyPropertyChanged


        Property Instrument As IBaseInstrument
        ReadOnly Property CommPorts As ReadOnlyCollection(Of String)
        ReadOnly Property BaudRates As List(Of String)

        'Commands
        ReadOnly Property FetchInstrumentInfoCommand As ICommand
        ReadOnly Property SetBaudRateCommand As ICommand

        ReadOnly Property setCommPortCommand As ICommand

        ReadOnly Property SaveCommand As ICommand

        ReadOnly Property MiniMaxCommand As ICommand

        ReadOnly Property FetchPressureItemsByLevelCommand As ICommand

        ReadOnly Property FetchTemperatureItemsByLevelCommand As ICommand


    End Interface
End Namespace
