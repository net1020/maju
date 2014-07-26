
Imports System.Net
Imports Newtonsoft.Json
Public Class frmLogin

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Panel1.Left = (frmMain.Width / 2) - (Panel1.Width / 2)
        Panel1.Top = (frmMain.Height / 2) - 225
    End Sub

    Private Sub frmLogin_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Panel1.Left = (frmMain.Width / 2) - (Panel1.Width / 2)
        Panel1.Top = (frmMain.Height / 2) - 225
    End Sub

    Private Sub Panel2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel2.Click
        If MsgBox("Are you confirm to exit this program?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Public Function login(ByVal str2 As String, ByVal str3 As String) As Boolean
        On Error Resume Next
        Dim cNet As New adnetObj.clsAdnet
        'Dim wc As New WebClient()
        'Dim json = wc.DownloadString(url & "all.php?u=" & userName & "&c=" & compName & "&q=99&q2=" & str2 & "|" & str3)
        'Dim data As List(Of clsReport) = JsonConvert.DeserializeObject(Of List(Of clsReport))(json)
        userName = cNet.ExecuteData(99, str2 & "|" & str3)
        If userName = "" Then
            login = False
            MsgBox("Your login is failed, please check the username or password", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        Else
            login = True
        End If
        'userAccess = data.Item(0).f2
    End Function

    Private Sub cmdLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogin.Click
        If login(txtUsername.Text, txtPassword.Text) Then
            frmMain.labelPosition.Text = "User: " & userName
            Me.Close()
            'frmMain.Load_Items()
            frmMain.ribbon1.Enabled = True
        End If
    End Sub

    Private Sub txtUsername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub txtPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            If login(txtUsername.Text, txtPassword.Text) Then
                frmMain.labelPosition.Text = "User: " & userName
                Me.Close()
                'frmMain.Load_Items()
                frmMain.ribbon1.Enabled = True
            End If
        End If
    End Sub

    Private Sub txtPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.TextChanged

    End Sub
End Class