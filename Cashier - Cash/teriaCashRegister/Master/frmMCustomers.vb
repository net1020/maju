Imports System.Net
Imports Newtonsoft.Json

Public Class frmMCustomers
    Dim editForm As Boolean
    Public page As Integer

    Public Sub grid(ByVal str2 As String)
        On Error Resume Next
        Dim wc As New WebClient()
        Dim json = wc.DownloadString(Url & "pos.php?q=13&q2=" & str2 & "&p=" & AdnetNavigation1.pageActive)
        Dim data As List(Of clsReport) = JsonConvert.DeserializeObject(Of List(Of clsReport))(json)
        grid1.DataSource = data
        Gridheader()
    End Sub

    Public Function totalRec(ByVal str2 As String) As Integer
        Dim wc As New WebClient()
        Dim json = wc.DownloadString(Url & "pos.php?q=14&q2=" & str2)
        Dim data As List(Of clsCombo2) = JsonConvert.DeserializeObject(Of List(Of clsCombo2))(json)
        On Error Resume Next

        totalRec = data.Item(0).code
    End Function

    Sub Gridheader()
        grid1.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        grid1.Columns(0).Visible = False
        grid1.Columns(0).HeaderText = "No"
        grid1.Columns(1).HeaderText = "First Name"
        grid1.Columns(2).HeaderText = "Last Name"
        grid1.Columns(3).HeaderText = "Email"
        grid1.Columns(4).HeaderText = "Phone"
        grid1.Columns(5).HeaderText = "Address 1"

        grid1.Columns(6).HeaderText = "Address 2"
        grid1.Columns(7).HeaderText = "City"
        grid1.Columns(8).HeaderText = "State"
        grid1.Columns(9).HeaderText = "Zip"
        grid1.Columns(10).HeaderText = "Country"

        grid1.Columns(11).HeaderText = "Comments"
        grid1.Columns(12).HeaderText = "Account"
        grid1.Columns(13).HeaderText = "Taxable"
        For i = 14 To 28
            grid1.Columns(i).Visible = False
        Next
    End Sub

    Private Sub frmme_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        grid("")
        page = 0
        AdnetNavigation1.adnetForm(Me, totalRec(cmbSearch.Text))
    End Sub

    Private Sub ButtonItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem4.Click
        frmMCustomer.cleardata("insert")
        frmMCustomer.load_counter()
        frmMCustomer.t1.Focus()

        frmMCustomer.ShowDialog()

    End Sub

    Private Sub ButtonItem3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem3.Click
        page = page + 1
        grid("")
    End Sub

    Private Sub ButtonItem2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem2.Click
        page = page - 1
        grid("")
    End Sub

    Private Sub ButtonItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem1.Click
        page = 0
        grid("")
    End Sub

    Public Sub adnetRefresh()
        'AdnetNavigation1.adnetForm(Me, totalRec(cmbSearch.Text))
        grid(cmbSearch.Text)
    End Sub

    Private Sub ButtonItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem5.Click
        frmMCustomer.cleardata("update")
        frmMCustomer.t0.Text = grid1.Item(0, grid1.CurrentRow.Index).Value
        frmMCustomer.t1.Text = grid1.Item(1, grid1.CurrentRow.Index).Value
        frmMCustomer.t2.Text = grid1.Item(2, grid1.CurrentRow.Index).Value
        frmMCustomer.t3.Text = grid1.Item(3, grid1.CurrentRow.Index).Value
        frmMCustomer.t4.Text = grid1.Item(4, grid1.CurrentRow.Index).Value
        frmMCustomer.t5.Text = grid1.Item(5, grid1.CurrentRow.Index).Value

        frmMCustomer.t6.Text = grid1.Item(6, grid1.CurrentRow.Index).Value
        frmMCustomer.t7.Text = grid1.Item(7, grid1.CurrentRow.Index).Value
        frmMCustomer.t8.Text = grid1.Item(8, grid1.CurrentRow.Index).Value
        frmMCustomer.t9.Text = grid1.Item(9, grid1.CurrentRow.Index).Value
        frmMCustomer.t10.Text = grid1.Item(10, grid1.CurrentRow.Index).Value

        frmMCustomer.t11.Text = grid1.Item(11, grid1.CurrentRow.Index).Value
        frmMCustomer.t12.Text = grid1.Item(12, grid1.CurrentRow.Index).Value
        frmMCustomer.c13.Checked = grid1.Item(13, grid1.CurrentRow.Index).Value
        frmMCustomer.t1.Focus()
        frmMCustomer.ShowDialog()
        grid(cmbSearch.Text)
    End Sub

    Private Sub ButtonItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem6.Click
        If MsgBox("do you confirm to remove this item?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            On Error Resume Next
            Dim wc As New WebClient()
            Dim json = wc.DownloadString(Url & "pos.php?q=15&q2=" & grid1.Item(0, grid1.CurrentRow.Index).Value)
            AdnetNavigation1.adnetForm(Me, totalRec(cmbSearch.Text))
            grid("")
        End If
    End Sub

    Private Sub ComboBoxItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ButtonItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem7.Click
        AdnetNavigation1.adnetForm(Me, totalRec(cmbSearch.Text))
        grid(cmbSearch.Text)
    End Sub
End Class