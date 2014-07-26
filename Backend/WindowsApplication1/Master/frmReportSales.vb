Imports System.Net
Imports Newtonsoft.Json
Public Class frmReportSales

    Public ReportID As String
    Private Sub cmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdView.Click
        Reports()
    End Sub

    Sub Reports()
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim wc As New WebClient()
        If ReportID = 401 Then
            Dim json = wc.DownloadString(url & "all.php?q=" & ReportID & "&q2=" & Format(t1.Value, "yyyy-M-d") & "|" & Format(t2.Value, "yyyy-M-d"))
            Dim users As List(Of clsReport) = JsonConvert.DeserializeObject(Of List(Of clsReport))(json)
            Try
                RunReportCR(users, "/template/sd.rpt", "Sales Detail Preview")
                frmReport.ShowDialog()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

        If ReportID = 402 Then
            Dim json = wc.DownloadString(url & "all.php?q=" & ReportID & "&q2=" & Format(t1.Value, "yyyy-M-d") & "|" & Format(t2.Value, "yyyy-M-d"))
            Dim users As List(Of clsReport) = JsonConvert.DeserializeObject(Of List(Of clsReport))(json)
            Try
                RunReportCR(users, "/template/sh.rpt", "Sales Daily Preview")
                frmReport.ShowDialog()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

        If ReportID = 403 Then
            Dim json = wc.DownloadString(url & "all.php?q=" & ReportID & "&q2=" & Format(t1.Value, "yyyy-M-d") & "|" & Format(t2.Value, "yyyy-M-d"))
            Dim users As List(Of clsReport) = JsonConvert.DeserializeObject(Of List(Of clsReport))(json)
            Try
                RunReportCR(users, "/template/sms.rpt", "Sales Monthly Preview")
                frmReport.ShowDialog()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

        If ReportID = 404 Then
            Dim json = wc.DownloadString(url & "all.php?q=" & ReportID & "&q2=" & Format(t1.Value, "yyyy-M-d") & "|" & Format(t2.Value, "yyyy-M-d"))
            Dim users As List(Of clsReport) = JsonConvert.DeserializeObject(Of List(Of clsReport))(json)
            Try
                RunReportCR(users, "/template/sms.rpt", "Sales Monthly Preview")
                frmReport.ShowDialog()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

        If ReportID = 405 Then
            Dim json = wc.DownloadString(url & "all.php?q=" & ReportID & "&q2=" & Format(t1.Value, "yyyy-M-d") & "|" & Format(t2.Value, "yyyy-M-d"))
            Dim users As List(Of clsReport) = JsonConvert.DeserializeObject(Of List(Of clsReport))(json)
            Try
                RunReportCR(users, "/template/sms.rpt", "Sales Monthly Preview")
                frmReport.ShowDialog()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

        If ReportID = 406 Then
            Dim json = wc.DownloadString(url & "all.php?q=" & ReportID & "&q2=" & Format(t1.Value, "yyyy-M-d") & "|" & Format(t2.Value, "yyyy-M-d"))
            Dim users As List(Of clsReport) = JsonConvert.DeserializeObject(Of List(Of clsReport))(json)
            Try
                RunReportCR(users, "/template/cr.rpt", "Cashier Report Preview")
                frmReport.ShowDialog()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        If ReportID = 407 Then
            Dim json = wc.DownloadString(url & "all.php?q=" & ReportID & "&q2=" & Format(t1.Value, "yyyy-M-d") & "|" & Format(t2.Value, "yyyy-M-d"))
            Dim users As List(Of clsReport) = JsonConvert.DeserializeObject(Of List(Of clsReport))(json)
            Try
                RunReportCR(users, "/template/top.rpt", "Sales Top 50 Preview")
                frmReport.ShowDialog()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        If ReportID = 408 Then
            Dim json = wc.DownloadString(url & "all.php?q=" & ReportID & "&q2=" & Format(t1.Value, "yyyy-M-d") & "|" & Format(t2.Value, "yyyy-M-d"))
            Dim users As List(Of clsReport) = JsonConvert.DeserializeObject(Of List(Of clsReport))(json)
            Try
                RunReportCR(users, "/template/top.rpt", "Sales Top 50 Preview")
                frmReport.ShowDialog()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        If ReportID = 409 Then
            Dim json = wc.DownloadString(url & "all.php?q=" & ReportID & "&q2=" & Format(t1.Value, "yyyy-M-d") & "|" & Format(t2.Value, "yyyy-M-d"))
            Dim users As List(Of clsReport) = JsonConvert.DeserializeObject(Of List(Of clsReport))(json)
            Try
                RunReportCR(users, "/template/stk.rpt", "Item Stock Preview")
                frmReport.ShowDialog()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

End Class