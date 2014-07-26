Imports System.Net
Imports Newtonsoft.Json
Imports System.Drawing
Imports System.Drawing.Printing

Public Class frmSales
    Dim a As Integer
    Public grandtotal As Long
    Public editStatus As Boolean
    Public strArr() As String

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

        If tab1.Tabs(0).Text = "Sales Quotation" Then
            str = str & "SQ" & "|"
        Else
            str = str & "SO" & "|"
            If t21.Value < Today Then
                MsgBox("Please check the delivery date", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                t21.Focus()
                Exit Sub
            End If
        End If

        str = str & t4.SelectedValue & "|"
        str = str & t4.Text & "|"
        str = str & t6.Text & "|"

        str = str & "" & "|"
        str = str & t5.Text & "|"
        str = str & Replace(Replace(t97.Text, ",", ""), ".", "") & "|"
        str = str & t17.Value & "|"
        str = str & t18.Value & "|"

        str = str & Replace(Replace(t94.Text, ",", ""), ".", "") & "|"
        str = str & t26.Value & "|"
        str = str & grandtotal & "|"
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

        If Me.Text = "Add" Then
            Inserted("SQinsert", str)
        Else
            Updated("SQupdate", str)
        End If
        load_enabled(False)
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
                    str = str & Replace(Replace(grid1.Item(4, n).Value, ",", ""), ".", "")
                End If

                If n2 = 6 Then
                    str = str & ""
                End If

                If n2 = 7 Then
                    str = str & ""
                End If

                If n2 = 8 Then
                    str = str & (Val(grid1.Item(3, n).Value) * Val(Replace(Replace(grid1.Item(4, n).Value, ",", ""), ".", "")))
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
        frmView2.load_sales("20", "")
        frmView2.grid1.Columns(0).Width = 125
        frmView2.grid1.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        frmView2.ShowDialog()

        'Dim a As Integer
        'For a = 0 To grid1.RowCount - 2
        '    If grid1.Item(1, a).Value = frmView2.sCode Then
        '        grid1.Item(3, a).Value = Val(grid1.Item(3, a).Value) + 1
        '        grid1.Item(5, a).Value = grid1.Item(3, a).Value * grid1.Item(4, a).Value
        '        load_grandtotal()
        '        Exit Sub
        '    End If
        'Next
        'If frmView2.sCode <> "" Then
        '    grid1.Rows.Add("", frmView2.sCode, frmView2.sName, "1", Replace(Replace(frmView2.sPrice, ",", ""), ".", ""), Replace(Replace(frmView2.sPrice, ",", ""), ".", ""))

        'End If
        load_grandtotal()
    End Sub

    Public Sub btnremove_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnremove.Click
        On Error Resume Next
        If grid1.RowCount > 1 Then
            btnremove.Enabled = True
            Me.grid1.Rows.RemoveAt(grid1.CurrentRow.Index)
        End If

        load_grandtotal()


    End Sub


    Private Sub grid1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grid1.KeyDown
        If e.KeyCode = Keys.Enter Then
            'frmSalesItem.ShowDialog()
            If editStatus = False Then Exit Sub
            frmView2.Text = "Item Barang"
            frmView2.load_sales("20", "")
            frmView2.grid1.Columns(0).Width = 125
            frmView2.grid1.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            frmView2.ShowDialog()

            'Dim a As Integer
            'For a = 0 To grid1.RowCount - 2
            '    If grid1.Item(1, a).Value = frmView2.sCode Then
            '        grid1.Item(3, a).Value = Val(grid1.Item(3, a).Value) + 1
            '        grid1.Item(5, a).Value = grid1.Item(3, a).Value * grid1.Item(4, a).Value
            '        load_grandtotal()
            '        Exit Sub
            '    End If
            'Next
            'If frmView2.sCode <> "" Then
            '    grid1.Rows.Add("", frmView2.sCode, frmView2.sName, "1", frmView2.sPrice, frmView2.sPrice)

            'End If
            load_grandtotal()
        End If

    End Sub

    Private Sub grid1_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid1.CellEnter
        Calculate_Total()
        load_grandtotal()
    End Sub

    Sub Calculate_Total()
        Dim i As Integer
        For i = 0 To grid1.RowCount - 2
            grid1.Item(5, i).Value = Val(Replace(Replace(grid1.Item(4, i).Value, ",", ""), ".", "")) * Val(grid1.Item(3, i).Value)
        Next i
    End Sub

    Private Sub t17_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles t17.KeyDown
        If e.KeyCode = Keys.Enter Then
            t18.Text = (Val(t17.Text) / 100) * Val(Replace(Replace(t97.Text, ",", ""), ".", ""))
        End If
        load_grandtotal()



    End Sub

    Private Sub t17_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles t17.MouseClick
        t18.Text = (Val(t17.Text) / 100) * Val(Replace(Replace(t97.Text, ",", ""), ".", ""))
        load_grandtotal()
    End Sub


    Private Sub t18_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles t18.KeyDown
        If e.KeyCode = Keys.Enter Then
            t17.Text = (t18.Text * 100) / Val(Replace(Replace(t97.Text, ",", ""), ".", ""))
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
        t18.Text = (Val(t17.Text) / 100) * Val(Replace(Replace(t97.Text, ",", ""), ".", ""))
        grandtotal = (grandtotal - t18.Text)


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
        load_ppn(t6.SelectedValue)
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
        Dim dNet As New adnetObj.clsAdnet
        t94.Text = "0"
        If dNet.loadComboData(16, str) <> "" Then
            t94.Text = FormatNumber(grandtotal * 0.1, 0)
            grandtotal = grandtotal * 1.1
        End If
        t96.Text = FormatNumber(grandtotal, 0)
        t95.Text = FormatNumber(grandtotal, 0)
    End Sub

    Private Sub frmSales_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim frm As New adnetObj.clsAdnet
        If Microsoft.VisualBasic.Left(Me.Text, 3) = "Add" Then
            load_enabled(True)
            editStatus = True
            Clear_data()
            tab1.Tabs(0).Text = Microsoft.VisualBasic.Right(Me.Text, Len(Me.Text) - 6)

        End If
        If Microsoft.VisualBasic.Left(Me.Text, 4) = "Edit" Then
            load_enabled(False)
            editStatus = False
            Clear_data()
            load_data()
            tab1.Tabs(0).Text = Microsoft.VisualBasic.Right(Me.Text, Len(Me.Text) - 7)
        End If

        TB2.SelectedTabIndex = 0
    End Sub

    Sub load_data()
        Dim frm As New adnetObj.clsAdnet
        Dim strArr() As String
        frm.load_printer(t1)

        strArr = Split(Me.Tag, "|")
        t2.Text = strArr(0)
        t3.Value = strArr(1)
        'Customer
        frm.loadCombo(t4, 10, "")
        t4.Text = strArr(4)
        'Salesman
        frm.loadCombo(t5, 11, "")
        t5.Text = strArr(7)
        'Payment terms
        frm.loadCombo(t6, 12, "")
        t6.Text = strArr(5)
        'Shipping
        frm.loadCombo(t19, 13, "")
        t19.Text = strArr(14)
        'Warehouse
        t7.Text = strArr(21)
        t8.Text = strArr(22)
        t9.Text = strArr(23)
        t10.Text = strArr(24)
        t11.Text = strArr(25)
        t12.Text = strArr(26)

        t17.Value = Val(strArr(9))
        t18.Value = Val(strArr(10))
        t20.Text = strArr(15)
        t21.Text = strArr(19)
        t22.Text = strArr(17)
        t23.Text = strArr(18)
        t24.Text = strArr(16)

        t26.Text = strArr(12)

        frm.loadCombo(t25, 14, "")
        t25.Text = strArr(20)
        t99.Text = strArr(31)
        t94.Text = FormatNumber(Val(strArr(11)), 0)
        load_griddata(strArr(32))
    End Sub

    Sub load_griddata(ByVal str As String)
        Dim arr1() As String
        Dim arr2() As String
        Dim i As Integer
        arr1 = str.Split("{")
        grid1.Rows.Clear()
        For i = 0 To arr1.Length - 1
            arr2 = arr1(i).Split("[")
            grid1.Rows.Add("", arr2(2), arr2(3), arr2(4), arr2(5), arr2(8))
        Next

    End Sub

    Sub Clear_data()
        Dim frm As New adnetObj.clsAdnet
        frm.load_printer(t1)
        frm.loadCounter(t2, 15)
        t3.Value = Today
        'Customer
        frm.loadCombo(t4, 10, "")
        'Salesman
        frm.loadCombo(t5, 11, "")
        'Payment terms
        frm.loadCombo(t6, 12, "")
        'Shipping
        frm.loadCombo(t19, 13, "")
        'Warehouse
        frm.loadCombo(t25, 14, "")
        t7.Text = ""
        t8.Text = ""
        t9.Text = ""
        t10.Text = ""
        t11.Text = ""
        t12.Text = ""
        t17.Text = 0
        t18.Text = 0
        t20.Text = ""
        t21.Text = ""
        t22.Text = ""
        t23.Text = ""
        t24.Text = ""
        t26.Text = 0
        t99.Text = ""
        grid1.Rows.Clear()
    End Sub

    Private Sub ButtonItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem1.Click
        Dim frm As New adnetObj.clsAdnet
        tab1.Tabs(0).Text = "Sales Order"
        Me.Text = "Add"
        frm.loadCounter(t2, 17)
        load_enabled(True)
    End Sub

    Private Sub grid1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid1.CellContentClick

    End Sub
End Class