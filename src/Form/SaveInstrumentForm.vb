Public Class SaveInstrumentForm

    Private Sub SaveInstrumentForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler Instrument.TotalItems, AddressOf Total
        AddHandler Instrument.ItemStored, AddressOf ItemStored

    End Sub

    Public Sub Total(ByVal TotalItems As Integer)
        ProgressBar.Value = 0
        ProgressBar.Maximum = TotalItems
        Application.DoEvents()
    End Sub

    Public Sub ItemStored(ByVal ItemNumber As Integer)
        If ProgressBar.Value >= ProgressBar.Maximum Then
            ProgressBar.Value = 0
        End If
        ProgressBar.Value += 1
        Application.DoEvents()
    End Sub
End Class