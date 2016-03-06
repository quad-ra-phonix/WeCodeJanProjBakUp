<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccPaymentForm
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
        Me.cboAccName = New System.Windows.Forms.ComboBox()
        Me.TblPaymentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrototypeBDDataSet = New Prototype1._1.PrototypeBDDataSet()
        Me.TblPaymentsTableAdapter = New Prototype1._1.PrototypeBDDataSetTableAdapters.tblPaymentsTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvPayments = New System.Windows.Forms.DataGridView()
        Me.PayIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatePaidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblPaymentsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AccNameBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AccNameTableAdapter = New Prototype1._1.PrototypeBDDataSetTableAdapters.AccNameTableAdapter()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.TblPaymentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrototypeBDDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPayments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPaymentsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccNameBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(506, 24)
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
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'cboAccName
        '
        Me.cboAccName.DataSource = Me.AccNameBindingSource
        Me.cboAccName.DisplayMember = "Name"
        Me.cboAccName.FormattingEnabled = True
        Me.cboAccName.Location = New System.Drawing.Point(12, 62)
        Me.cboAccName.Name = "cboAccName"
        Me.cboAccName.Size = New System.Drawing.Size(121, 21)
        Me.cboAccName.TabIndex = 1
        Me.cboAccName.ValueMember = "Acc_ID"
        '
        'TblPaymentsBindingSource
        '
        Me.TblPaymentsBindingSource.DataMember = "tblPayments"
        Me.TblPaymentsBindingSource.DataSource = Me.PrototypeBDDataSet
        '
        'PrototypeBDDataSet
        '
        Me.PrototypeBDDataSet.DataSetName = "PrototypeBDDataSet"
        Me.PrototypeBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblPaymentsTableAdapter
        '
        Me.TblPaymentsTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Select an Account "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Payment Histroy"
        '
        'dgvPayments
        '
        Me.dgvPayments.AllowUserToAddRows = False
        Me.dgvPayments.AllowUserToDeleteRows = False
        Me.dgvPayments.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPayments.AutoGenerateColumns = False
        Me.dgvPayments.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvPayments.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPayments.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PayIDDataGridViewTextBoxColumn, Me.FullNameDataGridViewTextBoxColumn, Me.DatePaidDataGridViewTextBoxColumn, Me.AmountDataGridViewTextBoxColumn})
        Me.dgvPayments.DataSource = Me.TblPaymentsBindingSource1
        Me.dgvPayments.Location = New System.Drawing.Point(12, 115)
        Me.dgvPayments.Name = "dgvPayments"
        Me.dgvPayments.ReadOnly = True
        Me.dgvPayments.RowHeadersVisible = False
        Me.dgvPayments.Size = New System.Drawing.Size(482, 214)
        Me.dgvPayments.TabIndex = 4
        '
        'PayIDDataGridViewTextBoxColumn
        '
        Me.PayIDDataGridViewTextBoxColumn.DataPropertyName = "Pay_ID"
        Me.PayIDDataGridViewTextBoxColumn.HeaderText = "Pay_ID"
        Me.PayIDDataGridViewTextBoxColumn.Name = "PayIDDataGridViewTextBoxColumn"
        Me.PayIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FullNameDataGridViewTextBoxColumn
        '
        Me.FullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName"
        Me.FullNameDataGridViewTextBoxColumn.HeaderText = "FullName"
        Me.FullNameDataGridViewTextBoxColumn.Name = "FullNameDataGridViewTextBoxColumn"
        Me.FullNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DatePaidDataGridViewTextBoxColumn
        '
        Me.DatePaidDataGridViewTextBoxColumn.DataPropertyName = "Date_Paid"
        Me.DatePaidDataGridViewTextBoxColumn.HeaderText = "Date_Paid"
        Me.DatePaidDataGridViewTextBoxColumn.Name = "DatePaidDataGridViewTextBoxColumn"
        Me.DatePaidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AmountDataGridViewTextBoxColumn
        '
        Me.AmountDataGridViewTextBoxColumn.DataPropertyName = "Amount"
        Me.AmountDataGridViewTextBoxColumn.HeaderText = "Amount"
        Me.AmountDataGridViewTextBoxColumn.Name = "AmountDataGridViewTextBoxColumn"
        Me.AmountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TblPaymentsBindingSource1
        '
        Me.TblPaymentsBindingSource1.DataMember = "tblPayments"
        Me.TblPaymentsBindingSource1.DataSource = Me.PrototypeBDDataSet
        '
        'AccNameBindingSource
        '
        Me.AccNameBindingSource.DataMember = "AccName"
        Me.AccNameBindingSource.DataSource = Me.PrototypeBDDataSet
        '
        'AccNameTableAdapter
        '
        Me.AccNameTableAdapter.ClearBeforeFill = True
        '
        'AccPaymentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 371)
        Me.Controls.Add(Me.dgvPayments)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboAccName)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimizeBox = False
        Me.Name = "AccPaymentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Single Account Payment"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.TblPaymentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrototypeBDDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPayments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPaymentsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccNameBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cboAccName As System.Windows.Forms.ComboBox
    Friend WithEvents PrototypeBDDataSet As Prototype1._1.PrototypeBDDataSet
    Friend WithEvents TblPaymentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblPaymentsTableAdapter As Prototype1._1.PrototypeBDDataSetTableAdapters.tblPaymentsTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvPayments As System.Windows.Forms.DataGridView
    Friend WithEvents PayIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FullNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatePaidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TblPaymentsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents AccNameBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AccNameTableAdapter As Prototype1._1.PrototypeBDDataSetTableAdapters.AccNameTableAdapter
End Class
