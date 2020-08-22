Imports System.Data.SqlClient
Public Class FrmBookBarrow
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim close = MsgBox("Are you Sure to Close", MsgBoxStyle.YesNo)
        If close = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim cls = MsgBox("are you sure to close", MsgBoxStyle.Information Or MsgBoxStyle.YesNo)
        If cls = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategory.SelectedIndexChanged
        openConne()
        query = "Select * from tblBookReg where  Category = '" & cmbCategory.Text & "' "
        cmd = New SqlCommand(query, con)
        dr = cmd.ExecuteReader
        While dr.Read = True
            cmbAuthor.Items.Clear()
            cmbAuthor.Text = ""
            cmbAuthor.Items.Add(dr.Item(2)).ToString
            Exit Sub
        End While
        If dr.Read = False Then
            cmbAuthor.Items.Clear()
            cmbAuthor.Text = ""
        End If
        dr.Close()
    End Sub

    Private Sub cmbAuthor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAuthor.SelectedIndexChanged
        openConne()
        query = "Select * from tblBookReg where Author = '" & cmbAuthor.Text & "' "
        cmd = New SqlCommand(query, con)
        dr = cmd.ExecuteReader
        While dr.Read = True
            cmbTitle.Items.Clear()
            cmbTitle.Items.Add(dr.Item(1))
            'GroupBox2.Enabled = True
            Exit Sub
        End While
        If dr.Read = False Then
            cmbTitle.Items.Clear()
        End If
        dr.Close()
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProgram.SelectedIndexChanged
        openConne()
        query = "Select * from tblStudent where Program = '" & cmbProgram.Text & "'"
        cmd = New SqlCommand(query, con)
        dr = cmd.ExecuteReader
        While dr.Read = True
            cmbSname.Items.Clear()
            cmbSname.Text = ""
            cmbSname.Items.Add(dr.Item(1))
            Exit Sub
        End While

        If dr.Read = False Then
            cmbSname.Items.Clear()
            cmbSname.Text = ""
        End If
        dr.Close()
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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Do_Operations("Update tblBookReg set Quantity = Quantity -1 where [Book Title] = '" & cmbTitle.Text & "' and Author = '" & cmbAuthor.Text & "' ")
        ' MsgBox("Updated", MsgBoxStyle.Information)
        Do_Operations("Insert into tblBookBarrow ([Book Title], [Student Name], [Date Borrowed],[Date Will Return]) Values ('" & cmbTitle.Text & "' , '" & cmbSname.Text & "' , '" & DTborrowed.Text & "', '" & DTwReturn.Text & "' )")
        MsgBox("Succesfully Borrowed Book Of " & cmbTitle.Text & " to The " & cmbSname.Text & "...", MsgBoxStyle.Information)

        cmbFaculty.Text = ""
        cmbAuthor.Text = ""
        cmbFaculty.Text = ""
        cmbProgram.Text = ""
        cmbSname.Text = ""
        cmbTitle.Text = ""



        cmbAuthor.Items.Clear()
        cmbCategory.Items.Clear()
        cmbSname.Items.Clear()
        cmbFaculty.Items.Clear()
        cmbTitle.Items.Clear()
        cmbProgram.Items.Clear()
        DTborrowed.ResetText()
        DTwReturn.ResetText()
    End Sub

    Private Sub FrmBookBarrow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class