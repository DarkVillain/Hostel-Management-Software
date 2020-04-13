Public Class register
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Login.Show()
        Me.Hide()

    End Sub

    Private Sub btnReg_Click(sender As Object, e As EventArgs) Handles btnReg.Click

        Login.Show()
        Me.Hide()

    End Sub

    Private Sub register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()   'Make it Center of the screen
    End Sub
End Class