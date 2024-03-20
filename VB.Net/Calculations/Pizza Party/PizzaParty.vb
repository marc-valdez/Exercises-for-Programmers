Public Class PizzaParty
    Private _people, _pizzas, _slices, _pieces, _leftovers As Integer

    Private Sub NumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_people.ValueChanged, NumericUpDown_q1.ValueChanged, NumericUpDown_q2.ValueChanged
        _people = NumericUpDown_people.Value
        UpdateData()
        UpdateQuestionText()
        UpdateOutputText()
    End Sub

    Private Sub RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged
        UpdateData()
        UpdateQuestionText()
        UpdateOutputText()
    End Sub

    Private Sub UpdateQuestionText()
        If RadioButton1.Checked Then
            Q1.Text = "How many pizzas do you have?"
            Q2.Text = "How many slices per pizza?"
        Else
            Q1.Text = "How many slices does each person want?"
            Q2.Text = "How many slices are there per pizza?"
        End If
    End Sub

    Private Sub UpdateOutputText()
        If RadioButton1.Checked Then
            If _pieces = 0 Then
                TextBox1.Text = "There aren't enough slices of pizza."
            ElseIf _pieces = 1 Then
                TextBox1.Text = "Each person gets a piece of pizza."
            Else
                TextBox1.Text = $"Each person gets {_pieces} pieces of pizza."
            End If

            If _leftovers = 0 Then
                TextBox2.Text = "There are no leftovers."
            ElseIf _leftovers = 1 Then
                TextBox2.Text = "There is one leftover piece."
            Else
                TextBox2.Text = $"There are {_leftovers} leftover pieces."
            End If
        Else
            If _pieces = 1 Then
                TextBox1.Text = "You need to buy one full pizza."
            Else
                TextBox1.Text = $"You need to buy {_pizzas} full pizzas."
            End If

            If _leftovers = 0 Then
                TextBox2.Text = "There will be no leftovers."
            ElseIf _leftovers = 1 Then
                TextBox2.Text = "There will be one leftover."
            Else
                TextBox2.Text = $"There will be {_leftovers} leftover pieces."
            End If
        End If
    End Sub

    Private Sub UpdateData()
        If RadioButton1.Checked Then
            _pizzas = NumericUpDown_q1.Value
            _slices = NumericUpDown_q2.Value * _pizzas

            _pieces = Math.Floor(_slices / _people)
            _leftovers = _slices Mod _people
        Else
            _pieces = NumericUpDown_q1.Value * _people
            _slices = NumericUpDown_q2.Value

            If _slices = 0 Then
                _pizzas = 0
                _leftovers = 0
            Else
                _pizzas = Math.Ceiling(_pieces / _slices)
                _leftovers = _pizzas * _slices - _pieces
            End If
        End If
    End Sub
End Class