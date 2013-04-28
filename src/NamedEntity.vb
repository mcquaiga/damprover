Namespace Data.ProviderModel

    Public Interface INamedEntity

        Property Name As String

        Property Id As String

        Property Entity As Object

    End Interface

    Public Class NamedEntity(Of TEntity)
        Implements INamedEntity

        Public Property Entity As TEntity

        Public Property EntityAsObject As Object Implements INamedEntity.Entity
            Get
                Return Entity
            End Get
            Set(ByVal value As Object)
                Entity = DirectCast(value, TEntity)
            End Set
        End Property

        Public Property Id As String Implements INamedEntity.Id

        Public Property Name As String Implements INamedEntity.Name

    End Class

End Namespace