Imports Prover.Instruments.Data

Public Interface ICertificate

    Property ID As Integer
    Property DateCreated As DateTime
    Property CreatedBy As String


    Property Instruments As List(Of IBaseInstrument)

End Interface
