Namespace Data.ProviderModel

    Public Class ParamDictionary
        Inherits Dictionary(Of String, ParamType)
    End Class

    Public Class ParameterDictionary
        Inherits Dictionary(Of String, Object)

        Public Overrides Function Equals(ByVal obj As Object) As Boolean

            Dim x = Me
            Dim y = DirectCast(obj, Dictionary(Of String, Object))

            If x.Count <> y.Count Then Return False

            For Each x1 In x
                If y.Keys.Contains(x1.Key) Then
                    If x1.Value IsNot Nothing AndAlso Not x1.Value.Equals(y(x1.Key)) Then
                        Return False
                    End If
                Else
                    Return False
                End If
            Next

            Return True
        End Function

        Public Overrides Function GetHashCode() As Integer
            Return MyBase.GetHashCode()
        End Function

    End Class

End Namespace