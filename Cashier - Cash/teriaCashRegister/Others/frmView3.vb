Imports System.Net
Imports Newtonsoft.Json
Public Class frmView3
    'Dim viewSales As List(Of clsCombo2)
    Public sCode As String
    Public sName As String
    Public Sub load_sales(ByVal sNo As String, ByVal isItem As Boolean)
        On Error Resume Next
        Dim wc As New WebClient()
        Dim json = wc.DownloadString(Url & "load.php?q=" & sNo)

        If isItem = True Then
            Dim data As List(Of clsItem) = JsonConvert.DeserializeObject(Of List(Of clsItem))(json)
            grid1.DataSource = data
        Else
            Dim data As List(Of clsCombo2) = JsonConvert.DeserializeObject(Of List(Of clsCombo2))(json)
            grid1.DataSource = data
        End If

        'viewSales = data

        grid1.Columns(1).Width = 265
        'grid1.Columns(3).Visible = False
        grid1.ColumnHeadersVisible = False
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
            Search_data()
        End If
    End Sub

    Sub Search_data()
        If Me.Text = "Item Barang" Then search_Item()
        If Me.Text = "Salesman" Then search_Member()
        If Me.Text = "Membership" Then search_Sales()
    End Sub

    Sub search_Item()
        load_sales("31" & "&q2=" & txtSearch.Text, True)
        'grid1.Columns(0).Visible = True
    End Sub

    Sub search_Member()
        'load_sales("11" & "&q2=" & txtSearch.Text, False)
    End Sub

    Sub search_Sales()
        load_sales("21" & "&q2=" & txtSearch.Text, False)
    End Sub

    Private Sub grid1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        sCode = grid1.Item(0, grid1.CurrentRow.Index).Value
        sName = grid1.Item(1, grid1.CurrentRow.Index).Value
        Me.Visible = False
        'Me.Hide()
    End Sub

    Private Sub grid1_CellDoubleClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid1.CellDoubleClick
        sCode = grid1.Item(0, grid1.CurrentRow.Index).Value
        sName = grid1.Item(1, grid1.CurrentRow.Index).Value
        Me.Visible = False
    End Sub

    Private Sub grid1_CellEnter1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid1.CellEnter
        On Error Resume Next

        lblStatus.Text = grid1.Item(1, grid1.CurrentRow.Index).Value & " - " & grid1.Item(2, grid1.CurrentRow.Index).Value
        If Me.Text <> "Item Barang" Then lblStatus.Text = grid1.Item(1, grid1.CurrentRow.Index).Value
    End Sub

    Private Sub grid1_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grid1.KeyDown
        If e.KeyCode = Keys.Up Then
            If grid1.CurrentRow.Index = 0 Then txtSearch.Focus()
            Exit Sub
        End If
        If e.KeyCode = Keys.Enter Then
            sCode = grid1.Item(0, grid1.CurrentRow.Index).Value
            sName = grid1.Item(1, grid1.CurrentRow.Index).Value

            Me.Visible = False
            Exit Sub
        End If
        If e.KeyCode = Keys.Escape Then
            sCode = ""
            sName = ""
            Me.Hide()
            Exit Sub
            'Else
            '    txtSearch.Focus()
        End If
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged

    End Sub

    Private Sub grid1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid1.CellContentClick

    End Sub

    Private Sub frmView2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblStatus.Text = ""
        txtSearch.Text = ""
        txtSearch.Focus()
    End Sub
End Class