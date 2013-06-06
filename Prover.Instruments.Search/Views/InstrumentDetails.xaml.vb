Imports System.ComponentModel.Composition
Imports Prover.Instruments.View.ViewModels

Public Class InstrumentDetails
    Implements IView(Of IInstrumentDetailsVM)


    Sub New()
        InitializeComponent()
    End Sub

    Sub New(viewModel As IInstrumentDetailsVM)
        DataContext = viewModel
        InitializeComponent()
    End Sub

    Public Property DataContext1 As IInstrumentDetailsVM Implements IView(Of IInstrumentDetailsVM).DataContext
End Class
