Imports System.Data.SqlClient
Public Class frm_login
    Private Sub bt_login_Click(sender As Object, e As EventArgs) Handles bt_login.Click
        Dim conn As SqlConnection = New SqlConnection("Data Source=344_06\SQLEXPRESS;Initial Catalog=Gamecafe;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM  Customer WHERE cus_username = '" & tb_user.Text & "' AND  cus_pwd = '" & tb_pwd.Text & "'  ", conn)
        Dim adp As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        adp.Fill(dt)
        If dt.Rows.Count = 1 Then
            frm_main.Show()
            Me.Hide()
        Else
            MessageBox.Show("ชื่อหรือรหัสผ่านไม่ถูกต้อง")
        End If
    End Sub

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_user.Select()
    End Sub
End Class
