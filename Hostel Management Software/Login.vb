Public Class Login
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblName.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)

        Me.Close()

    End Sub

    Private Sub Top_Paint(sender As Object, e As PaintEventArgs) Handles Up.Paint

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtBoxName.TextChanged

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim username As String
        Dim password As String

        username = "dark"
        password = "villain"

        If txtBoxName.Text = username And txtBoxPass.Text = password Then
            dash.Show()
            Me.Hide()
        ElseIf txtBoxName.Text <> username Or txtBoxPass.Text <> password Then
            MsgBox("Username or password is incorrect!")

        End If
        If txtBoxName.Text = username And txtBoxPass.Text = password Then
            txtBoxName.Text = " "
            txtBoxPass.Text = " "
        End If

    End Sub

    Private Sub txtBoxPass_TextChanged(sender As Object, e As EventArgs) Handles txtBoxPass.TextChanged

    End Sub

    Private Sub lblTitle_Click(sender As Object, e As EventArgs) Handles lblTitle.Click

    End Sub

    Private Sub btnClr_Click(sender As Object, e As EventArgs) Handles btnClr.Click

        txtBoxName.Clear()
        txtBoxPass.Clear()


    End Sub
End Class
