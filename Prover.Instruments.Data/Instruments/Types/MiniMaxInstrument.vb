Imports MiserialProtocol
Imports Prover.Data.ProviderModel

Public Class MiniMaxInstrument : Inherits BaseInstrument

    Public MiniMax As miSerialProtocol.MiniMaxClass


    Sub New(commPort As String, BaudRate As BaudRateEnum)
        MyBase.New(commPort, BaudRate)
        InstrumentType = InstrumentTypeCode.MiniMax
        Items = LoadInstrumentItems()
    End Sub

    Sub New(instrument As Prover.Model.instr)
        MyBase.New(instrument)
    End Sub


#Region "Methods"


    Overloads Shared Function LoadInstrumentItems() As List(Of ItemClass)
        Return ItemClass.LoadInstrumentItems(My.Application.Info.DirectoryPath + "\MiniMaxItems.xml")
    End Function

#End Region


End Class
