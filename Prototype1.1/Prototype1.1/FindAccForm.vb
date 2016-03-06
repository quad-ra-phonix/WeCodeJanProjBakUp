Public Class FindAccForm

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        If rBtnID.Checked Then
            'perform a search using ID number as parameter
            Me.TblAccTableAdapter.FindAccID(PrototypeBDDataSet.tblAcc, txtNum.Text)
        ElseIf rBtnRef.Checked Then
            'perform a search using Ref number as parameter
            Me.TblAccTableAdapter.FindAccRef(PrototypeBDDataSet.tblAcc, txtNum.Text)
        End If
    End Sub

    Private Sub FindAccForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PrototypeBDDataSet.tblAcc' table. You can move, or remove it, as needed.


    End Sub
End Class