Imports System.Net
Imports Newtonsoft.Json
Module modMain
    Public url As String = My.Settings.url
    Public urlBrowse As String = My.Settings.browse
    Public userName As String = "Admin"
    Public userAccess As String
    Public compName As String = System.Net.Dns.GetHostName()

    Sub Inserted(ByVal modId As String, ByVal str As String)
        Dim wc As New WebClient()
        Dim json = wc.DownloadString(url & "all.php?q=" & modId & "&q2=" & str)
    End Sub

    Sub Updated(ByVal modId As String, ByVal str As String)
        Dim wc As New WebClient()
        Dim json = wc.DownloadString(url & "all.php?q=" & modId & "&q2=" & str)
    End Sub

    Sub Removed(ByVal modId As String, ByVal str As String)
        Dim wc As New WebClient()
        Dim json = wc.DownloadString(url & "all.php?q=" & modId & "&q2=" & str)
    End Sub
End Module
