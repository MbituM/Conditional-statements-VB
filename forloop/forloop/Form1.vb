Public Class Form1
    Private Sub btnmultiply_Click(sender As Object, e As EventArgs) Handles btnmultiply.Click
        Dim Ans, Num As Integer
        Num = 9
        For counter = 1 To 9
            Ans = counter * Num
            lbloutput.Text = lbloutput.Text & vbCr & counter & "*" & Num & "=" & Ans
        Next
    End Sub
End Class
