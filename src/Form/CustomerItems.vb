Imports MySql.Data.MySqlClient

Public Class CustomerItems
    Public Customer As Customer

    Dim mySql As New MySQLLibrary.Database
    Dim db As MySqlConnection

    Dim beforeReadItemsChanged As Boolean
    Dim beforeWriteItemsChanged As Boolean
    Dim afterReadItemsChanged As Boolean
    Dim afterWriteItemsChanged As Boolean
    Private instr_id As Integer

    Dim InstrTypes As New Collection


    Private Sub frmCustomerItems_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'CustomerItemsDataSet.instr_type' table. You can move, or remove it, as needed.
        Me.Instr_typeTableAdapter.Fill(Me.CustomerItemsDataSet.instr_type)
        cmbInstr.SelectedIndex = 1
    End Sub


    Private Sub okButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles okButton.Click
        Try
            CustomeritemsBindingSource.EndEdit()
            Customer_itemsTableAdapter.Update(CustomerItemsDataSet)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            ItemsDataGridView.Update()
        End Try
    End Sub

    Private Sub cancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelButton.Click
        Me.Close()
    End Sub

    Private Sub cmbInstr_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbInstr.SelectedIndexChanged
        Dim d As DataRowView = cmbInstr.SelectedItem
        instr_id = d("instr_type_id")
        Customer_itemsTableAdapter.Fill(CustomerItemsDataSet.customer_items, Me.Customer.CustomerID, Me.instr_id)
    End Sub

    Private Sub ItemsDataGridView_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles ItemsDataGridView.CellBeginEdit

    End Sub

    Private Sub ItemsDataGridView_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ItemsDataGridView.CellEnter, ItemsDataGridView.CellEndEdit
        ItemsDataGridView.Update()
    End Sub

    Private Sub ItemsDataGridView_DefaultValuesNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles ItemsDataGridView.DefaultValuesNeeded
        With e.Row
            .Cells("instr_type_id").Value = instr_id
            .Cells("customer_id").Value = Customer.CustomerID
        End With
    End Sub

    Private Sub ItemsDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ItemsDataGridView.CellContentClick
       
    End Sub
    Private Sub LoadButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadButton.Click
        Try
            OpenFileDialog.Filter = "Mercury Item File (*.IMA; *.IMX) | *.IMA; *.IMX"
            OpenFileDialog.FileName = ""
            Dim result As DialogResult = OpenFileDialog.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub OpenFileDialog_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog.FileOk

        Me.Cursor = Cursors.WaitCursor
        'ItemsDataGridView.DataSource = Nothing
        Try
            Dim txt As System.IO.StreamReader
            Dim newItem As DataGridViewRow
            Dim itemNumber As Integer
            Dim itemValue As String
            Dim strLine As String = ""
            Dim test As New DataTable()
            If OpenFileDialog.CheckFileExists = True And OpenFileDialog.CheckPathExists = True Then
                txt = New IO.StreamReader(OpenFileDialog.FileName)
                While txt.EndOfStream = False
                    newItem = New DataGridViewRow()
                    newItem.CreateCells(ItemsDataGridView)
                    strLine = txt.ReadLine()
                    Dim strs As String() = strLine.Split(",")
                    itemNumber = CInt(strs(0))
                    itemValue = Trim(strs(2))
                    Customer_itemsTableAdapter.InsertQuery(Customer.CustomerID, itemNumber, Me.instr_id, itemValue)
                End While
            End If
            Customer_itemsTableAdapter.Fill(CustomerItemsDataSet.customer_items, Me.Customer.CustomerID, instr_id)
            'Me.Customer_itemsTableAdapter.Fill(CustomerItemsDataSet.customer_items, Customer.CustomerID, Me.instr_id)
            'ItemsDataGridView.DataSource = Me.Customer_itemsTableAdapter
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Text Error", MessageBoxButtons.OK)
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        'Customer_itemsTableAdapter.Dele()
    End Sub

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        Try
            If MessageBox.Show("Are you sure you want to clear items?", "Clear Items", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Me.Customer_itemsTableAdapter.DeleteQuery(Me.Customer.CustomerID, instr_id)
                Me.Customer_itemsTableAdapter.Fill(CustomerItemsDataSet.customer_items, Customer.CustomerID, instr_id)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ItemsDataGridView_RowLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ItemsDataGridView.RowLeave
        'Customer_itemsTableAdapter.Fill(CustomerItemsDataSet.customer_items, Me.Customer.CustomerID, Me.instr_id)
    End Sub

    Private Sub ItemsDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles ItemsDataGridView.DataError

        MessageBox.Show(e.Exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        e.Cancel = True
        ItemsDataGridView.Rows.RemoveAt(e.RowIndex)
    End Sub


    Private Sub ItemsDataGridView_UserAddedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles ItemsDataGridView.UserAddedRow
        Try
            If IsNumeric(ItemsDataGridView.Rows(e.Row.Index).Cells("Item_Num").Value) Then
                MessageBox.Show(Customer_itemsTableAdapter.GetDescription(ItemsDataGridView.Rows(e.Row.Index).Cells("Item_Num").Value, instr_id))
                ItemsDataGridView.Rows(e.Row.Index).Cells("item_desc").Value = Customer_itemsTableAdapter.GetDescription(ItemsDataGridView.Rows(e.Row.Index).Cells("Item_Num").Value, instr_id)
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class

Public Class InstrumentType
    Public InstrumentName As String
    Public InstrumentID As Integer
End Class