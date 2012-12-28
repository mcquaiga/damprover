<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerItems
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.ItemsDataGridView = New System.Windows.Forms.DataGridView
        Me.customer_id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.instr_type_id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.item_num = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.value = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.item_desc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CustomeritemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerItemsDataSet = New DAM_Prover.CustomerItemsDataSet
        Me.ItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.okButton = New System.Windows.Forms.Button
        Me.cancelButton = New System.Windows.Forms.Button
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.cmbInstr = New System.Windows.Forms.ComboBox
        Me.InstrtypeBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Instr_typeTableAdapter = New DAM_Prover.CustomerItemsDataSetTableAdapters.instr_typeTableAdapter
        Me.ItemsTableAdapter = New DAM_Prover.CustomerItemsDataSetTableAdapters.itemsTableAdapter
        Me.Customer_itemsTableAdapter = New DAM_Prover.CustomerItemsDataSetTableAdapters.customer_itemsTableAdapter
        Me.Label1 = New System.Windows.Forms.Label
        Me.LoadButton = New System.Windows.Forms.Button
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.InstrtypeidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CustomeridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.ClearButton = New System.Windows.Forms.Button
        Me.GroupBox4.SuspendLayout()
        CType(Me.ItemsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataGridContextMenuStrip.SuspendLayout()
        CType(Me.CustomeritemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerItemsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        CType(Me.InstrtypeBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.GroupBox4, 2)
        Me.GroupBox4.Controls.Add(Me.ItemsDataGridView)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Location = New System.Drawing.Point(3, 70)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(733, 318)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Write Items"
        '
        'ItemsDataGridView
        '
        Me.ItemsDataGridView.AutoGenerateColumns = False
        Me.ItemsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ItemsDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ItemsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.customer_id, Me.instr_type_id, Me.item_num, Me.value, Me.item_desc})
        Me.ItemsDataGridView.ContextMenuStrip = Me.DataGridContextMenuStrip
        Me.ItemsDataGridView.DataSource = Me.CustomeritemsBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ItemsDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.ItemsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemsDataGridView.Location = New System.Drawing.Point(3, 16)
        Me.ItemsDataGridView.Name = "ItemsDataGridView"
        Me.ItemsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ItemsDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.ItemsDataGridView.Size = New System.Drawing.Size(727, 299)
        Me.ItemsDataGridView.TabIndex = 8
        '
        'customer_id
        '
        Me.customer_id.DataPropertyName = "customer_id"
        Me.customer_id.HeaderText = "customer_id"
        Me.customer_id.Name = "customer_id"
        Me.customer_id.Visible = False
        '
        'instr_type_id
        '
        Me.instr_type_id.DataPropertyName = "instr_type_id"
        Me.instr_type_id.HeaderText = "instr_type_id"
        Me.instr_type_id.Name = "instr_type_id"
        Me.instr_type_id.Visible = False
        '
        'item_num
        '
        Me.item_num.DataPropertyName = "item_number"
        Me.item_num.HeaderText = "Item Number"
        Me.item_num.Name = "item_num"
        Me.item_num.ToolTipText = "Instrument Item Number"
        '
        'value
        '
        Me.value.DataPropertyName = "value"
        Me.value.HeaderText = "Value"
        Me.value.Name = "value"
        Me.value.ToolTipText = "Value to reset Item Number to"
        '
        'item_desc
        '
        Me.item_desc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.item_desc.DataPropertyName = "item_desc"
        Me.item_desc.HeaderText = "Description"
        Me.item_desc.Name = "item_desc"
        Me.item_desc.ToolTipText = "Instrument Item Description"
        '
        'DataGridContextMenuStrip
        '
        Me.DataGridContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem})
        Me.DataGridContextMenuStrip.Name = "DataGridContextMenuStrip"
        Me.DataGridContextMenuStrip.Size = New System.Drawing.Size(117, 26)
        Me.DataGridContextMenuStrip.Text = "&Delete"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.DeleteToolStripMenuItem.Text = "&Delete"
        '
        'CustomeritemsBindingSource
        '
        Me.CustomeritemsBindingSource.DataMember = "customer_items"
        Me.CustomeritemsBindingSource.DataSource = Me.CustomerItemsDataSet
        Me.CustomeritemsBindingSource.Sort = ""
        '
        'CustomerItemsDataSet
        '
        Me.CustomerItemsDataSet.DataSetName = "CustomerItemsDataSet"
        Me.CustomerItemsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ItemsBindingSource
        '
        Me.ItemsBindingSource.DataMember = "items"
        Me.ItemsBindingSource.DataSource = Me.CustomerItemsDataSet
        '
        'okButton
        '
        Me.okButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.okButton.Location = New System.Drawing.Point(3, 4)
        Me.okButton.Name = "okButton"
        Me.okButton.Size = New System.Drawing.Size(95, 34)
        Me.okButton.TabIndex = 12
        Me.okButton.Text = "OK"
        Me.okButton.UseVisualStyleBackColor = True
        '
        'cancelButton
        '
        Me.cancelButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cancelButton.Location = New System.Drawing.Point(104, 4)
        Me.cancelButton.Name = "cancelButton"
        Me.cancelButton.Size = New System.Drawing.Size(93, 34)
        Me.cancelButton.TabIndex = 13
        Me.cancelButton.Text = "Cancel"
        Me.cancelButton.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.cmbInstr)
        Me.GroupBox8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox8.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(363, 61)
        Me.GroupBox8.TabIndex = 14
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Instrument Type"
        '
        'cmbInstr
        '
        Me.cmbInstr.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbInstr.DataSource = Me.InstrtypeBindingSource1
        Me.cmbInstr.DisplayMember = "instr_type"
        Me.cmbInstr.FormattingEnabled = True
        Me.cmbInstr.Location = New System.Drawing.Point(23, 23)
        Me.cmbInstr.Name = "cmbInstr"
        Me.cmbInstr.Size = New System.Drawing.Size(311, 21)
        Me.cmbInstr.TabIndex = 0
        Me.cmbInstr.ValueMember = "instr_type_id"
        '
        'InstrtypeBindingSource1
        '
        Me.InstrtypeBindingSource1.DataMember = "instr_type"
        Me.InstrtypeBindingSource1.DataSource = Me.CustomerItemsDataSet
        '
        'Instr_typeTableAdapter
        '
        Me.Instr_typeTableAdapter.ClearBeforeFill = True
        '
        'ItemsTableAdapter
        '
        Me.ItemsTableAdapter.ClearBeforeFill = True
        '
        'Customer_itemsTableAdapter
        '
        Me.Customer_itemsTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(372, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(364, 67)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "The following list of items will be set when the test is completed."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LoadButton
        '
        Me.LoadButton.Location = New System.Drawing.Point(3, 3)
        Me.LoadButton.Name = "LoadButton"
        Me.LoadButton.Size = New System.Drawing.Size(160, 35)
        Me.LoadButton.TabIndex = 16
        Me.LoadButton.Text = "Load from Item file..."
        Me.LoadButton.UseVisualStyleBackColor = True
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "item_number"
        Me.DataGridViewTextBoxColumn1.HeaderText = "item_number"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "value"
        Me.DataGridViewTextBoxColumn2.HeaderText = "value"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "item_desc"
        Me.DataGridViewTextBoxColumn3.HeaderText = "item_desc"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'InstrtypeidDataGridViewTextBoxColumn
        '
        Me.InstrtypeidDataGridViewTextBoxColumn.DataPropertyName = "instr_type_id"
        Me.InstrtypeidDataGridViewTextBoxColumn.HeaderText = "instr_type_id"
        Me.InstrtypeidDataGridViewTextBoxColumn.Name = "InstrtypeidDataGridViewTextBoxColumn"
        '
        'CustomeridDataGridViewTextBoxColumn
        '
        Me.CustomeridDataGridViewTextBoxColumn.DataPropertyName = "customer_id"
        Me.CustomeridDataGridViewTextBoxColumn.HeaderText = "customer_id"
        Me.CustomeridDataGridViewTextBoxColumn.Name = "CustomeridDataGridViewTextBoxColumn"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox8, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox4, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.21312!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.78689!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(739, 438)
        Me.TableLayoutPanel1.TabIndex = 17
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.okButton)
        Me.Panel1.Controls.Add(Me.cancelButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(536, 394)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 41)
        Me.Panel1.TabIndex = 17
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ClearButton)
        Me.Panel2.Controls.Add(Me.LoadButton)
        Me.Panel2.Location = New System.Drawing.Point(3, 394)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(363, 41)
        Me.Panel2.TabIndex = 18
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(219, 3)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(141, 34)
        Me.ClearButton.TabIndex = 17
        Me.ClearButton.Text = "Clear All Items"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'CustomerItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(739, 438)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "CustomerItems"
        Me.Text = "Customer Items"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.ItemsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataGridContextMenuStrip.ResumeLayout(False)
        CType(Me.CustomeritemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerItemsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        CType(Me.InstrtypeBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents okButton As System.Windows.Forms.Button
    Friend Shadows WithEvents cancelButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbInstr As System.Windows.Forms.ComboBox
    Friend WithEvents ItemsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents CustomerItemsDataSet As DAM_Prover.CustomerItemsDataSet
    Friend WithEvents ItemnumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemdescDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Instr_typeTableAdapter As DAM_Prover.CustomerItemsDataSetTableAdapters.instr_typeTableAdapter
    Friend WithEvents ItemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemsTableAdapter As DAM_Prover.CustomerItemsDataSetTableAdapters.itemsTableAdapter
    Friend WithEvents CustomeritemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Customer_itemsTableAdapter As DAM_Prover.CustomerItemsDataSetTableAdapters.customer_itemsTableAdapter
    Friend WithEvents InstrtypeBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LoadButton As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents DataGridContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents item_number As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InstrtypeidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomeridDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents customer_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents instr_type_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents item_num As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents value As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents item_desc As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
