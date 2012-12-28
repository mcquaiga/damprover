Public Class ICReportForm

    Public inspectionID As Integer = 0
    Dim crw As New CrystalDecisions.CrystalReports.Engine.ReportDocument
    Dim dsExport As ExportToDataSetClass
    Dim ds As ICDataSet
    Dim filePath As String = My.Settings.ICLocation

    Private Sub ICReportForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        crw.Dispose()
        ds.Dispose()

    End Sub


    Private Sub ICReportForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'crw.FileName = Application.StartupPath & "Reports\CRWIC_trial.rpt"
        crw.Load(filePath, CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
        dsExport = New ExportToDataSetClass(inspectionID)
        ds = New ICDataSet
        'crw = New CRWIC_trial

        dsExport.FillDataSet(ds)
        crw.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = crw

        dsExport = Nothing
    End Sub
End Class