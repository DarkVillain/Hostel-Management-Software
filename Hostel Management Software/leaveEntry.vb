Imports System.IO
Imports System.Configuration
Imports Oracle.DataAccess.Client
Public Class addLeave

    Dim con As New Oracle.DataAccess.Client.OracleConnection("DATA SOURCE=localhost:1521/orclpdb;PERSIST SECURITY INFO=True;USER ID=HR;PASSWORD=hr")
    Private Sub btnBck_Click(sender As Object, e As EventArgs) Handles btnBck.Click

        dash.Show()
        Me.Hide()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        con.Open()
        Dim command As OracleCommand = con.CreateCommand()
        command.CommandText = " INSERT INTO LEAVE VALUES ('" & txtEi.Text & "','" & cmbRn.Text & "','" & cmbCz.Text & "','" & dtpFrm.Text & "','" & dtpTo.Text & "', " & txtSpn.Text & ")"
        txtEi.Text = " "
        cmbRn.Text = " "
        cmbCz.Text = " "
        txtSpn.Text = " "
        If command.ExecuteNonQuery() > 0 Then
            MsgBox("Data has been saved!")
        Else
            MsgBox("Error, while saving data!")
        End If
        con.Close()

    End Sub

    Private Sub dtpFrm_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRn.SelectedIndexChanged

    End Sub

    Private Sub btnCd_Click(sender As Object, e As EventArgs) Handles btnCd.Click
        'ei code 2 ta date er majher din gune textbox e store korbe.
        Dim dt1 As DateTime = Convert.ToDateTime(dtpFrm.Value.ToString("dd/MM/yyy"))
        Dim dt2 As DateTime = Convert.ToDateTime(dtpTo.Value.ToString("dd/MM/yyy"))
        Dim ts As TimeSpan = dt2.Subtract(dt1)
        If Convert.ToInt32(ts.Days) >= 0 Then
            txtSpn.Text = Convert.ToInt32(ts.Days) 'Stored to textBox
        Else
            MessageBox.Show("Please Check It's Invalid Input")
        End If

    End Sub

    Private Sub leaveEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CenterToScreen()

    End Sub
End Class