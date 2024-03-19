Public Class MadLib
    Private _noun As String = "{noun}"
    Private _verb As String = "{verb}"
    Private _adjective As String = "{adjective}"
    Private _adverb As String = "{adverb}"

    Public Sub UpdateText()
        RichTextBox1.Text = $"Do you {_verb} your {_adjective} {_noun} {_adverb}? That's hilarious!"
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        _noun = TextBox1.Text
        UpdateText()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        _verb = TextBox2.Text
        UpdateText()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        _adjective = TextBox3.Text
        UpdateText()
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        _adverb = TextBox4.Text
        UpdateText()
    End Sub
End Class