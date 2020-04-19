Imports Oracle.DataAccess.Client
Public Class enterUsage
    Dim con As New Oracle.DataAccess.Client.OracleConnection("DATA SOURCE=localhost:1521/orclpdb;PERSIST SECURITY INFO=True;USER ID=HR;PASSWORD=hr")
    Private Sub enterUsage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()   'Make it Center of the screen
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        con.Open()
        Dim command As Oracle.DataAccess.Client.OracleCommand = con.CreateCommand()
        command.CommandText = "INSERT INTO USAGE VALUES (" & txtUi.Text & ",'" & txtMn.Text & "'," & txtPu.Text & ",'" & cmbUn.Text & "'," & txtAm.Text & "," & txtPc.Text & ",'" & dtp.Text & "')"
        txtUi.Text = " "
        txtMn.Text = " "
        txtPu.Text = " "
        cmbUn.Text = " "
        txtAm.Text = " "
        txtPc.Text = " "
        If command.ExecuteNonQuery() > 0 Then
            MsgBox("Data has been saved!")
        Else
            MsgBox("Error, while saving data!")
        End If
        con.Close()
    End Sub

    Private Sub btnBck_Click(sender As Object, e As EventArgs) Handles btnBck.Click
        dash.Show()
        Me.Hide()
    End Sub
End Class