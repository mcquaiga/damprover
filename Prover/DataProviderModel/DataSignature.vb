Namespace Data.ProviderModel

    Public Class DataSignature

        Private _elementType As Type
        Private _parameters As ParamDictionary

        Public Sub New(ByVal elementType As Type, ByVal parameters As ParamDictionary)
            _elementType = elementType
            _parameters = parameters
        End Sub

        Public ReadOnly Property ElementType() As Type
            Get
                Return _elementType
            End Get
        End Property

        Public ReadOnly Property Parameters() As ParamDictionary
            Get
                Return _parameters
            End Get
        End Property

        Public Overrides Function Equals(ByVal obj As Object) As Boolean
            Dim signature = TryCast(obj, DataSignature)
            If signature IsNot Nothing Then
                If Me.ElementType Is signature.ElementType AndAlso ParamsAreEqual(Me.Parameters, signature.Parameters) Then
                    Return True
                End If
            End If
            Return False
        End Function

        Public Shared Function ParamsAreEqual(ByVal parameters1 As ParamDictionary, ByVal parameters2 As ParamDictionary) As Boolean
            ' if they have different number of params they must be different
            If parameters1.Count <> parameters2.Count Then
                Return False
            End If

            For Each key In parameters1.Keys
                ' if a key exists in one, but not the other, they must be different
                If Not parameters2.Keys.Contains(key) Then
                    Return False
                End If

                ' if the key exists in both make sure it has the same type
                If Not parameters1(key).Equals(parameters2(key)) Then
                    Return False
                End If
            Next

            ' if it got this far then no differences were found
            Return True
        End Function

    End Class

End Namespace
