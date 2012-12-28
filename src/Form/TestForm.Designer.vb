<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestForm
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
        Me.ItemsListView = New System.Windows.Forms.ListView
        Me.Item = New System.Windows.Forms.ColumnHeader
        Me.Value = New System.Windows.Forms.ColumnHeader
        Me.StartTestButton = New System.Windows.Forms.Button
        Me.ExitButton = New System.Windows.Forms.Button
        Me.StartPreButton = New System.Windows.Forms.Button
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.DisconnectButton = New System.Windows.Forms.Button
        Me.LiveReadButton = New System.Windows.Forms.Button
        Me.PressureRangeTextBox = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.PressureTextBox = New System.Windows.Forms.TextBox
        Me.TempTextBox = New System.Windows.Forms.TextBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.PercentMeterLabel = New System.Windows.Forms.Label
        Me.TrueMeterDisplacementTextBox = New System.Windows.Forms.TextBox
        Me.MeterTypeTextBox = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.EVCMeterDisplacementTextBox = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.SerialNumberTextBox = New System.Windows.Forms.TextBox
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.ProgressBar = New System.Windows.Forms.ProgressBar
        Me.CurrentLabel = New System.Windows.Forms.Label
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel
        Me.Item200TextBox = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.CorMultiTextBox = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.UnCorMultiTextBox = New System.Windows.Forms.TextBox
        Me.Item201TextBox = New System.Windows.Forms.TextBox
        Me.Item201Label = New System.Windows.Forms.Label
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.PulserBLabel = New System.Windows.Forms.Label
        Me.PulseBTextBox = New System.Windows.Forms.TextBox
        Me.PulseATextBox = New System.Windows.Forms.TextBox
        Me.PulserALabel = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.TachTextBox = New System.Windows.Forms.TextBox
        Me.PressureUnitsLabel = New System.Windows.Forms.Label
        Me.TempUnitsLabel = New System.Windows.Forms.Label
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'ItemsListView
        '
        Me.ItemsListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Item, Me.Value})
        Me.ItemsListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemsListView.FullRowSelect = True
        Me.ItemsListView.GridLines = True
        Me.ItemsListView.Location = New System.Drawing.Point(3, 3)
        Me.ItemsListView.Name = "ItemsListView"
        Me.ItemsListView.Size = New System.Drawing.Size(357, 137)
        Me.ItemsListView.TabIndex = 19
        Me.ItemsListView.UseCompatibleStateImageBehavior = False
        Me.ItemsListView.View = System.Windows.Forms.View.Details
        '
        'Item
        '
        Me.Item.Text = "Item"
        Me.Item.Width = 83
        '
        'Value
        '
        Me.Value.Text = "Value"
        Me.Value.Width = 109
        '
        'StartTestButton
        '
        Me.StartTestButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StartTestButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.StartTestButton.Location = New System.Drawing.Point(0, 0)
        Me.StartTestButton.Name = "StartTestButton"
        Me.StartTestButton.Size = New System.Drawing.Size(357, 54)
        Me.StartTestButton.TabIndex = 18
        Me.StartTestButton.Text = "Start &Test"
        Me.StartTestButton.UseVisualStyleBackColor = True
        Me.StartTestButton.Visible = False
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.ExitButton.Location = New System.Drawing.Point(0, 0)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(357, 54)
        Me.ExitButton.TabIndex = 14
        Me.ExitButton.Text = "&Cancel"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'StartPreButton
        '
        Me.StartPreButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StartPreButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.StartPreButton.Location = New System.Drawing.Point(0, 0)
        Me.StartPreButton.Name = "StartPreButton"
        Me.StartPreButton.Size = New System.Drawing.Size(357, 54)
        Me.StartPreButton.TabIndex = 13
        Me.StartPreButton.Text = "&Start"
        Me.StartPreButton.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBox3, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBox4, 0, 4)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(366, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel3.SetRowSpan(Me.TableLayoutPanel2, 2)
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(357, 299)
        Me.TableLayoutPanel2.TabIndex = 12
        '
        'GroupBox3
        '
        Me.TableLayoutPanel2.SetColumnSpan(Me.GroupBox3, 2)
        Me.GroupBox3.Controls.Add(Me.TempUnitsLabel)
        Me.GroupBox3.Controls.Add(Me.PressureUnitsLabel)
        Me.GroupBox3.Controls.Add(Me.DisconnectButton)
        Me.GroupBox3.Controls.Add(Me.LiveReadButton)
        Me.GroupBox3.Controls.Add(Me.PressureRangeTextBox)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.PressureTextBox)
        Me.GroupBox3.Controls.Add(Me.TempTextBox)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.TableLayoutPanel2.SetRowSpan(Me.GroupBox3, 3)
        Me.GroupBox3.Size = New System.Drawing.Size(351, 153)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Live Readings"
        '
        'DisconnectButton
        '
        Me.DisconnectButton.Location = New System.Drawing.Point(222, 122)
        Me.DisconnectButton.Name = "DisconnectButton"
        Me.DisconnectButton.Size = New System.Drawing.Size(97, 25)
        Me.DisconnectButton.TabIndex = 11
        Me.DisconnectButton.Text = "Disconnect"
        Me.DisconnectButton.UseVisualStyleBackColor = True
        '
        'LiveReadButton
        '
        Me.LiveReadButton.Location = New System.Drawing.Point(131, 122)
        Me.LiveReadButton.Name = "LiveReadButton"
        Me.LiveReadButton.Size = New System.Drawing.Size(85, 25)
        Me.LiveReadButton.TabIndex = 10
        Me.LiveReadButton.Text = "Connect"
        Me.LiveReadButton.UseVisualStyleBackColor = True
        '
        'PressureRangeTextBox
        '
        Me.PressureRangeTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PressureRangeTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PressureRangeTextBox.Location = New System.Drawing.Point(162, 93)
        Me.PressureRangeTextBox.Name = "PressureRangeTextBox"
        Me.PressureRangeTextBox.ReadOnly = True
        Me.PressureRangeTextBox.Size = New System.Drawing.Size(106, 23)
        Me.PressureRangeTextBox.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(41, 93)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(115, 17)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Pressure Range:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Current Temperature:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Current Pressure:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PressureTextBox
        '
        Me.PressureTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PressureTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PressureTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PressureTextBox.Location = New System.Drawing.Point(162, 64)
        Me.PressureTextBox.Name = "PressureTextBox"
        Me.PressureTextBox.ReadOnly = True
        Me.PressureTextBox.Size = New System.Drawing.Size(106, 22)
        Me.PressureTextBox.TabIndex = 7
        Me.PressureTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TempTextBox
        '
        Me.TempTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TempTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TempTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TempTextBox.Location = New System.Drawing.Point(162, 23)
        Me.TempTextBox.Name = "TempTextBox"
        Me.TempTextBox.ReadOnly = True
        Me.TempTextBox.Size = New System.Drawing.Size(106, 22)
        Me.TempTextBox.TabIndex = 6
        Me.TempTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox4
        '
        Me.TableLayoutPanel2.SetColumnSpan(Me.GroupBox4, 2)
        Me.GroupBox4.Controls.Add(Me.PercentMeterLabel)
        Me.GroupBox4.Controls.Add(Me.TrueMeterDisplacementTextBox)
        Me.GroupBox4.Controls.Add(Me.MeterTypeTextBox)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.EVCMeterDisplacementTextBox)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GroupBox4.Location = New System.Drawing.Point(3, 171)
        Me.GroupBox4.Name = "GroupBox4"
        Me.TableLayoutPanel2.SetRowSpan(Me.GroupBox4, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(351, 125)
        Me.GroupBox4.TabIndex = 17
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Meter"
        '
        'PercentMeterLabel
        '
        Me.PercentMeterLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PercentMeterLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PercentMeterLabel.Location = New System.Drawing.Point(6, 96)
        Me.PercentMeterLabel.Name = "PercentMeterLabel"
        Me.PercentMeterLabel.Size = New System.Drawing.Size(339, 16)
        Me.PercentMeterLabel.TabIndex = 15
        Me.PercentMeterLabel.Text = "Percent Error: --"
        Me.PercentMeterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TrueMeterDisplacementTextBox
        '
        Me.TrueMeterDisplacementTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TrueMeterDisplacementTextBox.Location = New System.Drawing.Point(205, 70)
        Me.TrueMeterDisplacementTextBox.Name = "TrueMeterDisplacementTextBox"
        Me.TrueMeterDisplacementTextBox.ReadOnly = True
        Me.TrueMeterDisplacementTextBox.Size = New System.Drawing.Size(114, 23)
        Me.TrueMeterDisplacementTextBox.TabIndex = 14
        '
        'MeterTypeTextBox
        '
        Me.MeterTypeTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MeterTypeTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.MeterTypeTextBox.Location = New System.Drawing.Point(144, 22)
        Me.MeterTypeTextBox.Name = "MeterTypeTextBox"
        Me.MeterTypeTextBox.ReadOnly = True
        Me.MeterTypeTextBox.Size = New System.Drawing.Size(144, 23)
        Me.MeterTypeTextBox.TabIndex = 10
        Me.MeterTypeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(202, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "True Meter Displ."
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "EVC Meter Displ."
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 17)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Meter Type"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'EVCMeterDisplacementTextBox
        '
        Me.EVCMeterDisplacementTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.EVCMeterDisplacementTextBox.Location = New System.Drawing.Point(43, 70)
        Me.EVCMeterDisplacementTextBox.Name = "EVCMeterDisplacementTextBox"
        Me.EVCMeterDisplacementTextBox.ReadOnly = True
        Me.EVCMeterDisplacementTextBox.Size = New System.Drawing.Size(110, 23)
        Me.EVCMeterDisplacementTextBox.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 26)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Serial Number:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SerialNumberTextBox
        '
        Me.SerialNumberTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.SerialNumberTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SerialNumberTextBox.Location = New System.Drawing.Point(114, 3)
        Me.SerialNumberTextBox.Name = "SerialNumberTextBox"
        Me.SerialNumberTextBox.ReadOnly = True
        Me.SerialNumberTextBox.Size = New System.Drawing.Size(234, 23)
        Me.SerialNumberTextBox.TabIndex = 5
        Me.SerialNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel3.SetColumnSpan(Me.TableLayoutPanel1, 2)
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.54902!))
        Me.TableLayoutPanel1.Controls.Add(Me.ProgressBar, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.CurrentLabel, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 473)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(720, 60)
        Me.TableLayoutPanel1.TabIndex = 11
        '
        'ProgressBar
        '
        Me.ProgressBar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressBar.Location = New System.Drawing.Point(3, 29)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(714, 28)
        Me.ProgressBar.TabIndex = 0
        '
        'CurrentLabel
        '
        Me.CurrentLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CurrentLabel.Location = New System.Drawing.Point(3, 0)
        Me.CurrentLabel.Name = "CurrentLabel"
        Me.CurrentLabel.Size = New System.Drawing.Size(714, 26)
        Me.CurrentLabel.TabIndex = 1
        Me.CurrentLabel.Text = "Currently:                                                                       " & _
            "  "
        Me.CurrentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.ItemsListView, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel2, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel1, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Panel1, 0, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.Panel2, 1, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.GroupBox1, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel5, 0, 2)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 5
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.88525!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.11475!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 165.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(726, 596)
        Me.TableLayoutPanel3.TabIndex = 20
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.StartTestButton)
        Me.Panel1.Controls.Add(Me.StartPreButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 539)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(357, 54)
        Me.Panel1.TabIndex = 21
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ExitButton)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(366, 539)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(357, 54)
        Me.Panel2.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel4)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 146)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(357, 156)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Site Information"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.63842!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.36158!))
        Me.TableLayoutPanel4.Controls.Add(Me.Item200TextBox, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label9, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.SerialNumberTextBox, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label8, 0, 4)
        Me.TableLayoutPanel4.Controls.Add(Me.CorMultiTextBox, 1, 4)
        Me.TableLayoutPanel4.Controls.Add(Me.Label7, 0, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.UnCorMultiTextBox, 1, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.Item201TextBox, 1, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.Item201Label, 0, 2)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 19)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 5
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(351, 134)
        Me.TableLayoutPanel4.TabIndex = 20
        '
        'Item200TextBox
        '
        Me.Item200TextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Item200TextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Item200TextBox.Location = New System.Drawing.Point(114, 29)
        Me.Item200TextBox.Name = "Item200TextBox"
        Me.Item200TextBox.ReadOnly = True
        Me.Item200TextBox.Size = New System.Drawing.Size(234, 23)
        Me.Item200TextBox.TabIndex = 7
        Me.Item200TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Location = New System.Drawing.Point(3, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 26)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Item 200:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Location = New System.Drawing.Point(3, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 31)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "COR Multi."
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CorMultiTextBox
        '
        Me.CorMultiTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.CorMultiTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CorMultiTextBox.Location = New System.Drawing.Point(114, 107)
        Me.CorMultiTextBox.Name = "CorMultiTextBox"
        Me.CorMultiTextBox.ReadOnly = True
        Me.CorMultiTextBox.Size = New System.Drawing.Size(234, 23)
        Me.CorMultiTextBox.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Location = New System.Drawing.Point(3, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 26)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "UNCOR Multi."
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UnCorMultiTextBox
        '
        Me.UnCorMultiTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.UnCorMultiTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UnCorMultiTextBox.Location = New System.Drawing.Point(114, 81)
        Me.UnCorMultiTextBox.Name = "UnCorMultiTextBox"
        Me.UnCorMultiTextBox.ReadOnly = True
        Me.UnCorMultiTextBox.Size = New System.Drawing.Size(234, 23)
        Me.UnCorMultiTextBox.TabIndex = 17
        '
        'Item201TextBox
        '
        Me.Item201TextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Item201TextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Item201TextBox.Location = New System.Drawing.Point(114, 55)
        Me.Item201TextBox.Name = "Item201TextBox"
        Me.Item201TextBox.ReadOnly = True
        Me.Item201TextBox.Size = New System.Drawing.Size(234, 23)
        Me.Item201TextBox.TabIndex = 20
        Me.Item201TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Item201Label
        '
        Me.Item201Label.AutoSize = True
        Me.Item201Label.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Item201Label.Location = New System.Drawing.Point(3, 52)
        Me.Item201Label.Name = "Item201Label"
        Me.Item201Label.Size = New System.Drawing.Size(105, 26)
        Me.Item201Label.TabIndex = 21
        Me.Item201Label.Text = "Item 201:"
        Me.Item201Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 5
        Me.TableLayoutPanel3.SetColumnSpan(Me.TableLayoutPanel5, 2)
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 61.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 301.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 63.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 231.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.GroupBox2, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.GroupBox5, 3, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 308)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(720, 159)
        Me.TableLayoutPanel5.TabIndex = 23
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PulserBLabel)
        Me.GroupBox2.Controls.Add(Me.PulseBTextBox)
        Me.GroupBox2.Controls.Add(Me.PulseATextBox)
        Me.GroupBox2.Controls.Add(Me.PulserALabel)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(64, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(295, 153)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pulse Outputs"
        '
        'PulserBLabel
        '
        Me.PulserBLabel.AutoSize = True
        Me.PulserBLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PulserBLabel.Location = New System.Drawing.Point(33, 99)
        Me.PulserBLabel.Name = "PulserBLabel"
        Me.PulserBLabel.Size = New System.Drawing.Size(77, 20)
        Me.PulserBLabel.TabIndex = 11
        Me.PulserBLabel.Text = "Pulser Yb"
        Me.PulserBLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PulseBTextBox
        '
        Me.PulseBTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PulseBTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PulseBTextBox.Location = New System.Drawing.Point(146, 99)
        Me.PulseBTextBox.Name = "PulseBTextBox"
        Me.PulseBTextBox.ReadOnly = True
        Me.PulseBTextBox.Size = New System.Drawing.Size(130, 26)
        Me.PulseBTextBox.TabIndex = 10
        Me.PulseBTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PulseATextBox
        '
        Me.PulseATextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PulseATextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PulseATextBox.Location = New System.Drawing.Point(146, 43)
        Me.PulseATextBox.Name = "PulseATextBox"
        Me.PulseATextBox.ReadOnly = True
        Me.PulseATextBox.Size = New System.Drawing.Size(130, 26)
        Me.PulseATextBox.TabIndex = 9
        Me.PulseATextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PulserALabel
        '
        Me.PulserALabel.AutoSize = True
        Me.PulserALabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PulserALabel.Location = New System.Drawing.Point(33, 43)
        Me.PulserALabel.Name = "PulserALabel"
        Me.PulserALabel.Size = New System.Drawing.Size(77, 20)
        Me.PulserALabel.TabIndex = 4
        Me.PulserALabel.Text = "Pulser Ya"
        Me.PulserALabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.TachTextBox)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(428, 3)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(225, 153)
        Me.GroupBox5.TabIndex = 19
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Tachometer"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label10.Location = New System.Drawing.Point(29, 44)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(169, 18)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Ideal tachometer reading"
        '
        'TachTextBox
        '
        Me.TachTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TachTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.TachTextBox.Location = New System.Drawing.Point(61, 74)
        Me.TachTextBox.Name = "TachTextBox"
        Me.TachTextBox.ReadOnly = True
        Me.TachTextBox.Size = New System.Drawing.Size(100, 24)
        Me.TachTextBox.TabIndex = 18
        '
        'PressureUnitsLabel
        '
        Me.PressureUnitsLabel.Location = New System.Drawing.Point(274, 64)
        Me.PressureUnitsLabel.Name = "PressureUnitsLabel"
        Me.PressureUnitsLabel.Size = New System.Drawing.Size(68, 20)
        Me.PressureUnitsLabel.TabIndex = 12
        Me.PressureUnitsLabel.Text = " "
        '
        'TempUnitsLabel
        '
        Me.TempUnitsLabel.Location = New System.Drawing.Point(271, 23)
        Me.TempUnitsLabel.Name = "TempUnitsLabel"
        Me.TempUnitsLabel.Size = New System.Drawing.Size(71, 22)
        Me.TempUnitsLabel.TabIndex = 13
        Me.TempUnitsLabel.Text = " "
        '
        'TestForm
        '
        Me.AcceptButton = Me.StartPreButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(726, 596)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Name = "TestForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Test Form"
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ItemsListView As System.Windows.Forms.ListView
    Friend WithEvents Item As System.Windows.Forms.ColumnHeader
    Friend WithEvents Value As System.Windows.Forms.ColumnHeader
    Friend WithEvents StartTestButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents StartPreButton As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SerialNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TempTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PressureTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents CurrentLabel As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Item200TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PulserBLabel As System.Windows.Forms.Label
    Friend WithEvents PulseBTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PulseATextBox As System.Windows.Forms.TextBox
    Friend WithEvents PulserALabel As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CorMultiTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents UnCorMultiTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Item201TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Item201Label As System.Windows.Forms.Label
    Friend WithEvents TachTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents PercentMeterLabel As System.Windows.Forms.Label
    Friend WithEvents TrueMeterDisplacementTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MeterTypeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents EVCMeterDisplacementTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PressureRangeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LiveReadButton As System.Windows.Forms.Button
    Friend WithEvents DisconnectButton As System.Windows.Forms.Button
    Friend WithEvents TempUnitsLabel As System.Windows.Forms.Label
    Friend WithEvents PressureUnitsLabel As System.Windows.Forms.Label
End Class
