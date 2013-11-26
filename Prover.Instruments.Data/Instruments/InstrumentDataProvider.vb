Imports Prover.Data.ProviderModel
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports Raven.Client.Document
Imports Raven.Client.Linq
Imports Raven.Client.Indexes


Namespace Instruments.Data
    Public Class InstrumentDataProvider
        Inherits DataProvider(Of IBaseInstrument)


        Public Sub New()
            MyBase.New()
            'IndexCreation.CreateIndexes(GetType(Instruments_MiniMax).Assembly, _docStore)
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
            Return ""
        End Function

        Public Function GetInstrumentsBySerialNumber(SerialNumber As String) As List(Of IBaseInstrument)

            Dim instr = (From i In _session.Query(Of IBaseInstrument)("BySerialNumber")
                Where i.SerialNumber = SerialNumber
                Select i).ToList()

            Return instr
        End Function

        Public Function GetInstrumentsWithNoCertificate() As List(Of IBaseInstrument)


            Dim instr = (From i In _session.Query(Of IBaseInstrument)("ByInspectionID")
                    Where i.InspectionID Is Nothing
              Select i).ToList()


            Return instr

        End Function

        Public Function GetInstrumentDateCreated(FromDate As DateTime) As List(Of IBaseInstrument)


            Dim instr = (From i In _session.Query(Of IBaseInstrument)("ByCreatedDate")
              Where i.CreatedDate.Value >= FromDate
              Select i).ToList()

            Return instr

        End Function

        Public Function GetMiniMaxInstruments() As List(Of IBaseInstrument)
            Dim instr = (From i In _session.Query(Of IBaseInstrument)("MiniMaxInstruments")
              Select i).ToList()

            Return instr
        End Function

        Public Function GetEC300Instruments() As List(Of IBaseInstrument)


            Dim instr = (From i In _session.Query(Of IBaseInstrument)("EC300Instruments")
              Select i).ToList()

            Return instr

        End Function

        Public Function GetInstrumentByID(ID As String) As IBaseInstrument

            Return _session.Load(Of IBaseInstrument)(ID)
        End Function

        Public Async Function UpsertInstrument(instrument As IBaseInstrument) As Task

            Await Task.Run(Sub()
                               Try
                                   If _session Is Nothing Then
                                       _session = _docStore.OpenSession()
                                   End If


                                   If instrument.CreatedDate Is Nothing Then instrument.CreatedDate = Date.Now()
                                   _session.Store(instrument)
                                   _session.SaveChanges()
                               Catch ex As Exception
                                   MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Error")
                               End Try

                           End Sub
            )
        End Function

        Public Async Function DeleteInstruments(Instruments As List(Of IBaseInstrument)) As Task
            Await Task.Run(Sub()
                               If _session Is Nothing Then
                                   _session = _docStore.OpenSession()
                               End If

                               For Each i In Instruments
                                   _session.Delete(i)
                               Next

                               _session.SaveChanges()

                           End Sub
            )
        End Function

        Protected Overrides Function FetchData(parameters As Dictionary(Of String, Object)) As IEnumerable(Of IBaseInstrument)
            Return Nothing
        End Function

        Private Sub CreateInstrumentIndexes()
            ' _session.
        End Sub
    End Class
End Namespace
