Imports Raven.Client.Document

Namespace Data.ProviderModel
    Public NotInheritable Class ProverDocuments

        Private Sub New()
        End Sub

        Private Shared ReadOnly _docStore As New Lazy(Of DocumentStore) _
            (Function()
                 Dim docStore = New DocumentStore() With { _
                    .Url = "http://localhost:8080",
                    .DefaultDatabase = "prover"
                }
                 docStore.Initialize()

                 'OPTIONAL:
                 'IndexCreation.CreateIndexes(typeof(Global).Assembly, docStore);

                 Return docStore

             End Function)

        Public Shared ReadOnly Property ProverDocumentStore() As DocumentStore
            Get
                Return _docStore.Value
            End Get
        End Property
    End Class
End Namespace