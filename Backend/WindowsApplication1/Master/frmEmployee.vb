Imports System.Net
Imports Newtonsoft.Json
Public Class frmEmployee

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim str As String
        Dim dt1 As DateTime
        Dim cs1 As String
        dt1 = t6.Value
        cs1 = dt1.ToString("yyyy-MM-dd")

        str = t0.Text & "|"
        str = str & t1.Text & "|"
        str = str & t2.Text & "|"
        str = str & t3.Text & "|"
        str = str & t4.Text & "|"
        str = str & t5.Text & "|"
        str = str & cs1 & "|"
        str = str & t7.Text
        If t0.Text = "" Then
            Inserted(201, str)
        Else
            Updated(202, str)
        End If
        Me.Hide()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Hide()
    End Sub

    Private Sub ButtonItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem2.Click
        Dim str As String
        Dim dt1 As DateTime
        Dim cs1 As String
        dt1 = t6.Value
        cs1 = dt1.ToString("yyyy-MM-dd")

        str = t1.Text & "|"
        str = str & t1.Text & "|"
        str = str & t2.Text & "|"
        str = str & t3.Text & "|"
        str = str & t4.Text & "|"
        str = str & t5.Text & "|"
        str = str & cs1 & "|"
        str = str & t7.Text
        If t0.Text = "" Then
            Inserted(201, str)
        Else
            Updated(202, str)
        End If
        t0.Text = ""
        t1.Text = ""
        t2.Text = ""
        t3.Text = ""
        t4.Text = ""
        t5.Text = ""
        t6.Text = Today
        t7.SelectedIndex = 0
        t1.Focus()
    End Sub


End Class