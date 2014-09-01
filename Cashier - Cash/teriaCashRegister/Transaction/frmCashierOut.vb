Imports System.Drawing.Printing
Imports System.Net
Imports Newtonsoft.Json

Public Class frmCashierOut

    Private Sub frmNewCashier_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        t1.Focus()
    End Sub

    Private Sub t3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles t3.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
        If e.KeyCode = Keys.F1 Then
            cmdf4.RaiseClick()
        End If
        If e.KeyCode = Keys.F2 Then
            cmdf2.RaiseClick()
        End If
        If e.KeyCode = Keys.Escape Then
            cmdf10.RaiseClick()
        End If
    End Sub

    Private Sub t4_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles t4.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
        If e.KeyCode = Keys.F1 Then
            cmdf4.RaiseClick()
        End If
        If e.KeyCode = Keys.F2 Then
            cmdf2.RaiseClick()
        End If
        If e.KeyCode = Keys.Escape Then
            cmdf10.RaiseClick()
        End If
    End Sub

    Private Sub t5_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles t5.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
        If e.KeyCode = Keys.F1 Then
            cmdf4.RaiseClick()
        End If
        If e.KeyCode = Keys.F2 Then
            cmdf2.RaiseClick()
        End If
        If e.KeyCode = Keys.Escape Then
            cmdf10.RaiseClick()
        End If
    End Sub

    Private Sub t6_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles t6.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
        If e.KeyCode = Keys.F1 Then
            cmdf4.RaiseClick()
        End If
        If e.KeyCode = Keys.F2 Then
            cmdf2.RaiseClick()
        End If
        If e.KeyCode = Keys.Escape Then
            cmdf10.RaiseClick()
        End If
    End Sub

    Private Sub t7_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles t7.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
        If e.KeyCode = Keys.F1 Then
            cmdf4.RaiseClick()
        End If
        If e.KeyCode = Keys.F2 Then
            cmdf2.RaiseClick()
        End If
        If e.KeyCode = Keys.Escape Then
            cmdf10.RaiseClick()
        End If
    End Sub

    Private Sub t8_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles t8.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
        If e.KeyCode = Keys.F1 Then
            cmdf4.RaiseClick()
        End If
        If e.KeyCode = Keys.F2 Then
            cmdf2.RaiseClick()
        End If
        If e.KeyCode = Keys.Escape Then
            cmdf10.RaiseClick()
        End If
    End Sub

    Private Sub t9_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles t9.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
        If e.KeyCode = Keys.F1 Then
            cmdf4.RaiseClick()
        End If
        If e.KeyCode = Keys.F2 Then
            cmdf2.RaiseClick()
        End If
        If e.KeyCode = Keys.Escape Then
            cmdf10.RaiseClick()
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

    Private Sub cmdf4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdf4.Click
        Dim sCounter As String
        sCounter = Counter()
        If t1.Value = 0 And t2.Value = 0 And t3.Value = 0 And t4.Value = 0 And t5.Value = 0 And t6.Value = 0 And t7.Value = 0 And t8.Value = 0 And t9.Value = 0 And t10.Value = 0 And t11.Value = 0 Then
            MsgBox("Please input a value to each field, minimum 1 field")
            Exit Sub
        End If
        Save_Deposit(sCounter & "|" & "Out" & "|" & TotalAmount() & "|" & userName & "|" & "CheckOut" & "|" & ItemDetail(sCounter))
        print_Sales()
        On Error Resume Next
        Shell(Application.StartupPath & "\print2.exe")
        Dim wc As New WebClient()
        load_printer()
        Dim json = wc.DownloadString(Url & "print/all.php?q=64&q2=" & userName)
        Dim users As List(Of clsReport) = JsonConvert.DeserializeObject(Of List(Of clsReport))(json)
        RunReportPrinter(users, "/template/deposit.rpt", cmbPrinters.Text)

        Dim json3 = wc.DownloadString(Url & "print/all.php?q=66&q2=" & userName)
        Dim users3 As List(Of clsReport) = JsonConvert.DeserializeObject(Of List(Of clsReport))(json3)
        RunReportPrinter(users3, "/template/deposit3.rpt", cmbPrinters.Text)

        Dim json4 = wc.DownloadString(Url & "print/all.php?q=67&q2=" & userName)
        Dim users4 As List(Of clsReport) = JsonConvert.DeserializeObject(Of List(Of clsReport))(json4)
        RunReportPrinter(users4, "/template/deposit4.rpt", cmbPrinters.Text)

        Dim json2 = wc.DownloadString(Url & "print/all.php?q=65&q2=" & userName)
        Dim users2 As List(Of clsReport) = JsonConvert.DeserializeObject(Of List(Of clsReport))(json2)
        RunReportPrinter(users2, "/template/deposit2.rpt", cmbPrinters.Text)

        

        Me.Hide()
        frmSales.Hide()
        frmLogin.Visible = True
        frmScreen.txtDisc.Text = 0
        frmScreen.txtChange.Text = 0
        frmScreen.txtTotal.Text = 0
        frmScreen.txtPay.Text = 0
        frmScreen.grid1.Rows.Clear()
    End Sub

    Sub print_Sales()
        Dim wc As New WebClient()
        Dim json = wc.DownloadString(Url & "print.php?q=2&q2=" & userName)
    End Sub

    Function TotalAmount() As Long
        TotalAmount = (t1.Value * 100000) + (t2.Value * 50000) + (t3.Value * 20000) + (t4.Value * 10000) + (t5.Value * 5000) + (t6.Value * 2000) + (t7.Value * 1000) + (t8.Value * 500) + (t9.Value * 200) + (t10.Value * 100) + (t11.Value * 50)
    End Function


    Function ItemDetail(ByVal sCounter As String) As String
        Dim n As Integer
        Dim str As String
        str = ""
        n = n + 1
        If t1.Value > 0 Then
            str = str & sCounter & "[]"
            str = str & n & "[]"
            str = str & t1.Value & "[]"
            str = str & "100000" & "[]"
            str = str & t1.Value * 100000 & "{}"
            n = n + 1
        End If
        If t2.Value > 0 Then
            str = str & sCounter & "[]"
            str = str & n & "[]"
            str = str & t2.Value & "[]"
            str = str & "50000" & "[]"
            str = str & t2.Value * 50000 & "{}"
            n = n + 1
        End If
        If t3.Value > 0 Then
            str = str & sCounter & "[]"
            str = str & n & "[]"
            str = str & t3.Value & "[]"
            str = str & "20000" & "[]"
            str = str & t3.Value * 20000 & "{}"
            n = n + 1
        End If
        If t4.Value > 0 Then
            str = str & sCounter & "[]"
            str = str & n & "[]"
            str = str & t4.Value & "[]"
            str = str & "10000" & "[]"
            str = str & t4.Value * 10000 & "{}"
            n = n + 1
        End If
        If t5.Value > 0 Then
            str = str & sCounter & "[]"
            str = str & n & "[]"
            str = str & t5.Value & "[]"
            str = str & "5000" & "[]"
            str = str & t5.Value * 5000 & "{}"
            n = n + 1
        End If
        If t6.Value > 0 Then
            str = str & sCounter & "[]"
            str = str & n & "[]"
            str = str & t6.Value & "[]"
            str = str & "2000" & "[]"
            str = str & t6.Value * 2000 & "{}"
            n = n + 1
        End If
        If t7.Value > 0 Then
            str = str & sCounter & "[]"
            str = str & n & "[]"
            str = str & t7.Value & "[]"
            str = str & "1000" & "[]"
            str = str & t7.Value * 1000 & "{}"
            n = n + 1
        End If
        If t8.Value > 0 Then
            str = str & sCounter & "[]"
            str = str & n & "[]"
            str = str & t8.Value & "[]"
            str = str & "500" & "[]"
            str = str & t8.Value * 500 & "{}"
            n = n + 1
        End If
        If t9.Value > 0 Then
            str = str & sCounter & "[]"
            str = str & n & "[]"
            str = str & t9.Value & "[]"
            str = str & "200" & "[]"
            str = str & t9.Value * 200 & "{}"
            n = n + 1
        End If
        If t10.Value > 0 Then
            str = str & sCounter & "[]"
            str = str & n & "[]"
            str = str & t10.Value & "[]"
            str = str & "100" & "[]"
            str = str & t10.Value * 100 & "{}"
            n = n + 1
        End If
        If t11.Value > 0 Then
            str = str & sCounter & "[]"
            str = str & n & "[]"
            str = str & t11.Value & "[]"
            str = str & "50" & "[]"
            str = str & t11.Value * 50 & "{}"
            n = n + 1
        End If
        str = Strings.Left(str, Len(str) - 2)
        ItemDetail = str
    End Function

    Sub Save_Deposit(ByVal str As String)
        Dim wc As New WebClient()
        Dim json = wc.DownloadString(Url & "load.php?q=61&q2=" & str)
    End Sub

    Public Function Counter() As String
        Dim wc As New WebClient()
        Dim json = wc.DownloadString(Url & "load.php?q=62&q2=")
        Dim data As List(Of clsCombo2) = JsonConvert.DeserializeObject(Of List(Of clsCombo2))(json)
        Counter = data.Item(0).name
    End Function


    Private Sub cmdf10_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdf10.Click
        Me.Hide()
    End Sub

    Private Sub t1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles t1.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
        If e.KeyCode = Keys.F1 Then
            cmdf4.RaiseClick()
        End If
        If e.KeyCode = Keys.F2 Then
            cmdf2.RaiseClick()
        End If
        If e.KeyCode = Keys.Escape Then
            cmdf10.RaiseClick()
        End If
    End Sub

    Private Sub t1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t1.ValueChanged

    End Sub

    Private Sub t10_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles t10.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
        If e.KeyCode = Keys.F1 Then
            cmdf4.RaiseClick()
        End If
        If e.KeyCode = Keys.F2 Then
            cmdf2.RaiseClick()
        End If
        If e.KeyCode = Keys.Escape Then
            cmdf10.RaiseClick()
        End If
    End Sub

    Private Sub t11_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles t11.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
        If e.KeyCode = Keys.F1 Then
            cmdf4.RaiseClick()
        End If
        If e.KeyCode = Keys.F2 Then
            cmdf2.RaiseClick()
        End If
        If e.KeyCode = Keys.Escape Then
            cmdf10.RaiseClick()
        End If
    End Sub

    Private Sub t2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles t2.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
        If e.KeyCode = Keys.F1 Then
            cmdf4.RaiseClick()
        End If
        If e.KeyCode = Keys.F2 Then
            cmdf2.RaiseClick()
        End If
        If e.KeyCode = Keys.Escape Then
            cmdf10.RaiseClick()
        End If
    End Sub

    Private Sub t2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles t2.KeyPress

    End Sub

    Private Sub ButtonItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdf2.Click
        Me.Hide()
        frmSales.Hide()
        frmLogin.Visible = True
        frmScreen.txtDisc.Text = 0
        frmScreen.txtChange.Text = 0
        frmScreen.txtTotal.Text = 0
        frmScreen.txtPay.Text = 0
        frmScreen.grid1.Rows.Clear()
    End Sub
End Class