Public Class OldStatusForm

    Dim miSrl As miSerialProtocol.miSerialProtocolClass

    Private Sub OldStatusForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler miSerialProtocol.miSerialProtocolClass.ItemCount, AddressOf ItemCount
        AddHandler miSerialProtocol.miSerialProtocolClass.CurrentItemProgress, AddressOf CurrentProgress
        AddHandler miSerialProtocol.miSerialProtocolClass.CommStateChanged, AddressOf CommState
    End Sub


    Private Sub ItemCount(ByVal Item As Integer)
        ProgressBar.Maximum = Item
        Application.DoEvents()
    End Sub

    Private Sub CurrentProgress(ByVal Item As Integer)
        ProgressBar.Value = Item
        Application.DoEvents()
    End Sub

    Private Sub CommState(ByVal State As miSerialProtocol.CommStateEnum)
        StatusLabel.Text = State.ToString
        Application.DoEvents()
    End Sub

End Class