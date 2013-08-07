Imports Prover.Data.ProviderModel
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports Raven.Client.Document
Imports Raven.Client.Linq


Namespace Instruments.Data
    Public Class InstrumentDataProvider
        Inherits DataProvider(Of IBaseInstrument)


        Public Sub New()
            MyBase.New()
        End Sub
        Private Sub New(ByVal key As String, ByVal name As String, ByVal source As String, ByVal parameters As ParamDictionary)
            MyBase.New(key, name, source, parameters)
        End Sub

        Public Shared Sub RegisterInstances()
            Dim params = New ParamDictionary From {{"time", New SimpleParamType(Of DateTime)}, {"maxHistory", New SimpleParamType(Of TimeSpan)}, {"InstrumentGuId", New SimpleParamType(Of Guid)}}
            DataCoordinator.RegisterDataProvider(New InstrumentDataProvider("AllInstruments", "All Instruments", Nothing, params))
        End Sub

        Private Function CreateInstrument() As IBaseInstrument 'ByVal instrument As Prover.Model.instr) As IBaseInstrument
            Return Nothing
        End Function

        Public Overrides Function GetIdentifier(ByVal element As IBaseInstrument) As String
            Return element.InstrumentGuid.ToString
        End Function

        Public Overrides Function GetName(ByVal element As IBaseInstrument) As String
            Return element.InstrumentDriveType.ToString
        End Function

        Public Function GetInstrumentsBySerialNumber(SerialNumber As String) As List(Of IBaseInstrument)
            Dim session = _docStore.OpenSession()

            Dim instr = (From i In session.Query(Of IBaseInstrument)("BySerialNumber")
                Where i.SerialNumber = SerialNumber
                Select i).ToList()

            Return instr
        End Function

        Public Function GetInstrumentsWithNoCertificate() As List(Of IBaseInstrument)
            Dim session = _docStore.OpenSession()

            Dim instr = (From i In session.Query(Of IBaseInstrument)()
              Where i.InspectionID Is Nothing
              Select i).ToList()


            Return instr

        End Function

        Public Function GetInstrumentDateCreated(FromDate As DateTime) As List(Of IBaseInstrument)
            Dim session = _docStore.OpenSession()

            Dim instr = (From i In session.Query(Of IBaseInstrument)("ByCreatedDate")
              Where i.CreatedDate.Value >= FromDate
              Select i).ToList()

            Return instr

        End Function

        Public Function GetInstrumentByInstrumentType(InstrumentType As String) As List(Of IBaseInstrument)
            Dim session = _docStore.OpenSession()

            Dim instr = (From i In session.Query(Of IBaseInstrument)("MiniMaxInstruments")
              Select i).ToList()

            Return instr

        End Function

        Public Function GetInstrumentByID(ID As String) As IBaseInstrument
            Dim session = _docStore.OpenSession()

            Return session.Load(Of IBaseInstrument)(ID)
        End Function

        Public Sub UpsetNewInstrument(Instrument As IBaseInstrument)
            UpsertInstrument(Instrument, Nothing)
        End Sub

        Public Sub UpsertInstrument(instrument As IBaseInstrument, Session As DocumentSession)
            If Session Is Nothing Then
                Session = _docStore.OpenSession()
            Else
                If Not Session.HasChanged(instrument) Then
                    Exit Sub
                End If
            End If
            If instrument.CreatedDate Is Nothing Then instrument.CreatedDate = Date.Now()
            Session.Store(instrument)
            Session.SaveChanges()
        End Sub

        Protected Overrides Function FetchData(parameters As Dictionary(Of String, Object)) As IEnumerable(Of IBaseInstrument)
            Return Nothing
        End Function
    End Class
End Namespace
