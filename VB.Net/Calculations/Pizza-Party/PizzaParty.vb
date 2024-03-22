Public Class PizzaParty
    Private _people = 1, _pizzas = 1, _slices = 1, _pieces = 1, _leftovers = 1

    Private Sub GetUserInput(sender As Object, e As EventArgs) Handles NumericUpDown_people.ValueChanged, NumericUpDown_q1.ValueChanged, NumericUpDown_q2.ValueChanged, RadioButton1.CheckedChanged, RadioButton2.CheckedChanged
        If NumericUpDown_people.Value <> 0 Then
            _people = NumericUpDown_people.Value
        End If

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
            If NumericUpDown_q1.Value <> 0 Then
                _pizzas = NumericUpDown_q1.Value
            End If
            If NumericUpDown_q2.Value <> 0 Then
                _slices = NumericUpDown_q2.Value * _pizzas
            End If

            _pieces = Math.Floor(_slices / _people)
            _leftovers = _slices Mod _people
        Else
            If NumericUpDown_q1.Value <> 0 Then
                _pieces = NumericUpDown_q1.Value * _people
            End If
            If NumericUpDown_q2.Value <> 0 Then
                _slices = NumericUpDown_q2.Value
            End If

            _pizzas = Math.Ceiling(_pieces / _slices)
            _leftovers = _pizzas * _slices - _pieces
        End If
    End Sub
End Class