Imports Microsoft.Practices.Prism
Imports System.Windows.Input

Public Class ProverModule
    Implements IProverModule

    Sub New(ModuleTitle As String, ModuleIcon As String, ModuleToolTipText As String, ModuleStartCommand As Commands.DelegateCommand(Of Object))
        Icon = ModuleIcon
        Title = ModuleTitle
        ToolTipText = ModuleToolTipText
        StartCommand = ModuleStartCommand
    End Sub

    Public Property Icon As String Implements IProverModule.Icon

    Public Property Title As String Implements IProverModule.Title

    Public Property ToolTipText As String Implements IProverModule.ToolTipText

    Public Property StartCommand As ICommand Implements IProverModule.StartCommand


End Class
