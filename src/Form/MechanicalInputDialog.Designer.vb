<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MechanicalInputDialog
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
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.PulseALabel = New System.Windows.Forms.Label
        Me.PulseBLabel = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.PulseACountTextBox = New System.Windows.Forms.TextBox
        Me.PulseBCountTextBox = New System.Windows.Forms.TextBox
        Me.AppliedInputTextBox = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.MechEndTextBox = New System.Windows.Forms.TextBox
        Me.MechStartTextBox = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
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
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(197, 322)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 5
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
        'PulseALabel
        '
        Me.PulseALabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.PulseALabel.Location = New System.Drawing.Point(13, 98)
        Me.PulseALabel.Name = "PulseALabel"
        Me.PulseALabel.Size = New System.Drawing.Size(141, 20)
        Me.PulseALabel.TabIndex = 1
        Me.PulseALabel.Text = "Pulse A:"
        Me.PulseALabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PulseBLabel
        '
        Me.PulseBLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.PulseBLabel.Location = New System.Drawing.Point(13, 142)
        Me.PulseBLabel.Name = "PulseBLabel"
        Me.PulseBLabel.Size = New System.Drawing.Size(141, 20)
        Me.PulseBLabel.TabIndex = 2
        Me.PulseBLabel.Text = "Pulse B:"
        Me.PulseBLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(47, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Applied Input:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PulseACountTextBox
        '
        Me.PulseACountTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.PulseACountTextBox.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.PulseACountTextBox.Location = New System.Drawing.Point(160, 95)
        Me.PulseACountTextBox.Name = "PulseACountTextBox"
        Me.PulseACountTextBox.Size = New System.Drawing.Size(106, 26)
        Me.PulseACountTextBox.TabIndex = 1
        Me.PulseACountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PulseBCountTextBox
        '
        Me.PulseBCountTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.PulseBCountTextBox.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.PulseBCountTextBox.Location = New System.Drawing.Point(160, 139)
        Me.PulseBCountTextBox.Name = "PulseBCountTextBox"
        Me.PulseBCountTextBox.Size = New System.Drawing.Size(106, 26)
        Me.PulseBCountTextBox.TabIndex = 2
        Me.PulseBCountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AppliedInputTextBox
        '
        Me.AppliedInputTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.AppliedInputTextBox.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.AppliedInputTextBox.Location = New System.Drawing.Point(160, 187)
        Me.AppliedInputTextBox.Name = "AppliedInputTextBox"
        Me.AppliedInputTextBox.Size = New System.Drawing.Size(106, 26)
        Me.AppliedInputTextBox.TabIndex = 4
        Me.AppliedInputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label4.Location = New System.Drawing.Point(109, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Start test now. "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(29, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(298, 34)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "When finished enter the pulse " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "count, mechanical readings and applied input." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MechEndTextBox
        '
        Me.MechEndTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.MechEndTextBox.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.MechEndTextBox.Location = New System.Drawing.Point(226, 27)
        Me.MechEndTextBox.Name = "MechEndTextBox"
        Me.MechEndTextBox.Size = New System.Drawing.Size(89, 26)
        Me.MechEndTextBox.TabIndex = 2
        Me.MechEndTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MechStartTextBox
        '
        Me.MechStartTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.MechStartTextBox.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.MechStartTextBox.Location = New System.Drawing.Point(64, 27)
        Me.MechStartTextBox.Name = "MechStartTextBox"
        Me.MechStartTextBox.Size = New System.Drawing.Size(89, 26)
        Me.MechStartTextBox.TabIndex = 1
        Me.MechStartTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(168, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "End:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(7, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Start:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.MechEndTextBox)
        Me.GroupBox1.Controls.Add(Me.MechStartTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 231)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(331, 64)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mechanical Readings"
        '
        'MechanicalInputDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(355, 363)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.AppliedInputTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PulseBCountTextBox)
        Me.Controls.Add(Me.PulseACountTextBox)
        Me.Controls.Add(Me.PulseBLabel)
        Me.Controls.Add(Me.PulseALabel)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MechanicalInputDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Mechanical Input"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents PulseALabel As System.Windows.Forms.Label
    Friend WithEvents PulseBLabel As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PulseACountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PulseBCountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AppliedInputTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MechEndTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MechStartTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox

End Class
