Imports Oracle.DataAccess.Client
Public Class addroom

    Dim con As New Oracle.DataAccess.Client.OracleConnection("DATA SOURCE=localhost:1521/orclpdb;PERSIST SECURITY INFO=True;USER ID=HR;PASSWORD=hr")

    Private Sub addroom_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        updategrid()

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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtRN.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblPC.Click

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        con.Open()

        Dim command As Oracle.DataAccess.Client.OracleCommand = con.CreateCommand()
        command.CommandText = " INSERT INTO ROOMDETAILS VALUES ('" & txtRN.Text & "','" & cmbRT.Text & "','" & txtPC.Text & "')"

        txtRN.Text = " "
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



    Private Sub btnBK_Click(sender As Object, e As EventArgs) Handles btnBK.Click

        dash.Show()
        Me.Hide()

    End Sub

    Private Sub btnClr_Click(sender As Object, e As EventArgs) Handles btnClr.Click

        txtRN.Text = " "
        cmbRT.Text = " "
        txtPC.Text = " "

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRoom.CellContentClick

    End Sub
End Class