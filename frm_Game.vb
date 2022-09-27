Public Class frm_Game
    Private Sub GameBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles GameBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.GameBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GamecafeDataSet)

    End Sub

    Private Sub frm_Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GamecafeDataSet.Game' table. You can move, or remove it, as needed.
        Me.GameTableAdapter.Fill(Me.GamecafeDataSet.Game)

    End Sub
End Class