Public Class MeterTypesForm

    Private Sub MeterTypesForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EquipementDataSet.meter_index' table. You can move, or remove it, as needed.
        Me.Meter_indexTableAdapter.Fill(Me.EquipementDataSet.meter_index)

    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        MeterindexBindingSource.EndEdit()
        Meter_indexTableAdapter.Update(EquipementDataSet)
        My.Settings.Save()
        Me.Close()

    End Sub

    Private Sub CancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub ICTextBox_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ICTextBox.MouseClick
        OpenFileDialog1.Filter = "Crystal Report | *.rpt"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ICTextBox.Text = OpenFileDialog1.FileName

        End If

    End Sub

    Private Sub ICTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ICTextBox.TextChanged

    End Sub
End Class