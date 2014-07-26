Imports System.Net
Imports Newtonsoft.Json
Public Class frmCustomer

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim str As String
        Dim dt1 As DateTime
        Dim cs1 As String
        dt1 = t7.Value
        cs1 = dt1.ToString("yyyy-MM-dd")

        str = t0.Text & "|"
        str = str & t1.Text & "|"
        str = str & t2.Text & "|"
        str = str & t3.Text & "|"
        str = str & t4.Text & "|"
        str = str & t5.Text & "|"
        str = str & t6.Text & "|"
        str = str & cs1 & "|"
        str = str & t8.Text & "|"
        str = str & t9.Text
        If t0.Text = "" Then
            Inserted(215, str)
        Else
            Updated(216, str)
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
        dt1 = t7.Value
        cs1 = dt1.ToString("yyyy-MM-dd")

        str = t0.Text & "|"
        str = str & t1.Text & "|"
        str = str & t2.Text & "|"
        str = str & t3.Text & "|"
        str = str & t4.Text & "|"
        str = str & t5.Text & "|"
        str = str & t6.Text & "|"
        str = str & cs1 & "|"
        str = str & t8.Text & "|"
        str = str & t9.Text
        If t0.Text = "" Then
            Inserted(215, str)
        Else
            Updated(216, str)
        End If
        t0.Text = ""
        t1.Text = ""
        t2.Text = ""
        t3.Text = ""
        t4.Text = ""
        t5.Text = ""
        t6.Text = ""
        t7.Text = Today
        t8.Text = ""
        t9.SelectedIndex = 0
        t1.Focus()
    End Sub


    Private Sub t6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class