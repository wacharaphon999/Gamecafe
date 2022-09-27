<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_sale
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lb_price = New System.Windows.Forms.Label()
        Me.bt_add = New System.Windows.Forms.Button()
        Me.lb_chang = New System.Windows.Forms.Label()
        Me.bt_sale = New System.Windows.Forms.Button()
        Me.DataGridgame = New System.Windows.Forms.DataGridView()
        Me.cus_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cus_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gmae_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.game_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.play_hours = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumericHours = New System.Windows.Forms.NumericUpDown()
        Me.tb_cusid = New System.Windows.Forms.TextBox()
        Me.tb_gameid = New System.Windows.Forms.TextBox()
        Me.Tb_money = New System.Windows.Forms.TextBox()
        CType(Me.DataGridgame, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericHours, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "รหัสสมาชิก"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "รหัสเกมส์"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ชั่วโมง"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "จำนวนเงิน"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(41, 226)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "รับเงิน"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(42, 252)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "ทอน"
        '
        'lb_price
        '
        Me.lb_price.AutoSize = True
        Me.lb_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lb_price.Location = New System.Drawing.Point(136, 157)
        Me.lb_price.Name = "lb_price"
        Me.lb_price.Size = New System.Drawing.Size(95, 24)
        Me.lb_price.TabIndex = 6
        Me.lb_price.Text = "................."
        '
        'bt_add
        '
        Me.bt_add.Location = New System.Drawing.Point(215, 183)
        Me.bt_add.Name = "bt_add"
        Me.bt_add.Size = New System.Drawing.Size(75, 23)
        Me.bt_add.TabIndex = 7
        Me.bt_add.Text = "Add"
        Me.bt_add.UseVisualStyleBackColor = True
        '
        'lb_chang
        '
        Me.lb_chang.AutoSize = True
        Me.lb_chang.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lb_chang.Location = New System.Drawing.Point(136, 261)
        Me.lb_chang.Name = "lb_chang"
        Me.lb_chang.Size = New System.Drawing.Size(100, 24)
        Me.lb_chang.TabIndex = 8
        Me.lb_chang.Text = ".................."
        '
        'bt_sale
        '
        Me.bt_sale.Location = New System.Drawing.Point(215, 300)
        Me.bt_sale.Name = "bt_sale"
        Me.bt_sale.Size = New System.Drawing.Size(75, 23)
        Me.bt_sale.TabIndex = 9
        Me.bt_sale.Text = "Sale"
        Me.bt_sale.UseVisualStyleBackColor = True
        '
        'DataGridgame
        '
        Me.DataGridgame.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridgame.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cus_id, Me.cus_name, Me.gmae_id, Me.game_name, Me.play_hours})
        Me.DataGridgame.Location = New System.Drawing.Point(349, 25)
        Me.DataGridgame.Name = "DataGridgame"
        Me.DataGridgame.Size = New System.Drawing.Size(544, 252)
        Me.DataGridgame.TabIndex = 10
        '
        'cus_id
        '
        Me.cus_id.HeaderText = "รหัสสมาชิก"
        Me.cus_id.Name = "cus_id"
        '
        'cus_name
        '
        Me.cus_name.HeaderText = "ชื่อสมาชิก"
        Me.cus_name.Name = "cus_name"
        '
        'gmae_id
        '
        Me.gmae_id.HeaderText = "รหัสเกมส์"
        Me.gmae_id.Name = "gmae_id"
        '
        'game_name
        '
        Me.game_name.HeaderText = "ชื่อเกมส์"
        Me.game_name.Name = "game_name"
        '
        'play_hours
        '
        Me.play_hours.HeaderText = "จำนวนชั่วโมง"
        Me.play_hours.Name = "play_hours"
        '
        'NumericHours
        '
        Me.NumericHours.Location = New System.Drawing.Point(150, 115)
        Me.NumericHours.Name = "NumericHours"
        Me.NumericHours.Size = New System.Drawing.Size(49, 20)
        Me.NumericHours.TabIndex = 12
        '
        'tb_cusid
        '
        Me.tb_cusid.Location = New System.Drawing.Point(150, 36)
        Me.tb_cusid.Name = "tb_cusid"
        Me.tb_cusid.Size = New System.Drawing.Size(106, 20)
        Me.tb_cusid.TabIndex = 13
        '
        'tb_gameid
        '
        Me.tb_gameid.Location = New System.Drawing.Point(150, 74)
        Me.tb_gameid.Name = "tb_gameid"
        Me.tb_gameid.Size = New System.Drawing.Size(106, 20)
        Me.tb_gameid.TabIndex = 14
        '
        'Tb_money
        '
        Me.Tb_money.Location = New System.Drawing.Point(139, 232)
        Me.Tb_money.Name = "Tb_money"
        Me.Tb_money.Size = New System.Drawing.Size(106, 20)
        Me.Tb_money.TabIndex = 15
        '
        'frm_sale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(935, 450)
        Me.Controls.Add(Me.Tb_money)
        Me.Controls.Add(Me.tb_gameid)
        Me.Controls.Add(Me.tb_cusid)
        Me.Controls.Add(Me.NumericHours)
        Me.Controls.Add(Me.DataGridgame)
        Me.Controls.Add(Me.bt_sale)
        Me.Controls.Add(Me.lb_chang)
        Me.Controls.Add(Me.bt_add)
        Me.Controls.Add(Me.lb_price)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_sale"
        Me.Text = "frm_seal"
        CType(Me.DataGridgame, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericHours, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lb_price As Label
    Friend WithEvents bt_add As Button
    Friend WithEvents lb_chang As Label
    Friend WithEvents bt_sale As Button
    Friend WithEvents DataGridgame As DataGridView
    Friend WithEvents NumericHours As NumericUpDown
    Friend WithEvents tb_cusid As TextBox
    Friend WithEvents tb_gameid As TextBox
    Friend WithEvents Tb_money As TextBox
    Friend WithEvents cus_id As DataGridViewTextBoxColumn
    Friend WithEvents cus_name As DataGridViewTextBoxColumn
    Friend WithEvents gmae_id As DataGridViewTextBoxColumn
    Friend WithEvents game_name As DataGridViewTextBoxColumn
    Friend WithEvents play_hours As DataGridViewTextBoxColumn
End Class
