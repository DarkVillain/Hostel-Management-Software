﻿Imports System.IO
Imports System.Configuration
Imports Oracle.DataAccess.Client
Public Class register

    Dim con As New Oracle.DataAccess.Client.OracleConnection("DATA SOURCE=localhost:1521/orclpdb;PERSIST SECURITY INFO=True;USER ID=HR;PASSWORD=hr")

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Login.Show()
        Me.Hide()

    End Sub

    Private Sub btnReg_Click(sender As Object, e As EventArgs) Handles btnReg.Click

        con.Open()

        Dim command As Oracle.DataAccess.Client.OracleCommand = con.CreateCommand()

        If txtPass.Text = txtCnPass.Text Then 'Change txtPass & txtCnPass to password & Confirm password

            command.CommandText = "INSERT INTO LOGIN VALUES ('" & txtUn.Text & "','" & txtPass.Text & "','" & txtFn.Text & "','" & cmbGnd.Text & "','" & dtpDob.Text & "','" & txtPn.Text & "','" & txtMl.Text & "')"

            txtUn.Text = " "
            txtPass.Text = " "
            txtCnPass.Text = " "
            txtFn.Text = " "
            cmbGnd.Text = " "
            txtPn.Text = " "
            txtMl.Text = " "

            If command.ExecuteNonQuery() > 0 Then
                MsgBox("You have registered yourself succsessfully! Now please login.")
                Login.Show()
                Me.Hide()
            Else


                MsgBox("Error, while saving data!")
            End If
        Else
            MsgBox("Password and Confirm Password fields doesn't match!")
        End If

        con.Close()

    End Sub

    Private Sub register_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CenterToScreen()   'Make it Center of the screen

    End Sub
End Class