<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RoomArea
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
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        GroupBox1 = New GroupBox()
        NumericUpDown1 = New NumericUpDown()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        NumericUpDown2 = New NumericUpDown()
        Label2 = New Label()
        GroupBox3 = New GroupBox()
        Label4 = New Label()
        Label3 = New Label()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        GroupBox1.SuspendLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(15, 22)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(47, 19)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "Feet"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(15, 47)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(61, 19)
        RadioButton2.TabIndex = 1
        RadioButton2.TabStop = True
        RadioButton2.Text = "Meters"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.Controls.Add(RadioButton2)
        GroupBox1.Location = New Point(15, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(89, 156)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Unit"
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.BackColor = SystemColors.Window
        NumericUpDown1.Cursor = Cursors.IBeam
        NumericUpDown1.DecimalPlaces = 2
        NumericUpDown1.Location = New Point(15, 22)
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(100, 23)
        NumericUpDown1.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(15, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(44, 15)
        Label1.TabIndex = 5
        Label1.Text = "Length"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(NumericUpDown2)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(NumericUpDown1)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Location = New Point(110, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(230, 75)
        GroupBox2.TabIndex = 6
        GroupBox2.TabStop = False
        GroupBox2.Text = "Inputs"
        ' 
        ' NumericUpDown2
        ' 
        NumericUpDown2.BackColor = SystemColors.Window
        NumericUpDown2.Cursor = Cursors.IBeam
        NumericUpDown2.DecimalPlaces = 2
        NumericUpDown2.Location = New Point(121, 22)
        NumericUpDown2.Name = "NumericUpDown2"
        NumericUpDown2.Size = New Size(100, 23)
        NumericUpDown2.TabIndex = 8
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(121, 48)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 15)
        Label2.TabIndex = 7
        Label2.Text = "Width"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(Label4)
        GroupBox3.Controls.Add(Label3)
        GroupBox3.Controls.Add(TextBox2)
        GroupBox3.Controls.Add(TextBox1)
        GroupBox3.Location = New Point(110, 93)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(230, 75)
        GroupBox3.TabIndex = 7
        GroupBox3.TabStop = False
        GroupBox3.Text = "Area"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(121, 48)
        Label4.Name = "Label4"
        Label4.Size = New Size(43, 15)
        Label4.TabIndex = 3
        Label4.Text = "Meters"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(15, 48)
        Label3.Name = "Label3"
        Label3.Size = New Size(29, 15)
        Label3.TabIndex = 2
        Label3.Text = "Feet"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(121, 22)
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 1
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(15, 22)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 0
        ' 
        ' RoomArea
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(353, 180)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "RoomArea"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Area of a Rectangular Room"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents NumericUpDown2 As NumericUpDown
End Class
