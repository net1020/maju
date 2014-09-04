
Public Class frmCashOut
    Dim editStatus As Boolean
    Dim grandTotal As Long

    Sub load_Setting()
        Dim adnet As adnetObj.clsAdnet = New adnetObj.clsAdnet()
        adnet.loadCounter(txtTransno, 64)
        adnet.loadCombo(cmbAccount, 19, "")
        adnet.load_printer(cmbReport)
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
        load_griddata(strArr(7))
        txtTransno.Text = strArr(0)
        dtTrans.Value = strArr(1)
        cmdAccount.Text = strArr(2)
        'tAmount.Value = strArr(8)
        txtNote.Text = strArr(6)
        'tLeftamount.Value = strArr(34)
        load_grid_total()

    End Sub
    Sub Clear_data()
        Dim frm As New adnetObj.clsAdnet
        dtTrans.Value = Today
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
            grid1.Rows.Add("", arr2(1), arr2(2), arr2(3))
        Next

    End Sub

    Private Sub grid1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid1.CellDoubleClick
        If cmdSave.Enabled = False Then Exit Sub
        frmViewAccount.Text = "Item Barang"
        frmViewAccount.load_sales("65", "")
        frmViewAccount.grid1.Columns(0).Width = 125
        frmViewAccount.grid1.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        frmViewAccount.txtSearch.Focus()
        frmViewAccount.ShowDialog()

        If frmViewAccount.selected = True Then
            grid1.Rows.Add("", frmViewAccount.selectedData(0), frmViewAccount.selectedData(1), "0")
            load_grid_total()
        End If
        On Error Resume Next
        grid1.CurrentCell = grid1.Rows(grid1.RowCount - 2).Cells(3)
    End Sub

    Public Sub load_grid_total()
        Dim q As Integer
        grandTotal = 0
        For q = 0 To grid1.RowCount - 2
            grandTotal = grandTotal + Val(grid1.Item(3, q).Value)
        Next
        tTotal.Text = FormatNumber(grandTotal, 0)

    End Sub

    Private Sub btnremove_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        On Error Resume Next
        If grid1.RowCount > 1 Then
            btnremove.Enabled = True
            grid1.Rows.RemoveAt(grid1.CurrentRow.Index)
        End If
        load_grid_total()
    End Sub

    Private Sub grid1_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid1.CellEnter
        load_grid_total()
    End Sub


    Private Sub grid1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grid1.KeyDown
        If cmdSave.Enabled = False Then Exit Sub
        If e.KeyCode = Keys.Enter And grid1.CurrentRow.Index = grid1.RowCount - 1 Then
            frmViewAccount.Text = "Item Barang"
            frmViewAccount.load_sales("65", "")
            frmViewAccount.grid1.Columns(0).Width = 125
            frmViewAccount.grid1.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            frmViewAccount.txtSearch.Focus()
            frmViewAccount.ShowDialog()

            If frmViewAccount.selected = True Then
                grid1.Rows.Add("", frmViewAccount.selectedData(0), frmViewAccount.selectedData(1), "0")
                load_grid_total()
            End If
            On Error Resume Next
            grid1.CurrentCell = grid1.Rows(grid1.RowCount - 2).Cells(3)
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
        cmdPreview.Enabled = Not mode
        cmdPrint.Enabled = Not mode
        grid1.ReadOnly = Not mode
        txtNote.Enabled = mode
        dtTrans.Enabled = mode
        cmbAccount.Enabled = mode
        '  cmbSales.Enabled = mode
        cmdAccount.Enabled = mode
        ' cmdSales.Enabled = mode
    End Sub

    Sub Saved()
        load_grid_total()
        Dim str As String
        Dim adnet As New adnetObj.clsAdnet
        str = txtTransno.Text & "|"
        str = str & adnet.FormatDate(dtTrans) & "|"
        str = str & cmbAccount.SelectedValue & "|"
        str = str & grandTotal & "|"
        str = str & txtNote.Text & "|"
        str = str & userName & "|"
        str = str & itemDetail() & "|"

        If Microsoft.VisualBasic.Left(Me.Text, 3) = "Add" Then
            adnet.ExecDataAll("COTinsert", str)
        Else
            adnet.ExecDataAll("COTupdate", str)
        End If

    End Sub

    Function itemDetail() As String
        Dim j, n, n2 As Integer
        Dim str As String

        j = grid1.RowCount
        str = ""

        For n = 0 To j - 2
            str = str & txtTransno.Text & "[]"
            For n2 = 1 To 4
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



                str = str & "[]"
            Next
            str = Strings.Left(str, Len(str) - 2)
            str = str & "{}"
        Next
        str = Strings.Left(str, Len(str) - 2)
        'str = Replace(str, ".", "") 'replace numeric amount with dot 
        itemDetail = str
    End Function

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Me.Text = "Edit - " & "Cash Out"
        load_enabled(True)
    End Sub


    Private Sub btnremove_Click2(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnremove.Click
        On Error Resume Next
        If grid1.RowCount > 1 Then
            btnremove.Enabled = True
            grid1.Rows.RemoveAt(grid1.CurrentRow.Index)
        End If
        load_grid_total()
    End Sub
End Class