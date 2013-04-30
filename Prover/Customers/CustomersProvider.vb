Imports Prover.Data.ProviderModel

Public Class CustomersProvider
    Inherits DataProvider(Of ICustomers)

    Private Sub New(ByVal key As String, ByVal name As String, ByVal source As String, ByVal parameters As ParamDictionary)
        MyBase.New(key, name, source, parameters)
    End Sub

    Public Shared Sub RegisterInstances()
        DataCoordinator.RegisterDataProvider(New CustomersProvider("AllCustomers", "All Customers", Nothing, Nothing))
    End Sub

    Protected Overrides Function FetchData(parameters As Dictionary(Of String, Object)) As IEnumerable(Of ICustomers)

        Return GetAllCustomers()

    End Function


    Private Function CreateICustomer(ByVal customer As Customer) As ICustomers

        Return customer

    End Function

    Public Overrides Function GetIdentifier(ByVal element As ICustomers) As String
        Return Nothing
    End Function

    Public Overrides Function GetName(ByVal element As ICustomers) As String
        Return Nothing
    End Function


    Private Function GetAllCustomers() As List(Of ICustomers)

        Using Data As New CustomerDataContext
            Dim customers = From customer In Data.customers.ToList Where customer IsNot Nothing Select customer
            For Each c In customers
                Dim id = c.customer_id
            Next
            Return Nothing
            'Return customers.ToList()
        End Using

    End Function
End Class
