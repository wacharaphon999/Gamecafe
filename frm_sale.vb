Imports System.Data.SqlClient
Public Class frm_sale
    Private Sub bt_add_Click(sender As Object, e As EventArgs) Handles bt_add.Click
        Dim conn As SqlConnection = New SqlConnection("Data Source=344_06\SQLEXPRESS;Initial Catalog=Gamecafe;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("SELECT cus_name FROM  Customer WHERE cus_id = '" & tb_cusid.Text & "' ", conn)
        Dim adp As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        adp.Fill(dt)
        If dt.Rows.Count = 1 Then
            Dim cmd1 As SqlCommand = New SqlCommand("SELECT * FROM  Game WHERE gmae_id = '" & tb_gameid.Text & "' ", conn)
            Dim adp1 As SqlDataAdapter = New SqlDataAdapter(cmd1)
            Dim dt1 As DataTable = New DataTable()
            adp1.Fill(dt1)
            If dt1.Rows.Count = 1 Then
                Dim rowID As Integer = DataGridgame.Rows.Add()
                Dim row As DataGridViewRow = DataGridgame.Rows(rowID)
                row.Cells("Cus_id").Value = tb_cusid.Text
                row.Cells("Cus_name").Value = dt.Rows(0).Item("cus_name")
                row.Cells("gmae_id").Value = tb_gameid.Text
                row.Cells("game_name").Value = dt1.Rows(0).Item("game_name")
                row.Cells("play_hours").Value = NumericHours.Value


            End If
        End If
    End Sub

    Private Sub NumericHours_ValueChanged(sender As Object, e As EventArgs) Handles NumericHours.ValueChanged
        lb_price.Text = NumericHours.Value * 20
    End Sub

    Private Sub Tb_money_TextChanged(sender As Object, e As EventArgs) Handles Tb_money.TextChanged
        lb_chang.Text = Tb_money.Text - lb_price.Text
    End Sub

    'Private Sub bt_sale_Click(sender As Object, e As EventArgs) Handles bt_sale.Click
    '    Dim conn As SqlConnection = New SqlConnection("Data Source=344_06\SQLEXPRESS;Initial Catalog=Gamecafe;Integrated Security=True")

    '    For Each DataRow As DataGridView In DataGridgame.Rows
    '        Dim cmd2 As SqlCommand = New SqlCommand("insert into play(cus_id,game_id,play_hour)
    '                                                values('@cus_id','@game_id','@play_hour')", conn)
    '        cmd2.Parameters.AddWithValue("cus_id", DataRow.Cells("cus_id").Value)
    '        cmd2.Parameters.AddWithValue("game_id", DataRow.SeleCells("game_id"))
    '        cmd2.Parameters.AddWithValue("play_hour", DataRow.SelectedCells("play_hour"))
    '        conn.Open()
    '        If cmd2.ExecuteNonQuery() Then
    '            MessageBox.Show("ขายแล้ว")
    '        End If


    '    Next

    'End Sub
End Class