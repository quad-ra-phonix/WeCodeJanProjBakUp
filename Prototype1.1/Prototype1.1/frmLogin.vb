Public Class frmLogin

    Private Sub LoginBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.LoginBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PrototypeBDDataSet)

    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PrototypeBDDataSet.Login' table. You can move, or remove it, as needed.
        Me.LoginTableAdapter.Fill(Me.PrototypeBDDataSet.Login)

    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Dim isOK As Boolean = False
        Dim un As String = txtUsername.Text
        Dim pw As String = txtPassword.Text

        isOK = CType(Me.LoginTableAdapter.verifyUser(un, pw), Integer) = 1
        If isOK Then
            LoginTimer.Enabled = True
            MessageBox.Show("Welcome To the Demo Application", "Demo Appliction Login", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            PictureBox1.Visible = True
        Else
            MsgBox("Invalid user name or password.")
        End If

    End Sub

    Private Sub LoginTimer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LoginTimer.Tick
        PictureBox1.Visible = False
        MainForm.Show()
        LoginTimer.Enabled = False
    End Sub
End Class