Imports Prover.Instruments.Data

Public Interface ICertificate

    Property Number As Integer
    Property DateCreated As DateTime
    Property CreatedBy As String


    Property Instruments As List(Of IBaseInstrument)

End Interface
