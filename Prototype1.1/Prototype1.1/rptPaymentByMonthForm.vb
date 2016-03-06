Imports Microsoft.Reporting.WinForms
Public Class rptPaymentByMonthForm
    Private Sub dtpStartDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpStartDate.ValueChanged
        setFilterParameters()
    End Sub

    Private Sub dtpEndDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpEndDate.ValueChanged
        setFilterParameters()
    End Sub

    Private Sub setFilterParameters()
        Me.ReportDataTableAdapter.ReportData(Me.PrototypeBDDataSet.ReportData)

        Dim startDate As New ReportParameter("startDate", dtpStartDate.Value)
        Dim endDate As New ReportParameter("endDate", dtpEndDate.Value)

        ReportViewer1.LocalReport.SetParameters(New ReportParameter() {startDate, endDate})
        ReportViewer1.RefreshReport()

    End Sub

    Private Sub rptPaymentByMonthForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PrototypeBDDataSet.ReportData' table. You can move, or remove it, as needed.
        Me.ReportDataTableAdapter.ReportData(Me.PrototypeBDDataSet.ReportData)

    End Sub
End Class