Imports System.Net
Imports Newtonsoft.Json
Public Class frmCalculateForm
    Public CancelForm As Boolean

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        CancelForm = False
        Me.Hide()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        CancelForm = True
        Me.Hide()


    End Sub
    Sub load_product()
        Dim wc As New WebClient()
        Dim json = wc.DownloadString(url & "all.php?q=1&q2=")
        Dim users As List(Of clsCombo) = JsonConvert.DeserializeObject(Of List(Of clsCombo))(json)
        t1.DataSource = users
        t1.DisplayMember = "name"
        t1.ValueMember = "code"
        t1.SelectedIndex = 0

    End Sub
    Private Sub t1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub t2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub frmProduct_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        load_product()
    End Sub

    Private Sub t0_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t0.TextChanged

    End Sub

    Private Sub FlowLayoutPanel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub

    Private Sub c2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t1.SelectedIndexChanged

    End Sub

    Private Sub c1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub t1_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t2.TextChanged

    End Sub
End Class