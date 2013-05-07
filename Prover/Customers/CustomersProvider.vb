Imports Prover.Data.ProviderModel

Public Class CustomersProvider
    Inherits DataProvider(Of ICustomers)

    Private Sub New(ByVal key As String, ByVal name As String, ByVal source As String, ByVal parameters As ParamDictionary)
        MyBase.New(key, name, source, parameters)
    End Sub

    Public Shared Sub RegisterInstances()

        Dim params = New ParamDictionary From {{"time", New SimpleParamType(Of DateTime)}, {"maxHistory", New SimpleParamType(Of TimeSpan)}, {"jobId", New SimpleParamType(Of Guid)}}

        DataCoordinator.RegisterDataProvider(New CustomersProvider("AllCustomers", "All Customers", Nothing, params))
    End Sub

    Protected Overrides Function FetchData(parameters As Dictionary(Of String, Object)) As IEnumerable(Of ICustomers)

        Return GetAllCustomers()

    End Function


    Private Function CreateICustomer(ByVal customer As Prover.Model.customer) As ICustomers


        Return New Customer(customer)

    End Function

    Public Overrides Function GetIdentifier(ByVal element As ICustomers) As String
        Return element.CustomerID.ToString
    End Function

    Public Overrides Function GetName(ByVal element As ICustomers) As String
        Return element.CustomerName.ToString
    End Function


    Private Function GetAllCustomers() As List(Of ICustomers)

        Using Data As New CustomerDataContext
            Dim customers = From customer In Data.customers.ToList Where customer IsNot Nothing Select CreateICustomer(customer)
            Return customers.ToList
        End Using
    End Function

    Private Function GetCustomerByID(customerID As Integer) As ICustomers

        Using Data As New CustomerDataContext
            Return (From c In Data.customers.ToList Where c.customer_id = customerID And c IsNot Nothing Select CreateICustomer(c)).First
        End Using

    End Function

    Private Function GetCustomerByName(customerName As String) As ICustomers

        Using Data As New CustomerDataContext
            Return (From c In Data.customers.ToList Where c.name = customerName And c IsNot Nothing Select CreateICustomer(c)).First
        End Using

    End Function


End Class
