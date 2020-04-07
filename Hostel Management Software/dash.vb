Public Class dash
    Private Sub dash_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub RoomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RoomToolStripMenuItem.Click

    End Sub

    Private Sub tsmEdit_Click(sender As Object, e As EventArgs) Handles tsmEdit.Click

        editRoom.Show()
        Close()

    End Sub

    Private Sub tsmAdd_Click(sender As Object, e As EventArgs) Handles tsmAdd.Click

        addroom.Show()
        Close()

    End Sub
End Class