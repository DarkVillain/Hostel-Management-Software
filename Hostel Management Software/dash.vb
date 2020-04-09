Public Class dash
    Private Sub dash_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AddToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem1.Click

        addroom.Show()
        Close()

    End Sub


    Private Sub RoomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RoomToolStripMenuItem.Click

    End Sub

    Private Sub EditToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem1.Click

        editRoom.Show()
        Close()

    End Sub
End Class