Imports Prover.Certificates.Data
Public Class CertificateReportViewer
    Dim certData As ICertificate
    Sub New(cert As ICertificate)
        InitializeComponent()
        certData = cert
        Me.Re()
    End Sub
End Class
