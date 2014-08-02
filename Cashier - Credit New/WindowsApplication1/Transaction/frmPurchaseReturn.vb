Public Class frmPurchaseReturn
    Dim editStatus As Boolean
    Dim grandTotal As Long

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCustomer.Click
        Dim adnet As adnetObj.frmSelect = New adnetObj.frmSelect()
        adnet.UrlClient = url
        adnet.newForm = False
        adnet.grid("Supplier")
        adnet.Text = "Supplier"
        adnet.ShowDialog()
        Dim adnet2 As adnetObj.clsAdnet = New adnetObj.clsAdnet()
        adnet2.loadCombo(cmbCustomer, 37, "")
        On Error Resume Next
        cmbCustomer.Text = adnet.SelectedData(2)
    End Sub

    Sub load_Setting()
        Dim adnet As adnetObj.clsAdnet = New adnetObj.clsAdnet()
        adnet.loadCombo(cmbCustomer, 37, "")
        adnet.loadCounter(txtTransno, 42)
        'adnet.loadCombo(cmbSales, 11, "")
        adnet.loadCombo(cmbPayment, 12, "", "Cash")
        adnet.loadCombo(cmbWarehouse, 14, "")
        adnet.load_printer(cmbPrinter)
        dtTrans.Value = Now

    End Sub

    Private Sub frmSalesOrder_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim frm As New adnetObj.clsAdnet
        load_Setting()
        If Microsoft.VisualBasic.Left(Me.Text, 3) = "Add" Then

            ' editStatus = True
            Clear_data()
            'tab1.Tabs(0).Text = Microsoft.VisualBasic.Right(Me.Text, Len(Me.Text) - 6)
            load_enabled(True)
        End If
        If Microsoft.VisualBasic.Left(Me.Text, 4) = "Edit" Then

            editStatus = False
            Clear_data()
            load_data()
            'tab1.Tabs(0).Text = Microsoft.VisualBasic.Right(Me.Text, Len(Me.Text) - 7)
            load_enabled(False)
        End If
        'load_enabled(True)

    End Sub

    Sub load_data()
        Dim frm As New adnetObj.clsAdnet
        Dim strArr() As String
        strArr = Split(Me.Tag, "|")
        load_griddata(strArr(16))
        txtTransno.Text = strArr(0)
        dtTrans.Value = strArr(1)
        cmbCustomer.Text = strArr(4)
        'cmbSales.Text = strArr(7)
        cmbPayment.Text = strArr(5)
        cmbWarehouse.Text = strArr(14)

        'tAmount.Value = strArr(8)
        tDisccent.Value = Val(strArr(9))
        'tDiscamount.Value = strArr(10)
        tPPNcent.Value = Val(strArr(11))
        'tPPNamount.Value = 0.1 * (Val(strArr(8)) - Val(strArr(10)))
        tOtherfee.Value = strArr(12)
        'tSubtotal.Value = Replace(Replace(strArr(13), ",", ""), ".", "")
        'tTotal.Text = strArr(13)
        txtNote.Text = strArr(15)
        tCash.Value = strArr(17)
        tCredit.Value = strArr(18)
        load_grid_total()

    End Sub
    Sub Clear_data()
        Dim frm As New adnetObj.clsAdnet
        dtTrans.Value = Today
        tAmount.Value = 0
        tDisccent.Value = 0
        tDiscamount.Value = 0
        tPPNcent.Value = 0
        tPPNamount.Value = 0
        tSubtotal.Value = 0
        tCash.Value = 0
        tCredit.Value = 0
        txtNote.Text = ""
        tTotal.Text = 0
        grid1.Rows.Clear()
    End Sub

    Sub load_griddata(ByVal str As String)
        Dim arr1() As String
        Dim arr2() As String
        Dim i As Integer
        arr1 = str.Split("{")
        grid1.Rows.Clear()
        For i = 0 To arr1.Length - 1
            arr2 = arr1(i).Split("[")
            grid1.Rows.Add("", arr2(1), arr2(2), arr2(3), arr2(4), arr2(5), arr2(6), arr2(8))
        Next
    End Sub



    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdWarehouse.Click
        Dim adnet As adnetObj.frmSelect = New adnetObj.frmSelect()
        adnet.UrlClient = url
        adnet.newForm = False
        adnet.grid("warehouse")
        adnet.Text = "warehouse"
        adnet.ShowDialog()
        Dim adnet2 As adnetObj.clsAdnet = New adnetObj.clsAdnet()
        adnet2.loadCombo(cmbWarehouse, 14, "")
        cmbWarehouse.Text = adnet.SelectedData(1)
    End Sub

    Private Sub ButtonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPayment.Click
        Dim adnet As adnetObj.frmSelect = New adnetObj.frmSelect()
        adnet.UrlClient = url
        adnet.newForm = False
        adnet.grid("payment")
        adnet.Text = "payment"
        adnet.ShowDialog()
        Dim adnet2 As adnetObj.clsAdnet = New adnetObj.clsAdnet()
        adnet2.loadCombo(cmbPayment, 12, "")
        cmbPayment.Text = adnet.SelectedData(1)
    End Sub

    Private Sub grid1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid1.CellDoubleClick
        If cmdSave.Enabled = False Then Exit Sub
        frmView2.Text = "Item Barang"
        frmView2.load_sales("20", "")
        frmView2.grid1.Columns(0).Width = 125
        frmView2.grid1.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        frmView2.txtSearch.Focus()
        frmView2.ShowDialog()

        If frmView2.selected = True Then
            Dim a As Integer
            For a = 0 To grid1.RowCount - 2
                If grid1.Item(1, a).Value = frmView2.selectedData(0) Then
                    grid1.Item(3, a).Value = Val(grid1.Item(3, a).Value) + 1
                    grid1.Item(7, a).Value = Val(grid1.Item(3, a).Value) * grid1.Item(5, a).Value
                    load_grid_total()
                    Exit Sub
                End If
            Next

            grid1.Rows.Add("", frmView2.selectedData(0), frmView2.selectedData(1), "1", frmView2.selectedData(2), Replace(Replace(frmView2.selectedData(3), ",", ""), ".", ""), Val(frmView2.selectedData(4)), Replace(Replace(frmView2.selectedData(3), ",", ""), ".", ""))
            load_grid_total()
        End If

    End Sub

    Public Sub load_grid_total()
        Dim q As Integer

        grandTotal = 0
        For q = 0 To grid1.RowCount - 2
            grid1.Item(7, q).Value = Val(grid1.Item(3, q).Value) * Val(grid1.Item(5, q).Value)
            grandTotal = grandTotal + Val(grid1.Item(7, q).Value)
        Next
        tAmount.Value = grandTotal
        tDiscamount.Value = (tDisccent.Value * grandTotal) / 100
        tPPNamount.Value = ((grandTotal - tDiscamount.Value) * tPPNcent.Value / 100)
        grandTotal = grandTotal - tDiscamount.Value
        grandTotal = grandTotal + tPPNamount.Value
        grandTotal = grandTotal + tOtherfee.Value
        tSubtotal.Text = FormatNumber(grandTotal, 0)
        tCredit.Value = grandTotal - tCash.Value
        tTotal.Text = FormatNumber(grandTotal, 0)

    End Sub

    Private Sub btnremove_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnremove.Click
        On Error Resume Next
        If grid1.RowCount > 1 Then
            btnremove.Enabled = True
            grid1.Rows.RemoveAt(grid1.CurrentRow.Index)
        End If
        load_grid_total()
    End Sub

    Public Sub load_ppn(ByVal str As String)
        Dim dNet As New adnetObj.clsAdnet
        If dNet.loadComboData(16, str) <> "" Then
            tPPNcent.Value = 10
            tPPNamount.Value = (tAmount.Value - tDiscamount.Value) * 0.1
        Else
            tPPNcent.Value = 0
            tPPNamount.Value = 0
        End If
        load_grid_total()
    End Sub

    Private Sub tDisccent_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tDisccent.ValueChanged
        tDiscamount.Value = (tAmount.Value * tDisccent.Value) / 100
        load_grid_total()
    End Sub

    Private Sub cmbPayment_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPayment.SelectedIndexChanged
        On Error Resume Next
        load_ppn(cmbPayment.SelectedValue)
    End Sub

    Private Sub tDP_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tCash.ValueChanged
        load_grid_total()
    End Sub

    Private Sub tOtherfee_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tOtherfee.ValueChanged
        load_grid_total()
    End Sub

    Private Sub grid1_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid1.CellEnter
        load_grid_total()
    End Sub

    Private Sub grid1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grid1.KeyDown
        If cmdSave.Enabled = False Then Exit Sub
        If e.KeyCode = Keys.Enter And grid1.CurrentRow.Index = grid1.RowCount - 1 Then
            frmView2.Text = "Item Barang"
            frmView2.load_sales("20", "")
            frmView2.grid1.Columns(0).Width = 125
            frmView2.grid1.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            frmView2.txtSearch.Focus()
            frmView2.ShowDialog()

            If frmView2.selected = True Then
                Dim a As Integer
                For a = 0 To grid1.RowCount - 2
                    If grid1.Item(1, a).Value = frmView2.selectedData(0) Then
                        grid1.Item(3, a).Value = Val(grid1.Item(3, a).Value) + 1
                        grid1.Item(7, a).Value = Val(grid1.Item(3, a).Value) * grid1.Item(5, a).Value
                        load_grid_total()
                        Exit Sub
                    End If
                Next

                grid1.Rows.Add("", frmView2.selectedData(0), frmView2.selectedData(1), "1", frmView2.selectedData(2), Replace(Replace(frmView2.selectedData(3), ",", ""), ".", ""), Val(frmView2.selectedData(4)), Replace(Replace(frmView2.selectedData(3), ",", ""), ".", ""))
                load_grid_total()
            End If
        End If
    End Sub


    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If grid1.RowCount > 1 Then
            Saved()
            load_enabled(False)
        Else
            MsgBox("There is no items to sell", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End If

    End Sub

    Sub load_enabled(ByVal mode As Boolean)
        cmdSave.Enabled = mode
        cmdEdit.Enabled = Not mode
        cmdAdd.Enabled = Not mode
        cmdPreview.Enabled = Not mode
        cmdPrint.Enabled = Not mode
        grid1.ReadOnly = Not mode
        tAmount.Enabled = mode
        tDisccent.Enabled = mode
        tPPNcent.Enabled = mode
        tOtherfee.Enabled = mode
        tCash.Enabled = mode
        txtNote.Enabled = mode
        dtTrans.Enabled = mode
        cmbCustomer.Enabled = mode
        cmbPayment.Enabled = mode
        ' cmbSales.Enabled = mode
        cmbWarehouse.Enabled = mode

        cmdCustomer.Enabled = mode
        cmdPayment.Enabled = mode
        'cmdSales.Enabled = mode
        cmdWarehouse.Enabled = mode
    End Sub

    Sub Saved()

        Dim str As String
        Dim adnet As New adnetObj.clsAdnet
        str = txtTransno.Text & "|"

        str = str & adnet.FormatDate(dtTrans) & "|"
        str = str & cmbCustomer.SelectedValue & "|"
        str = str & cmbCustomer.Text & "|"
        str = str & cmbRefno.Text & "|"
        str = str & cmbPayment.SelectedValue & "|"

        str = str & "" & "|"
        str = str & cmbWarehouse.SelectedValue & "|"
        str = str & tAmount.Value & "|"
        str = str & tDisccent.Value & "|"
        str = str & tDiscamount.Value & "|"

        str = str & tPPNcent.Value & "|"
        str = str & tPPNamount.Value & "|"
        str = str & tOtherfee.Value & "|"
        str = str & tSubtotal.Value & "|"
        str = str & tCash.Value & "|"

        str = str & tCredit.Value & "|"
        str = str & txtNote.Text & "|"
        str = str & userName & "|"
        str = str & itemDetail()



        If Microsoft.VisualBasic.Left(Me.Text, 3) = "Add" Then
            adnet.ExecDataAll("PRinsert", str)
        Else
            adnet.ExecDataAll("PRupdate", str)
        End If

    End Sub

    Function itemDetail() As String
        Dim j, n, n2 As Integer
        Dim str As String

        j = grid1.RowCount
        str = ""

        For n = 0 To j - 2
            str = str & txtTransno.Text & "[]"
            For n2 = 1 To 8
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
                    str = str & grid1.Item(4, n).Value
                End If

                If n2 = 6 Then
                    str = str & Replace(Replace(grid1.Item(5, n).Value, ",", ""), ".", "")
                End If

                If n2 = 7 Then
                    str = str & grid1.Item(6, n).Value
                End If

                If n2 = 8 Then
                    str = str & Replace(Replace(grid1.Item(7, n).Value, ",", ""), ".", "")
                End If
                'If n2 = 9 Then
                '    str = str & Replace(Replace(grid1.Item(8, n).Value, ",", ""), ".", "")
                'End If
                str = str & "[]"
            Next
            str = Strings.Left(str, Len(str) - 2)
            str = str & "{}"
        Next
        str = Strings.Left(str, Len(str) - 2)
        str = Replace(str, ".", "") 'replace numeric amount with dot 
        itemDetail = str
    End Function

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Me.Text = "Edit - " & "Purchase Return"
        load_enabled(True)
    End Sub
End Class