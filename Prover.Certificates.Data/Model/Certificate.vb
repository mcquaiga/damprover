Imports System.Xml

Public Class Certificate
    Implements ICertificate

    Dim CertInfoFilePath As String = My.Application.Info.DirectoryPath + "\CertificateInfo.xml"

    Sub New()
        DateCreated = Date.Now
        Number = GetNextCertificateNumber()
    End Sub

    Public Property Id As String Implements ICertificate.Id

    Public Property CreatedBy As String Implements ICertificate.CreatedBy

    Public Property VerificationType As String Implements ICertificate.VerificationType

    Public Property SealExpirationDate As String Implements ICertificate.SealExpirationDate

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
            Throw New Exception("Could not load certificate information.")
        End If


        Dim _xmlElement = XDocument.Load(CertInfoFilePath)
        _xmlElement.<CertificateInfo>.Elements("NextCertificateNumber").Value = Me.Number + 1
        _xmlElement.Save(CertInfoFilePath)

    End Sub

    Private Function CertFileExists() As Boolean
        If Not System.IO.File.Exists(CertInfoFilePath) Then
            System.IO.File.Create(CertInfoFilePath)
        End If

        Return True
    End Function

End Class
