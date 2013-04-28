Imports DAM_Prover.Data.ProviderModel

Public Class CustomersProvider
    Inherits DataProvider(Of ICustomers)

    Private Sub New()
        MyBase.New()
    End Sub

    Protected Overrides Function FetchData(parameters As Dictionary(Of String, Object)) As IEnumerable(Of ICustomers)

        Return GetAllCustomers()

    End Function


    Private Function CreateICustomer(ByVal customer As DamProverModel.customer) As ICustomers

        Return Nothing

    End Function

    Public Overrides Function GetIdentifier(ByVal element As ICustomers) As String
        Return Nothing
    End Function

    Public Overrides Function GetName(ByVal element As ICustomers) As String
        Return Nothing
    End Function


    Private Function GetAllCustomers() As List(Of ICustomers)

        Using Data As New CustomerDataContext
            Dim customers = From customer In Data.customers Where customer IsNot Nothing Select CreateICustomer(customer)
            Return customers.ToList()
        End Using

    End Function
End Class
