Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dblTotal As Double

        dblTotal = CDbl(TextBox1.Text) + CDbl(TextBox2.Text) + CDbl(TextBox3.Text) + CDbl(TextBox4.Text) + CDbl(TextBox5.Text)

        lblResult.Text = dblTotal / 5
    End Sub
End Class
