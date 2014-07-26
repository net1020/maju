Imports System.Net
Imports Newtonsoft.Json

Public Class frmGroupList
    Dim editForm As Boolean
    Dim RowActive As Integer
    Dim Page As Integer
    Dim gridTitle As String
    Dim gridVisible As String
    Dim gridLength As String
    Dim gridCount As Integer

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
        gridRaw1.DataSource = users2
        format_Grid()
    End Sub


    Private Sub frmAddMaterials_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        grid("Group")
    End Sub

    Sub format_Grid()
        Dim strArr() As String
        Dim i As Integer
        strArr = gridTitle.Split("|")
        For i = 0 To gridCount - 1
            gridRaw1.Columns(i).HeaderText = strArr(i)
        Next i
        strArr = gridLength.Split("|")
        For i = 0 To gridCount - 1
            gridRaw1.Columns(i).Width = strArr(i)
        Next i
        strArr = gridVisible.Split("|")
        For i = 0 To gridCount - 1
            gridRaw1.Columns(i).Visible = strArr(i)
        Next i

        Dim j As Integer
        For j = gridCount To 28
            gridRaw1.Columns(j).Visible = False
        Next
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        frmGroup.t0.Text = ""
        frmGroup.t1.Text = ""
        frmGroup.t2.Text = ""

        RowActive = gridRaw1.CurrentRow.Index
        frmGroup.ShowDialog()
        grid("Group")
        If RowActive < 0 Then RowActive = 0
        gridRaw1.CurrentCell = gridRaw1.Rows(RowActive).Cells(1)
    End Sub

    Private Sub cmdRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemove.Click
        Dim wc As New WebClient()
        If MsgBox("Are you confirmed to delete this record?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            Dim json = wc.DownloadString(url & "all.php?q=253&q2=" & gridRaw1.Item(0, gridRaw1.CurrentRow.Index).Value)
            grid("Group")
        End If
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        frmGroup.t0.Text = gridRaw1.Item(0, gridRaw1.CurrentRow.Index).Value
        frmGroup.t1.Text = gridRaw1.Item(0, gridRaw1.CurrentRow.Index).Value
        frmGroup.t2.Text = gridRaw1.Item(1, gridRaw1.CurrentRow.Index).Value
        RowActive = gridRaw1.CurrentRow.Index
        frmGroup.ShowDialog()
        grid("Group")
        If RowActive < 0 Then RowActive = 0
        gridRaw1.CurrentCell = gridRaw1.Rows(RowActive).Cells(1)
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        grid("Group")
    End Sub

    Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click
        Page = Page - 1
        If Page < 0 Then Page = 0
        lblPage.Text = "Page (" & Page + 1 & ")"
        grid("Group")

    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        Page = Page + 1
        lblPage.Text = "Page (" & Page + 1 & ")"
        grid("Group")
        If gridRaw1.RowCount = 0 Then
            Page = Page - 1
            lblPage.Text = "Page (" & Page + 1 & ")"
            grid("Group")

        End If
    End Sub

    Private Sub txtSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.Click

    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            Page = 0
            lblPage.Text = "Page (" & Page + 1 & ")"
            grid("Group")
            Page = 0
        End If
    End Sub

    Private Sub gridRaw1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridRaw1.CellContentClick

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click

    End Sub

    Private Sub lblPage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPage.Click

    End Sub
End Class