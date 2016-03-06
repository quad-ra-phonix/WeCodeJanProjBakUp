<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MembershipToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FindMemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewMemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OneMemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertPaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OutstandingReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(57, 54)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(390, 115)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(12, 16)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(360, 80)
        Me.Panel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(335, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Demo Applicaiton"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(254, 194)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Management System 1.0"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.MembershipToolStripMenuItem, Me.PaymentsToolStripMenuItem, Me.ReportsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(514, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(91, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'MembershipToolStripMenuItem
        '
        Me.MembershipToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListAllToolStripMenuItem, Me.FindMemberToolStripMenuItem, Me.AddNewMemberToolStripMenuItem})
        Me.MembershipToolStripMenuItem.Name = "MembershipToolStripMenuItem"
        Me.MembershipToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.MembershipToolStripMenuItem.Text = "&Accounts"
        '
        'ListAllToolStripMenuItem
        '
        Me.ListAllToolStripMenuItem.Name = "ListAllToolStripMenuItem"
        Me.ListAllToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.ListAllToolStripMenuItem.Text = "&List All"
        '
        'FindMemberToolStripMenuItem
        '
        Me.FindMemberToolStripMenuItem.Name = "FindMemberToolStripMenuItem"
        Me.FindMemberToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.FindMemberToolStripMenuItem.Text = "&Find Account"
        '
        'AddNewMemberToolStripMenuItem
        '
        Me.AddNewMemberToolStripMenuItem.Name = "AddNewMemberToolStripMenuItem"
        Me.AddNewMemberToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.AddNewMemberToolStripMenuItem.Text = "&Add New Account"
        '
        'PaymentsToolStripMenuItem
        '
        Me.PaymentsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllToolStripMenuItem, Me.OneMemberToolStripMenuItem, Me.InsertPaymentToolStripMenuItem})
        Me.PaymentsToolStripMenuItem.Name = "PaymentsToolStripMenuItem"
        Me.PaymentsToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.PaymentsToolStripMenuItem.Text = "&Payments"
        '
        'AllToolStripMenuItem
        '
        Me.AllToolStripMenuItem.Name = "AllToolStripMenuItem"
        Me.AllToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.AllToolStripMenuItem.Text = "&All"
        '
        'OneMemberToolStripMenuItem
        '
        Me.OneMemberToolStripMenuItem.Name = "OneMemberToolStripMenuItem"
        Me.OneMemberToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.OneMemberToolStripMenuItem.Text = "&One Member"
        '
        'InsertPaymentToolStripMenuItem
        '
        Me.InsertPaymentToolStripMenuItem.Name = "InsertPaymentToolStripMenuItem"
        Me.InsertPaymentToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.InsertPaymentToolStripMenuItem.Text = "Add New &Payment"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PaymentReportToolStripMenuItem, Me.OutstandingReportToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.ReportsToolStripMenuItem.Text = "&Reports"
        '
        'PaymentReportToolStripMenuItem
        '
        Me.PaymentReportToolStripMenuItem.Name = "PaymentReportToolStripMenuItem"
        Me.PaymentReportToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.PaymentReportToolStripMenuItem.Text = "&Payment Report"
        '
        'OutstandingReportToolStripMenuItem
        '
        Me.OutstandingReportToolStripMenuItem.Name = "OutstandingReportToolStripMenuItem"
        Me.OutstandingReportToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.OutstandingReportToolStripMenuItem.Text = "&Outstanding Report"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 236)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Demo Application"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MembershipToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FindMemberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewMemberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PaymentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OneMemberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InsertPaymentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PaymentReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OutstandingReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
