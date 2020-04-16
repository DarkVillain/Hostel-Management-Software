Public Class Login

    Private Sub btnExit_Click(sender As Object, e As EventArgs)

        Me.Close()

    End Sub

    Private Sub Top_Paint(sender As Object, e As PaintEventArgs) Handles Up.Paint

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtUm.TextChanged

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim username As String
        Dim password As String

        username = "dark"
        password = "villain"

        If txtUm.Text = username And txtPass.Text = password Then
            'dash.tsslNm.Text = txtBoxName.Text
            dash.Show()
            Me.Hide()
        ElseIf txtUm.Text <> username Or txtPass.Text <> password Then
            MsgBox("Username or password is incorrect!")

        End If
        If txtUm.Text = username And txtPass.Text = password Then
            txtUm.Text = " "
            txtPass.Text = " "
        End If

    End Sub

    Private Sub btnClr_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtUm.Clear()
        txtPass.Clear()

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CenterToScreen() 'To make window to the centerScreen
        'Me.CenterToParent()

    End Sub


    Private Sub llRn_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llRn.LinkClicked

        register.Show()
        Me.Hide()

    End Sub

    Private Sub llFp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llFp.LinkClicked

        changePass.Show()
        Me.Hide()

    End Sub
End Class
