Public Class CompoundInterest
    Private Sub RadioButtons(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged
        If RadioButton1.Checked Then
            Label1.Text = "What is the principal amount?"
        Else
            Label1.Text = "What is your goal amount?"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim _principalAmount = 0.0, _goal = 0.0
        If RadioButton1.Checked Then
            Label1.Text = "What is the principal amount?"
            _principalAmount = NumericUpDown1.Value
        Else
            Label1.Text = "What is your goal amount?"
            _goal = NumericUpDown1.Value
        End If

        Dim _annualRate As Single = NumericUpDown2.Value
        Dim _yearsInvested As Integer = NumericUpDown3.Value
        Dim _timesCompounded As Byte = NumericUpDown4.Value

        Dim incrementalFactor = 1 + (_annualRate / 100 / _timesCompounded)
        Dim exponent = _timesCompounded * _yearsInvested
        Dim compound = Math.Pow(incrementalFactor, exponent)

        Dim MessageText As New Text.StringBuilder
        If RadioButton1.Checked Then
            _goal = _principalAmount * compound
            MessageText.Append($"${_principalAmount:F2} invested at {_annualRate}% for {_yearsInvested} years, " & vbCrLf)
            MessageText.Append($"compounded {_timesCompounded} times per year is ${_goal:F2}.")
        Else
            _principalAmount = _goal / compound
            MessageText.Append($"To get ${_goal}, given the annual rate is {_annualRate}% for {_yearsInvested} years, compounded {_timesCompounded} times per year." & vbCrLf)
            MessageText.Append($"You need to invest a principal amount of ${_principalAmount:F2}.")
        End If

        MessageBox.Show(MessageText.ToString, "Results", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class