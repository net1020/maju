Public Class frmConsignePayment
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
        adnet.loadCounter(txtTransno, 46)
        adnet.loadCombo(cmbAccount, 19, "")
        adnet.loadCombo(cmbPaytype, 33, "")
        adnet.load_printer(cmbPrinter)
        dtTrans.Value = Now
        dtPayment.Value = Now

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



    End Sub

    Sub load_data()
        Dim frm As New adnetObj.clsAdnet
        Dim strArr() As String
        strArr = Split(Me.Tag, "|")
        load_griddata(strArr(15))
        txtTransno.Text = strArr(0)
        dtTrans.Value = strArr(1)
        cmbCustomer.Text = strArr(4)
        cmbAccount.Text = strArr(5)
        cmbPaytype.Text = strArr(6)
        dtPayment.Value = strArr(7)
        txtCheque.Text = strArr(8)
        txtNote.Text = strArr(10)
        load_grid_total()

    End Sub
    Sub Clear_data()
        Dim frm As New adnetObj.clsAdnet
        dtTrans.Value = Today
        dtPayment.Value = Today
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
            grid1.Rows.Add("", arr2(2), arr2(3), arr2(4), arr2(5), arr2(6), arr2(7), arr2(8), arr2(9))
        Next

    End Sub





    Private Sub btnremove_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        On Error Resume Next
        If grid1.RowCount > 1 Then
            btnremove.Enabled = True
            grid1.Rows.RemoveAt(grid1.CurrentRow.Index)
        End If
        load_grid_total()
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

        txtNote.Enabled = mode
        dtTrans.Enabled = mode
        dtPayment.Enabled = mode
        cmbCustomer.Enabled = mode
        cmbAccount.Enabled = mode
        cmbPaytype.Enabled = mode
        txtCheque.Enabled = mode
        If cmbPaytype.Text = "" Then cmbPaytype.Text = "Cash"
        If cmbPaytype.Text = "Cash" Then
            dtPayment.Enabled = False
            txtCheque.Enabled = False
        Else
            dtPayment.Enabled = True
            txtCheque.Enabled = True
        End If
    End Sub

    Sub Saved()

        Dim str As String
        Dim adnet As New adnetObj.clsAdnet
        str = txtTransno.Text & "|"

        str = str & adnet.FormatDate(dtTrans) & "|"
        str = str & cmbCustomer.SelectedValue & "|"
        str = str & cmbCustomer.Text & "|"
        str = str & cmbAccount.SelectedValue & "|"
        str = str & cmbPaytype.Text & "|"

        str = str & adnet.FormatDate(dtPayment) & "|"
        str = str & txtCheque.Text & "|"
        str = str & grandTotal & "|"
        str = str & txtNote.Text & "|"
        str = str & userName & "|" & itemDetail()

        If Microsoft.VisualBasic.Left(Me.Text, 3) = "Add" Then
            adnet.ExecDataAll("CPinsert", str)
        Else
            adnet.ExecDataAll("CPupdate", str)
        End If

    End Sub

    Function itemDetail() As String
        Dim adnet2 As New adnetObj.clsAdnet
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
                    str = str & adnet2.FormatDateString(grid1.Item(2, n).Value)
                End If

                If n2 = 4 Then
                    str = str & grid1.Item(3, n).Value
                End If

                If n2 = 5 Then
                    str = str & Replace(Replace(grid1.Item(4, n).Value, ",", ""), ".", "")
                End If

                If n2 = 6 Then
                    str = str & Replace(Replace(grid1.Item(5, n).Value, ",", ""), ".", "")
                End If

                If n2 = 7 Then
                    str = str & Replace(Replace(grid1.Item(6, n).Value, ",", ""), ".", "")
                End If

                If n2 = 8 Then
                    str = str & Replace(Replace(grid1.Item(7, n).Value, ",", ""), ".", "")
                End If
                If n2 = 9 Then
                    str = str & Replace(Replace(grid1.Item(8, n).Value, ",", ""), ".", "")
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



    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Me.Text = "Edit - " & "Consignment Payment"
        load_enabled(True)
    End Sub

    Private Sub cmbPaytype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPaytype.SelectedIndexChanged
        If cmbPaytype.Text = "Cash" Then
            dtPayment.Enabled = False
            txtCheque.Enabled = False
        Else
            dtPayment.Enabled = True
            txtCheque.Enabled = True
        End If
    End Sub
    Public Sub load_grid_total()
        Dim q As Integer

        grandTotal = 0
        For q = 0 To grid1.RowCount - 2
            If Val(grid1.Item(7, q).Value) > Val(grid1.Item(6, q).Value) Then grid1.Item(7, q).Value = grid1.Item(6, q).Value
            grid1.Item(8, q).Value = Val(grid1.Item(6, q).Value) - Val(grid1.Item(7, q).Value)
            grandTotal = grandTotal + Val(grid1.Item(7, q).Value)
        Next
        tTotal.Text = FormatNumber(grandTotal, 0)

    End Sub

    Private Sub cmdAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAccount.Click
        Dim adnet As adnetObj.frmSelect = New adnetObj.frmSelect()
        adnet.UrlClient = url
        adnet.newForm = False
        adnet.grid("Bank")
        adnet.Text = "Bank"
        adnet.ShowDialog()
        Dim adnet2 As adnetObj.clsAdnet = New adnetObj.clsAdnet()
        adnet2.loadCombo(cmbAccount, 19, "")
        On Error Resume Next
        cmbAccount.Text = adnet.SelectedData(1)
    End Sub

    Private Sub cmbCustomer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCustomer.SelectedIndexChanged
        Dim dNet As New adnetObj.clsAdnet
        On Error Resume Next
        If Microsoft.VisualBasic.Left(Me.Text, 3) = "Add" Then
            dNet.loadGrid_Detail(grid1, 47, cmbCustomer.SelectedValue)
        End If
        load_grid_total()
    End Sub

    Private Sub grid1_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid1.CellEnter
        load_grid_total()
    End Sub
End Class