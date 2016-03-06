Public Class AccPaymentForm

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AccPaymentForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PrototypeBDDataSet.AccName' table. You can move, or remove it, as needed.
        Me.AccNameTableAdapter.Fill(Me.PrototypeBDDataSet.AccName)
        'TODO: This line of code loads data into the 'PrototypeBDDataSet.tblPayments' table. You can move, or remove it, as needed.
        Me.TblPaymentsTableAdapter.AllPayment(Me.PrototypeBDDataSet.tblPayments)

    End Sub

    Private Sub cboAccName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAccName.SelectedIndexChanged
        If cboAccName.SelectedIndex = -1 Then Exit Sub
        'Get the Acc_ID value associated with the selected Account
        Dim Acc_ID As Integer = CInt(cboAccName.SelectedValue)
        'Fill the payments grid, passing it the Account ID.
        TblPaymentsTableAdapter.AccPayments(PrototypeBDDataSet.tblPayments, Acc_ID)
    End Sub
End Class