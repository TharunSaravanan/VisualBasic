' Converts user entered numbers in a textbox from string to integer and prints it out in a rich textbox


Public Class Form1
    Dim newArray(4) As Integer
    Dim Numbers As Integer
    Dim Index As Integer
    Dim Temp As String
    Dim a As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Index = 0
        Temp = ""
        For n = 0 To txtNumbers.TextLength - 1
            If txtNumbers.Text(n) = "," Then
                newArray(Index) = Convert.ToInt32(Temp)
                Temp = ""
                Index = Index + 1

            Else
                Temp = Temp + txtNumbers.Text(n)
            End If

        Next
        'to move the final number
        newArray(Index) = Convert.ToInt32(Temp)

        For i = 0 To newArray.Length - 1
            rtMain.AppendText(newArray(i) & vbNewLine)
        Next


    End Sub

End Class
