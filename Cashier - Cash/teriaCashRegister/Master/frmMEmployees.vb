Imports System.Net
Imports Newtonsoft.Json

Public Class frmMEmployees
    Dim editForm As Boolean
    Public page As Integer

    Public Sub grid(ByVal str2 As String)
        On Error Resume Next
        Dim wc As New WebClient()
        Dim json = wc.DownloadString(Url & "pos.php?q=23&q2=" & str2 & "&p=" & AdnetNavigation1.pageActive)
        Dim data As List(Of clsReport) = JsonConvert.DeserializeObject(Of List(Of clsReport))(json)
        grid1.DataSource = data
        Gridheader()
    End Sub

    Public Function totalRec() As Integer
        Dim wc As New WebClient()
        Dim json = wc.DownloadString(Url & "pos.php?q=25")
        Dim data As List(Of clsCombo2) = JsonConvert.DeserializeObject(Of List(Of clsCombo2))(json)
        On Error Resume Next

        totalRec = data.Item(0).code
    End Function

    Sub Gridheader()
        grid1.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        grid1.Columns(4).Width = 125
        grid1.Columns(0).HeaderText = "No"


    End Sub

    Private Sub frmme_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        grid("")
        page = 0
        AdnetNavigation1.adnetForm(Me, totalRec)
        '    grid2(gridRaw1.Item(1, gridRaw1.CurrentRow.Index).Value())
    End Sub




    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ButtonItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ButtonItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ButtonItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ButtonItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
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
        grid("")
    End Sub

    Private Sub ButtonItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem9.Click
        frmMEmployee.load_counter()
        frmMEmployee.ShowDialog()
    End Sub

    Private Sub ButtonItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem11.Click
        
    End Sub
End Class