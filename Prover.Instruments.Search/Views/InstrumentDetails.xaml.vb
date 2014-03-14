Imports System.ComponentModel.Composition
Imports Prover.Instruments.View.ViewModels
Imports Microsoft.Practices.Prism.Regions

Public Class InstrumentDetails
    Implements IView(Of IInstrumentDetailsVM), IRegionMemberLifetime

    Sub New()
        InitializeComponent()
    End Sub

    Sub New(viewModel As IInstrumentDetailsVM)
        DataContext = viewModel
        InitializeComponent()
    End Sub

    Public Property DataContext1 As IInstrumentDetailsVM Implements IView(Of IInstrumentDetailsVM).DataContext

    Public ReadOnly Property KeepAlive As Boolean Implements IRegionMemberLifetime.KeepAlive
        Get
            Return False
        End Get
    End Property

    Private Sub UserControl_Initialized(sender As Object, e As EventArgs)
        If My.Settings.InstrumentType = "MiniMax" Then
            MiniMax.IsChecked = True
        ElseIf My.Settings.InstrumentType = "EC300" Then
            EC300.IsChecked = True
        End If

    End Sub

    Private Sub MiniMax_Checked(sender As Object, e As RoutedEventArgs) Handles MiniMax.Checked
        If MiniMax.IsChecked = True Then
            My.Settings.InstrumentType = "MiniMax"
        End If
    End Sub

    Private Sub EC300_Checked(sender As Object, e As RoutedEventArgs) Handles EC300.Checked
        If EC300.IsChecked = True Then
            My.Settings.InstrumentType = "EC300"
        End If
    End Sub
End Class
