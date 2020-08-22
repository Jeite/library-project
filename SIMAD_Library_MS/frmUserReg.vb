Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class frmUserReg
    Private Sub FfrmUserReg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCheckUsername.Hide()
        PictureBox2.Hide()
        PictureBox3.Hide()
    End Sub

    Private Sub txtSecretCode_TextChanged(sender As Object, e As EventArgs) Handles txtSecretCode.TextChanged
        txtSecretCode.MaxLength = 4
        If Not IsNumeric(txtSecretCode.Text) Then
            txtSecretCode.Clear()
            MsgBox("Only  Numbers Are allowed Here", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
    End Sub

    Private Sub btnGetData_Click(sender As Object, e As EventArgs) Handles btnGetData.Click
        Me.Hide()
        frmUserManage.Show()
    End Sub

    Sub texBoxClear()
        txtFullName.Text = ""
        txtEmail.Text = ""
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtConPass.Text = ""
        cmbSecQ.SelectedIndex = -1
        txtSecA.Text = ""
        txtSecretCode.Text = ""
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        Dim closin = MsgBox("Are you sure to close", MsgBoxStyle.YesNo)
        If closin = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim close = MsgBox("Are you sure to Close", MsgBoxStyle.YesNo, "Closing User Registration")
        If close = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim cls = MsgBox("Ma Hubtaa in aad ka baxeysid", MsgBoxStyle.YesNo Or MsgBoxStyle.Information)
        If cls = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim close = MsgBox("Ma hubtaa in aad ka baxeysid", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation)
        If close = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PictureBox2.Hide()
        txtPassword.UseSystemPasswordChar = True
        txtConPass.UseSystemPasswordChar = True
        PictureBox3.Show()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        PictureBox3.Hide()
        txtPassword.UseSystemPasswordChar = False
        txtConPass.UseSystemPasswordChar = False
        PictureBox2.Show()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not txtPassword.Text = txtConPass.Text Then
            MsgBox("Both Password Does't Match... PLease Check and try again", MsgBoxStyle.Exclamation, "Mismatch Password")
            Exit Sub
        End If
        Dim warning = MsgBox("Are you sure to save this user", MsgBoxStyle.YesNo Or MsgBoxStyle.Information, "Adding New User........")
        If warning = DialogResult.Yes Then

            openConne()
            query = "select * from tbl_Login where Username = '" & txtUsername.Text & "'"
            cmd = New SqlCommand(query, con)
            dr = cmd.ExecuteReader
            If dr.Read = False Then
                Do_Operations("Insert into tbl_Login values ('" & txtFullName.Text & "','" & txtEmail.Text & "','" & txtUsername.Text & "','" & txtPassword.Text & "','" & cmbSecQ.Text & "','" & txtSecA.Text & "','" & txtSecretCode.Text & "')")
                MsgBox("Sucesfully Created User:- '" & txtUsername.Text & "'.")
                texBoxClear()
                Exit Sub
            Else
                MsgBox("User:- '" & txtUsername.Text & "' Is already Registered in our database Please try another one", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            dr.Close()

        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        txtPassword.MaxLength = 15
        If txtPassword.Text <> "" Then
            PictureBox3.Show()
            PictureBox2.Show()
        Else
            PictureBox3.Hide()
            PictureBox2.Hide()
        End If
    End Sub

    Private Sub txtConPass_TextChanged(sender As Object, e As EventArgs) Handles txtConPass.TextChanged
        txtConPass.MaxLength = 15
    End Sub
End Class