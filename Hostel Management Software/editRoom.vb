Imports Oracle.DataAccess.Client
Public Class editRoom

    Dim con As New Oracle.DataAccess.Client.OracleConnection("DATA SOURCE=localhost:1521/orclpdb;PERSIST SECURITY INFO=True;USER ID=HR;PASSWORD=hr")

    Private Sub lblRT_Click(sender As Object, e As EventArgs) Handles lblRT.Click

    End Sub

    Private Sub btnBCK_Click(sender As Object, e As EventArgs) Handles btnBCK.Click
        dash.Show()
        Me.Hide()
    End Sub

    Private Sub btnCLR_Click(sender As Object, e As EventArgs) Handles btnCLR.Click
        cmbRN.Text = " "
        cmbRT.Text = " "
        txtPC.Text = " "
    End Sub
    Private Sub C1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRN.SelectedIndexChanged
        cmbRN.Items.Clear()

        con.Open()
        Dim command As OracleCommand = con.CreateCommand()
        command.CommandText = "SELECT * FROM ROOMDETAILS WHERE ROOM_NO=" & cmbRN.SelectedItem
        Dim oraclereader As OracleDataReader = command.ExecuteReader()

        oraclereader.Read()
        cmbRT.Text = oraclereader.Item("ROOM_TYPE")
        txtPC.Text = oraclereader.Item("PRICE")

        con.Close()
    End Sub

    Private Sub btnUPDT_Click(sender As Object, e As EventArgs) Handles btnUPDT.Click
        con.Open()
        Dim command As OracleCommand = con.CreateCommand()
        command.CommandText = "UPDATE ROOMDETAILS SET ROOM_TYPE='" & cmbRT.Text & "', PRICE=" & txtPC.Text & " WHERE ROOM_NO= " & cmbRN.SelectedItem
        If command.ExecuteNonQuery() > 0 Then
            MsgBox("datas are updated...!")
        Else
            MsgBox("datas are not updated")
        End If
    End Sub

End Class