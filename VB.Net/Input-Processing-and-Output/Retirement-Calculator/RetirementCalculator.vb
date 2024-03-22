Public Class RetirementCalculator
    Private Sub GetInfo(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged, NumericUpDown2.ValueChanged
        Dim _currentAge As Byte = NumericUpDown1.Value
        Dim _ageTarget As Byte = NumericUpDown2.Value

        Dim ageDiff As Byte = _ageTarget - _currentAge
        If ageDiff <= 0 Then
            Label3.Text = "You can already retire."
        Else
            Label3.Text = $"You have {ageDiff} years left until you can retire." & vbCrLf &
                          $"It's {DateTime.Now.Year}, so you can retire in {DateTime.Now.Year + (ageDiff)}."
        End If
    End Sub
End Class