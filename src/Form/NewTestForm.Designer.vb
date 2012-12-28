<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewTestForm
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
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Rotary", "minimaxr_01.gif")
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("TCI", 1)
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Mini-Max", "minimax_01.gif")
        Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Mini-AT", "miniat_01.jpg")
        Dim ListViewItem10 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("EC-AT", 0)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewTestForm))
        Dim MySettings2 As DAM_Prover.My.MySettings = New DAM_Prover.My.MySettings
        Me.InstrumentsListView = New System.Windows.Forms.ListView
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.RotaryTabControl = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.AddCustomerButton = New System.Windows.Forms.Button
        Me.SetDateTimeCheckBox = New System.Windows.Forms.CheckBox
        Me.CustomerComboBox = New System.Windows.Forms.ComboBox
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerItemsDataSet = New DAM_Prover.CustomerItemsDataSet
        Me.EditButton = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.StopMotorButton = New System.Windows.Forms.Button
        Me.StartMotorButton = New System.Windows.Forms.Button
        Me.Label16 = New System.Windows.Forms.Label
        Me.DABoardComboBox = New System.Windows.Forms.ComboBox
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.TestDBButton = New System.Windows.Forms.Button
        Me.Label13 = New System.Windows.Forms.Label
        Me.ServerTextBox = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.DBTextBox = New System.Windows.Forms.TextBox
        Me.PasswordTextBox = New System.Windows.Forms.TextBox
        Me.DbUserNameTextBox = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TestTachButton = New System.Windows.Forms.Button
        Me.TachSerialComboBox = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.AccessCodeTextBox = New System.Windows.Forms.TextBox
        Me.InstBaudComboBox = New System.Windows.Forms.ComboBox
        Me.InstCommComboBox = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TestButton = New System.Windows.Forms.Button
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.MechMetricExcelTextBox = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.MechExcelTextBox = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.RotaryMetricExcelTextBox = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.RotaryEnglishExcelTextBox = New System.Windows.Forms.TextBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.UncOnlyTestCheckBox = New System.Windows.Forms.CheckBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.ManualPressureCheckBox = New System.Windows.Forms.CheckBox
        Me.PressureLimitTextBox = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.PressurePercentErrorTextBox = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.ManualTempCheckBox = New System.Windows.Forms.CheckBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TempLimitTextBox = New System.Windows.Forms.TextBox
        Me.TempPercentErrorTextBox = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.CustomeritemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerItemsDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StartButton = New System.Windows.Forms.Button
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintInspectionCertificateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RestartIrDAServiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SetInstrumentDateAndTimeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RawItemAccessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditRotaryMeterTypesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataAcqWiringDiagramsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Customer_itemsTableAdapter = New DAM_Prover.CustomerItemsDataSetTableAdapters.customer_itemsTableAdapter
        Me.CustomersTableAdapter = New DAM_Prover.CustomerItemsDataSetTableAdapters.customersTableAdapter
        Me.BoardTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.TableLayoutPanel1.SuspendLayout()
        Me.RotaryTabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerItemsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.CustomeritemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerItemsDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.BoardTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InstrumentsListView
        '
        Me.InstrumentsListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InstrumentsListView.HideSelection = False
        Me.InstrumentsListView.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem6, ListViewItem7, ListViewItem8, ListViewItem9, ListViewItem10})
        Me.InstrumentsListView.LargeImageList = Me.ImageList1
        Me.InstrumentsListView.Location = New System.Drawing.Point(3, 3)
        Me.InstrumentsListView.MultiSelect = False
        Me.InstrumentsListView.Name = "InstrumentsListView"
        Me.InstrumentsListView.Size = New System.Drawing.Size(103, 368)
        Me.InstrumentsListView.TabIndex = 0
        Me.InstrumentsListView.UseCompatibleStateImageBehavior = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "erx_800_case_large.jpg")
        Me.ImageList1.Images.SetKeyName(1, "metreteck_img.gif")
        Me.ImageList1.Images.SetKeyName(2, "miniat_01.jpg")
        Me.ImageList1.Images.SetKeyName(3, "minimax_01.gif")
        Me.ImageList1.Images.SetKeyName(4, "minimaxr_01.gif")
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.InstrumentsListView, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.RotaryTabControl, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 27)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(725, 374)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'RotaryTabControl
        '
        Me.RotaryTabControl.Controls.Add(Me.TabPage1)
        Me.RotaryTabControl.Controls.Add(Me.TabPage2)
        Me.RotaryTabControl.Controls.Add(Me.TabPage3)
        Me.RotaryTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RotaryTabControl.Location = New System.Drawing.Point(112, 3)
        Me.RotaryTabControl.Name = "RotaryTabControl"
        Me.RotaryTabControl.SelectedIndex = 0
        Me.RotaryTabControl.Size = New System.Drawing.Size(610, 368)
        Me.RotaryTabControl.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(602, 342)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Customer"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.AddCustomerButton, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.SetDateTimeCheckBox, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.CustomerComboBox, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.EditButton, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(103, 103)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.25!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.54167!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(372, 117)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'AddCustomerButton
        '
        Me.AddCustomerButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.AddCustomerButton.Location = New System.Drawing.Point(3, 62)
        Me.AddCustomerButton.Name = "AddCustomerButton"
        Me.AddCustomerButton.Size = New System.Drawing.Size(180, 31)
        Me.AddCustomerButton.TabIndex = 18
        Me.AddCustomerButton.Text = "Add Customer..."
        Me.AddCustomerButton.UseVisualStyleBackColor = True
        '
        'SetDateTimeCheckBox
        '
        Me.SetDateTimeCheckBox.AutoSize = True
        MySettings2.BoardType = "1"
        MySettings2.CorVolumeTolerance = "1.0"
        MySettings2.CustomerId = 0
        MySettings2.DB = "dam_prover_test"
        MySettings2.DB_server = "damserver"
        MySettings2.Dimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        MySettings2.ExcelLocation = "C:\Mi Testing Files\"
        MySettings2.ExcelReport = True
        MySettings2.HighPressureLowTemp = "Auto"
        MySettings2.InstrumentAccessCode = "33333"
        MySettings2.InstrumentBaudRate = "38400"
        MySettings2.InstrumentCommPort = "COM1"
        MySettings2.Location = New System.Drawing.Point(0, 0)
        MySettings2.LowPressureHighTemp = "Auto"
        MySettings2.ManualPressure = False
        MySettings2.ManualTemp = False
        MySettings2.MechExcel = "C:\Mi Testing Files\"
        MySettings2.MechMetricExcel = "C:\Mi Testing Files\"
        MySettings2.MidPressureMidTemp = "Auto"
        MySettings2.Password = "damprover09"
        MySettings2.PCIBoardName = """DT335(00)"""
        MySettings2.PressureLimit = "80"
        MySettings2.PressurePercentageMax = 0.8
        MySettings2.PressureTolerance = "1.0"
        MySettings2.PulserADataFlow = 1
        MySettings2.PulserASubsystem = 0
        MySettings2.PulserBDataFlow = 1
        MySettings2.PulserBSubsystem = 1
        MySettings2.PulserOutDataFlow = 1
        MySettings2.PulserOutSubsystem = 5
        MySettings2.RotaryMetricExcel = "C:\Mi Testing Files\"
        MySettings2.SetInstrumentDateTime = False
        MySettings2.SettingsKey = ""
        MySettings2.SuperTolerance = "0.3"
        MySettings2.TachCommPort = "COM2"
        MySettings2.TCIAccessCode = 33333
        MySettings2.TCIBaudRate = miSerialProtocol.BaudRateEnum.b38400
        MySettings2.TCICommPort = 5
        MySettings2.TemperatureTolerance = "1.0"
        MySettings2.TempLimit = "35"
        MySettings2.TempPercentageMax = 0.8
        MySettings2.UncVolumeOnly = False
        MySettings2.UncVolumeTolerance = "0.1"
        MySettings2.USBBoardName = ""
        MySettings2.UserID = "damprover09"
        Me.SetDateTimeCheckBox.Checked = MySettings2.SetInstrumentDateTime
        Me.TableLayoutPanel2.SetColumnSpan(Me.SetDateTimeCheckBox, 2)
        Me.SetDateTimeCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", MySettings2, "SetInstrumentDateTime", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.SetDateTimeCheckBox.Location = New System.Drawing.Point(3, 99)
        Me.SetDateTimeCheckBox.Name = "SetDateTimeCheckBox"
        Me.SetDateTimeCheckBox.Size = New System.Drawing.Size(160, 15)
        Me.SetDateTimeCheckBox.TabIndex = 17
        Me.SetDateTimeCheckBox.Text = "Set instrument date and time"
        Me.SetDateTimeCheckBox.UseVisualStyleBackColor = True
        '
        'CustomerComboBox
        '
        Me.TableLayoutPanel2.SetColumnSpan(Me.CustomerComboBox, 2)
        Me.CustomerComboBox.DataSource = Me.CustomersBindingSource
        Me.CustomerComboBox.DisplayMember = "name"
        Me.CustomerComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustomerComboBox.FormattingEnabled = True
        Me.CustomerComboBox.Location = New System.Drawing.Point(3, 32)
        Me.CustomerComboBox.Name = "CustomerComboBox"
        Me.CustomerComboBox.Size = New System.Drawing.Size(366, 21)
        Me.CustomerComboBox.TabIndex = 0
        Me.CustomerComboBox.ValueMember = "customer_id"
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "customers"
        Me.CustomersBindingSource.DataSource = Me.CustomerItemsDataSet
        '
        'CustomerItemsDataSet
        '
        Me.CustomerItemsDataSet.DataSetName = "CustomerItemsDataSet"
        Me.CustomerItemsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EditButton
        '
        Me.EditButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.EditButton.Location = New System.Drawing.Point(189, 62)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(180, 31)
        Me.EditButton.TabIndex = 2
        Me.EditButton.Text = "Edit Customers..."
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Customer:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox8)
        Me.TabPage2.Controls.Add(Me.GroupBox7)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(602, 342)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Communications"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Button1)
        Me.GroupBox8.Controls.Add(Me.StopMotorButton)
        Me.GroupBox8.Controls.Add(Me.StartMotorButton)
        Me.GroupBox8.Controls.Add(Me.Label16)
        Me.GroupBox8.Controls.Add(Me.DABoardComboBox)
        Me.GroupBox8.Location = New System.Drawing.Point(264, 6)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(326, 162)
        Me.GroupBox8.TabIndex = 3
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Data Acq. Board"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(248, 64)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 20)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Options"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'StopMotorButton
        '
        Me.StopMotorButton.Location = New System.Drawing.Point(184, 117)
        Me.StopMotorButton.Name = "StopMotorButton"
        Me.StopMotorButton.Size = New System.Drawing.Size(72, 27)
        Me.StopMotorButton.TabIndex = 8
        Me.StopMotorButton.Text = "Stop Motor"
        Me.StopMotorButton.UseVisualStyleBackColor = True
        '
        'StartMotorButton
        '
        Me.StartMotorButton.Location = New System.Drawing.Point(86, 117)
        Me.StartMotorButton.Name = "StartMotorButton"
        Me.StartMotorButton.Size = New System.Drawing.Size(74, 27)
        Me.StartMotorButton.TabIndex = 7
        Me.StartMotorButton.Text = "Start Motor"
        Me.StartMotorButton.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(22, 68)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(35, 13)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Board"
        '
        'DABoardComboBox
        '
        Me.DABoardComboBox.FormattingEnabled = True
        Me.DABoardComboBox.Location = New System.Drawing.Point(63, 63)
        Me.DABoardComboBox.Name = "DABoardComboBox"
        Me.DABoardComboBox.Size = New System.Drawing.Size(170, 21)
        Me.DABoardComboBox.TabIndex = 5
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.TestDBButton)
        Me.GroupBox7.Controls.Add(Me.Label13)
        Me.GroupBox7.Controls.Add(Me.ServerTextBox)
        Me.GroupBox7.Controls.Add(Me.Label12)
        Me.GroupBox7.Controls.Add(Me.Label11)
        Me.GroupBox7.Controls.Add(Me.Label10)
        Me.GroupBox7.Controls.Add(Me.DBTextBox)
        Me.GroupBox7.Controls.Add(Me.PasswordTextBox)
        Me.GroupBox7.Controls.Add(Me.DbUserNameTextBox)
        Me.GroupBox7.Location = New System.Drawing.Point(264, 175)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(327, 145)
        Me.GroupBox7.TabIndex = 2
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Database"
        '
        'TestDBButton
        '
        Me.TestDBButton.Location = New System.Drawing.Point(245, 102)
        Me.TestDBButton.Name = "TestDBButton"
        Me.TestDBButton.Size = New System.Drawing.Size(75, 37)
        Me.TestDBButton.TabIndex = 15
        Me.TestDBButton.Text = "Test"
        Me.TestDBButton.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(8, 30)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 13)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Server Name:"
        '
        'ServerTextBox
        '
        'Me.ServerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", My.Settings, "DB_server", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ServerTextBox.Location = New System.Drawing.Point(86, 27)
        Me.ServerTextBox.Name = "ServerTextBox"
        Me.ServerTextBox.Size = New System.Drawing.Size(138, 20)
        Me.ServerTextBox.TabIndex = 11
        'Me.ServerTextBox.Text = My.Settings.DB_server
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(24, 120)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 13)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Password:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(2, 89)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Username:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(24, 58)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "DB Name:"
        '
        'DBTextBox
        '
        Me.DBTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", My.Settings, "DB", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DBTextBox.Location = New System.Drawing.Point(86, 55)
        Me.DBTextBox.Name = "DBTextBox"
        Me.DBTextBox.Size = New System.Drawing.Size(138, 20)
        Me.DBTextBox.TabIndex = 12
        Me.DBTextBox.Text = My.Settings.DB
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", My.Settings, "Password", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.PasswordTextBox.Location = New System.Drawing.Point(86, 117)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(138, 20)
        Me.PasswordTextBox.TabIndex = 14
        Me.PasswordTextBox.Text = My.Settings.Password
        '
        'DbUserNameTextBox
        '
        Me.DbUserNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", My.Settings, "UserID", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DbUserNameTextBox.Location = New System.Drawing.Point(86, 86)
        Me.DbUserNameTextBox.Name = "DbUserNameTextBox"
        Me.DbUserNameTextBox.Size = New System.Drawing.Size(138, 20)
        Me.DbUserNameTextBox.TabIndex = 13
        Me.DbUserNameTextBox.Text = My.Settings.UserID
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TestTachButton)
        Me.GroupBox2.Controls.Add(Me.TachSerialComboBox)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 175)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(252, 145)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tachometer"
        '
        'TestTachButton
        '
        Me.TestTachButton.Location = New System.Drawing.Point(113, 89)
        Me.TestTachButton.Name = "TestTachButton"
        Me.TestTachButton.Size = New System.Drawing.Size(100, 33)
        Me.TestTachButton.TabIndex = 10
        Me.TestTachButton.Text = "Test"
        Me.TestTachButton.UseVisualStyleBackColor = True
        '
        'TachSerialComboBox
        '
        Me.TachSerialComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", My.Settings, "TachCommPort", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TachSerialComboBox.FormattingEnabled = True
        Me.TachSerialComboBox.Location = New System.Drawing.Point(92, 55)
        Me.TachSerialComboBox.Name = "TachSerialComboBox"
        Me.TachSerialComboBox.Size = New System.Drawing.Size(121, 21)
        Me.TachSerialComboBox.TabIndex = 9
        Me.TachSerialComboBox.Text = My.Settings.TachCommPort
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Serial Port:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.AccessCodeTextBox)
        Me.GroupBox1.Controls.Add(Me.InstBaudComboBox)
        Me.GroupBox1.Controls.Add(Me.InstCommComboBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TestButton)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(252, 163)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Instrument Communications"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Access Code:"
        '
        'AccessCodeTextBox
        '
        Me.AccessCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", My.Settings, "InstrumentAccessCode", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.AccessCodeTextBox.Location = New System.Drawing.Point(92, 96)
        Me.AccessCodeTextBox.Name = "AccessCodeTextBox"
        Me.AccessCodeTextBox.Size = New System.Drawing.Size(121, 20)
        Me.AccessCodeTextBox.TabIndex = 3
        Me.AccessCodeTextBox.Text = My.Settings.InstrumentAccessCode
        '
        'InstBaudComboBox
        '
        Me.InstBaudComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", My.Settings, "InstrumentBaudRate", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.InstBaudComboBox.FormattingEnabled = True
        Me.InstBaudComboBox.Location = New System.Drawing.Point(92, 60)
        Me.InstBaudComboBox.Name = "InstBaudComboBox"
        Me.InstBaudComboBox.Size = New System.Drawing.Size(121, 21)
        Me.InstBaudComboBox.TabIndex = 2
        Me.InstBaudComboBox.Text = My.Settings.InstrumentBaudRate
        '
        'InstCommComboBox
        '
        Me.InstCommComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", My.Settings, "InstrumentCommPort", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.InstCommComboBox.FormattingEnabled = True
        Me.InstCommComboBox.Location = New System.Drawing.Point(92, 24)
        Me.InstCommComboBox.Name = "InstCommComboBox"
        Me.InstCommComboBox.Size = New System.Drawing.Size(121, 21)
        Me.InstCommComboBox.TabIndex = 1
        Me.InstCommComboBox.Text = My.Settings.InstrumentCommPort
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Baud Rate:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Serial Port:"
        '
        'TestButton
        '
        Me.TestButton.Location = New System.Drawing.Point(113, 122)
        Me.TestButton.Name = "TestButton"
        Me.TestButton.Size = New System.Drawing.Size(100, 35)
        Me.TestButton.TabIndex = 4
        Me.TestButton.Text = "Test Comm"
        Me.TestButton.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox6)
        Me.TabPage3.Controls.Add(Me.GroupBox5)
        Me.TabPage3.Controls.Add(Me.GroupBox4)
        Me.TabPage3.Controls.Add(Me.GroupBox3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(602, 342)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Test"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label19)
        Me.GroupBox6.Controls.Add(Me.MechMetricExcelTextBox)
        Me.GroupBox6.Controls.Add(Me.Label20)
        Me.GroupBox6.Controls.Add(Me.MechExcelTextBox)
        Me.GroupBox6.Controls.Add(Me.Label18)
        Me.GroupBox6.Controls.Add(Me.RotaryMetricExcelTextBox)
        Me.GroupBox6.Controls.Add(Me.Label17)
        Me.GroupBox6.Controls.Add(Me.RotaryEnglishExcelTextBox)
        Me.GroupBox6.Location = New System.Drawing.Point(9, 6)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(582, 78)
        Me.GroupBox6.TabIndex = 4
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Report"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(275, 55)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(39, 13)
        Me.Label19.TabIndex = 9
        Me.Label19.Text = "Metric:"
        '
        'MechMetricExcelTextBox
        '
        Me.MechMetricExcelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", My.Settings, "MechMetricExcel", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.MechMetricExcelTextBox.Location = New System.Drawing.Point(329, 52)
        Me.MechMetricExcelTextBox.Name = "MechMetricExcelTextBox"
        Me.MechMetricExcelTextBox.Size = New System.Drawing.Size(232, 20)
        Me.MechMetricExcelTextBox.TabIndex = 8
        Me.MechMetricExcelTextBox.Text = My.Settings.MechMetricExcel
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 55)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(40, 13)
        Me.Label20.TabIndex = 7
        Me.Label20.Text = "Mech.:"
        '
        'MechExcelTextBox
        '
        Me.MechExcelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", My.Settings, "MechExcel", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.MechExcelTextBox.Location = New System.Drawing.Point(50, 52)
        Me.MechExcelTextBox.Name = "MechExcelTextBox"
        Me.MechExcelTextBox.Size = New System.Drawing.Size(212, 20)
        Me.MechExcelTextBox.TabIndex = 6
        Me.MechExcelTextBox.Text = My.Settings.MechExcel
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(275, 20)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(39, 13)
        Me.Label18.TabIndex = 5
        Me.Label18.Text = "Metric:"
        '
        'RotaryMetricExcelTextBox
        '
        Me.RotaryMetricExcelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", My.Settings, "RotaryMetricExcel", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.RotaryMetricExcelTextBox.Location = New System.Drawing.Point(329, 17)
        Me.RotaryMetricExcelTextBox.Name = "RotaryMetricExcelTextBox"
        Me.RotaryMetricExcelTextBox.Size = New System.Drawing.Size(232, 20)
        Me.RotaryMetricExcelTextBox.TabIndex = 4
        Me.RotaryMetricExcelTextBox.Text = My.Settings.RotaryMetricExcel
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 20)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(41, 13)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "Rotary:"
        '
        'RotaryEnglishExcelTextBox
        '
        Me.RotaryEnglishExcelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", My.Settings, "ExcelLocation", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.RotaryEnglishExcelTextBox.Location = New System.Drawing.Point(50, 17)
        Me.RotaryEnglishExcelTextBox.Name = "RotaryEnglishExcelTextBox"
        Me.RotaryEnglishExcelTextBox.Size = New System.Drawing.Size(212, 20)
        Me.RotaryEnglishExcelTextBox.TabIndex = 1
        Me.RotaryEnglishExcelTextBox.Text = My.Settings.ExcelLocation
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.UncOnlyTestCheckBox)
        Me.GroupBox5.Location = New System.Drawing.Point(390, 90)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(201, 248)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Volume"
        '
        'UncOnlyTestCheckBox
        '
        Me.UncOnlyTestCheckBox.AutoSize = True
        Me.UncOnlyTestCheckBox.Checked = My.Settings.UncVolumeOnly
        Me.UncOnlyTestCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", My.Settings, "UncVolumeOnly", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.UncOnlyTestCheckBox.Location = New System.Drawing.Point(35, 39)
        Me.UncOnlyTestCheckBox.Name = "UncOnlyTestCheckBox"
        Me.UncOnlyTestCheckBox.Size = New System.Drawing.Size(135, 17)
        Me.UncOnlyTestCheckBox.TabIndex = 0
        Me.UncOnlyTestCheckBox.Text = "Only Test Unc. Volume"
        Me.UncOnlyTestCheckBox.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.ManualPressureCheckBox)
        Me.GroupBox4.Controls.Add(Me.PressureLimitTextBox)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.PressurePercentErrorTextBox)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Location = New System.Drawing.Point(9, 213)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(375, 125)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Pressure"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Enabled = False
        Me.Label14.Location = New System.Drawing.Point(6, 96)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(148, 13)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "Input pressure items manually:"
        '
        'ManualPressureCheckBox
        '
        Me.ManualPressureCheckBox.AutoSize = True
        Me.ManualPressureCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ManualPressureCheckBox.Checked = My.Settings.ManualPressure
        Me.ManualPressureCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ManualPressureCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", My.Settings, "ManualPressure", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ManualPressureCheckBox.Enabled = False
        Me.ManualPressureCheckBox.Location = New System.Drawing.Point(313, 96)
        Me.ManualPressureCheckBox.Name = "ManualPressureCheckBox"
        Me.ManualPressureCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.ManualPressureCheckBox.TabIndex = 4
        Me.ManualPressureCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ManualPressureCheckBox.UseVisualStyleBackColor = True
        '
        'PressureLimitTextBox
        '
        Me.PressureLimitTextBox.Enabled = False
        Me.PressureLimitTextBox.Location = New System.Drawing.Point(313, 56)
        Me.PressureLimitTextBox.Name = "PressureLimitTextBox"
        Me.PressureLimitTextBox.Size = New System.Drawing.Size(56, 20)
        Me.PressureLimitTextBox.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.Enabled = False
        Me.Label9.Location = New System.Drawing.Point(6, 55)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(287, 20)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Test Limit (Instrument pressure must be lower then this limit)"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PressurePercentErrorTextBox
        '
        Me.PressurePercentErrorTextBox.Location = New System.Drawing.Point(313, 19)
        Me.PressurePercentErrorTextBox.Name = "PressurePercentErrorTextBox"
        Me.PressurePercentErrorTextBox.Size = New System.Drawing.Size(56, 20)
        Me.PressurePercentErrorTextBox.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(6, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(287, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Percent Error Threshold:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.ManualTempCheckBox)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.TempLimitTextBox)
        Me.GroupBox3.Controls.Add(Me.TempPercentErrorTextBox)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 90)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(375, 118)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Temperature"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Enabled = False
        Me.Label15.Location = New System.Drawing.Point(6, 97)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(164, 13)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "Input temperature items manually:"
        '
        'ManualTempCheckBox
        '
        Me.ManualTempCheckBox.AutoSize = True
        Me.ManualTempCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ManualTempCheckBox.Checked = My.Settings.ManualTemp
        Me.ManualTempCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ManualTempCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", My.Settings, "ManualTemp", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ManualTempCheckBox.Enabled = False
        Me.ManualTempCheckBox.Location = New System.Drawing.Point(313, 97)
        Me.ManualTempCheckBox.Name = "ManualTempCheckBox"
        Me.ManualTempCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.ManualTempCheckBox.TabIndex = 6
        Me.ManualTempCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ManualTempCheckBox.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Enabled = False
        Me.Label8.Location = New System.Drawing.Point(6, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(300, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Test Limit (Instrument temperature must be lower then this limit)"
        '
        'TempLimitTextBox
        '
        Me.TempLimitTextBox.Enabled = False
        Me.TempLimitTextBox.Location = New System.Drawing.Point(313, 59)
        Me.TempLimitTextBox.Name = "TempLimitTextBox"
        Me.TempLimitTextBox.Size = New System.Drawing.Size(56, 20)
        Me.TempLimitTextBox.TabIndex = 2
        '
        'TempPercentErrorTextBox
        '
        Me.TempPercentErrorTextBox.Location = New System.Drawing.Point(313, 23)
        Me.TempPercentErrorTextBox.Name = "TempPercentErrorTextBox"
        Me.TempPercentErrorTextBox.Size = New System.Drawing.Size(56, 20)
        Me.TempPercentErrorTextBox.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(6, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(301, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Percent Error Threshold (+/- limit that creates an error)"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CustomeritemsBindingSource
        '
        Me.CustomeritemsBindingSource.DataMember = "customer_items"
        Me.CustomeritemsBindingSource.DataSource = Me.CustomerItemsDataSetBindingSource
        '
        'CustomerItemsDataSetBindingSource
        '
        Me.CustomerItemsDataSetBindingSource.DataSource = Me.CustomerItemsDataSet
        Me.CustomerItemsDataSetBindingSource.Position = 0
        '
        'StartButton
        '
        Me.StartButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StartButton.Location = New System.Drawing.Point(600, 407)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(137, 35)
        Me.StartButton.TabIndex = 2
        Me.StartButton.Text = "&Start"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(749, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintInspectionCertificateToolStripMenuItem, Me.RestartIrDAServiceToolStripMenuItem, Me.SetInstrumentDateAndTimeToolStripMenuItem, Me.RawItemAccessToolStripMenuItem, Me.EditRotaryMeterTypesToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'PrintInspectionCertificateToolStripMenuItem
        '
        Me.PrintInspectionCertificateToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem, Me.PrintToolStripMenuItem})
        Me.PrintInspectionCertificateToolStripMenuItem.Name = "PrintInspectionCertificateToolStripMenuItem"
        Me.PrintInspectionCertificateToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.PrintInspectionCertificateToolStripMenuItem.Text = "Inspection Certificates"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'RestartIrDAServiceToolStripMenuItem
        '
        Me.RestartIrDAServiceToolStripMenuItem.Name = "RestartIrDAServiceToolStripMenuItem"
        Me.RestartIrDAServiceToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.RestartIrDAServiceToolStripMenuItem.Text = "Restart IrDA Service"
        '
        'SetInstrumentDateAndTimeToolStripMenuItem
        '
        Me.SetInstrumentDateAndTimeToolStripMenuItem.Name = "SetInstrumentDateAndTimeToolStripMenuItem"
        Me.SetInstrumentDateAndTimeToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.SetInstrumentDateAndTimeToolStripMenuItem.Text = "Set Instrument Date and Time"
        '
        'RawItemAccessToolStripMenuItem
        '
        Me.RawItemAccessToolStripMenuItem.Name = "RawItemAccessToolStripMenuItem"
        Me.RawItemAccessToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.RawItemAccessToolStripMenuItem.Text = "Raw Item Access"
        '
        'EditRotaryMeterTypesToolStripMenuItem
        '
        Me.EditRotaryMeterTypesToolStripMenuItem.Name = "EditRotaryMeterTypesToolStripMenuItem"
        Me.EditRotaryMeterTypesToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.EditRotaryMeterTypesToolStripMenuItem.Text = "Edit Rotary Meter Types"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.DataAcqWiringDiagramsToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'DataAcqWiringDiagramsToolStripMenuItem
        '
        Me.DataAcqWiringDiagramsToolStripMenuItem.Name = "DataAcqWiringDiagramsToolStripMenuItem"
        Me.DataAcqWiringDiagramsToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.DataAcqWiringDiagramsToolStripMenuItem.Text = "Data Acq. Wiring Diagrams"
        '
        'Customer_itemsTableAdapter
        '
        Me.Customer_itemsTableAdapter.ClearBeforeFill = True
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Excel|*.xls"
        '
        'NewTestForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 454)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "NewTestForm"
        Me.Text = "C.R. Wall & Co. Inc."
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.RotaryTabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerItemsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.CustomeritemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerItemsDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.BoardTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents InstrumentsListView As System.Windows.Forms.ListView
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents RotaryTabControl As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents StartButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CustomerComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents AccessCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents InstBaudComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents InstCommComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TestButton As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TachSerialComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintInspectionCertificateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TempPercentErrorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents PressurePercentErrorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PressureLimitTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TempLimitTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents UncOnlyTestCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DBTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DbUserNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ServerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TestDBButton As System.Windows.Forms.Button
    Friend WithEvents ManualPressureCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ManualTempCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CustomeritemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomerItemsDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomerItemsDataSet As DAM_Prover.CustomerItemsDataSet
    Friend WithEvents Customer_itemsTableAdapter As DAM_Prover.CustomerItemsDataSetTableAdapters.customer_itemsTableAdapter
    Friend WithEvents CustomersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomersTableAdapter As DAM_Prover.CustomerItemsDataSetTableAdapters.customersTableAdapter
    Friend WithEvents TestTachButton As System.Windows.Forms.Button
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents DABoardComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BoardTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StopMotorButton As System.Windows.Forms.Button
    Friend WithEvents StartMotorButton As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RotaryEnglishExcelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestartIrDAServiceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetDateTimeCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SetInstrumentDateAndTimeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RawItemAccessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddCustomerButton As System.Windows.Forms.Button
    Friend WithEvents EditRotaryMeterTypesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents RotaryMetricExcelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents MechMetricExcelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents MechExcelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents DataAcqWiringDiagramsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
