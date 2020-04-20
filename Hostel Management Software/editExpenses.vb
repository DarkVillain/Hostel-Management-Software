Imports Oracle.DataAccess.Client
Public Class editExpenses
    Dim con As New Oracle.DataAccess.Client.OracleConnection("DATA SOURCE=localhost:1521/orclpdb;PERSIST SECURITY INFO=True;USER ID=HR;PASSWORD=hr")
    Private Sub editExpenses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()   'Make it Center of the screen
        updateCombo()
    End Sub

    Private Sub btnUpdt_Click(sender As Object, e As EventArgs) Handles btnUpdt.Click
        con.Open()
        Dim command As OracleCommand = con.CreateCommand()
        command.CommandText = "UPDATE EXPENSE SET NAME='" & txtTo.Text & "', REASON='" & txtRn.Text & "', AMOUNT='" & txtAm.Text & "',DATED='" & dtp.Text & "'  WHERE E_ID= " & cmbEi.SelectedItem
        cmbEi.Text = " "
        txtTo.Text = " "
        txtRn.Text = " "
        txtAm.Text = " "
        If command.ExecuteNonQuery() > 0 Then
            MsgBox("Data has been Updated!")
        Else
            MsgBox("Error, while saving data!")
        End If
        Me.Refresh()
        con.Close()
    End Sub

    Private Sub btnDlt_Click(sender As Object, e As EventArgs) Handles btnDlt.Click
        con.Open()
        Dim command As OracleCommand = con.CreateCommand()
        command.CommandText = "DELETE FROM EXPENSE WHERE E_ID='" & cmbEi.Text & "'"
        cmbEi.Text = " "
        txtTo.Text = " "
        txtRn.Text = " "
        txtAm.Text = " "
        If command.ExecuteNonQuery() > 0 Then
            MsgBox("Data has been deleted!")
        Else
            MsgBox("Error, while deleting data!")
        End If
        con.Close()
        updateCombo()
    End Sub

    Private Sub btnBck_Click(sender As Object, e As EventArgs) Handles btnBck.Click
        dash.Show()
        Me.Hide()
    End Sub
    Private Sub updateCombo()
        cmbEi.Items.Clear()
        con.Open()
        Dim command As OracleCommand = con.CreateCommand()
        command.CommandText = "SELECT E_ID FROM EXPENSE"
        Dim oraclereader As OracleDataReader = command.ExecuteReader()
        While oraclereader.Read()
            cmbEi.Items.Add(oraclereader.Item("E_ID"))
        End While
        con.Close()
    End Sub
    Private Sub cmbEi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEi.SelectedIndexChanged
        con.Open()
        Dim command As OracleCommand = con.CreateCommand()
        command.CommandText = "SELECT * FROM EXPENSE WHERE E_ID=" & cmbEi.SelectedItem
        Dim oraclereader As OracleDataReader = command.ExecuteReader()
        oraclereader.Read()
        txtTo.Text = oraclereader.Item("NAME")
        txtRn.Text = oraclereader.Item("REASON")
        txtAm.Text = oraclereader.Item("AMOUNT")
        dtp.Text = oraclereader.Item("DATED")
        con.Close()
    End Sub
End Class