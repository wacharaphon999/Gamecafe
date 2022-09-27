Imports System.Data.SqlClient
Public Class frm_Customer
    Private Sub CustomerBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CustomerBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustomerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GamecafeDataSet)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim conn As SqlConnection = New SqlConnection("Data Source=344_06\SQLEXPRESS;Initial Catalog=Gamecafe;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("UPDATE Customer SET cus_name=@name,cus_sername=@sername,cus_username=@username,cus_pwd=@pwd WHERE  cus_id=@id", conn)
        cmd.Parameters.AddWithValue("name", Cus_nameTextBox.Text)
        cmd.Parameters.AddWithValue("sername", Cus_sernameTextBox.Text)
        cmd.Parameters.AddWithValue("username", Cus_usernameTextBox.Text)
        cmd.Parameters.AddWithValue("pwd", Cus_pwdTextBox.Text)
        cmd.Parameters.AddWithValue("id", Cus_idTextBox.Text)
        conn.Open()
        If cmd.ExecuteNonQuery() Then

            MsgBox("แก้ไข้สำเร็จ", MsgBoxStyle.Information)
        Else
            MsgBox("ไม่สามารถแก้ไขข้อมูลได้", MsgBoxStyle.Critical)
        End If


        conn.Close()
        Me.CustomerTableAdapter.Fill(Me.GamecafeDataSet.Customer)


    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim conn As SqlConnection = New SqlConnection("Data Source=344_06\SQLEXPRESS;Initial Catalog=Gamecafe;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("DELETE Customer  WHERE  cus_id=@id", conn)
        cmd.Parameters.AddWithValue("id", Cus_idTextBox.Text)
        conn.Open()
        If cmd.ExecuteNonQuery() Then

            MsgBox("ลบข้อมูลสำเร็จ", MsgBoxStyle.Information)
        Else
            MsgBox("ไม่สามารถลบข้อมูลได้", MsgBoxStyle.Critical)
        End If
        conn.Close()


        Me.CustomerTableAdapter.Fill(Me.GamecafeDataSet.Customer)
    End Sub

    Private Sub frm_Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CustomerTableAdapter.Fill(Me.GamecafeDataSet.Customer)
    End Sub
End Class