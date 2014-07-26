Public Class frmCombo

    Private Sub frmCombo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        Me.Hide()
        frmCustomer.Visible = True
    End Sub

    Private Sub frmCombo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class