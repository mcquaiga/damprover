Imports MySql.Data.MySqlClient
Public Class ViewInspectionForm

    Dim instr_id As Integer
    Dim inspec_id As Integer

    Private Sub ViewInspectionForm_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Me.CustomersTableAdapter.Connection.Close()
        Me.SerialCompanyTableAdapter.Connection.Close()
        InspecTableAdapter.Connection.Close()

        CustomersTableAdapter.Dispose()
        SerialCompanyTableAdapter.Dispose()
        LoadInspectionCertDataSet.Dispose()

    End Sub
    Private Sub ViewInspectionForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LoadInspectionCertDataSet.customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.LoadInspectionCertDataSet.customers)
        Me.ComboBox1_SelectedIndexChanged(Me.CustomerComboBox, e)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerComboBox.SelectedIndexChanged
        Try
            Dim d As DataRowView = CustomerComboBox.SelectedItem
            InspecTableAdapter.Fill(LoadInspectionCertDataSet.Inspec, d("customer_id"))
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub OpenButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenButton.Click

        Dim r As DataGridViewRow = DataGridView1.SelectedRows(0)

        Dim inspection_id = r.Cells(0).Value

        Dim frm As New ICReportForm
        frm.inspectionID = inspection_id
        frm.ShowDialog()
    End Sub


    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then

            InspecMenuStrip.Show(MousePosition.X, MousePosition.Y)
            inspec_id = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        End If
    End Sub

    Private Sub DataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged
        Dim inspec As Integer
        If DataGridView1.SelectedRows.Count > 0 Then
            inspec = DataGridView1.SelectedRows(0).Cells(0).Value
            SerialCompanyTableAdapter.Fill(InstrumentInformationDataSet.SerialCompany, inspec)
        End If

    End Sub

    Private Sub DataGridView2_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView2.CellMouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then

            InstrMenuStrip.Show(MousePosition.X, MousePosition.Y)
            instr_id = DataGridView2.Rows(e.RowIndex).Cells(0).Value
        End If
    End Sub

    Private Sub EditMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditMenuItem.Click

        Dim instrument As New Instrument()
        instrument.LoadFromDB(instr_id)
        Dim excel As New ExcelWriterClass(Me, instrument)

    End Sub


    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click

        Dim frm As New InspectionCustomerDialog
        frm.ShowDialog()

        Dim mysql_cn As New MySQLLibrary.Database
        Try
            If frm.DialogResult = Windows.Forms.DialogResult.OK Then
                Using command As New MySqlCommand
                    With command
                        .Connection = mysql_cn.OpenMySQL
                        .CommandText = "UPDATE inspection_cert SET customer_id = " & frm.customer_id & ", comments = '" & frm.comments & "', insp_type ='" & frm.InspType & "' WHERE inspection_id = " & Me.inspec_id
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End With
                End Using

                Using command As New MySqlCommand
                    With command
                        .Connection = mysql_cn.OpenMySQL
                        Dim x = 0
                        .CommandText = "DELETE FROM inspection_equipement WHERE inspec_id = " & Me.inspec_id
                        .ExecuteNonQuery()

                        Do While (x < frm.apparatusIds.Length - 1)
                            .CommandText = "INSERT INTO inspection_equipement (inspec_id, equip_id) VALUES (" & inspec_id & "," & frm.apparatusIds(x) & ")"
                            .CommandType = CommandType.Text
                            .ExecuteNonQuery()
                            x += 1
                        Loop
                    End With
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            mysql_cn.CloseMySQL()
        End Try
    End Sub

    Private Sub SearchDateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchDateButton.Click
        Try
            Dim d As DataRowView = CustomerComboBox.SelectedItem
            InspecTableAdapter.FillBy(LoadInspectionCertDataSet.Inspec, StartDateTimePicker.Text, EndDateTimePicker.Text, d("customer_id"))
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub SerialSearchButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SerialSearchButton.Click
        Try
            If IsNumeric(SerialNumberTextBox.Text) Then
                InspecTableAdapter.FillBySerialNumber(LoadInspectionCertDataSet.Inspec, Me.SerialNumberTextBox.Text)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub StandardCSVToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StandardCSVToolStripMenuItem.Click

        Try
            Dim csv As New CSVWriterClass(inspec_id)
            csv.WriteStandardCSVFile()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub EnbridgeNewCSVToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnbridgeNewCSVToolStripMenuItem.Click
        Try

            Dim csv As New CSVWriterClass(inspec_id)
            csv.WriteNewEnbridgeCSVFile()
            csv = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        OpenButton_Click(sender, e)
    End Sub

    Private Sub CompanySearchButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompanySearchButton.Click
        Try

            InspecTableAdapter.FillByCompanyNumber(LoadInspectionCertDataSet.Inspec, Me.CompanyNumberTextBox.Text)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class