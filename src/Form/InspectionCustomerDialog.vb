Imports System.Windows.Forms

Public Class InspectionCustomerDialog

    Public customer_id As Integer
    Public customer_name As String
    Public comments As String
    Public apparatusIds(100) As Integer
    Public InspType As String
    Public EventLog As Boolean = False

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim x As Integer

        EquipementBindingSource.EndEdit()
        EquipementTableAdapter.Update(EquipementDataSet)

        comments = CommentsTextBox.Text

        For Each item As DataGridViewRow In DataGridView1.Rows
            If item.Cells("EquipementUsed").Value = True Then
                apparatusIds(x) = item.Cells(0).Value
                x += 1
            End If
        Next
        ReDim Preserve apparatusIds(x)

        If NCheckBox.Checked Then
            InspType = "N"
        Else
            InspType = "R"
        End If
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub InspectionCustomerDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EquipementDataSet.equipement' table. You can move, or remove it, as needed.
        Me.EquipementTableAdapter.Fill(Me.EquipementDataSet.equipement)
        'TODO: This line of code loads data into the 'LoadInspectionCertDataSet.customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.LoadInspectionCertDataSet.customers)
        ComboBox1_SelectedIndexChanged(Me.ComboBox1, e)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim customer As DataRowView = ComboBox1.SelectedItem
        customer_id = customer("customer_id")
        customer_name = customer("name")
    End Sub

    Private Sub NCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NCheckBox.CheckedChanged
        If NCheckBox.Checked Then
            RCheckBox.Checked = False
        End If
    End Sub

    Private Sub RCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RCheckBox.CheckedChanged
        If RCheckBox.Checked Then
            NCheckBox.Checked = False
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EventLogCheckBox.CheckedChanged
        If EventLogCheckBox.Checked Then
            EventLog = True

        End If
    End Sub
End Class
