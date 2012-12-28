<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InspecForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.inspNumLabel = New System.Windows.Forms.Label
        Me.AddButton = New System.Windows.Forms.Button
        Me.RemoveButton = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.IgnoreButton = New System.Windows.Forms.Button
        Me.FinishButton = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.InspTextBox = New System.Windows.Forms.TextBox
        Me.InspectionListView = New System.Windows.Forms.ListView
        Me._Serial = New System.Windows.Forms.ColumnHeader
        Me.TotalInstrLabel = New System.Windows.Forms.Label
        Me.selectedLabel = New System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.RefreshButton = New System.Windows.Forms.Button
        Me.InstrumentsDataGridView = New System.Windows.Forms.DataGridView
        Me.Status = New System.Windows.Forms.DataGridViewImageColumn
        Me.SerialnumberColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ItemvalueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.InstrtypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.customer_name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.instrIDTextBox = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.InstrumentsForInspectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InstrumentInformationDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InstrumentInformationDataSet = New DAM_Prover.InstrumentInformationDataSet
        Me.Label1 = New System.Windows.Forms.Label
        Me.EditMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FontDialog = New System.Windows.Forms.FontDialog
        Me.InstrumentsForInspectionTableAdapter = New DAM_Prover.InstrumentInformationDataSetTableAdapters.InstrumentsForInspectionTableAdapter
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.InstrumentsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InstrumentsForInspectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InstrumentInformationDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InstrumentInformationDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EditMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'inspNumLabel
        '
        Me.inspNumLabel.AutoSize = True
        Me.inspNumLabel.Dock = System.Windows.Forms.DockStyle.Right
        Me.inspNumLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inspNumLabel.Location = New System.Drawing.Point(593, 0)
        Me.inspNumLabel.Name = "inspNumLabel"
        Me.inspNumLabel.Size = New System.Drawing.Size(40, 25)
        Me.inspNumLabel.TabIndex = 2
        Me.inspNumLabel.Text = "0/10"
        Me.inspNumLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'AddButton
        '
        Me.AddButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.AddButton.Location = New System.Drawing.Point(388, 102)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(102, 23)
        Me.AddButton.TabIndex = 3
        Me.AddButton.Text = "Add -->>"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'RemoveButton
        '
        Me.RemoveButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.RemoveButton.Location = New System.Drawing.Point(388, 201)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(102, 23)
        Me.RemoveButton.TabIndex = 4
        Me.RemoveButton.Text = "<<-- Remove"
        Me.RemoveButton.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button3.Location = New System.Drawing.Point(558, 470)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 27)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "E&xit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'IgnoreButton
        '
        Me.IgnoreButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.IgnoreButton.Location = New System.Drawing.Point(3, 470)
        Me.IgnoreButton.Name = "IgnoreButton"
        Me.IgnoreButton.Size = New System.Drawing.Size(79, 27)
        Me.IgnoreButton.TabIndex = 6
        Me.IgnoreButton.Text = "Ignore"
        Me.IgnoreButton.UseVisualStyleBackColor = True
        '
        'FinishButton
        '
        Me.FinishButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.FinishButton.Location = New System.Drawing.Point(496, 290)
        Me.FinishButton.Name = "FinishButton"
        Me.FinishButton.Size = New System.Drawing.Size(137, 23)
        Me.FinishButton.TabIndex = 7
        Me.FinishButton.Text = "Finish IC"
        Me.FinishButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Inspection ID #:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'InspTextBox
        '
        Me.InspTextBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.InspTextBox.Location = New System.Drawing.Point(3, 16)
        Me.InspTextBox.Name = "InspTextBox"
        Me.InspTextBox.Size = New System.Drawing.Size(83, 20)
        Me.InspTextBox.TabIndex = 9
        '
        'InspectionListView
        '
        Me.InspectionListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me._Serial})
        Me.InspectionListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InspectionListView.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InspectionListView.FullRowSelect = True
        Me.InspectionListView.HideSelection = False
        Me.InspectionListView.Location = New System.Drawing.Point(496, 28)
        Me.InspectionListView.Name = "InspectionListView"
        Me.TableLayoutPanel1.SetRowSpan(Me.InspectionListView, 2)
        Me.InspectionListView.Size = New System.Drawing.Size(137, 196)
        Me.InspectionListView.TabIndex = 11
        Me.InspectionListView.UseCompatibleStateImageBehavior = False
        Me.InspectionListView.View = System.Windows.Forms.View.List
        '
        '_Serial
        '
        Me._Serial.Text = "Serial"
        '
        'TotalInstrLabel
        '
        Me.TotalInstrLabel.AutoSize = True
        Me.TotalInstrLabel.Dock = System.Windows.Forms.DockStyle.Left
        Me.TotalInstrLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalInstrLabel.Location = New System.Drawing.Point(3, 0)
        Me.TotalInstrLabel.Name = "TotalInstrLabel"
        Me.TotalInstrLabel.Size = New System.Drawing.Size(0, 25)
        Me.TotalInstrLabel.TabIndex = 12
        '
        'selectedLabel
        '
        Me.selectedLabel.AutoSize = True
        Me.selectedLabel.Location = New System.Drawing.Point(3, 426)
        Me.selectedLabel.Name = "selectedLabel"
        Me.selectedLabel.Size = New System.Drawing.Size(95, 13)
        Me.selectedLabel.TabIndex = 13
        Me.selectedLabel.Text = "Num. of Selected: "
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 202.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 143.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 14.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TotalInstrLabel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.InspectionListView, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Button3, 3, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.FinishButton, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.AddButton, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.RemoveButton, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.inspNumLabel, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.IgnoreButton, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.RefreshButton, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.InstrumentsDataGridView, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.selectedLabel, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 103.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 99.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(650, 500)
        Me.TableLayoutPanel1.TabIndex = 14
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel1.Controls.Add(Me.InspTextBox)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(496, 230)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(137, 54)
        Me.FlowLayoutPanel1.TabIndex = 14
        '
        'RefreshButton
        '
        Me.RefreshButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RefreshButton.Location = New System.Drawing.Point(186, 429)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(196, 35)
        Me.RefreshButton.TabIndex = 15
        Me.RefreshButton.Text = "&Refresh"
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'InstrumentsDataGridView
        '
        Me.InstrumentsDataGridView.AllowUserToAddRows = False
        Me.InstrumentsDataGridView.AllowUserToDeleteRows = False
        Me.InstrumentsDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        Me.InstrumentsDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.InstrumentsDataGridView.AutoGenerateColumns = False
        Me.InstrumentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.InstrumentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InstrumentsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Status, Me.SerialnumberColumn, Me.ItemvalueDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn, Me.InstrtypeDataGridViewTextBoxColumn, Me.TypeDataGridViewTextBoxColumn, Me.customer_name, Me.instrIDTextBox})
        Me.TableLayoutPanel1.SetColumnSpan(Me.InstrumentsDataGridView, 2)
        Me.InstrumentsDataGridView.DataSource = Me.InstrumentsForInspectionBindingSource
        Me.InstrumentsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InstrumentsDataGridView.Location = New System.Drawing.Point(3, 28)
        Me.InstrumentsDataGridView.Name = "InstrumentsDataGridView"
        Me.InstrumentsDataGridView.ReadOnly = True
        Me.InstrumentsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InstrumentsDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.TableLayoutPanel1.SetRowSpan(Me.InstrumentsDataGridView, 5)
        Me.InstrumentsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.InstrumentsDataGridView.Size = New System.Drawing.Size(379, 395)
        Me.InstrumentsDataGridView.TabIndex = 16
        '
        'Status
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.NullValue = "System.Drawing.Bitmap"
        Me.Status.DefaultCellStyle = DataGridViewCellStyle2
        Me.Status.FillWeight = 32.0!
        Me.Status.HeaderText = ""
        Me.Status.Image = Global.DAM_Prover.My.Resources.Resources.blank
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        Me.Status.Width = 5
        '
        'SerialnumberColumn
        '
        Me.SerialnumberColumn.DataPropertyName = "serial_number"
        Me.SerialnumberColumn.HeaderText = "Serial Number"
        Me.SerialnumberColumn.Name = "SerialnumberColumn"
        Me.SerialnumberColumn.ReadOnly = True
        Me.SerialnumberColumn.Width = 90
        '
        'ItemvalueDataGridViewTextBoxColumn
        '
        Me.ItemvalueDataGridViewTextBoxColumn.DataPropertyName = "item_value"
        Me.ItemvalueDataGridViewTextBoxColumn.HeaderText = "Company Number"
        Me.ItemvalueDataGridViewTextBoxColumn.Name = "ItemvalueDataGridViewTextBoxColumn"
        Me.ItemvalueDataGridViewTextBoxColumn.ReadOnly = True
        Me.ItemvalueDataGridViewTextBoxColumn.Width = 106
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date Tested"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        Me.DateDataGridViewTextBoxColumn.ReadOnly = True
        Me.DateDataGridViewTextBoxColumn.Width = 84
        '
        'InstrtypeDataGridViewTextBoxColumn
        '
        Me.InstrtypeDataGridViewTextBoxColumn.DataPropertyName = "instr_type"
        Me.InstrtypeDataGridViewTextBoxColumn.HeaderText = "Instrument Type"
        Me.InstrtypeDataGridViewTextBoxColumn.Name = "InstrtypeDataGridViewTextBoxColumn"
        Me.InstrtypeDataGridViewTextBoxColumn.ReadOnly = True
        Me.InstrtypeDataGridViewTextBoxColumn.Width = 99
        '
        'TypeDataGridViewTextBoxColumn
        '
        Me.TypeDataGridViewTextBoxColumn.DataPropertyName = "type"
        Me.TypeDataGridViewTextBoxColumn.HeaderText = "Rotary Type"
        Me.TypeDataGridViewTextBoxColumn.Name = "TypeDataGridViewTextBoxColumn"
        Me.TypeDataGridViewTextBoxColumn.ReadOnly = True
        Me.TypeDataGridViewTextBoxColumn.Width = 83
        '
        'customer_name
        '
        Me.customer_name.DataPropertyName = "name"
        Me.customer_name.HeaderText = "Customer Name"
        Me.customer_name.Name = "customer_name"
        Me.customer_name.ReadOnly = True
        Me.customer_name.Width = 98
        '
        'instrIDTextBox
        '
        Me.instrIDTextBox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.instrIDTextBox.DataPropertyName = "instr_id"
        Me.instrIDTextBox.HeaderText = "instr_id"
        Me.instrIDTextBox.Name = "instrIDTextBox"
        Me.instrIDTextBox.ReadOnly = True
        Me.instrIDTextBox.Visible = False
        '
        'InstrumentsForInspectionBindingSource
        '
        Me.InstrumentsForInspectionBindingSource.DataMember = "InstrumentsForInspection"
        Me.InstrumentsForInspectionBindingSource.DataSource = Me.InstrumentInformationDataSetBindingSource
        '
        'InstrumentInformationDataSetBindingSource
        '
        Me.InstrumentInformationDataSetBindingSource.DataSource = Me.InstrumentInformationDataSet
        Me.InstrumentInformationDataSetBindingSource.Position = 0
        '
        'InstrumentInformationDataSet
        '
        Me.InstrumentInformationDataSet.DataSetName = "InstrumentInformationDataSet"
        Me.InstrumentInformationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(186, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 25)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Click column header to sort."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'EditMenuStrip
        '
        Me.EditMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem})
        Me.EditMenuStrip.Name = "EditMenuStrip"
        Me.EditMenuStrip.Size = New System.Drawing.Size(104, 26)
        Me.EditMenuStrip.Text = "EditMenu"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'FontDialog
        '
        '
        'InstrumentsForInspectionTableAdapter
        '
        Me.InstrumentsForInspectionTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.FillWeight = 32.0!
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = Global.DAM_Prover.My.Resources.Resources.blank
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Width = 32
        '
        'InspecForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 500)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "InspecForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inspection Certificate"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.InstrumentsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InstrumentsForInspectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InstrumentInformationDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InstrumentInformationDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EditMenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents inspNumLabel As System.Windows.Forms.Label
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents RemoveButton As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents IgnoreButton As System.Windows.Forms.Button
    Friend WithEvents FinishButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents InspTextBox As System.Windows.Forms.TextBox
    Friend WithEvents InspectionListView As System.Windows.Forms.ListView
    Friend WithEvents _Serial As System.Windows.Forms.ColumnHeader
    Friend WithEvents TotalInstrLabel As System.Windows.Forms.Label
    Friend WithEvents selectedLabel As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents EditMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshButton As System.Windows.Forms.Button
    Friend WithEvents InstrumentsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents InstrumentInformationDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InstrumentInformationDataSet As DAM_Prover.InstrumentInformationDataSet
    Friend WithEvents InstrumentsForInspectionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InstrumentsForInspectionTableAdapter As DAM_Prover.InstrumentInformationDataSetTableAdapters.InstrumentsForInspectionTableAdapter
    Friend WithEvents FontDialog As System.Windows.Forms.FontDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Status As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents SerialnumberColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemvalueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InstrtypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents instrIDTextBox As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
