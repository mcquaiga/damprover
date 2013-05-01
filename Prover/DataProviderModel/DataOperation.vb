Namespace Data.ProviderModel
    ''' <summary>
    ''' Represents a provider paired with a set of parameters
    ''' </summary>
    Public Class DataOperation(Of TElement)
        Inherits DataOperation

        Private _provider As DataProvider(Of TElement)
        Private _parameters As Dictionary(Of String, Object)

        Public Sub New(ByVal provider As DataProvider(Of TElement), ByVal parameters As Dictionary(Of String, Object))
            MyBase.New(provider, parameters)
            _provider = provider
            _parameters = parameters
        End Sub

        Public Function GetTypedData() As Dictionary(Of String, NamedEntity(Of TElement))
            Return _provider.GetWrappedData(_parameters).ToDictionary(Of String)(Function(el)
                                                                                     Return _provider.GetIdentifier(el.Entity)
                                                                                 End Function)
        End Function

    End Class

    ''' <summary>
    ''' Represents a provider paired with a set of parameters
    ''' </summary>
    Public Class DataOperation

        Private _provider As IDataProvider
        Private _parameters As Dictionary(Of String, Object)

        Public Sub New(ByVal provider As IDataProvider, ByVal parameters As Dictionary(Of String, Object))
            _provider = provider
            _parameters = parameters
        End Sub

        Public Function GetData() As Dictionary(Of String, INamedEntity)
            Return _provider.GetWrappedData(_parameters).ToDictionary(Of String)(Function(el) _provider.GetIdentifier(el.Entity))
        End Function

    End Class

End Namespace