<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPaymentForm
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
        Dim Acc_IDLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim SurnameLabel As System.Windows.Forms.Label
        Me.lsbID = New System.Windows.Forms.ListBox()
        Me.TblAccBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrototypeBDDataSet = New Prototype1._1.PrototypeBDDataSet()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SurnameLabel1 = New System.Windows.Forms.Label()
        Me.NameLabel1 = New System.Windows.Forms.Label()
        Me.Acc_IDLabel1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lsbRef = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rBtnRef = New System.Windows.Forms.RadioButton()
        Me.rBtnID = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TblAccTableAdapter = New Prototype1._1.PrototypeBDDataSetTableAdapters.tblAccTableAdapter()
        Me.TableAdapterManager = New Prototype1._1.PrototypeBDDataSetTableAdapters.TableAdapterManager()
        Me.TblPaymentTableAdapter = New Prototype1._1.PrototypeBDDataSetTableAdapters.tblPaymentTableAdapter()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.mTxtDate = New System.Windows.Forms.MaskedTextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.dgvPayment = New System.Windows.Forms.DataGridView()
        Me.Acc_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatePaidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblPaymentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Acc_IDLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        SurnameLabel = New System.Windows.Forms.Label()
        CType(Me.TblAccBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrototypeBDDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvPayment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPaymentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Acc_IDLabel
        '
        Acc_IDLabel.AutoSize = True
        Acc_IDLabel.Location = New System.Drawing.Point(141, 99)
        Acc_IDLabel.Name = "Acc_IDLabel"
        Acc_IDLabel.Size = New System.Drawing.Size(43, 13)
        Acc_IDLabel.TabIndex = 5
        Acc_IDLabel.Text = "Acc ID:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(141, 123)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 7
        NameLabel.Text = "Name:"
        '
        'SurnameLabel
        '
        SurnameLabel.AutoSize = True
        SurnameLabel.Location = New System.Drawing.Point(141, 146)
        SurnameLabel.Name = "SurnameLabel"
        SurnameLabel.Size = New System.Drawing.Size(52, 13)
        SurnameLabel.TabIndex = 9
        SurnameLabel.Text = "Surname:"
        '
        'lsbID
        '
        Me.lsbID.DataSource = Me.TblAccBindingSource
        Me.lsbID.DisplayMember = "ID_no"
        Me.lsbID.FormattingEnabled = True
        Me.lsbID.Location = New System.Drawing.Point(15, 99)
        Me.lsbID.Name = "lsbID"
        Me.lsbID.Size = New System.Drawing.Size(120, 160)
        Me.lsbID.TabIndex = 0
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Controls.Add(SurnameLabel)
        Me.GroupBox1.Controls.Add(Me.SurnameLabel1)
        Me.GroupBox1.Controls.Add(NameLabel)
        Me.GroupBox1.Controls.Add(Me.NameLabel1)
        Me.GroupBox1.Controls.Add(Acc_IDLabel)
        Me.GroupBox1.Controls.Add(Me.Acc_IDLabel1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lsbRef)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lsbID)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(305, 279)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Account Information"
        '
        'SurnameLabel1
        '
        Me.SurnameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblAccBindingSource, "Surname", True))
        Me.SurnameLabel1.Location = New System.Drawing.Point(199, 146)
        Me.SurnameLabel1.Name = "SurnameLabel1"
        Me.SurnameLabel1.Size = New System.Drawing.Size(100, 23)
        Me.SurnameLabel1.TabIndex = 10
        Me.SurnameLabel1.Text = "Label3"
        '
        'NameLabel1
        '
        Me.NameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblAccBindingSource, "Name", True))
        Me.NameLabel1.Location = New System.Drawing.Point(199, 123)
        Me.NameLabel1.Name = "NameLabel1"
        Me.NameLabel1.Size = New System.Drawing.Size(100, 23)
        Me.NameLabel1.TabIndex = 8
        Me.NameLabel1.Text = "Label3"
        '
        'Acc_IDLabel1
        '
        Me.Acc_IDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblAccBindingSource, "Acc_ID", True))
        Me.Acc_IDLabel1.Location = New System.Drawing.Point(199, 99)
        Me.Acc_IDLabel1.Name = "Acc_IDLabel1"
        Me.Acc_IDLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Acc_IDLabel1.TabIndex = 6
        Me.Acc_IDLabel1.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Ref no. List"
        '
        'lsbRef
        '
        Me.lsbRef.DataSource = Me.TblAccBindingSource
        Me.lsbRef.DisplayMember = "Ref_no"
        Me.lsbRef.FormattingEnabled = True
        Me.lsbRef.Location = New System.Drawing.Point(15, 99)
        Me.lsbRef.Name = "lsbRef"
        Me.lsbRef.Size = New System.Drawing.Size(120, 160)
        Me.lsbRef.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rBtnRef)
        Me.GroupBox2.Controls.Add(Me.rBtnID)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(238, 44)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Select Criterion"
        '
        'rBtnRef
        '
        Me.rBtnRef.AutoSize = True
        Me.rBtnRef.Location = New System.Drawing.Point(119, 19)
        Me.rBtnRef.Name = "rBtnRef"
        Me.rBtnRef.Size = New System.Drawing.Size(80, 17)
        Me.rBtnRef.TabIndex = 1
        Me.rBtnRef.TabStop = True
        Me.rBtnRef.Text = "Ref number"
        Me.rBtnRef.UseVisualStyleBackColor = True
        '
        'rBtnID
        '
        Me.rBtnID.AutoSize = True
        Me.rBtnID.Location = New System.Drawing.Point(7, 20)
        Me.rBtnID.Name = "rBtnID"
        Me.rBtnID.Size = New System.Drawing.Size(77, 17)
        Me.rBtnID.TabIndex = 0
        Me.rBtnID.TabStop = True
        Me.rBtnID.Text = "I.D number"
        Me.rBtnID.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID List"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(676, 24)
        Me.MenuStrip1.TabIndex = 2
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblAccTableAdapter = Me.TblAccTableAdapter
        Me.TableAdapterManager.tblPaymentTableAdapter = Me.TblPaymentTableAdapter
        Me.TableAdapterManager.UpdateOrder = Prototype1._1.PrototypeBDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblPaymentTableAdapter
        '
        Me.TblPaymentTableAdapter.ClearBeforeFill = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnInsert)
        Me.GroupBox3.Controls.Add(Me.mTxtDate)
        Me.GroupBox3.Controls.Add(Me.txtAmount)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.lblAmount)
        Me.GroupBox3.Location = New System.Drawing.Point(323, 27)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(302, 146)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Payment Information"
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(105, 112)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(75, 23)
        Me.btnInsert.TabIndex = 5
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'mTxtDate
        '
        Me.mTxtDate.Location = New System.Drawing.Point(105, 72)
        Me.mTxtDate.Mask = "0000/00/00"
        Me.mTxtDate.Name = "mTxtDate"
        Me.mTxtDate.Size = New System.Drawing.Size(100, 20)
        Me.mTxtDate.TabIndex = 4
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(105, 24)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtAmount.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Date Paid"
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(6, 32)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(43, 13)
        Me.lblAmount.TabIndex = 1
        Me.lblAmount.Text = "Amount"
        '
        'dgvPayment
        '
        Me.dgvPayment.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPayment.AutoGenerateColumns = False
        Me.dgvPayment.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvPayment.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPayment.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Acc_ID, Me.AmountDataGridViewTextBoxColumn, Me.DatePaidDataGridViewTextBoxColumn})
        Me.dgvPayment.DataSource = Me.TblPaymentBindingSource
        Me.dgvPayment.Location = New System.Drawing.Point(323, 179)
        Me.dgvPayment.Name = "dgvPayment"
        Me.dgvPayment.ReadOnly = True
        Me.dgvPayment.RowHeadersVisible = False
        Me.dgvPayment.Size = New System.Drawing.Size(304, 187)
        Me.dgvPayment.TabIndex = 4
        '
        'Acc_ID
        '
        Me.Acc_ID.DataPropertyName = "Acc_ID"
        Me.Acc_ID.HeaderText = "Acc_ID"
        Me.Acc_ID.Name = "Acc_ID"
        Me.Acc_ID.ReadOnly = True
        '
        'AmountDataGridViewTextBoxColumn
        '
        Me.AmountDataGridViewTextBoxColumn.DataPropertyName = "Amount"
        Me.AmountDataGridViewTextBoxColumn.HeaderText = "Amount"
        Me.AmountDataGridViewTextBoxColumn.Name = "AmountDataGridViewTextBoxColumn"
        Me.AmountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DatePaidDataGridViewTextBoxColumn
        '
        Me.DatePaidDataGridViewTextBoxColumn.DataPropertyName = "Date_Paid"
        Me.DatePaidDataGridViewTextBoxColumn.HeaderText = "Date_Paid"
        Me.DatePaidDataGridViewTextBoxColumn.Name = "DatePaidDataGridViewTextBoxColumn"
        Me.DatePaidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TblPaymentBindingSource
        '
        Me.TblPaymentBindingSource.DataMember = "tblPayment"
        Me.TblPaymentBindingSource.DataSource = Me.PrototypeBDDataSet
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(144, 183)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(136, 20)
        Me.txtSearch.TabIndex = 11
        '
        'AddPaymentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 386)
        Me.Controls.Add(Me.dgvPayment)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "AddPaymentForm"
        Me.Text = "AddPaymentForm"
        CType(Me.TblAccBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrototypeBDDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgvPayment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPaymentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lsbID As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rBtnRef As System.Windows.Forms.RadioButton
    Friend WithEvents rBtnID As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrototypeBDDataSet As Prototype1._1.PrototypeBDDataSet
    Friend WithEvents TblAccBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblAccTableAdapter As Prototype1._1.PrototypeBDDataSetTableAdapters.tblAccTableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lsbRef As System.Windows.Forms.ListBox
    Friend WithEvents Acc_IDLabel1 As System.Windows.Forms.Label
    Friend WithEvents TableAdapterManager As Prototype1._1.PrototypeBDDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NameLabel1 As System.Windows.Forms.Label
    Friend WithEvents SurnameLabel1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents mTxtDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents dgvPayment As System.Windows.Forms.DataGridView
    Friend WithEvents TblPaymentTableAdapter As Prototype1._1.PrototypeBDDataSetTableAdapters.tblPaymentTableAdapter
    Friend WithEvents TblPaymentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Acc_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatePaidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
End Class
