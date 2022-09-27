<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
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
        Me.bt_login = New System.Windows.Forms.Button()
        Me.tb_user = New System.Windows.Forms.TextBox()
        Me.tb_pwd = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'bt_login
        '
        Me.bt_login.BackColor = System.Drawing.Color.Cyan
        Me.bt_login.Location = New System.Drawing.Point(271, 231)
        Me.bt_login.Name = "bt_login"
        Me.bt_login.Size = New System.Drawing.Size(74, 40)
        Me.bt_login.TabIndex = 0
        Me.bt_login.Text = "Login"
        Me.bt_login.UseVisualStyleBackColor = False
        '
        'tb_user
        '
        Me.tb_user.Location = New System.Drawing.Point(226, 153)
        Me.tb_user.Name = "tb_user"
        Me.tb_user.Size = New System.Drawing.Size(175, 20)
        Me.tb_user.TabIndex = 1
        '
        'tb_pwd
        '
        Me.tb_pwd.Location = New System.Drawing.Point(226, 190)
        Me.tb_pwd.Name = "tb_pwd"
        Me.tb_pwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_pwd.Size = New System.Drawing.Size(175, 20)
        Me.tb_pwd.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(219, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Game_Zone"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(149, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(149, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Password"
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Gamecafe.My.Resources.Resources._15
        Me.ClientSize = New System.Drawing.Size(623, 377)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_pwd)
        Me.Controls.Add(Me.tb_user)
        Me.Controls.Add(Me.bt_login)
        Me.Name = "frm_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gamecafe->Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bt_login As Button
    Friend WithEvents tb_user As TextBox
    Friend WithEvents tb_pwd As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
