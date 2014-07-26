Public Class frmView

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Me.Hide()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        t1.SelectedIndex = 0
        t2.Text = ""
        t3.Text = ""
        Me.Hide()
    End Sub
End Class