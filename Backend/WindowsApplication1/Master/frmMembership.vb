Imports System.Net
Imports Newtonsoft.Json
Public Class frmMembership

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim str As String
        Dim dt1, dt2, dt3 As DateTime
        Dim cs1, cs2, cs3 As String
        dt1 = t3.Value
        cs1 = dt1.ToString("yyyy-MM-dd")

        dt2 = t4.Value
        cs2 = dt2.ToString("yyyy-MM-dd")

        dt3 = t5.Value
        cs3 = dt3.ToString("yyyy-MM-dd")

        str = t0.Text & "|"
        str = str & t1.Text & "|"
        str = str & t2.Text & "|"
        str = str & cs1 & "|"
        str = str & cs2 & "|"
        str = str & cs3 & "|"
        str = str & t6.Text & "|"
        str = str & t7.Text & "|"
        str = str & t8.Text & "|"
        str = str & t9.Text & "|"
        str = str & t10.Text
        If t0.Text = "" Then
            Inserted(211, str)
        Else
            Updated(212, str)
        End If
        Me.Hide()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Hide()
    End Sub

    Private Sub ButtonItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem2.Click
        Dim str As String
        Dim dt1, dt2, dt3 As DateTime
        Dim cs1, cs2, cs3 As String
        dt1 = t3.Value
        cs1 = dt1.ToString("yyyy-MM-dd")

        dt2 = t4.Value
        cs2 = dt2.ToString("yyyy-MM-dd")

        dt3 = t5.Value
        cs3 = dt3.ToString("yyyy-MM-dd")

        str = t1.Text & "|"
        str = str & t1.Text & "|"
        str = str & t2.Text & "|"
        str = str & cs1 & "|"
        str = str & cs2 & "|"
        str = str & cs3 & "|"
        str = str & t6.Text & "|"
        str = str & t7.Text & "|"
        str = str & t8.Text & "|"
        str = str & t9.Text & "|"
        str = str & t10.Text
        If t0.Text = "" Then
            Inserted(211, str)
        Else
            Updated(212, str)
        End If
        t0.Text = ""
        t1.Text = ""
        t2.Text = ""
        t3.Text = Today
        t4.Text = Today
        t5.Text = Today
        t6.SelectedIndex = 0
        t7.Text = ""
        t8.Text = ""
        t9.Text = ""
        t3.Text = Today
        t10.SelectedIndex = 0
        t1.Focus()
    End Sub


    Private Sub t6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t6.SelectedIndexChanged

    End Sub
End Class