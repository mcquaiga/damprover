Imports Microsoft.Practices.Prism
Imports System.Windows.Input

Public Class ProverModule
    Implements IProverModule

    Private _title As String
    Private _startCommand As ICommand
    Private _toolTipText As String
    Private _icon As String

    Sub New(Title As String, StartCommand As ICommand, ToolTipText As String, Icon As String)
        _title = Title
        _startCommand = StartCommand
        _toolTipText = ToolTipText
        _icon = Icon
    End Sub

    Public ReadOnly Property Icon As String Implements IProverModule.Icon
        Get
            Return _icon

        End Get
    End Property

    Public ReadOnly Property StartCommand As ICommand Implements IProverModule.StartCommand
        Get
            Return _startCommand
        End Get
    End Property

    Public ReadOnly Property Title As String Implements IProverModule.Title
        Get
            Return _title
        End Get
    End Property

    Public ReadOnly Property ToolTipText As String Implements IProverModule.ToolTipText
        Get
            Return _toolTipText
        End Get
    End Property
End Class
