Public Class Form1
    Private Sub Calc_Click(sender As Object, e As EventArgs) Handles Calc.Click
        Dim kb As Decimal = kilobytes.Text
        Dim time As Decimal = sTsime.Text
        Dim bits As Decimal = kb * 8000
        Dim bandwidth As Decimal = bits / time
        MessageBox.Show($"Bandwidth = {bandwidth} bps")
    End Sub
End Class
