Imports System.Net
Imports Newtonsoft.Json
Public Class frmMCategory
    Dim wc As New WebClient()
    Private Sub ButtonItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem1.Click
        savedata()
        cleardata()
        Me.Hide()
    End Sub

    Sub savedata()
        Dim str As String
        str = t0.Text & "|"
        str = str & t1.Text
        
        Dim json = wc.DownloadString(Url & "pos.php?q=51&q2=" & str)
    End Sub

    Private Sub ButtonItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem2.Click
        savedata()
        cleardata()
        load_counter()
        t1.Focus()
    End Sub

    Sub cleardata()
        t1.Text = ""

    End Sub

    Private Sub ButtonItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem3.Click
        Me.Hide()
    End Sub

    Public Sub load_counter()
        Dim json = wc.DownloadString(Url & "pos.php?q=52")
        Dim data As List(Of clsCombo2) = JsonConvert.DeserializeObject(Of List(Of clsCombo2))(json)
        On Error Resume Next

        t0.Text = data.Item(0).code
    End Sub
End Class