<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewInspectionForm
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.InspectionidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.InspecBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoadInspectionCertDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoadInspectionCertDataSet = New DAM_Prover.LoadInspectionCertDataSet
        Me.CustomerComboBox = New System.Windows.Forms.ComboBox
        Me.CustomersBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CompanyNumberTextBox = New System.Windows.Forms.TextBox
        Me.CompanySearchButton = New System.Windows.Forms.Button
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.InstridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SerialnumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ItemvalueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SerialCompanyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InstrumentInformationDataSet = New DAM_Prover.InstrumentInformationDataSet
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.OpenButton = New System.Windows.Forms.Button
        Me.CloseButton = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.SearchDateButton = New System.Windows.Forms.Button
        Me.EndDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.StartDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.SerialNumberTextBox = New System.Windows.Forms.TextBox
        Me.SerialSearchButton = New System.Windows.Forms.Button
        Me.InstrBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InstrumentInformationDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InstrinfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Instr_infoTableAdapter = New DAM_Prover.InstrumentInformationDataSetTableAdapters.instr_infoTableAdapter
        Me.InstrTableAdapter = New DAM_Prover.InstrumentInformationDataSetTableAdapters.instrTableAdapter
        Me.InstrMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VolumetestBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Volume_testTableAdapter = New DAM_Prover.InstrumentInformationDataSetTableAdapters.volume_testTableAdapter
        Me.SerialCompanyTableAdapter = New DAM_Prover.InstrumentInformationDataSetTableAdapters.SerialCompanyTableAdapter
        Me.InspecMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CreateCSVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EnbridgeNewCSVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StandardCSVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InspecTableAdapter = New DAM_Prover.LoadInspectionCertDataSetTableAdapters.InspecTableAdapter
        Me.CustomersTableAdapter = New DAM_Prover.LoadInspectionCertDataSetTableAdapters.customersTableAdapter
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InspecBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoadInspectionCertDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoadInspectionCertDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SerialCompanyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InstrumentInformationDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.InstrBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InstrumentInformationDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InstrinfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InstrMenuStrip.SuspendLayout()
        CType(Me.VolumetestBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InspecMenuStrip.SuspendLayout()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.InspectionidDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.InspecBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(558, 337)
        Me.DataGridView1.TabIndex = 0
        '
        'InspectionidDataGridViewTextBoxColumn
        '
        Me.InspectionidDataGridViewTextBoxColumn.DataPropertyName = "inspection_id"
        Me.InspectionidDataGridViewTextBoxColumn.HeaderText = "Inspection ID"
        Me.InspectionidDataGridViewTextBoxColumn.Name = "InspectionidDataGridViewTextBoxColumn"
        Me.InspectionidDataGridViewTextBoxColumn.ReadOnly = True
        Me.InspectionidDataGridViewTextBoxColumn.Width = 125
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        Me.DateDataGridViewTextBoxColumn.ReadOnly = True
        Me.DateDataGridViewTextBoxColumn.Width = 200
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Customer Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        Me.NameDataGridViewTextBoxColumn.Width = 200
        '
        'InspecBindingSource
        '
        Me.InspecBindingSource.DataMember = "Inspec"
        Me.InspecBindingSource.DataSource = Me.LoadInspectionCertDataSetBindingSource
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
        'CustomerComboBox
        '
        Me.CustomerComboBox.DataSource = Me.CustomersBindingSource1
        Me.CustomerComboBox.DisplayMember = "name"
        Me.CustomerComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustomerComboBox.FormattingEnabled = True
        Me.CustomerComboBox.Location = New System.Drawing.Point(71, 3)
        Me.CustomerComboBox.Name = "CustomerComboBox"
        Me.CustomerComboBox.Size = New System.Drawing.Size(792, 21)
        Me.CustomerComboBox.TabIndex = 1
        Me.CustomerComboBox.ValueMember = "customer_id"
        '
        'CustomersBindingSource1
        '
        Me.CustomersBindingSource1.DataMember = "customers"
        Me.CustomersBindingSource1.DataSource = Me.LoadInspectionCertDataSetBindingSource
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Customer Name:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 569.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 303.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox2, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox3, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(872, 557)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CompanyNumberTextBox)
        Me.GroupBox2.Controls.Add(Me.CompanySearchButton)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(572, 102)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(297, 68)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Company Number"
        '
        'CompanyNumberTextBox
        '
        Me.CompanyNumberTextBox.Location = New System.Drawing.Point(25, 26)
        Me.CompanyNumberTextBox.Name = "CompanyNumberTextBox"
        Me.CompanyNumberTextBox.Size = New System.Drawing.Size(143, 20)
        Me.CompanyNumberTextBox.TabIndex = 1
        '
        'CompanySearchButton
        '
        Me.CompanySearchButton.Location = New System.Drawing.Point(176, 24)
        Me.CompanySearchButton.Name = "CompanySearchButton"
        Me.CompanySearchButton.Size = New System.Drawing.Size(75, 23)
        Me.CompanySearchButton.TabIndex = 0
        Me.CompanySearchButton.Text = "Search"
        Me.CompanySearchButton.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel1.SetColumnSpan(Me.TableLayoutPanel2, 2)
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 798.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.CustomerComboBox, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(866, 26)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel1.SetColumnSpan(Me.TableLayoutPanel3, 2)
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.24249!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.75751!))
        Me.TableLayoutPanel3.Controls.Add(Me.DataGridView1, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.DataGridView2, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 176)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(866, 343)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.InstridDataGridViewTextBoxColumn, Me.SerialnumberDataGridViewTextBoxColumn, Me.ItemvalueDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.SerialCompanyBindingSource
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(567, 3)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(296, 337)
        Me.DataGridView2.TabIndex = 1
        '
        'InstridDataGridViewTextBoxColumn
        '
        Me.InstridDataGridViewTextBoxColumn.DataPropertyName = "instr_id"
        Me.InstridDataGridViewTextBoxColumn.HeaderText = "instr_id"
        Me.InstridDataGridViewTextBoxColumn.Name = "InstridDataGridViewTextBoxColumn"
        Me.InstridDataGridViewTextBoxColumn.Visible = False
        '
        'SerialnumberDataGridViewTextBoxColumn
        '
        Me.SerialnumberDataGridViewTextBoxColumn.DataPropertyName = "serial_number"
        Me.SerialnumberDataGridViewTextBoxColumn.HeaderText = "Serial Number"
        Me.SerialnumberDataGridViewTextBoxColumn.Name = "SerialnumberDataGridViewTextBoxColumn"
        '
        'ItemvalueDataGridViewTextBoxColumn
        '
        Me.ItemvalueDataGridViewTextBoxColumn.DataPropertyName = "item_value"
        Me.ItemvalueDataGridViewTextBoxColumn.HeaderText = "Company Number"
        Me.ItemvalueDataGridViewTextBoxColumn.Name = "ItemvalueDataGridViewTextBoxColumn"
        '
        'SerialCompanyBindingSource
        '
        Me.SerialCompanyBindingSource.DataMember = "SerialCompany"
        Me.SerialCompanyBindingSource.DataSource = Me.InstrumentInformationDataSet
        '
        'InstrumentInformationDataSet
        '
        Me.InstrumentInformationDataSet.DataSetName = "InstrumentInformationDataSet"
        Me.InstrumentInformationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.OpenButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.CloseButton)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(702, 525)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(167, 29)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'OpenButton
        '
        Me.OpenButton.Location = New System.Drawing.Point(3, 3)
        Me.OpenButton.Name = "OpenButton"
        Me.OpenButton.Size = New System.Drawing.Size(75, 23)
        Me.OpenButton.TabIndex = 0
        Me.OpenButton.Text = "&Open"
        Me.OpenButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(84, 3)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseButton.TabIndex = 1
        Me.CloseButton.Text = "&Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.SearchDateButton)
        Me.GroupBox1.Controls.Add(Me.EndDateTimePicker)
        Me.GroupBox1.Controls.Add(Me.StartDateTimePicker)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(563, 61)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Start Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(232, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "to"
        '
        'SearchDateButton
        '
        Me.SearchDateButton.Location = New System.Drawing.Point(472, 25)
        Me.SearchDateButton.Name = "SearchDateButton"
        Me.SearchDateButton.Size = New System.Drawing.Size(76, 23)
        Me.SearchDateButton.TabIndex = 5
        Me.SearchDateButton.Text = "Search"
        Me.SearchDateButton.UseVisualStyleBackColor = True
        '
        'EndDateTimePicker
        '
        Me.EndDateTimePicker.CustomFormat = "yyyy-MM-dd"
        Me.EndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.EndDateTimePicker.Location = New System.Drawing.Point(265, 25)
        Me.EndDateTimePicker.Name = "EndDateTimePicker"
        Me.EndDateTimePicker.Size = New System.Drawing.Size(191, 20)
        Me.EndDateTimePicker.TabIndex = 4
        '
        'StartDateTimePicker
        '
        Me.StartDateTimePicker.CustomFormat = "yyyy-MM-dd"
        Me.StartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.StartDateTimePicker.Location = New System.Drawing.Point(18, 25)
        Me.StartDateTimePicker.Name = "StartDateTimePicker"
        Me.StartDateTimePicker.Size = New System.Drawing.Size(196, 20)
        Me.StartDateTimePicker.TabIndex = 3
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.SerialNumberTextBox)
        Me.GroupBox3.Controls.Add(Me.SerialSearchButton)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(572, 35)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(297, 61)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Serial Number"
        '
        'SerialNumberTextBox
        '
        Me.SerialNumberTextBox.Location = New System.Drawing.Point(25, 26)
        Me.SerialNumberTextBox.Name = "SerialNumberTextBox"
        Me.SerialNumberTextBox.Size = New System.Drawing.Size(143, 20)
        Me.SerialNumberTextBox.TabIndex = 1
        '
        'SerialSearchButton
        '
        Me.SerialSearchButton.Location = New System.Drawing.Point(176, 24)
        Me.SerialSearchButton.Name = "SerialSearchButton"
        Me.SerialSearchButton.Size = New System.Drawing.Size(75, 23)
        Me.SerialSearchButton.TabIndex = 0
        Me.SerialSearchButton.Text = "Search"
        Me.SerialSearchButton.UseVisualStyleBackColor = True
        '
        'InstrBindingSource
        '
        Me.InstrBindingSource.DataMember = "instr"
        Me.InstrBindingSource.DataSource = Me.InstrumentInformationDataSetBindingSource
        '
        'InstrumentInformationDataSetBindingSource
        '
        Me.InstrumentInformationDataSetBindingSource.DataSource = Me.InstrumentInformationDataSet
        Me.InstrumentInformationDataSetBindingSource.Position = 0
        '
        'InstrinfoBindingSource
        '
        Me.InstrinfoBindingSource.DataMember = "instr_info"
        Me.InstrinfoBindingSource.DataSource = Me.InstrumentInformationDataSetBindingSource
        '
        'Instr_infoTableAdapter
        '
        Me.Instr_infoTableAdapter.ClearBeforeFill = True
        '
        'InstrTableAdapter
        '
        Me.InstrTableAdapter.ClearBeforeFill = True
        '
        'InstrMenuStrip
        '
        Me.InstrMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditMenuItem})
        Me.InstrMenuStrip.Name = "InstrMenuStrip"
        Me.InstrMenuStrip.Size = New System.Drawing.Size(104, 26)
        '
        'EditMenuItem
        '
        Me.EditMenuItem.Name = "EditMenuItem"
        Me.EditMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.EditMenuItem.Text = "Edit"
        '
        'VolumetestBindingSource
        '
        Me.VolumetestBindingSource.DataMember = "volume_test"
        Me.VolumetestBindingSource.DataSource = Me.InstrumentInformationDataSet
        '
        'Volume_testTableAdapter
        '
        Me.Volume_testTableAdapter.ClearBeforeFill = True
        '
        'SerialCompanyTableAdapter
        '
        Me.SerialCompanyTableAdapter.ClearBeforeFill = True
        '
        'InspecMenuStrip
        '
        Me.InspecMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.EditToolStripMenuItem, Me.CreateCSVToolStripMenuItem})
        Me.InspecMenuStrip.Name = "InspecMenuStrip"
        Me.InspecMenuStrip.Size = New System.Drawing.Size(141, 70)
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.OpenToolStripMenuItem.Text = "&Open"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'CreateCSVToolStripMenuItem
        '
        Me.CreateCSVToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnbridgeNewCSVToolStripMenuItem, Me.StandardCSVToolStripMenuItem})
        Me.CreateCSVToolStripMenuItem.Name = "CreateCSVToolStripMenuItem"
        Me.CreateCSVToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.CreateCSVToolStripMenuItem.Text = "Create CSV"
        '
        'EnbridgeNewCSVToolStripMenuItem
        '
        Me.EnbridgeNewCSVToolStripMenuItem.Name = "EnbridgeNewCSVToolStripMenuItem"
        Me.EnbridgeNewCSVToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.EnbridgeNewCSVToolStripMenuItem.Text = "Enbridge New CSV"
        '
        'StandardCSVToolStripMenuItem
        '
        Me.StandardCSVToolStripMenuItem.Name = "StandardCSVToolStripMenuItem"
        Me.StandardCSVToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.StandardCSVToolStripMenuItem.Text = "Standard CSV"
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "customers"
        Me.CustomersBindingSource.DataSource = Me.LoadInspectionCertDataSet
        '
        'InspecTableAdapter
        '
        Me.InspecTableAdapter.ClearBeforeFill = True
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'ViewInspectionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 557)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "ViewInspectionForm"
        Me.ShowInTaskbar = False
        Me.Text = "Open Inspection Certificate"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InspecBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoadInspectionCertDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoadInspectionCertDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SerialCompanyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InstrumentInformationDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.InstrBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InstrumentInformationDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InstrinfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InstrMenuStrip.ResumeLayout(False)
        CType(Me.VolumetestBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InspecMenuStrip.ResumeLayout(False)
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents InspecBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LoadInspectionCertDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LoadInspectionCertDataSet As DAM_Prover.LoadInspectionCertDataSet
    Friend WithEvents InspecTableAdapter As DAM_Prover.LoadInspectionCertDataSetTableAdapters.InspecTableAdapter
    Friend WithEvents CustomerComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CustomersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomersTableAdapter As DAM_Prover.LoadInspectionCertDataSetTableAdapters.customersTableAdapter
    Friend WithEvents CustomersBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents InspectionidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents OpenButton As System.Windows.Forms.Button
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents InstrBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InstrumentInformationDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InstrumentInformationDataSet As DAM_Prover.InstrumentInformationDataSet
    Friend WithEvents InstrinfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Instr_infoTableAdapter As DAM_Prover.InstrumentInformationDataSetTableAdapters.instr_infoTableAdapter
    Friend WithEvents InstrTableAdapter As DAM_Prover.InstrumentInformationDataSetTableAdapters.instrTableAdapter
    Friend WithEvents InstrMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SerialCompanyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VolumetestBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Volume_testTableAdapter As DAM_Prover.InstrumentInformationDataSetTableAdapters.volume_testTableAdapter
    Friend WithEvents SerialCompanyTableAdapter As DAM_Prover.InstrumentInformationDataSetTableAdapters.SerialCompanyTableAdapter
    Friend WithEvents InstridDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SerialnumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemvalueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InspecMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents EndDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents SerialNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SerialSearchButton As System.Windows.Forms.Button
    Friend WithEvents SearchDateButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CreateCSVToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnbridgeNewCSVToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StandardCSVToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CompanyNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CompanySearchButton As System.Windows.Forms.Button
End Class
