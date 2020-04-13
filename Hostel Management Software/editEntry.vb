Imports System.IO
Imports System.Configuration
Imports Oracle.DataAccess.Client
Public Class editEntry
    Dim con As New Oracle.DataAccess.Client.OracleConnection("DATA SOURCE=localhost:1521/orclpdb;PERSIST SECURITY INFO=True;USER ID=HR;PASSWORD=hr")
    Private Sub editEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CenterToScreen()   'Make it Center of the screen
        updateCombo()


    End Sub

    Private Sub updateCombo()

        cmbEi.Items.Clear()

        con.Open()
        Dim command As OracleCommand = con.CreateCommand()
        command.CommandText = "SELECT ENTRY_ID FROM LEAVE"
        Dim oraclereader As OracleDataReader = command.ExecuteReader()

        While oraclereader.Read()
            cmbEi.Items.Add(oraclereader.Item("ENTRY_ID"))
        End While
        con.Close()

    End Sub

    Private Sub btnUpdt_Click(sender As Object, e As EventArgs) Handles btnUpdt.Click

        con.Open()
        Dim command As OracleCommand = con.CreateCommand()
        command.CommandText = "UPDATE LEAVE SET REG_ID = " & txtRn.Text & ",'" & cmbCz.Text & "','" & dtpFrm.Text & "','" & dtpTo.Text & "' WHERE ENTRY_ID=" & cmbEi.SelectedItem
        cmbEi.Text = " "
        txtRn.Text = " "
        cmbCz.Text = " "
        If command.ExecuteNonQuery() > 0 Then
            MsgBox("Data has been saved!")
        Else
            MsgBox("Error, while saving data!")
        End If
        con.Close()
        updateCombo()

    End Sub

    Private Sub btnBck_Click(sender As Object, e As EventArgs) Handles btnBck.Click

        dash.Show()
        Me.Hide()

    End Sub
End Class