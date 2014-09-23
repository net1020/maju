Imports System.Net
Imports Newtonsoft.Json
Public Class frmReportSales1

    Public ReportID As String
    Public cmbID As String
    Public cmbT As Boolean

    Private Sub cmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdView.Click
        Dim dNet As New adnetObj.clsAdnet
        If cmbT = True Then
            cmbID = cmb.SelectedValue
        Else
            cmbID = cmb.Text
        End If
        dNet.viewReportNew("template\" & ReportID & ".repx", dNet.loadJsonReport(ReportID, cmbID & "|" & dNet.FormatDateString(t1.Value) & "|" & dNet.FormatDateString(t2.Value)))
        cmbT = False
    End Sub

    Public Sub loads(ByVal Qno As String)
        Dim adnet As adnetObj.clsAdnet = New adnetObj.clsAdnet()
        adnet.loadCombo(cmb, Qno, "")
    End Sub
  

    Private Sub cmb_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb.SelectedIndexChanged
       

    End Sub
End Class