Imports System.Net
Imports Newtonsoft.Json
Public Class frmCatpricing

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim str As String

        str = t8.Text & "|"
        str = str & Replace(t2.Text, ",", "") & "|"
        str = str & Replace(t3.Text, ",", "") & "|"
        str = str & Replace(t4.Text, ",", "") & "|"
        str = str & Replace(t5.Text, ",", "") & "|"
        str = str & userName
        If t0.Text = "" Then
            Inserted(265, str)
        Else
            Updated(266, str)
        End If
        Me.Hide()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Hide()
    End Sub



    Private Sub t8_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles t3.KeyPress
        Dim allowedChars As String = "0123456789."
        If allowedChars.IndexOf(e.KeyChar) = -1 And Not e.KeyChar = ChrW(8) Then
            e.Handled = True
            Exit Sub
        End If
    End Sub

    Private Sub t9_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles t4.KeyPress
        Dim allowedChars As String = "0123456789."
        If allowedChars.IndexOf(e.KeyChar) = -1 And Not e.KeyChar = ChrW(8) Then
            e.Handled = True
            Exit Sub
        End If
    End Sub

    Private Sub t10_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles t5.KeyPress
        Dim allowedChars As String = "0123456789."
        If allowedChars.IndexOf(e.KeyChar) = -1 And Not e.KeyChar = ChrW(8) Then
            e.Handled = True
            Exit Sub
        End If
    End Sub


    Private Sub frmItem_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        t1.Focus()
    End Sub

End Class