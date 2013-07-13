Imports Microsoft.Practices.Prism
Imports System.Windows.Input

Public Interface IProverModule
    ReadOnly Property Title As String
    ReadOnly Property Icon As String
    ReadOnly Property ToolTipText As String
    ReadOnly Property StartCommand As ICommand
End Interface
