Imports System.IO
Imports System.Configuration
Imports Oracle.DataAccess.Client
Public Class addStudent

    Dim con As New Oracle.DataAccess.Client.OracleConnection("DATA SOURCE=localhost:1521/orclpdb;PERSIST SECURITY INFO=True;USER ID=HR;PASSWORD=hr")
    'connection done here 
    Private Sub addStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub txtRn_TextChanged(sender As Object, e As EventArgs) Handles txtRn.TextChanged

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        con.Open()

        Dim command As Oracle.DataAccess.Client.OracleCommand = con.CreateCommand()
        dtp.Text = DateTime.Now.ToString("dd/MM/yyyy")
        command.CommandText = " INSERT INTO student(reg_id, name, fat_name, class, dated, alloc_room, image) VALUES ('" & txtRn.Text & "','" & txtNm.Text & "','" & txtFn.Text & "','" & cmbYr.Text & "','" & dtp.Text & "','" & cmbAr.Text & "','" & pbPic.Name & "')"

        txtRn.Text = " "
        txtNm.Text = " "
        txtFn.Text = " "
        cmbYr.Text = " "
        'dtp.Value = " "
        cmbAr.Text = " "
        pbPic.Image = Nothing
        txtPic.Text = " "


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

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ofgUp.FileOk



    End Sub

    Private Sub pbPic_Click(sender As Object, e As EventArgs) Handles pbPic.Click

    End Sub

    Private Sub btnBrws_Click(sender As Object, e As EventArgs) Handles btnBrws.Click

        ofgUp.ShowDialog()
        '
        txtPic.Text = ofgUp.FileName

        pbPic.Image = Image.FromFile(txtPic.Text)

    End Sub
End Class