<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InspectionCustomerDialog
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoadInspectionCertDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoadInspectionCertDataSet = New DAM_Prover.LoadInspectionCertDataSet
        Me.Label1 = New System.Windows.Forms.Label
        Me.CustomersTableAdapter = New DAM_Prover.LoadInspectionCertDataSetTableAdapters.customersTableAdapter
        Me.Label2 = New System.Windows.Forms.Label
        Me.CommentsTextBox = New System.Windows.Forms.TextBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EquipementUsed = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.CodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EquipementBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EquipementDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EquipementDataSet = New DAM_Prover.EquipementDataSet
        Me.Label3 = New System.Windows.Forms.Label
        Me.EquipementTableAdapter = New DAM_Prover.EquipementDataSetTableAdapters.equipementTableAdapter
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RCheckBox = New System.Windows.Forms.CheckBox
        Me.NCheckBox = New System.Windows.Forms.CheckBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.EventLogCheckBox = New System.Windows.Forms.CheckBox
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoadInspectionCertDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoadInspectionCertDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EquipementBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EquipementDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EquipementDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(187, 389)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.CustomersBindingSource
        Me.ComboBox1.DisplayMember = "name"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(56, 35)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(233, 21)
        Me.ComboBox1.TabIndex = 1
        Me.ComboBox1.ValueMember = "customer_id"
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "customers"
        Me.CustomersBindingSource.DataSource = Me.LoadInspectionCertDataSetBindingSource
        '
        'LoadInspectionCertDataSetBindingSource
        '
        Me.LoadInspectionCertDataSetBindingSource.DataSource = Me.LoadInspectionCertDataSet
        Me.LoadInspectionCertDataSetBindingSource.Position = 0
        '
        'LoadInspectionCertDataSet
        '
        Me.LoadInspectionCertDataSet.DataSetName = "LoadInspectionCertDataSet"
        Me.LoadInspectionCertDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Customer:"
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 271)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Comments:"
        '
        'CommentsTextBox
        '
        Me.CommentsTextBox.Location = New System.Drawing.Point(12, 287)
        Me.CommentsTextBox.Multiline = True
        Me.CommentsTextBox.Name = "CommentsTextBox"
        Me.CommentsTextBox.Size = New System.Drawing.Size(233, 96)
        Me.CommentsTextBox.TabIndex = 4
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.EquipementUsed, Me.CodeDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EquipementBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 84)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(320, 184)
        Me.DataGridView1.TabIndex = 5
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.Visible = False
        '
        'EquipementUsed
        '
        Me.EquipementUsed.HeaderText = ""
        Me.EquipementUsed.Name = "EquipementUsed"
        Me.EquipementUsed.Width = 50
        '
        'CodeDataGridViewTextBoxColumn
        '
        Me.CodeDataGridViewTextBoxColumn.DataPropertyName = "code"
        Me.CodeDataGridViewTextBoxColumn.HeaderText = "Apparatus Name"
        Me.CodeDataGridViewTextBoxColumn.Name = "CodeDataGridViewTextBoxColumn"
        Me.CodeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'EquipementBindingSource
        '
        Me.EquipementBindingSource.DataMember = "equipement"
        Me.EquipementBindingSource.DataSource = Me.EquipementDataSetBindingSource
        '
        'EquipementDataSetBindingSource
        '
        Me.EquipementDataSetBindingSource.DataSource = Me.EquipementDataSet
        Me.EquipementDataSetBindingSource.Position = 0
        '
        'EquipementDataSet
        '
        Me.EquipementDataSet.DataSetName = "EquipementDataSet"
        Me.EquipementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Equipement Used:"
        '
        'EquipementTableAdapter
        '
        Me.EquipementTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RCheckBox)
        Me.GroupBox1.Controls.Add(Me.NCheckBox)
        Me.GroupBox1.Location = New System.Drawing.Point(251, 274)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(84, 68)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Insp. Type"
        '
        'RCheckBox
        '
        Me.RCheckBox.AutoSize = True
        Me.RCheckBox.Location = New System.Drawing.Point(26, 46)
        Me.RCheckBox.Name = "RCheckBox"
        Me.RCheckBox.Size = New System.Drawing.Size(34, 17)
        Me.RCheckBox.TabIndex = 1
        Me.RCheckBox.Text = "R"
        Me.RCheckBox.UseVisualStyleBackColor = True
        '
        'NCheckBox
        '
        Me.NCheckBox.AutoSize = True
        Me.NCheckBox.Checked = True
        Me.NCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.NCheckBox.Location = New System.Drawing.Point(26, 23)
        Me.NCheckBox.Name = "NCheckBox"
        Me.NCheckBox.Size = New System.Drawing.Size(34, 17)
        Me.NCheckBox.TabIndex = 0
        Me.NCheckBox.Text = "N"
        Me.NCheckBox.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.EventLogCheckBox)
        Me.GroupBox2.Location = New System.Drawing.Point(252, 343)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(83, 40)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Event Log"
        '
        'EventLogCheckBox
        '
        Me.EventLogCheckBox.AutoSize = True
        Me.EventLogCheckBox.Location = New System.Drawing.Point(25, 17)
        Me.EventLogCheckBox.Name = "EventLogCheckBox"
        Me.EventLogCheckBox.Size = New System.Drawing.Size(33, 17)
        Me.EventLogCheckBox.TabIndex = 0
        Me.EventLogCheckBox.Text = "Y"
        Me.EventLogCheckBox.UseVisualStyleBackColor = True
        '
        'InspectionCustomerDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(345, 430)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CommentsTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "InspectionCustomerDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Select a Customer:"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoadInspectionCertDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoadInspectionCertDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EquipementBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EquipementDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EquipementDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LoadInspectionCertDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LoadInspectionCertDataSet As DAM_Prover.LoadInspectionCertDataSet
    Friend WithEvents CustomersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomersTableAdapter As DAM_Prover.LoadInspectionCertDataSetTableAdapters.customersTableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CommentsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents EquipementDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EquipementDataSet As DAM_Prover.EquipementDataSet
    Friend WithEvents EquipementBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EquipementTableAdapter As DAM_Prover.EquipementDataSetTableAdapters.equipementTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EquipementUsed As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents NCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents EventLogCheckBox As System.Windows.Forms.CheckBox

End Class
