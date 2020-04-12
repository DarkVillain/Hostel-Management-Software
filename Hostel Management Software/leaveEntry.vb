Imports System.IO
Imports System.Configuration
Imports Oracle.DataAccess.Client
Public Class leaveEntry

    Dim con As New Oracle.DataAccess.Client.OracleConnection("DATA SOURCE=localhost:1521/orclpdb;PERSIST SECURITY INFO=True;USER ID=HR;PASSWORD=hr")
    Private Sub btnBck_Click(sender As Object, e As EventArgs) Handles btnBck.Click

        dash.Show()
        Me.Hide()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        con.Open()
        Dim command As OracleCommand = con.CreateCommand()
        command.CommandText = " INSERT INTO LEAVE VALUES ('" & txtEi.Text & "','" & cmbRn.Text & "','" & cmbCz.Text & "','" & dtpFrm.Text & "','" & dtpTo.Text & "')"
        txtEi.Text = " "
        cmbRn.Text = " "
        cmbCz.Text = " "
        If command.ExecuteNonQuery() > 0 Then
            MsgBox("Data has been saved!")
        Else
            MsgBox("Error, while saving data!")
        End If
        con.Close()

    End Sub

    Private Sub dtpFrm_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRn.SelectedIndexChanged

    End Sub
End Class