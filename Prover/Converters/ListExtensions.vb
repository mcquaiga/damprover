Imports System.Runtime.CompilerServices

Public Module ListExtension

    <Extension()>
    Sub BubbleSort(o As IList)
        For i As Integer = o.Count - 1 To 0 Step -1
            For j As Integer = 1 To i
                Dim o1 As Object = o(j - 1)
                Dim o2 As Object = o(j)
                If DirectCast(o1, IComparable).CompareTo(o2) > 0 Then
                    o.Remove(o1)
                    o.Insert(j, o1)
                End If
            Next
        Next
    End Sub
End Module
