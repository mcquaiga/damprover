Public Class MainViewModel



    Private _goToMainMenu As Microsoft.Practices.Prism.Commands.DelegateCommand(Of Object)
    Public ReadOnly Property GoToMainMenuCommand As ICommand
        Get
            Return _goToMainMenu
        End Get
    End Property
    Private Sub GoToMainMenu(ByVal o As Object)
        '_nav.GoToStart()
    End Sub
End Class
