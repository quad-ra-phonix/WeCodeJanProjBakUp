<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FindAccForm
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.rBtnID = New System.Windows.Forms.RadioButton()
        Me.rBtnRef = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.dgvAccounts = New System.Windows.Forms.DataGridView()
        Me.AccIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SurnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RefRAFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RefnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblAccBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrototypeBDDataSet = New Prototype1._1.PrototypeBDDataSet()
        Me.TblAccTableAdapter = New Prototype1._1.PrototypeBDDataSetTableAdapters.tblAccTableAdapter()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvAccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblAccBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrototypeBDDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(841, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'rBtnID
        '
        Me.rBtnID.AutoSize = True
        Me.rBtnID.Location = New System.Drawing.Point(6, 19)
        Me.rBtnID.Name = "rBtnID"
        Me.rBtnID.Size = New System.Drawing.Size(54, 17)
        Me.rBtnID.TabIndex = 1
        Me.rBtnID.TabStop = True
        Me.rBtnID.Text = "ID no."
        Me.rBtnID.UseVisualStyleBackColor = True
        '
        'rBtnRef
        '
        Me.rBtnRef.AutoSize = True
        Me.rBtnRef.Location = New System.Drawing.Point(128, 19)
        Me.rBtnRef.Name = "rBtnRef"
        Me.rBtnRef.Size = New System.Drawing.Size(60, 17)
        Me.rBtnRef.TabIndex = 2
        Me.rBtnRef.TabStop = True
        Me.rBtnRef.Text = "Ref no."
        Me.rBtnRef.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rBtnID)
        Me.GroupBox1.Controls.Add(Me.rBtnRef)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(247, 53)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search By:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(321, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Enter no."
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(420, 52)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(145, 20)
        Me.txtNum.TabIndex = 5
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(619, 52)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(75, 23)
        Me.btnGo.TabIndex = 6
        Me.btnGo.Text = "&Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'dgvAccounts
        '
        Me.dgvAccounts.AllowUserToAddRows = False
        Me.dgvAccounts.AllowUserToDeleteRows = False
        Me.dgvAccounts.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvAccounts.AutoGenerateColumns = False
        Me.dgvAccounts.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvAccounts.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAccounts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AccIDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.SurnameDataGridViewTextBoxColumn, Me.IDnoDataGridViewTextBoxColumn, Me.RefRAFDataGridViewTextBoxColumn, Me.RefnoDataGridViewTextBoxColumn, Me.BalDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn})
        Me.dgvAccounts.DataSource = Me.TblAccBindingSource
        Me.dgvAccounts.Location = New System.Drawing.Point(18, 106)
        Me.dgvAccounts.Name = "dgvAccounts"
        Me.dgvAccounts.ReadOnly = True
        Me.dgvAccounts.RowHeadersVisible = False
        Me.dgvAccounts.Size = New System.Drawing.Size(804, 127)
        Me.dgvAccounts.TabIndex = 7
        '
        'AccIDDataGridViewTextBoxColumn
        '
        Me.AccIDDataGridViewTextBoxColumn.DataPropertyName = "Acc_ID"
        Me.AccIDDataGridViewTextBoxColumn.HeaderText = "Acc_ID"
        Me.AccIDDataGridViewTextBoxColumn.Name = "AccIDDataGridViewTextBoxColumn"
        Me.AccIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SurnameDataGridViewTextBoxColumn
        '
        Me.SurnameDataGridViewTextBoxColumn.DataPropertyName = "Surname"
        Me.SurnameDataGridViewTextBoxColumn.HeaderText = "Surname"
        Me.SurnameDataGridViewTextBoxColumn.Name = "SurnameDataGridViewTextBoxColumn"
        Me.SurnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IDnoDataGridViewTextBoxColumn
        '
        Me.IDnoDataGridViewTextBoxColumn.DataPropertyName = "ID_no"
        Me.IDnoDataGridViewTextBoxColumn.HeaderText = "ID_no"
        Me.IDnoDataGridViewTextBoxColumn.Name = "IDnoDataGridViewTextBoxColumn"
        Me.IDnoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RefRAFDataGridViewTextBoxColumn
        '
        Me.RefRAFDataGridViewTextBoxColumn.DataPropertyName = "Ref_RAF"
        Me.RefRAFDataGridViewTextBoxColumn.HeaderText = "Ref_RAF"
        Me.RefRAFDataGridViewTextBoxColumn.Name = "RefRAFDataGridViewTextBoxColumn"
        Me.RefRAFDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RefnoDataGridViewTextBoxColumn
        '
        Me.RefnoDataGridViewTextBoxColumn.DataPropertyName = "Ref_no"
        Me.RefnoDataGridViewTextBoxColumn.HeaderText = "Ref_no"
        Me.RefnoDataGridViewTextBoxColumn.Name = "RefnoDataGridViewTextBoxColumn"
        Me.RefnoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BalDataGridViewTextBoxColumn
        '
        Me.BalDataGridViewTextBoxColumn.DataPropertyName = "Bal"
        Me.BalDataGridViewTextBoxColumn.HeaderText = "Bal"
        Me.BalDataGridViewTextBoxColumn.Name = "BalDataGridViewTextBoxColumn"
        Me.BalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        Me.TotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TblAccBindingSource
        '
        Me.TblAccBindingSource.DataMember = "tblAcc"
        Me.TblAccBindingSource.DataSource = Me.PrototypeBDDataSet
        '
        'PrototypeBDDataSet
        '
        Me.PrototypeBDDataSet.DataSetName = "PrototypeBDDataSet"
        Me.PrototypeBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblAccTableAdapter
        '
        Me.TblAccTableAdapter.ClearBeforeFill = True
        '
        'FindAccForm
        '
        Me.AcceptButton = Me.btnGo
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 245)
        Me.Controls.Add(Me.dgvAccounts)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimizeBox = False
        Me.Name = "FindAccForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Find Account"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvAccounts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblAccBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrototypeBDDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rBtnID As System.Windows.Forms.RadioButton
    Friend WithEvents rBtnRef As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNum As System.Windows.Forms.TextBox
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents dgvAccounts As System.Windows.Forms.DataGridView
    Friend WithEvents PrototypeBDDataSet As Prototype1._1.PrototypeBDDataSet
    Friend WithEvents TblAccBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblAccTableAdapter As Prototype1._1.PrototypeBDDataSetTableAdapters.tblAccTableAdapter
    Friend WithEvents AccIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SurnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RefRAFDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RefnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
