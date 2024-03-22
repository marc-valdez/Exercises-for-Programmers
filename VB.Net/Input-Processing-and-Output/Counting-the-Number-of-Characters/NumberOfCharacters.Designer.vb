<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NumberOfCharacters
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        RichTextBox1 = New RichTextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(14, 152)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(106, 15)
        Label1.TabIndex = 1
        Label1.Text = "Character Count: 0"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(14, 14)
        RichTextBox1.Margin = New Padding(4, 3, 4, 3)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(417, 134)
        RichTextBox1.TabIndex = 2
        RichTextBox1.Text = ""
        ' 
        ' NumberOfCharacters
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(446, 178)
        Controls.Add(RichTextBox1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        MinimizeBox = False
        Name = "NumberOfCharacters"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Counting the Number of Characters"
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
