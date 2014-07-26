Imports System.Net
Imports Newtonsoft.Json
Public Class frm1PurchaseReturn
    'Public Sub Sync(ByVal stype As String, ByVal str1 As String)
    '    Dim wc As New WebClient()
    '    Dim loadstring As String
    '    loadstring = ""
    '    If stype = "insert" Then loadstring = "erw.php?q=12"
    '    If stype = "update" Then loadstring = "erw.php?q=13"
    '    If stype = "delete" Then loadstring = "erw.php?q=14"
    '    Dim json = wc.DownloadString(Url & loadstring & "&q2=" & str1)

    'End Sub
    'Private Sub frm2ScheduleDeliveryForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    'End Sub
    'Public Sub load_product()
    '    Dim wc As New WebClient()
    '    Dim json = wc.DownloadString(Url & "load.php?q=107")
    '    Dim data As List(Of clsCombo2) = JsonConvert.DeserializeObject(Of List(Of clsCombo2))(json)
    '    Dim coltype As DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn = DirectCast(grid1.Columns(3), DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn)
    '    coltype.DataSource = data
    '    coltype.DisplayMember = "name"
    '    coltype.ValueMember = "code"
    'End Sub

    'Public Sub load_customer()
    '    On Error Resume Next
    '    Dim wc As New WebClient()
    '    Dim json = wc.DownloadString(Url & "load.php?q=103")
    '    Dim data As List(Of clsCombo) = JsonConvert.DeserializeObject(Of List(Of clsCombo))(json)
    '    cmbCustomer.DataSource = data
    '    cmbCustomer.DisplayMember = "name"
    '    cmbCustomer.ValueMember = "code"
    '    cmbCustomer.SelectedIndex = 0
    'End Sub

    'Public Sub load_approval()
    '    On Error Resume Next
    '    Dim wc As New WebClient()
    '    Dim json = wc.DownloadString(Url & "load.php?q=108")
    '    Dim data As List(Of clsCombo) = JsonConvert.DeserializeObject(Of List(Of clsCombo))(json)
    '    cmbApprove.DataSource = data
    '    cmbApprove.DisplayMember = "name"
    '    cmbApprove.ValueMember = "code"
    '    cmbApprove.SelectedIndex = 0
    'End Sub

    'Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
    '    editForm2 = False
    '    Me.Close()
    'End Sub

    'Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
    '    Dim dt1 As DateTime
    '    Dim cs1 As String
    '    dt1 = txtEODate.Value
    '    cs1 = dt1.ToString("yyyy-MM-dd")
    '    If txtno.Text = "" Then
    '        'Insert new
    '        Sync("insert", txtno.Text & "|" & txtEONo.Text & "|" & cs1 & "|" & cmbCustomer.SelectedValue & "|" & cmbCustomer.Text & "|" & cmbApprove.Text & "|" & txtNotes.Text & "|" & userName & "|" & gridDetail())
    '    Else
    '        'Update record
    '        Sync("update", txtno.Text & "|" & txtEONo.Text & "|" & cs1 & "|" & cmbCustomer.SelectedValue & "|" & cmbCustomer.Text & "|" & cmbApprove.Text & "|" & txtNotes.Text & "|" & userName & "|" & gridDetail())
    '    End If
    '    Me.Close()
    'End Sub
    'Public Sub load_setting()
    '    load_customer()
    '    load_product()
    '    load_approval()
    '    grid1.Columns(0).Visible = False
    '    grid1.Columns(1).Visible = False
    '    grid1.Columns(4).Visible = False
    '    grid1.Columns(6).Visible = False
    '    grid1.Columns(7).Visible = False
    '    'grid2.Columns(10).Visible = False
    '    'grid2.Columns(11).Visible = False
    'End Sub

    'Function gridDetail() As String
    '    Dim j, n, n2 As Integer
    '    Dim str As String
    '    Dim data1, data2 As String

    '    j = grid1.RowCount
    '    str = ""

    '    For n = 0 To j - 2
    '        data1 = grid1.Item(3, n).Value()
    '        data2 = grid1.Item(4, n).Value()
    '        For n2 = 0 To 7

    '            If n2 = 3 Then
    '                If data1 = data2 And grid1.Item(6, n).Value() <> "" Then
    '                    str = str & grid1.Item(6, n).Value()
    '                Else
    '                    str = str & grid1.Item(n2, n).Value()
    '                End If

    '            Else

    '                str = str & grid1.Item(n2, n).Value()
    '            End If

    '            str = str & "[]"
    '        Next
    '        str = Strings.Left(str, Len(str) - 2)
    '        str = str & "{}"
    '    Next
    '    str = Strings.Left(str, Len(str) - 2)
    '    gridDetail = str
    'End Function


    Private Sub ToolStripButton24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmMaster.ShowDialog()

    End Sub

    Private Sub ToolStripButton15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TabControlPanel7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControlPanel7.Click

    End Sub
End Class