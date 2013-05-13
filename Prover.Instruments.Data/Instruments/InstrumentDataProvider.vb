Imports Prover.Data.ProviderModel
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports Raven.Client.Document
Imports Raven.Client.Linq
Imports Prover.Instruments.Data

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

        Protected Overrides Function FetchData(parameters As Dictionary(Of String, Object)) As Global.System.Collections.Generic.IEnumerable(Of IBaseInstrument)
            'Return GetAllInstruments()
        End Function

        Private Function CreateInstrument(ByVal instrument As Prover.Model.instr) As IBaseInstrument
            Select Case instrument.instr_type_id
                Case miSerialProtocol.InstrumentTypeCode.MiniMax
                    Return New MiniMaxInstrument(instrument)
                Case Else
                    Return Nothing
            End Select
        End Function

        Public Overrides Function GetIdentifier(ByVal element As IBaseInstrument) As String
            Return element.InstrumentGuid.ToString
        End Function

        Public Overrides Function GetName(ByVal element As IBaseInstrument) As String
            Return element.InstrumentDriveType.ToString
        End Function


        Public Function GetInstrumentsBySerialNumber(SerialNumber As String) As List(Of BaseInstrument)
            Dim session = _docStore.OpenSession()

            Dim instr = (From i In session.Query(Of BaseInstrument)("BaseInstruments/BySerialNumber")
                Where i.SerialNumber Like "%" + SerialNumber + "%"
                Select i).ToList()

            Return instr
        End Function

        Public Function GetInstrumentByID(ID As String) As BaseInstrument
            Dim session = _docStore.OpenSession()

            Return session.Load(Of BaseInstrument)(ID)
        End Function

        Public Sub UpsertInstrument(instrument As IBaseInstrument)

            Dim session = _docStore.OpenSession()
            If instrument.CreatedDate Is Nothing Then instrument.CreatedDate = Date.Now()
            session.Store(instrument)
            session.SaveChanges()
        End Sub

    End Class
End Namespace
