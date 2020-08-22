Imports System.Data.SqlClient
Public Class frmBookReg
    Private Sub frmBookReg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerateID()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim Warning = MsgBox("Are you sure to Save ", MsgBoxStyle.YesNo)
        If Warning = DialogResult.Yes Then
            Do_Operations("Insert into tblBookReg values ('" & txtBookID.Text & "', '" & txtBookTitle.Text & "', '" & txtAuthor.Text & "','" & cmbCategory.Text & "', '" & txtPublisher.Text & "', '" & txtISBN.Text & "', '" & txtQuantity.Text & "')")
            MsgBox("Succes Fully added Book Of '" & txtBookTitle.Text & "'. to the store", MsgBoxStyle.Information)
            textBoxClear()
            GenerateID()
        End If
    End Sub

    Sub textBoxClear()
        txtAuthor.Text = ""
        txtBookID.Text = ""
        txtBookTitle.Text = ""
        txtISBN.Text = ""
        txtPublisher.Text = ""
        txtQuantity.Text = ""
        cmbCategory.Text = ""
        txtBookID.Focus()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        If txtBookTitle.Text = "" Then
            MsgBox("Please Enter Book Title", MsgBoxStyle.Exclamation)
            Exit Sub
        ElseIf txtPublisher.Text = "" Then
            MsgBox("PLease Enter Book Publisher", MsgBoxStyle.Exclamation)
            Exit Sub
        ElseIf txtQuantity.Text = "" Then
            MsgBox("PLease Enter Book Qty", MsgBoxStyle.Exclamation)
            Exit Sub
        ElseIf cmbCategory.SelectedIndex = -1 Then
            MsgBox("PLease CHoose Book Category", MsgBoxStyle.Exclamation)
            Exit Sub
        ElseIf txtAuthor.Text = "" Then
            MsgBox("PLease Enter Book Author", MsgBoxStyle.Exclamation)
            Exit Sub
        ElseIf txtISBN.Text = "" Then
            MsgBox("PLease Enter Book ISBN", MsgBoxStyle.Exclamation)
            Exit Sub
        End If


        Dim msg = MsgBox("Are you sure to save", MsgBoxStyle.Information Or MsgBoxStyle.YesNo, "Saving New Book")
        If msg = DialogResult.Yes Then
            Do_Operations("Insert into tblBookReg Values ('" & txtBookID.Text & "', '" & txtBookTitle.Text & "', '" & txtAuthor.Text & "', '" & cmbCategory.Text & "', '" & txtPublisher.Text & "', '" & txtISBN.Text & "', '" & txtQuantity.Text & "' )")
            MsgBox("Succesfully added Book Of '" & txtBookTitle.Text & " to the store", MsgBoxStyle.Information)
            clear()


        End If
            GenerateID()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim close = MsgBox("Are you Sure to Close", MsgBoxStyle.YesNo Or MsgBoxStyle.Information, "Closing Book Regsitration")
        If close = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Sub clear()
        txtAuthor.Text = ""
        txtBookID.Text = ""
        txtBookTitle.Text = ""
        txtISBN.Text = ""
        txtPublisher.Text = ""
        txtQuantity.Text = ""
        cmbCategory.SelectedIndex = -1
        txtBookTitle.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        frmManageBooks.Show()
    End Sub

    Sub GenerateID()
        openConne()
        query = "Select count(BooKID) from tblBookReg"
        cmd = New SqlCommand(query, con)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            Dim x As String
            Dim y As String
            x = "Bk20180610"
            y = dr.Item(0) + 1
            txtBookID.Text = x + y
        End If
    End Sub

End Class