Public Class RetirementCalculator
    Private _currentAge As Short
    Private _ageTarget As Short

    Public Sub UpdateText()
        Dim ageDiff = _ageTarget - _currentAge
        If ageDiff <= 0 Then
            Label3.Text = "You can already retire."
        Else
            Label3.Text = $"You have {ageDiff} years left until you can retire." & vbCrLf &
                          $"It's {DateTime.Now.Year}, so you can retire in {DateTime.Now.Year + (ageDiff)}."
        End If
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        _currentAge = NumericUpDown1.Value
        UpdateText()
    End Sub

    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown2.ValueChanged
        _ageTarget = NumericUpDown2.Value
        UpdateText()
    End Sub
End Class