Public Class PrintingQuotes
    Private Sub UpdateText(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged, TextBox1.TextChanged
        Dim quote As String = RichTextBox1.Text
        Dim speaker As String = TextBox1.Text
        Label3.Text = speaker + " says, """ + quote + """"
    End Sub
End Class