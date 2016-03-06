Public Class AddAccountForm

    Private Sub AddAccountForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        TblAccBindingSource.CancelEdit()
    End Sub


    Private Sub AddAccountForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PrototypeBDDataSet.tblAcc' table. You can move, or remove it, as needed.
        TblAccBindingSource.AddNew()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            TblAccBindingSource.EndEdit()
            TblAccTableAdapter.Update(PrototypeBDDataSet.tblAcc)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub
End Class