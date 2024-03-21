<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaintCalculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        Label3 = New Label()
        Label4 = New Label()
        NumericUpDown3 = New NumericUpDown()
        NumericUpDown4 = New NumericUpDown()
        Label2 = New Label()
        Label1 = New Label()
        NumericUpDown2 = New NumericUpDown()
        NumericUpDown1 = New NumericUpDown()
        GroupBox2 = New GroupBox()
        TextBox1 = New TextBox()
        GroupBox3 = New GroupBox()
        RadioButton3 = New RadioButton()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        GroupBox1.SuspendLayout()
        CType(NumericUpDown3, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown4, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(NumericUpDown3)
        GroupBox1.Controls.Add(NumericUpDown4)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(NumericUpDown2)
        GroupBox1.Controls.Add(NumericUpDown1)
        GroupBox1.Location = New Point(12, 125)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(276, 121)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Measurements"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(139, 97)
        Label3.Name = "Label3"
        Label3.Size = New Size(48, 15)
        Label3.TabIndex = 7
        Label3.Text = "Width 2"
        Label3.Visible = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(139, 48)
        Label4.Name = "Label4"
        Label4.Size = New Size(53, 15)
        Label4.TabIndex = 6
        Label4.Text = "Length 2"
        Label4.Visible = False
        ' 
        ' NumericUpDown3
        ' 
        NumericUpDown3.DecimalPlaces = 2
        NumericUpDown3.Location = New Point(139, 71)
        NumericUpDown3.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        NumericUpDown3.Name = "NumericUpDown3"
        NumericUpDown3.Size = New Size(127, 23)
        NumericUpDown3.TabIndex = 5
        NumericUpDown3.Value = New Decimal(New Integer() {1, 0, 0, 0})
        NumericUpDown3.Visible = False
        ' 
        ' NumericUpDown4
        ' 
        NumericUpDown4.DecimalPlaces = 2
        NumericUpDown4.Location = New Point(139, 22)
        NumericUpDown4.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        NumericUpDown4.Name = "NumericUpDown4"
        NumericUpDown4.Size = New Size(127, 23)
        NumericUpDown4.TabIndex = 4
        NumericUpDown4.Value = New Decimal(New Integer() {1, 0, 0, 0})
        NumericUpDown4.Visible = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 97)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 15)
        Label2.TabIndex = 3
        Label2.Text = "Width"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(44, 15)
        Label1.TabIndex = 2
        Label1.Text = "Length"
        ' 
        ' NumericUpDown2
        ' 
        NumericUpDown2.DecimalPlaces = 2
        NumericUpDown2.Location = New Point(6, 71)
        NumericUpDown2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        NumericUpDown2.Name = "NumericUpDown2"
        NumericUpDown2.Size = New Size(127, 23)
        NumericUpDown2.TabIndex = 1
        NumericUpDown2.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.DecimalPlaces = 2
        NumericUpDown1.Location = New Point(6, 22)
        NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(127, 23)
        NumericUpDown1.TabIndex = 0
        NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(TextBox1)
        GroupBox2.Location = New Point(133, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(155, 107)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Recommendation"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(6, 21)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(143, 80)
        TextBox1.TabIndex = 0
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(RadioButton3)
        GroupBox3.Controls.Add(RadioButton1)
        GroupBox3.Controls.Add(RadioButton2)
        GroupBox3.Location = New Point(12, 12)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(115, 107)
        GroupBox3.TabIndex = 2
        GroupBox3.TabStop = False
        GroupBox3.Text = "Room Type"
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(14, 73)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(75, 19)
        RadioButton3.TabIndex = 2
        RadioButton3.Text = "L-Shaped"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Checked = True
        RadioButton1.Location = New Point(14, 23)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(88, 19)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "Rectangular"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(14, 48)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(60, 19)
        RadioButton2.TabIndex = 1
        RadioButton2.Text = "Round"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' PaintCalculator
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(299, 253)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "PaintCalculator"
        Text = "Paint Calculator"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(NumericUpDown3, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown4, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents NumericUpDown3 As NumericUpDown
    Friend WithEvents NumericUpDown4 As NumericUpDown
End Class
