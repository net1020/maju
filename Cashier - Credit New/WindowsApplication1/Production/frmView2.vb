Imports System.Net
Imports Newtonsoft.Json
Public Class frmView2
    'Dim viewSales As List(Of clsCombo2)
    Public selectedData() As String
    Public selected As Boolean

    Public Sub load_sales(ByVal sNo As String, ByVal str As String)
        Dim dNet As New adnetObj.clsAdnet
        dNet.loadGrid(grid1, 20, str)
        grid1.ColumnHeadersVisible = False
        Dim i As Integer
        For i = 4 To 39
            grid1.Columns(i).Visible = False
        Next
    End Sub

    Private Sub frmView2_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        lblStatus.Text = ""
        txtSearch.Text = ""
        txtSearch.Focus()
    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Then
            grid1.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Hide()
        End If
        If e.KeyCode = Keys.Enter Then
            load_sales(20, txtSearch.Text)
        End If
    End Sub

    Private Sub grid1_CellDoubleClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid1.CellDoubleClick
        Dim i As Integer
        Dim sData As String = ""
        For i = 0 To grid1.ColumnCount - 1
            sData = sData & grid1.Item(i, grid1.CurrentRow.Index).Value & "|"
        Next i
        selectedData = Split(sData, "|")
        selected = True
        Me.Visible = False
    End Sub

    Private Sub grid1_CellEnter1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid1.CellEnter
        On Error Resume Next
        lblStatus.Text = grid1.Item(1, grid1.CurrentRow.Index).Value & " - " & grid1.Item(2, grid1.CurrentRow.Index).Value
        If Me.Text <> "Item Barang" Then lblStatus.Text = grid1.Item(1, grid1.CurrentRow.Index).Value
    End Sub

    Private Sub grid1_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grid1.KeyDown
        Dim sData As String = ""
        If e.KeyCode = Keys.Up Then
            If grid1.CurrentRow.Index = 0 Then txtSearch.Focus()
            Exit Sub
        End If
        If e.KeyCode = Keys.Enter Then
            Dim i As Integer

            For i = 0 To grid1.ColumnCount - 1
                sData = sData & grid1.Item(i, grid1.CurrentRow.Index).Value & "|"
            Next i
            selectedData = Split(sData, "|")
            selected = True
            Me.Visible = False
            Exit Sub
        End If
        If e.KeyCode = Keys.Escape Then
            selected = False
            Me.Hide()
        End If
    End Sub

    Private Sub frmView2_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        'selected = False

    End Sub

    Private Sub frmView2_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        selected = False
    End Sub

    Private Sub frmView2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblStatus.Text = ""
        txtSearch.Text = ""
        txtSearch.Focus()
    End Sub

    Private Sub frmView2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus

    End Sub
End Class