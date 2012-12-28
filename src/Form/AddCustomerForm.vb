Public Class AddCustomerForm

    Private Sub OkButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OkButton.Click

        If NameTextBox.Text <> "" And AddressTextBox.Text <> "" And PostalCodeTextBox.Text <> "" And IsNumeric(RegNumberTextBox.Text) Then
            CustomersTableAdapter.InsertQuery(NameTextBox.Text, AddressTextBox.Text, PostalCodeTextBox.Text, RegNumberTextBox.Text)
            CustomersBindingSource.EndEdit()

            CustomersTableAdapter.Update(CustomerItemsDataSet)
            Me.Close()
        End If

    End Sub

    Private Sub AddCustomerForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CustomerItemsDataSet.customers' table. You can move, or remove it, as needed.
        'Me.CustomersTableAdapter.Fill(Me.CustomerItemsDataSet.customers)

    End Sub
End Class