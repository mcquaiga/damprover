Imports System.Windows.Forms

Public Class MechanicalInputDialog

    Public PulseACount As Integer
    Public PulseBCount As Integer
    Public AppliedInput As Integer
    Public MechReading As Integer


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Try
            PulseACount = PulseACountTextBox.Text
            PulseBCount = PulseBCountTextBox.Text
            AppliedInput = AppliedInputTextBox.Text

            MechReading = MechEndTextBox.Text - MechStartTextBox.Text

            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Hide()
        Catch ex As InvalidCastException
            MessageBox.Show("Please enter only numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub MechanicalInputDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
