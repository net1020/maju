Imports System.Net
Imports Newtonsoft.Json
Public Class frmUser

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim str As String
        str = t0.Text & "|"
        str = str & t1.Text & "|"
        str = str & t2.Text & "|"
        str = str & t3.Text & "|"
        str = str & t4.Text
        If t0.Text = "" Then
            Inserted(245, str)
        Else
            Updated(246, str)
        End If
        Me.Hide()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Hide()
    End Sub

    Private Sub ButtonItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem2.Click
        Dim str As String
        str = t0.Text & "|"
        str = str & t1.Text & "|"
        str = str & t2.Text & "|"
        str = str & t3.Text & "|"
        str = str & t4.Text
        If t0.Text = "" Then
            Inserted(245, str)
        Else
            Updated(246, str)
        End If
        t0.Text = ""
        t1.Text = ""
        t2.Text = ""
        t3.Text = ""
        t4.Text = ""
        t1.Focus()
    End Sub

    Public Sub load_Group()
        Dim wc As New WebClient()
        Dim json = wc.DownloadString(url & "all.php?u=" & userName & "&c=" & compName & "&q=304&q2=")
        Dim users As List(Of clsCombo) = JsonConvert.DeserializeObject(Of List(Of clsCombo))(json)
        t4.DataSource = users
        t4.DisplayMember = "name"
        t4.ValueMember = "code"
        t4.SelectedIndex = 0
    End Sub
End Class