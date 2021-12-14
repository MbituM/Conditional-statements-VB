Public Class Form1
    Private Sub btndisplay_Click(sender As Object, e As EventArgs) Handles btndisplay.Click
        Dim i As Integer = 1
        Do While (i < 100)
            lstitems.Items.Add(i)
            i = i + 1
        Loop
    End Sub
End Class
