Imports System.Data.SqlClient

Public Class frm_game_type
    'Private Sub Game_typeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MyBaseBindingNavigatorSaveItem.Click, MyBaseBindingNavigatorSaveItem.Click, MyBaseBindingNavigatorSaveItem.Click
    '    Me.Validate()
    '    Me.Game_typeBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.GamecafeDataSet)

    'End Sub

    Private Sub game_type_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GamecafeDataSet.Game_type' table. You can move, or remove it, as needed.
        Me.Game_typeTableAdapter.Fill(Me.GamecafeDataSet.Game_type)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim conn As SqlConnection = New SqlConnection("Data Source=344_06\SQLEXPRESS;Initial Catalog=Gamecafe;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("UPDATE Game_type SET type_name=@name WHERE  type_id=@id", conn)
        cmd.Parameters.AddWithValue("name", Type_nameTextBox.Text)
        cmd.Parameters.AddWithValue("id", Type_idTextBox.Text)
        conn.Open()
        If cmd.ExecuteNonQuery() Then

            MsgBox("แก้ไข้สำเร็จ", MsgBoxStyle.Information)
        Else
            MsgBox("ไม่สามารถแก้ไขข้อมูลได้", MsgBoxStyle.Critical)
        End If


        conn.Close()
        Me.Game_typeTableAdapter.Fill(Me.GamecafeDataSet.Game_type)

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim conn As SqlConnection = New SqlConnection("Data Source=344_06\SQLEXPRESS;Initial Catalog=Gamecafe;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("DELETE Game_type  WHERE  type_id=@id", conn)
        cmd.Parameters.AddWithValue("id", Type_idTextBox.Text)
        conn.Open()
        If cmd.ExecuteNonQuery() Then

            MsgBox("ลบข้อมูลสำเร็จ", MsgBoxStyle.Information)
        Else
            MsgBox("ไม่สามารถลบข้อมูลได้", MsgBoxStyle.Critical)
        End If
        conn.Close()


        Me.Game_typeTableAdapter.Fill(Me.GamecafeDataSet.Game_type)
    End Sub
End Class