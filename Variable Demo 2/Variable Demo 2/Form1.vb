Class Form1


    Private Sub btnShowName_Click(sender As Object, e As EventArgs) Handles btnShowName.Click
        'Declare a string variable to hold FirstNameTextBox.
        Dim strFullName As String
        'Combine()FirstNameTextBox and LastNameTe'xtBox and 
        strFullName = harold.Text & " " & txtLastName.Text

        lblFullName.Text = strFullName
    End Sub
end Class
