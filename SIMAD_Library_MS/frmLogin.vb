Imports System.Data.SqlClient
Public Class frmLogin
    Dim counter As String = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        openConne()
        query = "select * from tbl_Login where Username = '" & txtUsername.Text & "'"
        cmd = New SqlCommand(query, con)


        dr = cmd.ExecuteReader
        If dr.Read = True Then
            query = "select * from tbl_login where Password = '" & txtPassword.Text & "' and Username = '" & txtUsername.Text & "' "
            cmd = New SqlCommand(query, con)
            dr.Close()
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                Me.Hide()
                frmMain.Show()
                frmMain.lblLogedInUser.Text = logeinUser
                counter = 0
                txtPassword.Clear()
                txtUsername.Clear()
                txtUsername.Focus()
            Else
                MsgBox("Passwrd is incorrect", MsgBoxStyle.Exclamation)
                counter += 1
                ' Exit Sub
            End If
            dr.Close()

        Else
            MsgBox("Invalid Username", MsgBoxStyle.Exclamation, "Incorret Password")
            counter += 1
        End If
        If counter = 3 Then
            txtPassword.Text = ""
            txtUsername.Text = ""
            txtUsername.Focus()
            MsgBox("You have intered Have reached 3 times of attempt..", MsgBoxStyle.Exclamation)
            Me.Close()
        End If
        dr.Close()

    End Sub

    Private Sub btnCLose_Click(sender As Object, e As EventArgs)
        Dim close = MsgBox("Are you sure to close the program", MsgBoxStyle.YesNo Or MsgBoxStyle.Information, "Login")
        If close = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim close = MsgBox("Are you sure to close", MsgBoxStyle.YesNo Or MsgBoxStyle.Information, "Closing Login")
        If close = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox4.Hide()
        PictureBox5.Hide()
        lblShowHidePass.Hide()

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        txtPassword.UseSystemPasswordChar = False
        PictureBox4.Show()
        PictureBox5.Hide()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        txtPassword.UseSystemPasswordChar = True
        PictureBox5.Show()
        PictureBox4.Hide()
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        If txtPassword.Text <> "" Then
            PictureBox4.Show()
            PictureBox5.Show()
        End If
    End Sub

    Private Sub PictureBox5_MouseHover(sender As Object, e As EventArgs) Handles PictureBox5.MouseHover
        lblShowHidePass.Show()
        lblShowHidePass.Text = "Show"
    End Sub

    Private Sub PictureBox5_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox5.MouseLeave
        lblShowHidePass.Hide()
    End Sub

    Private Sub PictureBox4_MouseHover(sender As Object, e As EventArgs) Handles PictureBox4.MouseHover
        lblShowHidePass.Show()
        lblShowHidePass.Text = "Hide"

    End Sub

    Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox4.MouseLeave
        lblShowHidePass.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        frmForgetPassword.Show()
    End Sub
End Class
