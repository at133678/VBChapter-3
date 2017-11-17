Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblTotle As Double
        dbLTotle = CDbl(lblCelsius.Text) * CDbl(lblFahrenheit.Text) + 32


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Converting_Celsius_to_Fahrenheit Clear
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me Close
    End Sub
End Class
