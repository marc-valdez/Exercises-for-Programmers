<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CalculationsMenu
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
        Button5 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(14, 14)
        Button1.Margin = New Padding(4, 3, 4, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(304, 27)
        Button1.TabIndex = 1
        Button1.Text = "Area of a Rectangle Room"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(14, 47)
        Button2.Margin = New Padding(4, 3, 4, 3)
        Button2.Name = "Button2"
        Button2.Size = New Size(304, 27)
        Button2.TabIndex = 2
        Button2.Text = "Pizza Party"
        Button2.UseMnemonic = False
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(14, 81)
        Button3.Margin = New Padding(4, 3, 4, 3)
        Button3.Name = "Button3"
        Button3.Size = New Size(304, 27)
        Button3.TabIndex = 3
        Button3.Text = "Paint Calculator"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(14, 114)
        Button4.Margin = New Padding(4, 3, 4, 3)
        Button4.Name = "Button4"
        Button4.Size = New Size(304, 27)
        Button4.TabIndex = 4
        Button4.Text = "Self-Checkout"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(14, 147)
        Button5.Margin = New Padding(4, 3, 4, 3)
        Button5.Name = "Button5"
        Button5.Size = New Size(304, 27)
        Button5.TabIndex = 5
        Button5.Text = "Determining Compound Interest"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' CalculationsMenu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(336, 189)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Margin = New Padding(4, 3, 4, 3)
        Name = "CalculationsMenu"
        Text = "Calculations"
        ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
