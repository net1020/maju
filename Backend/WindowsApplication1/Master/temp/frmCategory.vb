Imports System.Net
Imports Newtonsoft.Json
Public Class frmCategory

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim str As String
        str = t1.Text & "|"
        str = str & t2.Text
        If t0.Text = "" Then
            Inserted(235, str)
        Else
            Updated(236, str)
        End If
        Me.Hide()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Hide()
    End Sub

    Private Sub ButtonItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem2.Click
        Dim str As String
        str = t1.Text & "|"
        str = str & t2.Text
        If t0.Text = "" Then
            Inserted(235, str)
        Else
            Updated(236, str)
        End If
        t0.Text = ""
        t1.Text = ""
        t2.Text = ""
        t2.Focus()
    End Sub
End Class