<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PTAutoDialog
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.PressureUnitsLabel = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.InstrPressureTextBox = New System.Windows.Forms.TextBox
        Me.ATMLabel = New System.Windows.Forms.Label
        Me.ATMTextBox = New System.Windows.Forms.TextBox
        Me.GaugePressureTextBox = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TempUnitsLabel = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.InstrTempTextBox = New System.Windows.Forms.TextBox
        Me.GaugeTempTextBox = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.TableLayoutPanel1.SuspendLayout()
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
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(178, 235)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(76, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 4
        Me.OK_Button.Text = "OK"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(87, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Gauge:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PressureUnitsLabel)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.InstrPressureTextBox)
        Me.GroupBox1.Controls.Add(Me.ATMLabel)
        Me.GroupBox1.Controls.Add(Me.ATMTextBox)
        Me.GroupBox1.Controls.Add(Me.GaugePressureTextBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(309, 117)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pressure"
        '
        'PressureUnitsLabel
        '
        Me.PressureUnitsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PressureUnitsLabel.Location = New System.Drawing.Point(254, 22)
        Me.PressureUnitsLabel.Name = "PressureUnitsLabel"
        Me.PressureUnitsLabel.Size = New System.Drawing.Size(49, 19)
        Me.PressureUnitsLabel.TabIndex = 7
        Me.PressureUnitsLabel.Text = " "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Instrument Pressure:"
        '
        'InstrPressureTextBox
        '
        Me.InstrPressureTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.InstrPressureTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.InstrPressureTextBox.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.InstrPressureTextBox.Location = New System.Drawing.Point(146, 19)
        Me.InstrPressureTextBox.Name = "InstrPressureTextBox"
        Me.InstrPressureTextBox.ReadOnly = True
        Me.InstrPressureTextBox.Size = New System.Drawing.Size(100, 26)
        Me.InstrPressureTextBox.TabIndex = 5
        Me.InstrPressureTextBox.TabStop = False
        Me.InstrPressureTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ATMLabel
        '
        Me.ATMLabel.AutoSize = True
        Me.ATMLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ATMLabel.Location = New System.Drawing.Point(54, 83)
        Me.ATMLabel.Name = "ATMLabel"
        Me.ATMLabel.Size = New System.Drawing.Size(86, 16)
        Me.ATMLabel.TabIndex = 4
        Me.ATMLabel.Text = "Atmospheric:"
        '
        'ATMTextBox
        '
        Me.ATMTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ATMTextBox.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.ATMTextBox.Location = New System.Drawing.Point(146, 83)
        Me.ATMTextBox.Name = "ATMTextBox"
        Me.ATMTextBox.Size = New System.Drawing.Size(100, 26)
        Me.ATMTextBox.TabIndex = 2
        Me.ATMTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GaugePressureTextBox
        '
        Me.GaugePressureTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GaugePressureTextBox.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GaugePressureTextBox.Location = New System.Drawing.Point(146, 51)
        Me.GaugePressureTextBox.Name = "GaugePressureTextBox"
        Me.GaugePressureTextBox.Size = New System.Drawing.Size(100, 26)
        Me.GaugePressureTextBox.TabIndex = 1
        Me.GaugePressureTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TempUnitsLabel)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.InstrTempTextBox)
        Me.GroupBox2.Controls.Add(Me.GaugeTempTextBox)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 135)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(309, 94)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Temperature"
        '
        'TempUnitsLabel
        '
        Me.TempUnitsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TempUnitsLabel.Location = New System.Drawing.Point(254, 25)
        Me.TempUnitsLabel.Name = "TempUnitsLabel"
        Me.TempUnitsLabel.Size = New System.Drawing.Size(49, 16)
        Me.TempUnitsLabel.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Instrument Temp.:"
        '
        'InstrTempTextBox
        '
        Me.InstrTempTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.InstrTempTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.InstrTempTextBox.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.InstrTempTextBox.Location = New System.Drawing.Point(146, 19)
        Me.InstrTempTextBox.Name = "InstrTempTextBox"
        Me.InstrTempTextBox.ReadOnly = True
        Me.InstrTempTextBox.Size = New System.Drawing.Size(100, 26)
        Me.InstrTempTextBox.TabIndex = 2
        Me.InstrTempTextBox.TabStop = False
        Me.InstrTempTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GaugeTempTextBox
        '
        Me.GaugeTempTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GaugeTempTextBox.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GaugeTempTextBox.Location = New System.Drawing.Point(146, 56)
        Me.GaugeTempTextBox.Name = "GaugeTempTextBox"
        Me.GaugeTempTextBox.Size = New System.Drawing.Size(100, 26)
        Me.GaugeTempTextBox.TabIndex = 1
        Me.GaugeTempTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(88, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Gauge:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 241)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(67, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Live Read"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PTAutoDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 276)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PTAutoDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.TopMost = True
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ATMLabel As System.Windows.Forms.Label
    Friend WithEvents ATMTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GaugePressureTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GaugeTempTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents InstrPressureTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents InstrTempTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PressureUnitsLabel As System.Windows.Forms.Label
    Friend WithEvents TempUnitsLabel As System.Windows.Forms.Label

End Class
