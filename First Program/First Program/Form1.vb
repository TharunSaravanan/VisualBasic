Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        lblShowText.Text = txtName.Text.ToUpper
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If (txtName.Text.Length = 0) Then
            MessageBox.Show("Enter a name!")
        Else
            MessageBox.Show("Welcome " + txtName.Text)
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
