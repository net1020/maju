Imports System.Net
Imports Newtonsoft.Json
Public Class frmReportSales

    Public ReportID As String
    Private Sub cmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdView.Click
        Dim dNet As New adnetObj.clsAdnet

        dNet.viewReportNew("template\" & ReportID & ".repx", dNet.loadJsonReport(ReportID, dNet.FormatDateString(t1.Value) & "|" & dNet.FormatDateString(t2.Value)))

    End Sub

  

End Class