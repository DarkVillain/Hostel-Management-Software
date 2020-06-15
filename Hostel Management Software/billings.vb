Imports Oracle.DataAccess.Client
Public Class billings
    Dim con As New OracleConnection("DATA SOURCE=localhost:1521/orclpdb;PERSIST SECURITY INFO=True;USER ID=HR;PASSWORD=hr")
    Private Sub billings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateCombo()

        Me.CenterToScreen()   'Make it Center of the screen
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