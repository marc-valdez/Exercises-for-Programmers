<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PizzaParty
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
        Label1 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        NumericUpDown_people = New NumericUpDown()
        Q1 = New Label()
        NumericUpDown_q1 = New NumericUpDown()
        Q2 = New Label()
        NumericUpDown_q2 = New NumericUpDown()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        GroupBox1 = New GroupBox()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TableLayoutPanel1.SuspendLayout()
        CType(NumericUpDown_people, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown_q1, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown_q2, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Left
        Label1.AutoSize = True
        Label1.Location = New Point(108, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(109, 15)
        Label1.TabIndex = 1
        Label1.Text = "How many people?"
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30.1724129F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 69.82758F))
        TableLayoutPanel1.Controls.Add(Label1, 1, 0)
        TableLayoutPanel1.Controls.Add(NumericUpDown_people, 0, 0)
        TableLayoutPanel1.Controls.Add(Q1, 1, 1)
        TableLayoutPanel1.Controls.Add(NumericUpDown_q1, 0, 1)
        TableLayoutPanel1.Controls.Add(Q2, 1, 2)
        TableLayoutPanel1.Controls.Add(NumericUpDown_q2, 0, 2)
        TableLayoutPanel1.Location = New Point(12, 99)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.Size = New Size(350, 121)
        TableLayoutPanel1.TabIndex = 2
        ' 
        ' NumericUpDown_people
        ' 
        NumericUpDown_people.Anchor = AnchorStyles.None
        NumericUpDown_people.Location = New Point(3, 8)
        NumericUpDown_people.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        NumericUpDown_people.Name = "NumericUpDown_people"
        NumericUpDown_people.Size = New Size(99, 23)
        NumericUpDown_people.TabIndex = 0
        NumericUpDown_people.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' Q1
        ' 
        Q1.Anchor = AnchorStyles.Left
        Q1.AutoSize = True
        Q1.Location = New Point(108, 52)
        Q1.Name = "Q1"
        Q1.Size = New Size(225, 15)
        Q1.TabIndex = 2
        Q1.Text = "How many slices does each person want?"
        ' 
        ' NumericUpDown_q1
        ' 
        NumericUpDown_q1.Anchor = AnchorStyles.None
        NumericUpDown_q1.Location = New Point(3, 48)
        NumericUpDown_q1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        NumericUpDown_q1.Name = "NumericUpDown_q1"
        NumericUpDown_q1.Size = New Size(99, 23)
        NumericUpDown_q1.TabIndex = 3
        NumericUpDown_q1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' Q2
        ' 
        Q2.Anchor = AnchorStyles.Left
        Q2.AutoSize = True
        Q2.Location = New Point(108, 93)
        Q2.Name = "Q2"
        Q2.Size = New Size(199, 15)
        Q2.TabIndex = 4
        Q2.Text = "How many slices are there per pizza?"
        ' 
        ' NumericUpDown_q2
        ' 
        NumericUpDown_q2.Anchor = AnchorStyles.None
        NumericUpDown_q2.Location = New Point(3, 89)
        NumericUpDown_q2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        NumericUpDown_q2.Name = "NumericUpDown_q2"
        NumericUpDown_q2.Size = New Size(99, 23)
        NumericUpDown_q2.TabIndex = 5
        NumericUpDown_q2.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Checked = True
        RadioButton1.Location = New Point(17, 22)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(322, 19)
        RadioButton1.TabIndex = 3
        RadioButton1.TabStop = True
        RadioButton1.Text = "I want to know how many slices each person should get."
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(17, 47)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(270, 19)
        RadioButton2.TabIndex = 4
        RadioButton2.Text = "I want to know how many pizzas I have to buy."
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.Controls.Add(RadioButton2)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(350, 81)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        GroupBox1.Text = "What would you like to do?"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(12, 226)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(350, 23)
        TextBox1.TabIndex = 6
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(12, 255)
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.Size = New Size(350, 23)
        TextBox2.TabIndex = 7
        ' 
        ' PizzaParty
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(373, 289)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(GroupBox1)
        Controls.Add(TableLayoutPanel1)
        Name = "PizzaParty"
        Text = "Pizza Party"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        CType(NumericUpDown_people, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown_q1, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown_q2, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents NumericUpDown_people As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents NumericUpDown_q2 As NumericUpDown
    Friend WithEvents Q2 As Label
    Friend WithEvents Q1 As Label
    Friend WithEvents NumericUpDown_q1 As NumericUpDown
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
End Class
