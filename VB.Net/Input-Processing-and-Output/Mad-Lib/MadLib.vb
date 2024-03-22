Public Class MadLib
    Private _noun As String = "{noun}"
    Private _verb As String = "{verb}"
    Private _adjective As String = "{adjective}"
    Private _adverb As String = "{adverb}"

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged, TextBox2.TextChanged, TextBox3.TextChanged, TextBox4.TextChanged
        _noun = TextBox1.Text
        _verb = TextBox2.Text
        _adjective = TextBox3.Text
        _adverb = TextBox4.Text

        RichTextBox1.Text = $"Did you know that a {_adjective} {_noun} can {_adverb} {_verb}? I know! It's crazy!"
    End Sub
End Class