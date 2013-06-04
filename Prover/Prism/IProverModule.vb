Imports Microsoft.Practices.Prism
Imports System.Windows.Input

Public Interface IProverModule
    Property Title As String
    Property Icon As String
    Property ToolTipText As String
    Property StartCommand As ICommand
End Interface
