Imports Oracle.DataAccess.Client
Public Class editRoom

    Dim con As New Oracle.DataAccess.Client.OracleConnection("DATA SOURCE=localhost:1521/orclpdb;PERSIST SECURITY INFO=True;USER ID=HR;PASSWORD=hr")

    Private Sub lblRT_Click(sender As Object, e As EventArgs) Handles lblRT.Click

    End Sub

    Private Sub btnBCK_Click(sender As Object, e As EventArgs) Handles btnBCK.Click
        dash.Show()
        Me.Hide()
    End Sub

    Private Sub btnCLR_Click(sender As Object, e As EventArgs)
        cmbRN.Text = " "
        cmbRT.Text = " "
        txtPC.Text = " "
    End Sub
    Private Sub cmbRN_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRN.SelectedIndexChanged

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

        cmbRN.Text = " "
        cmbRT.Text = " "
        txtPC.Text = " "

        If command.ExecuteNonQuery() > 0 Then
            MsgBox("Data has been saved!")
        Else
            MsgBox("Error, while saving data!")
        End If
        Me.Refresh()
        con.Close()
        updategrid()

    End Sub

    Private Sub editRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        updatecombo()
        updategrid()

    End Sub

    Private Sub updatecombo()

        cmbRN.Items.Clear()

        con.Open()
        Dim command As OracleCommand = con.CreateCommand()
        command.CommandText = "SELECT ROOM_NO FROM ROOMDETAILS"
        Dim oraclereader As OracleDataReader = command.ExecuteReader()

        While oraclereader.Read()
            cmbRN.Items.Add(oraclereader.Item("ROOM_NO"))
        End While
        con.Close()

    End Sub

    Private Sub updategrid()

        dgvRoom.Columns.Clear()
        dgvRoom.Rows.Clear()

        dgvRoom.Columns.Add("colROOM_NO", "ROOM_NO")
        dgvRoom.Columns.Add("colROOM_TYPE", "ROOM_TYPE")
        dgvRoom.Columns.Add("colPRICE", "PRICE")

        con.Open()
        Dim command As OracleCommand = con.CreateCommand()
        command.CommandText = "SELECT * FROM ROOMDETAILS"
        Dim oraclereader As OracleDataReader = command.ExecuteReader()

        While oraclereader.Read()
            dgvRoom.Rows.Add({oraclereader.Item("ROOM_NO"), oraclereader.Item("ROOM_TYPE"), oraclereader.Item("PRICE")})
        End While
        con.Close()

    End Sub

    Private Sub btnDLT_Click(sender As Object, e As EventArgs) Handles btnDLT.Click

        con.Open()
        Dim command As OracleCommand = con.CreateCommand()
        command.CommandText = "DELETE FROM ROOMDETAILS WHERE ROOM_NO='" & cmbRN.Text & "'"
        cmbRN.Text = " "
        cmbRT.Text = " "
        txtPC.Text = " "


        If command.ExecuteNonQuery() > 0 Then
            MsgBox("Data has been deleted!")
        Else
            MsgBox("Error, while deleting data!")
        End If


        con.Close()
        updatecombo()
        updategrid()

    End Sub

End Class