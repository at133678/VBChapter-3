Public Class Form1
    "Declare a class-level variable"
    Dim intValue As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim dblAnswer As Double
        Dim strResult As String

        dblAnswer = CDbl(txtUserEntry.Text)

        strResult = dblAnswer.ToString("n")
        lblResult.Text = strResult
    End Sub
    Dim dblAnswer As Double
    Dim strResult As String

        dblAnswer = CDbl(txtUserEntry.Text)

        strResult = dblAnswer.ToString("f")
        lblResult.Text = strResult

    Private Sub txtUserEntry_TextChanged(sender As Object, e As EventArgs) Handles txtUserEntry.TextChanged

    End Sub
End Class
