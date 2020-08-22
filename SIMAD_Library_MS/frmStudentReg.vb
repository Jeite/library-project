Imports System.Data.SqlClient
Imports System.IO
Public Class frmStudentReg
    Dim pic As String
    Dim opf As New OpenFileDialog
    Dim i As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim close = MsgBox("Are you Sure to close", MsgBoxStyle.YesNo)
        If close = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub frmStudentReg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerateID()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim cls = MsgBox("Are you sure to close", MsgBoxStyle.YesNo Or MsgBoxStyle.Information)
        If cls = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub cmbFaculty_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFaculty.SelectedIndexChanged
        If cmbFaculty.SelectedIndex = 0 Then
            cmbProgram.Items.Clear()
            cmbProgram.Items.Add("Computer Science")
            cmbProgram.Items.Add("Information Technology")
            cmbProgram.Items.Add("Multimedia")
        ElseIf cmbFaculty.SelectedIndex = 1 Then
            cmbProgram.Items.Clear()
            cmbProgram.Items.Add("Civil Engineering")
            cmbProgram.Items.Add("Electric Engineering")
            cmbProgram.Items.Add("Telecommication Engineering")
        ElseIf cmbFaculty.SelectedIndex = 2 Then
            cmbProgram.Items.Clear()
            cmbProgram.Items.Add("Accounting")
            cmbProgram.Items.Add("Bussines")
            cmbProgram.Items.Add("Public Administration")
        ElseIf cmbFaculty.SelectedIndex = 3 Then
            cmbProgram.Items.Clear()
            cmbProgram.Items.Add("Nursing")
            cmbProgram.Items.Add("General Medicine")
        Else
            cmbProgram.Items.Clear()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        opf.Filter = Nothing
        pic = opf.FileName
        opf.ShowDialog()
        PBSTimage.Image = Image.FromFile(opf.FileName)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim warning = MsgBox("Are you sure to Save....", MsgBoxStyle.Information Or MsgBoxStyle.YesNo, "Saving New Student")
        If warning = DialogResult.Yes Then
            Try
                openConne()
                Using cmd = New SqlCommand("Insert into tblStudent(StudentID,[Full Name],Gender,[Date Of Birth],Address,Email,Telephone,Faculty,Program,Semister,[Sponser Name],[Sponser Tell],[Student Image]) Values ('" & txtStdID.Text & "','" & txtFullName.Text & "','" & cmbGender.Text & "','" & dTpDateOfBirth.Text & "','" & txtAddress.Text & "','" & txtEmail.Text & "','" & txtTell.Text & "','" & cmbFaculty.Text & "','" & cmbProgram.Text & "','" & txtSemister.Text & "','" & txtSponserName.Text & "','" & txtSponserTell.Text & "', @studImages)", con)
                    cmd.Parameters.Add("@studImages", SqlDbType.Image).Value = IO.File.ReadAllBytes(opf.FileName)
                    i = cmd.ExecuteNonQuery
                End Using

                If i > 0 Then
                    MsgBox("Succesfully Saved")
                    PBSTimage.Image = Nothing
                    opf.FileName = Nothing
                    pic = ""
                    clearFields()
                    GenerateID()
                End If
            Catch ex As Exception
                MsgBox("Please Choose Image.....", MsgBoxStyle.Information)
            End Try
        End If

    End Sub

    Sub GenerateID()
        Dim x As String
        Dim y As String

        y = "Std20180610000"
        openConne()
        query = "Select count(StudentID) from tblStudent"
        cmd = New SqlCommand(query, con)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            x = dr.Item(0) + 1
            txtStdID.Text = y + x
        End If
    End Sub

    Sub clearFields()
        txtAddress.Text = ""
        txtEmail.Text = ""
        txtFullName.Text = ""
        txtSemister.Text = ""
        txtSponserName.Text = ""
        txtSponserTell.Text = ""
        txtTell.Text = ""
        cmbFaculty.SelectedIndex = -1
        cmbProgram.SelectedIndex = -1
        cmbGender.SelectedIndex = -1
        txtStdID.Text = ""
        PBSTimage.Image = Nothing
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PBSTimage.Image = Nothing
        opf.FileName = Nothing
        pic = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        StudentManagement.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class