Imports Oracle.DataAccess.Client
Public Class studentRep
    Dim con As New Oracle.DataAccess.Client.OracleConnection("DATA SOURCE=localhost:1521/orclpdb;PERSIST SECURITY INFO=True;USER ID=HR;PASSWORD=hr")
    Private Sub studentRep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()   'Make it Center of the screen
        Me.Refresh()
        updateGrid()
    End Sub
    Private Sub updateGrid()
        dgv.BackgroundColor = Color.White
        dgv.ForeColor = Color.Black
        dgv.Columns.Clear()
        dgv.Rows.Clear()
        dgv.Columns.Add("colREG_ID", "Registration No")
        dgv.Columns.Add("colNAME", "Full Name")
        dgv.Columns.Add("colCLASS", "Class")
        dgv.Columns.Add("colDATED", "Date Joined")
        dgv.Columns.Add("colALLOC_ROOM", "Room No.")
        dgv.Columns.Add("colPHONE", "Phone No")
        con.Open()
        Dim command As OracleCommand = con.CreateCommand()
        command.CommandText = "SELECT * FROM STUDENT"
        Dim oraclereader As OracleDataReader = command.ExecuteReader()
        While oraclereader.Read()
            dgv.Rows.Add({oraclereader.Item("REG_ID"), oraclereader.Item("NAME"), oraclereader.Item("CLASS"), oraclereader.Item("DATED"), oraclereader.Item("ALLOC_ROOM"), oraclereader.Item("PHONE")})
        End While
        con.Close()
        dgv.Sort(dgv.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
    End Sub
    Private Sub btnBck_Click(sender As Object, e As EventArgs) Handles btnBck.Click
        dash.Show()
        Me.Hide()
    End Sub
End Class