Imports System.Data.SqlClient
Public Class frmReturnedBooks

    Private Sub frmReturnedBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' openConne()
        Dim stmt1 As String
        stmt1 = "select * from tblBookBarrow where Returned = 'Yes' "
        reports(stmt1, "ReturnedBooks1", CrystalReportViewer1)
        CrystalReportViewer1.Refresh()
    End Sub
End Class