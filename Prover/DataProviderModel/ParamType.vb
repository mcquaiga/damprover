Namespace Data.ProviderModel

    Public MustInherit Class ParamType

        Public MustOverride Overrides Function Equals(ByVal obj As Object) As Boolean
        Public MustOverride ReadOnly Property Type As Type
        Public MustOverride ReadOnly Property DefaultValue As Object

    End Class


End Namespace
