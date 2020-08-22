Imports System.Data.SqlClient
Public Class frmManageBooks
    Private Sub frmManageBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillDGV()

        DGVMngBook.Columns(0).Width = 100
        DGVMngBook.Columns(1).Width = 150
        DGVMngBook.Columns(2).Width = 150
        DGVMngBook.Columns(5).Width = 150
        DGVMngBook.Columns(4).Width = 150

        totalBooks()


    End Sub

    Sub totalBooks()
        openConne()
        query = "select SUM(Quantity) from tblBookReg "
        cmd = New SqlCommand(query, con)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            lblTotalBookInStore.Text = dr.Item(0)
        End If

    End Sub
    Sub fillDGV()
        openConne()
        query = "select * from tblBookReg "
        da = New SqlDataAdapter(query, con)
        ds.Clear()
        da.Fill(ds, "DGV1B")
        DGVMngBook.DataSource = ds.Tables("DGV1B")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim closing = MsgBox("Are  you sure to close", MsgBoxStyle.Information Or MsgBoxStyle.YesNo, "Closing Book Management")
        If closing = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        search()
    End Sub

    Sub search()

        openConne()
            query = "select * from tblBookReg where CONCAT ([Book Title], Author, Category) like '%" & txtSearch.Text & "%' "
            da = New SqlDataAdapter(query, con)
            ds.Clear()
            da.Fill(ds, "DGV")
            DGVMngBook.DataSource = ds.Tables("DGV")

    End Sub

    Private Sub txtSearch_OnValueChanged(sender As Object, e As EventArgs) Handles txtSearch.OnValueChanged
        search()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim warning = MsgBox("Are you sure to Delete", MsgBoxStyle.Information Or MsgBoxStyle.YesNo)
        If warning = DialogResult.Yes Then
            openConne()
            query = "Delete from tblBookReg Where BooKID = '" & DGVMngBook.CurrentRow.Cells(0).Value & "' "
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("Succesfully Deleted...", MsgBoxStyle.Information)
            fillDGV()
            totalBooks()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmBookReg.ShowDialog()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        fillDGV()
        totalBooks()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim warning = MsgBox("Are you sure to Update", MsgBoxStyle.Information Or MsgBoxStyle.YesNo)
        If warning = DialogResult.Yes Then
            Do_Operations("Update tblBookReg set [Book Title] = '" & DGVMngBook.CurrentRow.Cells(1).Value & "' , Author = '" & DGVMngBook.CurrentRow.Cells(2).Value & "', Category = '" & DGVMngBook.CurrentRow.Cells(3).Value & "', Publisher = '" & DGVMngBook.CurrentRow.Cells(4).Value & "', ISBN  = '" & DGVMngBook.CurrentRow.Cells(5).Value & "' , Quantity = '" & DGVMngBook.CurrentRow.Cells(6).Value & "'  where BookID = '" & DGVMngBook.CurrentRow.Cells(0).Value & "'")
            MsgBox("Updated", MsgBoxStyle.Information)
            fillDGV()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub


End Class