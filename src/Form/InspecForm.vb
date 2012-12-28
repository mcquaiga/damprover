Imports MySql.Data.MySqlClient
Public Class InspecForm

    Dim db As New MySqlConnection
    Dim mySQL As New MySQLLibrary.Database
    Dim insp_instr_num As Integer = 0
    Dim total_instr_num As Integer = 0
    Dim current_ic_num As Integer
    Dim inspection_num As Integer
    Dim instr_id As Integer

    Public WithEvents excel As ExcelWriterClass


    Private Sub InspecForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InstrumentInformationDataSet.InstrumentsForInspection' table. You can move, or remove it, as needed.
        Me.InstrumentsForInspectionTableAdapter.Fill(Me.InstrumentInformationDataSet.InstrumentsForInspection)

        getInspectionID()
        InspTextBox.Text = inspection_num

        TotalInstrLabel.Text = "Total Instruments:" & InstrumentsDataGridView.RowCount

    End Sub

    Private Sub AddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddButton.Click

        For Each item As DataGridViewRow In InstrumentsDataGridView.SelectedRows
            If insp_instr_num < 10 Then
                item.Cells("Status").Value = My.Resources.CheckMark
                InspectionListView.Items.Add(item.Cells("SerialNumberColumn").Value)
                'Add instr_id from the database as a hidden column to the listview
                InspectionListView.Items(insp_instr_num).SubItems.Add(item.Cells("instrIdTextBox").Value)
                Console.Write("Instrument Id:" & InspectionListView.Items(insp_instr_num).SubItems(1).Text & vbNewLine)
                insp_instr_num += 1
                inspNumLabel.Text = insp_instr_num & "/10"
            Else
                MessageBox.Show("Inspection certificate is full. " & vbNewLine & "Please remove an instrument or start another.", "Inspection Cert. Full", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Exit For
            End If
        Next

    End Sub

    Private Sub RemoveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveButton.Click
        For Each item As ListViewItem In InspectionListView.SelectedItems
            item.Remove()
            insp_instr_num -= 1
            inspNumLabel.Text = insp_instr_num & "/10"
        Next
        RefreshInstrumentList()
    End Sub

    Private Sub FinishButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinishButton.Click
        Dim customer_id As Integer
        Dim comments As String
        Dim InspType As String
        Dim Eventlog As Boolean
        If insp_instr_num > 0 Then

            If MessageBox.Show("Are you sure you want to add these instruments and close the certificate?", "IC", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Try
                    Cursor = Cursors.WaitCursor
                    Dim frm As New InspectionCustomerDialog
                    frm.ShowDialog()
                    customer_id = frm.customer_id
                    comments = frm.comments
                    InspType = frm.InspType
                    Eventlog = frm.EventLog
                    If frm.DialogResult = Windows.Forms.DialogResult.OK Then
                        Using mysql As New MySQLLibrary.Database
                            For Each item As ListViewItem In InspectionListView.Items

                                Dim sql = "Update instr SET inspection_id = " & inspection_num & " WHERE instr_id = " & item.SubItems(1).Text
                                Using command As New MySqlCommand
                                    With command
                                        .Connection = mysql.OpenMySQL
                                        .CommandText = sql
                                        .CommandType = CommandType.Text
                                        .ExecuteNonQuery()
                                    End With
                                End Using
                            Next

                            Using command As New MySqlCommand
                                With command
                                    .Connection = mysql.OpenMySQL
                                    .CommandText = "INSERT INTO inspection_cert VALUES (0, Now(), " & customer_id & ", '" & comments & "', '" & InspType & "'," & Eventlog & ")"
                                    .CommandType = CommandType.Text
                                    .ExecuteNonQuery()
                                End With
                            End Using

                            Using command As New MySqlCommand
                                With command
                                    .Connection = mysql.OpenMySQL
                                    Dim x = 0
                                    Do While (x < frm.apparatusIds.Length - 1)
                                        .CommandText = "INSERT INTO inspection_equipement (inspec_id, equip_id) VALUES (" & inspection_num & "," & frm.apparatusIds(x) & ")"
                                        .CommandType = CommandType.Text
                                        .ExecuteNonQuery()
                                        x += 1
                                    Loop
                                End With
                            End Using
                        End Using

                        'Print Inspection Form
                        Me.Cursor = Cursors.Default

                        Dim frmReport As New ICReportForm
                        frmReport.inspectionID = inspection_num
                        frmReport.ShowDialog()

                        getInspectionID()
                        InspTextBox.Text = inspection_num
                        insp_instr_num = 0
                        inspNumLabel.Text = insp_instr_num & "/10"
                        InspectionListView.Items.Clear()
                        RefreshInstrumentList()
                    Else
                        Me.Cursor = Cursors.Default
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
  
    Private Sub IgnoreButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IgnoreButton.Click
        Dim sql As String
        Dim num As Integer = 0

        Try
            If MessageBox.Show("Are you sure you want to remove the instrument(s) from any further IC's?", "Ignore", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Using command As New MySqlCommand
                    With command
                        .Connection = mySQL.OpenMySQL
                        .CommandType = CommandType.Text
                        For Each item As DataGridViewRow In InstrumentsDataGridView.SelectedRows
                            sql = "UPDATE instr SET inspection_id = -1 WHERE instr_id = " & item.Cells("instrIDTextBox").Value
                            .CommandText = sql
                            .ExecuteNonQuery()
                        Next
                    End With
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        RefreshInstrumentList()
    End Sub

    Private Sub RefreshInstrumentList()
        Me.InstrumentsForInspectionTableAdapter.Fill(Me.InstrumentInformationDataSet.InstrumentsForInspection)
        TotalInstrLabel.Text = "Total Instruments:" & InstrumentsDataGridView.RowCount
    End Sub

    Private Sub getInspectionID()
        Try
            Using mysql As New MySQLLibrary.Database
                Using mySqlCommand As New MySqlCommand
                    With mySqlCommand
                        .Connection = mysql.OpenMySQL
                        .CommandText = "SHOW TABLE STATUS LIKE 'inspection_cert'"
                        .CommandType = CommandType.Text
                        Dim myreader As MySqlDataReader = .ExecuteReader()

                        If myreader.HasRows Then
                            myreader.Read()
                            Me.inspection_num = myreader.GetInt32("Auto_increment")
                            Me.InspTextBox.Text = inspection_num
                        End If
                        myreader.Close()
                    End With
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub InstrListView_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)

    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        Dim instrument As New Instrument()
        instrument.LoadFromDB(instr_id)
        excel = New ExcelWriterClass(Me, instrument)
        'AddHandler excel.InstrumentSaved, AddressOf RefreshInstrumentList
        RefreshInstrumentList()
    End Sub

    Private Sub RefreshButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshButton.Click
        RefreshInstrumentList()
    End Sub

    Private Sub InstrumentsDataGridView_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles InstrumentsDataGridView.CellFormatting

    End Sub


    Private Sub InstrumentsDataGridView_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles InstrumentsDataGridView.RowHeaderMouseClick
        selectedLabel.Text = "No. Selected: " & InstrumentsDataGridView.SelectedRows.Count
        If InstrumentsDataGridView.SelectedRows.Count = 1 Then
            instr_id = InstrumentsDataGridView.SelectedRows(0).Cells("instrIdTextBox").Value
        End If
    End Sub

    Private Sub InstrumentsDataGridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles InstrumentsDataGridView.CellMouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            instr_id = InstrumentsDataGridView.SelectedRows(0).Cells("instrIdTextBox").Value
            EditMenuStrip.Show(MousePosition.X, MousePosition.Y)
        End If
    End Sub

    Private Sub InstrumentsDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles InstrumentsDataGridView.CellContentClick
        selectedLabel.Text = "No. Selected: " & InstrumentsDataGridView.SelectedRows.Count
    End Sub

    Private Sub InstrumentsDataGridView_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles InstrumentsDataGridView.KeyDown
        If e.KeyCode = Keys.Enter Then
            AddButton_Click(sender, e)
        End If
    End Sub

    Private Sub FontDialog_Apply(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontDialog.Apply

    End Sub

    Private Sub InstrumentsDataGridView_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles InstrumentsDataGridView.ColumnHeaderMouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            FontDialog.ShowDialog()

            InstrumentsDataGridView.Columns(e.ColumnIndex).DefaultCellStyle.Font = FontDialog.Font

        End If
    End Sub

    Private Sub InstrumentsDataGridView_CellValueNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValueEventArgs) Handles InstrumentsDataGridView.CellValueNeeded
        e.Value = My.Resources.blank
    End Sub

    Private Sub InspectionListView_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles InspectionListView.KeyDown
        If e.KeyCode = Keys.Delete Then
            RemoveButton_Click(sender, e)
        End If
    End Sub

    Private Sub InspectionListView_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InspectionListView.SelectedIndexChanged

    End Sub

    Private Sub InstrumentsDataGridView_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles InstrumentsDataGridView.MouseClick
        selectedLabel.Text = "No. Selected: " & InstrumentsDataGridView.SelectedRows.Count
    End Sub
End Class