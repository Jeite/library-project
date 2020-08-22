Imports System.Data.SqlClient
Public Class frmUserManage
    Private Sub frmUserManage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillDGV()
        DgvManageUser.ColumnHeadersHeight = 30
        DgvManageUser.CellBorderStyle = DataGridViewCellBorderStyle.Raised


    End Sub
    Sub fillDGV()

        openConne()
        query = "Select * from tbl_login order by [Full Name] ASC"
        da = New SqlDataAdapter(query, con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "DGV1")
        DgvManageUser.DataSource = ds.Tables("DGV1")

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Dim close = MsgBox("Are you sure to close", MsgBoxStyle.YesNo, "Closing The Form")
        If close = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub DgvManageUser_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvManageUser.CellContentClick

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim clsoing = MsgBox("Are you sure to close the form", MsgBoxStyle.Information Or MsgBoxStyle.YesNo, "Closing user Mangement")
        If clsoing = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        search()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim warn = MsgBox("Are you sure to Delete", MsgBoxStyle.Information Or MsgBoxStyle.YesNo, "Deleting")
        If warn = DialogResult.Yes Then
            openConne()
            query = "delete from tbl_Login where [Full Name] = '" & DgvManageUser.CurrentRow.Cells(0).Value & "' "
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("Succesfully Deleted")
            fillDGV()
        End If
    End Sub

    Private Sub txtSearch_OnValueChanged(sender As Object, e As EventArgs) Handles txtSearch.OnValueChanged
        search()
    End Sub

    Sub search()
        openConne()
        query = "Select * from tbl_Login  where concat ([Full Name], Username) Like '%" & txtSearch.Text & "%' "
        da = New SqlDataAdapter(query, con)
        ds.Clear()
        da.Fill(ds, "DV")
        DgvManageUser.DataSource = ds.Tables("DV")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If DgvManageUser.RowCount > 0 Then
            Dim warning = MsgBox("Are you sure to Update ", MsgBoxStyle.Information Or MsgBoxStyle.YesNo, "Updating")
            If warning = DialogResult.Yes Then
                query = "Update tbl_Login SET [Full Name] = '" & DgvManageUser.CurrentRow.Cells(0).Value & "', Email = '" & DgvManageUser.CurrentRow.Cells(1).Value & "', Username = '" & DgvManageUser.CurrentRow.Cells(2).Value & "', Password = '" & DgvManageUser.CurrentRow.Cells(3).Value & "', [Security Question] = '" & DgvManageUser.CurrentRow.Cells(4).Value & "' , [Security Answer] = '" & DgvManageUser.CurrentRow.Cells(5).Value & "' ,[Secret Code] = '" & DgvManageUser.CurrentRow.Cells(6).Value & "' where [Full Name] = '" & DgvManageUser.CurrentRow.Cells(0).Value & "' "
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                fillDGV()
            End If

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class