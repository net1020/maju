Imports System.Net
Imports Newtonsoft.Json
Public Class frmItem

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim str As String

        str = t0.Text & "|"
        str = str & t1.Text & "|"
        str = str & t2.Text & "|"
        str = str & t3.Text & "|"
        str = str & t4.Text & "|"
        str = str & t5.SelectedValue & "|"
        str = str & t6.Text & "|"
        str = str & t7.Text & "|"
        str = str & Replace(t8.Text, ",", "") & "|"
        str = str & Replace(t9.Text, ",", "") & "|"
        str = str & Replace(t10.Text, ",", "") & "|"
        str = str & Replace(t11.Text, ",", "")
        If t0.Text = "" Then
            Inserted(231, str)
        Else
            Updated(232, str)
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
        str = str & t4.Text & "|"
        str = str & t5.SelectedValue & "|"
        str = str & t6.Text & "|"
        str = str & t7.Text & "|"
        str = str & Replace(t8.Text, ",", "") & "|"
        str = str & Replace(t9.Text, ",", "") & "|"
        str = str & Replace(t10.Text, ",", "") & "|"
        str = str & Replace(t11.Text, ",", "")
        If t0.Text = "" Then
            Inserted(231, str)
        Else
            Updated(232, str)
        End If
        t0.Text = ""
        t1.Text = ""
        t2.Text = ""
        t3.Text = ""
        t4.SelectedIndex = 0
        t5.SelectedIndex = 0
        t6.Text = ""
        t7.SelectedIndex = 0
        t8.Text = 0
        t9.Text = 0
        t10.Text = 0
        t11.Text = 0
        t1.Focus()
    End Sub


    Private Sub t8_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles t8.KeyPress
        Dim allowedChars As String = "0123456789"
        If allowedChars.IndexOf(e.KeyChar) = -1 And Not e.KeyChar = ChrW(8) Then
            e.Handled = True
            Exit Sub
        End If
    End Sub

    Private Sub t9_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles t9.KeyPress
        Dim allowedChars As String = "0123456789"
        If allowedChars.IndexOf(e.KeyChar) = -1 And Not e.KeyChar = ChrW(8) Then
            e.Handled = True
            Exit Sub
        End If
    End Sub

    Private Sub t10_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles t10.KeyPress
        Dim allowedChars As String = "0123456789"
        If allowedChars.IndexOf(e.KeyChar) = -1 And Not e.KeyChar = ChrW(8) Then
            e.Handled = True
            Exit Sub
        End If
    End Sub

    Private Sub t11_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles t11.KeyPress
        Dim allowedChars As String = "0123456789"
        If allowedChars.IndexOf(e.KeyChar) = -1 And Not e.KeyChar = ChrW(8) Then
            e.Handled = True
            Exit Sub
        End If
    End Sub

    Private Sub frmItem_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        
        t1.Focus()
    End Sub

    Public Sub load_category()
        Dim wc As New WebClient()
        Dim json = wc.DownloadString(url & "all.php?q=301")
        Dim data As List(Of clsCombo) = JsonConvert.DeserializeObject(Of List(Of clsCombo))(json)
        t4.DataSource = data
        t4.DisplayMember = "name"
        t4.ValueMember = "code"
        t4.SelectedIndex = 0
    End Sub

    Public Sub load_supplier()
        Dim wc As New WebClient()
        Dim json = wc.DownloadString(url & "all.php?q=302")
        Dim data As List(Of clsCombo) = JsonConvert.DeserializeObject(Of List(Of clsCombo))(json)
        t5.DataSource = data
        t5.DisplayMember = "name"
        t5.ValueMember = "code"
        t5.SelectedIndex = 0
    End Sub

    Public Sub load_unit()
        Dim wc As New WebClient()
        Dim json = wc.DownloadString(url & "all.php?q=303")
        Dim data As List(Of clsCombo) = JsonConvert.DeserializeObject(Of List(Of clsCombo))(json)
        t7.DataSource = data
        t7.DisplayMember = "name"
        t7.ValueMember = "code"
        t7.SelectedIndex = 0
    End Sub

End Class