Public Class PaintCalculator
    Private _area = 1, _gallons = 1, _plurality = ""
    Private Const GALLONS = 350 'Square Feet

    Private Sub UpdateOnChange(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged, RadioButton3.CheckedChanged, NumericUpDown1.ValueChanged, NumericUpDown2.ValueChanged, NumericUpDown3.ValueChanged, NumericUpDown4.ValueChanged
        If NumericUpDown1.Value <> 0 And NumericUpDown2.Value <> 0 And NumericUpDown3.Value <> 0 And NumericUpDown4.Value <> 0 Then
            If RadioButton1.Checked Then
                _area = Rectangular()
            ElseIf RadioButton2.Checked Then
                _area = Round()
            Else
                _area = LShaped()
            End If

            _gallons = Math.Ceiling(_area / GALLONS)
            _plurality = If(_gallons <= 1, "gallon", "gallons")
        End If

        TextBox1.Text = $"You will need to purchase {_gallons} {_plurality} of paint to cover {_area:F0} square feet."
    End Sub

    Private Function Rectangular()
        Label1.Text = "Length"
        Label2.Text = "Width"
        Label2.Visible = True
        NumericUpDown2.Visible = True
        Label3.Visible = False
        NumericUpDown3.Visible = False
        Label4.Visible = False
        NumericUpDown4.Visible = False

        Dim _length As Integer = NumericUpDown1.Value
        Dim _width As Integer = NumericUpDown2.Value
        Return _length * _width
    End Function

    Private Function Round()
        Label1.Text = "Radius"
        Label2.Visible = False
        NumericUpDown2.Visible = False
        Label3.Visible = False
        NumericUpDown3.Visible = False
        Label4.Visible = False
        NumericUpDown4.Visible = False

        Dim _radius As Integer = NumericUpDown1.Value
        Return Math.PI * _radius
    End Function

    Private Function LShaped()
        Label1.Text = "Length 1"
        Label2.Text = "Width 1"
        Label2.Visible = True
        NumericUpDown2.Visible = True
        Label3.Visible = True
        NumericUpDown3.Visible = True
        Label4.Visible = True
        NumericUpDown4.Visible = True

        Dim _length1 As Integer = NumericUpDown1.Value
        Dim _width1 As Integer = NumericUpDown2.Value
        Dim _length2 As Integer = NumericUpDown3.Value
        Dim _width2 As Integer = NumericUpDown4.Value
        Return (_length1 * _width1) + (_length2 * _width2)
    End Function
End Class