Imports System.Xml

Public Class Certificate
    Implements ICertificate

    Dim CertInfoFilePath As String = My.Application.Info.DirectoryPath + "\CertificateInfo.xml"

    Sub New()
        DateCreated = Date.Now
        Number = GetNextCertificateNumber()
    End Sub

    Public Property CreatedBy As String Implements ICertificate.CreatedBy

    Public Property DateCreated As Date Implements ICertificate.DateCreated

    Public Property Number As Integer Implements ICertificate.Number

    Public Property Instruments As List(Of IBaseInstrument) Implements ICertificate.Instruments

    Public Function GetNextCertificateNumber() As Integer
        If CertInfoFilePath Is Nothing OrElse CertInfoFilePath = "" Then
            Throw New Exception("Could not load instrument items.")
        End If

        Dim _xmlElement = XDocument.Load(CertInfoFilePath)
        Return _xmlElement.<CertificateInfo>.Elements("NextCertificateNumber").Value
    End Function

    Public Sub SetNextCertificateNumber()
        If CertInfoFilePath Is Nothing OrElse CertInfoFilePath = "" Then
            Throw New Exception("Could not load instrument items.")
        End If


        Dim _xmlElement = XDocument.Load(CertInfoFilePath)
        _xmlElement.<CertificateInfo>.Elements("NextCertificateNumber").Value = Me.Number + 1
        _xmlElement.Save(CertInfoFilePath)

    End Sub
End Class
