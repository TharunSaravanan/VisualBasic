Public Class frmMain

    Dim number1 As Integer
    Dim number2 As Integer
    Dim answer As Decimal
    Dim op As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        number2 = Integer.Parse(txtDisplay.Text)
        If op = "+" Then
            answer = number1 + number2

            txtDisplay.Text = answer

        ElseIf op = "-" Then
            answer = number1 - number2

            txtDisplay.Text = answer
        ElseIf op = "*" Then
            answer = number1 * number2

            txtDisplay.Text = answer

        ElseIf op = "/" Then
            answer = number1 / number2

            txtDisplay.Text = answer
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtDisplay.Text = txtDisplay.Text + "1"
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        op = "+"
        number1 = Integer.Parse(txtDisplay.Text)
        txtDisplay.Text = ""
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        op = "-"
        number1 = Integer.Parse(txtDisplay.Text)
        txtDisplay.Text = ""
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs)
        op = "*"
        number1 = Integer.Parse(txtDisplay.Text)
        txtDisplay.Text = ""
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txtDisplay.Text = txtDisplay.Text + "6"
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs)
        op = "/"
        number1 = Integer.Parse(txtDisplay.Text)
        txtDisplay.Text = ""
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtDisplay.Text = txtDisplay.Text + "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtDisplay.Text = txtDisplay.Text + "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txtDisplay.Text = txtDisplay.Text + "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtDisplay.Text = txtDisplay.Text + "5"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txtDisplay.Text = txtDisplay.Text + "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtDisplay.Text = txtDisplay.Text + "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtDisplay.Text = txtDisplay.Text + "9"
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txtDisplay.Text = txtDisplay.Text + "0"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        op = "/"
        number1 = Integer.Parse(txtDisplay.Text)
        txtDisplay.Text = ""
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        op = "*"
        number1 = Integer.Parse(txtDisplay.Text)
        txtDisplay.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDisplay.Text = ""

    End Sub
End Class
