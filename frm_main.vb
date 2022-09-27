Public Class frm_main

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Application.Exit()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        frm_login.Show()
        Me.Hide()
    End Sub

    Private Sub CustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerToolStripMenuItem.Click
        frm_customer.MdiParent = frm_main.ActiveForm
        frm_customer.Dock = DockStyle.Fill
        frm_customer.Show()
    End Sub



    Private Sub Game_type_Click(sender As Object, e As EventArgs) Handles Game_type.Click
        frm_game_type.MdiParent = frm_main.ActiveForm
        frm_game_type.Dock = DockStyle.Fill
        frm_game_type.Show()
    End Sub




    Private Sub Game_Click(sender As Object, e As EventArgs) Handles Game.Click
        frm_game_list.MdiParent = frm_main.ActiveForm
        frm_game_list.Dock = DockStyle.Fill
        frm_game_list.Show()
    End Sub

    Private Sub SaleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaleToolStripMenuItem.Click
        frm_sale.MdiParent = frm_main.ActiveForm
        frm_sale.Dock = DockStyle.Fill
        frm_sale.Show()
    End Sub
End Class