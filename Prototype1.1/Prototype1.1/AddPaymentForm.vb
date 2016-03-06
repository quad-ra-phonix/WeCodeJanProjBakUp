Public Class AddPaymentForm

    Private Sub AddPaymentForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PrototypeBDDataSet.tblPayment' table. You can move, or remove it, as needed.
        Me.TblPaymentTableAdapter.Fill(Me.PrototypeBDDataSet.tblPayment)
        'TODO: This line of code loads data into the 'PrototypeBDDataSet.tblAcc' table. You can move, or remove it, as needed.
        Me.TblAccTableAdapter.Fill(Me.PrototypeBDDataSet.tblAcc)
        Label1.Visible = False
        Label2.Visible = False
        lsbID.Visible = False
        lsbRef.Visible = False
        'Set the text box to today's date.
        mTxtDate.Text = FormatDateTime(Today, DateFormat.ShortDate)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub rBtnID_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rBtnID.CheckedChanged
        Label1.Visible = True
        lsbID.Visible = True
        Label2.Visible = False
        lsbRef.Visible = False
    End Sub

    Private Sub rBtnRef_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rBtnRef.CheckedChanged
        Label2.Visible = True
        lsbRef.Visible = True
        Label1.Visible = False
        lsbID.Visible = False
    End Sub

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        Dim AccID As Integer
        AccID = CInt(Acc_IDLabel1.Text)
        Try
            TblPaymentTableAdapter.Insert(AccID, CDec(txtAmount.Text), CDate(mTxtDate.Text))
            Me.TblPaymentTableAdapter.Fill(Me.PrototypeBDDataSet.tblPayment)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database Error")
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Dim searchString As String
        searchString = txtSearch.Text

        If rBtnID.Checked Then
            ' Ensure we have a proper string to search for.
            If searchString <> String.Empty Then
                ' Find the item in the list and store the index to the item.
                Dim index As Integer = lsbID.FindString(searchString)
                ' Determine if a valid index is returned. Select the item if it is valid.
                If index <> -1 Then
                    lsbID.SetSelected(index, True)
                Else
                    MessageBox.Show("The search string did not match any items in the ListBox")
                End If
            End If
        ElseIf rBtnRef.Checked Then
            ' Ensure we have a proper string to search for.
            If searchString <> String.Empty Then
                ' Find the item in the list and store the index to the item.
                Dim index As Integer = lsbRef.FindString(searchString)
                ' Determine if a valid index is returned. Select the item if it is valid.
                If index <> -1 Then
                    lsbRef.SetSelected(index, True)
                Else
                    MessageBox.Show("The search string did not match any items in the ListBox")
                End If
            End If
        End If
       

    End Sub
End Class