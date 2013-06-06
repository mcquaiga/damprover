Imports System.ComponentModel.Composition
Imports Prover.Instruments.View.ViewModels

Public Class InstrumentsListPage
    Implements IView(Of IInstrumentsListPageVM)

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Sub New(viewModel As IInstrumentsListPageVM)

        DataContext = viewModel
        InitializeComponent()

    End Sub
    Public Property DataContext1 As IInstrumentsListPageVM Implements IView(Of IInstrumentsListPageVM).DataContext
End Class
