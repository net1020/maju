Public Class frmMain

    Private Sub buttonExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonExit.Click
        End
    End Sub

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        tabStrip1.MdiForm = Me
        ribbon1.Enabled = False
        Dim doc1 As frmLogin = New frmLogin()
        doc1.Text = "Login"
        doc1.MdiParent = Me
        doc1.WindowState = FormWindowState.Maximized
        doc1.Show()
        doc1.Update()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim time As DateTime = DateTime.Now
        Dim format As String = "dd MMMM yyyy HH:mm:ss"
        labelStatus.Text = time.ToString(format)
    End Sub


    Private Sub ButtonItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem13.Click
        Dim doc1 As frmUserList = New frmUserList()
        doc1.Text = "User"
        doc1.MdiParent = Me
        doc1.WindowState = FormWindowState.Maximized
        doc1.Show()
        doc1.Update()
    End Sub
End Class