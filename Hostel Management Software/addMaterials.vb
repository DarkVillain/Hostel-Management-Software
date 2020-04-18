Imports System.IO
Imports System.Drawing
Imports System.Configuration
Imports Oracle.DataAccess.Client
Public Class addMaterials
    Dim con As New Oracle.DataAccess.Client.OracleConnection("DATA SOURCE=localhost:1521/orclpdb;PERSIST SECURITY INFO=True;USER ID=HR;PASSWORD=hr")
    Private Sub addMaterials_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
    Private Sub btnBck_Click(sender As Object, e As EventArgs) Handles btnBck.Click
        dash.Show()
        Me.Hide()
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        con.Open()
        Dim command As Oracle.DataAccess.Client.OracleCommand = con.CreateCommand()
        command.CommandText = "INSERT INTO MATERIAL VALUES (" & txtMi.Text & ",'" & txtMn.Text & "'," & txtPu.Text & "," & txtAm.Text & ",'" & cmbUn.Text & "')"
        txtMi.Text = " "
        txtMn.Text = " "
        txtPu.Text = " "
        txtAm.Text = " "
        cmbUn.Text = " "
        If command.ExecuteNonQuery() > 0 Then
            MsgBox("Data has been saved!")
        Else
            MsgBox("Error, while saving data!")
        End If
        con.Close()
    End Sub
End Class