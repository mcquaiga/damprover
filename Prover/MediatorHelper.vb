Imports System.Collections.Generic

Public NotInheritable Class Mediator
    Private Sub New()
    End Sub
    Shared pl_dict As IDictionary(Of String, List(Of Action(Of Object))) = New Dictionary(Of String, List(Of Action(Of Object)))()

    Public Shared Sub Register(token As String, callback As Action(Of Object))
        If Not pl_dict.ContainsKey(token) Then
            Dim list = New List(Of Action(Of Object))()
            list.Add(callback)
            pl_dict.Add(token, list)
        Else
            Dim found As Boolean = False
            For Each item In pl_dict(token)
                If item.Method.ToString() = callback.Method.ToString() Then
                    found = True
                End If
            Next
            If Not found Then
                pl_dict(token).Add(callback)
            End If
        End If
    End Sub

    Public Shared Sub Unregister(token As String, callback As Action(Of Object))
        If pl_dict.ContainsKey(token) Then
            pl_dict(token).Remove(callback)
        End If
    End Sub

    Public Shared Sub NotifyColleagues(token As String, args As Object)
        If pl_dict.ContainsKey(token) Then
            For Each callback In pl_dict(token)
                callback(args)
            Next
        End If
    End Sub
End Class
