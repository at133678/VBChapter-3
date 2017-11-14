Public Class Form1

    Private Sub btnCalculateChanges_Click(sender As Object, e As EventArgs) Handles btnCalculateChanges.Click
        ' Declare variables fr the calculations.
        Dim lblRoomCharges As Decimal           ' Room charges total
        Dim lblAddCharges                       ' Additional charges
        Dim lblSubtotal As Decimal              ' Subtotal
        Dim lblTax As Decimal                   'Tax
        Dim lblTotal As Decimal                   'Total of all cahrges
        Const lblTAX_RATE As Decimal = 0.08D   'Tax rate

        'lblStatus.Text = String.Empty
        Try
            'Calculate and display the room changes.
            txtRoomCharges = CDec(txtMiscNights.Text) *
                CDec(txtNightlyChrges.Text)
            lblRoomCharges = txtRoomCharges.ToString("c")

            'Calculate and desplay the additional charges.' 
            txtAddCharges = (txtRoomService.Text) + CDec(txtTelephone.Text) + CDec(txtMisc.Text)
            lblAddCharges.Text()
    End Sub
End Class
