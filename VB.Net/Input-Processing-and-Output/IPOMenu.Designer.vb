<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class IPOMenu
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
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(14, 14)
        Button1.Margin = New Padding(4, 3, 4, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(304, 27)
        Button1.TabIndex = 1
        Button1.Text = "Counting the Number of Characters"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(14, 47)
        Button2.Margin = New Padding(4, 3, 4, 3)
        Button2.Name = "Button2"
        Button2.Size = New Size(304, 27)
        Button2.TabIndex = 2
        Button2.Text = "Printing Quotes"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(14, 81)
        Button3.Margin = New Padding(4, 3, 4, 3)
        Button3.Name = "Button3"
        Button3.Size = New Size(304, 27)
        Button3.TabIndex = 3
        Button3.Text = "Mad Lib"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(14, 114)
        Button4.Margin = New Padding(4, 3, 4, 3)
        Button4.Name = "Button4"
        Button4.Size = New Size(304, 27)
        Button4.TabIndex = 4
        Button4.Text = "Retirement Calculator"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' IPOMenu
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(336, 156)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Margin = New Padding(4, 3, 4, 3)
        Name = "IPOMenu"
        Text = "IPO"
        ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
