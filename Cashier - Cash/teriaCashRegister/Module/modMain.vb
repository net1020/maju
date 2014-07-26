
Imports System.Web
Imports System.Net
Imports System.IO
Imports System.Text
Imports Newtonsoft.Json

Module modMain
    Public X1, Y1 As Integer

    Public userName As String = "Admin"
    Public userType As String
    Public compName As String = System.Net.Dns.GetHostName()
    Public Port As String = My.Settings.port
    Public Url As String = My.Settings.url

    Public ViewProductName As String
    Public ViewProductCode As String
    Public ViewProductPrice As Decimal


    Public Sub AddTab(ByVal doc As Object, ByVal frmName As String)
        doc.Text = frmName
        doc.MdiParent = frmMain
        doc.WindowState = FormWindowState.Maximized
        doc.Show()
        doc.Update()
    End Sub

    Public Function SyncDB(ByVal Url As String, ByVal Dt As String) As String
        Dim s As HttpWebRequest
        Dim enc As UTF8Encoding
        Dim postdata As String
        Dim postdatabytes As Byte()
        s = HttpWebRequest.Create(Url)
        enc = New System.Text.UTF8Encoding()
        postdata = "q=" & HttpUtility.UrlEncode(Dt)
        postdatabytes = enc.GetBytes(postdata)
        s.Method = "POST"
        s.ContentType = "application/x-www-form-urlencoded"
        s.ContentLength = postdatabytes.Length

        Using stream = s.GetRequestStream()
            stream.Write(postdatabytes, 0, postdatabytes.Length)

        End Using
        'Dim result = s.GetResponse()
        Dim response As HttpWebResponse = s.GetResponse()
        Dim reader As New StreamReader(response.GetResponseStream())
        Dim tmp As String = reader.ReadToEnd()
        response.Close()
        SyncDB = tmp
    End Function

    Public Sub start_server()
        Try
            Dim procInfo As New ProcessStartInfo()
            procInfo.UseShellExecute = True
            procInfo.FileName = "install.bat"
            procInfo.WorkingDirectory = Application.StartupPath & "\adnet"
            procInfo.Verb = "runas"
            Process.Start(procInfo)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())

        End Try
    End Sub

End Module
