Imports System.Data.SqlClient
Public Class frmForgetPassword
    Private Sub frmForgetPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox2.Hide()
        PictureBox3.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim closing = MsgBox("Are you sure to close", MsgBoxStyle.YesNo)
        If closing = DialogResult.Yes Then
            Me.Hide()
            frmLogin.Show()
        End If
    End Sub

    Sub clearTextBox()
        txtUsername.Text = ""
        txtSecretCode.Text = ""
        txtSecA.Text = ""
        txtPassword.Text = ""
        txtEmail.Text = ""
        txtConfirmPass.Text = ""
        cmbSecQ.SelectedIndex = -1
        GroupBox2.Enabled = False
        GroupBox1.Enabled = True
        txtUsername.Focus()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim close = MsgBox("Are you sure To close the program", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, "Closing Forget Password")
        If close = DialogResult.Yes Then
            Me.Hide()
            frmLogin.Show()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Not txtPassword.Text = txtConfirmPass.Text Then
            MsgBox("Both password Does't Match Please Check Again", MsgBoxStyle.Exclamation, "Mismatch Password")
            Exit Sub
        End If
        Do_Operations("update tbl_Login Set Password = '" & txtPassword.Text & "'")
        MsgBox("Succesfully Recovered Password", MsgBoxStyle.Information, "Password Recovered")
        clearTextBox()
        Me.Hide()
        frmLogin.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        openConne()
        If txtUsername.Text = "" Then
            MsgBox("Please Enter Username...", MsgBoxStyle.Exclamation)
            Exit Sub
        ElseIf txtEmail.Text = "" Then
            MsgBox("Please Enter Email...", MsgBoxStyle.Exclamation)
            Exit Sub
        ElseIf cmbSecQ.Text = "" Then
            MsgBox("Please Choose Security Question...", MsgBoxStyle.Exclamation)
            Exit Sub
        ElseIf txtSecA.Text = "" Then
            MsgBox("Please Enter Security Answer...", MsgBoxStyle.Exclamation)
            Exit Sub
        ElseIf txtSecretCode.Text = "" Then
            MsgBox("Please Enter Secret Code...", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        query = "select * from tbl_Login where  Username = '" & txtUsername.Text & "' "
        cmd = New SqlCommand(query, con)
        dr = cmd.ExecuteReader
        If dr.Read = False Then
            MsgBox("Ivalid Username", MsgBoxStyle.Exclamation)
        Else
            dr.Close()
            query = "select Email from tbl_Login where Username ='" & txtUsername.Text & "' and Email ='" & txtEmail.Text & "'"
            cmd = New SqlCommand(query, con)
            dr = cmd.ExecuteReader
            If dr.Read = False Then
                MsgBox("Invalid Email", MsgBoxStyle.Exclamation)
            Else
                dr.Close()
                query = "select [Security Question] from tbl_Login where [Security Question] = '" & cmbSecQ.Text & "' and Username = '" & txtUsername.Text & "'"
                cmd = New SqlCommand(query, con)
                dr = cmd.ExecuteReader
                If dr.Read = False Then
                    MsgBox("Invalid Security Question Please choose the right one", MsgBoxStyle.Exclamation)
                Else
                    dr.Close()
                    query = "select [Security Answer] from tbl_Login where Username = '" & txtUsername.Text & "' and [Security Answer] = '" & txtSecA.Text & "'"
                    cmd = New SqlCommand(query, con)
                    dr = cmd.ExecuteReader
                    If dr.Read = False Then
                        MsgBox("Invalid Security Answer")
                    Else
                        dr.Close()
                        query = "select [Secret Code] from tbl_Login where Username = '" & txtUsername.Text & "' and [Secret Code] = '" & txtSecretCode.Text & "'"
                        cmd = New SqlCommand(query, con)
                        dr = cmd.ExecuteReader
                        If dr.Read = False Then
                            MsgBox("Invalid Secret Code", MsgBoxStyle.Exclamation)
                        Else
                            dr.Close()
                            query = "select * from tbl_login where Username = '" & txtUsername.Text & "' and Email = '" & txtEmail.Text & "' and [Security Question] = '" & cmbSecQ.Text & "' and [Security Answer] = '" & txtSecA.Text & "' and [Secret Code] = '" & txtSecretCode.Text & "' "
                            cmd = New SqlCommand(query, con)
                            dr = cmd.ExecuteReader
                            If dr.Read = False Then
                                MsgBox("SomeThing is Wrong", MsgBoxStyle.Exclamation)
                            Else
                                GroupBox2.Enabled = True
                                GroupBox1.Enabled = False
                            End If
                        End If

                    End If
                End If

            End If
        End If




    End Sub

    Private Sub txtSecretCode_TextChanged(sender As Object, e As EventArgs) Handles txtSecretCode.TextChanged
        txtSecretCode.MaxLength = 4
        If Not IsNumeric(txtSecretCode.Text) Then
            txtSecretCode.Text = ""
            MsgBox("Only Numbers are allowed here !!!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        txtPassword.UseSystemPasswordChar = False
        txtConfirmPass.UseSystemPasswordChar = False
        PictureBox2.Hide()
        PictureBox3.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        txtPassword.UseSystemPasswordChar = True
        txtConfirmPass.UseSystemPasswordChar = True
        PictureBox2.Show()
        PictureBox3.Hide()
    End Sub

    Private Sub txtConfirmPass_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmPass.TextChanged
        If Not txtConfirmPass.Text = "" Or txtPassword.Text = "" Then
            PictureBox3.Show()
            PictureBox2.Show()
        Else
            PictureBox2.Hide()
            PictureBox3.Hide()
        End If
    End Sub
End Class