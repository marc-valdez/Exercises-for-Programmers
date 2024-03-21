Public Class SelfCheckout

    Private Const TAX = 0.055

    Private Sub On_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each column As DataGridViewColumn In ItemList.Columns
            column.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
        ItemList.RowCount = 3
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ItemList.Rows.Add()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim _total, _subtotal, _tax As Decimal
        For Each row As DataGridViewRow In ItemList.Rows
            Dim price As Decimal = 0.0
            Dim quantity As Integer = 0

            If Decimal.TryParse(row.Cells("Price").Value?.ToString(), price) AndAlso
               Integer.TryParse(row.Cells("Quantity").Value?.ToString(), quantity) Then
                _subtotal += price * quantity
            End If
        Next

        _tax = _subtotal * TAX
        _total = _subtotal + _tax

        Dim MessageString As New Text.StringBuilder
        MessageString.Append($"Subtotal: ${_subtotal:F2}" & vbCrLf)
        MessageString.Append($"Tax: ${_tax:F2}" & vbCrLf)
        MessageString.Append($"Total: ${_total:F2}")

        MessageBox.Show(MessageString.ToString, "Basket", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class