<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AllAccountsForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TblAccTableAdapter = New Prototype1._1.PrototypeBDDataSetTableAdapters.tblAccTableAdapter()
        CType(Me.dgvAccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblAccBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrototypeBDDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvAccounts
        '
        Me.dgvAccounts.AllowUserToAddRows = False
        Me.dgvAccounts.AutoGenerateColumns = False
        Me.dgvAccounts.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvAccounts.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAccounts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AccIDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.SurnameDataGridViewTextBoxColumn, Me.IDnoDataGridViewTextBoxColumn, Me.RefRAFDataGridViewTextBoxColumn, Me.RefnoDataGridViewTextBoxColumn, Me.BalDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn})
        Me.dgvAccounts.DataSource = Me.TblAccBindingSource
        Me.dgvAccounts.Location = New System.Drawing.Point(10, 37)
        Me.dgvAccounts.Name = "dgvAccounts"
        Me.dgvAccounts.RowHeadersVisible = False
        Me.dgvAccounts.Size = New System.Drawing.Size(807, 302)
        Me.dgvAccounts.TabIndex = 0
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
        '
        'SurnameDataGridViewTextBoxColumn
        '
        Me.SurnameDataGridViewTextBoxColumn.DataPropertyName = "Surname"
        Me.SurnameDataGridViewTextBoxColumn.HeaderText = "Surname"
        Me.SurnameDataGridViewTextBoxColumn.Name = "SurnameDataGridViewTextBoxColumn"
        '
        'IDnoDataGridViewTextBoxColumn
        '
        Me.IDnoDataGridViewTextBoxColumn.DataPropertyName = "ID_no"
        Me.IDnoDataGridViewTextBoxColumn.HeaderText = "ID_no"
        Me.IDnoDataGridViewTextBoxColumn.Name = "IDnoDataGridViewTextBoxColumn"
        '
        'RefRAFDataGridViewTextBoxColumn
        '
        Me.RefRAFDataGridViewTextBoxColumn.DataPropertyName = "Ref_RAF"
        Me.RefRAFDataGridViewTextBoxColumn.HeaderText = "Ref_RAF"
        Me.RefRAFDataGridViewTextBoxColumn.Name = "RefRAFDataGridViewTextBoxColumn"
        '
        'RefnoDataGridViewTextBoxColumn
        '
        Me.RefnoDataGridViewTextBoxColumn.DataPropertyName = "Ref_no"
        Me.RefnoDataGridViewTextBoxColumn.HeaderText = "Ref_no"
        Me.RefnoDataGridViewTextBoxColumn.Name = "RefnoDataGridViewTextBoxColumn"
        '
        'BalDataGridViewTextBoxColumn
        '
        Me.BalDataGridViewTextBoxColumn.DataPropertyName = "Bal"
        Me.BalDataGridViewTextBoxColumn.HeaderText = "Bal"
        Me.BalDataGridViewTextBoxColumn.Name = "BalDataGridViewTextBoxColumn"
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
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
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(829, 24)
        Me.MenuStrip1.TabIndex = 1
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
        'TblAccTableAdapter
        '
        Me.TblAccTableAdapter.ClearBeforeFill = True
        '
        'AllAccountsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 375)
        Me.Controls.Add(Me.dgvAccounts)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AllAccountsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "All Accounts"
        CType(Me.dgvAccounts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblAccBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrototypeBDDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvAccounts As System.Windows.Forms.DataGridView
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
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
