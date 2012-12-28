
Public Class EditInstrumentForm

    Private instr_id As Integer

    Private Sub Close2Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Close2Button.Click
        Me.Close()
    End Sub

    Private Sub EditInstrumentForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        instr_id = CDbl(InputBox("Enter Instrument Id:", "Instrument"))

        PressureTableAdapter.Fill(InstrumentInformationDataSet.pressure, instr_id)
        TemperatureTableAdapter.Fill(InstrumentInformationDataSet.temperature, instr_id)
    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click

    End Sub


    Private Sub TempDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TempDataGridView.CellContentClick

    End Sub


    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class