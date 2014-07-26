Imports System.Net
Imports Newtonsoft.Json
Public Class frm1PurchaseList
    Public Sub grid(ByVal str2 As String)
        'On Error Resume Next
        'Dim wc As New WebClient()
        'Dim json = wc.DownloadString(Url & "erw.php?q=11&q2=" & str2)
        'Dim data As List(Of clsERWOut) = JsonConvert.DeserializeObject(Of List(Of clsERWOut))(json)
        'grid1.DataSource = data
        'Gridheader()
    End Sub

    Sub Gridheader()


        grid1.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        grid1.Columns(4).Width = 125


        grid1.Columns(0).HeaderText = "EO ID"
        grid1.Columns(1).HeaderText = "EO No"
        grid1.Columns(2).HeaderText = "EO Date"
        grid1.Columns(3).HeaderText = "Cust ID"
        grid1.Columns(4).HeaderText = "Customer"
        grid1.Columns(5).HeaderText = "Approved by"
        grid1.Columns(6).HeaderText = "Notes"


    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        'Dim str, str2 As String
        'Dim strArr(), strArr2() As String
        'editForm2 = True
        'frm3ERWOut.load_setting()
        'frm3ERWOut.txtno.Text = grid1.Item(0, grid1.CurrentRow.Index).Value
        'frm3ERWOut.txtEONo.Text = grid1.Item(1, grid1.CurrentRow.Index).Value
        'frm3ERWOut.txtEODate.Text = grid1.Item(2, grid1.CurrentRow.Index).Value
        'frm3ERWOut.cmbCustomer.Text = grid1.Item(4, grid1.CurrentRow.Index).Value
        'frm3ERWOut.cmbApprove.Text = grid1.Item(5, grid1.CurrentRow.Index).Value
        'frm3ERWOut.txtNotes.Text = grid1.Item(6, grid1.CurrentRow.Index).Value

        'Clear_Data()
        'If grid1.Item(7, grid1.CurrentRow.Index).Value() <> "" Then
        '    str = grid1.Item(7, grid1.CurrentRow.Index).Value()
        '    strArr = str.Split(";")
        '    For count = 0 To strArr.Length - 1
        '        str2 = strArr(count)
        '        strArr2 = str2.Split("|")
        '        frm3ERWOut.grid1.Rows.Add(New String() {strArr2(0), strArr2(1), strArr2(2), strArr2(4), strArr2(4), strArr2(5), strArr2(3), strArr2(6)})

        '    Next
        'End If

        'frm3ERWOut.ShowDialog()
    End Sub



    Private Sub frm3WorkOrders_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        grid("")
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Sub Clear_Data()
        'frm3ERWOut.grid1.Rows.Clear()
    End Sub


    Private Sub txtSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.Click

    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            grid(txtSearch.Text)
        End If
    End Sub

    Private Sub grid1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub grid1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs)
        'If editForm2 = True Then
        '    grid("")
        '    editForm2 = False
        'End If
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        grid("")
        txtSearch.Text = ""
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        frm1Purchase.ShowDialog()
        'editForm2 = True
        'frm3ERWOut.load_setting()
        'frm3ERWOut.txtno.Text = ""
        'frm3ERWOut.txtEONo.Text = EONo()
        'frm3ERWOut.txtEODate.Text = ""
        'frm3ERWOut.cmbCustomer.Text = ""
        'frm3ERWOut.cmbApprove.Text = ""
        'frm3ERWOut.txtNotes.Text = ""

        'Clear_Data()
        'frm3ERWOut.ShowDialog()
    End Sub

    Private Sub cmdRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemove.Click
        'If MsgBox("Are you confirmed to delete this record?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        '    frm3ERWOut.Sync("delete", grid1.Item(1, grid1.CurrentRow.Index).Value())
        '    grid("")
        'End If
    End Sub
End Class