Public Class Form1
    Dim radius As Double
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        lblOutput.Text = "You picked " & radius & " as your radius."
    End Sub

    Private Sub TrackBar2_Scroll(sender As Object, e As EventArgs) Handles trcRadius.Scroll
        txtInput.Text = CStr(trcRadius.Value)
        radius = trcRadius.Value

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtInput.TextChanged

    End Sub
End Class
