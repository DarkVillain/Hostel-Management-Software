Public Class editUsage
    Private Sub btnBck_Click(sender As Object, e As EventArgs) Handles btnBck.Click

        dash.Show()
        Me.Hide()

    End Sub

    Private Sub editUsage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()   'Make it Center of the screen
    End Sub
End Class