Public Class Certificate
    Implements ICertificate


    Public Property CreatedBy As String Implements ICertificate.CreatedBy

    Public Property DateCreated As Date Implements ICertificate.DateCreated

    Public Property ID As Integer Implements ICertificate.ID

    Public Property Instruments As List(Of IBaseInstrument) Implements ICertificate.Instruments
End Class
