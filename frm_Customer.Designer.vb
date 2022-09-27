<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Customer
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
        Dim Cus_idLabel As System.Windows.Forms.Label
        Dim Cus_nameLabel As System.Windows.Forms.Label
        Dim Cus_sernameLabel As System.Windows.Forms.Label
        Dim Cus_usernameLabel As System.Windows.Forms.Label
        Dim Cus_pwdLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Customer))
        Me.GamecafeDataSet = New Gamecafe.GamecafeDataSet()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerTableAdapter = New Gamecafe.GamecafeDataSetTableAdapters.CustomerTableAdapter()
        Me.TableAdapterManager = New Gamecafe.GamecafeDataSetTableAdapters.TableAdapterManager()
        Me.CustomerBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CustomerBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.Cus_idTextBox = New System.Windows.Forms.TextBox()
        Me.Cus_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Cus_sernameTextBox = New System.Windows.Forms.TextBox()
        Me.Cus_usernameTextBox = New System.Windows.Forms.TextBox()
        Me.Cus_pwdTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Cus_idLabel = New System.Windows.Forms.Label()
        Cus_nameLabel = New System.Windows.Forms.Label()
        Cus_sernameLabel = New System.Windows.Forms.Label()
        Cus_usernameLabel = New System.Windows.Forms.Label()
        Cus_pwdLabel = New System.Windows.Forms.Label()
        CType(Me.GamecafeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomerBindingNavigator.SuspendLayout()
        CType(Me.CustomerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cus_idLabel
        '
        Cus_idLabel.AutoSize = True
        Cus_idLabel.Location = New System.Drawing.Point(88, 90)
        Cus_idLabel.Name = "Cus_idLabel"
        Cus_idLabel.Size = New System.Drawing.Size(38, 13)
        Cus_idLabel.TabIndex = 2
        Cus_idLabel.Text = "cus id:"
        '
        'Cus_nameLabel
        '
        Cus_nameLabel.AutoSize = True
        Cus_nameLabel.Location = New System.Drawing.Point(88, 116)
        Cus_nameLabel.Name = "Cus_nameLabel"
        Cus_nameLabel.Size = New System.Drawing.Size(56, 13)
        Cus_nameLabel.TabIndex = 4
        Cus_nameLabel.Text = "cus name:"
        '
        'Cus_sernameLabel
        '
        Cus_sernameLabel.AutoSize = True
        Cus_sernameLabel.Location = New System.Drawing.Point(88, 142)
        Cus_sernameLabel.Name = "Cus_sernameLabel"
        Cus_sernameLabel.Size = New System.Drawing.Size(70, 13)
        Cus_sernameLabel.TabIndex = 6
        Cus_sernameLabel.Text = "cus sername:"
        '
        'Cus_usernameLabel
        '
        Cus_usernameLabel.AutoSize = True
        Cus_usernameLabel.Location = New System.Drawing.Point(88, 168)
        Cus_usernameLabel.Name = "Cus_usernameLabel"
        Cus_usernameLabel.Size = New System.Drawing.Size(76, 13)
        Cus_usernameLabel.TabIndex = 8
        Cus_usernameLabel.Text = "cus username:"
        '
        'Cus_pwdLabel
        '
        Cus_pwdLabel.AutoSize = True
        Cus_pwdLabel.Location = New System.Drawing.Point(88, 194)
        Cus_pwdLabel.Name = "Cus_pwdLabel"
        Cus_pwdLabel.Size = New System.Drawing.Size(50, 13)
        Cus_pwdLabel.TabIndex = 10
        Cus_pwdLabel.Text = "cus pwd:"
        '
        'GamecafeDataSet
        '
        Me.GamecafeDataSet.DataSetName = "GamecafeDataSet"
        Me.GamecafeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me.GamecafeDataSet
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomerTableAdapter = Me.CustomerTableAdapter
        Me.TableAdapterManager.Game_typeTableAdapter = Nothing
        Me.TableAdapterManager.GameTableAdapter = Nothing
        Me.TableAdapterManager.playTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Gamecafe.GamecafeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CustomerBindingNavigator
        '
        Me.CustomerBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CustomerBindingNavigator.BindingSource = Me.CustomerBindingSource
        Me.CustomerBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CustomerBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CustomerBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CustomerBindingNavigatorSaveItem, Me.ToolStripButton1, Me.ToolStripButton2})
        Me.CustomerBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CustomerBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CustomerBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CustomerBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CustomerBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CustomerBindingNavigator.Name = "CustomerBindingNavigator"
        Me.CustomerBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CustomerBindingNavigator.Size = New System.Drawing.Size(1064, 25)
        Me.CustomerBindingNavigator.TabIndex = 0
        Me.CustomerBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'CustomerBindingNavigatorSaveItem
        '
        Me.CustomerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CustomerBindingNavigatorSaveItem.Image = CType(resources.GetObject("CustomerBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CustomerBindingNavigatorSaveItem.Name = "CustomerBindingNavigatorSaveItem"
        Me.CustomerBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CustomerBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'Cus_idTextBox
        '
        Me.Cus_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "cus_id", True))
        Me.Cus_idTextBox.Location = New System.Drawing.Point(170, 87)
        Me.Cus_idTextBox.Name = "Cus_idTextBox"
        Me.Cus_idTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Cus_idTextBox.TabIndex = 0
        '
        'Cus_nameTextBox
        '
        Me.Cus_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "cus_name", True))
        Me.Cus_nameTextBox.Location = New System.Drawing.Point(170, 113)
        Me.Cus_nameTextBox.Name = "Cus_nameTextBox"
        Me.Cus_nameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Cus_nameTextBox.TabIndex = 1
        '
        'Cus_sernameTextBox
        '
        Me.Cus_sernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "cus_sername", True))
        Me.Cus_sernameTextBox.Location = New System.Drawing.Point(170, 139)
        Me.Cus_sernameTextBox.Name = "Cus_sernameTextBox"
        Me.Cus_sernameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Cus_sernameTextBox.TabIndex = 2
        '
        'Cus_usernameTextBox
        '
        Me.Cus_usernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "cus_username", True))
        Me.Cus_usernameTextBox.Location = New System.Drawing.Point(170, 165)
        Me.Cus_usernameTextBox.Name = "Cus_usernameTextBox"
        Me.Cus_usernameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Cus_usernameTextBox.TabIndex = 3
        '
        'Cus_pwdTextBox
        '
        Me.Cus_pwdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "cus_pwd", True))
        Me.Cus_pwdTextBox.Location = New System.Drawing.Point(170, 191)
        Me.Cus_pwdTextBox.Name = "Cus_pwdTextBox"
        Me.Cus_pwdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Cus_pwdTextBox.TabIndex = 4
        '
        'CustomerDataGridView
        '
        Me.CustomerDataGridView.AutoGenerateColumns = False
        Me.CustomerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomerDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.CustomerDataGridView.DataSource = Me.CustomerBindingSource
        Me.CustomerDataGridView.Location = New System.Drawing.Point(496, 46)
        Me.CustomerDataGridView.Name = "CustomerDataGridView"
        Me.CustomerDataGridView.Size = New System.Drawing.Size(546, 220)
        Me.CustomerDataGridView.TabIndex = 11
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "cus_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "cus_id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "cus_name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "cus_name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "cus_sername"
        Me.DataGridViewTextBoxColumn3.HeaderText = "cus_sername"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "cus_username"
        Me.DataGridViewTextBoxColumn4.HeaderText = "cus_username"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "cus_pwd"
        Me.DataGridViewTextBoxColumn5.HeaderText = "cus_pwd"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'frm_Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 561)
        Me.Controls.Add(Me.CustomerDataGridView)
        Me.Controls.Add(Cus_idLabel)
        Me.Controls.Add(Me.Cus_idTextBox)
        Me.Controls.Add(Cus_nameLabel)
        Me.Controls.Add(Me.Cus_nameTextBox)
        Me.Controls.Add(Cus_sernameLabel)
        Me.Controls.Add(Me.Cus_sernameTextBox)
        Me.Controls.Add(Cus_usernameLabel)
        Me.Controls.Add(Me.Cus_usernameTextBox)
        Me.Controls.Add(Cus_pwdLabel)
        Me.Controls.Add(Me.Cus_pwdTextBox)
        Me.Controls.Add(Me.CustomerBindingNavigator)
        Me.Name = "frm_Customer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "1"
        CType(Me.GamecafeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomerBindingNavigator.ResumeLayout(False)
        Me.CustomerBindingNavigator.PerformLayout()
        CType(Me.CustomerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GamecafeDataSet As GamecafeDataSet
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As GamecafeDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents TableAdapterManager As GamecafeDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CustomerBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents CustomerBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents Cus_idTextBox As TextBox
    Friend WithEvents Cus_nameTextBox As TextBox
    Friend WithEvents Cus_sernameTextBox As TextBox
    Friend WithEvents Cus_usernameTextBox As TextBox
    Friend WithEvents Cus_pwdTextBox As TextBox
    Friend WithEvents CustomerDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripButton2 As ToolStripButton
End Class
