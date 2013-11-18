Imports Raven.Client.Indexes
Imports Prover.Instruments.Data

Public Class Instruments_BySerialNumber
    Inherits AbstractMultiMapIndexCreationTask(Of Instruments_BySerialNumber.Result)

    Public Class Result
        Public Property Content As Object()
    End Class

    Sub New()
        'Me.AddMap(Of IBaseInstrument)(Function(minis) From mini In minis
        '                                 Select New With {.SerialNumber = mini.SerialNumber}())
    End Sub
End Class

Public Class Instruments_MiniMax
    Inherits AbstractIndexCreationTask(Of MiniMaxInstrument)

    Sub New()
        Me.Map = Function(docs) From doc In docs
                        Select New With {doc.SerialNumber}

    End Sub
End Class