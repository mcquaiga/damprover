<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManualVolumeForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox12 = New System.Windows.Forms.GroupBox
        Me.MechanicalRadioButton = New System.Windows.Forms.RadioButton
        Me.RotaryRadioButton = New System.Windows.Forms.RadioButton
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.MeterDisplacementTextBox = New System.Windows.Forms.TextBox
        Me.UnCorMultiplierTextBox = New System.Windows.Forms.TextBox
        Me.CorMultiTextBox = New System.Windows.Forms.TextBox
        Me.DriveRateTextBox = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TempRadioButton = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.SuperNoRadioButton = New System.Windows.Forms.RadioButton
        Me.SuperYesRadioButton = New System.Windows.Forms.RadioButton
        Me.PTRadioButton = New System.Windows.Forms.RadioButton
        Me.PressureRadioButton = New System.Windows.Forms.RadioButton
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.PressureGroupBox = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.PressureUnitsComboBox = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.BasePressureTextBox = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.ATMTextBox = New System.Windows.Forms.TextBox
        Me.PressureTextBox = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.ActualInputTextBox = New System.Windows.Forms.TextBox
        Me.EndCorrectedTextBox = New System.Windows.Forms.TextBox
        Me.EndUncorrectedTextBox = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.TemperatureGroupBox = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.TempUnitsComboBox = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.BaseTempTextBox = New System.Windows.Forms.TextBox
        Me.TempTextBox = New System.Windows.Forms.TextBox
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.StartCorrectedTextBox = New System.Windows.Forms.TextBox
        Me.StartUncorrectedTextBox = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.NoSuperRadioButton = New System.Windows.Forms.RadioButton
        Me.YesSuperRadioButton = New System.Windows.Forms.RadioButton
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.CO2TextBox = New System.Windows.Forms.TextBox
        Me.GroupBox11 = New System.Windows.Forms.GroupBox
        Me.AGA8RadioButton = New System.Windows.Forms.RadioButton
        Me.NX19RadioButton = New System.Windows.Forms.RadioButton
        Me.Label15 = New System.Windows.Forms.Label
        Me.N2TextBox = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.SpecGrTextBox = New System.Windows.Forms.TextBox
        Me.GroupBox10 = New System.Windows.Forms.GroupBox
        Me.CalcTotalCorrectionLabel = New System.Windows.Forms.Label
        Me.InstrumentTotalCorrectionFactorLabel = New System.Windows.Forms.Label
        Me.AccuracyLabel = New System.Windows.Forms.Label
        Me.PercErrorLabel = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.CalculatedTotalCorrectionFactorLabel = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.PressureGroupBox.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TemperatureGroupBox.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox12)
        Me.GroupBox1.Controls.Add(Me.GroupBox8)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(628, 141)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Instrument Settings"
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.MechanicalRadioButton)
        Me.GroupBox12.Controls.Add(Me.RotaryRadioButton)
        Me.GroupBox12.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(151, 67)
        Me.GroupBox12.TabIndex = 5
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "EVC Drive"
        '
        'MechanicalRadioButton
        '
        Me.MechanicalRadioButton.AutoSize = True
        Me.MechanicalRadioButton.Checked = True
        Me.MechanicalRadioButton.Location = New System.Drawing.Point(17, 19)
        Me.MechanicalRadioButton.Name = "MechanicalRadioButton"
        Me.MechanicalRadioButton.Size = New System.Drawing.Size(80, 17)
        Me.MechanicalRadioButton.TabIndex = 4
        Me.MechanicalRadioButton.TabStop = True
        Me.MechanicalRadioButton.Text = "Mechanical"
        Me.MechanicalRadioButton.UseVisualStyleBackColor = True
        '
        'RotaryRadioButton
        '
        Me.RotaryRadioButton.AutoSize = True
        Me.RotaryRadioButton.Location = New System.Drawing.Point(17, 42)
        Me.RotaryRadioButton.Name = "RotaryRadioButton"
        Me.RotaryRadioButton.Size = New System.Drawing.Size(56, 17)
        Me.RotaryRadioButton.TabIndex = 3
        Me.RotaryRadioButton.Text = "Rotary"
        Me.RotaryRadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Label22)
        Me.GroupBox8.Controls.Add(Me.MeterDisplacementTextBox)
        Me.GroupBox8.Controls.Add(Me.UnCorMultiplierTextBox)
        Me.GroupBox8.Controls.Add(Me.CorMultiTextBox)
        Me.GroupBox8.Controls.Add(Me.DriveRateTextBox)
        Me.GroupBox8.Controls.Add(Me.Label3)
        Me.GroupBox8.Controls.Add(Me.Label2)
        Me.GroupBox8.Controls.Add(Me.Label1)
        Me.GroupBox8.Location = New System.Drawing.Point(397, 9)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(183, 126)
        Me.GroupBox8.TabIndex = 2
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Multipliers"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(12, 107)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(30, 13)
        Me.Label22.TabIndex = 7
        Me.Label22.Text = "M.D."
        '
        'MeterDisplacementTextBox
        '
        Me.MeterDisplacementTextBox.Location = New System.Drawing.Point(65, 100)
        Me.MeterDisplacementTextBox.Name = "MeterDisplacementTextBox"
        Me.MeterDisplacementTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MeterDisplacementTextBox.TabIndex = 6
        '
        'UnCorMultiplierTextBox
        '
        Me.UnCorMultiplierTextBox.Location = New System.Drawing.Point(65, 78)
        Me.UnCorMultiplierTextBox.Name = "UnCorMultiplierTextBox"
        Me.UnCorMultiplierTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UnCorMultiplierTextBox.TabIndex = 5
        Me.UnCorMultiplierTextBox.Text = "0"
        '
        'CorMultiTextBox
        '
        Me.CorMultiTextBox.Location = New System.Drawing.Point(65, 51)
        Me.CorMultiTextBox.Name = "CorMultiTextBox"
        Me.CorMultiTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CorMultiTextBox.TabIndex = 4
        Me.CorMultiTextBox.Text = "0"
        '
        'DriveRateTextBox
        '
        Me.DriveRateTextBox.Location = New System.Drawing.Point(65, 24)
        Me.DriveRateTextBox.Name = "DriveRateTextBox"
        Me.DriveRateTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DriveRateTextBox.TabIndex = 3
        Me.DriveRateTextBox.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Item 92"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Item 90"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Item 98"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TempRadioButton)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.PTRadioButton)
        Me.GroupBox2.Controls.Add(Me.PressureRadioButton)
        Me.GroupBox2.Location = New System.Drawing.Point(163, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(164, 83)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Type"
        '
        'TempRadioButton
        '
        Me.TempRadioButton.AutoSize = True
        Me.TempRadioButton.Checked = True
        Me.TempRadioButton.Location = New System.Drawing.Point(6, 19)
        Me.TempRadioButton.Name = "TempRadioButton"
        Me.TempRadioButton.Size = New System.Drawing.Size(85, 17)
        Me.TempRadioButton.TabIndex = 2
        Me.TempRadioButton.TabStop = True
        Me.TempRadioButton.Text = "Temperature"
        Me.TempRadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.SuperNoRadioButton)
        Me.GroupBox3.Controls.Add(Me.SuperYesRadioButton)
        Me.GroupBox3.Location = New System.Drawing.Point(86, 89)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(116, 26)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'SuperNoRadioButton
        '
        Me.SuperNoRadioButton.AutoSize = True
        Me.SuperNoRadioButton.Location = New System.Drawing.Point(99, 12)
        Me.SuperNoRadioButton.Name = "SuperNoRadioButton"
        Me.SuperNoRadioButton.Size = New System.Drawing.Size(39, 17)
        Me.SuperNoRadioButton.TabIndex = 1
        Me.SuperNoRadioButton.TabStop = True
        Me.SuperNoRadioButton.Text = "No"
        Me.SuperNoRadioButton.UseVisualStyleBackColor = True
        '
        'SuperYesRadioButton
        '
        Me.SuperYesRadioButton.AutoSize = True
        Me.SuperYesRadioButton.Location = New System.Drawing.Point(12, 12)
        Me.SuperYesRadioButton.Name = "SuperYesRadioButton"
        Me.SuperYesRadioButton.Size = New System.Drawing.Size(43, 17)
        Me.SuperYesRadioButton.TabIndex = 0
        Me.SuperYesRadioButton.TabStop = True
        Me.SuperYesRadioButton.Text = "Yes"
        Me.SuperYesRadioButton.UseVisualStyleBackColor = True
        '
        'PTRadioButton
        '
        Me.PTRadioButton.AutoSize = True
        Me.PTRadioButton.Location = New System.Drawing.Point(6, 59)
        Me.PTRadioButton.Name = "PTRadioButton"
        Me.PTRadioButton.Size = New System.Drawing.Size(138, 17)
        Me.PTRadioButton.TabIndex = 1
        Me.PTRadioButton.Text = "Pressure && Temperature"
        Me.PTRadioButton.UseVisualStyleBackColor = True
        '
        'PressureRadioButton
        '
        Me.PressureRadioButton.AutoSize = True
        Me.PressureRadioButton.Location = New System.Drawing.Point(6, 39)
        Me.PressureRadioButton.Name = "PressureRadioButton"
        Me.PressureRadioButton.Size = New System.Drawing.Size(66, 17)
        Me.PressureRadioButton.TabIndex = 0
        Me.PressureRadioButton.Text = "Pressure"
        Me.PressureRadioButton.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.37811!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.62189!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(634, 604)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.PressureGroupBox, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBox5, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TemperatureGroupBox, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBox7, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBox9, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBox10, 1, 2)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 150)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.5858!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.04219!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.42194!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(628, 451)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'PressureGroupBox
        '
        Me.PressureGroupBox.Controls.Add(Me.Label7)
        Me.PressureGroupBox.Controls.Add(Me.PressureUnitsComboBox)
        Me.PressureGroupBox.Controls.Add(Me.Label6)
        Me.PressureGroupBox.Controls.Add(Me.BasePressureTextBox)
        Me.PressureGroupBox.Controls.Add(Me.Label5)
        Me.PressureGroupBox.Controls.Add(Me.ATMTextBox)
        Me.PressureGroupBox.Controls.Add(Me.PressureTextBox)
        Me.PressureGroupBox.Controls.Add(Me.Label4)
        Me.PressureGroupBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PressureGroupBox.Enabled = False
        Me.PressureGroupBox.Location = New System.Drawing.Point(3, 3)
        Me.PressureGroupBox.Name = "PressureGroupBox"
        Me.PressureGroupBox.Size = New System.Drawing.Size(308, 127)
        Me.PressureGroupBox.TabIndex = 0
        Me.PressureGroupBox.TabStop = False
        Me.PressureGroupBox.Text = "Pressure"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(185, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Units:"
        '
        'PressureUnitsComboBox
        '
        Me.PressureUnitsComboBox.FormattingEnabled = True
        Me.PressureUnitsComboBox.Location = New System.Drawing.Point(186, 29)
        Me.PressureUnitsComboBox.Name = "PressureUnitsComboBox"
        Me.PressureUnitsComboBox.Size = New System.Drawing.Size(104, 21)
        Me.PressureUnitsComboBox.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Base Pressure:"
        '
        'BasePressureTextBox
        '
        Me.BasePressureTextBox.Location = New System.Drawing.Point(88, 71)
        Me.BasePressureTextBox.Name = "BasePressureTextBox"
        Me.BasePressureTextBox.Size = New System.Drawing.Size(92, 20)
        Me.BasePressureTextBox.TabIndex = 4
        Me.BasePressureTextBox.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "ATM Pressure:"
        '
        'ATMTextBox
        '
        Me.ATMTextBox.Location = New System.Drawing.Point(88, 45)
        Me.ATMTextBox.Name = "ATMTextBox"
        Me.ATMTextBox.Size = New System.Drawing.Size(92, 20)
        Me.ATMTextBox.TabIndex = 2
        Me.ATMTextBox.Text = "0"
        '
        'PressureTextBox
        '
        Me.PressureTextBox.Location = New System.Drawing.Point(88, 19)
        Me.PressureTextBox.Name = "PressureTextBox"
        Me.PressureTextBox.Size = New System.Drawing.Size(92, 20)
        Me.PressureTextBox.TabIndex = 1
        Me.PressureTextBox.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Pressure:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Controls.Add(Me.ActualInputTextBox)
        Me.GroupBox5.Controls.Add(Me.EndCorrectedTextBox)
        Me.GroupBox5.Controls.Add(Me.EndUncorrectedTextBox)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox5.Location = New System.Drawing.Point(317, 136)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(308, 84)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "End Reading"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(183, 38)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 13)
        Me.Label19.TabIndex = 5
        Me.Label19.Text = "Input Volume:"
        '
        'ActualInputTextBox
        '
        Me.ActualInputTextBox.Location = New System.Drawing.Point(186, 54)
        Me.ActualInputTextBox.Name = "ActualInputTextBox"
        Me.ActualInputTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ActualInputTextBox.TabIndex = 4
        Me.ActualInputTextBox.Text = "0"
        '
        'EndCorrectedTextBox
        '
        Me.EndCorrectedTextBox.Location = New System.Drawing.Point(80, 54)
        Me.EndCorrectedTextBox.Name = "EndCorrectedTextBox"
        Me.EndCorrectedTextBox.Size = New System.Drawing.Size(77, 20)
        Me.EndCorrectedTextBox.TabIndex = 3
        Me.EndCorrectedTextBox.Text = "0"
        '
        'EndUncorrectedTextBox
        '
        Me.EndUncorrectedTextBox.Location = New System.Drawing.Point(80, 19)
        Me.EndUncorrectedTextBox.Name = "EndUncorrectedTextBox"
        Me.EndUncorrectedTextBox.Size = New System.Drawing.Size(77, 20)
        Me.EndUncorrectedTextBox.TabIndex = 2
        Me.EndUncorrectedTextBox.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(7, 58)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 13)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Corrected:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(7, 23)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Uncorrected:"
        '
        'TemperatureGroupBox
        '
        Me.TemperatureGroupBox.Controls.Add(Me.Label10)
        Me.TemperatureGroupBox.Controls.Add(Me.TempUnitsComboBox)
        Me.TemperatureGroupBox.Controls.Add(Me.Label9)
        Me.TemperatureGroupBox.Controls.Add(Me.Label8)
        Me.TemperatureGroupBox.Controls.Add(Me.BaseTempTextBox)
        Me.TemperatureGroupBox.Controls.Add(Me.TempTextBox)
        Me.TemperatureGroupBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TemperatureGroupBox.Location = New System.Drawing.Point(317, 3)
        Me.TemperatureGroupBox.Name = "TemperatureGroupBox"
        Me.TemperatureGroupBox.Size = New System.Drawing.Size(308, 127)
        Me.TemperatureGroupBox.TabIndex = 2
        Me.TemperatureGroupBox.TabStop = False
        Me.TemperatureGroupBox.Text = "Temperature"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(183, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Units:"
        '
        'TempUnitsComboBox
        '
        Me.TempUnitsComboBox.FormattingEnabled = True
        Me.TempUnitsComboBox.Location = New System.Drawing.Point(186, 25)
        Me.TempUnitsComboBox.Name = "TempUnitsComboBox"
        Me.TempUnitsComboBox.Size = New System.Drawing.Size(105, 21)
        Me.TempUnitsComboBox.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Base Temp."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Temperature"
        '
        'BaseTempTextBox
        '
        Me.BaseTempTextBox.Location = New System.Drawing.Point(80, 56)
        Me.BaseTempTextBox.Name = "BaseTempTextBox"
        Me.BaseTempTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BaseTempTextBox.TabIndex = 1
        Me.BaseTempTextBox.Text = "0"
        '
        'TempTextBox
        '
        Me.TempTextBox.Location = New System.Drawing.Point(80, 26)
        Me.TempTextBox.Name = "TempTextBox"
        Me.TempTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TempTextBox.TabIndex = 0
        Me.TempTextBox.Text = "0"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.StartCorrectedTextBox)
        Me.GroupBox7.Controls.Add(Me.StartUncorrectedTextBox)
        Me.GroupBox7.Controls.Add(Me.Label12)
        Me.GroupBox7.Controls.Add(Me.Label11)
        Me.GroupBox7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox7.Location = New System.Drawing.Point(3, 136)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(308, 84)
        Me.GroupBox7.TabIndex = 3
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Start Reading"
        '
        'StartCorrectedTextBox
        '
        Me.StartCorrectedTextBox.Location = New System.Drawing.Point(88, 54)
        Me.StartCorrectedTextBox.Name = "StartCorrectedTextBox"
        Me.StartCorrectedTextBox.Size = New System.Drawing.Size(92, 20)
        Me.StartCorrectedTextBox.TabIndex = 3
        Me.StartCorrectedTextBox.Text = "0"
        '
        'StartUncorrectedTextBox
        '
        Me.StartUncorrectedTextBox.Location = New System.Drawing.Point(88, 19)
        Me.StartUncorrectedTextBox.Name = "StartUncorrectedTextBox"
        Me.StartUncorrectedTextBox.Size = New System.Drawing.Size(91, 20)
        Me.StartUncorrectedTextBox.TabIndex = 2
        Me.StartUncorrectedTextBox.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 58)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Corrected:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 23)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Uncorrected:"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.GroupBox6)
        Me.GroupBox9.Controls.Add(Me.GroupBox4)
        Me.GroupBox9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox9.Location = New System.Drawing.Point(3, 226)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(308, 222)
        Me.GroupBox9.TabIndex = 4
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Supercompresibility"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.NoSuperRadioButton)
        Me.GroupBox6.Controls.Add(Me.YesSuperRadioButton)
        Me.GroupBox6.Location = New System.Drawing.Point(60, 25)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(181, 37)
        Me.GroupBox6.TabIndex = 8
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Use Supercompressibility?"
        '
        'NoSuperRadioButton
        '
        Me.NoSuperRadioButton.AutoSize = True
        Me.NoSuperRadioButton.Location = New System.Drawing.Point(100, 14)
        Me.NoSuperRadioButton.Name = "NoSuperRadioButton"
        Me.NoSuperRadioButton.Size = New System.Drawing.Size(39, 17)
        Me.NoSuperRadioButton.TabIndex = 1
        Me.NoSuperRadioButton.TabStop = True
        Me.NoSuperRadioButton.Text = "No"
        Me.NoSuperRadioButton.UseVisualStyleBackColor = True
        '
        'YesSuperRadioButton
        '
        Me.YesSuperRadioButton.AutoSize = True
        Me.YesSuperRadioButton.Location = New System.Drawing.Point(28, 14)
        Me.YesSuperRadioButton.Name = "YesSuperRadioButton"
        Me.YesSuperRadioButton.Size = New System.Drawing.Size(43, 17)
        Me.YesSuperRadioButton.TabIndex = 0
        Me.YesSuperRadioButton.TabStop = True
        Me.YesSuperRadioButton.Text = "Yes"
        Me.YesSuperRadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.CO2TextBox)
        Me.GroupBox4.Controls.Add(Me.GroupBox11)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.N2TextBox)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.SpecGrTextBox)
        Me.GroupBox4.Location = New System.Drawing.Point(4, 79)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(298, 128)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Super. Factors"
        '
        'CO2TextBox
        '
        Me.CO2TextBox.Location = New System.Drawing.Point(73, 60)
        Me.CO2TextBox.Name = "CO2TextBox"
        Me.CO2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.CO2TextBox.TabIndex = 4
        Me.CO2TextBox.Text = "0"
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.AGA8RadioButton)
        Me.GroupBox11.Controls.Add(Me.NX19RadioButton)
        Me.GroupBox11.Location = New System.Drawing.Point(191, 42)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(103, 73)
        Me.GroupBox11.TabIndex = 6
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Table"
        '
        'AGA8RadioButton
        '
        Me.AGA8RadioButton.AutoSize = True
        Me.AGA8RadioButton.Location = New System.Drawing.Point(22, 49)
        Me.AGA8RadioButton.Name = "AGA8RadioButton"
        Me.AGA8RadioButton.Size = New System.Drawing.Size(56, 17)
        Me.AGA8RadioButton.TabIndex = 1
        Me.AGA8RadioButton.TabStop = True
        Me.AGA8RadioButton.Text = "AGA-8"
        Me.AGA8RadioButton.UseVisualStyleBackColor = True
        '
        'NX19RadioButton
        '
        Me.NX19RadioButton.AutoSize = True
        Me.NX19RadioButton.Location = New System.Drawing.Point(22, 16)
        Me.NX19RadioButton.Name = "NX19RadioButton"
        Me.NX19RadioButton.Size = New System.Drawing.Size(55, 17)
        Me.NX19RadioButton.TabIndex = 0
        Me.NX19RadioButton.TabStop = True
        Me.NX19RadioButton.Text = "NX-19"
        Me.NX19RadioButton.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(11, 20)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 26)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Spec. Gr." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " (Item 53)"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'N2TextBox
        '
        Me.N2TextBox.Location = New System.Drawing.Point(73, 95)
        Me.N2TextBox.Name = "N2TextBox"
        Me.N2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.N2TextBox.TabIndex = 5
        Me.N2TextBox.Text = "0"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(11, 56)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(48, 26)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "CO2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Item 54)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(11, 91)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(48, 26)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "N2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Item 55)"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SpecGrTextBox
        '
        Me.SpecGrTextBox.Location = New System.Drawing.Point(73, 24)
        Me.SpecGrTextBox.Name = "SpecGrTextBox"
        Me.SpecGrTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SpecGrTextBox.TabIndex = 3
        Me.SpecGrTextBox.Text = "0"
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.CalcTotalCorrectionLabel)
        Me.GroupBox10.Controls.Add(Me.InstrumentTotalCorrectionFactorLabel)
        Me.GroupBox10.Controls.Add(Me.AccuracyLabel)
        Me.GroupBox10.Controls.Add(Me.PercErrorLabel)
        Me.GroupBox10.Controls.Add(Me.Label21)
        Me.GroupBox10.Controls.Add(Me.Label20)
        Me.GroupBox10.Controls.Add(Me.CalculatedTotalCorrectionFactorLabel)
        Me.GroupBox10.Controls.Add(Me.Label18)
        Me.GroupBox10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox10.Location = New System.Drawing.Point(317, 226)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(308, 222)
        Me.GroupBox10.TabIndex = 5
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Volume Verification"
        '
        'CalcTotalCorrectionLabel
        '
        Me.CalcTotalCorrectionLabel.AutoSize = True
        Me.CalcTotalCorrectionLabel.Location = New System.Drawing.Point(230, 54)
        Me.CalcTotalCorrectionLabel.Name = "CalcTotalCorrectionLabel"
        Me.CalcTotalCorrectionLabel.Size = New System.Drawing.Size(13, 13)
        Me.CalcTotalCorrectionLabel.TabIndex = 7
        Me.CalcTotalCorrectionLabel.Text = "0"
        '
        'InstrumentTotalCorrectionFactorLabel
        '
        Me.InstrumentTotalCorrectionFactorLabel.AutoSize = True
        Me.InstrumentTotalCorrectionFactorLabel.Location = New System.Drawing.Point(230, 25)
        Me.InstrumentTotalCorrectionFactorLabel.Name = "InstrumentTotalCorrectionFactorLabel"
        Me.InstrumentTotalCorrectionFactorLabel.Size = New System.Drawing.Size(13, 13)
        Me.InstrumentTotalCorrectionFactorLabel.TabIndex = 6
        Me.InstrumentTotalCorrectionFactorLabel.Text = "0"
        '
        'AccuracyLabel
        '
        Me.AccuracyLabel.AutoSize = True
        Me.AccuracyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccuracyLabel.Location = New System.Drawing.Point(223, 141)
        Me.AccuracyLabel.Name = "AccuracyLabel"
        Me.AccuracyLabel.Size = New System.Drawing.Size(18, 20)
        Me.AccuracyLabel.TabIndex = 5
        Me.AccuracyLabel.Text = "0"
        '
        'PercErrorLabel
        '
        Me.PercErrorLabel.AutoSize = True
        Me.PercErrorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PercErrorLabel.Location = New System.Drawing.Point(223, 105)
        Me.PercErrorLabel.Name = "PercErrorLabel"
        Me.PercErrorLabel.Size = New System.Drawing.Size(18, 20)
        Me.PercErrorLabel.TabIndex = 4
        Me.PercErrorLabel.Text = "0"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(45, 141)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(136, 20)
        Me.Label21.TabIndex = 3
        Me.Label21.Text = "% Corrected Error"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(34, 105)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(154, 20)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "% Uncorrected Error"
        '
        'CalculatedTotalCorrectionFactorLabel
        '
        Me.CalculatedTotalCorrectionFactorLabel.AutoSize = True
        Me.CalculatedTotalCorrectionFactorLabel.Location = New System.Drawing.Point(65, 54)
        Me.CalculatedTotalCorrectionFactorLabel.Name = "CalculatedTotalCorrectionFactorLabel"
        Me.CalculatedTotalCorrectionFactorLabel.Size = New System.Drawing.Size(69, 13)
        Me.CalculatedTotalCorrectionFactorLabel.TabIndex = 1
        Me.CalculatedTotalCorrectionFactorLabel.Text = "True Cor. Vol"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(63, 25)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(71, 13)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "EVC Cor. Vol."
        '
        'ManualVolumeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 604)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "ManualVolumeForm"
        Me.Text = "Manual Volume"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.PressureGroupBox.ResumeLayout(False)
        Me.PressureGroupBox.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.TemperatureGroupBox.ResumeLayout(False)
        Me.TemperatureGroupBox.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents SuperNoRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents SuperYesRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TempRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents PTRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents PressureRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PressureGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents TemperatureGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents UnCorMultiplierTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CorMultiTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DriveRateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BasePressureTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ATMTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PressureTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PressureUnitsComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TempUnitsComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BaseTempTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TempTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents StartCorrectedTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StartUncorrectedTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents EndCorrectedTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EndUncorrectedTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents AGA8RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents NX19RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents N2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents CO2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents SpecGrTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents CalculatedTotalCorrectionFactorLabel As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents CalcTotalCorrectionLabel As System.Windows.Forms.Label
    Friend WithEvents InstrumentTotalCorrectionFactorLabel As System.Windows.Forms.Label
    Friend WithEvents AccuracyLabel As System.Windows.Forms.Label
    Friend WithEvents PercErrorLabel As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ActualInputTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents MechanicalRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents RotaryRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents MeterDisplacementTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents NoSuperRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents YesSuperRadioButton As System.Windows.Forms.RadioButton
End Class
