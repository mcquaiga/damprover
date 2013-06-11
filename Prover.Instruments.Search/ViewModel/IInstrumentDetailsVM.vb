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
        ReadOnly Property BaudRates As List(Of Integer, String)

        'Commands
        ReadOnly Property FetchInstrumentInfoCommand As ICommand
        ReadOnly Property SetBaudRateCommand As ICommand


    End Interface
End Namespace
