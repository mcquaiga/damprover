Imports System.ComponentModel
Imports System.Collections.ObjectModel
Imports Microsoft.Practices.Prism.Events
Imports Prover.Instruments.Data
Imports miSerialProtocol


Namespace ViewModels
    Public Interface IInstrumentDetailsVM
        Inherits INotifyPropertyChanged


        Property Instrument As IBaseInstrument
        ReadOnly Property BaudRates As List(Of String)

        'Commands
        ReadOnly Property FetchInstrumentInfoCommand As ICommand
        ReadOnly Property SetBaudRateCommand As ICommand

        ReadOnly Property setCommPortCommand As ICommand

        ReadOnly Property SaveCommand As ICommand

        ReadOnly Property MiniMaxCommand As ICommand

        ReadOnly Property FetchPressureItemsByLevelCommand As ICommand

        ReadOnly Property FetchTemperatureItemsByLevelCommand As ICommand

        ReadOnly Property CommPorts As List(Of String)

        ReadOnly Property EC300Command As ICommand


    End Interface
End Namespace
