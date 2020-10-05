Public Class Form1
    Dim fact As Long
    Dim n As Long
    Dim intCount As Long
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        fact = 1
        n = Integer.Parse(txtFact.Text)
        For intCount = 1 To n
            fact = fact * intCount

        Next
        lblNumber.Text = fact
    End Sub
End Class
