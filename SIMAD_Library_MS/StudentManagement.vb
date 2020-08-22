Imports System.Data.SqlClient
Public Class StudentManagement
    Private Sub cmbFaculty_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFaculty.SelectedIndexChanged
        openConne()

        query = "Select * from tblStudent where Faculty = '" & cmbFaculty.Text & "' "
        da = New SqlDataAdapter(query, con)
        ds.Clear()
        da.Fill(ds, "DGVCS")
        dgvStInfo.DataSource = ds.Tables("DGVCS")

        query = "select COUNT(StudentID) from tblStudent where Faculty = '" & cmbFaculty.Text & "' "
        cmd = New SqlCommand(query, con)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            lblResult.Text = dr.Item(0)
        End If
        dr.Close()

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

    Private Sub cmbProgram_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProgram.SelectedIndexChanged
        openConne()
        query = "Select * from tblStudent where Program = '" & cmbProgram.Text & "' "
        da = New SqlDataAdapter(query, con)
        ds.Clear()
        da.Fill(ds, "DGVCS")
        dgvStInfo.DataSource = ds.Tables("DGVCS")

        query = "select COUNT(StudentID) from tblStudent where Program = '" & cmbProgram.Text & "' "
        cmd = New SqlCommand(query, con)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            lblResult.Text = dr.Item(0)
        End If
        dr.Close()

    End Sub

    Private Sub StudentManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NumOfShowingRecord()
        Label5.Hide()
        display()
        dgvStInfo.AllowUserToAddRows = False
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtNameSearch.TextChanged
        openConne()
        query = "select * from tblStudent where CONCAT ([Full Name], [Sponser Name]) like '%" & txtNameSearch.Text & "%' "
        da = New SqlDataAdapter(query, con)
        ds.Clear()
        da.Fill(ds, "DGV")
        dgvStInfo.DataSource = ds.Tables("DGV")

        query = "select COUNT(StudentID) from tblStudent where [Full Name] like '%" & txtNameSearch.Text & "%' "
        cmd = New SqlCommand(query, con)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            lblResult.Text = dr.Item(0)
        End If
        dr.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmStudentReg.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim warning = MsgBox("Are you sure to Delete", MsgBoxStyle.YesNo Or MsgBoxStyle.Information, "Deleting")
        If warning = DialogResult.Yes Then
            Do_Operations("Delete from tblStudent where StudentID = '" & dgvStInfo.CurrentRow.Cells(0).Value & "'")
            MsgBox("Deleted Succesfully", MsgBoxStyle.Information, "Deleted...")
            display()
        End If
    End Sub
    Sub display()
        openConne()
        query = "Select * from tblStudent  "
        da = New SqlDataAdapter(query, con)
        ds.Clear()
        da.Fill(ds, "DGVCS")
        dgvStInfo.DataSource = ds.Tables("DGVCS")


    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim closing = MsgBox("Are you sure to close", MsgBoxStyle.Information Or MsgBoxStyle.YesNo, "Closing Student Management")
        If closing = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim warm = MsgBox("Are you sure to update", MsgBoxStyle.Information Or MsgBoxStyle.YesNo, "Update")
        If warm = DialogResult.Yes Then
            Do_Operations("Update tblStudent set [Full Name] = '" & dgvStInfo.CurrentRow.Cells(1).Value & "', Gender = '" & dgvStInfo.CurrentRow.Cells(2).Value & "' , [Date Of Birth] = '" & dgvStInfo.CurrentRow.Cells(3).Value & "' , [Address] = '" & dgvStInfo.CurrentRow.Cells(4).Value & "' , [Email] = '" & dgvStInfo.CurrentRow.Cells(5).Value & "' , [Telephone] = '" & dgvStInfo.CurrentRow.Cells(6).Value & "' , [Faculty] = '" & dgvStInfo.CurrentRow.Cells(7).Value & "' , [Program] = '" & dgvStInfo.CurrentRow.Cells(8).Value & "' , [Semister] = '" & dgvStInfo.CurrentRow.Cells(9).Value & "' , [Sponser Name] = '" & dgvStInfo.CurrentRow.Cells(10).Value & "' , [Sponser Tell] = '" & dgvStInfo.CurrentRow.Cells(11).Value & "'   where [StudentID] = '" & dgvStInfo.CurrentRow.Cells(0).Value & "' ")
            MsgBox("Sucesfully Updated", MsgBoxStyle.Information, "Updated")
            display()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
    Sub NumOfShowingRecord()
        openConne()
        query = "select COUNT(StudentID)  from tblStudent"
        cmd = New SqlCommand(query, con)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            lblResult.Text = dr.Item(0)
        End If
        dr.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        display()
        NumOfShowingRecord()
        cmbProgram.SelectedIndex = -1
        cmbFaculty.SelectedIndex = -1
        txtNameSearch.Text = ""
    End Sub

    Private Sub PictureBox3_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox3.MouseEnter
        Label5.Show()
    End Sub

    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox3.MouseLeave
        Label5.Hide()
    End Sub

    Private Sub PictureBox3_Enter(sender As Object, e As EventArgs) Handles PictureBox3.Enter
        Label5.Show()
    End Sub
End Class