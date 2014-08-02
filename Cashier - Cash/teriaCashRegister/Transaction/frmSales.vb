Imports System.Net
Imports Newtonsoft.Json
'Imports MSCommLib
Imports System.IO.Ports


Public Class frmSales
    Public salesId As String
    Public memberId As String
    Public userId As String
    Public SubTotal As Long
    Public loadPending As Boolean
    'Public salesNo As String
    'Public bookingNo As String


    Public Function Counter() As String
        Dim wc As New WebClient()
        Dim json = wc.DownloadString(Url & "load.php?q=53&q2=")
        Dim data As List(Of clsCombo2) = JsonConvert.DeserializeObject(Of List(Of clsCombo2))(json)
        Counter = data.Item(0).name
    End Function

    Public Function CounterBooking() As String
        Dim wc As New WebClient()
        Dim json = wc.DownloadString(Url & "load.php?q=55&q2=")
        Dim data As List(Of clsCombo2) = JsonConvert.DeserializeObject(Of List(Of clsCombo2))(json)
        CounterBooking = data.Item(0).name
    End Function

    Public Function Sub_Total() As Long
        Dim i As Integer
        For i = 0 To grid1.RowCount - 1
            Sub_Total = Sub_Total + (grid1.Item(7, i).Value)
        Next
    End Function

    Public Function TotalDisc() As Long
        Dim i As Integer
        TotalDisc = 0
        For i = 0 To grid1.RowCount - 1
            TotalDisc = TotalDisc + (Val(grid1.Item(3, i).Value) * Val(grid1.Item(5, i).Value) * (Val(grid1.Item(6, i).Value) / 100))
        Next
    End Function

    Public Function TotalQty() As Long
        Dim i As Integer
        For i = 0 To grid1.RowCount - 1
            TotalQty = TotalQty + grid1.Item(3, i).Value
        Next
    End Function

    Private Sub txtPLU_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            frmView3.Show()
        End If
    End Sub

    Private Sub ButtonItem10_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdf10.Click
        frmCashierOut.ShowDialog()
    End Sub

    Private Sub ButtonItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdf2.Click
        'grid1.Focus()
        On Error Resume Next
        
        grid1.CurrentCell = grid1.Rows(grid1.CurrentRow.Index).Cells(1)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        grid1.Rows.RemoveAt(1)
        'SerialPort1.PortName = "COM3"
        'SerialPort1.Open()
        'SerialPort1.Write("WELCOME TO ADNETINDO.COM")
    End Sub


    Private Sub ButtonItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdf8.Click
        frmView3.Text = "Salesman"
        If salesId = "" Then
            frmView3.sCode = ""
            frmView3.sName = ""
        End If
        frmView3.load_sales("11", False)
        frmView3.ShowDialog()
        'frmView2.BringToFront()
        salesId = frmView3.sCode
        cmbSales.Text = "Sales : " & frmView3.sName
        cmbSales.Tooltip = "Sales : " & frmView3.sName
        cmbSales.Refresh()
    End Sub

    Private Sub ButtonItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdf9.Click
        frmView3.Text = "Membership"
        If memberId = "" Then
            frmView3.sCode = ""
            frmView3.sName = ""
        End If
        frmView3.load_sales("21", False)
        frmView3.ShowDialog()
        'frmView2.BringToFront()
        memberId = frmView3.sCode
        cmbMember.Text = "Member : " & frmView3.sName
        cmbMember.Tooltip = "Member : " & frmView3.sName
        cmbMember.Refresh()
        Dim i As Integer
        For i = 0 To grid1.RowCount - 2
            load_item(i, grid1.Item(1, i).Value)
        Next
        'recheck_item(grid1.RowCount - 2)
    End Sub

    Private Sub ButtonItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdf5.Click
        frmView2.Text = "Item Barang"
        frmView2.load_sales("31", True)
        frmView2.grid1.Columns(0).Visible = True
        frmView2.grid1.Columns(2).Visible = True
        frmView2.grid1.Columns(0).Width = 125
        frmView2.grid1.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        frmView2.grid1.Columns(3).Visible = False
        frmView2.ShowDialog()
        If frmView2.sCode <> "" Then
            If grid1.RowCount = 1 Then grid1.Rows.Add("")
            If grid1.Item(3, grid1.RowCount - 2).Value = 1 Then grid1.Rows.Add("")
            If grid1.Item(2, grid1.RowCount - 2).Value <> "" Then grid1.Rows.Add("")
            grid1.Item(1, grid1.RowCount - 2).Value = frmView2.sCode
            grid1.CurrentCell = grid1.Rows(grid1.RowCount - 2).Cells(1)
            If grid1.Item(3, grid1.RowCount - 2).Value > 1 Then SendKeys.Send("{ENTER}")
        End If


        'frmView2.BringToFront()

    End Sub

    Private Sub grid1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid1.CellClick
        On Error Resume Next
        grid1.CurrentCell = grid1.CurrentRow.Cells(1)

    End Sub

    Private Sub grid1_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid1.CellEnter
        On Error Resume Next
        'If grid1.Item(1, grid1.RowCount - 2).Value = "" Then SendKeys.Send("{UP}")

        Online_Status()
        grid1.CurrentCell = grid1.CurrentRow.Cells(1)
        reload_item()
        recheck_item(e.RowIndex)

    End Sub

    Sub load_item(ByVal row As Integer, ByVal str As String)
        On Error Resume Next
        Dim total As Long
        Dim discType As String
        Dim wc As New WebClient()
        If memberId = "" Or memberId = "0" Then
            discType = "public"
        Else
            discType = "member"
        End If
        Dim json = wc.DownloadString(Url & "load.php?q=41&q2=" & str & "|" & disctype)
        Dim data As List(Of clsItem) = JsonConvert.DeserializeObject(Of List(Of clsItem))(json)
        grid1.Item(0, row).Value = row + 1
        grid1.Item(1, row).Value = data.Item(0).itemcode
        grid1.Item(2, row).Value = data.Item(0).itemname
        If grid1.Item(3, row).Value = "" Then grid1.Item(3, row).Value = 1
        grid1.Item(4, row).Value = data.Item(0).unit
        grid1.Item(5, row).Value = data.Item(0).unitprice
        grid1.Item(6, row).Value = data.Item(0).discount
        total = (data.Item(0).unitprice - (data.Item(0).unitprice * (Val(grid1.Item(6, row).Value) / 100))) * grid1.Item(3, row).Value
        grid1.Item(7, row).Value = total
        grid1.Item(1, row).ReadOnly = True
        grid1.Item(3, row).ReadOnly = True
        lblName.Text = data.Item(0).itemname
        lblQty.Text = 1 & " " & grid1.Item(4, row).Value
        lblPrice.Text = FormatCurrency(data.Item(0).unitprice, 0)
        SubTotal = Sub_Total()
        lblSubTotal.Text = FormatCurrency(SubTotal, 0)

        If Err.Number > 0 Then
            timerItem.Enabled = True

        End If

        Err.Number = 0
        Print_Screen(data.Item(0).itemname, grid1.Item(3, row).Value & grid1.Item(4, row).Value, data.Item(0).unitprice)
    End Sub

    Sub reload_item()
        Dim i As Integer
        For i = 0 To grid1.RowCount - 1
            If grid1.Item(1, i).Value <> "" And grid1.Item(2, i).Value = "" Then
                load_item(i, grid1.Item(1, i).Value)
            End If
        Next
    End Sub

    Sub voidall_item()
        'Dim i As Integer
        Online_Status()
        'For i = 0 To grid1.RowCount - 2
        '    grid1.Rows.RemoveAt(0)
        'Next
        grid1.Rows.Clear()
        clear_label()
        SubTotal = 0
        salesId = ""
        memberId = ""
        '        salesNo = Counter()
        '      bookingNo = CounterBooking()
        Print_Screen2("Welcome to", "Toko Madju")
    End Sub

    Public Function SalesNo() As String
        SalesNo = Counter()
    End Function

    Public Function bookingNo() As String
        bookingNo = CounterBooking()
    End Function

    Sub clear_label()
        lblName.Text = ""
        lblPrice.Text = FormatCurrency(0, 0)
        lblQty.Text = ""
        lblSubTotal.Text = FormatCurrency(0, 0)
        cmbMember.Text = ""
        cmbSales.Text = ""
        cmbMember.Tooltip = ""
        cmbSales.Tooltip = ""
    End Sub

    Sub recheck_item(ByVal sColumn As Integer)
        Dim i As Integer
        Dim Max As Integer
        Max = grid1.RowCount - 2
        If Max = sColumn - 1 Then
            For i = 0 To Max - 1
                If grid1.Item(1, i).Value = grid1.Item(1, Max).Value Then

                    grid1.Item(3, i).Value = Val(grid1.Item(3, i).Value) + Val(grid1.Item(3, Max).Value)
                    grid1.Item(7, i).Value = (Val(grid1.Item(5, i).Value) - (Val(grid1.Item(5, i).Value) * (Val(grid1.Item(6, i).Value) / 100))) * Val(grid1.Item(3, i).Value)
                    timerItem.Enabled = True

                End If
                grid1.Item(0, i).Value = i + 1
            Next
        End If
    End Sub

    Private Sub timerItem_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerItem.Tick
        On Error Resume Next

        grid1.Rows.RemoveAt(grid1.RowCount - 2)
        timerItem.Enabled = False
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ButtonItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdf12.Click
        'voidall_item()
        Open_Drawer()

    End Sub

    Sub Open_Drawer()
        'Dim sPort As SerialPort = New SerialPort(port1.Text, 38400, Parity.None, 8)
        'sPort.Open()
        'sPort.Write(Chr(27) & Chr(112) & Chr(0) & Chr(25) & Chr(250))
        'sPort.Close()
    End Sub

    Sub OpenDrawer()
        'A new instance of the MSComm control
        'Dim MSComm2 As MSComm
        'MSComm2 = New MSComm
        Dim Buffer(4) As Byte
        Buffer(0) = 27
        Buffer(1) = 112
        Buffer(2) = 0
        Buffer(3) = 25
        Buffer(4) = 250
        'MSComm2.CommPort = 4
        'MSComm2.Settings = "9600,N,8,1"
        '' Open the port.
        'MSComm2.PortOpen = True
        '' Send the eject command
        'MSComm2.Output = Buffer
        'MSComm2.PortOpen = False
    End Sub

    Private Sub ButtonItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdf3.Click
        On Error Resume Next
        grid1.Focus()
        grid1.CurrentCell = grid1.Rows(grid1.CurrentRow.Index).Cells(3)
        SendKeys.Send("{ENTER}")
    End Sub

    Private Sub ButtonItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdf11.Click
        On Error Resume Next


        grid1.Rows.RemoveAt(grid1.RowCount - 2)
        SubTotal = Sub_Total()
        lblSubTotal.Text = FormatCurrency(SubTotal, 0)
    End Sub

    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Dim time As DateTime = DateTime.Now
        Dim format As String = "dddd, dd-MMM-yyyy HH:mm:ss"
        lblTime.Text = time.ToString(format)
    End Sub

    Private Sub frmSales_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then cmdf1.RaiseClick()
        If e.KeyCode = Keys.F2 Then cmdf2.RaiseClick()
        If e.KeyCode = Keys.F3 Then cmdf3.RaiseClick()
        If e.KeyCode = Keys.F4 Then cmdf4.RaiseClick()
        If e.KeyCode = Keys.F5 Then cmdf5.RaiseClick()

        If e.KeyCode = Keys.F6 Then cmdf6.RaiseClick()
        If e.KeyCode = Keys.F7 Then cmdf7.RaiseClick()
        If e.KeyCode = Keys.F8 Then cmdf8.RaiseClick()
        If e.KeyCode = Keys.F9 Then cmdf9.RaiseClick()
        If e.KeyCode = Keys.F10 Then cmdf10.RaiseClick()

        If e.KeyCode = Keys.F11 Then cmdf11.RaiseClick()
        If e.KeyCode = Keys.F12 Then cmdf12.RaiseClick()
        If e.KeyCode = Keys.PrintScreen Then cmdPrint.RaiseClick()
    End Sub

    Private Sub frmSales_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave
        SerialPort1.Close()
    End Sub

    Private Sub frmSales_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        On Error Resume Next
        grid1.Focus()
        clear_label()
        'Me.TopMost = True
        'Open_Screen()
        'load_welcome()
        voidall_item()
        cmdUser.Text = "Cashier : " & userName
        cmdf2.RaiseClick()
    End Sub

    Sub load_welcome()
        SerialPort1.Write("Welcome to" & "          ")
        Dim stext As String
        stext = "Toko Madju"
        SerialPort1.Write(stext & "         ")
    End Sub

    Private Sub grid1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grid1.KeyDown
        If e.KeyCode = Keys.F1 Then cmdf1.RaiseClick()
        If e.KeyCode = Keys.F2 Then cmdf2.RaiseClick()
        If e.KeyCode = Keys.F3 Then cmdf3.RaiseClick()
        If e.KeyCode = Keys.F4 Then cmdf4.RaiseClick()
        If e.KeyCode = Keys.F5 Then cmdf5.RaiseClick()

        If e.KeyCode = Keys.F6 Then cmdf6.RaiseClick()
        If e.KeyCode = Keys.F7 Then cmdf7.RaiseClick()
        If e.KeyCode = Keys.F8 Then cmdf8.RaiseClick()
        If e.KeyCode = Keys.F9 Then cmdf9.RaiseClick()
        If e.KeyCode = Keys.F10 Then cmdf10.RaiseClick()

        If e.KeyCode = Keys.F11 Then cmdf11.RaiseClick()
        If e.KeyCode = Keys.F12 Then cmdf12.RaiseClick()
        If e.KeyCode = Keys.PrintScreen Then cmdPrint.RaiseClick()
    End Sub

    Private Sub grid1_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid1.CellEndEdit
        If e.ColumnIndex = 3 Then
            cmdf2.RaiseClick()
            SendKeys.Send("{UP}")
        End If
    End Sub

    Sub Print_Screen(ByVal line1 As String, ByVal line2a As String, ByVal line2b As String)
        Dim sDisplay As String
        On Error Resume Next
        SerialPort1.PortName = Port
        SerialPort1.Open()
        '   SerialPort1.Write(" ")
        Dim i1, i2, i3 As Integer
        i1 = Len(line1)
        If i1 > 20 Then i1 = 20
        i2 = Len(line2a)
        If i2 > 10 Then i2 = 10
        i3 = Len(FormatNumber(line2b, 0))
        If i3 > 9 Then i3 = 9
        sDisplay = Strings.Left(line1, i1) & Strings.Left("                    ", 20 - i1)
        sDisplay = sDisplay & Strings.Left(line2a, i2) & Strings.Left("          ", 10 - i2)
        line2b = FormatNumber(line2b, 0)
        sDisplay = sDisplay & Strings.Left("          ", 9 - i3) & Strings.Left(line2b, i3)
        SerialPort1.Write(vbNewLine)
        SerialPort1.Write(sDisplay)
        SerialPort1.Close()
        SerialPort1.Dispose()
    End Sub

    Sub Print_Display(ByVal line1 As String, ByVal line2a As String, ByVal line2b As String)
        Dim i1, i2, i3 As Integer
        i1 = Len(line1)
        If i1 > 15 Then i1 = 15
        i2 = Len(line2a)
        If i2 > 10 Then i2 = 10
        i3 = Len(FormatNumber(line2b, 0))
        If i3 > 9 Then i3 = 9
        lblName.Text = Strings.Left(line1, i1) & Strings.Left("               ", 15 - i1)
        lblQty.Text = Strings.Left(line2a, i2) & Strings.Left("          ", 10 - i2)
        line2b = FormatNumber(line2b, 0)
        lblPrice.Text = Strings.Left("          ", 9 - i3) & Strings.Left(line2b, i3)
    End Sub


    Sub Online_Status()
        Dim wc As New WebClient()
        On Error Resume Next
        Dim json = wc.DownloadString(Url & "load.php?q=1")


        'MsgBox(json)
        Dim data As List(Of clsCombo2) = JsonConvert.DeserializeObject(Of List(Of clsCombo2))(json)
        If data.Item(0).code <> "1" Then
            cmdOffline.Visible = True
            cmdOnline.Visible = False
            cmdOffline.Refresh()
        Else
            cmdOffline.Visible = False
            cmdOnline.Visible = True
            cmdOnline.Refresh()
        End If
        ribbonMenu.Refresh()
    End Sub


    Private Sub cmdf1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdf1.Click
        If MsgBox("do you confirm to void all the items?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            voidall_item()
        End If
        SendKeys.Send("{TAB}")
        SendKeys.Send("{TAB}")
        cmdf2.RaiseClick()
    End Sub

    Private Sub cmdf4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdf4.Click
        If grid1.RowCount = 1 Then Exit Sub
        SubTotal = Sub_Total()
        frmPayment.t1.Text = FormatNumber(SubTotal, 0)
        frmPayment.t2.Text = FormatNumber(0, 0)
        frmPayment.t3.Text = FormatNumber(0, 0)
        frmPayment.t4.Text = FormatNumber(0, 0)
        frmPayment.t4a.Text = FormatNumber(SubTotal, 0)
        frmPayment.t5.Text = FormatNumber(0, 0)
        frmPayment.t6.Text = FormatNumber(0, 0)
        frmPayment.t7.Text = FormatNumber(0, 0)
        frmPayment.t8.Text = FormatNumber(0, 0)
        frmPayment.t9.Text = FormatNumber(0, 0)
        frmPayment.t10.Text = FormatNumber(SubTotal, 0)
        Print_Screen2("Total", FormatCurrency(SubTotal))
        frmPayment.Show()

    End Sub

    Private Sub grid1_ColumnDataPropertyNameChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewColumnEventArgs) Handles grid1.ColumnDataPropertyNameChanged

    End Sub

    Private Sub cmdf6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdf6.Click
        If grid1.RowCount > 1 Then
            If MsgBox("do you confirm to pending this transaction?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Save_Booking(bookingNo() & "|" & salesId & "|" & memberId & "|" & "" & "|" & Sub_Total() & "|" & userName & "|" & BookingDetail())
                Print_Screen2("No Pending", BookingNumber())
                MsgBox("No Pending : " & BookingNumber())
                voidall_item()
                cmdf2.RaiseClick()
            End If
        End If
    End Sub

    Sub Save_Booking(ByVal str As String)
        Dim wc As New WebClient()
        Dim json = wc.DownloadString(Url & "load.php?q=54&q2=" & str)
    End Sub

    Function BookingDetail() As String
        Dim j, n, n2 As Integer
        Dim str As String

        j = grid1.RowCount
        str = ""

        For n = 0 To j - 2
            str = str & bookingNo & "[]"
            For n2 = 1 To 8
                If n2 = 1 Then str = str & "Item" 'Kits
                If n2 = 2 Then str = str & grid1.Item(n2 - 1, n).Value()
                If n2 = 3 Then str = str & grid1.Item(0, n).Value()
                If n2 > 3 Then str = str & grid1.Item(n2 - 1, n).Value()

                str = str & "[]"
            Next
            str = Strings.Left(str, Len(str) - 2)
            str = str & "{}"
        Next
        str = Strings.Left(str, Len(str) - 2)
        BookingDetail = str
    End Function

    Public Function BookingNumber() As String
        Dim wc As New WebClient()
        Dim json = wc.DownloadString(Url & "load.php?q=56&q2=" & userName)
        Dim data As List(Of clsCombo2) = JsonConvert.DeserializeObject(Of List(Of clsCombo2))(json)
        On Error Resume Next

        BookingNumber = data.Item(0).name
    End Function

    Private Sub cmdf7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdf7.Click
        frmView3.Text = "Pending"
        frmView3.load_sales("57&q2=" & userName, False)
        frmView3.ShowDialog()
        'frmView2.BringToFront()

        If frmView3.sCode <> "" Then load_sales(frmView3.sCode)
        reload_item()
        recheck_item(0)
    End Sub

    Sub load_sales(ByVal sNo As String)
        Dim wc As New WebClient()
        Dim json = wc.DownloadString(Url & "load.php?q=58&q2=" & sNo)
        Dim data As List(Of clsReport) = JsonConvert.DeserializeObject(Of List(Of clsReport))(json)
        load_Header(data)
        load_Detail(data)

    End Sub

    Sub load_Header(ByVal data1 As List(Of clsReport))
        On Error Resume Next
        salesId = data1.Item(0).f2
        memberId = data1.Item(0).f3
        If salesId <> "" Then
            cmbSales.Text = "Sales : " & data1.Item(0).f8
            cmbSales.Tooltip = "Sales : " & data1.Item(0).f8
            cmbSales.Refresh()
        End If
        If memberId <> "" Then
            cmbMember.Text = "Member : " & data1.Item(0).f9
            cmbMember.Tooltip = "Member : " & data1.Item(0).f9
            cmbMember.Refresh()
        End If
    End Sub

    Sub load_Detail(ByVal data2 As List(Of clsReport))
        Dim str, str2 As String
        Dim strArr(), strArr2() As String
        Dim count As Integer
        On Error Resume Next

        str = data2.Item(0).f7
        strArr = str.Split(";")
        For count = 0 To strArr.Length - 1
            str2 = strArr(count)
            strArr2 = str2.Split("|")

            grid1.Rows.Add("", strArr2(2), "", strArr2(4))
        Next
    End Sub

    Public Sub Print_Screen2(ByVal line1 As String, ByVal line2 As String)
        Dim sDisplay As String
        Dim i1, i2 As Integer
        On Error Resume Next

        SerialPort1.PortName = Port
        SerialPort1.Open()
        i1 = Len(line1)
        If i1 > 20 Then i1 = 20
        i2 = Len(line2)
        If i2 > 20 Then i2 = 19
        sDisplay = Strings.Left(line1, i1) & Strings.Left("                    ", 20 - i1)
        sDisplay = sDisplay & Strings.Left(line2, i2) & Strings.Left("                   ", 19 - i2)
        SerialPort1.Write(vbNewLine)
        SerialPort1.Write(sDisplay)
        SerialPort1.Close()
        SerialPort1.Dispose()
    End Sub

    Private Sub cmbMember_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMember.Click
        'System.Diagnostics.Process.Start(Application.StartupPath & "\print.bat")
        'Dim myProcess As Process = New Process
        'Dim sysFolder As String = Application.StartupPath & "\print.bat"
        'myProcess.StartInfo.FileName = sysFolder
        'myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        'myProcess.StartInfo.CreateNoWindow = True
        'myProcess.Start()
        'myProcess.WaitForExit()
        'myProcess.Close()
    End Sub

    Private Sub cmbSales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSales.Click
        'Dim sPort As SerialPort = New SerialPort(port1.Text, 9600, Parity.None, 8)
        'sPort.Open()
        'sPort.Write("Great one")
        'sPort.Close()
    End Sub



    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        frmPayment.print_Sales()
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim wc As New WebClient()
        Dim json = wc.DownloadString(Url & "print/all.php?q=63&q2=")
        Dim users As List(Of clsReport) = JsonConvert.DeserializeObject(Of List(Of clsReport))(json)
        RunReportPrinter(users, "/template/sales.rpt", "")
    End Sub


    Private Sub grid1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid1.CellContentClick

    End Sub
End Class