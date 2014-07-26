Imports System.Net
Imports Newtonsoft.Json
Public Class frmLogin

    Private Sub frmLogin_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtUsername.Focus()
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Panel1.Left = (Me.Width / 2) - (Panel1.Width / 2)
        Panel1.Top = (Me.Height / 2) - 225
    End Sub

    Private Sub frmLogin_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Panel1.Left = (Me.Width / 2) - (Panel1.Width / 2)
        Panel1.Top = (Me.Height / 2) - 225
    End Sub

    Private Sub Panel2_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        If MsgBox("Are you confirm to exit this program?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub cmdLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogin.Click
        If login(txtUsername.Text, txtPassword.Text) Then
            txtUsername.Text = ""
            txtPassword.Text = ""
            frmBrowser.ShowDialog()
            txtUsername.Focus()
        End If
    End Sub

    'Public Function login() As String
    '    On Error Resume Next
    '    Dim wc As New WebClient()
    '    Dim json = wc.DownloadString(Url & "load.php?q=2&q2=" & txtUsername.Text & "|" & txtPassword.Text)
    '    Dim data As List(Of clsCombo) = JsonConvert.DeserializeObject(Of List(Of clsCombo))(json)
    '    login = data.Item(0).name
    'End Function

    Private Sub txtPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            If login(txtUsername.Text, txtPassword.Text) Then
                txtUsername.Text = ""
                txtPassword.Text = ""
                frmBrowser.ShowDialog()
                txtUsername.Focus()
            End If
        End If
    End Sub

    Public Function login(ByVal str2 As String, ByVal str3 As String) As Boolean
        On Error Resume Next
        Dim wc As New WebClient()
        Dim json = wc.DownloadString(url & "all.php?u=" & userName & "&c=" & compName & "&q=99&q2=" & str2 & "|" & str3)
        Dim data As List(Of clsReport) = JsonConvert.DeserializeObject(Of List(Of clsReport))(json)
        If data.Item(0).f1 = "" Then
            login = False
            MsgBox("Your login is failed, please check the username or password", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        Else
            login = True
        End If
        userName = data.Item(0).f1
        'userAccess = data.Item(0).f2
    End Function

    Private Sub txtPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.TextChanged

    End Sub
End Class