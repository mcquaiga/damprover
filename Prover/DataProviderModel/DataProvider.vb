Imports Raven.Client.Document

Namespace Data.ProviderModel
    Public MustInherit Class DataProvider(Of TElement)
        Implements IDataProvider


        Protected _docStore As DocumentStore = ProverDocuments.ProverDocumentStore
        Protected _session As DocumentSession
        Private _name As String
        Private _parameters As ParamDictionary
        Private _source As String
        Private _key As String
        Private _cacheLock As New Object

        Public Sub New(ByVal key As String, ByVal name As String, ByVal source As String, ByVal parameters As ParamDictionary)
            _name = name
            _key = key
            _parameters = parameters
            _source = source
        End Sub

        Protected Sub New()
            _session = _docStore.OpenSession
        End Sub

        Protected Sub New(Session As DocumentSession)
            _session = Session
        End Sub

        Public ReadOnly Property ElementType() As System.Type Implements IDataProvider.ElementType
            Get
                Return GetType(TElement)
            End Get
        End Property

        Public ReadOnly Property Name() As String Implements IDataProvider.Name
            Get
                Return _name
            End Get
        End Property

        Public ReadOnly Property Parameters() As ParamDictionary Implements IDataProvider.Parameters
            Get
                Return _parameters
            End Get
        End Property


        'First parameter - parameters dictionary; Second param - cached data
        Private _dicCache As New Dictionary(Of ParameterDictionary, IEnumerable(Of Object))
        Protected MustOverride Function FetchData(ByVal parameters As System.Collections.Generic.Dictionary(Of String, Object)) As IEnumerable(Of TElement)


        ''' <summary>
        ''' Returns data for the data provider request and caches it. It uses data from cache if the given combination of parameters exists as a key in the cache dictionary.
        ''' Cache in all data providers is reset after each data transfer and save (if Save in DataHelpers is used otherwise a module is responsible fore refreshing their providers cache)
        ''' for all registered data providers
        ''' </summary>
        ''' <param name="parameters"></param>
        ''' <returns></returns>
        ''' <remarks>Everything that accesses the cache is sync locked for thread safety, but the actual call to
        ''' GetData is NOT locked, to avoid prolonged blocking.</remarks>
        Public Function GetData(ByVal parameters As System.Collections.Generic.Dictionary(Of String, Object)) As IEnumerable(Of TElement)

            Dim params As New ParameterDictionary
            If parameters IsNot Nothing Then
                For Each p In parameters
                    params.Add(p.Key, p.Value)
                Next
            End If

            SyncLock _cacheLock
                Dim cachedValue = _dicCache.SingleOrDefault(Function(d) d.Key.Equals(params)).Value
                If cachedValue IsNot Nothing Then
                    Return cachedValue
                End If
            End SyncLock

            Dim data = FetchData(params)

            SyncLock _cacheLock
                Dim existingKey = _dicCache.SingleOrDefault(Function(d) d.Key.Equals(params)).Key
                If existingKey Is Nothing Then
                    _dicCache.Add(params, data)
                End If
            End SyncLock

            Return data

        End Function

        Private Function GetExistingKeyInCache(params As ParameterDictionary) As ParameterDictionary
            For Each k In _dicCache.Keys
                If k.Equals(params) Then
                    Return k
                End If
            Next
            Return Nothing
        End Function

        Private Function GetDataFromCache(params As ParameterDictionary) As IEnumerable(Of TElement)
            Return _dicCache.SingleOrDefault(Function(d) d.Key.Equals(params)).Value
        End Function

        Public Sub ClearCache() Implements IDataProvider.ClearCache
            SyncLock _cacheLock
                _dicCache.Clear()
            End SyncLock
        End Sub

        Public Function GetDataAsObjects(ByVal parameters As System.Collections.Generic.Dictionary(Of String, Object)) As IEnumerable(Of Object) Implements IDataProvider.GetData
            Return GetData(parameters).Cast(Of Object)()
        End Function

        Public ReadOnly Property Source() As String Implements IDataProvider.Source
            Get
                Return _source
            End Get
        End Property

        Public ReadOnly Property Key() As String Implements IDataProvider.Key
            Get
                Return _key
            End Get
        End Property

        Public MustOverride Function GetIdentifier(ByVal element As TElement) As String

        Public Function GetIdentifier1(ByVal element As Object) As String Implements IDataProvider.GetIdentifier
            If TypeOf element Is TElement Then
                Return GetIdentifier(DirectCast(element, TElement))
            Else
                Throw New ArgumentException("Element is of wrong type")
            End If
        End Function

        Public Function GetWrappedData(ByVal parameters As System.Collections.Generic.Dictionary(Of String, Object)) As IEnumerable(Of NamedEntity(Of TElement))
            Return GetData(parameters).Select(Function(el) New NamedEntity(Of TElement) With {.Name = GetName(el), .Id = GetIdentifier(el), .Entity = el}).ToList
        End Function

        Public Function GetWrappedData1(ByVal parameters As System.Collections.Generic.Dictionary(Of String, Object)) As System.Collections.Generic.IEnumerable(Of INamedEntity) Implements IDataProvider.GetWrappedData
            Return GetWrappedData(parameters)
        End Function

        Public MustOverride Function GetName(ByVal element As TElement) As String

        Public Function GetName1(ByVal element As Object) As String Implements IDataProvider.GetName
            If TypeOf element Is TElement Then
                Return GetName(DirectCast(element, TElement))
            Else
                Throw New ArgumentException("Element is of wrong type")
            End If
        End Function
    End Class

End Namespace