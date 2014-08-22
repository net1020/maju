Public Class frmScreen

    Private Sub frmScreen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        WebBrowser1.Navigate(My.Settings.sliderurl)
        Me.Hide()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Me.Hide()
    End Sub
End Class