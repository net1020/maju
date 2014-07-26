Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Net
Imports Newtonsoft.Json
Public Class frmPrintIMIP
    Dim editForm As Boolean

   

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Dim appXL As Excel.Application
        Dim wbXl As Excel.Workbook
        Dim shXL As Excel.Worksheet
        appXL = CreateObject("Excel.Application")
        appXL.Visible = True
        wbXl = appXL.Workbooks.Open(Application.StartupPath & ("/template/instruksimixing.xls"))
        shXL = wbXl.ActiveSheet
        Dim query As String
        query = SyncDB("http://localhost/apnws/iIM.php", gridRaw1.Item(0, gridRaw1.CurrentRow.Index).Value())
        appXL.Sheets(1).Cells(1, 1) = query
        appXL.Run("ExecuteData")
        appXL.Sheets(1).Cells(1, 1) = ""
        appXL.Sheets(1).visible = False
        appXL.ActiveWorkbook.SaveAs(Filename:="c:\APN-Report\InstruksiMixing-" & gridRaw1.Item(0, gridRaw1.CurrentRow.Index).Value() & "-" & Convert.ToInt32(Now.ToString("hhmmss")) & ".xls")
        appXL = Nothing
    End Sub
End Class