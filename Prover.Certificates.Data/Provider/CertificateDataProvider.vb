Imports Prover.Data.ProviderModel
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports Raven.Client.Document
Imports Raven.Client.Linq

Public Class CertificateDataProvider
    Inherits DataProvider(Of ICertificate)

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(Session As DocumentSession)
        MyBase.New()
        Me._session = Session
    End Sub

    Public Async Function UpsertCertificate(certificate As ICertificate) As Task(Of String)

        Return Await Task.Run(Function()

                                  If _session Is Nothing Then
                                      _session = _docStore.OpenSession()
                                  End If

                                  _session.Store(certificate)
                                  _session.SaveChanges()
                                  Return _session.Advanced.GetDocumentId(certificate)
                              End Function
        )
    End Function

    Protected Overrides Function FetchData(parameters As Dictionary(Of String, Object)) As IEnumerable(Of ICertificate)
        Return Nothing
    End Function

    Public Overrides Function GetIdentifier(element As ICertificate) As String
        Return Nothing
    End Function

    Public Overrides Function GetName(element As ICertificate) As String
        Return Nothing
    End Function
End Class
