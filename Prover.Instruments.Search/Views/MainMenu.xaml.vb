Imports Prover.Instruments.Data
Imports System.ComponentModel
Imports System.Collections.ObjectModel
Imports Microsoft.Practices.Prism.Events
Imports Prover.Instruments.View.ViewModels

Public Class MainMenu
    Implements IView(Of IMainMenuVM)


    Sub New()
        InitializeComponent()
    End Sub

    Sub New(viewModel As IMainMenuVM)
        DataContext = viewModel
        InitializeComponent()
    End Sub

    Public Property DataContext1 As IMainMenuVM Implements IView(Of IMainMenuVM).DataContext
End Class

