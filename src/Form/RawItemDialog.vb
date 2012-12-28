Imports System.Windows.Forms

Public Class RawItemDialog

    Public WithEvents instrument As miSerialProtocol.miSerialProtocolClass


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Try
            CurrentStatus.Text = ""
            Application.DoEvents()
            ItemValueTextBox.Text = instrument.RD(ItemNumberTextBox.Text)
            CurrentStatus.Text = "Success"
        Catch ex As Exception
            CurrentStatus.Text = ex.Message
        End Try

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Try
            CurrentStatus.Text = ""
            Application.DoEvents()
            Dim instrErr As miSerialProtocol.InstrumentErrorsEnum
            instrErr = instrument.WD(ItemNumberTextBox.Text, ItemValueTextBox.Text)
            If instrErr <> miSerialProtocol.InstrumentErrorsEnum.NoError Then
                CurrentStatus.Text = instrErr.ToString
            Else
                CurrentStatus.Text = "Success"
            End If
        Catch ex As Exception
            CurrentStatus.Text = ex.Message
        End Try
    End Sub

    Private Sub RawItemDialog_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        CurrentStatus.Text = "Closing..."
        Application.DoEvents()
        instrument.Disconnect()
        instrument.Dispose()

    End Sub

    Private Sub RawItemDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler instrument.CommStateChanged, AddressOf StatusChanged

    End Sub

    Private Sub StatusChanged(ByVal CommState As miSerialProtocol.CommStateEnum)
        CurrentCommStatus.Text = CommState.ToString
    End Sub
End Class
