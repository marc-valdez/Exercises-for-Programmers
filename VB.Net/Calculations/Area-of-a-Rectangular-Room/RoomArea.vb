Public Class RoomArea
    Private _length As Double
    Private _width As Double
    Private _area As Double
    Private _convertedArea As Double
    Private Const CONVERSION_FACTOR = 0.09290304F

    Private Sub GetUserInput(sender As Object, e As EventArgs) Handles RadioButton1.Click, RadioButton2.Click, NumericUpDown1.TextChanged, NumericUpDown2.TextChanged
        _length = NumericUpDown1.Value
        _width = NumericUpDown2.Value
        UpdateText()
    End Sub

    Private Sub CalculateArea()
        _area = _length * _width
    End Sub

    Private Sub UpdateText()
        If RadioButton1.Checked Then
            CalculateArea()
            TextBox1.Text = $"{_area:F4} ft²"
            TextBox2.Text = $"{_area * CONVERSION_FACTOR:F4} m²"
        ElseIf RadioButton2.Checked Then
            CalculateArea()
            TextBox2.Text = $"{_area:F4} m²"
            TextBox1.Text = $"{_area / CONVERSION_FACTOR:F4} ft²"
        End If
    End Sub
End Class