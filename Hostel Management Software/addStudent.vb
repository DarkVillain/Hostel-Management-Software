Imports Oracle.DataAccess.Client
Public Class addStudent

    Dim con As New Oracle.DataAccess.Client.OracleConnection("DATA SOURCE=localhost:1521/orclpdb;PERSIST SECURITY INFO=True;USER ID=HR;PASSWORD=hr")
    'connection done here 
    Private Sub addStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub txtRn_TextChanged(sender As Object, e As EventArgs) Handles txtRn.TextChanged

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        con.Open()

        Dim command As Oracle.DataAccess.Client.OracleCommand = con.CreateCommand()
        command.CommandText = " INSERT INTO STUDENT VALUES ('" & txtRn.Text & "','" & txtNm.Text & "','" & txtFn.Text & "','" & cmbYr.Text & "','" & dtp.Text & "','" & cmbAr.Text & "')"

        txtRn.Text = " "
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

        con.Close()


    End Sub

    Private Sub btnBck_Click(sender As Object, e As EventArgs) Handles btnBck.Click

        dash.Show()
        Me.Hide()

    End Sub

End Class