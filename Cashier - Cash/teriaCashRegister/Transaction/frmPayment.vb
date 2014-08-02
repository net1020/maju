Imports System.Drawing.Printing
Imports System.Net
Imports Newtonsoft.Json

Public Class frmPayment

    Private Sub frmPayment_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        t5.Focus()
    End Sub

    Private Sub frmPayment_ContextMenuChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ContextMenuChanged

    End Sub

    Private Sub frmPayment_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Hide()
        End If
    End Sub

    Private Sub frmPayment_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        c1.Items.Add("DB001")
        c1.Items.Add("DB002")
        c1.Items.Add("DB003")
        c2.Items.Add("CC001")
        c2.Items.Add("CC002")
        c2.Items.Add("CC003")
        c3.Items.Add("VC001")
        c3.Items.Add("VC002")
        c3.Items.Add("VC003")
        c4.Items.Add("TF001")
        c4.Items.Add("TF002")
        c4.Items.Add("TF003")
        c1.SelectedIndex = 0
        c2.SelectedIndex = 0
        c3.SelectedIndex = 0
        c4.SelectedIndex = 0
        'Me.TopMost = True
    End Sub

    Private Sub t2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub t2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t2.ValueChanged
        t4a.Value = FormatNumber(t1.Value - t2.Value - t3.Value + t4.Value, 0)
        't5.Value = FormatNumber(t1.Value - t2.Value - t3.Value + t4.Value, 0)
        t10.Value = (t5.Value + t6.Value + t7.Value + t8.Value + t9.Value) - t4a.Value
    End Sub

    Private Sub t3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles t3.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
        If e.KeyCode = Keys.F1 Then
            cmdf4.RaiseClick()
        End If
    End Sub

    Private Sub t3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t3.ValueChanged
        t4a.Value = FormatNumber(t1.Value - t2.Value - t3.Value + t4.Value, 0)
        't5.Value = FormatNumber(t1.Value - t2.Value - t3.Value + t4.Value, 0)
        t10.Value = (t5.Value + t6.Value + t7.Value + t8.Value + t9.Value) - t4a.Value
    End Sub

    Private Sub t4_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles t4.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
        If e.KeyCode = Keys.F1 Then
            cmdf4.RaiseClick()
        End If
    End Sub

    Private Sub t4_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t4.ValueChanged
        t4a.Value = FormatNumber(t1.Value - t2.Value - t3.Value + t4.Value, 0)
        't5.Value = FormatNumber(t1.Value - t2.Value - t3.Value + t4.Value, 0)
        t10.Value = (t5.Value + t6.Value + t7.Value + t8.Value + t9.Value) - t4a.Value
    End Sub

    Private Sub t5_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles t5.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Hide()

        End If
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
        If e.KeyCode = Keys.F1 Then
            cmdf4.RaiseClick()
            
        End If
    End Sub

    Private Sub t5_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t5.ValueChanged
        t10.Value = (t5.Value + t6.Value + t7.Value + t8.Value + t9.Value) - t4a.Value
    End Sub

    Private Sub t6_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles t6.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Hide()
        End If
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
        If e.KeyCode = Keys.F1 Then
            cmdf4.RaiseClick()
        End If
    End Sub

    Private Sub t6_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t6.ValueChanged
        t10.Value = (t5.Value + t6.Value + t7.Value + t8.Value + t9.Value) - t4a.Value
    End Sub

    Private Sub t7_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles t7.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Hide()
        End If
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
        If e.KeyCode = Keys.F1 Then
            cmdf4.RaiseClick()
        End If
    End Sub

    Private Sub t7_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t7.ValueChanged
        t10.Value = (t5.Value + t6.Value + t7.Value + t8.Value + t9.Value) - t4a.Value
    End Sub

    Private Sub t8_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles t8.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Hide()
        End If
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
        If e.KeyCode = Keys.F1 Then
            cmdf4.RaiseClick()
        End If
    End Sub

    Private Sub t8_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t8.ValueChanged
        t10.Value = (t5.Value + t6.Value + t7.Value + t8.Value + t9.Value) - t4a.Value
    End Sub

    Private Sub t9_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles t9.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Hide()
        End If
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
        If e.KeyCode = Keys.F1 Then
            cmdf4.RaiseClick()
        End If
    End Sub

    Private Sub t9_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t9.ValueChanged
        t10.Value = (t5.Value + t6.Value + t7.Value + t8.Value + t9.Value) - t4a.Value
    End Sub

    Private Sub t2a_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t2a.ValueChanged
        t2.Value = (t2a.Value / 100) * t1.Value
    End Sub

    Private Sub cmdf4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdf4.Click
        Dim SalesNo As String
        t10.Value = (t5.Value + t6.Value + t7.Value + t8.Value + t9.Value) - t4a.Value
        Dim v As Long
        v = t10.Value
        If v < 0 Then
            lblStatus.Text = "Saldo pembayaran masih kurang"
        Else

            frmPaymentDone.lblChange.Text = FormatCurrency(t10.Value)
            frmSales.lblName.Text = "Bayar " & FormatNumber(t5.Value + t6.Value + t7.Value + t8.Value + t9.Value, 0)
            frmSales.lblQty.Text = "Kembali"
            frmSales.lblPrice.Text = FormatNumber(t10.Value, 0)
            SalesNo = frmSales.SalesNo
            Save_Payment(SalesNo & "|" & frmSales.salesId & "|" & frmSales.memberId & "|" & frmSales.Sub_Total & "|" & t4.Value & "|" & t3.Value & "|" & t2.Value & "|" & t4a.Value & "|" & frmSales.TotalDisc & "|" & frmSales.TotalQty & "|" & ItemDetail() & "|" & PaymentDetail(SalesNo) & "|" & userName)
            frmSales.Print_Screen2("Bayar " & FormatCurrency(t5.Value + t6.Value + t7.Value + t8.Value + t9.Value), "Kembali " & FormatCurrency(t10.Value))
            print_Sales()
            ' print_Sales2()
            On Error Resume Next
            '\\print comm port
            'Shell(Application.StartupPath & "\print.exe")
            '===================
            'load_printer()
            '\\ Print usb
            Dim ds As New DataSet
            Dim dt As New DataTable
            Dim wc As New WebClient()
            Dim json = wc.DownloadString(Url & "print/all.php?q=63&q2=")
            Dim users As List(Of clsReport) = JsonConvert.DeserializeObject(Of List(Of clsReport))(json)
            RunReportPrinter(users, "/template/sales.rpt", cmbPrinters.Text)
            '=====================
            Me.Visible = False
            frmPaymentDone.Show()

        End If
    End Sub
    Public Sub load_printer()
        cmbPrinters.Items.Clear()
        For Each Printer In PrinterSettings.InstalledPrinters
            cmbPrinters.Items.Add(Printer)
        Next
        Dim oPS As New System.Drawing.Printing.PrinterSettings
        cmbPrinters.Text = oPS.PrinterName
        ' cmbPrinters.SelectedIndex = 0
    End Sub
    Function ItemDetail() As String
        Dim j, n, n2 As Integer
        Dim str As String
        Dim SalesNo As String
        j = frmSales.grid1.RowCount
        str = ""
        SalesNo = frmSales.SalesNo
        For n = 0 To j - 2
            str = str & SalesNo & "[]"
            For n2 = 1 To 8
                If n2 = 1 Then str = str & "Item" 'Kits
                If n2 = 2 Then str = str & frmSales.grid1.Item(n2 - 1, n).Value()
                If n2 = 3 Then str = str & frmSales.grid1.Item(0, n).Value()
                If n2 > 3 Then str = str & frmSales.grid1.Item(n2 - 1, n).Value()

                str = str & "[]"
            Next
            str = Strings.Left(str, Len(str) - 2)
            str = str & "{}"
        Next
        str = Strings.Left(str, Len(str) - 2)
        ItemDetail = str
    End Function

    Function PaymentDetail(ByVal SalesNo As String) As String
        Dim str As String
        str = ""
        'Discount
        If t2.Value <> 0 Then
            str = str & SalesNo & "[]"
            str = str & "Discount" & "[]"
            str = str & "" & "[]"
            str = str & -(t2.Value) & "{}"
        End If
        'Pembulatan
        If t3.Value <> 0 Then
            str = str & SalesNo & "[]"
            str = str & "Pembulatan" & "[]"
            str = str & "" & "[]"
            str = str & t3.Value & "{}"
        End If
        'Creditcardfee
        If t4.Value <> 0 Then
            str = str & SalesNo & "[]"
            str = str & "Creditcardfee" & "[]"
            str = str & "" & "[]"
            str = str & -(t4.Value) & "{}"
        End If
        'Cash
        If t5.Value <> 0 Then
            str = str & SalesNo & "[]"
            str = str & "Cash" & "[]"
            str = str & "" & "[]"
            str = str & t5.Value & "{}"
        End If
        'Debit
        If t6.Value <> 0 Then
            str = str & SalesNo & "[]"
            str = str & "Debit" & "[]"
            str = str & c1.Text & "[]"
            str = str & t6.Value & "{}"
        End If
        'Credit Card
        If t7.Value <> 0 Then
            str = str & SalesNo & "[]"
            str = str & "CreditCard" & "[]"
            str = str & c2.Text & "[]"
            str = str & t7.Value & "{}"
        End If
        'Voucher
        If t8.Value <> 0 Then
            str = str & SalesNo & "[]"
            str = str & "Voucher" & "[]"
            str = str & c3.Text & "[]"
            str = str & t8.Value & "{}"
        End If
        'Transfer
        If t9.Value <> 0 Then
            str = str & SalesNo & "[]"
            str = str & "Transfer" & "[]"
            str = str & c4.Text & "[]"
            str = str & t9.Value & "{}"
        End If
        'Change
        If t10.Value <> 0 Then
            str = str & SalesNo & "[]"
            str = str & "Change" & "[]"
            str = str & "" & "[]"
            str = str & -(t10.Value) & "{}"
        End If
        On Error Resume Next

        str = Strings.Left(str, Len(str) - 2)
        PaymentDetail = str
    End Function

    Private Sub cmdf10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdf10.Click
        Me.Hide()
    End Sub

    Private Sub c1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c1.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
        If e.KeyCode = Keys.F1 Then
            cmdf4.RaiseClick()
        End If
    End Sub

    Private Sub c2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c2.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
        If e.KeyCode = Keys.F1 Then
            cmdf4.RaiseClick()
        End If
    End Sub

    Private Sub c3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c3.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
        If e.KeyCode = Keys.F1 Then
            cmdf4.RaiseClick()
        End If
    End Sub

    Private Sub c4_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c4.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
        If e.KeyCode = Keys.F1 Then
            cmdf4.RaiseClick()
        End If
    End Sub

    Sub Save_Payment(ByVal str As String)
        Dim wc As New WebClient()
        Dim json = wc.DownloadString(Url & "load.php?q=52&q2=" & str)
        'Dim data As List(Of clsCombo2) = JsonConvert.DeserializeObject(Of List(Of clsCombo2))(json)
        'If data.Item(0).code <> "1" Then
        'End If
    End Sub

    Sub print_Sales()
        Dim wc As New WebClient()
        Dim json = wc.DownloadString(Url & "print.php?q=1")
        'Dim data As List(Of clsCombo2) = JsonConvert.DeserializeObject(Of List(Of clsCombo2))(json)
        'If data.Item(0).code <> "1" Then
        'End If
    End Sub
    Sub print_Sales2()
        Dim wc As New WebClient()
        Dim json = wc.DownloadString(Url & "print/all.php?q=63")
        'Dim data As List(Of clsCombo2) = JsonConvert.DeserializeObject(Of List(Of clsCombo2))(json)
        'If data.Item(0).code <> "1" Then
        'End If
    End Sub


End Class