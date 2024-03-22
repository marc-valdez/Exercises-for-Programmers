<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SelfCheckout
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
        ItemList = New DataGridView()
        Price = New DataGridViewTextBoxColumn()
        Quantity = New DataGridViewTextBoxColumn()
        Button1 = New Button()
        Button2 = New Button()
        CType(ItemList, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ItemList
        ' 
        ItemList.AllowUserToDeleteRows = False
        ItemList.AllowUserToResizeColumns = False
        ItemList.AllowUserToResizeRows = False
        ItemList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        ItemList.Columns.AddRange(New DataGridViewColumn() {Price, Quantity})
        ItemList.Cursor = Cursors.IBeam
        ItemList.EditMode = DataGridViewEditMode.EditOnEnter
        ItemList.Location = New Point(12, 12)
        ItemList.MultiSelect = False
        ItemList.Name = "ItemList"
        ItemList.RowHeadersVisible = False
        ItemList.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        ItemList.RowTemplate.Resizable = DataGridViewTriState.False
        ItemList.ScrollBars = ScrollBars.Vertical
        ItemList.SelectionMode = DataGridViewSelectionMode.CellSelect
        ItemList.Size = New Size(220, 125)
        ItemList.TabIndex = 0
        ' 
        ' Price
        ' 
        Price.Frozen = True
        Price.HeaderText = "Price"
        Price.Name = "Price"
        ' 
        ' Quantity
        ' 
        Quantity.Frozen = True
        Quantity.HeaderText = "Quantity"
        Quantity.Name = "Quantity"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(12, 143)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 1
        Button1.Text = "Add Item"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(158, 143)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 2
        Button2.Text = "Checkout"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' SelfCheckout
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(245, 176)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(ItemList)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "SelfCheckout"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Self-Checkout"
        CType(ItemList, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents ItemList As DataGridView
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
