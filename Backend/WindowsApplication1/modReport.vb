
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.CrystalReports

Module modReport
    Public Sub RunReportPDF(ByVal data As List(Of clsReport), ByVal Template As String, ByVal ResultFile As String)
        Dim oRpt As ReportDocument
        oRpt = New ReportDocument()
        oRpt.Load(Application.StartupPath & Template)
        oRpt.SetDataSource(data)
        oRpt.ExportToDisk(ExportFormatType.PortableDocFormat, Application.StartupPath & ResultFile)
        Dim p = Process.Start(Application.StartupPath & ResultFile)
    End Sub

    Public Sub RunReportCR(ByVal data As List(Of clsReport), ByVal Template As String, ByVal ReportName As String)
        Dim oRpt As ReportDocument
        oRpt = New ReportDocument()
        oRpt.Load(Application.StartupPath & Template)
        oRpt.SetDataSource(data)
        frmReport.CrystalReportViewer1.ReportSource = oRpt
        frmReport.lblTitle.Text = ReportName
    End Sub

    Public Sub RunReportExcel(ByVal data As List(Of clsReport), ByVal Template As String, ByVal ResultFile As String)
        On Error Resume Next
        Dim oRpt As ReportDocument
        oRpt = New ReportDocument()
        oRpt.Load(Application.StartupPath & Template)
        oRpt.SetDataSource(data)
        oRpt.ExportToDisk(ExportFormatType.Excel, Application.StartupPath & ResultFile)
        Dim p = Process.Start(Application.StartupPath & ResultFile)
    End Sub

    Public Sub RunReportPrinter(ByVal data As List(Of clsReport), ByVal Template As String, ByVal Printer As String)
        On Error Resume Next
        Dim oRpt As ReportDocument
        oRpt = New ReportDocument()
        oRpt.Load(Application.StartupPath & Template)
        oRpt.SetDataSource(data)
        oRpt.PrintOptions.PrinterName = Printer
        oRpt.PrintToPrinter(1, False, 0, 0)
        'oRpt.ExportToDisk(ExportFormatType., Application.StartupPath & ResultFile)
        'Dim p = Process.Start(Application.StartupPath & ResultFile)
    End Sub
End Module
