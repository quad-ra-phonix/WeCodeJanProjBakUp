Public Class ReportForm

    Private Sub ReportForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PrototypeBDDataSet.ReportData' table. You can move, or remove it, as needed.
        Me.ReportDataTableAdapter.ReportData(Me.PrototypeBDDataSet.ReportData)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub dtpStartDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpStartDate.ValueChanged

    End Sub

    Private Sub dtpEndDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpEndDate.ValueChanged

    End Sub
End Class