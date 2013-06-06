
Imports System.Windows.Input
Imports System.Collections.ObjectModel
Imports Prover.Instruments.Data
Imports System.ComponentModel

Namespace ViewModels
    Public Interface IInstrumentDetailsVM
        Inherits INotifyPropertyChanged

        Property Instrument As IBaseInstrument

    End Interface
End Namespace
