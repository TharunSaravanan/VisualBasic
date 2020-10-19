Public Class Form1
    Dim Num1 As Integer
    Dim Num2 As Integer
    Private Sub btnCalc_Click_1(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim Num1 As Integer = Integer.Parse(txtFirst.Text)
        Dim Num2 As Integer = Integer.Parse(txtSecond.Text)

        If Num1 > Num2 Then
            Label4.Text = (Num1) & " (first number) is bigger than " & (Num2) & " (second number)"
        Else
            Label4.Text = (Num2) & " (second number) is bigger than " & (Num1) & " (first number)"
        End If


    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
