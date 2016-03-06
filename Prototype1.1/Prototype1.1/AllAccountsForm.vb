Public Class AllAccountsForm

    Private Sub AllAccountsForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PrototypeBDDataSet.tblAcc' table. You can move, or remove it, as needed.
        Me.TblAccTableAdapter.Fill(Me.PrototypeBDDataSet.tblAcc)

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class