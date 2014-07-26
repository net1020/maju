Imports System.Net
Imports Newtonsoft.Json

Public Class frmPettyCashIns
    Dim editForm As Boolean
    Dim RowActive As Integer

    Private Sub frmAddMaterials_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        grid("")
        gridRaw1.Columns(0).HeaderText = "Petty No"
        gridRaw1.Columns(1).HeaderText = "Petty Date"
        gridRaw1.Columns(2).HeaderText = "Bank Account"
        gridRaw1.Columns(3).HeaderText = "Client Name"
        gridRaw1.Columns(4).HeaderText = "Total Amount"
        gridRaw1.Columns(5).HeaderText = "Notes"
        gridRaw1.Columns(6).HeaderText = "Status"
        gridRaw1.Columns(8).HeaderText = "Update By"
        gridRaw1.Columns(9).HeaderText = "Cash Advance No"

        gridRaw1.Columns(0).Width = "100"
        gridRaw1.Columns(1).Width = "100"
        gridRaw1.Columns(2).Width = "185"
        gridRaw1.Columns(3).Width = "145"
        gridRaw1.Columns(4).Width = "120"
        gridRaw1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        gridRaw1.Columns(5).Width = "150"
        gridRaw1.Columns(6).Width = "120"
        gridRaw1.Columns(7).Visible = False
        gridRaw1.Columns(8).Width = "100"
        gridRaw1.Columns(9).Width = "100"
        Dim j As Integer
        For j = 10 To 28
            gridRaw1.Columns(j).Visible = False
        Next
    End Sub

    Public Sub grid(ByVal str2 As String)
        On Error Resume Next
        Dim wc As New WebClient()
        Dim json = wc.DownloadString(url & "all.php?q=110&q2" & str2)
        Dim users As List(Of clsReport) = JsonConvert.DeserializeObject(Of List(Of clsReport))(json)
        gridRaw1.DataSource = users
    End Sub

    'Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
    '    Dim dt1, dt2 As String

    '    dt1 = gridRaw1.Item(6, gridRaw1.CurrentRow.Index).Value()
    '    dt2 = gridRaw1.Item(7, gridRaw1.CurrentRow.Index).Value()
    '    frm2SalesOrder.load_settings()
    '    frm2SalesOrder.Clear_grid()
    '    frm2SalesOrder.txtHeader.Text = dt1
    '    frm2SalesOrder.txtDetails.Text = dt2

    '    Load_Header(dt1)
    '    Load_Details(dt2)
    '    frm2SalesOrder.Calculate_All()
    '    editForm = True
    '    frm2SalesOrder.cmdEnabled(False)
    '    frm2SalesOrder.ShowDialog()
    '    grid(txtSearch.Text)
    '    gridRaw1.CurrentCell = gridRaw1.Rows(RowActive).Cells(0)
    '    editForm = False
    'End Sub

    'Sub Load_Header(ByVal dt1 As String)
    '    Dim str As String
    '    Dim strArr() As String
    '    str = dt1
    '    'On Error Resume Next

    '    strArr = str.Split("|")
    '    Dim dt5 As DateTime
    '    Dim cs5 As String
    '    dt5 = strArr(1)
    '    cs5 = dt5.ToString("yyyy-MM-dd")
    '    On Error Resume Next
    '    frm2SalesOrder.txtOrderno.Text = strArr(0)
    '    frm2SalesOrder.txtOrderdate.Text = cs5
    '    frm2SalesOrder.cmbCust.Text = strArr(4)
    '    frm2SalesOrder.cmbPayterms.Text = strArr(5)
    '    frm2SalesOrder.txtPono.Text = strArr(6)
    '    frm2SalesOrder.cmbSales.Text = strArr(7)
    '    frm2SalesOrder.lblTotal.Text = strArr(8)
    '    frm2SalesOrder.txtDiscent.Text = strArr(9)
    '    frm2SalesOrder.txtDisamount.Text = strArr(10)

    '    frm2SalesOrder.lblPPN.Text = strArr(11)
    '    frm2SalesOrder.txtShippingCost.Text = strArr(12)
    '    frm2SalesOrder.lblGrandTotal.Text = strArr(13)
    '    frm2SalesOrder.cmbShipping.Text = strArr(14)
    '    frm2SalesOrder.cmbDeliveryTo.Text = strArr(15)
    '    frm2SalesOrder.txtDeliveryAddress.Text = strArr(16)
    '    frm2SalesOrder.txtContactPerson.Text = strArr(17)
    '    frm2SalesOrder.txtDeliveryphone.Text = strArr(18)
    '    frm2SalesOrder.txtDeliveryDate.Text = strArr(19)

    '    frm2SalesOrder.cmbDeliveryWarehouse.Text = strArr(20)
    '    frm2SalesOrder.txtF1.Text = strArr(21)
    '    frm2SalesOrder.txtF2.Text = strArr(22)
    '    frm2SalesOrder.txtF3.Text = strArr(23)
    '    frm2SalesOrder.cmbF4.Text = strArr(24)
    '    frm2SalesOrder.cmbF5.Text = strArr(25)
    '    frm2SalesOrder.cmbF6.Text = strArr(26)
    '    frm2SalesOrder.txtTax1.Text = strArr(27)
    '    frm2SalesOrder.txtTax2.Text = strArr(28)

    '    Dim dt2 As DateTime
    '    Dim cs1 As String
    '    dt2 = strArr(29)
    '    cs1 = dt2.ToString("yyyy-MM-dd")
    '    On Error Resume Next

    '    frm2SalesOrder.txtTaxDate.Text = cs1

    '    frm2SalesOrder.txtTaxMemo.Text = strArr(30)
    '    frm2SalesOrder.txtNotes.Text = strArr(31)
    '    frm2SalesOrder.txtRefno.Text = strArr(32)

    'End Sub

    'Sub Load_Details(ByVal dt2 As String)
    '    Dim str, str2 As String
    '    Dim strArr(), strArr2() As String
    '    Dim count As Integer
    '    str = dt2
    '    On Error Resume Next

    '    strArr = str.Split(";")
    '    For count = 0 To strArr.Length - 1
    '        str2 = strArr(count)
    '        strArr2 = str2.Split("|")
    '        frm2SalesOrder.grid1.Rows.Add("", strArr2(1), strArr2(2), strArr2(3), strArr2(4), strArr2(5), strArr2(6), strArr2(8), strArr2(9), strArr2(10), strArr2(1))


    '    Next
    'End Sub

    'Private Sub gridRaw1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridRaw1.CellClick
    '    RowActive = gridRaw1.CurrentRow.Index
    'End Sub

    'Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
    '    frm2SalesOrder.cmdEnabled(True)
    '    frm2SalesOrder.load_settings()
    '    frm2SalesOrder.Clear_All()
    '    frm2SalesOrder.ShowDialog()
    '    grid(txtSearch.Text)
    '    gridRaw1.CurrentCell = gridRaw1.Rows(RowActive).Cells(0)
    '    editForm = False
    'End Sub

    'Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        grid(txtSearch.Text)
    '    End If
    'End Sub

    'Private Sub txtSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged

    'End Sub

    'Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
    '    grid(txtSearch.Text)
    'End Sub

    'Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
    '    grid(txtSearch.Text)
    'End Sub

    'Private Sub cmdRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemove.Click
    '    If MsgBox("are you confirmed to delete this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    '        frm2SalesOrder.Sync("delete", gridRaw1.Item(0, gridRaw1.CurrentRow.Index).Value())
    '        grid(txtSearch.Text)
    '    End If
    'End Sub

    'Private Sub gridRaw1_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridRaw1.CellEnter
    '    'RowActive = gridRaw1.CurrentRow.Index
    'End Sub

    'Private Sub gridRaw1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridRaw1.MouseHover
    '    If editForm = True Then
    '        grid(txtSearch.Text)
    '        gridRaw1.CurrentCell = gridRaw1.Rows(RowActive).Cells(0)
    '        editForm = False
    '    End If
    'End Sub

    'Private Sub txtSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.Click

    'End Sub

    'Private Sub gridRaw1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridRaw1.CellContentClick

    'End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        frmPettyCashIn.cmdEnabled(True)
        frmPettyCashIn.load_settings()
        frmPettyCashIn.Clear_All()
        frmPettyCashIn.load_PettyNo()
        frmPettyCashIn.cmbFrom.Focus()
        frmPettyCashIn.load_CashAdvance()
        frmPettyCashIn.ShowDialog()
        grid(txtSearch.Text)
        gridRaw1.CurrentCell = gridRaw1.Rows(RowActive).Cells(0)
        editForm = False
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Dim dt1 As String
        frmPettyCashIn.cmdEnabled(False)
        dt1 = gridRaw1.Item(7, gridRaw1.CurrentRow.Index).Value()

        frmPettyCashIn.load_settings()
        frmPettyCashIn.Clear_All()
        frmPettyCashIn.txtno.Text = gridRaw1.Item(0, gridRaw1.CurrentRow.Index).Value()
        'frmPettyCashIn.txtDetails.Text = dt1
        Load_Header()
        Load_Details(dt1)
        editForm = True
        frmPettyCashIn.ShowDialog()
        grid(txtSearch.Text)
        gridRaw1.CurrentCell = gridRaw1.Rows(RowActive).Cells(0)
        editForm = False
    End Sub

    Private Sub gridRaw1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridRaw1.CellClick
        RowActive = gridRaw1.CurrentRow.Index
        If gridRaw1.Item(6, RowActive).Value = "Void" Then
            cmdRemove.Enabled = False
        Else
            cmdRemove.Enabled = True
        End If

    End Sub

    Private Sub gridRaw1_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridRaw1.CellEnter
        'RowActive = gridRaw1.CurrentRow.Index
        ' frmPettyCashIn.txtDetails = gridRaw1.Item(6, gridRaw1.CurrentRow.Index).Value
        On Error Resume Next

        If gridRaw1.Item(6, RowActive).Value = "Void" Then
            cmdRemove.Enabled = False
        Else
            cmdRemove.Enabled = True
        End If
        If gridRaw1.Item(9, RowActive).Value <> "" Then
            cmdRemove.Enabled = True
        Else
            cmdRemove.Enabled = False
        End If
    End Sub

    Sub Load_Header()

        'On Error Resume Next

        frmPettyCashIn.txtOrderno.Text = gridRaw1.Item(0, RowActive).Value
        frmPettyCashIn.cmbBank.Text = gridRaw1.Item(2, RowActive).Value
        frmPettyCashIn.cmbFrom.Text = gridRaw1.Item(3, RowActive).Value
        frmPettyCashIn.txtNotes.Text = gridRaw1.Item(5, RowActive).Value
        frmPettyCashIn.cmbStatus.Text = gridRaw1.Item(6, RowActive).Value

        If gridRaw1.Item(9, RowActive).Value = "" Then
            frmPettyCashIn.tabAdvance.Visible = False
            frmPettyCashIn.cmbCashAdvance.DropDownStyle = ComboBoxStyle.DropDownList
        Else
            frmPettyCashIn.tabAdvance.Visible = True
            frmPettyCashIn.cmbCashAdvance.DropDownStyle = ComboBoxStyle.DropDown
        End If
        frmPettyCashIn.cmbCashAdvance.DataSource = Nothing
        frmPettyCashIn.cmbCashAdvance.Items.Add(gridRaw1.Item(3, RowActive).Value & " - " & gridRaw1.Item(9, RowActive).Value)
        frmPettyCashIn.cmbCashAdvance.Text = gridRaw1.Item(3, RowActive).Value & " - " & gridRaw1.Item(9, RowActive).Value


    End Sub

    Sub Load_Details(ByVal dt2 As String)
        Dim str, str2 As String
        Dim strArr(), strArr2() As String
        Dim count As Integer
        str = dt2
        On Error Resume Next

        strArr = str.Split(";")
        For count = 0 To strArr.Length - 1
            str2 = strArr(count)
            strArr2 = str2.Split("|")
            frmPettyCashIn.grid1.Rows.Add("", strArr2(1), strArr2(2), strArr2(3), strArr2(4))


        Next
    End Sub

    Private Sub cmdRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemove.Click
        Dim dt1 As String
        frmPettyCashIn.cmdEnabled(False)
        dt1 = gridRaw1.Item(7, gridRaw1.CurrentRow.Index).Value()
        frmPettyCashIn.load_settings()
        frmPettyCashIn.Clear_All()
        frmPettyCashIn.txtno.Text = gridRaw1.Item(0, gridRaw1.CurrentRow.Index).Value()
        'frmPettyCashIn.txtDetails.Text = dt1
        Load_Header()
        Load_Details(dt1)
        editForm = True
        frmPettyCashIn.cmdSave.Enabled = True
        frmPettyCashIn.cmbStatus.Enabled = True
        frmPettyCashIn.cmbStatus.Text = "Void"
        frmPettyCashIn.txtNotes.Enabled = True
        frmPettyCashIn.ShowDialog()

        grid(txtSearch.Text)
        On Error Resume Next

        gridRaw1.CurrentCell = gridRaw1.Rows(RowActive).Cells(0)

        editForm = False
    End Sub

    Private Sub gridRaw1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridRaw1.CellContentClick

    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        grid(txtSearch.Text)
    End Sub
End Class