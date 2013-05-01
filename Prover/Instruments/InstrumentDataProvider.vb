Imports Prover.Data.ProviderModel

Public Class InstrumentDataProvider
    Inherits DataProvider(Of IBaseInstrument)

    Private Sub New(ByVal key As String, ByVal name As String, ByVal source As String, ByVal parameters As ParamDictionary)
        MyBase.New(key, name, source, parameters)
    End Sub

    Public Shared Sub RegisterInstances()

        Dim params = New ParamDictionary From {{"time", New SimpleParamType(Of DateTime)}, {"maxHistory", New SimpleParamType(Of TimeSpan)}, {"InstrumentGuId", New SimpleParamType(Of Guid)}}

        DataCoordinator.RegisterDataProvider(New InstrumentDataProvider("AllInstruments", "All Instruments", Nothing, params))
    End Sub

    Protected Overrides Function FetchData(parameters As Dictionary(Of String, Object)) As Global.System.Collections.Generic.IEnumerable(Of Global.Prover.IBaseInstrument)

        Return GetAllInstruments()

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


    Private Function GetAllInstruments() As List(Of IBaseInstrument)

        Using Data As New InstrumentDataContext
            Dim instruments = From inst In Data.instrs.ToList Where inst IsNot Nothing Select CreateInstrument(inst)
            Return instruments.ToList
        End Using


    End Function
End Class
