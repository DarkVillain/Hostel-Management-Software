Imports System.IO
Imports System.Configuration
Imports Oracle.DataAccess.Client
Public Class changePass

    Dim con As New Oracle.DataAccess.Client.OracleConnection("DATA SOURCE=localhost:1521/orclpdb;PERSIST SECURITY INFO=True;USER ID=HR;PASSWORD=hr")

    Private Sub btnCng_Click(sender As Object, e As EventArgs) Handles btnCng.Click

    End Sub

    Private Sub btnCnl_Click(sender As Object, e As EventArgs) Handles btnCnl.Click

        Login.Show()
        Me.Hide()

    End Sub

    Private Sub changePass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()   'Make it Center of the screen
    End Sub
End Class