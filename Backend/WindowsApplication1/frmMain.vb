Imports System.Net
Imports Newtonsoft.Json
Imports System.Drawing
Imports System.Drawing.Printing
Public Class frmMain

    Private Sub buttonExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonExit.Click
        End
    End Sub

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        tabStrip1.MdiForm = Me
        ribbon1.Enabled = False
        Dim doc1 As frmLogin = New frmLogin()
        doc1.Text = "Login"
        doc1.MdiParent = Me
        doc1.WindowState = FormWindowState.Maximized
        doc1.Show()
        doc1.Update()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim time As DateTime = DateTime.Now
        Dim format As String = "dd MMMM yyyy HH:mm:ss"
        labelStatus.Text = time.ToString(format)
    End Sub

    Public Sub Load_Items()

    End Sub

    Private Sub tabStrip1_SelectedTabChanged(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.TabStripTabChangedEventArgs) Handles tabStrip1.SelectedTabChanged

    End Sub

    Private Sub ButtonItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Load_Items()
    End Sub

    Private Sub ButtonItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ButtonItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem1.Click
        Dim doc1 As frmEmployeeList = New frmEmployeeList()
        doc1.Text = "Employee"
        doc1.MdiParent = Me
        doc1.WindowState = FormWindowState.Maximized
        doc1.Show()
        doc1.Update()
    End Sub

    Private Sub ribbonTabItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ribbonTabItem1.Click

    End Sub

    Private Sub ButtonItem64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem64.Click
        Dim doc1 As frmJabatanList = New frmJabatanList()
        doc1.Text = "Position"
        doc1.MdiParent = Me
        doc1.WindowState = FormWindowState.Maximized
        doc1.Show()
        doc1.Update()
    End Sub

    Private Sub ButtonItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem9.Click
        Dim doc1 As frmMembershipList = New frmMembershipList()
        doc1.Text = "Membership"
        doc1.MdiParent = Me
        doc1.WindowState = FormWindowState.Maximized
        doc1.Show()
        doc1.Update()
    End Sub

    Private Sub ButtonItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem3.Click
        Dim doc1 As frmCustomerList = New frmCustomerList()
        doc1.Text = "Customer"
        doc1.MdiParent = Me
        doc1.WindowState = FormWindowState.Maximized
        doc1.Show()
        doc1.Update()
    End Sub

    Private Sub ButtonItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ButtonItem2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub ButtonItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem7.Click
        Dim doc1 As frmBankList = New frmBankList()
        doc1.Text = "Bank"
        doc1.MdiParent = Me
        doc1.WindowState = FormWindowState.Maximized
        doc1.Show()
        doc1.Update()
    End Sub

    Private Sub ButtonItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem11.Click
        Dim doc1 As frmCategoryList = New frmCategoryList()
        doc1.Text = "Category"
        doc1.MdiParent = Me
        doc1.WindowState = FormWindowState.Maximized
        doc1.Show()
        doc1.Update()
    End Sub

    Private Sub ButtonItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem12.Click
        Dim doc1 As frmCourierList = New frmCourierList()
        doc1.Text = "Courier"
        doc1.MdiParent = Me
        doc1.WindowState = FormWindowState.Maximized
        doc1.Show()
        doc1.Update()
    End Sub

    Private Sub ButtonItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem15.Click
        Dim doc1 As frmGroupList = New frmGroupList()
        doc1.Text = "Group"
        doc1.MdiParent = Me
        doc1.WindowState = FormWindowState.Maximized
        doc1.Show()
        doc1.Update()
    End Sub

    Private Sub ButtonItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem16.Click
        Dim doc1 As frmUnitList = New frmUnitList()
        doc1.Text = "Unit"
        doc1.MdiParent = Me
        doc1.WindowState = FormWindowState.Maximized
        doc1.Show()
        doc1.Update()
    End Sub

    Private Sub ButtonItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem4.Click
        Dim doc1 As frmSupplierList = New frmSupplierList()
        doc1.Text = "Supplier"
        doc1.MdiParent = Me
        doc1.WindowState = FormWindowState.Maximized
        doc1.Show()
        doc1.Update()
    End Sub

    Private Sub ButtonItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem10.Click
        Dim doc1 As frmItemList = New frmItemList()
        doc1.Text = "Item"
        doc1.MdiParent = Me
        doc1.WindowState = FormWindowState.Maximized
        doc1.Show()
        doc1.Update()
    End Sub

    Private Sub ButtonItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem17.Click
        Dim doc1 As frmPricingList = New frmPricingList()
        doc1.Text = "Pricing"
        doc1.MdiParent = Me
        doc1.WindowState = FormWindowState.Maximized
        doc1.Show()
        doc1.Update()
    End Sub

    Private Sub ButtonItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem18.Click
        Dim doc1 As frmCatpricingList = New frmCatpricingList()
        doc1.Text = "Category Discount"
        doc1.MdiParent = Me
        doc1.WindowState = FormWindowState.Maximized
        doc1.Show()
        doc1.Update()
    End Sub

    Private Sub ButtonItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem13.Click
        Dim doc1 As frmUserList = New frmUserList()
        doc1.Text = "User"
        doc1.MdiParent = Me
        doc1.WindowState = FormWindowState.Maximized
        doc1.Show()
        doc1.Update()
    End Sub

    Private Sub ButtonItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem20.Click
        frmReportSales.ReportID = 401
        frmReportSales.ShowDialog()
    End Sub

    Private Sub ButtonItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem19.Click

    End Sub

    Private Sub ButtonItem2_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem2.Click
        frmReportSales.ReportID = 402
        frmReportSales.ShowDialog()

    End Sub

    Private Sub ButtonItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem21.Click

    End Sub

    Private Sub ButtonItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem22.Click
        frmReportSales.ReportID = 403
        frmReportSales.ShowDialog()
    End Sub

    Private Sub ButtonItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem23.Click
        frmReportSales.ReportID = 404
        frmReportSales.ShowDialog()
    End Sub

    Private Sub ButtonItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem24.Click
        frmReportSales.ReportID = 405
        frmReportSales.ShowDialog()
    End Sub

    Private Sub ButtonItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem25.Click
        frmReportSales.ReportID = 406
        frmReportSales.ShowDialog()
    End Sub

    Private Sub ButtonItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem26.Click

    End Sub

    Private Sub ButtonItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem27.Click
        frmReportSales.ReportID = 408
        frmReportSales.ShowDialog()
    End Sub

    Private Sub ButtonItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem28.Click
        frmReportSales.ReportID = 407
        frmReportSales.ShowDialog()
    End Sub

    Private Sub ButtonItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem30.Click
        frmReportSales.ReportID = 409
        frmReportSales.ShowDialog()
    End Sub

    Private Sub ButtonItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem31.Click
        frmReportSales1.ReportID = 410
        frmReportSales1.ShowDialog()
    End Sub
End Class