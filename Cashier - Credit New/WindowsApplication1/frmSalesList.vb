Imports System.Net
Imports Newtonsoft.Json
Public Class frmSalesList
    Dim editForm As Boolean
    Dim RowActive As Integer
    Dim gridTitle As String
    Dim gridVisible As String
    Dim gridLength As String
    Dim gridCount As Integer
    Dim Page As Integer
    Public Sub grid(ByVal str2 As String)
        On Error Resume Next
        Dim wc As New WebClient()
        Dim query1 As String
        Dim param As String
        If txtSearch.Text = "" Then
            param = "all.php?q=100&q2=" & str2
        Else
            param = "all.php?q=102&q2=" & str2
        End If
        Dim json = wc.DownloadString(url & param)
        Dim users As List(Of clsReport) = JsonConvert.DeserializeObject(Of List(Of clsReport))(json)
        query1 = users.Item(0).f1
        query1 = Replace(query1, """", "'")
        gridLength = users.Item(0).f4
        gridTitle = users.Item(0).f2
        gridVisible = users.Item(0).f3
        gridCount = users.Item(0).f5

        query1 = Replace(query1, "'", "!")
        query1 = Replace(query1, "%w2%", "$" & txtSearch.Text & "$")

        Dim json2 = wc.DownloadString(url & "all.php?q=101&q2=" & query1 & "&p=" & Page & "&w2=" & txtSearch.Text)

        Dim users2 As List(Of clsReport) = JsonConvert.DeserializeObject(Of List(Of clsReport))(json2)
        grid1.DataSource = users2
        format_Grid()
    End Sub
    Sub format_Grid()
        Dim strArr() As String
        Dim i As Integer
        strArr = gridTitle.Split("|")
        For i = 0 To gridCount - 1
            grid1.Columns(i).HeaderText = strArr(i)
        Next i
        strArr = gridLength.Split("|")
        For i = 0 To gridCount - 1
            grid1.Columns(i).Width = strArr(i)
        Next i
        strArr = gridVisible.Split("|")
        For i = 0 To gridCount - 1
            grid1.Columns(i).Visible = strArr(i)
        Next i

        Dim j As Integer
        For j = gridCount To 43
            grid1.Columns(j).Visible = False
        Next
    End Sub
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        editStatus = True
        frmSales.load_enabled(True)
        frmSales.load_Customer()
        frmSales.load_Payment()
        frmSales.load_Ship()
        frmSales.load_Warehouse()
        frmSales.load_Salesman()
        frmSales.load_sqno()

        frmSales.t2.Enabled = False
        frmSales.t1.Text = ""
        frmSales.t3.Text = Now()
        'frmSales.t4.Text = ""
        'frmSales.t5.Text = ""
        'frmSales.t6.Text = ""
        frmSales.t7.Text = ""
        frmSales.t8.Text = ""
        frmSales.t9.Text = ""
        frmSales.t10.Text = ""
        frmSales.t11.Text = ""
        frmSales.t12.Text = ""
        frmSales.t17.Text = 0
        frmSales.t18.Text = 0
        'frmSales.t19.Text = ""
        frmSales.t20.Text = ""
        frmSales.t21.Text = ""
        frmSales.t22.Text = ""
        frmSales.t23.Text = ""
        frmSales.t24.Text = ""
        frmSales.grid1.Rows.Clear()
        frmSales.t98.Text = "0"
        frmSales.t97.Text = "0"
        frmSales.t96.Text = "0"
        frmSales.t95.Text = "0"

        frmSales.ShowDialog()
        frmSales.Calculate_Total()
        frmSales.load_grid_total()
        frmSales.load_totaldisc()
        frmSales.Load_totalship()
        frmSales.load_grandtotal()
        grid("presales")
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        editStatus = False
        On Error Resume Next
        frmSales.load_enabled(False)
        'frmSales.btnremove.Enabled = False
        frmSales.load_Customer()
        frmSales.load_Payment()
        frmSales.load_ppn(frmSales.t6.SelectedValue)
        frmSales.load_Ship()
        frmSales.load_Warehouse()
        frmSales.load_Salesman()
        frmSales.load_sqno()

        frmSales.t2.Enabled = False



        frmSales.t1.Text = ""
        frmSales.t3.Text = Now()
        'frmSales.t4.Text = ""
        'frmSales.t5.Text = ""
        'frmSales.t6.Text = ""
        frmSales.t7.Text = ""
        frmSales.t8.Text = ""
        frmSales.t9.Text = ""
        frmSales.t10.Text = ""
        frmSales.t11.Text = ""
        frmSales.t12.Text = ""
        frmSales.t17.Text = 0
        frmSales.t18.Text = 0
        'frmSales.t19.Text = ""
        frmSales.t20.Text = ""
        frmSales.t21.Text = ""
        frmSales.t22.Text = ""
        frmSales.t23.Text = ""
        frmSales.t24.Text = ""
        frmSales.t98.Text = "0"
        frmSales.t97.Text = "0"
        frmSales.t96.Text = "0"
        frmSales.t95.Text = "0"
        frmSales.t94.Text = "0"

        frmSales.t0.Text = grid1.Item(0, grid1.CurrentRow.Index).Value
        frmSales.t2.Text = grid1.Item(0, grid1.CurrentRow.Index).Value
        frmSales.t3.Text = grid1.Item(1, grid1.CurrentRow.Index).Value
        frmSales.t4.Text = grid1.Item(4, grid1.CurrentRow.Index).Value
        frmSales.t5.Text = grid1.Item(7, grid1.CurrentRow.Index).Value
        frmSales.t6.Text = grid1.Item(5, grid1.CurrentRow.Index).Value
        frmSales.t7.Text = grid1.Item(21, grid1.CurrentRow.Index).Value
        frmSales.t8.Text = grid1.Item(22, grid1.CurrentRow.Index).Value
        frmSales.t9.Text = grid1.Item(23, grid1.CurrentRow.Index).Value
        frmSales.t10.Text = grid1.Item(24, grid1.CurrentRow.Index).Value
        frmSales.t11.Text = grid1.Item(25, grid1.CurrentRow.Index).Value
        frmSales.t12.Text = grid1.Item(26, grid1.CurrentRow.Index).Value
        frmSales.t17.Text = grid1.Item(9, grid1.CurrentRow.Index).Value
        frmSales.t18.Text = grid1.Item(10, grid1.CurrentRow.Index).Value
        frmSales.t19.Text = grid1.Item(14, grid1.CurrentRow.Index).Value
        frmSales.t20.Text = grid1.Item(15, grid1.CurrentRow.Index).Value
        frmSales.t21.Text = grid1.Item(19, grid1.CurrentRow.Index).Value
        frmSales.t22.Text = grid1.Item(17, grid1.CurrentRow.Index).Value
        frmSales.t23.Text = grid1.Item(18, grid1.CurrentRow.Index).Value
        frmSales.t24.Text = grid1.Item(16, grid1.CurrentRow.Index).Value
        frmSales.t25.Text = grid1.Item(20, grid1.CurrentRow.Index).Value
        frmSales.t26.Text = grid1.Item(12, grid1.CurrentRow.Index).Value
        frmSales.t94.Text = FormatNumber(grid1.Item(11, grid1.CurrentRow.Index).Value, 0)


        load_griddetail(32)
        ' frmSales.load_grid_total()
        'rowactive
        RowActive = grid1.CurrentRow.Index
        frmSales.Calculate_Total()
        frmSales.load_grandtotal()
        frmSales.ShowDialog()
        frmSales.TB2.SelectedTabIndex = 0
        grid("presales")
        grid1.CurrentCell = grid1.Rows(RowActive).Cells(1)
    End Sub

    Private Sub cmdRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemove.Click
        Dim wc As New WebClient()
        If MsgBox("Are you confirmed to delete this record?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            Dim json = wc.DownloadString(url & "all.php?q=203&q2=" & grid1.Item(0, grid1.CurrentRow.Index).Value)
            grid("presales")
        End If
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        grid("presales")
    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            Page = 0
            lblPage.Text = "Page (" & Page + 1 & ")"
            grid("presales")
            Page = 0
        End If
    End Sub
    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        Page = Page + 1
        lblPage.Text = "Page (" & Page + 1 & ")"
        grid("presales")
        If grid1.RowCount = 0 Then
            Page = Page - 1
            lblPage.Text = "Page (" & Page + 1 & ")"
            grid("presales")

        End If
    End Sub


    Private Sub frmSalesList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        grid("presales")
        Dim strArr() As String
        Dim i As Integer
        strArr = gridTitle.Split("|")
        For i = 0 To gridCount - 1
            grid1.Columns(i).HeaderText = strArr(i)
        Next i
        strArr = gridLength.Split("|")
        For i = 0 To gridCount - 1
            grid1.Columns(i).Width = strArr(i)
        Next i
        strArr = gridVisible.Split("|")
        For i = 0 To gridCount - 1
            grid1.Columns(i).Visible = strArr(i)
        Next i

        Dim j As Integer
        For j = gridCount To 28
            grid1.Columns(j).Visible = False
        Next
    End Sub
    Sub load_griddetail(ByVal columnNo As Integer)
        Dim str, str2 As String
        Dim strArr(), strArr2() As String
        Dim count As Integer
        frmSales.grid1.Rows.Clear()
        str = grid1.Item(columnNo, grid1.CurrentRow.Index).Value()
        strArr = str.Split("{")
        For count = 0 To strArr.Length - 1
            str2 = strArr(count)
            strArr2 = str2.Split("[")
            frmSales.grid1.Rows.Add(New String() {"", strArr2(2), strArr2(3), strArr2(4), strArr2(5)})
        Next
    End Sub
   

    Private Sub grid1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid1.CellContentClick

    End Sub
End Class