Imports Oracle.DataAccess.Client
Public Class editUsage
    Dim con As New Oracle.DataAccess.Client.OracleConnection("DATA SOURCE=localhost:1521/orclpdb;PERSIST SECURITY INFO=True;USER ID=HR;PASSWORD=hr")
    Private Sub btnBck_Click(sender As Object, e As EventArgs) Handles btnBck.Click
        dash.Show()
        Me.Hide()
    End Sub
    Private Sub editUsage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()   'Make it Center of the screen
        updateCombo()
    End Sub
    Private Sub btnUpdt_Click(sender As Object, e As EventArgs) Handles btnUpdt.Click
        con.Open()
        Dim command As OracleCommand = con.CreateCommand()
        command.CommandText = "UPDATE USAGE SET NAME='" & txtMn.Text & "', PRICEU='" & txtPu.Text & "', USAGE='" & txtAm.Text & "', UNIT='" & cmbUn.Text & "', PRICE='" & txtPc.Text & "',DATED='" & dtp.Text & "'  WHERE U_ID= " & cmbUi.SelectedItem
        cmbUi.Text = " "
        txtMn.Text = " "
        txtPu.Text = " "
        txtAm.Text = " "
        cmbUn.Text = " "
        txtPc.Text = " "
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
        command.CommandText = "DELETE FROM USAGE WHERE U_ID='" & cmbUi.Text & "'"
        cmbUi.Text = " "
        txtMn.Text = " "
        txtPu.Text = " "
        txtAm.Text = " "
        cmbUn.Text = " "
        txtPc.Text = " "
        If command.ExecuteNonQuery() > 0 Then
            MsgBox("Data has been deleted!")
        Else
            MsgBox("Error, while deleting data!")
        End If
        con.Close()
        updateCombo()
    End Sub
    Private Sub updateCombo()
        cmbUi.Items.Clear()
        con.Open()
        Dim command As OracleCommand = con.CreateCommand()
        command.CommandText = "SELECT U_ID FROM USAGE"
        Dim oraclereader As OracleDataReader = command.ExecuteReader()
        While oraclereader.Read()
            cmbUi.Items.Add(oraclereader.Item("U_ID"))
        End While
        con.Close()
    End Sub
    Private Sub cmbMi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUi.SelectedIndexChanged
        con.Open()
        Dim command As OracleCommand = con.CreateCommand()
        command.CommandText = "SELECT * FROM USAGE WHERE U_ID=" & cmbUi.SelectedItem
        Dim oraclereader As OracleDataReader = command.ExecuteReader()
        oraclereader.Read()
        txtMn.Text = oraclereader.Item("NAME")
        txtPu.Text = oraclereader.Item("PRICEU")
        cmbUn.Text = oraclereader.Item("UNIT")
        txtAm.Text = oraclereader.Item("USAGE")
        txtPc.Text = oraclereader.Item("PRICE")
        dtp.Text = oraclereader.Item("DATED")
        con.Close()
    End Sub
End Class