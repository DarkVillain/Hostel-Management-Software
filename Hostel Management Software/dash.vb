Public Class dash
    Private Sub dash_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        lblUSR.Text = Login.txtBoxName.Text

    End Sub

    Private Sub StudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentToolStripMenuItem.Click



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

        leaveEntry.Show()


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

    Private Sub lblUSR_Click(sender As Object, e As EventArgs) Handles lblUSR.Click



    End Sub
End Class