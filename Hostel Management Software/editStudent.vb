Imports Oracle.DataAccess.Client
Public Class editStudent
    Dim con As New OracleConnection("DATA SOURCE=localhost:1521/orclpdb;PERSIST SECURITY INFO=True;USER ID=HR;PASSWORD=hr")
    Private Sub editStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()   'Make it Center of the screen
        updateCombo()
    End Sub
    Private Sub btnUpdt_Click(sender As Object, e As EventArgs) Handles btnUpdt.Click
        con.Open()
        Dim command As OracleCommand = con.CreateCommand()
        command.CommandText = "UPDATE STUDENT SET NAME='" & txtNm.Text & "', FAT_NAME='" & txtFn.Text & "', CLASS='" & cmbYr.Text & "', DATED='" & dtp.Text & "', ALLOC_ROOM='" & cmbAr.Text & "', PHONE='" & txtPn.Text & "', ADDRS='" & txtAdrs.Text & "', EMAIL='" & txtMl.Text & "'  WHERE REG_ID= " & cmbRn.SelectedItem
        txtNm.Text = " "
        txtFn.Text = " "
        cmbYr.Text = " "
        'dtp.Text = " "
        cmbAr.Text = " "
        txtPn.Text = " "
        txtAdrs.Text = " "
        txtMl.Text = " "
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
        command.CommandText = "DELETE FROM STUDENT WHERE REG_ID='" & cmbRn.Text & "'"
        txtNm.Text = " "
        txtFn.Text = " "
        cmbYr.Text = " "
        'dtp.Text = " "
        cmbAr.Text = " "
        txtPn.Text = " "
        txtAdrs.Text = " "
        txtMl.Text = " "
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
    Private Sub cmbRn_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRn.SelectedIndexChanged
        con.Open()
        Dim command As OracleCommand = con.CreateCommand()
        command.CommandText = "SELECT * FROM STUDENT WHERE REG_ID=" & cmbRn.SelectedItem
        Dim oraclereader As OracleDataReader = command.ExecuteReader()
        oraclereader.Read()
        txtNm.Text = oraclereader.Item("NAME")
        txtFn.Text = oraclereader.Item("FAT_NAME")
        cmbYr.Text = oraclereader.Item("CLASS")
        dtp.Text = oraclereader.Item("DATED")
        cmbAr.Text = oraclereader.Item("ALLOC_ROOM")
        txtPn.Text = oraclereader.Item("PHONE")
        txtAdrs.Text = oraclereader.Item("ADDRS")
        txtMl.Text = oraclereader.Item("EMAIL")
        con.Close()
    End Sub
    Private Sub updateCombo()
        cmbRn.Items.Clear()
        con.Open()
        Dim command As OracleCommand = con.CreateCommand()
        command.CommandText = "SELECT REG_ID FROM STUDENT"
        Dim oraclereader As OracleDataReader = command.ExecuteReader()
        While oraclereader.Read()
            cmbRn.Items.Add(oraclereader.Item("REG_ID"))
        End While
        con.Close()
    End Sub
End Class