<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CompoundInterest
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
        TableLayoutPanel1 = New TableLayoutPanel()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        NumericUpDown1 = New NumericUpDown()
        NumericUpDown2 = New NumericUpDown()
        NumericUpDown3 = New NumericUpDown()
        NumericUpDown4 = New NumericUpDown()
        Label1 = New Label()
        Button1 = New Button()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        GroupBox1 = New GroupBox()
        TableLayoutPanel1.SuspendLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown3, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown4, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 22.6980724F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 77.3019257F))
        TableLayoutPanel1.Controls.Add(Label4, 1, 3)
        TableLayoutPanel1.Controls.Add(Label3, 1, 2)
        TableLayoutPanel1.Controls.Add(Label2, 1, 1)
        TableLayoutPanel1.Controls.Add(NumericUpDown1, 0, 0)
        TableLayoutPanel1.Controls.Add(NumericUpDown2, 0, 1)
        TableLayoutPanel1.Controls.Add(NumericUpDown3, 0, 2)
        TableLayoutPanel1.Controls.Add(NumericUpDown4, 0, 3)
        TableLayoutPanel1.Controls.Add(Label1, 1, 0)
        TableLayoutPanel1.Location = New Point(9, 102)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 4
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 25.0F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 25.0F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 25.0F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 25.0F))
        TableLayoutPanel1.Size = New Size(467, 112)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Location = New Point(109, 90)
        Label4.Name = "Label4"
        Label4.Size = New Size(355, 15)
        Label4.TabIndex = 7
        Label4.Text = "What is the number of times the interest is compounded per year?"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Location = New Point(109, 62)
        Label3.Name = "Label3"
        Label3.Size = New Size(355, 15)
        Label3.TabIndex = 6
        Label3.Text = "What is the number of years?"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Location = New Point(109, 34)
        Label2.Name = "Label2"
        Label2.Size = New Size(355, 15)
        Label2.TabIndex = 5
        Label2.Text = "What is the rate?"
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        NumericUpDown1.DecimalPlaces = 2
        NumericUpDown1.Location = New Point(3, 3)
        NumericUpDown1.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(100, 23)
        NumericUpDown1.TabIndex = 0
        NumericUpDown1.TextAlign = HorizontalAlignment.Center
        NumericUpDown1.ThousandsSeparator = True
        ' 
        ' NumericUpDown2
        ' 
        NumericUpDown2.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        NumericUpDown2.DecimalPlaces = 1
        NumericUpDown2.Location = New Point(3, 31)
        NumericUpDown2.Name = "NumericUpDown2"
        NumericUpDown2.Size = New Size(100, 23)
        NumericUpDown2.TabIndex = 1
        NumericUpDown2.TextAlign = HorizontalAlignment.Center
        NumericUpDown2.ThousandsSeparator = True
        ' 
        ' NumericUpDown3
        ' 
        NumericUpDown3.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        NumericUpDown3.Location = New Point(3, 59)
        NumericUpDown3.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        NumericUpDown3.Name = "NumericUpDown3"
        NumericUpDown3.Size = New Size(100, 23)
        NumericUpDown3.TabIndex = 2
        NumericUpDown3.TextAlign = HorizontalAlignment.Center
        NumericUpDown3.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' NumericUpDown4
        ' 
        NumericUpDown4.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        NumericUpDown4.Location = New Point(3, 87)
        NumericUpDown4.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        NumericUpDown4.Name = "NumericUpDown4"
        NumericUpDown4.Size = New Size(100, 23)
        NumericUpDown4.TabIndex = 3
        NumericUpDown4.TextAlign = HorizontalAlignment.Center
        NumericUpDown4.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Location = New Point(109, 6)
        Label1.Name = "Label1"
        Label1.Size = New Size(355, 15)
        Label1.TabIndex = 4
        Label1.Text = "What is the principal amount?"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(12, 218)
        Button1.Name = "Button1"
        Button1.Size = New Size(461, 23)
        Button1.TabIndex = 1
        Button1.Text = "Calculate"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Checked = True
        RadioButton1.Location = New Point(20, 22)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(387, 19)
        RadioButton1.TabIndex = 2
        RadioButton1.TabStop = True
        RadioButton1.Text = "I want to know how much money I'll get after my investment period."
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(20, 47)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(418, 19)
        RadioButton2.TabIndex = 3
        RadioButton2.Text = "I want to know how much money I'll need to invest to reach a certain goal."
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.Controls.Add(RadioButton2)
        GroupBox1.Location = New Point(9, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(467, 79)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        GroupBox1.Text = "What would you like to do?"
        ' 
        ' CompoundInterest
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(484, 249)
        Controls.Add(GroupBox1)
        Controls.Add(Button1)
        Controls.Add(TableLayoutPanel1)
        Name = "CompoundInterest"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Determining Compound Interest"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown3, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown4, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents NumericUpDown3 As NumericUpDown
    Friend WithEvents NumericUpDown4 As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
End Class
