Public Class NumberOfCharacters
    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        Dim UserInput As String = RichTextBox1.Text
        Label1.Text = $"Character Count: {UserInput.Length}"
    End Sub
End Class