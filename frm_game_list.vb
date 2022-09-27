Imports System.Data.SqlClient
Public Class frm_game_list
    Private Sub GameBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles GameBindingNavigatorSaveItem.Click
        'Me.Validate()
        'Me.GameBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.GamecafeDataSet)

    End Sub

    Private Sub frm_game_list_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GamecafeDataSet.Game' table. You can move, or remove it, as needed.
        Me.GameTableAdapter.Fill(Me.GamecafeDataSet.Game)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim conn As SqlConnection = New SqlConnection("Data Source=344_06\SQLEXPRESS;Initial Catalog=Gamecafe;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("UPDATE Game SET Game_name=@name,type_id=@type_id WHERE  Gmae_id=@id", conn)
        cmd.Parameters.AddWithValue("name", Game_nameTextBox.Text)
        cmd.Parameters.AddWithValue("type_id", Type_idTextBox.Text)
        cmd.Parameters.AddWithValue("id", Gmae_idTextBox.Text)
        conn.Open()
        If cmd.ExecuteNonQuery() Then

            MsgBox("แก้ไข้สำเร็จ", MsgBoxStyle.Information)
        Else
            MsgBox("ไม่สามารถแก้ไขข้อมูลได้", MsgBoxStyle.Critical)
        End If


        conn.Close()
        Me.GameTableAdapter.Fill(Me.GamecafeDataSet.Game)
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim conn As SqlConnection = New SqlConnection("Data Source=344_06\SQLEXPRESS;Initial Catalog=Gamecafe;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("DELETE Game  WHERE  Gmae_id=@id", conn)
        cmd.Parameters.AddWithValue("id", Gmae_idTextBox.Text)
        conn.Open()
        If cmd.ExecuteNonQuery() Then

            MsgBox("ลบข้อมูลสำเร็จ", MsgBoxStyle.Information)
        Else
            MsgBox("ไม่สามารถลบข้อมูลได้", MsgBoxStyle.Critical)
        End If
        conn.Close()


        Me.GameTableAdapter.Fill(Me.GamecafeDataSet.Game)
    End Sub
End Class