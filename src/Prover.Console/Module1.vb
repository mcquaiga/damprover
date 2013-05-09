Imports Prover.Data.ProviderModel
Imports Prover.Instruments

Module Module1

    Sub Main()
        'LoadCustomers()
        ' loadinstruments()
        saveinstrument()
        InstrumentByGuid()
    End Sub

    Public Sub LoadCustomers()

        CustomersProvider.RegisterInstances()
        Dim c = DataCoordinator.GetData(Of ICustomers)("AllCustomers", New Dictionary(Of String, Object) From {{"time", DateTime.Now()}})

    End Sub

    Public Sub loadinstruments()
        InstrumentDataProvider.RegisterInstances()
        Dim i = DataCoordinator.GetData(Of IBaseInstrument)("AllInstruments", New Dictionary(Of String, Object) From {{"time", DateTime.Now()}})

        Dim myInstrument As New MiniMaxInstrument("COM9", miSerialProtocol.BaudRateEnum.b38400)
        Dim y = InstrumentCommunications.DownloadItemFile(myInstrument)

    End Sub

    Public Sub InstrumentByGuid()
        Dim i = New InstrumentDataProvider()
        Dim it = i.GetInstrumentByGUID("14405968-ae84-43af-9821-2c6da6ddd462")
    End Sub

    Public Sub saveinstrument()
        Dim myinstrument As New MiniMaxInstrument("COM9", miSerialProtocol.BaudRateEnum.b38400)
        Dim myprovider As New InstrumentDataProvider
        'InstrumentDataProvider.RegisterInstances()
        'Dim i = DataCoordinator.GetData(Of IBaseInstrument)("AllInstruments", New Dictionary(Of String, Object) From {{"time", DateTime.Now()}})

        myinstrument.ItemFile = InstrumentCommunications.DownloadItemFile(myinstrument)
        myprovider.UpsertInstrument(myinstrument)
    End Sub
End Module
