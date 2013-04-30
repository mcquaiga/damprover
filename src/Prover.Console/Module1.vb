Imports Prover.Data.ProviderModel

Module Module1

    Sub Main()
        Loadcustomers()
    End Sub

    Public Sub LoadCustomers()

        CustomersProvider.RegisterInstances()
        Dim c = DataCoordinator.GetData(Of ICustomers)("AllCustomers", New Dictionary(Of String, Object))

    End Sub

End Module
