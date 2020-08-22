Imports System.Data.SqlClient
Module Mconne
    Public con As New SqlConnection
    Public cmd As New SqlCommand
    Public query As String
    Public dr As SqlDataReader
    Public da As New SqlDataAdapter
    Public ds As New DataSet
    Public logeinUser As  String



    Public Sub openConne()
        con.Close()
        con.ConnectionString = ("Server=DESKTOP-P4AG53I; Database=SIMALibray; Integrated Security = true")
        con.Open()
    End Sub

    Public Sub Do_Operations(query As String)
        openConne()
        cmd = New SqlCommand(query, con)
        cmd.ExecuteNonQuery()
    End Sub

    Public Sub Reports(ByVal query As String, ByVal reportname As String, ByVal Crystal As Object)
        Try
            openConne()
            Dim reprtname As String = reportname
            With cmd
                .CommandText = query
            End With
            ds = New DataSet
            da = New SqlDataAdapter(query, con)
            da.Fill(ds)

            Dim ReportPath As String = "C:\users\...." & reportname & ".rpt"
            Dim ReportDoc As New CrystalDecisions.CrystalReports.Engine.ReportDocument

            With Crystal
                .ShowRefreshButton = False
                .ShowCancelButton = False
                .ShowTreeViewButton = False
                .Datasoource = ReportDoc
                .Refresh()
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            da.Dispose()
            con.Close()
        End Try
    End Sub


End Module
