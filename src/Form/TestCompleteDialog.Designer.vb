<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestCompleteDialog
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.UnCorPercErrorLabel = New System.Windows.Forms.Label
        Me.CorPercErrorLabel = New System.Windows.Forms.Label
        Me.ConfirmedStatusLabel = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.YaPulsesPassLabel = New System.Windows.Forms.Label
        Me.YbPulsesPassLabel = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.ViewButton = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.RetryButton = New System.Windows.Forms.Button
        Me.MechLabel = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.TableLayoutPanel1.SuspendLayout()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(265, 321)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "&Yes"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.No
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "&No"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "UnCorrected Percent Error:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(49, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(215, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Corrected Percent Error:"
        '
        'UnCorPercErrorLabel
        '
        Me.UnCorPercErrorLabel.AutoSize = True
        Me.UnCorPercErrorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnCorPercErrorLabel.Location = New System.Drawing.Point(288, 150)
        Me.UnCorPercErrorLabel.Name = "UnCorPercErrorLabel"
        Me.UnCorPercErrorLabel.Size = New System.Drawing.Size(85, 24)
        Me.UnCorPercErrorLabel.TabIndex = 3
        Me.UnCorPercErrorLabel.Text = "0.0000 %"
        '
        'CorPercErrorLabel
        '
        Me.CorPercErrorLabel.AutoSize = True
        Me.CorPercErrorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CorPercErrorLabel.Location = New System.Drawing.Point(288, 187)
        Me.CorPercErrorLabel.Name = "CorPercErrorLabel"
        Me.CorPercErrorLabel.Size = New System.Drawing.Size(85, 24)
        Me.CorPercErrorLabel.TabIndex = 4
        Me.CorPercErrorLabel.Text = "0.0000 %"
        '
        'ConfirmedStatusLabel
        '
        Me.ConfirmedStatusLabel.AutoSize = True
        Me.ConfirmedStatusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfirmedStatusLabel.ForeColor = System.Drawing.Color.DarkGreen
        Me.ConfirmedStatusLabel.Location = New System.Drawing.Point(288, 228)
        Me.ConfirmedStatusLabel.Name = "ConfirmedStatusLabel"
        Me.ConfirmedStatusLabel.Size = New System.Drawing.Size(63, 24)
        Me.ConfirmedStatusLabel.TabIndex = 5
        Me.ConfirmedStatusLabel.Text = "PASS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(97, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Ya Pulses Verified:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(96, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 24)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Yb Pulses Verified:"
        '
        'YaPulsesPassLabel
        '
        Me.YaPulsesPassLabel.AutoSize = True
        Me.YaPulsesPassLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YaPulsesPassLabel.ForeColor = System.Drawing.Color.DarkGreen
        Me.YaPulsesPassLabel.Location = New System.Drawing.Point(288, 42)
        Me.YaPulsesPassLabel.Name = "YaPulsesPassLabel"
        Me.YaPulsesPassLabel.Size = New System.Drawing.Size(63, 24)
        Me.YaPulsesPassLabel.TabIndex = 8
        Me.YaPulsesPassLabel.Text = "PASS"
        '
        'YbPulsesPassLabel
        '
        Me.YbPulsesPassLabel.AutoSize = True
        Me.YbPulsesPassLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YbPulsesPassLabel.ForeColor = System.Drawing.Color.Red
        Me.YbPulsesPassLabel.Location = New System.Drawing.Point(288, 74)
        Me.YbPulsesPassLabel.Name = "YbPulsesPassLabel"
        Me.YbPulsesPassLabel.Size = New System.Drawing.Size(53, 24)
        Me.YbPulsesPassLabel.TabIndex = 9
        Me.YbPulsesPassLabel.Text = "FAIL"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(107, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(157, 24)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Confirmed Status:"
        '
        'ViewButton
        '
        Me.ViewButton.Location = New System.Drawing.Point(13, 324)
        Me.ViewButton.Name = "ViewButton"
        Me.ViewButton.Size = New System.Drawing.Size(75, 23)
        Me.ViewButton.TabIndex = 11
        Me.ViewButton.Text = "View Report"
        Me.ViewButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(78, 268)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(280, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Would you like to save the instrument?"
        '
        'RetryButton
        '
        Me.RetryButton.DialogResult = System.Windows.Forms.DialogResult.Retry
        Me.RetryButton.Location = New System.Drawing.Point(13, 12)
        Me.RetryButton.Name = "RetryButton"
        Me.RetryButton.Size = New System.Drawing.Size(75, 23)
        Me.RetryButton.TabIndex = 13
        Me.RetryButton.Text = "Retest"
        Me.RetryButton.UseVisualStyleBackColor = True
        '
        'MechLabel
        '
        Me.MechLabel.AutoSize = True
        Me.MechLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MechLabel.ForeColor = System.Drawing.Color.Red
        Me.MechLabel.Location = New System.Drawing.Point(288, 109)
        Me.MechLabel.Name = "MechLabel"
        Me.MechLabel.Size = New System.Drawing.Size(53, 24)
        Me.MechLabel.TabIndex = 15
        Me.MechLabel.Text = "FAIL"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(81, 109)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(183, 24)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Mechanical Volume:"
        '
        'TestCompleteDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(423, 368)
        Me.Controls.Add(Me.MechLabel)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.RetryButton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ViewButton)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.YbPulsesPassLabel)
        Me.Controls.Add(Me.YaPulsesPassLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ConfirmedStatusLabel)
        Me.Controls.Add(Me.CorPercErrorLabel)
        Me.Controls.Add(Me.UnCorPercErrorLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TestCompleteDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Test Complete"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents UnCorPercErrorLabel As System.Windows.Forms.Label
    Friend WithEvents CorPercErrorLabel As System.Windows.Forms.Label
    Friend WithEvents ConfirmedStatusLabel As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents YaPulsesPassLabel As System.Windows.Forms.Label
    Friend WithEvents YbPulsesPassLabel As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ViewButton As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents RetryButton As System.Windows.Forms.Button
    Friend WithEvents MechLabel As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label

End Class
