Public Class MainForm

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ListAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListAllToolStripMenuItem.Click
        AllAccountsForm.ShowDialog()
    End Sub

    Private Sub AddNewMemberToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles AddNewMemberToolStripMenuItem.Click
        AddAccountForm.ShowDialog()
    End Sub

    Private Sub FindMemberToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindMemberToolStripMenuItem.Click
        FindAccForm.ShowDialog()
    End Sub

    Private Sub AllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllToolStripMenuItem.Click
        AllPaymentsForm.ShowDialog()
    End Sub

    Private Sub OneMemberToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OneMemberToolStripMenuItem.Click
        AccPaymentForm.ShowDialog()
    End Sub

    Private Sub InsertPaymentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertPaymentToolStripMenuItem.Click
        AddPaymentForm.Show()
    End Sub

    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        frmLogin.Visible = False
    End Sub

    Private Sub PaymentReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentReportToolStripMenuItem.Click
        ReportForm.ShowDialog()
    End Sub

    Private Sub OutstandingReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OutstandingReportToolStripMenuItem.Click
        rptPaymentByMonthForm.ShowDialog()
    End Sub
End Class
