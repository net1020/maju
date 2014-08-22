Imports System.Net
Imports Newtonsoft.Json
Public Class frmLogin

    Private Sub frmLogin_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtUsername.Focus()
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Panel1.Left = (Me.Width / 2) - (Panel1.Width / 2)
        Panel1.Top = (Me.Height / 2) - 225
        'frmSales.Open_Screen()
        frmScreen.Left = My.Settings.screenleft
        frmScreen.Top = My.Settings.screentop
        frmScreen.Width = My.Settings.screenwidth
        frmScreen.Height = My.Settings.screenheight

        Dim Screen2() As Screen = Screen.AllScreens
        On Error Resume Next

        frmScreen.Location = Screen2(1).Bounds.Location
        frmScreen.Show()
        frmScreen.Hide()

        frmSales.Print_Screen2("Welcome to", "Toko Madju")
    End Sub

    Private Sub frmLogin_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Panel1.Left = (Me.Width / 2) - (Panel1.Width / 2)
        Panel1.Top = (Me.Height / 2) - 225
    End Sub

    Private Sub Panel2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel2.Click
        If MsgBox("Are you confirm to exit this program?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    'Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogin.Click

    '    combo_login(txtUsername.Text, txtPassword.Text)
    '    If cmb_Login Is Nothing Then
    '        MsgBox("Username or Password is not valid", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Login Form")
    '    Else
    '        userName = cmb_Login(0).name.ToString
    '        userType = cmb_Login(0).code.ToString
    '        frmMain.lblUsername.Text = "User: " & userName
    '        frmMain.ribbonControl1.Enabled = True
    '        Me.Close()
    '        frmMain.Open_Order()
    '    End If
    'End Sub

    'Private Sub txtPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        combo_login(txtUsername.Text, txtPassword.Text)
    '        If cmb_Login Is Nothing Then
    '            MsgBox("Username or Password is not valid", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Login Form")
    '        Else
    '            combo_customer()
    '            combo_product()
    '            combo_payment()
    '            combo_salesman()
    '            combo_shipping()
    '            combo_warehouse()
    '            combo_price()
    '            combo_printer()
    '            userName = cmb_Login(0).name.ToString
    '            userType = cmb_Login(0).code.ToString
    '            frmMain.lblUsername.Text = "User: " & userName
    '            frmMain.ribbonControl1.Enabled = True
    '            Me.Close()
    '            frmMain.Open_Order()
    '        End If
    '    End If
    'End Sub

    'Private Sub txtPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.TextChanged

    'End Sub


    Private Sub cmdLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogin.Click
        userName = login()
        If userName <> "" Then
            txtUsername.Text = ""
            txtPassword.Text = ""
            frmSales.cmdUser.Text = "Cashier: " & userName
            frmNewCashier.ShowDialog()
            Me.Hide()
            frmSales.Show()
        Else
            MsgBox("Login anda gagal!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End If

    
    End Sub

    Public Function login() As String
        On Error Resume Next
        Dim wc As New WebClient()
        Dim json = wc.DownloadString(Url & "load.php?q=2&q2=" & txtUsername.Text & "|" & txtPassword.Text)
        Dim data As List(Of clsCombo2) = JsonConvert.DeserializeObject(Of List(Of clsCombo2))(json)


        login = data.Item(0).name
    End Function

    Private Sub txtPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            userName = login()
            If userName <> "" Then
                txtUsername.Text = ""
                txtPassword.Text = ""
                frmSales.cmdUser.Text = "Cashier: " & userName
                frmNewCashier.ShowDialog()
                Me.Hide()
                frmSales.Show()
            Else
                MsgBox("Login anda gagal!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            End If
        End If
    End Sub

    Private Sub txtPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.TextChanged

    End Sub
End Class