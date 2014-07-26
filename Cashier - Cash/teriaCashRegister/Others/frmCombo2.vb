Public Class frmCombo2
    Dim obj As Object
    Private Sub ButtonItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem3.Click
        Me.Hide()
    End Sub

    Private Sub frmCombo2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        Me.Hide()
        obj.Visible = True
    End Sub

    Public Sub objCombo(ByVal obj1 As Object)
        obj = obj1
    End Sub

    Private Sub ButtonItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem2.Click
        Me.Hide()
        obj.showdialog()
    End Sub
End Class