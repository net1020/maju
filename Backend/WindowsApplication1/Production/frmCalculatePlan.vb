
Imports System.Net
Imports Newtonsoft.Json
Imports System.Drawing
Imports System.Drawing.Printing

Public Class frmCalculatePlan

    Dim RowIndex As Integer
    Dim ColumnIndex As Integer
    Dim TotalAmount As Double
    Dim TotalAmount2 As Double
    Dim GrandTotal As Double
    Dim editForm As Boolean

    Private Sub DataGridViewX1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridX1.CellDoubleClick
        frmCalculateForm.t1.Text = GridX1.Item(1, GridX1.CurrentRow.Index).Value
        frmCalculateForm.t2.Text = GridX1.Item(2, GridX1.CurrentRow.Index).Value

        frmCalculateForm.ShowDialog()
        If frmCalculateForm.CancelForm = False Then
            GridX1.Rows.Add("", frmCalculateForm.t1.Text, frmCalculateForm.t2.Text)
        End If
    End Sub


    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        On Error Resume Next
        Dim links As String
        Dim Y As Integer
        Dim wc As New WebClient()
        gridX3.Rows.Clear()

        For Y = 0 To GridX1.Rows.Count - 2

            links = "all.php?q=35&q2=" & GridX1.Item(1, Y).Value & "|" & GridX1.Item(2, Y).Value

            Dim json = wc.DownloadString(url & links)
            Dim dataX As List(Of clsReport) = JsonConvert.DeserializeObject(Of List(Of clsReport))(json)
            Dim i As Integer
            For i = 0 To dataX.Count - 1
                gridX3.Rows.Add("", dataX.Item(i).f1, dataX.Item(i).f2, dataX.Item(i).f3, dataX.Item(i).f4, dataX.Item(i).f5, dataX.Item(i).f6, dataX.Item(i).f7, dataX.Item(i).f8, dataX.Item(i).f9, dataX.Item(i).f10, dataX.Item(i).f11, dataX.Item(i).f12, dataX.Item(i).f13)
            Next
        Next

        Calculate_Machine()
        tabs.SelectedTabIndex = 2
        dt1.Text = ConvertTimestamp2(Start_date())
        dt2.Text = ConvertTimestamp2(End_date())
        Create_daterow()
    End Sub

    Sub Calculate_Machine()

        Dim X, X2 As Integer

        For X = 0 To gridX3.RowCount - 2
            For X2 = X + 1 To gridX3.RowCount - 2
                If gridX3.Item(4, X).Value = gridX3.Item(4, X2).Value Then
                    gridX3.Item(7, X2).Value = gridX3.Item(9, X).Value
                    gridX3.Item(8, X2).Value = gridX3.Item(10, X).Value
                    gridX3.Item(11, X2).Value = gridX3.Item(12, X).Value

                    gridX3.Item(9, X2).Value = ConvertTimestamp(gridX3.Item(12, X).Value + (gridX3.Item(13, X2).Value * 3600)).ToString("dd-MM-yyyy")
                    gridX3.Item(10, X2).Value = ConvertTimestamp(gridX3.Item(12, X).Value + (gridX3.Item(13, X2).Value * 3600)).ToString("HH:mm")
                    gridX3.Item(12, X2).Value = gridX3.Item(12, X).Value + (gridX3.Item(13, X2).Value * 3600)
                    Exit For
                End If
            Next
        Next

    End Sub

    Function Start_date() As Double
        Dim X As Integer
        Start_date = gridX3.Item(11, 0).Value
        For X = 0 To gridX3.RowCount - 2
            If Val(gridX3.Item(11, X + 1).Value) <> 0 Then
                If Start_date > gridX3.Item(11, X + 1).Value Then
                    Start_date = gridX3.Item(11, X + 1).Value
                End If
            End If
        Next

    End Function

    Function End_date() As Double
        Dim X As Integer
        End_date = gridX3.Item(12, 0).Value
        For X = 0 To gridX3.RowCount - 2
            If Val(gridX3.Item(12, X + 1).Value) <> 0 Then
                If gridX3.Item(12, X + 1).Value > End_date Then
                    End_date = gridX3.Item(12, X + 1).Value
                End If
            End If
        Next
    End Function

    Sub Create_daterow()
        Dim dtDiff As Long = DateDiff("d", dt1.Text, dt2.Text)
        Dim X As Integer
        Dim today As System.DateTime
        today = dt1.Value
        gridX2.Rows.Clear()
        For X = 0 To dtDiff
            gridX2.Rows.Add("", today.AddDays(X).ToString("dd/MM/yyyy"), True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True)
        Next
    End Sub

    Private Sub cmdRemove_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdRemove.Click
        GridX1.Rows.RemoveAt(GridX1.CurrentRow.Index)
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Function timetounix(ByVal date1 As DateTime) As Integer
        timetounix = (date1 - New DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds
    End Function
    
    Function ConvertTimestamp(ByVal timestamp As Double) As DateTime
        Return New DateTime(1970, 1, 1, 0, 0, 0).AddSeconds(timestamp)
    End Function

    Function ConvertTimestamp2(ByVal timestamp As Double) As DateTime
        Return New DateTime(1970, 1, 1, 0, 0, 0).AddSeconds(timestamp)
    End Function

    Private Sub cmdRemove3_Click1(ByVal sender As Object, ByVal e As System.EventArgs)
        gridX3.Rows.RemoveAt(gridX3.CurrentRow.Index)
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Create_daterow()
        create_Result()
    End Sub

    Sub Create_Result()
        Dim J As Integer
        For J = 0 To gridX3.RowCount - 2
            For J2 = 1 To gridX3.Item(13, J).Value
                gridX5.Rows.Add("", gridX3.Item(1, J).Value, gridX3.Item(2, J).Value, gridX3.Item(3, J).Value, gridX3.Item(4, J).Value, gridX3.Item(6, J).Value, gridX3.Item(7, J).Value, gridX3.Item(8, J).Value, gridX3.Item(11, J).Value)
            Next
        Next
    End Sub

    Private Sub btnAll_Disposed(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub gridX2_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridX2.CellClick
        
    End Sub

    Private Sub gridX2_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridX2.CellContentClick

    End Sub

    Private Sub gridX2_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridX2.CellEnter
       
    End Sub

    Private Sub gridX2_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles gridX2.CellMouseClick
        
    End Sub

    Private Sub gridX2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridX2.Click


    End Sub

    Private Sub gridX2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gridX2.MouseUp

    End Sub
End Class
