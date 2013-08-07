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
End Class
