Imports System.Net
Imports Newtonsoft.Json
Public Class frmPricing

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim str As String

        str = t13.Text & "|"
        str = str & Replace(t6.Text, ",", "") & "|"
        str = str & Replace(t7.Text, ",", "") & "|"
        str = str & Replace(t8.Text, ",", "") & "|"
        str = str & Replace(t9.Text, ",", "") & "|"
        str = str & Replace(t10.Text, ",", "") & "|"
        str = str & userName
        If t0.Text = "" Then
            Inserted(261, str)
        Else
            Updated(262, str)
        End If
        Me.Hide()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Hide()
    End Sub



    Private Sub t8_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles t8.KeyPress
        Dim allowedChars As String = "0123456789."
        If allowedChars.IndexOf(e.KeyChar) = -1 And Not e.KeyChar = ChrW(8) Then
            e.Handled = True
            Exit Sub
        End If
    End Sub

    Private Sub t9_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles t9.KeyPress
        Dim allowedChars As String = "0123456789."
        If allowedChars.IndexOf(e.KeyChar) = -1 And Not e.KeyChar = ChrW(8) Then
            e.Handled = True
            Exit Sub
        End If
    End Sub

    Private Sub t10_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles t10.KeyPress
        Dim allowedChars As String = "0123456789."
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


    Private Sub t5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles t5.KeyPress
        Dim allowedChars As String = "0123456789"
        If allowedChars.IndexOf(e.KeyChar) = -1 And Not e.KeyChar = ChrW(8) Then
            e.Handled = True
            Exit Sub
        End If
    End Sub

    Private Sub t6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles t6.KeyPress
        Dim allowedChars As String = "0123456789"
        If allowedChars.IndexOf(e.KeyChar) = -1 And Not e.KeyChar = ChrW(8) Then
            e.Handled = True
            Exit Sub
        End If
    End Sub

    Private Sub t7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles t7.KeyPress
        Dim allowedChars As String = "0123456789"
        If allowedChars.IndexOf(e.KeyChar) = -1 And Not e.KeyChar = ChrW(8) Then
            e.Handled = True
            Exit Sub
        End If
    End Sub
End Class