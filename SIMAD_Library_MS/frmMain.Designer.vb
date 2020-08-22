<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserManageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserRegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookRegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookBarrowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookReturnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookManageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentRegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageStudentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotepadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoogleChromeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PowepointToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SoftwareToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblLogedInUser = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Olive
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.BookToolStripMenuItem, Me.StudentToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1130, 31)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserManageToolStripMenuItem, Me.UserRegistrationToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 27)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'UserManageToolStripMenuItem
        '
        Me.UserManageToolStripMenuItem.Name = "UserManageToolStripMenuItem"
        Me.UserManageToolStripMenuItem.Size = New System.Drawing.Size(165, 24)
        Me.UserManageToolStripMenuItem.Text = "User Manage"
        '
        'UserRegistrationToolStripMenuItem
        '
        Me.UserRegistrationToolStripMenuItem.Name = "UserRegistrationToolStripMenuItem"
        Me.UserRegistrationToolStripMenuItem.Size = New System.Drawing.Size(165, 24)
        Me.UserRegistrationToolStripMenuItem.Text = "Create User"
        '
        'BookToolStripMenuItem
        '
        Me.BookToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BookRegistrationToolStripMenuItem, Me.BookBarrowToolStripMenuItem, Me.BookReturnToolStripMenuItem, Me.BookManageToolStripMenuItem})
        Me.BookToolStripMenuItem.Name = "BookToolStripMenuItem"
        Me.BookToolStripMenuItem.Size = New System.Drawing.Size(55, 27)
        Me.BookToolStripMenuItem.Text = "Book"
        '
        'BookRegistrationToolStripMenuItem
        '
        Me.BookRegistrationToolStripMenuItem.Name = "BookRegistrationToolStripMenuItem"
        Me.BookRegistrationToolStripMenuItem.Size = New System.Drawing.Size(196, 24)
        Me.BookRegistrationToolStripMenuItem.Text = "Book Registration"
        '
        'BookBarrowToolStripMenuItem
        '
        Me.BookBarrowToolStripMenuItem.Name = "BookBarrowToolStripMenuItem"
        Me.BookBarrowToolStripMenuItem.Size = New System.Drawing.Size(196, 24)
        Me.BookBarrowToolStripMenuItem.Text = "Book Barrow"
        '
        'BookReturnToolStripMenuItem
        '
        Me.BookReturnToolStripMenuItem.Name = "BookReturnToolStripMenuItem"
        Me.BookReturnToolStripMenuItem.Size = New System.Drawing.Size(196, 24)
        Me.BookReturnToolStripMenuItem.Text = "Book Return"
        '
        'BookManageToolStripMenuItem
        '
        Me.BookManageToolStripMenuItem.Name = "BookManageToolStripMenuItem"
        Me.BookManageToolStripMenuItem.Size = New System.Drawing.Size(196, 24)
        Me.BookManageToolStripMenuItem.Text = "Book Manage"
        '
        'StudentToolStripMenuItem
        '
        Me.StudentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentRegistrationToolStripMenuItem, Me.ManageStudentsToolStripMenuItem})
        Me.StudentToolStripMenuItem.Name = "StudentToolStripMenuItem"
        Me.StudentToolStripMenuItem.Size = New System.Drawing.Size(72, 27)
        Me.StudentToolStripMenuItem.Text = "Student"
        '
        'StudentRegistrationToolStripMenuItem
        '
        Me.StudentRegistrationToolStripMenuItem.Name = "StudentRegistrationToolStripMenuItem"
        Me.StudentRegistrationToolStripMenuItem.Size = New System.Drawing.Size(213, 24)
        Me.StudentRegistrationToolStripMenuItem.Text = "Student Registration"
        '
        'ManageStudentsToolStripMenuItem
        '
        Me.ManageStudentsToolStripMenuItem.Name = "ManageStudentsToolStripMenuItem"
        Me.ManageStudentsToolStripMenuItem.Size = New System.Drawing.Size(213, 24)
        Me.ManageStudentsToolStripMenuItem.Text = "Manage Student's"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.LogoutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NotepadToolStripMenuItem, Me.CalculatorToolStripMenuItem, Me.GoogleChromeToolStripMenuItem, Me.WordToolStripMenuItem, Me.PowepointToolStripMenuItem, Me.ExcelToolStripMenuItem})
        Me.LogoutToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(193, 27)
        Me.LogoutToolStripMenuItem.Text = "Windows Functions"
        '
        'NotepadToolStripMenuItem
        '
        Me.NotepadToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.NotepadToolStripMenuItem.Name = "NotepadToolStripMenuItem"
        Me.NotepadToolStripMenuItem.Size = New System.Drawing.Size(229, 28)
        Me.NotepadToolStripMenuItem.Text = "Notepad"
        '
        'CalculatorToolStripMenuItem
        '
        Me.CalculatorToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark
        Me.CalculatorToolStripMenuItem.Name = "CalculatorToolStripMenuItem"
        Me.CalculatorToolStripMenuItem.Size = New System.Drawing.Size(229, 28)
        Me.CalculatorToolStripMenuItem.Text = "Calculator"
        '
        'GoogleChromeToolStripMenuItem
        '
        Me.GoogleChromeToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GoogleChromeToolStripMenuItem.Name = "GoogleChromeToolStripMenuItem"
        Me.GoogleChromeToolStripMenuItem.Size = New System.Drawing.Size(229, 28)
        Me.GoogleChromeToolStripMenuItem.Text = "Google Chrome"
        '
        'WordToolStripMenuItem
        '
        Me.WordToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.WordToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.WordToolStripMenuItem.Name = "WordToolStripMenuItem"
        Me.WordToolStripMenuItem.Size = New System.Drawing.Size(229, 28)
        Me.WordToolStripMenuItem.Text = "Word"
        '
        'PowepointToolStripMenuItem
        '
        Me.PowepointToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.PowepointToolStripMenuItem.Name = "PowepointToolStripMenuItem"
        Me.PowepointToolStripMenuItem.Size = New System.Drawing.Size(229, 28)
        Me.PowepointToolStripMenuItem.Text = "Powepoint"
        '
        'ExcelToolStripMenuItem
        '
        Me.ExcelToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control
        Me.ExcelToolStripMenuItem.Name = "ExcelToolStripMenuItem"
        Me.ExcelToolStripMenuItem.Size = New System.Drawing.Size(229, 28)
        Me.ExcelToolStripMenuItem.Text = "Excel"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SoftwareToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(62, 27)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'SoftwareToolStripMenuItem
        '
        Me.SoftwareToolStripMenuItem.Name = "SoftwareToolStripMenuItem"
        Me.SoftwareToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.SoftwareToolStripMenuItem.Text = "System"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.lblDate)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblLogedInUser)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.MenuStrip2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1130, 36)
        Me.Panel1.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(719, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 23)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Time:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(783, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 23)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Active User:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblDate.Location = New System.Drawing.Point(470, 7)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(55, 23)
        Me.lblDate.TabIndex = 4
        Me.lblDate.Text = "         "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(400, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Date: "
        '
        'lblLogedInUser
        '
        Me.lblLogedInUser.AutoSize = True
        Me.lblLogedInUser.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogedInUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblLogedInUser.Location = New System.Drawing.Point(128, 7)
        Me.lblLogedInUser.Name = "lblLogedInUser"
        Me.lblLogedInUser.Size = New System.Drawing.Size(0, 23)
        Me.lblLogedInUser.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(4, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Active User:"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.Color.White
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.Right
        Me.MenuStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserToolStripMenuItem})
        Me.MenuStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table
        Me.MenuStrip2.Location = New System.Drawing.Point(1069, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.ShowItemToolTips = True
        Me.MenuStrip2.Size = New System.Drawing.Size(61, 36)
        Me.MenuStrip2.TabIndex = 2
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.UserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangePasswordToolStripMenuItem, Me.LogOutToolStripMenuItem1})
        Me.UserToolStripMenuItem.Image = Global.SIMAD_Library_MS.My.Resources.Resources.download
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.UserToolStripMenuItem.Text = "User"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'LogOutToolStripMenuItem1
        '
        Me.LogOutToolStripMenuItem1.Name = "LogOutToolStripMenuItem1"
        Me.LogOutToolStripMenuItem1.Size = New System.Drawing.Size(168, 22)
        Me.LogOutToolStripMenuItem1.Text = "Log out"
        '
        'Timer1
        '
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1130, 402)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "SIMAD Libarary"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserManageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserRegistrationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BookToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BookRegistrationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BookBarrowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BookReturnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentRegistrationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblLogedInUser As Label
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NotepadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculatorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GoogleChromeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PowepointToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExcelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblDate As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents UserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents SoftwareToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BookManageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageStudentsToolStripMenuItem As ToolStripMenuItem
End Class
