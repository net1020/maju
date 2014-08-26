Imports System.Net
Imports Newtonsoft.Json
Imports System.Drawing
Imports System.Drawing.Printing
Public Class frmMain

    Private Sub buttonExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonExit.Click
        End
    End Sub

    Function selectTab(ByVal str As String) As Boolean
        For Each child As Form In Me.MdiChildren
            If child.Text = str Then
                child.Select()
                selectTab = True
            End If
        Next child
    End Function

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

    Private Sub ButtonItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEmployee.Click
        If selectTab("Employee") = False Then
            Dim adnet As adnetObj.frmList = New adnetObj.frmList()
            adnet.UrlClient = url
            adnet.newForm = False
            adnet.grid("Employee")
            adnet.Text = "Employee"
            adnet.MdiParent = Me
            adnet.WindowState = FormWindowState.Maximized
            adnet.Show()
            adnet.Update()
        End If
    End Sub

    Private Sub ribbonTabItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ribbonTabItem1.Click

    End Sub

    Private Sub ButtonItem64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPosition.Click
        If selectTab("Position") = False Then
            Dim adnet As adnetObj.frmList = New adnetObj.frmList()
            adnet.UrlClient = url
            adnet.newForm = False
            adnet.grid("Jabatan")
            adnet.Text = "Position"
            adnet.MdiParent = Me
            adnet.WindowState = FormWindowState.Maximized
            adnet.Show()
            adnet.Update()
        End If
    End Sub

    Private Sub ButtonItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMembership.Click
        If selectTab("Membership") = False Then
            Dim adnet As adnetObj.frmList = New adnetObj.frmList()
            adnet.UrlClient = url
            adnet.newForm = False
            adnet.grid("Membership")
            adnet.Text = "Membership"
            adnet.MdiParent = Me
            adnet.WindowState = FormWindowState.Maximized
            adnet.Show()
            adnet.Update()
        End If
    End Sub

    Private Sub ButtonItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCustomer.Click
        If selectTab("Customer") = False Then
            Dim adnet As adnetObj.frmList = New adnetObj.frmList()
            adnet.UrlClient = url
            adnet.newForm = False
            adnet.grid("Customer")
            adnet.Text = "Customer"
            adnet.MdiParent = Me
            adnet.WindowState = FormWindowState.Maximized
            adnet.Show()
            adnet.Update()
        End If
    End Sub

    Private Sub ButtonItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ButtonItem2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub ButtonItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBank.Click
        If selectTab("Bank") = False Then
            Dim adnet As adnetObj.frmList = New adnetObj.frmList()
            adnet.UrlClient = url
            adnet.newForm = False
            adnet.grid("Bank")
            adnet.Text = "Bank"
            adnet.MdiParent = Me
            adnet.WindowState = FormWindowState.Maximized
            adnet.Show()
            adnet.Update()
        End If
    End Sub

    Private Sub ButtonItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCategory.Click
        If selectTab("Category") = False Then
            Dim adnet As adnetObj.frmList = New adnetObj.frmList()
            adnet.UrlClient = url

            adnet.newForm = False
            adnet.grid("Category")
            adnet.Text = "Category"
            adnet.MdiParent = Me
            adnet.WindowState = FormWindowState.Maximized
            adnet.Show()
            adnet.Update()
        End If
    End Sub

    Private Sub ButtonItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCourier.Click
        If selectTab("Courier") = False Then
            Dim adnet As adnetObj.frmList = New adnetObj.frmList()
            adnet.UrlClient = url
            adnet.newForm = False
            adnet.grid("Courier")
            adnet.Text = "Courier"
            adnet.MdiParent = Me
            adnet.WindowState = FormWindowState.Maximized
            adnet.Show()
            adnet.Update()
        End If
    End Sub

    Private Sub ButtonItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGroup.Click
        If selectTab("Group") = False Then
            Dim adnet As adnetObj.frmList = New adnetObj.frmList()
            adnet.UrlClient = url
            adnet.newForm = False
            adnet.grid("Group")
            adnet.Text = "Group"
            adnet.MdiParent = Me
            adnet.WindowState = FormWindowState.Maximized
            adnet.Show()
            adnet.Update()
        End If
    End Sub

    Private Sub ButtonItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUnit.Click
        If selectTab("Unit") = False Then
            Dim adnet As adnetObj.frmList = New adnetObj.frmList()
            adnet.UrlClient = url
            adnet.newForm = False
            adnet.grid("Unit")
            adnet.Text = "Unit"
            adnet.MdiParent = Me
            adnet.WindowState = FormWindowState.Maximized
            adnet.Show()
            adnet.Update()
        End If
    End Sub

    Private Sub ButtonItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSupplier.Click
        If selectTab("Supplier") = False Then
            Dim adnet As adnetObj.frmList = New adnetObj.frmList()
            adnet.UrlClient = url
            adnet.newForm = False
            adnet.grid("Supplier")
            adnet.Text = "Supplier"
            adnet.MdiParent = Me
            adnet.WindowState = FormWindowState.Maximized
            adnet.Show()
            adnet.Update()
        End If
    End Sub

    Private Sub ButtonItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdProduct.Click
        If selectTab("Product") = False Then
            Dim adnet As adnetObj.frmList = New adnetObj.frmList()
            adnet.UrlClient = url
            'adnet.frmNew = New frmItems
            adnet.newForm = False
            adnet.grid("Product")
            adnet.Text = "Product"
            adnet.MdiParent = Me
            adnet.WindowState = FormWindowState.Maximized
            adnet.Show()
            adnet.Update()
        End If
    End Sub

    Private Sub ButtonItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPricing.Click
        If selectTab("Pricing") = False Then
            Dim adnet As adnetObj.frmList = New adnetObj.frmList()
            adnet.UrlClient = url
            adnet.newForm = False
            adnet.grid("Pricing")
            adnet.Text = "Pricing"
            adnet.MdiParent = Me
            adnet.WindowState = FormWindowState.Maximized
            adnet.Show()
            adnet.Update()
        End If
    End Sub

    Private Sub ButtonItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCatDis.Click
        If selectTab("Catpricing") = False Then
            Dim adnet As adnetObj.frmList = New adnetObj.frmList()
            adnet.UrlClient = url
            adnet.newForm = False
            adnet.grid("Catpricing")
            adnet.Text = "Catpricing"
            adnet.MdiParent = Me
            adnet.WindowState = FormWindowState.Maximized
            adnet.Show()
            adnet.Update()
        End If
    End Sub

    Private Sub ButtonItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUser.Click
        If selectTab("User") = False Then
            Dim adnet As adnetObj.frmList = New adnetObj.frmList()
            adnet.UrlClient = url
            adnet.newForm = False
            adnet.grid("User")
            adnet.Text = "User"
            adnet.MdiParent = Me
            adnet.WindowState = FormWindowState.Maximized
            adnet.Show()
            adnet.Update()
        End If
    End Sub

    Private Sub ButtonItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmReportSales.ReportID = 401
        frmReportSales.ShowDialog()
    End Sub

    Private Sub ButtonItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ButtonItem2_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmReportSales.ReportID = 402
        frmReportSales.ShowDialog()

    End Sub

    Private Sub ButtonItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ButtonItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmReportSales.ReportID = 403
        frmReportSales.ShowDialog()
    End Sub

    Private Sub ButtonItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmReportSales.ReportID = 404
        frmReportSales.ShowDialog()
    End Sub

    Private Sub ButtonItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmReportSales.ReportID = 405
        frmReportSales.ShowDialog()
    End Sub

    Private Sub ButtonItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmReportSales.ReportID = 406
        frmReportSales.ShowDialog()
    End Sub

    Private Sub ButtonItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ButtonItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmReportSales.ReportID = 408
        frmReportSales.ShowDialog()
    End Sub

    Private Sub ButtonItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmReportSales.ReportID = 407
        frmReportSales.ShowDialog()
    End Sub

    Private Sub ButtonItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmReportSales.ReportID = 409
        frmReportSales.ShowDialog()
    End Sub

    Private Sub ButtonItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmReportSales1.ReportID = 410
        frmReportSales1.ShowDialog()
    End Sub

    Private Sub ButtonItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim doc1 As adnetObj.frmList = New adnetObj.frmList()
        doc1.UrlClient = url
        doc1.frmNew = New frmSales
        doc1.newForm = True
        doc1.grid("SQ")
        doc1.Text = "Sales Quotation"
        doc1.MdiParent = Me
        doc1.WindowState = FormWindowState.Maximized
        doc1.Show()
        doc1.Update()
    End Sub

    Private Sub ButtonItem33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalesOrder.Click
        'Dim doc1 As adnetObj.frmList = New adnetObj.frmList()
        'doc1.UrlClient = url
        'doc1.frmNew = New frmSales
        'doc1.newForm = True
        'doc1.grid("SO")
        'doc1.Text = "Sales Order"
        'doc1.MdiParent = Me
        'doc1.WindowState = FormWindowState.Maximized
        'doc1.Show()
        'doc1.Update()
        If selectTab("Sales Order") = False Then
            Dim doc1 As adnetObj.frmList = New adnetObj.frmList()
            doc1.UrlClient = url
            doc1.frmNew = New frmSalesOrder
            doc1.newForm = True
            doc1.grid("SO")
            doc1.Text = "Sales Order"
            doc1.MdiParent = Me
            doc1.WindowState = FormWindowState.Maximized
            doc1.Show()
            doc1.Update()
        End If
    End Sub

  

    Private Sub ButtonItem39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem39.Click
        Dim dNet As New adnetObj.clsAdnet
        dNet.viewReport("template\sample.repx", dNet.loadJson("21", "SQ14060002"))
    End Sub

    Private Sub ButtonItem3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem3.Click
        If selectTab("Sales Invoice") = False Then
            Dim doc1 As adnetObj.frmList = New adnetObj.frmList()
            doc1.UrlClient = url
            doc1.frmNew = New frmSalesInvoice
            doc1.newForm = True
            doc1.grid("SI")
            doc1.Text = "Sales Invoice"
            doc1.MdiParent = Me
            doc1.WindowState = FormWindowState.Maximized
            doc1.Show()
            doc1.Update()
        End If
    End Sub

    Private Sub ButtonItem2_Click_4(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem2.Click
        If selectTab("Salesman") = False Then
            Dim adnet As adnetObj.frmList = New adnetObj.frmList()
            adnet.UrlClient = url
            adnet.newForm = False
            adnet.grid("Salesman")
            adnet.Text = "Salesman"
            adnet.MdiParent = Me
            adnet.WindowState = FormWindowState.Maximized
            adnet.Show()
            adnet.Update()
        End If
    End Sub

    Private Sub ButtonItem16_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem16.Click
        If selectTab("warehouse") = False Then
            Dim adnet As adnetObj.frmList = New adnetObj.frmList()
            adnet.UrlClient = url
            adnet.newForm = False
            adnet.grid("warehouse")
            adnet.Text = "Warehouse"
            adnet.MdiParent = Me
            adnet.WindowState = FormWindowState.Maximized
            adnet.Show()
            adnet.Update()
        End If
    End Sub

    Private Sub ButtonItem19_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem19.Click
        If selectTab("payment") = False Then
            Dim adnet As adnetObj.frmList = New adnetObj.frmList()
            adnet.UrlClient = url
            adnet.newForm = False
            adnet.grid("payment")
            adnet.Text = "Payment"
            adnet.MdiParent = Me
            adnet.WindowState = FormWindowState.Maximized
            adnet.Show()
            adnet.Update()
        End If
    End Sub

    Private Sub ButtonItem4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem4.Click
        If selectTab("Sales Payment") = False Then
            Dim doc1 As adnetObj.frmList = New adnetObj.frmList()
            doc1.UrlClient = url
            doc1.frmNew = New frmSalesReceipt
            doc1.newForm = True
            doc1.grid("SP")
            doc1.Text = "Sales Payment"
            doc1.MdiParent = Me
            doc1.WindowState = FormWindowState.Maximized
            doc1.Show()
            doc1.Update()
        End If
    End Sub

    Private Sub ButtonItem18_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem18.Click
        If selectTab("Sales Return") = False Then
            Dim doc1 As adnetObj.frmList = New adnetObj.frmList()
            doc1.UrlClient = url
            doc1.frmNew = New frmSalesReturn
            doc1.newForm = True
            doc1.grid("SR")
            doc1.Text = "Sales Return"
            doc1.MdiParent = Me
            doc1.WindowState = FormWindowState.Maximized
            doc1.Show()
            doc1.Update()
        End If
    End Sub

    Private Sub ButtonItem17_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem17.Click
        If selectTab("Purchase Order") = False Then
            Dim doc1 As adnetObj.frmList = New adnetObj.frmList()
            doc1.UrlClient = url
            doc1.frmNew = New frmPurchaseOrder
            doc1.newForm = True
            doc1.grid("PO")
            doc1.Text = "Purchase Order"
            doc1.MdiParent = Me
            doc1.WindowState = FormWindowState.Maximized
            doc1.Show()
            doc1.Update()
        End If
    End Sub

    Private Sub ButtonItem11_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem11.Click
        If selectTab("Purchase Invoice") = False Then
            Dim doc1 As adnetObj.frmList = New adnetObj.frmList()
            doc1.UrlClient = url
            doc1.frmNew = New frmPurchaseInvoice
            doc1.newForm = True
            doc1.grid("PI")
            doc1.Text = "Purchase Invoice"
            doc1.MdiParent = Me
            doc1.WindowState = FormWindowState.Maximized
            doc1.Show()
            doc1.Update()
        End If
    End Sub

    Private Sub ButtonItem12_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem12.Click
        If selectTab("Purchase Payment") = False Then
            Dim doc1 As adnetObj.frmList = New adnetObj.frmList()
            doc1.UrlClient = url
            doc1.frmNew = New frmPurchasePayment
            doc1.newForm = True
            doc1.grid("PP")
            doc1.Text = "Purchase Payment"
            doc1.MdiParent = Me
            doc1.WindowState = FormWindowState.Maximized
            doc1.Show()
            doc1.Update()
        End If
    End Sub

    Private Sub ButtonItem15_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem15.Click
        If selectTab("Purchase Return") = False Then
            Dim doc1 As adnetObj.frmList = New adnetObj.frmList()
            doc1.UrlClient = url
            doc1.frmNew = New frmPurchaseReturn
            doc1.newForm = True
            doc1.grid("PR")
            doc1.Text = "Purchase Return"
            doc1.MdiParent = Me
            doc1.WindowState = FormWindowState.Maximized
            doc1.Show()
            doc1.Update()
        End If
    End Sub

    Private Sub ButtonItem1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem1.Click
        If selectTab("Purchase Cheque Status") = False Then
            Dim doc1 As adnetObj.frmList = New adnetObj.frmList()
            doc1.UrlClient = url
            'doc1.frmNew = New frmPurchaseReturn
            doc1.newForm = False
            doc1.grid("PCQ")
            doc1.Text = "Purchase Cheque Status"
            doc1.MdiParent = Me
            doc1.WindowState = FormWindowState.Maximized
            doc1.Show()
            doc1.Update()
        End If
    End Sub

    Private Sub ButtonItem20_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem20.Click
        If selectTab("History Purchase Price") = False Then
            Dim doc1 As adnetObj.frmList = New adnetObj.frmList()
            doc1.UrlClient = url
            'doc1.frmNew = New frmPurchaseReturn
            doc1.newForm = False
            doc1.grid("PH")
            doc1.Text = "History Purchase Price"
            doc1.MdiParent = Me
            doc1.WindowState = FormWindowState.Maximized
            doc1.Show()
            doc1.Update()
        End If
    End Sub

    Private Sub ButtonItem21_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem21.Click
        If selectTab("Sales Cheque Status") = False Then
            Dim doc1 As adnetObj.frmList = New adnetObj.frmList()
            doc1.UrlClient = url
            'doc1.frmNew = New frmPurchaseReturn
            doc1.newForm = False
            doc1.grid("SCQ")
            doc1.Text = "Sales Cheque Status"
            doc1.MdiParent = Me
            doc1.WindowState = FormWindowState.Maximized
            doc1.Show()
            doc1.Update()
        End If
    End Sub

    Private Sub ButtonItem22_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem22.Click
        If selectTab("History Sales Price") = False Then
            Dim doc1 As adnetObj.frmList = New adnetObj.frmList()
            doc1.UrlClient = url
            'doc1.frmNew = New frmPurchaseReturn
            doc1.newForm = False
            doc1.grid("SH")
            doc1.Text = "History Sales Price"
            doc1.MdiParent = Me
            doc1.WindowState = FormWindowState.Maximized
            doc1.Show()
            doc1.Update()
        End If
    End Sub

    Private Sub ButtonItem23_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem23.Click
        If selectTab("Sales Check Point") = False Then
            Dim doc1 As adnetObj.frmList = New adnetObj.frmList()
            doc1.UrlClient = url
            'doc1.frmNew = New frmPurchaseReturn
            doc1.newForm = False
            doc1.grid("SCP")
            doc1.Text = "Sales Check Point"
            doc1.MdiParent = Me
            doc1.WindowState = FormWindowState.Maximized
            doc1.Show()
            doc1.Update()
        End If
    End Sub

    Private Sub ButtonItem24_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem24.Click
        If selectTab("Sales Point Detail") = False Then
            Dim doc1 As adnetObj.frmList = New adnetObj.frmList()
            doc1.UrlClient = url
            'doc1.frmNew = New frmPurchaseReturn
            doc1.newForm = False
            doc1.grid("SPD")
            doc1.Text = "Sales Point Detail"
            doc1.MdiParent = Me
            doc1.WindowState = FormWindowState.Maximized
            doc1.Show()
            doc1.Update()
        End If
    End Sub

    Private Sub ButtonItem25_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem25.Click
        If selectTab("Sales Reimburse Point") = False Then
            Dim doc1 As adnetObj.frmList = New adnetObj.frmList()
            doc1.UrlClient = url
            'doc1.frmNew = New frmPurchaseReturn
            doc1.newForm = False
            doc1.grid("SRP")
            doc1.Text = "Sales Reimburse Point"
            doc1.MdiParent = Me
            doc1.WindowState = FormWindowState.Maximized
            doc1.Show()
            doc1.Update()
        End If
    End Sub

    Private Sub ButtonItem7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem7.Click
        If selectTab("Consignment Order") = False Then
            Dim doc1 As adnetObj.frmList = New adnetObj.frmList()
            doc1.UrlClient = url
            doc1.frmNew = New frmConsigneOrder
            doc1.newForm = True
            doc1.grid("CO")
            doc1.Text = "Consignment Order"
            doc1.MdiParent = Me
            doc1.WindowState = FormWindowState.Maximized
            doc1.Show()
            doc1.Update()
        End If
    End Sub

    Private Sub ButtonItem9_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem9.Click
        If selectTab("Consignment Invoice") = False Then
            Dim doc1 As adnetObj.frmList = New adnetObj.frmList()
            doc1.UrlClient = url
            doc1.frmNew = New frmConsigneInvoice
            doc1.newForm = True
            doc1.grid("CI")
            doc1.Text = "Consignment Invoice"
            doc1.MdiParent = Me
            doc1.WindowState = FormWindowState.Maximized
            doc1.Show()
            doc1.Update()
        End If
    End Sub

    Private Sub ButtonItem26_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem26.Click
        If selectTab("Consignment Payment") = False Then
            Dim doc1 As adnetObj.frmList = New adnetObj.frmList()
            doc1.UrlClient = url
            doc1.frmNew = New frmConsignePayment
            doc1.newForm = True
            doc1.grid("CP")
            doc1.Text = "Consignment Payment"
            doc1.MdiParent = Me
            doc1.WindowState = FormWindowState.Maximized
            doc1.Show()
            doc1.Update()
        End If
    End Sub

    Private Sub ButtonItem27_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem27.Click
        If selectTab("Consignment Return") = False Then
            Dim doc1 As adnetObj.frmList = New adnetObj.frmList()
            doc1.UrlClient = url
            doc1.frmNew = New frmConsigneReturn
            doc1.newForm = True
            doc1.grid("CR")
            doc1.Text = "Consignment Return"
            doc1.MdiParent = Me
            doc1.WindowState = FormWindowState.Maximized
            doc1.Show()
            doc1.Update()
        End If
    End Sub

    Private Sub ButtonItem28_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem28.Click
        If selectTab("Consignment Cheque Status") = False Then
            Dim doc1 As adnetObj.frmList = New adnetObj.frmList()
            doc1.UrlClient = url
            'doc1.frmNew = New frmPurchaseReturn
            doc1.newForm = False
            doc1.grid("CCQ")
            doc1.Text = "Consignment Cheque Status"
            doc1.MdiParent = Me
            doc1.WindowState = FormWindowState.Maximized
            doc1.Show()
            doc1.Update()
        End If
    End Sub

    Private Sub ButtonItem46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem46.Click
        If selectTab("History Consignment Price") = False Then
            Dim doc1 As adnetObj.frmList = New adnetObj.frmList()
            doc1.UrlClient = url
            'doc1.frmNew = New frmPurchaseReturn
            doc1.newForm = False
            doc1.grid("CH")
            doc1.Text = "History Consignment Price"
            doc1.MdiParent = Me
            doc1.WindowState = FormWindowState.Maximized
            doc1.Show()
            doc1.Update()
        End If
    End Sub

    Private Sub ButtonItem55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem55.Click
        If selectTab("Delivery Order") = False Then
            Dim doc1 As adnetObj.frmList = New adnetObj.frmList()
            doc1.UrlClient = url
            doc1.frmNew = New frmDeliveryOrder
            doc1.newForm = True
            doc1.grid("DO")
            doc1.Text = "Delivery Order"
            doc1.MdiParent = Me
            doc1.WindowState = FormWindowState.Maximized
            doc1.Show()
            doc1.Update()
        End If
    End Sub

    Private Sub ButtonItem56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem56.Click
        If selectTab("Delivery Out") = False Then
            Dim doc1 As adnetObj.frmList = New adnetObj.frmList()
            doc1.UrlClient = url
            doc1.frmNew = New frmDeliveryOut
            doc1.newForm = True
            doc1.grid("DT")
            doc1.Text = "Delivery Out"
            doc1.MdiParent = Me
            doc1.WindowState = FormWindowState.Maximized
            doc1.Show()
            doc1.Update()
        End If
    End Sub

    Private Sub ButtonItem57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem57.Click
        If selectTab("Delivery Received") = False Then
            Dim doc1 As adnetObj.frmList = New adnetObj.frmList()
            doc1.UrlClient = url
            doc1.frmNew = New frmDeliveryReceived
            doc1.newForm = True
            doc1.grid("DR")
            doc1.Text = "Delivery Received"
            doc1.MdiParent = Me
            doc1.WindowState = FormWindowState.Maximized
            doc1.Show()
            doc1.Update()
        End If
    End Sub

    Private Sub ButtonItem63_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem63.Click
        If selectTab("Pending Delivery Order") = False Then
            Dim doc1 As adnetObj.frmList = New adnetObj.frmList()
            doc1.UrlClient = url
            'doc1.frmNew = New frmDeliveryReceived
            doc1.newForm = False
            doc1.grid("DPO")
            doc1.Text = "Pending Delivery Order"
            doc1.MdiParent = Me
            doc1.WindowState = FormWindowState.Maximized
            doc1.Show()
            doc1.Update()
        End If
    End Sub

    Private Sub ButtonItem64_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem64.Click
        If selectTab("Pending Delivery Out") = False Then
            Dim doc1 As adnetObj.frmList = New adnetObj.frmList()
            doc1.UrlClient = url
            'doc1.frmNew = New frmDeliveryReceived
            doc1.newForm = False
            doc1.grid("DPR")
            doc1.Text = "Pending Delivery Out"
            doc1.MdiParent = Me
            doc1.WindowState = FormWindowState.Maximized
            doc1.Show()
            doc1.Update()
        End If
    End Sub

    Private Sub ButtonItem35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem35.Click
        If selectTab("Beginning Stock") = False Then
            Dim doc1 As adnetObj.frmList = New adnetObj.frmList()
            doc1.UrlClient = url
            'doc1.frmNew = New frmDeliveryReceived
            doc1.newForm = False
            doc1.grid("SB")
            doc1.Text = "Beginning Stock"
            doc1.MdiParent = Me
            doc1.WindowState = FormWindowState.Maximized
            doc1.Show()
            doc1.Update()
        End If
    End Sub

    Private Sub ButtonItem38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem38.Click
        Dim dNet As New adnetObj.clsAdnet
        dNet.viewReportNew("template\S001.repx", dNet.loadJsonReport("101", "1407/SO/IV/0004"))
    End Sub

    Private Sub ButtonItem60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem60.Click
        If selectTab("Cash In") = False Then
            Dim doc1 As adnetObj.frmList = New adnetObj.frmList()
            doc1.UrlClient = url
            doc1.frmNew = New frmCashIn
            doc1.newForm = True
            doc1.grid("CIN")
            doc1.Text = "Cash In"
            doc1.MdiParent = Me
            doc1.WindowState = FormWindowState.Maximized
            doc1.Show()
            doc1.Update()
        End If
    End Sub

    Private Sub ButtonItem61_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem61.Click
        If selectTab("Cash Out") = False Then
            Dim doc1 As adnetObj.frmList = New adnetObj.frmList()
            doc1.UrlClient = url
            doc1.frmNew = New frmCashOut
            doc1.newForm = True
            doc1.grid("COT")
            doc1.Text = "Cash Out"
            doc1.MdiParent = Me
            doc1.WindowState = FormWindowState.Maximized
            doc1.Show()
            doc1.Update()
        End If
    End Sub

    Private Sub ButtonItem34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem34.Click
        If selectTab("Stock Opname") = False Then
            Dim doc1 As adnetObj.frmList = New adnetObj.frmList()
            doc1.UrlClient = url
            doc1.newForm = False
            doc1.grid("SOPNAME")
            doc1.Text = "Stock Opname"
            doc1.updateListColumn = 10
            doc1.updateListTable = "SOPNAMEupdate"
            doc1.MdiParent = Me
            doc1.WindowState = FormWindowState.Maximized
            doc1.Show()
            doc1.Update()
        End If
    End Sub

    Private Sub ButtonItem43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem43.Click

        frmReportSales.ReportID = "RS01"
        frmReportSales.ShowDialog()
    End Sub

    Private Sub ButtonItem44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem44.Click
        frmReportSales.ReportID = "RS02"
        frmReportSales.ShowDialog()
    End Sub

    Private Sub ButtonItem48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem48.Click
        frmReportSales.ReportID = "RS03"
        frmReportSales.ShowDialog()
    End Sub

    Private Sub ButtonItem49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem49.Click
        frmReportSales.ReportID = "RS04"
        frmReportSales.ShowDialog()
    End Sub

    Private Sub ButtonItem50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem50.Click
        frmReportSales.ReportID = "RS05"
        frmReportSales.ShowDialog()
    End Sub

    Private Sub ButtonItem51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem51.Click
        frmReportSales.ReportID = "RS06"
        frmReportSales.ShowDialog()
    End Sub

    Private Sub ButtonItem53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem53.Click
        frmReportSales.ReportID = "RS07"
        frmReportSales.ShowDialog()
    End Sub

    Private Sub ButtonItem54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem54.Click
        frmReportSales.ReportID = "RS08"
        frmReportSales.ShowDialog()
    End Sub

 
End Class