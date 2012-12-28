Public Class LoginForm

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click



        If UsernameTextBox.Text.ToLower = "crwall" Then
            If PasswordTextBox.Text = "22222" Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            Else
                MessageBox.Show("The username and password pair is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                PasswordTextBox.Focus()
                PasswordTextBox.SelectAll()
            End If
        Else
            MessageBox.Show("The username and password pair is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            UsernameTextBox.Focus()
            UsernameTextBox.SelectAll()
        End If
        ' The user is still not validated.

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
