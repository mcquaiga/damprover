<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MeterTypesForm
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
        Me.MeterTypesDataGridView = New System.Windows.Forms.DataGridView
        Me.MeterindexidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MeterDisplacement = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MeterindexBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EquipementDataSet = New DAM_Prover.EquipementDataSet
        Me.OKButton = New System.Windows.Forms.Button
        Me.CancelButton = New System.Windows.Forms.Button
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.CorTextBox = New System.Windows.Forms.TextBox
        Me.UncTextBox = New System.Windows.Forms.TextBox
        Me.SuperTextBox = New System.Windows.Forms.TextBox
        Me.TemperatureTextBox = New System.Windows.Forms.TextBox
        Me.PressureTextBox = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Meter_indexTableAdapter = New DAM_Prover.EquipementDataSetTableAdapters.meter_indexTableAdapter
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ICTextBox = New System.Windows.Forms.TextBox
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        CType(Me.MeterTypesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MeterindexBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EquipementDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MeterTypesDataGridView
        '
        Me.MeterTypesDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MeterTypesDataGridView.AutoGenerateColumns = False
        Me.MeterTypesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MeterTypesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MeterindexidDataGridViewTextBoxColumn, Me.TypeDataGridViewTextBoxColumn, Me.MeterDisplacement})
        Me.MeterTypesDataGridView.DataSource = Me.MeterindexBindingSource
        Me.MeterTypesDataGridView.Location = New System.Drawing.Point(3, 12)
        Me.MeterTypesDataGridView.Name = "MeterTypesDataGridView"
        Me.MeterTypesDataGridView.Size = New System.Drawing.Size(409, 346)
        Me.MeterTypesDataGridView.TabIndex = 0
        '
        'MeterindexidDataGridViewTextBoxColumn
        '
        Me.MeterindexidDataGridViewTextBoxColumn.DataPropertyName = "meter_index_id"
        Me.MeterindexidDataGridViewTextBoxColumn.HeaderText = "Instrument Index (432)"
        Me.MeterindexidDataGridViewTextBoxColumn.Name = "MeterindexidDataGridViewTextBoxColumn"
        '
        'TypeDataGridViewTextBoxColumn
        '
        Me.TypeDataGridViewTextBoxColumn.DataPropertyName = "type"
        Me.TypeDataGridViewTextBoxColumn.HeaderText = "Meter Name"
        Me.TypeDataGridViewTextBoxColumn.Name = "TypeDataGridViewTextBoxColumn"
        '
        'MeterDisplacement
        '
        Me.MeterDisplacement.DataPropertyName = "MeterDisplacement"
        Me.MeterDisplacement.HeaderText = "Meter Displacement"
        Me.MeterDisplacement.Name = "MeterDisplacement"
        '
        'MeterindexBindingSource
        '
        Me.MeterindexBindingSource.DataMember = "meter_index"
        Me.MeterindexBindingSource.DataSource = Me.EquipementDataSet
        '
        'EquipementDataSet
        '
        Me.EquipementDataSet.DataSetName = "EquipementDataSet"
        Me.EquipementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OKButton
        '
        Me.OKButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OKButton.Location = New System.Drawing.Point(3, 3)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(94, 23)
        Me.OKButton.TabIndex = 1
        Me.OKButton.Text = "&OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CancelButton.Location = New System.Drawing.Point(103, 3)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(94, 23)
        Me.CancelButton.TabIndex = 2
        Me.CancelButton.Text = "&Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OKButton, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CancelButton, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(487, 364)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(200, 29)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.CorTextBox, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.UncTextBox, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.SuperTextBox, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.TemperatureTextBox, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.PressureTextBox, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(9, 33)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(238, 126)
        Me.TableLayoutPanel2.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pressure"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(3, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Temperature"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(3, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Supercompressibility"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(3, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Unconverted Volume"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(3, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 26)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Converted Volume"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CorTextBox
        '
        Me.CorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.DAM_Prover.My.MySettings.Default, "CorVolumeTolerance", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CorTextBox.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CorTextBox.Location = New System.Drawing.Point(122, 103)
        Me.CorTextBox.Name = "CorTextBox"
        Me.CorTextBox.Size = New System.Drawing.Size(113, 20)
        Me.CorTextBox.TabIndex = 5
        Me.CorTextBox.Text = Global.DAM_Prover.My.MySettings.Default.CorVolumeTolerance
        '
        'UncTextBox
        '
        Me.UncTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.DAM_Prover.My.MySettings.Default, "UncVolumeTolerance", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.UncTextBox.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UncTextBox.Location = New System.Drawing.Point(122, 78)
        Me.UncTextBox.Name = "UncTextBox"
        Me.UncTextBox.Size = New System.Drawing.Size(113, 20)
        Me.UncTextBox.TabIndex = 6
        Me.UncTextBox.Text = Global.DAM_Prover.My.MySettings.Default.UncVolumeTolerance
        '
        'SuperTextBox
        '
        Me.SuperTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.DAM_Prover.My.MySettings.Default, "SuperTolerance", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.SuperTextBox.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SuperTextBox.Location = New System.Drawing.Point(122, 53)
        Me.SuperTextBox.Name = "SuperTextBox"
        Me.SuperTextBox.Size = New System.Drawing.Size(113, 20)
        Me.SuperTextBox.TabIndex = 7
        Me.SuperTextBox.Text = Global.DAM_Prover.My.MySettings.Default.SuperTolerance
        '
        'TemperatureTextBox
        '
        Me.TemperatureTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.DAM_Prover.My.MySettings.Default, "TemperatureTolerance", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TemperatureTextBox.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TemperatureTextBox.Location = New System.Drawing.Point(122, 28)
        Me.TemperatureTextBox.Name = "TemperatureTextBox"
        Me.TemperatureTextBox.Size = New System.Drawing.Size(113, 20)
        Me.TemperatureTextBox.TabIndex = 8
        Me.TemperatureTextBox.Text = Global.DAM_Prover.My.MySettings.Default.TemperatureTolerance
        '
        'PressureTextBox
        '
        Me.PressureTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.DAM_Prover.My.MySettings.Default, "PressureTolerance", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.PressureTextBox.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PressureTextBox.Location = New System.Drawing.Point(122, 3)
        Me.PressureTextBox.Name = "PressureTextBox"
        Me.PressureTextBox.Size = New System.Drawing.Size(113, 20)
        Me.PressureTextBox.TabIndex = 9
        Me.PressureTextBox.Text = Global.DAM_Prover.My.MySettings.Default.PressureTolerance
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox1.Location = New System.Drawing.Point(425, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(258, 176)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tolerances"
        '
        'Meter_indexTableAdapter
        '
        Me.Meter_indexTableAdapter.ClearBeforeFill = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ICTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(425, 250)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(258, 80)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "IC Report"
        '
        'ICTextBox
        '
        Me.ICTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.DAM_Prover.My.MySettings.Default, "ICLocation", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ICTextBox.Location = New System.Drawing.Point(9, 30)
        Me.ICTextBox.Name = "ICTextBox"
        Me.ICTextBox.Size = New System.Drawing.Size(243, 20)
        Me.ICTextBox.TabIndex = 0
        Me.ICTextBox.Text = Global.DAM_Prover.My.MySettings.Default.ICLocation
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'MeterTypesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 405)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.MeterTypesDataGridView)
        Me.Name = "MeterTypesForm"
        Me.Text = "Advanced Settings"
        CType(Me.MeterTypesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MeterindexBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EquipementDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MeterTypesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents EquipementDataSet As DAM_Prover.EquipementDataSet
    Friend WithEvents MeterindexBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Meter_indexTableAdapter As DAM_Prover.EquipementDataSetTableAdapters.meter_indexTableAdapter
    Friend WithEvents OKButton As System.Windows.Forms.Button
    Friend WithEvents CancelButton As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents MeterindexidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MeterDisplacement As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UncTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SuperTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TemperatureTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PressureTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ICTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
