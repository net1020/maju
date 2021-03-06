Public Class frmDeliveryRequest
    Dim editStatus As Boolean
    Dim grandTotal As Long

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCustomer.Click
        Dim adnet As adnetObj.frmSelect = New adnetObj.frmSelect()
        adnet.UrlClient = url
        adnet.newForm = False
        adnet.grid("Customer")
        adnet.Text = "Customer"
        adnet.ShowDialog()
        Dim adnet2 As adnetObj.clsAdnet = New adnetObj.clsAdnet()
        adnet2.loadCombo(cmbCustomer, 37, "")
        On Error Resume Next
        cmbCustomer.Text = adnet.SelectedData(2)
        If cmbType.Text = "Credit" Then adnet2.loadCombo(cmbTransno, 51, cmbCustomer.Text)
        If cmbType.Text = "Cash" Then adnet2.loadCombo(cmbTransno, 52, cmbCustomer.Text)
    End Sub

    Sub load_Setting()
        Dim adnet As adnetObj.clsAdnet = New adnetObj.clsAdnet()
        adnet.loadCombo(cmbCustomer, 10, "")
        adnet.loadCounter(txtTransno, 103)
        adnet.loadCombo(cmbType, 50, "", "Credit")
        'adnet.loadCombo(cmbReport, 90, "")
        adnet.loadCombo(cmbTransno, 51, cmbCustomer.Text)
        'adnet.loadCombo(cmbTransno, 12, "", "Cash")
        adnet.loadCombo(cmbWarehouse, 14, "")
        adnet.loadCombo(cmbVia, 53, "")
        'adnet.load_printer(cmbPrinter)
        dtTrans.Value = Now
        'dtDelivery.Value = Now
        cmbStatus.Items.Clear()
        cmbStatus.Items.Add("Pending")
        cmbStatus.Items.Add("Finish")
    End Sub

    Private Sub DoubleInput5_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tSubtotal.ValueChanged

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
            If Me.Tag = "" Then Exit Sub
            editStatus = False
            Clear_data()
            load_data()
            'tab1.Tabs(0).Text = Microsoft.VisualBasic.Right(Me.Text, Len(Me.Text) - 7)
            load_enabled(False)
            If cmbStatus.Text = "Finish" Then cmdEdit.Enabled = False
        End If
        'load_enabled(True)

    End Sub

    Sub load_data()
        Dim frm As New adnetObj.clsAdnet
        Dim strArr() As String
        strArr = Split(Me.Tag, "|")
        load_griddata(strArr(32))
        txtTransno.Text = strArr(0)
        dtTrans.Value = strArr(1)
        cmbCustomer.Text = strArr(4)
        'cmbSales.Text = strArr(7)
        cmbTransno.Text = strArr(6)
        cmbWarehouse.Text = strArr(20)
        'txtPO.Text = strArr(6)
        cmbStatus.Text = strArr(19)
        'tAmount.Value = strArr(8)
        'tDisccent.Value = Val(strArr(9))
        'tDiscamount.Value = strArr(10)
        'tPPNcent.Value = Val(strArr(11))
        'tPPNamount.Value = 0.1 * (Val(strArr(8)) - Val(strArr(10)))
        'tOtherfee.Value = strArr(12)
        'tSubtotal.Value = Replace(Replace(strArr(13), ",", ""), ".", "")
        'tTotal.Text = strArr(13)
        txtNote.Text = strArr(31)
        ' tDP.Value = strArr(33)

        cmbVia.Text = strArr(14)
        txtContact.Text = strArr(17)
        txtAddress.Text = strArr(16)
        txtPhone.Text = strArr(18)

        'tLeftamount.Value = strArr(34)
        load_grid_total()

    End Sub

    Sub load_order()
        Dim frm As New adnetObj.clsAdnet
        Dim strArr() As String
        strArr = Split(Me.Tag, "|")
        load_griddata(strArr(32))
        'txtTransno.Text = strArr(0)
        'dtTrans.Value = strArr(1)
        'cmbCustomer.Text = strArr(4)
        'cmbSales.Text = strArr(7)
        'cmbTransno.Text = strArr(5)
        cmbWarehouse.Text = strArr(20)
        'txtPO.Text = strArr(6)
        cmbStatus.Text = strArr(19)
        'tAmount.Value = strArr(8)
        ' tDisccent.Value = Val(strArr(9))
        'tDiscamount.Value = strArr(10)
        ' tPPNcent.Value = Val(strArr(11))
        'tPPNamount.Value = 0.1 * (Val(strArr(8)) - Val(strArr(10)))
        'tOtherfee.Value = strArr(12)
        'tSubtotal.Value = Replace(Replace(strArr(13), ",", ""), ".", "")
        'tTotal.Text = strArr(13)
        txtNote.Text = strArr(31)
        ' tDP.Value = strArr(33)

        cmbVia.Text = strArr(14)
        txtContact.Text = strArr(17)
        txtAddress.Text = strArr(16)
        txtPhone.Text = strArr(18)


        'tLeftamount.Value = strArr(34)
        load_grid_total()

    End Sub

    Sub Clear_data()
        Dim frm As New adnetObj.clsAdnet
        dtTrans.Value = Today


        cmbStatus.Text = "Pending"
        tAmount.Value = 0
        tDisccent.Value = 0
        tDiscamount.Value = 0
        tPPNcent.Value = 0
        tPPNamount.Value = 0
        tSubtotal.Value = 0
        tDP.Value = 0
        tLeftamount.Value = 0
        txtNote.Text = ""
        tTotal.Text = 0
        txtAddress.Text = ""
        txtContact.Text = ""
        txtPhone.Text = ""
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
            'If Val(arr2(9)) > 0 Then
            grid1.Rows.Add("", arr2(1), arr2(2), arr2(3), arr2(4), arr2(5), arr2(6), arr2(8), arr2(9), arr2(3))
            'End If
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

    Private Sub ButtonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim adnet As adnetObj.frmSelect = New adnetObj.frmSelect()
        adnet.UrlClient = url
        adnet.newForm = False
        adnet.grid("payment")
        adnet.Text = "payment"
        adnet.ShowDialog()
        Dim adnet2 As adnetObj.clsAdnet = New adnetObj.clsAdnet()
        adnet2.loadCombo(cmbTransno, 12, "")
        cmbTransno.Text = adnet.SelectedData(1)
    End Sub

    Private Sub grid1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid1.CellContentClick

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
        tpreTotal.Value = tAmount.Value - tDiscamount.Value
        tPPNamount.Value = ((grandTotal - tDiscamount.Value) * tPPNcent.Value / 100)
        grandTotal = grandTotal - tDiscamount.Value
        grandTotal = grandTotal + tPPNamount.Value
        grandTotal = grandTotal + tOtherfee.Value
        tSubtotal.Text = FormatNumber(grandTotal, 0)
        tLeftamount.Value = grandTotal - tDP.Value
        tTotal.Text = FormatNumber(grandTotal, 0)

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

    Private Sub cmbTransno_DropDownChange(ByVal sender As Object, ByVal Expanded As Boolean) Handles cmbTransno.DropDownChange
        
    End Sub

    Private Sub cmbPayment_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbTransno.SelectedIndexChanged
        On Error Resume Next
        'load_ppn(cmbTransno.SelectedValue)
        If Me.Text = "Add - Delivery Request" Then
            Dim dNet As New adnetObj.clsAdnet
            Me.Tag = ""
            If cmbTransno.SelectedValue = "credit" Then Me.Tag = dNet.loadJsonFormat(123, cmbTransno.Text)
            If cmbTransno.SelectedValue = "cash" Then Me.Tag = dNet.loadJsonFormat(104, cmbTransno.Text)
            On Error Resume Next
            If Me.Tag = "" Then grid1.Rows.Clear()
            load_order()
        End If
    End Sub

    Private Sub tDP_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tDP.ValueChanged
        load_grid_total()
    End Sub

    Private Sub tOtherfee_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tOtherfee.ValueChanged
        load_grid_total()
    End Sub

    Private Sub grid1_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid1.CellEndEdit
        If Val(grid1.Item(3, e.RowIndex).Value) > Val(grid1.Item(9, e.RowIndex).Value) Then
            grid1.Item(3, e.RowIndex).Value = grid1.Item(9, e.RowIndex).Value
        End If
        If Val(grid1.Item(3, e.RowIndex).Value) < Val(grid1.Item(8, e.RowIndex).Value) Then
            grid1.Item(3, e.RowIndex).Value = grid1.Item(8, e.RowIndex).Value
        End If
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

    Private Sub grid1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles grid1.KeyPress

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
        'cmdAdd.Enabled = False
        cmdPreview.Enabled = False
        cmdPrint.Enabled = False
        grid1.ReadOnly = Not mode
        tAmount.Enabled = mode
        tDisccent.Enabled = mode
        'tPPNcent.Enabled = mode
        tOtherfee.Enabled = mode
        tDP.Enabled = mode
        txtNote.Enabled = mode
        dtTrans.Enabled = mode
        cmbStatus.Enabled = mode
        cmbCustomer.Enabled = mode
        cmbTransno.Enabled = mode
        cmbType.Enabled = mode
        'cmbSales.Enabled = mode
        cmbWarehouse.Enabled = mode
        'txtPO.Enabled = mode
        cmdCustomer.Enabled = mode
        'cmdPayment.Enabled = mode
        'cmdSales.Enabled = mode
        cmdWarehouse.Enabled = mode

        cmbVia.Enabled = mode
        cmdVia.Enabled = mode
        txtContact.Enabled = mode
        txtAddress.Enabled = mode
        txtPhone.Enabled = mode
    End Sub

    Sub Saved()

        Dim str As String
        Dim adnet As New adnetObj.clsAdnet
        str = txtTransno.Text & "|"

        str = str & adnet.FormatDate(dtTrans) & "|"
        str = str & cmbCustomer.SelectedValue & "|"
        str = str & cmbCustomer.Text & "|"
        str = str & "" & "|"
        str = str & cmbWarehouse.SelectedValue & "|"

        str = str & cmbTransno.Text & "|"
        str = str & "" & "|"
        str = str & tAmount.Value & "|"
        str = str & tDisccent.Value & "|"
        str = str & tDiscamount.Value & "|"

        str = str & tPPNcent.Value & "|"
        str = str & tOtherfee.Value & "|"
        str = str & tSubtotal.Value & "|"
        str = str & tDP.Value & "|"
        str = str & tLeftamount.Value & "|"

        str = str & txtNote.Text & "|"
        str = str & userName & "|"
        str = str & cmbStatus.Text & "|" & itemDetail() & "|" & tPPNamount.Value & "|"

        str = str & cmbVia.SelectedValue & "|"
        str = str & txtContact.Text & "|"
        str = str & txtAddress.Text & "|"
        str = str & txtPhone.Text & "|"
        str = str & cmbTransno.Text & "|"

        If Microsoft.VisualBasic.Left(Me.Text, 3) = "Add" Then
            adnet.ExecDataAll("DORinsert", str)
        Else
            adnet.ExecDataAll("DORupdate", str)
        End If

    End Sub

    Function itemDetail() As String
        Dim j, n, n2 As Integer
        Dim str As String

        j = grid1.RowCount
        str = ""

        For n = 0 To j - 2
            str = str & txtTransno.Text & "[]"
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
                str = str & "[]"
            Next
            str = Strings.Left(str, Len(str) - 2)
            str = str & "{}"
        Next
        str = Strings.Left(str, Len(str) - 2)
        'str = Replace(str, ".", "") 'replace numeric amount with dot 
        itemDetail = str
    End Function

    Private Sub tTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tTotal.Click

    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Me.Text = "Edit - " & "Delivery Request"
        load_enabled(True)
        dtTrans.Enabled = False
        cmdCustomer.Enabled = False
        cmbCustomer.Enabled = False
        cmbType.Enabled = False
        cmbTransno.Enabled = False
        cmdTransno.Enabled = False
    End Sub

    Private Sub tPPNcent_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tPPNcent.ValueChanged

    End Sub

    Private Sub LabelX25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelX25.Click

    End Sub

    Private Sub cmbType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbType.SelectedIndexChanged
        Dim adnet As adnetObj.clsAdnet = New adnetObj.clsAdnet()
        If cmbType.Text = "Credit" Then adnet.loadCombo(cmbTransno, 51, cmbCustomer.Text)
        If cmbType.Text = "Cash" Then adnet.loadCombo(cmbTransno, 52, cmbCustomer.Text)

    End Sub

    Private Sub cmdVia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVia.Click
        Dim adnet As adnetObj.frmSelect = New adnetObj.frmSelect()
        adnet.UrlClient = url
        adnet.newForm = False
        adnet.grid("courier")
        adnet.Text = "courier"
        adnet.ShowDialog()
        Dim adnet2 As adnetObj.clsAdnet = New adnetObj.clsAdnet()
        adnet2.loadCombo(cmbVia, 53, "")
        cmbWarehouse.Text = adnet.SelectedData(1)
    End Sub

    Private Sub cmdPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPreview.Click
        Dim dNet As New adnetObj.clsAdnet
        dNet.viewReportNew("template\" & cmbReport.SelectedValue & ".repx", dNet.loadJsonReport(cmbReport.SelectedValue, txtTransno.Text))
    End Sub

    Private Sub cmdTransno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTransno.Click
        Dim adnet As adnetObj.frmSelect = New adnetObj.frmSelect()
        adnet.UrlClient = url
        adnet.newForm = False
        If cmbType.Text = "Credit" Then
            adnet.grid("DOS")
        Else
            adnet.grid("DOC")
        End If
        adnet.Text = "Delivery Order"
        adnet.ShowDialog()
        Dim adnet2 As adnetObj.clsAdnet = New adnetObj.clsAdnet()
        If cmbType.Text = "Credit" Then
            adnet2.loadCombo(cmbTransno, 51, cmbCustomer.Text)
        Else
            adnet2.loadCombo(cmbTransno, 52, cmbCustomer.Text)
        End If

        On Error Resume Next
        cmbTransno.Text = adnet.SelectedData(0)
    End Sub

    Private Sub btnremove_Click1(ByVal sender As Object, ByVal e As System.EventArgs)
        On Error Resume Next
        If grid1.RowCount > 1 Then
            btnremove.Enabled = True
            grid1.Rows.RemoveAt(grid1.CurrentRow.Index)
        End If
        load_grid_total()
    End Sub

    Private Sub cmbCustomer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCustomer.SelectedIndexChanged
        Dim adnet As adnetObj.clsAdnet = New adnetObj.clsAdnet()
        If cmbType.Text = "Credit" Then adnet.loadCombo(cmbTransno, 51, cmbCustomer.Text)
        If cmbType.Text = "Cash" Then adnet.loadCombo(cmbTransno, 52, cmbCustomer.Text)
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
End Class