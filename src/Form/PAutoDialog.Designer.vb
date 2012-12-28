<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PAutoDialog
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.InstrPressureTextBox = New System.Windows.Forms.TextBox
        Me.ATMLabel = New System.Windows.Forms.Label
        Me.ATMTextBox = New System.Windows.Forms.TextBox
        Me.GaugePressureTextBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.PressureUnitsLabel = New System.Windows.Forms.Label
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(178, 160)
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
        Me.OK_Button.TabIndex = 1
        Me.OK_Button.Text = "OK"
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
        Me.GroupBox1.Size = New System.Drawing.Size(309, 129)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pressure"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Instrument Pressure:"
        '
        'InstrPressureTextBox
        '
        Me.InstrPressureTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.InstrPressureTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.InstrPressureTextBox.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.InstrPressureTextBox.Location = New System.Drawing.Point(138, 24)
        Me.InstrPressureTextBox.Name = "InstrPressureTextBox"
        Me.InstrPressureTextBox.ReadOnly = True
        Me.InstrPressureTextBox.Size = New System.Drawing.Size(100, 26)
        Me.InstrPressureTextBox.TabIndex = 7
        Me.InstrPressureTextBox.TabStop = False
        Me.InstrPressureTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ATMLabel
        '
        Me.ATMLabel.AutoSize = True
        Me.ATMLabel.Location = New System.Drawing.Point(37, 96)
        Me.ATMLabel.Name = "ATMLabel"
        Me.ATMLabel.Size = New System.Drawing.Size(68, 13)
        Me.ATMLabel.TabIndex = 4
        Me.ATMLabel.Text = "Atmospheric:"
        '
        'ATMTextBox
        '
        Me.ATMTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ATMTextBox.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.ATMTextBox.Location = New System.Drawing.Point(138, 88)
        Me.ATMTextBox.Name = "ATMTextBox"
        Me.ATMTextBox.Size = New System.Drawing.Size(100, 26)
        Me.ATMTextBox.TabIndex = 2
        Me.ATMTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GaugePressureTextBox
        '
        Me.GaugePressureTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GaugePressureTextBox.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GaugePressureTextBox.Location = New System.Drawing.Point(138, 56)
        Me.GaugePressureTextBox.Name = "GaugePressureTextBox"
        Me.GaugePressureTextBox.Size = New System.Drawing.Size(100, 26)
        Me.GaugePressureTextBox.TabIndex = 1
        Me.GaugePressureTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Gauge:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 163)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(67, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Live Read"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PressureUnitsLabel
        '
        Me.PressureUnitsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PressureUnitsLabel.Location = New System.Drawing.Point(244, 28)
        Me.PressureUnitsLabel.Name = "PressureUnitsLabel"
        Me.PressureUnitsLabel.Size = New System.Drawing.Size(59, 23)
        Me.PressureUnitsLabel.TabIndex = 9
        '
        'PAutoDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 201)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PAutoDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "PAutoDialog"
        Me.TopMost = True
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ATMLabel As System.Windows.Forms.Label
    Friend WithEvents ATMTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GaugePressureTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents InstrPressureTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PressureUnitsLabel As System.Windows.Forms.Label

End Class
