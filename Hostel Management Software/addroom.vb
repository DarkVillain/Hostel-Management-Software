﻿Public Class addroom

    Dim con As New Oracle.DataAccess.Client.OracleConnection("DATA SOURCE=orcl;PERSIST SECURITY INFO=True;USER ID=HR")
    Private Sub addroom_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtRN.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblPC.Click

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        con.Open()
        Dim command As Oracle.DataAccess.Client.OracleCommand = con.CreateCommand()
        command.CommandText = " INSERT INTO ROOMDETAILS VALUES (" & txtRN.Text & "," & txtRT.Text & "," & txtPC.Text & ")"
        If command.ExecuteNonQuery() > 0 Then
            MsgBox("datas are saved..!")
        Else
            MsgBox("datas are not saved...!")
        End If

    End Sub

    Private Sub btnBK_Click(sender As Object, e As EventArgs) Handles btnBK.Click

        txtRN.Text = " "
        txtRT.Text = " "
        txtPC.Text = " "

    End Sub

    Private Sub btnClr_Click(sender As Object, e As EventArgs) Handles btnClr.Click

        dash.Show()
        Me.Close()

    End Sub
End Class