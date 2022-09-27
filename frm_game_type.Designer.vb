<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_game_type
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
        Dim Type_idLabel As System.Windows.Forms.Label
        Dim Type_nameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_game_type))
        Me.GamecafeDataSet = New Gamecafe.GamecafeDataSet()
        Me.Game_typeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Game_typeTableAdapter = New Gamecafe.GamecafeDataSetTableAdapters.Game_typeTableAdapter()
        Me.TableAdapterManager = New Gamecafe.GamecafeDataSetTableAdapters.TableAdapterManager()
        Me.Game_typeBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Game_typeBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.Type_idTextBox = New System.Windows.Forms.TextBox()
        Me.Type_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Game_typeDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Type_idLabel = New System.Windows.Forms.Label()
        Type_nameLabel = New System.Windows.Forms.Label()
        CType(Me.GamecafeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Game_typeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Game_typeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Game_typeBindingNavigator.SuspendLayout()
        CType(Me.Game_typeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Type_idLabel
        '
        Type_idLabel.AutoSize = True
        Type_idLabel.Location = New System.Drawing.Point(125, 128)
        Type_idLabel.Name = "Type_idLabel"
        Type_idLabel.Size = New System.Drawing.Size(41, 13)
        Type_idLabel.TabIndex = 1
        Type_idLabel.Text = "type id:"
        '
        'Type_nameLabel
        '
        Type_nameLabel.AutoSize = True
        Type_nameLabel.Location = New System.Drawing.Point(125, 154)
        Type_nameLabel.Name = "Type_nameLabel"
        Type_nameLabel.Size = New System.Drawing.Size(59, 13)
        Type_nameLabel.TabIndex = 3
        Type_nameLabel.Text = "type name:"
        '
        'GamecafeDataSet
        '
        Me.GamecafeDataSet.DataSetName = "GamecafeDataSet"
        Me.GamecafeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Game_typeBindingSource
        '
        Me.Game_typeBindingSource.DataMember = "Game_type"
        Me.Game_typeBindingSource.DataSource = Me.GamecafeDataSet
        '
        'Game_typeTableAdapter
        '
        Me.Game_typeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomerTableAdapter = Nothing
        Me.TableAdapterManager.Game_typeTableAdapter = Me.Game_typeTableAdapter
        Me.TableAdapterManager.GameTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Gamecafe.GamecafeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Game_typeBindingNavigator
        '
        Me.Game_typeBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Game_typeBindingNavigator.BindingSource = Me.Game_typeBindingSource
        Me.Game_typeBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Game_typeBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Game_typeBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Game_typeBindingNavigatorSaveItem, Me.ToolStripButton1, Me.ToolStripButton2})
        Me.Game_typeBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Game_typeBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Game_typeBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Game_typeBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Game_typeBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Game_typeBindingNavigator.Name = "Game_typeBindingNavigator"
        Me.Game_typeBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Game_typeBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.Game_typeBindingNavigator.TabIndex = 0
        Me.Game_typeBindingNavigator.Text = "BindingNavigator1"
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
        'Game_typeBindingNavigatorSaveItem
        '
        Me.Game_typeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Game_typeBindingNavigatorSaveItem.Image = CType(resources.GetObject("Game_typeBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Game_typeBindingNavigatorSaveItem.Name = "Game_typeBindingNavigatorSaveItem"
        Me.Game_typeBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Game_typeBindingNavigatorSaveItem.Text = "Save Data"
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
        'Type_idTextBox
        '
        Me.Type_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Game_typeBindingSource, "type_id", True))
        Me.Type_idTextBox.Location = New System.Drawing.Point(190, 125)
        Me.Type_idTextBox.Name = "Type_idTextBox"
        Me.Type_idTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Type_idTextBox.TabIndex = 2
        '
        'Type_nameTextBox
        '
        Me.Type_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Game_typeBindingSource, "type_name", True))
        Me.Type_nameTextBox.Location = New System.Drawing.Point(190, 151)
        Me.Type_nameTextBox.Name = "Type_nameTextBox"
        Me.Type_nameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Type_nameTextBox.TabIndex = 4
        '
        'Game_typeDataGridView
        '
        Me.Game_typeDataGridView.AutoGenerateColumns = False
        Me.Game_typeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Game_typeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.Game_typeDataGridView.DataSource = Me.Game_typeBindingSource
        Me.Game_typeDataGridView.Location = New System.Drawing.Point(452, 47)
        Me.Game_typeDataGridView.Name = "Game_typeDataGridView"
        Me.Game_typeDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.Game_typeDataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "type_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "type_id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "type_name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "type_name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'frm_game_type
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Game_typeDataGridView)
        Me.Controls.Add(Type_idLabel)
        Me.Controls.Add(Me.Type_idTextBox)
        Me.Controls.Add(Type_nameLabel)
        Me.Controls.Add(Me.Type_nameTextBox)
        Me.Controls.Add(Me.Game_typeBindingNavigator)
        Me.Name = "frm_game_type"
        Me.Text = "จัดการประเภทเกม"
        CType(Me.GamecafeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Game_typeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Game_typeBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Game_typeBindingNavigator.ResumeLayout(False)
        Me.Game_typeBindingNavigator.PerformLayout()
        CType(Me.Game_typeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GamecafeDataSet As GamecafeDataSet
    Friend WithEvents Game_typeBindingSource As BindingSource
    Friend WithEvents Game_typeTableAdapter As GamecafeDataSetTableAdapters.Game_typeTableAdapter
    Friend WithEvents TableAdapterManager As GamecafeDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Game_typeBindingNavigator As BindingNavigator
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
    Friend WithEvents Game_typeBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Type_idTextBox As TextBox
    Friend WithEvents Type_nameTextBox As TextBox
    Friend WithEvents Game_typeDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
End Class
