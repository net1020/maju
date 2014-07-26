Imports Newtonsoft.Json
Imports System.Net
Module modLoad
    Public cmb_Product As List(Of clsCombo2)
    Public cmb_Price As List(Of clsviewProduct)
    Sub combo_product()
        Dim wc As New WebClient()
        Dim json = wc.DownloadString(Url & "load.php?u=" & userName & "&c=" & compName & "&q=104")
        Dim data As List(Of clsCombo2) = JsonConvert.DeserializeObject(Of List(Of clsCombo2))(json)
        cmb_Product = data
    End Sub

    Sub combo_price()
        Dim wc As New WebClient()
        Dim json = wc.DownloadString(Url & "load.php?u=" & userName & "&c=" & compName & "&q=110")
        Dim data As List(Of clsviewProduct) = JsonConvert.DeserializeObject(Of List(Of clsviewProduct))(json)
        cmb_Price = data
    End Sub
End Module
