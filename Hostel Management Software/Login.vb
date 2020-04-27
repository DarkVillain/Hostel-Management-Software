Imports Oracle.DataAccess.Client
Public Class Login
    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim con As New Oracle.DataAccess.Client.OracleConnection("DATA SOURCE=localhost:1521/orclpdb;PERSIST SECURITY INFO=True;USER ID=HR;PASSWORD=hr")
        If txtPass.Text = "" Or txtUm.Text = "" Then
            MessageBox.Show("Please fill the field(s)!!", "Authentication Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Dim sql As String = "SELECT * FROM LOGIN WHERE USERNAME='" & txtUm.Text & "' AND PASSWORD = '" & txtPass.Text & "'"
                Dim sqlCom As New OracleCommand(sql)
                sqlCom.Connection = con
                con.Open()
                Dim sqlRead As OracleDataReader = sqlCom.ExecuteReader()
                If sqlRead.Read() Then
                    dash.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Username and Password do not match!!", "Authentication Failure!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtPass.Text = ""
                    txtUm.Text = ""
                    txtUm.Focus()
                End If
            Catch ex As Exception
                MessageBox.Show("Failed to connect to Database!!", "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Private Sub btnClr_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtUm.Clear()
        txtPass.Clear()
    End Sub
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen() 'To make window to the centerScreen
        'Me.CenterToParent()
        AcceptButton = btnLogin
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
