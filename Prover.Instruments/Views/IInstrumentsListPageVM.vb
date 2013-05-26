Imports System.Windows.Input
Imports System.Collections
Imports Prover.Instruments.Prover

Public Interface IInstrumentsListPageVM

    Property Instruments As IObservable(Of IBaseInstrument)

End Interface


