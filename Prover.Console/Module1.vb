Imports Prover.Data.ProviderModel
Imports Prover.Prover
Imports System.Xml
Imports System.Xml.Serialization
Imports Newtonsoft.Json
Imports System.Net
Imports System.Net.Sockets
Imports Prover.Instruments.Data


Module Module1

    Sub Main()
        'LoadCustomers()
        'loadinstruments()
        'GetAllInstruments()
        saveinstrument()
        'InstrumentByGuid()
    End Sub

    Public Sub LoadCustomers()

        CustomersProvider.RegisterInstances()
        Dim c = DataCoordinator.GetData(Of ICustomers)("AllCustomers", New Dictionary(Of String, Object) From {{"time", DateTime.Now()}})

    End Sub

    Public Sub loadinstruments()
        InstrumentDataProvider.RegisterInstances()
        Dim i = DataCoordinator.GetData(Of IBaseInstrument)("AllInstruments", New Dictionary(Of String, Object) From {{"time", DateTime.Now()}})

        Dim myInstrument As New MiniMaxInstrument()
        Dim y = InstrumentCommunications.DownloadItemFile(myInstrument)

    End Sub

    Public Sub InstrumentByGuid()
        Dim i = New InstrumentDataProvider()
        Dim x = 0
        Dim it = i.GetInstrumentByID("BaseInstruments/622")
        'Dim se = it.GetItemValue(62)
        'Dim js = "{'InstrumentType':4,'TemperatureData':null,'VolumeData':null,'InstrumentDriveType':0,'ItemFile':{'0':' 0000000','1':' 0000000','2':' 0000000','5':' 0000000','6':' 0000000','8':'    0.00','10':'99999.98','11':'   -1.00','12':'  0.0000','13':' 14.6500','14':' 14.4000','15':'    0.00','16':'    0.00','17':'  0.0000','18':'  0.0000','19':'  0.0000','20':'  1.0000','21':'  1.0000','22':'  1.0000','23':' 50.0000','24':'  2.0000','25':'  100.00','26':'  -40.00','27':'  -35.00','28':'  145.00','29':'    0.00','30':'    0.00','31':'   73.32','32':'  114.22','33':'    5.21','34':'   60.00','35':'  0.0893','44':'  1.0000','47':'  1.0000','62':'01084240','87':'       0','109':'       1','112':'       0'},'InspectionID':0,'PressureTests':[{'Items':{'8':'    0.00','13':' 14.6500','14':' 14.4000','44':'  1.0000','47':'  1.0000','87':'       0','109':'       1','112':'       0'},'GaugePressure':60.0,'AtmosphericPressure':0.0,'PressureUnits':0,'Transducer':0,'BasePressure':14.65,'EVCPressure':'    0.00','EVCFactor':'  1.0000','EVCUnsqr':1.0,'PercentError':-75.583333333333343,'ActualPressureFactor':4.09556313993174},{'Items':{'8':'    0.00','13':' 14.6500','14':' 14.4000','44':'  1.0000','47':'  1.0000','87':'       0','109':'       1','112':'       0'},'GaugePressure':60.0,'AtmosphericPressure':0.0,'PressureUnits':0,'Transducer':0,'BasePressure':14.65,'EVCPressure':'    0.00','EVCFactor':'  1.0000','EVCUnsqr':1.0,'PercentError':-75.583333333333343,'ActualPressureFactor':4.09556313993174}],'TemperatureTests':null,'VolumeTests':null,'InstrumenGuID':'9832c3c7-1a93-43a1-9dfc-f3df046006c3','SerialNumber':'01084240','PulseASelect':0,'PulseBSelect':0}"
        'Dim myI = JsonConvert.DeserializeObject(Of BaseInstrument)(js)
        i.UpsertInstrument(it)
        ' Dim x = it.PressureTests.Count

    End Sub

    Public Sub GetAllInstruments()
        Dim i = New InstrumentDataProvider
        i.GetInstrumentsBySerialNumber("01084240")

    End Sub

    Public Sub saveinstrument()
        Dim myinstrument As New MiniMaxInstrument()
        Dim myprovider As New InstrumentDataProvider
        'InstrumentDataProvider.RegisterInstances()
        'Dim i = DataCoordinator.GetData(Of IBaseInstrument)("AllInstruments", New Dictionary(Of String, Object) From {{"time", DateTime.Now()}})

        Dim x = My.Computer.Ports

        InstrumentCommunications.CommPort = "Com4"
        InstrumentCommunications.BaudRate = miSerialProtocol.BaudRateEnum.b38400
        myinstrument.ItemFile = InstrumentCommunications.DownloadItemFile(myinstrument)

        Dim p As New PressureFactorClass()
        With p
            p.Items = InstrumentCommunications.DownloadPressureItems(myinstrument)
            p.GaugePressure = 80
            myinstrument.PressureTests.Add(p)

            p.Items = InstrumentCommunications.DownloadPressureItems(myinstrument)
            p.GaugePressure = 60
            myinstrument.PressureTests.Add(p)

            p.Items = InstrumentCommunications.DownloadPressureItems(myinstrument)
            p.GaugePressure = 20
            myinstrument.PressureTests.Add(p)
        End With

        Dim js = JsonConvert.SerializeObject(myinstrument)
        myprovider.UpsertInstrument(myinstrument)
    End Sub
End Module
