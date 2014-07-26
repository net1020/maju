Imports System.Net
Imports Newtonsoft.Json
Imports System.Drawing
Imports System.Drawing.Printing

Public Class frmSales
    Dim a As Integer
    Public grandtotal As Long


    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim dt1 As Date
        Dim cs1 As String
        dt1 = t3.Value
        cs1 = dt1.ToString("yyyy-MM-dd")

        Dim dt2 As Date
        Dim cs2 As String
        dt2 = t21.Value
        cs2 = dt2.ToString("yyyy-MM-dd")

        Dim str As String
        str = t2.Text & "|"
        str = str & cs1 & "|"
        str = str & "SQ" & "|"
        str = str & t4.SelectedValue & "|"
        str = str & t4.Text & "|"
        str = str & t6.Text & "|"

        str = str & "" & "|"
        str = str & t5.Text & "|"
        str = str & Replace(t97.Text, ",", "") & "|"
        str = str & t17.Text & "|"
        str = str & t18.Text & "|"

        str = str & Replace(t94.Text, ",", "") & "|"
        str = str & t26.Value & "|"
        str = str & Replace(t98.Text, ",", "") & "|"
        str = str & t19.Text & "|"
        str = str & t20.Text & "|"

        str = str & t24.Text & "|"
        str = str & t22.Text & "|"
        str = str & t23.Text & "|"
        str = str & cs2 & "|"
        str = str & t25.Text & "|"

        str = str & t7.Text & "|"
        str = str & t8.Text & "|"
        str = str & t9.Text & "|"
        str = str & t10.Text & "|"
        str = str & t11.Text & "|"

        str = str & t12.Text & "|"
        str = str & "" & "|"
        str = str & "" & "|"
        str = str & "" & "|"
        str = str & "" & "|"

        str = str & t99.Text & "|"
        str = str & userName & "|"
        str = str & itemDetail()

        If t0.Text = "" Then
            Inserted(201, str)
        Else
            Updated(202, str)
        End If
        Me.Hide()
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        load_enabled(True)
        editStatus = True
    End Sub

    Public Sub load_enabled(ByVal mode As Boolean)
        btnsave.Enabled = mode
        'btnsave1.Enabled = mode
        btnedit.Enabled = Not mode
        t2.Enabled = False
        t3.Enabled = mode
        t4.Enabled = mode
        t5.Enabled = mode
        t6.Enabled = mode
        t7.Enabled = mode
        t8.Enabled = mode
        t9.Enabled = mode
        t10.Enabled = mode
        t11.Enabled = mode
        t12.Enabled = mode
        t17.Enabled = mode
        t18.Enabled = mode
        t19.Enabled = mode
        t20.Enabled = mode
        t21.Enabled = mode
        t22.Enabled = mode
        t23.Enabled = mode
        t24.Enabled = mode
        t25.Enabled = mode
        t26.Enabled = mode
        t99.Enabled = mode
        btnremove.Enabled = mode
        'grid1.ReadOnly = Not mode
        grid1.Columns(1).ReadOnly = True
        grid1.Columns(3).ReadOnly = Not mode
        grid1.Columns(2).ReadOnly = True
        grid1.Columns(4).ReadOnly = True
        grid1.Columns(5).ReadOnly = True

        'grid1.ReadOnly = mode

    End Sub
    Function itemDetail() As String
        Dim j, n, n2 As Integer
        Dim str As String

        j = grid1.RowCount
        str = ""

        For n = 0 To j - 2
            str = str & t2.Text & "[]"
            For n2 = 1 To 10
                If n2 = 1 Then
                    str = str & n + 1
                End If
                If n2 = 2 Then
                    str = str & grid1.Item(1, n).Value
                End If
                If n2 = 3 Then
                    str = str & grid1.Item(2, n).Value
                End If

                If n2 = 4 Then
                    str = str & grid1.Item(3, n).Value
                End If

                If n2 = 5 Then
                    str = str & Replace(grid1.Item(4, n).Value, ",", "")
                End If

                If n2 = 6 Then
                    str = str & ""
                End If

                If n2 = 7 Then
                    str = str & ""
                End If

                If n2 = 8 Then
                    str = str & (Val(grid1.Item(3, n).Value) * Val(Replace(grid1.Item(4, n).Value, ",", "")))
                End If

                If n2 = 9 Then
                    str = str & ""
                End If

                If n2 = 10 Then
                    str = str & ""
                End If
                str = str & "[]"
            Next
            str = Strings.Left(str, Len(str) - 2)
            str = str & "{}"
        Next
        str = Strings.Left(str, Len(str) - 2)
        str = Replace(str, ".", "") 'replace numeric amount with dot 
        itemDetail = str
    End Function

    Private Sub grid1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid1.CellDoubleClick
        'frmSalesItem.ShowDialog()
        If editStatus = False Or e.ColumnIndex = 0 Then Exit Sub
        frmView2.Text = "Item Barang"
        frmView2.load_sales("20", True)
        frmView2.grid1.Columns(0).Visible = True
        frmView2.grid1.Columns(2).Visible = True
        frmView2.grid1.Columns(0).Width = 125
        frmView2.grid1.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        frmView2.grid1.Columns(3).Visible = False
        frmView2.ShowDialog()
       
        Dim a As Integer
        For a = 0 To grid1.RowCount - 2
            If grid1.Item(1, a).Value = frmView2.sCode Then
                grid1.Item(3, a).Value = Val(grid1.Item(3, a).Value) + 1
                grid1.Item(5, a).Value = grid1.Item(3, a).Value * grid1.Item(4, a).Value
                load_grandtotal()
                Exit Sub
            End If
        Next
        If frmView2.sCode <> "" Then
            grid1.Rows.Add("", frmView2.sCode, frmView2.sName, "1", frmView2.sprice, frmView2.sprice)

        End If
        load_grandtotal()
    End Sub

  

    Public Sub load_Customer()
        Dim wc As New WebClient()
        Dim json = wc.DownloadString(url & "all.php?u=" & userName & "&q=10&q2=")
        Dim users As List(Of clsCombo) = JsonConvert.DeserializeObject(Of List(Of clsCombo))(json)
        t4.DataSource = users
        t4.DisplayMember = "name"
        t4.ValueMember = "code"
        t4.SelectedIndex = 0
    End Sub

    Public Sub load_Salesman()
        Dim wc As New WebClient()
        Dim json = wc.DownloadString(url & "all.php?u=" & userName & "&q=11&q2=")
        Dim users As List(Of clsCombo) = JsonConvert.DeserializeObject(Of List(Of clsCombo))(json)
        t5.DataSource = users
        t5.DisplayMember = "name"
        t5.ValueMember = "code"
        t5.SelectedIndex = 0
    End Sub

    Public Sub load_Payment()
        Dim wc As New WebClient()
        Dim json = wc.DownloadString(url & "all.php?u=" & userName & "&q=12&q2=")
        Dim users As List(Of clsCombo) = JsonConvert.DeserializeObject(Of List(Of clsCombo))(json)
        t6.DataSource = users
        t6.DisplayMember = "name"
        t6.ValueMember = "code"
        t6.SelectedIndex = 0
    End Sub
    Public Sub load_Ship()
        Dim wc As New WebClient()
        Dim json = wc.DownloadString(url & "all.php?u=" & userName & "&q=13&q2=")
        Dim users As List(Of clsCombo) = JsonConvert.DeserializeObject(Of List(Of clsCombo))(json)
        t19.DataSource = users
        t19.DisplayMember = "name"
        t19.ValueMember = "code"
        t19.SelectedIndex = 0
    End Sub
    Public Sub load_Warehouse()
        Dim wc As New WebClient()
        Dim json = wc.DownloadString(url & "all.php?u=" & userName & "&q=14&q2=")
        Dim users As List(Of clsCombo) = JsonConvert.DeserializeObject(Of List(Of clsCombo))(json)
        t25.DataSource = users
        t25.DisplayMember = "name"
        t25.ValueMember = "code"
        t25.SelectedIndex = 0
    End Sub
    Public Sub load_sqno()
        Dim wc As New WebClient()
        Dim json = wc.DownloadString(url & "all.php?u=" & userName & "&q=15&q2=")
        Dim users As List(Of clsCombo) = JsonConvert.DeserializeObject(Of List(Of clsCombo))(json)
        t2.Text = users.Item(0).name
    End Sub
    Public Sub btnremove_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnremove.Click
        If grid1.RowCount > 1 Then
            btnremove.Enabled = True
            Me.grid1.Rows.RemoveAt(grid1.CurrentRow.Index)
        End If

        load_grandtotal


    End Sub


    Private Sub grid1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grid1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If editStatus = False Then Exit Sub
            frmView2.Text = "Item Barang"
            frmView2.load_sales("20", True)
            frmView2.grid1.Columns(0).Visible = True
            frmView2.grid1.Columns(2).Visible = True
            frmView2.grid1.Columns(0).Width = 125
            frmView2.grid1.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            frmView2.grid1.Columns(3).Visible = False
            frmView2.ShowDialog()
            If frmView2.sCode <> "" Then
                grid1.Rows.Add("", frmView2.sCode, frmView2.sName, "1", frmView2.sprice)
            End If
        End If

        load_grandtotal()
        
    End Sub

    Private Sub grid1_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid1.CellEnter
        Calculate_Total()
        load_grandtotal()
    End Sub

    Sub Calculate_Total()
        Dim i As Integer
        For i = 0 To grid1.RowCount - 2
            grid1.Item(5, i).Value = Val(Replace(grid1.Item(4, i).Value, ",", "")) * Val(grid1.Item(3, i).Value)
        Next i
    End Sub

    Private Sub t17_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles t17.KeyDown
        If e.KeyCode = Keys.Enter Then
            t18.Text = (Val(t17.Text) / 100) * Val(Replace(t97.Text, ",", ""))
        End If
        load_grandtotal()



    End Sub

    Private Sub t17_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles t17.MouseClick
        t18.Text = (Val(t17.Text) / 100) * Val(Replace(t97.Text, ",", ""))
        load_grandtotal()
    End Sub


    Private Sub t18_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles t18.KeyDown
        If e.KeyCode = Keys.Enter Then
            t17.Text = ((Val(Replace(t18.Text, ",", "")) * 100) / Val(Replace(t97.Text, ",", "")))
        End If
        load_grandtotal()
    End Sub
    'Item
    Public Sub load_grid_total()
        Dim q As Integer
        For q = 0 To grid1.RowCount - 2
            grandtotal = grandtotal + Val(grid1.Item(5, q).Value)
        Next
        t97.Text = FormatNumber(grandtotal, 0)

    End Sub
    'Discount
    Sub load_totaldisc()
        t18.Text = (Val(t17.Text) / 100) * Val(Replace(t97.Text, ",", ""))
        grandtotal = grandtotal - Val(Replace(t18.Text, ",", "")) + Val(Replace(t94.Text, ",", ""))
        t96.Text = FormatNumber(grandtotal, 0)
        t95.Text = t96.Text
        t18.Text = FormatNumber(t18.Text, 0)
    End Sub
    'Shipping
    Public Sub Load_totalship()
        If t26.Text > 0 Then
            grandtotal = grandtotal + Val(t26.Value)
            t98.Text = FormatNumber(grandtotal, 0)
            Exit Sub
        End If
    End Sub

    Public Sub t26_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles t26.KeyDown
        If e.KeyCode = Keys.Enter Then
            load_grandtotal()
        End If
    End Sub
    'Grand TOTAL
    Public Sub load_grandtotal()
        grandtotal = 0

        load_grid_total()
        load_totaldisc()
        Load_totalship()
        t98.Text = FormatNumber(grandtotal, 0)
    End Sub

    Private Sub btnexit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub t6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t6.SelectedIndexChanged
        On Error Resume Next

        load_ppn(t6.SelectedValue)
        Calculate_Total()
        load_grandtotal()
    End Sub

    Public Sub load_ppn(ByVal str As String)
        Dim wc As New WebClient()
        Dim json = wc.DownloadString(url & "all.php?u=" & userName & "&q=16&q2=" & str)
        Dim users As List(Of clsCombo) = JsonConvert.DeserializeObject(Of List(Of clsCombo))(json)
        t94.Text = "0"
        If users.Item(0).name <> "" Then
            t94.Text = (10 / 100) * (Val(Replace(t97.Text, ",", "")) - t18.Value)
            t94.Text = FormatNumber(t94.Text, 0)
        End If
    End Sub

    Public Sub load_printer()
        t1.Items.Clear()
        For Each Printer In PrinterSettings.InstalledPrinters
            t1.Items.Add(Printer)
        Next
        t1.SelectedIndex = 0
    End Sub

    Private Sub frmSales_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        load_printer()
    End Sub
End Class