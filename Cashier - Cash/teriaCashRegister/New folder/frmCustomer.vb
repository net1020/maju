﻿Public Class frmCustomer

    Private Sub ButtonItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem3.Click
        Me.Hide()
    End Sub

    Private Sub TextBoxX7_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxX7.KeyDown
        If e.KeyCode = Keys.Enter Then
            frmCombo2.Show()
            frmCombo2.TopMost = True
            Me.Hide()
        End If
    End Sub

    Private Sub TextBoxX7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxX7.TextChanged

    End Sub

    Private Sub frmCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Sub load_textbox()

    End Sub
End Class