Imports MiserialProtocol
Imports Prover.Data.ProviderModel

Namespace Instruments.Data


    Public Class MiniMaxInstrument : Inherits BaseInstrument

        Sub New()
            MyBase.New()
            MyBase.Items = LoadInstrumentItems()
            InstrumentType = InstrumentTypeCode.MiniMax
        End Sub

        Public ReadOnly Property RotaryMeterType As String
            Get
                Try
                    Return Items.Where(Function(x) x.Number = 432).SingleOrDefault.DescriptionValue
                Catch ex As Exception
                    Return Nothing
                End Try
            End Get
        End Property

#Region "Methods"


        Overloads Shared Function LoadInstrumentItems() As List(Of ItemClass)
            Return ItemClass.LoadInstrumentItems(My.Application.Info.DirectoryPath + "\MiniMaxItems.xml")
        End Function


#End Region


    End Class
End Namespace
