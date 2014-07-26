Imports System.Net
Imports Newtonsoft.Json
Public Class frmReportSales1

    Public ReportID As String
    Private Sub cmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdView.Click
        Reports()
    End Sub

    Sub Reports()
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim wc As New WebClient()
       
        If ReportID = 410 Then
            Dim json = wc.DownloadString(url & "all.php?q=" & ReportID & "&q2=" & Format(t1.Value, "yyyy-M-d") & "|" & Format(t2.Value, "yyyy-M-d") & "|" & t3.text)
            Dim users As List(Of clsReport) = JsonConvert.DeserializeObject(Of List(Of clsReport))(json)
            Try
                RunReportCR(users, "/template/scard.rpt", "Stock Card Preview")
                frmReport.ShowDialog()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

End Class