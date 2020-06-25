Public Class Sumfrm
    Private Sub sumBtn_Click(sender As Object, e As EventArgs) Handles sumBtn.Click
        Dim result As Integer

        result = CDbl(txtFirstNum.Text) + CDbl(txtSecondNum.Text)

        txtResult.Text = result.ToString()
    End Sub
End Class
