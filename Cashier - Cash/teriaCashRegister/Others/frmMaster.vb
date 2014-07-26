Public Class frmMaster

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'SlidePanel1.SlideSide.Bottom()
        SlidePanel1.SlideSide = DevComponents.DotNetBar.Controls.eSlideSide.Left
        ' Bring To Front
        SlidePanel1.BringToFront() ' Hide it
        SlidePanel1.IsOpen = False

        'SlidePanel1.IsOpen = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        SlidePanel1.SlideSide = DevComponents.DotNetBar.Controls.eSlideSide.Left
        ' Bring To Front
        SlidePanel1.BringToFront() ' Hide it
        SlidePanel1.IsOpen = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
       
    End Sub
End Class