Imports Prover.Data.ProviderModel

Module Module1

    Sub Main()
        'LoadCustomers()
        loadinstruments()
    End Sub

    Public Sub LoadCustomers()

        CustomersProvider.RegisterInstances()
        Dim c = DataCoordinator.GetData(Of ICustomers)("AllCustomers", New Dictionary(Of String, Object) From {{"time", DateTime.Now()}})

    End Sub

    Public Sub loadinstruments()
        InstrumentDataProvider.RegisterInstances()
        Dim i = DataCoordinator.GetData(Of IBaseInstrument)("AllInstruments", New Dictionary(Of String, Object) From {{"time", DateTime.Now()}})

    End Sub

End Module
