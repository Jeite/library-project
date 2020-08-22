Imports System.Data.SqlClient
Public Class frmChangePass
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        openConne()
        query = "Select * from tbl_login where Username ='" & txtUsername.Text & "' and  Password = '" & txtPassword.Text & "'"
        cmd = New SqlCommand(query, con)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            MsgBox("Enter New Password", MsgBoxStyle.Information)
            GroupBox2.Enabled = True
        Else
            MsgBox("Something is Wrong", MsgBoxStyle.Exclamation)
            GroupBox2.Enabled = False
        End If
        dr.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim exitt = MsgBox("Are you sure to close the application", MsgBoxStyle.YesNo)
        If exitt = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Not txtNewPass.Text = txtConPass.Text Then
            MsgBox("Password ka isma laha Fadlan iska Hubi", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Do_Operations("Update tbl_login set Password = '" & txtNewPass.Text & "' where Username='" & txtUsername.Text & "'")
        MsgBox("Succesfully Change the Password", MsgBoxStyle.Information)
        txtBoxClear()
        GroupBox2.Enabled = False
    End Sub

    Sub txtBoxClear()
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtNewPass.Text = ""
        txtConPass.Text = ""
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim closin = MsgBox("Are you sure to close", MsgBoxStyle.YesNo Or MsgBoxStyle.Information, "Closing CHange Password")
        If closin = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

End Class