Public Class dash
    Private Sub dash_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub StudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentToolStripMenuItem.Click



    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click

        addStudent.Show()
        Close()

    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click

        editStudent.Show()
        Close()

    End Sub
End Class