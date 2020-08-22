Imports System.Data.SqlClient
Public Class frmBookReturn
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim cls = MsgBox("Are you sure to  close the program", MsgBoxStyle.Information Or MsgBoxStyle.YesNo)
        If cls = DialogResult.Yes Then
            Me.Close()

        End If
    End Sub

    Private Sub frmBookReturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        selectSt()
    End Sub
    Sub selectSt()
        openConne()
        query = "select * from tblBookBarrow where Returned = 'No'"
        cmd = New SqlCommand(query, con)
        dr = cmd.ExecuteReader
        While dr.Read = True
            cmbBookT.Items.Add(dr.Item(0))
        End While
        dr.Close()

    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBookT.SelectedIndexChanged
        openConne()
        query = "select * from tblBookBarrow where [Book Title] = '" & cmbBookT.Text & "' and Returned  = 'No' "
        cmd = New SqlCommand(query, con)
        dr = cmd.ExecuteReader
        While dr.Read = True
            cmbStudeName.Items.Clear()
            cmbStudeName.Items.Add(dr.Item(1))

            Exit Sub
        End While
        If dr.Read = False Then
            cmbStudeName.Items.Clear()
            cmbStudeName.Text = ""
        End If
        dr.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        openConne()
        Do_Operations("Update tblBookReg Set Quantity +=1 where [Book Title] = '" & cmbBookT.Text & "' ")
        Do_Operations("Update tblBookBarrow Set [Date Borrowed] = '" & DateTimePicker1.Text & "' , Returned = 'Yes' where [Student Name] = '" & cmbStudeName.Text & "' and [Book Title] = '" & cmbBookT.Text & "' ")
        MsgBox("Succesfully Returned Book", MsgBoxStyle.Information)
        cmbBookT.Text = ""
        cmbStudeName.Text = ""
        DateTimePicker1.ResetText()
        cmbBookT.Items.Clear()
        cmbStudeName.Items.Clear()
        selectSt()
    End Sub
End Class