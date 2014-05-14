Imports Prover.Instruments.Data

Public Interface ICertificate

    Property Id As String
    Property Number As Integer
    Property DateCreated As DateTime
    Property CreatedBy As String


    Property Instruments As List(Of IBaseInstrument)

    Property VerificationType As String

    Property SealExpirationDate As String

End Interface
