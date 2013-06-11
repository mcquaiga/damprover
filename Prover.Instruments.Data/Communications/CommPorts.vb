Imports System.Collections.ObjectModel

Public Class CommunicationPorts

    Public Shared Function GetAllCommPorts() As ReadOnlyCollection(Of String)
        Return My.Computer.Ports.SerialPortNames
    End Function

End Class
