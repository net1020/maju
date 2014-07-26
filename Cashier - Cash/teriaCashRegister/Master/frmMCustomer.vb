Imports System.Net
Imports Newtonsoft.Json
Public Class frmMCustomer
    Dim wc As New WebClient()
    Public Stype As String 'Save type insert or update

    Private Sub ButtonItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem1.Click
        savedata()
        cleardata("")
        Me.Hide()
    End Sub

    Sub savedata()
        Dim str As String
        str = t0.Text & "|"
        str = str & t1.Text & "|"
        str = str & t2.Text & "|"
        str = str & t3.Text & "|"
        str = str & t4.Text & "|"
        str = str & t5.Text & "|"
        str = str & t6.Text & "|"
        str = str & t7.Text & "|"
        str = str & t8.Text & "|"
        str = str & t9.Text & "|"
        str = str & t10.Text & "|"
        str = str & t11.Text & "|"
        str = str & t12.Text & "|"
        If c13.Checked = True Then
            str = str & "1"
        Else
            str = str & "0"
        End If
        Dim json = wc.DownloadString(Url & "pos.php?type=" & Stype & "&q=11&q2=" & str)
    End Sub

    Private Sub ButtonItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem2.Click
        savedata()
        cleardata("")
        load_counter()
        t1.Focus()
    End Sub

    Public Sub cleardata(ByVal mtype As String)
        Stype = mtype
        t0.Text = ""
        t1.Text = ""
        t2.Text = ""
        t3.Text = ""
        t4.Text = ""
        t5.Text = ""

        t6.Text = ""
        t7.Text = ""
        t8.Text = ""
        t9.Text = ""
        t10.Text = ""

        t11.Text = ""
        t12.Text = ""
        c13.Checked = False

    End Sub

    Private Sub ButtonItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem3.Click
        Me.Hide()
    End Sub

    Public Sub load_counter()
        Dim json = wc.DownloadString(Url & "pos.php?q=12")
        Dim data As List(Of clsCombo2) = JsonConvert.DeserializeObject(Of List(Of clsCombo2))(json)
        t0.Text = data.Item(0).code
    End Sub
End Class