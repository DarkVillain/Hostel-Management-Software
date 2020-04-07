Imports Oracle.DataAccess.Client

Public Class Login

    Dim con As New Oracle.DataAccess.Client.OracleConnection("DATA SOURCE=localhost:1521/orclpdb;PERSIST SECURITY INFO=True;USER ID=HR;PASSWORD=hr")


    Private Sub btnExit_Click(sender As Object, e As EventArgs)

        Me.Close()

    End Sub

    Private Sub Top_Paint(sender As Object, e As PaintEventArgs) Handles Up.Paint

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim username As String = txtBoxName.Text
        Dim password As String = txtBoxPass.Text

        con.Open()
        Dim command As OracleCommand = con.CreateCommand()
        command.CommandText = "SELECT USERNAME,PASSWORD FROM LOGIN WHERE USERNAME='" + txtBoxName.Text + "'AND PASSWORD='" + txtBoxPass.Text + "'   "
        Dim oraclereader As OracleDataReader = command.ExecuteReader()

        oraclereader.Read()
        txtBoxPass.Text = oraclereader.Item("PASSWORD")

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
        con.Close()
    End Sub

    Private Sub txtBoxPass_TextChanged(sender As Object, e As EventArgs) Handles txtBoxPass.TextChanged

    End Sub

    Private Sub lblTitle_Click(sender As Object, e As EventArgs) Handles lblTitle.Click

    End Sub

    Private Sub btnClr_Click(sender As Object, e As EventArgs) Handles btnClr.Click

        txtBoxName.Clear()
        txtBoxPass.Clear()


    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class
