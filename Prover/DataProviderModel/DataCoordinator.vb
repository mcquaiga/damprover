Option Strict On

Imports Microsoft.Practices.Unity
Imports Microsoft.Practices.Prism.Events

Namespace Data.ProviderModel
    Public Class DataCoordinator

        Private Shared _dataProviders As New Dictionary(Of String, HashSet(Of IDataProvider))

        ''' <summary>
        ''' Get data providers returning elements of the specified type.
        ''' </summary>
        ''' <typeparam name="TElement">The type of the elements in the result</typeparam>
        ''' <param name="providerKey">Name of the data source</param>
        Public Shared Function GetDataProviders(Of TElement)(ByVal providerKey As String) As IEnumerable(Of DataProvider(Of TElement))
            Return GetDataProviders(providerKey).Where(Function(dp) dp.ElementType Is GetType(TElement)).Cast(Of DataProvider(Of TElement))()
        End Function

        ''' <summary>
        ''' Get data providers returning elements of the specified type that take the specific
        ''' set of parameters given.
        ''' </summary>
        ''' <typeparam name="TElement">The type of the elements in the result</typeparam>
        ''' <param name="providerKey">Name of the data source</param>
        ''' <param name="parameters">The arguments required</param>
        Public Shared Function GetDataProviders(Of TElement)(ByVal providerKey As String, ByVal parameters As ParamDictionary) As IEnumerable(Of DataProvider(Of TElement))
            Return GetDataProviders(Of TElement)(providerKey).Where(Function(dp) DataSignature.ParamsAreEqual(parameters, dp.Parameters))
        End Function

        ''' <summary>
        ''' Get data providers returning elements of the specified type.
        ''' </summary>
        ''' <param name="providerKey">Name of the data source</param>
        ''' <param name="elementType">The type of elements in the result</param>
        Public Shared Function GetDataProviders(ByVal providerKey As String, ByVal elementType As Type) As IEnumerable(Of IDataProvider)
            Return GetDataProviders(providerKey).Where(Function(dp) dp.ElementType Is elementType)
        End Function

        Public Shared Function GetDataProviders(providerKey As String, parameterTypes As Dictionary(Of String, Type)) As IEnumerable(Of IDataProvider)
            Return GetDataProviders(providerKey).Where(Function(provider) ParamsAreEqual(provider.Parameters, parameterTypes))
        End Function

        Private Shared Function ParamsAreEqual(paramDict As ParamDictionary, parameterTypes As Dictionary(Of String, Type)) As Boolean
            Return parameterTypes.All(Function(paramType) paramDict.Keys.Contains(paramType.Key) AndAlso paramDict(paramType.Key).Type Is paramType.Value)
        End Function

        ''' <summary>
        ''' Get data providers returning elements of the specified type that take the specific
        ''' set of parameters given.
        ''' </summary>
        ''' <param name="providerKey">Name of the data source</param>
        ''' <param name="elementType">The type of the elements in the result</param>
        ''' <param name="parameters">Arguments required</param>
        Public Shared Function GetDataProviders(ByVal providerKey As String, ByVal elementType As Type, ByVal parameters As ParamDictionary) As IEnumerable(Of IDataProvider)
            Return GetDataProviders(providerKey, elementType).Where(Function(dp) DataSignature.ParamsAreEqual(dp.Parameters, parameters))
        End Function

        ''' <summary>
        ''' Get all data providers with the given key
        ''' </summary>
        ''' <param name="providerKey">Name of the data source</param>
        Public Shared Function GetDataProviders(ByVal providerKey As String) As IEnumerable(Of IDataProvider)
            If _dataProviders.Keys.Contains(providerKey) Then
                Return _dataProviders(providerKey)
            Else
                Return New IDataProvider() {}
            End If
        End Function

        Public Shared Function GetDataProviders(Of TElement)() As IEnumerable(Of DataProvider(Of TElement))
            Return (From providerGroup In _dataProviders.Values
                    From provider In providerGroup
                    Select provider).OfType(Of DataProvider(Of TElement))()
        End Function

        ''' <summary>
        ''' Adds a new data provider to the coordinator
        ''' </summary>
        ''' <typeparam name="TElement">Type of the elements returned</typeparam>
        ''' <param name="dataProvider">An instance of the provider</param>
        Public Shared Sub RegisterDataProvider(Of TElement)(ByVal dataProvider As DataProvider(Of TElement))
            If Not _dataProviders.Keys.Contains(dataProvider.Key) Then
                _dataProviders(dataProvider.Key) = New HashSet(Of IDataProvider)
            End If
            _dataProviders(dataProvider.Key).Add(dataProvider)

            ' Notify anyone who's listening that this data provider has been initialized
            'If OnboardManager.Unity.IsRegistered(GetType(IEventAggregator)) Then
            'OnboardManager.Unity.Resolve(Of IEventAggregator)().GetEvent(Of DataChangedEvent).Publish(dataProvider)
            'End If

        End Sub

        Public Shared Sub ClearDataProviders()
            _dataProviders.Clear()
        End Sub

        ''' <summary>
        ''' Gets unioned results from all data providers that meet the given criteria
        ''' </summary>
        ''' <typeparam name="TElement">The type of elements in the result</typeparam>
        Public Shared Function GetData(Of TElement)(ByVal providerKey As String, ByVal parameters As Dictionary(Of String, Object), ByVal signature As DataSignature) As IEnumerable(Of NamedEntity(Of TElement))
            Dim result As New List(Of NamedEntity(Of TElement))
            For Each provider In GetDataProviders(Of TElement)(providerKey, signature.Parameters)
                result.AddRange(provider.GetWrappedData(parameters))
            Next
            Return result
        End Function

        Public Shared Function GetData(Of TElement)() As IEnumerable(Of NamedEntity(Of TElement))
            Dim result As New List(Of NamedEntity(Of TElement))
            For Each provider In GetDataProviders(Of TElement)()
                result.AddRange(provider.GetWrappedData(New Dictionary(Of String, Object)))
            Next
            Return result
        End Function

        Public Shared Function GetData(Of TElement)(ByVal providerKey As String) As IEnumerable(Of NamedEntity(Of TElement))
            Dim result As New List(Of NamedEntity(Of TElement))
            For Each provider In GetDataProviders(Of TElement)(providerKey, New ParamDictionary)
                result.AddRange(provider.GetWrappedData(New Dictionary(Of String, Object)))
            Next
            Return result
        End Function

        Public Shared Function GetData(ByVal providerKey As String) As IEnumerable(Of INamedEntity)
            Dim result As New List(Of INamedEntity)
            For Each provider In GetDataProviders(providerKey)
                result.AddRange(provider.GetWrappedData(New Dictionary(Of String, Object)))
            Next
            Return result
        End Function

        Public Shared Function GetData(ByVal providerKey As String, ByVal parameters As Dictionary(Of String, Object), ByVal signature As DataSignature) As IEnumerable(Of INamedEntity)
            Dim result As New List(Of INamedEntity)
            For Each provider In GetDataProviders(providerKey, signature.ElementType, signature.Parameters)
                result.AddRange(provider.GetWrappedData(parameters))
            Next
            Return result
        End Function

        Public Shared Function GetData(providerKey As String, parameterValues As Dictionary(Of String, Object)) As IEnumerable(Of INamedEntity)
            Dim parameterTypes = parameterValues.ToDictionary(Of String, Type)(Function(o) o.Key, Function(o) o.Value.GetType())
            Return GetData(providerKey, parameterValues, parameterTypes)
        End Function

        Public Shared Function GetData(providerKey As String, parameterValues As Dictionary(Of String, Object), parameterTypes As Dictionary(Of String, Type)) As IEnumerable(Of INamedEntity)
            Dim result As New List(Of INamedEntity)
            For Each provider In GetDataProviders(providerKey, parameterTypes)
                result.AddRange(provider.GetWrappedData(parameterValues))
            Next
            Return result
        End Function

        Public Shared Function GetData(Of TElement)(ByVal dataOperations As IEnumerable(Of DataOperation(Of TElement))) As IEnumerable(Of NamedEntity(Of TElement))
            Dim result As New Dictionary(Of String, NamedEntity(Of TElement))
            For Each operation In dataOperations
                For Each keyValPair In operation.GetTypedData
                    result(keyValPair.Key) = keyValPair.Value
                Next
            Next
            Return result.Values.ToList
        End Function

        Public Shared Function GetData(Of TElement)(providerKey As String, parameters As Dictionary(Of String, Object)) As IEnumerable(Of NamedEntity(Of TElement))
            Dim providers = GetDataProviders(Of TElement)(providerKey)
            Dim result As New Dictionary(Of String, NamedEntity(Of TElement))
            For Each provider In providers
                For Each e In GetData(Of TElement)({New DataOperation(Of TElement)(provider, parameters)})
                    result(e.Id) = e
                Next
            Next
            Return result.Values.ToList
        End Function

        Public Shared Function GetData(ByVal dataOperations As IEnumerable(Of DataOperation)) As IEnumerable(Of INamedEntity)
            Dim result As New Dictionary(Of String, INamedEntity)
            For Each operation In dataOperations
                For Each keyValPair In operation.GetData
                    result(keyValPair.Key) = keyValPair.Value
                Next
            Next
            Return result.Values.ToList
        End Function

        Public Shared Function GetAllDataProviderKeys() As IEnumerable(Of String)
            Return _dataProviders.Select(Function(keyValPair) keyValPair.Key)
        End Function

        Public Shared Function GetAvailableSignatures(ByVal providerKey As String) As IEnumerable(Of DataSignature)
            Dim signatures As New List(Of DataSignature)
            For Each provider In _dataProviders(providerKey)
                Dim thisSignature As New DataSignature(provider.ElementType, provider.Parameters)
                If Not signatures.Any(Function(sig) sig.Equals(thisSignature)) Then
                    signatures.Add(thisSignature)
                End If
            Next
            Return signatures
        End Function

        Public Shared Sub ClearAllProvidersCaches()
            For Each similarProviders In _dataProviders.Values
                For Each p In similarProviders
                    p.ClearCache()
                Next
            Next
        End Sub

    End Class

End Namespace