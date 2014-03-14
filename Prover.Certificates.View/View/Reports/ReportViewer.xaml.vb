Public Class ReportViewer

    Public _data As Object

    Sub New(Data As Object)
        InitializeComponent()
    End Sub

    Private Sub UserControl_Loaded(sender As Object, e As RoutedEventArgs) Handles reportViewer.Load

        reportViewer.Show()
        reportViewer.LocalReport.ReportPath = "Certificate.rdlc"
        reportViewer.LocalReport.DataSources.Clear()

        reportViewer.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Instruments", _data.Instruments))

    End Sub


    Private Sub reportViewer_RenderingComplete(sender As Object, e As Microsoft.Reporting.WinForms.RenderingCompleteEventArgs) Handles reportViewer.RenderingComplete

    End Sub

End Class
