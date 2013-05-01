Namespace Data.ProviderModel

    Public Class SimpleParamType(Of T)
        Inherits ParamType

        Private _defaultValue As T

        Public Sub New()
        End Sub

        Public Sub New(ByVal defaultValue As T)
            _defaultValue = defaultValue
        End Sub

        Public Overrides ReadOnly Property Type() As Type
            Get
                Return GetType(T)
            End Get
        End Property

        Public Overloads Overrides Function Equals(ByVal obj As Object) As Boolean
            Dim other = TryCast(obj, ParamType)
            If other Is Nothing Then
                Return False
            Else
                Return Me.Type Is other.Type
            End If
        End Function

        Public Overrides ReadOnly Property DefaultValue As Object
            Get
                Return _defaultValue
            End Get
        End Property

    End Class

    Public Class SimpleParamType
        Inherits ParamType

        Private _type As Type
        Private _defaultValue As Object

        Public Sub New(type As Type)
            _type = type
        End Sub

        Public Sub New(type As Type, ByVal defaultValue As Object)
            _type = Type
            _defaultValue = defaultValue
        End Sub

        Public Overrides ReadOnly Property DefaultValue As Object
            Get
                Return _defaultValue
            End Get
        End Property

        Public Overloads Overrides Function Equals(obj As Object) As Boolean
            Dim other = TryCast(obj, ParamType)
            If other Is Nothing Then
                Return False
            Else
                Return Me.Type Is other.Type
            End If
        End Function

        Public Overrides ReadOnly Property Type As System.Type
            Get
                Return _type
            End Get
        End Property

    End Class


End Namespace