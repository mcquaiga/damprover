Imports MiserialProtocol
Imports Prover.Data.ProviderModel

Namespace Instruments.Data


    Public Class MiniMaxInstrument : Inherits BaseInstrument

        Sub New()
            MyBase.New()
            InstrumentType = InstrumentTypeCode.MiniMax
            MyBase.Items = LoadInstrumentItems()
            MyBase.VolumeTest = New Volume()
        End Sub



#Region "Methods"


        Overloads Shared Function LoadInstrumentItems() As List(Of ItemClass)
            Return ItemClass.LoadInstrumentItems(My.Application.Info.DirectoryPath + "\MiniMaxItems.xml")
        End Function

#End Region


    End Class
End Namespace
