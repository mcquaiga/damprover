Imports Prover.Instruments.Data
Imports System.ComponentModel
Imports System.Collections.ObjectModel
Imports Microsoft.Practices.Prism.Events
Imports Prover.Instruments.View.ViewModels

Public Class ToolBar
    Implements IView(Of IToolBarVM)

    Sub New()
        InitializeComponent()
    End Sub

    Sub New(viewModel As IToolBarVM)
        DataContext = viewModel
    End Sub

    Public Property DataContext As IToolBarVM Implements IView(Of IToolBarVM).DataContext

End Class
