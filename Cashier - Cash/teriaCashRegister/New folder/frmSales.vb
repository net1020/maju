Public Class frmSales

    Private Sub frmSales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem6.Click

    End Sub

    Private Sub txtPLU_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPLU.KeyDown
        If e.KeyCode = Keys.Enter Then
            frmViewProduct.ShowDialog()
        End If
    End Sub

    Private Sub TextBoxX1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPLU.TextChanged

    End Sub

    Private Sub ribbonPanel3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ribbonPanel3.Click

    End Sub

    Private Sub ButtonItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem10.Click
        End
    End Sub
End Class