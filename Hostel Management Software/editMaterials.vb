Imports Oracle.DataAccess.Client
Public Class editMaterials
    Dim con As New Oracle.DataAccess.Client.OracleConnection("DATA SOURCE=localhost:1521/orclpdb;PERSIST SECURITY INFO=True;USER ID=HR;PASSWORD=hr")
    Private Sub editMaterials_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()   'Make it Center of the screen
        updateCombo()
    End Sub
    Private Sub btnBck_Click(sender As Object, e As EventArgs) Handles btnBck.Click
        dash.Show()
        Me.Hide()
    End Sub
    Private Sub btnUpdt_Click(sender As Object, e As EventArgs) Handles btnUpdt.Click
        con.Open()
        Dim command As OracleCommand = con.CreateCommand()
        command.CommandText = "UPDATE MATERIAL SET NAME='" & txtMn.Text & "', PRICEU='" & txtPu.Text & "', QUANT='" & txtAm.Text & "', UNIT='" & cmbUn.Text & "'  WHERE MAT_ID= " & cmbMi.SelectedItem
        cmbMi.Text = " "
        txtMn.Text = " "
        txtPu.Text = " "
        txtAm.Text = " "
        cmbUn.Text = " "
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
        command.CommandText = "DELETE FROM MATERIAL WHERE MAT_ID='" & cmbMi.Text & "'"
        cmbMi.Text = " "
        txtMn.Text = " "
        txtPu.Text = " "
        txtAm.Text = " "
        cmbUn.Text = " "
        If command.ExecuteNonQuery() > 0 Then
            MsgBox("Data has been deleted!")
        Else
            MsgBox("Error, while deleting data!")
        End If
        con.Close()
        updateCombo()
    End Sub
    Private Sub updateCombo()
        cmbMi.Items.Clear()
        con.Open()
        Dim command As OracleCommand = con.CreateCommand()
        command.CommandText = "SELECT MAT_ID FROM MATERIAL"
        Dim oraclereader As OracleDataReader = command.ExecuteReader()
        While oraclereader.Read()
            cmbMi.Items.Add(oraclereader.Item("MAT_ID"))
        End While
        con.Close()
    End Sub
    Private Sub cmbMi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMi.SelectedIndexChanged
        con.Open()
        Dim command As OracleCommand = con.CreateCommand()
        command.CommandText = "SELECT * FROM MATERIAL WHERE MAT_ID=" & cmbMi.SelectedItem
        Dim oraclereader As OracleDataReader = command.ExecuteReader()
        oraclereader.Read()
        txtMn.Text = oraclereader.Item("NAME")
        txtPu.Text = oraclereader.Item("PRICEU")
        txtAm.Text = oraclereader.Item("QUANT")
        cmbUn.Text = oraclereader.Item("UNIT")
        con.Close()
    End Sub
End Class