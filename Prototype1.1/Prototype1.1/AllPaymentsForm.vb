Public Class AllPaymentsForm

    Private Sub AllPaymentsForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PrototypeBDDataSet.tblPayments' table. You can move, or remove it, as needed.
        Me.TblPaymentsTableAdapter.AllPayment(Me.PrototypeBDDataSet.tblPayments)

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ViewPaymentReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ReportForm.ShowDialog()
    End Sub

    Private Sub FilterByMonthToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        rptPaymentByMonthForm.ShowDialog()
    End Sub
End Class