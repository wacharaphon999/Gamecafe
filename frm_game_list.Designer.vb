<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_game_list
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
        Dim Gmae_idLabel As System.Windows.Forms.Label
        Dim Game_nameLabel As System.Windows.Forms.Label
        Dim Type_idLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_game_list))
        Me.GamecafeDataSet = New Gamecafe.GamecafeDataSet()
        Me.GameBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GameTableAdapter = New Gamecafe.GamecafeDataSetTableAdapters.GameTableAdapter()
        Me.TableAdapterManager = New Gamecafe.GamecafeDataSetTableAdapters.TableAdapterManager()
        Me.GameBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.GameBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.GameDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gmae_idTextBox = New System.Windows.Forms.TextBox()
        Me.Game_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Type_idTextBox = New System.Windows.Forms.TextBox()
        Gmae_idLabel = New System.Windows.Forms.Label()
        Game_nameLabel = New System.Windows.Forms.Label()
        Type_idLabel = New System.Windows.Forms.Label()
        CType(Me.GamecafeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GameBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GameBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GameBindingNavigator.SuspendLayout()
        CType(Me.GameDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Gmae_idLabel
        '
        Gmae_idLabel.AutoSize = True
        Gmae_idLabel.Location = New System.Drawing.Point(138, 142)
        Gmae_idLabel.Name = "Gmae_idLabel"
        Gmae_idLabel.Size = New System.Drawing.Size(47, 13)
        Gmae_idLabel.TabIndex = 2
        Gmae_idLabel.Text = "gmae id:"
        '
        'Game_nameLabel
        '
        Game_nameLabel.AutoSize = True
        Game_nameLabel.Location = New System.Drawing.Point(138, 168)
        Game_nameLabel.Name = "Game_nameLabel"
        Game_nameLabel.Size = New System.Drawing.Size(65, 13)
        Game_nameLabel.TabIndex = 4
        Game_nameLabel.Text = "game name:"
        '
        'Type_idLabel
        '
        Type_idLabel.AutoSize = True
        Type_idLabel.Location = New System.Drawing.Point(138, 194)
        Type_idLabel.Name = "Type_idLabel"
        Type_idLabel.Size = New System.Drawing.Size(41, 13)
        Type_idLabel.TabIndex = 6
        Type_idLabel.Text = "type id:"
        '
        'GamecafeDataSet
        '
        Me.GamecafeDataSet.DataSetName = "GamecafeDataSet"
        Me.GamecafeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GameBindingSource
        '
        Me.GameBindingSource.DataMember = "Game"
        Me.GameBindingSource.DataSource = Me.GamecafeDataSet
        '
        'GameTableAdapter
        '
        Me.GameTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomerTableAdapter = Nothing
        Me.TableAdapterManager.Game_typeTableAdapter = Nothing
        Me.TableAdapterManager.GameTableAdapter = Me.GameTableAdapter
        Me.TableAdapterManager.UpdateOrder = Gamecafe.GamecafeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GameBindingNavigator
        '
        Me.GameBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.GameBindingNavigator.BindingSource = Me.GameBindingSource
        Me.GameBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.GameBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.GameBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.GameBindingNavigatorSaveItem, Me.ToolStripButton1, Me.ToolStripButton2})
        Me.GameBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.GameBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.GameBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.GameBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.GameBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.GameBindingNavigator.Name = "GameBindingNavigator"
        Me.GameBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.GameBindingNavigator.Size = New System.Drawing.Size(856, 25)
        Me.GameBindingNavigator.TabIndex = 0
        Me.GameBindingNavigator.Text = "BindingNavigator1"
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
        'GameBindingNavigatorSaveItem
        '
        Me.GameBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GameBindingNavigatorSaveItem.Image = CType(resources.GetObject("GameBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.GameBindingNavigatorSaveItem.Name = "GameBindingNavigatorSaveItem"
        Me.GameBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.GameBindingNavigatorSaveItem.Text = "Save Data"
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
        'GameDataGridView
        '
        Me.GameDataGridView.AutoGenerateColumns = False
        Me.GameDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GameDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.GameDataGridView.DataSource = Me.GameBindingSource
        Me.GameDataGridView.Location = New System.Drawing.Point(463, 68)
        Me.GameDataGridView.Name = "GameDataGridView"
        Me.GameDataGridView.Size = New System.Drawing.Size(342, 220)
        Me.GameDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "gmae_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "gmae_id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "game_name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "game_name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "type_id"
        Me.DataGridViewTextBoxColumn3.HeaderText = "type_id"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'Gmae_idTextBox
        '
        Me.Gmae_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GameBindingSource, "gmae_id", True))
        Me.Gmae_idTextBox.Location = New System.Drawing.Point(209, 139)
        Me.Gmae_idTextBox.Name = "Gmae_idTextBox"
        Me.Gmae_idTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Gmae_idTextBox.TabIndex = 3
        '
        'Game_nameTextBox
        '
        Me.Game_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GameBindingSource, "game_name", True))
        Me.Game_nameTextBox.Location = New System.Drawing.Point(209, 165)
        Me.Game_nameTextBox.Name = "Game_nameTextBox"
        Me.Game_nameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Game_nameTextBox.TabIndex = 5
        '
        'Type_idTextBox
        '
        Me.Type_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GameBindingSource, "type_id", True))
        Me.Type_idTextBox.Location = New System.Drawing.Point(209, 191)
        Me.Type_idTextBox.Name = "Type_idTextBox"
        Me.Type_idTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Type_idTextBox.TabIndex = 7
        '
        'frm_game_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 450)
        Me.Controls.Add(Gmae_idLabel)
        Me.Controls.Add(Me.Gmae_idTextBox)
        Me.Controls.Add(Game_nameLabel)
        Me.Controls.Add(Me.Game_nameTextBox)
        Me.Controls.Add(Type_idLabel)
        Me.Controls.Add(Me.Type_idTextBox)
        Me.Controls.Add(Me.GameDataGridView)
        Me.Controls.Add(Me.GameBindingNavigator)
        Me.Name = "frm_game_list"
        Me.Text = "จัดการรายชื่อเกม"
        CType(Me.GamecafeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GameBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GameBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GameBindingNavigator.ResumeLayout(False)
        Me.GameBindingNavigator.PerformLayout()
        CType(Me.GameDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GamecafeDataSet As GamecafeDataSet
    Friend WithEvents GameBindingSource As BindingSource
    Friend WithEvents GameTableAdapter As GamecafeDataSetTableAdapters.GameTableAdapter
    Friend WithEvents TableAdapterManager As GamecafeDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GameBindingNavigator As BindingNavigator
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
    Friend WithEvents GameBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents GameDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents Gmae_idTextBox As TextBox
    Friend WithEvents Game_nameTextBox As TextBox
    Friend WithEvents Type_idTextBox As TextBox
End Class
