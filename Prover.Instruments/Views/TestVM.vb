Imports Prover.Instruments.Data

Public Class TestVM

    Public Property Instrument As IBaseInstrument

    Sub New()
        Instrument = New MiniMaxInstrument()
    End Sub

End Class
