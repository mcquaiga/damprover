Imports Prover.Data.ProviderModel
Imports Prover.Instruments

Module Module1

    Sub Main()
        'LoadCustomers()
        ' loadinstruments()
        'saveinstrument()
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
        Dim it = i.GetInstrumentByGUID("9a16a25a-eb0b-4ad6-95bd-8583771673d4")
        Dim se = it.SerialNumber
        Dim x = it.PressureTests.Count
    End Sub

    Public Sub saveinstrument()
        Dim myinstrument As New MiniMaxInstrument("COM9", miSerialProtocol.BaudRateEnum.b38400)
        Dim myprovider As New InstrumentDataProvider
        'InstrumentDataProvider.RegisterInstances()
        'Dim i = DataCoordinator.GetData(Of IBaseInstrument)("AllInstruments", New Dictionary(Of String, Object) From {{"time", DateTime.Now()}})
        Dim items = ItemClass.LoadInstrumentItems(".\MiniMaxItems.xml")
        myinstrument.ItemFile = InstrumentCommunications.DownloadItemFile(myinstrument)
        myprovider.UpsertInstrument(myinstrument)
    End Sub
End Module
