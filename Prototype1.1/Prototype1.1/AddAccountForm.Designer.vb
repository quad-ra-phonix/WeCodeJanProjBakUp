<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddAccountForm
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
        Dim NameLabel As System.Windows.Forms.Label
        Dim SurnameLabel As System.Windows.Forms.Label
        Dim ID_noLabel As System.Windows.Forms.Label
        Dim Ref_RAFLabel As System.Windows.Forms.Label
        Dim Ref_noLabel As System.Windows.Forms.Label
        Dim BalLabel As System.Windows.Forms.Label
        Dim TotalLabel As System.Windows.Forms.Label
        Me.PrototypeBDDataSet = New Prototype1._1.PrototypeBDDataSet()
        Me.TblAccBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblAccTableAdapter = New Prototype1._1.PrototypeBDDataSetTableAdapters.tblAccTableAdapter()
        Me.TableAdapterManager = New Prototype1._1.PrototypeBDDataSetTableAdapters.TableAdapterManager()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.SurnameTextBox = New System.Windows.Forms.TextBox()
        Me.ID_noTextBox = New System.Windows.Forms.TextBox()
        Me.Ref_RAFTextBox = New System.Windows.Forms.TextBox()
        Me.Ref_noTextBox = New System.Windows.Forms.TextBox()
        Me.BalTextBox = New System.Windows.Forms.TextBox()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnUpdate = New System.Windows.Forms.Button()
        NameLabel = New System.Windows.Forms.Label()
        SurnameLabel = New System.Windows.Forms.Label()
        ID_noLabel = New System.Windows.Forms.Label()
        Ref_RAFLabel = New System.Windows.Forms.Label()
        Ref_noLabel = New System.Windows.Forms.Label()
        BalLabel = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
        CType(Me.PrototypeBDDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblAccBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(48, 41)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 3
        NameLabel.Text = "Name:"
        '
        'SurnameLabel
        '
        SurnameLabel.AutoSize = True
        SurnameLabel.Location = New System.Drawing.Point(48, 67)
        SurnameLabel.Name = "SurnameLabel"
        SurnameLabel.Size = New System.Drawing.Size(52, 13)
        SurnameLabel.TabIndex = 5
        SurnameLabel.Text = "Surname:"
        '
        'ID_noLabel
        '
        ID_noLabel.AutoSize = True
        ID_noLabel.Location = New System.Drawing.Point(48, 93)
        ID_noLabel.Name = "ID_noLabel"
        ID_noLabel.Size = New System.Drawing.Size(36, 13)
        ID_noLabel.TabIndex = 7
        ID_noLabel.Text = "ID no:"
        '
        'Ref_RAFLabel
        '
        Ref_RAFLabel.AutoSize = True
        Ref_RAFLabel.Location = New System.Drawing.Point(48, 119)
        Ref_RAFLabel.Name = "Ref_RAFLabel"
        Ref_RAFLabel.Size = New System.Drawing.Size(51, 13)
        Ref_RAFLabel.TabIndex = 9
        Ref_RAFLabel.Text = "Ref RAF:"
        '
        'Ref_noLabel
        '
        Ref_noLabel.AutoSize = True
        Ref_noLabel.Location = New System.Drawing.Point(48, 145)
        Ref_noLabel.Name = "Ref_noLabel"
        Ref_noLabel.Size = New System.Drawing.Size(42, 13)
        Ref_noLabel.TabIndex = 11
        Ref_noLabel.Text = "Ref no:"
        '
        'BalLabel
        '
        BalLabel.AutoSize = True
        BalLabel.Location = New System.Drawing.Point(48, 171)
        BalLabel.Name = "BalLabel"
        BalLabel.Size = New System.Drawing.Size(25, 13)
        BalLabel.TabIndex = 13
        BalLabel.Text = "Bal:"
        '
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.Location = New System.Drawing.Point(48, 197)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(34, 13)
        TotalLabel.TabIndex = 15
        TotalLabel.Text = "Total:"
        '
        'PrototypeBDDataSet
        '
        Me.PrototypeBDDataSet.DataSetName = "PrototypeBDDataSet"
        Me.PrototypeBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblAccBindingSource
        '
        Me.TblAccBindingSource.DataMember = "tblAcc"
        Me.TblAccBindingSource.DataSource = Me.PrototypeBDDataSet
        '
        'TblAccTableAdapter
        '
        Me.TblAccTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblAccTableAdapter = Me.TblAccTableAdapter
        Me.TableAdapterManager.tblPaymentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Prototype1._1.PrototypeBDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblAccBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(140, 41)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NameTextBox.TabIndex = 4
        '
        'SurnameTextBox
        '
        Me.SurnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblAccBindingSource, "Surname", True))
        Me.SurnameTextBox.Location = New System.Drawing.Point(140, 67)
        Me.SurnameTextBox.Name = "SurnameTextBox"
        Me.SurnameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SurnameTextBox.TabIndex = 6
        '
        'ID_noTextBox
        '
        Me.ID_noTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblAccBindingSource, "ID_no", True))
        Me.ID_noTextBox.Location = New System.Drawing.Point(140, 93)
        Me.ID_noTextBox.Name = "ID_noTextBox"
        Me.ID_noTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ID_noTextBox.TabIndex = 8
        '
        'Ref_RAFTextBox
        '
        Me.Ref_RAFTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblAccBindingSource, "Ref_RAF", True))
        Me.Ref_RAFTextBox.Location = New System.Drawing.Point(140, 119)
        Me.Ref_RAFTextBox.Name = "Ref_RAFTextBox"
        Me.Ref_RAFTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Ref_RAFTextBox.TabIndex = 10
        '
        'Ref_noTextBox
        '
        Me.Ref_noTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblAccBindingSource, "Ref_no", True))
        Me.Ref_noTextBox.Location = New System.Drawing.Point(140, 145)
        Me.Ref_noTextBox.Name = "Ref_noTextBox"
        Me.Ref_noTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Ref_noTextBox.TabIndex = 12
        '
        'BalTextBox
        '
        Me.BalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblAccBindingSource, "Bal", True))
        Me.BalTextBox.Location = New System.Drawing.Point(140, 171)
        Me.BalTextBox.Name = "BalTextBox"
        Me.BalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BalTextBox.TabIndex = 14
        '
        'TotalTextBox
        '
        Me.TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblAccBindingSource, "Total", True))
        Me.TotalTextBox.Location = New System.Drawing.Point(140, 197)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotalTextBox.TabIndex = 16
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 17
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
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(89, 251)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(100, 30)
        Me.btnUpdate.TabIndex = 18
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'AddAccountForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 310)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(SurnameLabel)
        Me.Controls.Add(Me.SurnameTextBox)
        Me.Controls.Add(ID_noLabel)
        Me.Controls.Add(Me.ID_noTextBox)
        Me.Controls.Add(Ref_RAFLabel)
        Me.Controls.Add(Me.Ref_RAFTextBox)
        Me.Controls.Add(Ref_noLabel)
        Me.Controls.Add(Me.Ref_noTextBox)
        Me.Controls.Add(BalLabel)
        Me.Controls.Add(Me.BalTextBox)
        Me.Controls.Add(TotalLabel)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddAccountForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add New Account"
        CType(Me.PrototypeBDDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblAccBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrototypeBDDataSet As Prototype1._1.PrototypeBDDataSet
    Friend WithEvents TblAccBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblAccTableAdapter As Prototype1._1.PrototypeBDDataSetTableAdapters.tblAccTableAdapter
    Friend WithEvents TableAdapterManager As Prototype1._1.PrototypeBDDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SurnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ID_noTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Ref_RAFTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Ref_noTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
End Class
