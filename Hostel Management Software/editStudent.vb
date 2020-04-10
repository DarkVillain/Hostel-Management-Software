Imports Oracle.DataAccess.Client
Public Class editStudent

    Dim con As New Oracle.DataAccess.Client.OracleConnection("DATA SOURCE=localhost:1521/orclpdb;PERSIST SECURITY INFO=True;USER ID=HR;PASSWORD=hr")

    Private Sub btnBck_Click(sender As Object, e As EventArgs) Handles btnBck.Click

        dash.Show()
        Me.Hide()

    End Sub

    Private Sub cmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRn.SelectedIndexChanged

        con.Open()
        Dim command As OracleCommand = con.CreateCommand()
        command.CommandText = "SELECT * FROM student WHERE reg_id=" & cmbRn.SelectedItem
        Dim oraclereader As OracleDataReader = command.ExecuteReader()

        oraclereader.Read()
        txtNm.Text = oraclereader.Item("NAME")
        txtFn.Text = oraclereader.Item("FATHERS_NAME")
        cmbYr.Text = oraclereader.Item("YEAR")
        dtp.Text = oraclereader.Item("DATED")
        cmbAr.Text = oraclereader.Item("ALLOC_ROOM")

        con.Close()
        updateCombo()

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

    Private Sub dtp_Click(sender As Object, e As EventArgs) Handles lblDtp.Click

    End Sub

    Private Sub btnUpdt_Click(sender As Object, e As EventArgs) Handles btnUpdt.Click

        con.Open()

        Dim command As OracleCommand = con.CreateCommand()
        command.CommandText = "UPDATE STUDENT SET REG_ID" & cmbRn.Text & "','" & txtNm.Text & "','" & txtFn.Text & "','" & cmbYr.Text & "','" & dtp.Text & "','" & cmbAr.Text & "')"

        cmbRn.Text = " "
        txtNm.Text = " "
        txtFn.Text = " "
        cmbYr.Text = " "
        dtp.Text = " "
        cmbAr.Text = " "

        If command.ExecuteNonQuery() > 0 Then
            MsgBox("Data has been saved!")
        Else
            MsgBox("Error, while saving data!")
        End If
        Me.Refresh()
        con.Close()

    End Sub
End Class