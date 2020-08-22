Imports System.ComponentModel

Public Class frmMain
    Private Sub UserManageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserManageToolStripMenuItem.Click
        frmUserManage.ShowDialog()
    End Sub

    Private Sub StudentRegistrationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentRegistrationToolStripMenuItem.Click
        frmStudentReg.ShowDialog()
    End Sub

    Private Sub BookRegistrationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookRegistrationToolStripMenuItem.Click
        frmBookReg.ShowDialog()
    End Sub

    Private Sub BookBarrowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookBarrowToolStripMenuItem.Click
        FrmBookBarrow.ShowDialog()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblLogedInUser.Text = logeinUser
        dr.Close()
        Timer1.Start()
        lblDate.Text = Now.Date

    End Sub

    Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim close = MsgBox("Are you Sure to Close the program", MsgBoxStyle.YesNo Or MsgBoxStyle.Information, "Shutdown Library Management System")
        If close = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub LogoutToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        frmLogin.Show()

    End Sub

    Private Sub UserRegistrationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserRegistrationToolStripMenuItem.Click
        frmUserReg.ShowDialog()
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        frmChangePass.ShowDialog()
    End Sub

    Private Sub LogOutToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem1.Click
        Me.Hide()
        frmLogin.Show()
        lblLogedInUser.Text = logeinUser
    End Sub
    Private Sub CalculatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculatorToolStripMenuItem.Click
        Shell("c:\WINDOWS\system32\calc.exe")
    End Sub

    Private Sub NotepadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotepadToolStripMenuItem.Click
        Shell("C:\Windows\system32\notepad.exe")
    End Sub

    Private Sub GoogleChromeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoogleChromeToolStripMenuItem.Click
        Shell("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' DateTimePicker1.Value = DateTime.Now
        Label4.Text = TimeOfDay
    End Sub

    Private Sub WordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WordToolStripMenuItem.Click

        Shell("C:\Program Files (x86)\Microsoft Office\root\Office16\WINWORD.exe")

    End Sub

    Private Sub ExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExcelToolStripMenuItem.Click
        Shell("C:\Program Files (x86)\Microsoft Office\root\Office16\EXCEL.exe")
    End Sub

    Private Sub BookManageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookManageToolStripMenuItem.Click
        frmManageBooks.ShowDialog()
    End Sub

    Private Sub ManageStudentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageStudentsToolStripMenuItem.Click
        StudentManagement.ShowDialog()
    End Sub

    Private Sub SoftwareToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SoftwareToolStripMenuItem.Click
        aboutSoftware.ShowDialog()
    End Sub

    Private Sub DevelopersToolStripMenuItem_Click(sender As Object, e As EventArgs)
        '  aboutDevelopers.ShowDialog()
    End Sub

    Private Sub BookReturnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookReturnToolStripMenuItem.Click
        frmBookReturn.ShowDialog()
    End Sub

    Private Sub AllStudentsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ' frmAllStudRep.MdiParent = Me
        'frmAllStudRep.Show()
    End Sub

    Private Sub ReturnedToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmReturnedBooks.MdiParent = Me
        frmReturnedBooks.Show()

    End Sub

    Private Sub BorrowedToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
End Class