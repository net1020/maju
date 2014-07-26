Imports System.Net
Imports Newtonsoft.Json
Imports System.Drawing
Imports System.Drawing.Printing

Public Class frmItems

   
    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Dim adnet As adnetObj.frmList = New adnetObj.frmList()
        adnet.UrlClient = url
        adnet.newForm = False
        adnet.grid("Category")
        adnet.Text = "Category"
        adnet.Show()
        adnet.Update()
    End Sub
End Class