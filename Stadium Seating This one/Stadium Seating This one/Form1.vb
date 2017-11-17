Public Class Form1

    Private Sub CalculateRevenue1_Click(sender As Object, e As EventArgs) Handles CalculateRevenue1.Click
        Dim classA, classB, classC, total As Double

        classA = CDbl(TextBox1.Text) * 15
        Label1.Text = classA
        classB = CDbl(TextBox2.Text) * 12
        Label2.Text = classB
        classC = CDbl(TextBox3.Text) * 9
        Label3.Text = classC

        total = classA + classB + classC

        Label4.Text = total.ToString("c")
    End Sub

    Private Sub Clear2_Click(sender As Object, e As EventArgs) Handles Clear2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub

    Private Sub Exit3_Click(sender As Object, e As EventArgs) Handles Exit3.Click
        Me.Close()
    End Sub
End Class
