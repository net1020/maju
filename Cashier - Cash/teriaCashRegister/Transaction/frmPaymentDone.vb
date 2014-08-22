Public Class frmPaymentDone
    Private Sub t1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles t1.KeyDown
        If e.KeyCode = Keys.F1 Then
            Me.Hide()
            frmSales.voidall_item()
            SendKeys.Send("{TAB}")
            SendKeys.Send("{TAB}")
            frmSales.cmdf2.RaiseClick()
            frmScreen.txtDisc.Text = 0
            frmScreen.txtChange.Text = 0
            frmScreen.txtTotal.Text = 0
            frmScreen.txtPay.Text = 0
        End If
    End Sub

    Private Sub frmPaymentDone_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        t1.Focus()
    End Sub

    Private Sub cmdf1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdf1.Click
        Me.Visible = False
        frmSales.voidall_item()
        SendKeys.Send("{TAB}")
        SendKeys.Send("{TAB}")
        frmSales.cmdf2.RaiseClick()
        frmScreen.txtDisc.Text = 0
        frmScreen.txtChange.Text = 0
        frmScreen.txtTotal.Text = 0
        frmScreen.txtPay.Text = 0
        ' SendKeys.Send("{ENTER}")
    End Sub

    Private Sub frmPaymentDone_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Me.TopMost = True
    End Sub
End Class