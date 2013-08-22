Imports miSerialProtocol
Imports Prover.Data.ProviderModel

Namespace Instruments.Data


    Public Class EC300Instrument : Inherits BaseInstrument

        Sub New()
            MyBase.New()
            InstrumentType = InstrumentTypeCode.EC300
            MyBase.Items = LoadInstrumentItems()
            MyBase.VolumeTest = New Volume(Items.Where(Function(x) x.IsVolume = True).ToList)
        End Sub



#Region "Methods"

        Overloads Shared Function LoadInstrumentItems() As List(Of ItemClass)
            Return ItemClass.LoadInstrumentItems(My.Application.Info.DirectoryPath + "\EC300Items.xml")
        End Function

#End Region


    End Class
End Namespace
