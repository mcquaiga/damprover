Imports Prover.Certificates.Data
Public Class CertificateReportViewer

    Dim _certificateObject As ICertificate

    Sub New(Certificate As ICertificate)

        ' This call is required by the designer.
        InitializeComponent()
        _certificateObject = Certificate
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub _reportViewer_Load(sender As Object, e As EventArgs) Handles _reportViewer.Load
        Dim reportDataSource1 = New Microsoft.Reporting.WinForms.ReportDataSource()
        reportDataSource1.Name = "CertificatesDataset"
        reportDataSource1.Value = _certificateObject

        _reportViewer.LocalReport.DataSources.Add(reportDataSource1)
    End Sub
End Class
