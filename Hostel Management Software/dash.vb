Imports Oracle.DataAccess.Client
Imports System.IO
Public Class dash
    Dim con As New Oracle.DataAccess.Client.OracleConnection("DATA SOURCE=localhost:1521/orclpdb;PERSIST SECURITY INFO=True;USER ID=HR;PASSWORD=hr")
    Private Sub dash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call CenterToScreen()
        Me.FormBorderStyle = FormBorderStyle.Sizable
        Me.WindowState = FormWindowState.Maximized
        ' Above line will make it fullscreen
        tsslNm.Text = Login.txtUm.Text
        tsslTd.Text = Now
        Me.Refresh()
        btnClick.PerformClick()
        Timer2.Start()
        Timer2.Interval = 1000
        updateGrid()
    End Sub
    Private Sub updateGrid()
        dgv.BackgroundColor = Color.White
        dgv.ForeColor = Color.Black
        dgv.Columns.Clear()
        dgv.Rows.Clear()
        dgv.Columns.Add("colREG_ID", "Reg id")
        dgv.Columns.Add("colNAME", "Name")
        dgv.Columns.Add("colCLASS", "Class")
        dgv.Columns.Add("colDATED", "Date Joined")
        dgv.Columns.Add("colALLOC_ROOM", "Room")
        dgv.Columns.Add("colPHONE", "Phone No")
        con.Open()
        Dim command As OracleCommand = con.CreateCommand()
        command.CommandText = "SELECT * FROM STUDENT"
        Dim oraclereader As OracleDataReader = command.ExecuteReader()
        While oraclereader.Read()
            dgv.Rows.Add({oraclereader.Item("REG_ID"), oraclereader.Item("NAME"), oraclereader.Item("ALLOC_ROOM"), oraclereader.Item("CLASS"), oraclereader.Item("DATED"), oraclereader.Item("PHONE")})
        End While
        con.Close()
    End Sub
    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        addStudent.Show()
    End Sub
    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        editStudent.Show()
    End Sub
    Private Sub AddMaterialsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddMaterialsToolStripMenuItem.Click
        addMaterials.Show()
    End Sub
    Private Sub EditMaterialsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditMaterialsToolStripMenuItem.Click
        editMaterials.Show()
    End Sub
    Private Sub EnterUsageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnterUsageToolStripMenuItem.Click
        enterUsage.Show()
    End Sub
    Private Sub EditUsageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditUsageToolStripMenuItem.Click
        editUsage.Show()
    End Sub
    Private Sub LeaveEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeaveEntryToolStripMenuItem.Click
        addLeave.Show()
    End Sub
    Private Sub EditEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditEntryToolStripMenuItem.Click
        editEntry.Show()
    End Sub
    Private Sub EnterExpensesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnterExpensesToolStripMenuItem.Click
        addExpenses.Show()
    End Sub
    Private Sub EditExpensesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditExpensesToolStripMenuItem.Click
        editExpenses.Show()
    End Sub
    Private Sub BillsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BillsToolStripMenuItem.Click
        billings.Show()
    End Sub
    Private Sub StudentReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentReportsToolStripMenuItem.Click
        studentRep.Show()
    End Sub
    Private Sub MaterialReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaterialReportToolStripMenuItem.Click
        materialRep.Show()
    End Sub
    Private Sub DailyUsageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DailyUsageToolStripMenuItem.Click
        dailyUsageRep.Show()
    End Sub
    Private Sub LeaveEntryToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LeaveEntryToolStripMenuItem1.Click
        leaveRep.Show()
    End Sub
    Private Sub ExpensesEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExpensesEntryToolStripMenuItem.Click
        expensesRep.Show()
    End Sub
    Private Sub btnClick_Click(sender As Object, e As EventArgs) Handles btnClick.Click
        updateGrid()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Start()
        tsslTd.Text = Now
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        btnClick.PerformClick()
    End Sub
End Class