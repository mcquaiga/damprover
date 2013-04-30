Namespace Data.ProviderModel

    Public Interface IDataProvider

        ReadOnly Property ElementType() As Type
        ReadOnly Property Parameters() As ParamDictionary
        ReadOnly Property Name() As String
        ReadOnly Property Key() As String
        ReadOnly Property Source() As String

        Function GetData(ByVal parameters As Dictionary(Of String, Object)) As IEnumerable(Of Object)
        Function GetWrappedData(ByVal parameters As Dictionary(Of String, Object)) As IEnumerable(Of INamedEntity)
        Function GetIdentifier(ByVal element As Object) As String
        Function GetName(ByVal element As Object) As String

        Sub ClearCache()

    End Interface

End Namespace