Imports Prover.Model

Public Class Customer
    Implements ICustomers

    Private _customer As Prover.Model.customer
    Private _Name As String
    Private _Id As Integer
    Private _Address As String
    Private _InspectionID As Integer
    Private _InspectionCount As Integer
    Private _ApparatusId As String
    Private _PostalCode As String
    Private _RegNumber As Integer

    Private _WriteBeforeItems As New Collection
    Private _WriteBeforeValues As New Collection
    Private _WriteAfterItems As New Collection
    Private _WriteAfterValues As New Collection
    Private _ItemDescriptions As New Collection

    'Private _Instrument As Instrument

    Sub New(Customer As Prover.Model.customer)
        _customer = Customer
    End Sub

    Public ReadOnly Property CustomerName() As String Implements ICustomers.CustomerName
        Get
            Return _customer.name
        End Get
    End Property

    Public ReadOnly Property CustomerAddress() As String Implements ICustomers.CustomerAddress
        Get
            Return _customer.address
        End Get
    End Property

    Public ReadOnly Property WriteAfterItems() As Collection Implements ICustomers.WriteAfterItems
        Get
            Return _customer.write_items
        End Get
    End Property

    Public Overridable ReadOnly Property WriteAfterValues() As Collection Implements ICustomers.WriteAfterValues
        Get
            Return _WriteAfterValues
        End Get
    End Property

    Public ReadOnly Property ItemDescriptions() As Collection Implements ICustomers.ItemDescriptions
        Get
            Return _ItemDescriptions
        End Get

    End Property

    'Public Property Instrument() As Instrument
    '    Get
    '        Return _Instrument
    '    End Get
    '    Set(ByVal value As Instrument)
    '        _Instrument = value
    '    End Set
    'End Property

    Public ReadOnly Property CustomerID() As Integer Implements ICustomers.CustomerID
        Get
            Return _Id
        End Get
    End Property

    Public ReadOnly Property InspectionID() As Integer Implements ICustomers.InspectionID
        Get
            Return _InspectionID
        End Get
    End Property

    Public ReadOnly Property ApparatusID() As String Implements ICustomers.ApparatusID
        Get
            Return _ApparatusId
        End Get
    End Property

    Public ReadOnly Property InspectionCount() As Integer Implements ICustomers.InspectionCount
        Get
            Return _InspectionCount
        End Get
    End Property

    Public ReadOnly Property PostalCode() As String Implements ICustomers.PostalCode
        Get
            Return _PostalCode
        End Get
    End Property

    Public ReadOnly Property RegNumber() As Integer Implements ICustomers.RegNumber
        Get
            Return _RegNumber
        End Get
    End Property


#Region "Methods"

    Public Sub SaveCustomerItems()
        'Dim x As Integer = 1
        'Try
        '    Using mySqlCommand As New MySqlCommand
        '        With mySqlCommand
        '            .Connection = mySQL.OpenMySQL
        '            .CommandText = "DELETE FROM write_items WHERE Customer_ID = " & Me.CustomerID & " AND instr_type_id = " & Me.Instrument.InstrumentType
        '            .ExecuteNonQuery()
        '            For Each item As Integer In WriteAfterItems
        '                Dim value = WriteAfterValues(x)
        '                .CommandText = "INSERT INTO write_items VALUES (" & Me.CustomerID & ", " & item & "," & Instrument.InstrumentType & ", '" & CStr(value) & "')"
        '                .CommandType = CommandType.Text
        '                .ExecuteNonQuery()
        '                x += 1
        '            Next
        '        End With
        '    End Using
        'Finally
        '    'mySQL.CloseMySQL()
        'End Try
    End Sub

    Public Sub LoadCustomerInformation()
        'Dim myDataReader As MySqlDataReader = Nothing

        'If CustomerID <> -1 Then
        '    Try
        '        Using mysqlcommand As New MySqlCommand
        '            With mysqlcommand
        '                .Connection = mySQL.OpenMySQL
        '                .CommandText = "SELECT * FROM customers WHERE customer_id = " & Me.CustomerID
        '                .CommandType = CommandType.Text
        '                myDataReader = .ExecuteReader

        '                If myDataReader.HasRows Then
        '                    myDataReader.Read()
        '                    Me.CustomerName = myDataReader.GetString("name")
        '                    Me.CustomerAddress = myDataReader.GetString("address")
        '                    Me.PostalCode = myDataReader.GetString("postal_code")
        '                    Me.RegNumber = myDataReader.GetInt32("reg_number")
        '                End If

        '            End With
        '        End Using
        '    Finally
        '        mySQL.CloseMySQL()
        '        If Not myDataReader.IsClosed Then
        '            myDataReader.Close()
        '        End If
        '    End Try

        'End If

    End Sub

    Public Sub GetCustomerItems()
        'Dim myDataReader As MySqlDataReader = Nothing
        'If CustomerID <> -1 Then
        '    Try
        '        _WriteAfterItems.Clear()
        '        cWriteAfterValues.Clear()

        '        Using mySqlCommand As New MySqlCommand
        '            With mySqlCommand
        '                .Connection = mySQL.OpenMySQL
        '                .CommandText = "SELECT w.item_number, w.value, i.item_desc FROM write_items w, items i WHERE w.customer_id = " & Me.CustomerID & " AND w.instr_type_id = " & Me.Instrument.InstrumentType & " AND w.item_number = i.item_num and w.instr_type_id = i.instr_type_id ORDER BY w.item_number"
        '                .CommandType = CommandType.Text
        '                myDataReader = .ExecuteReader()

        '                If myDataReader.HasRows Then
        '                    While myDataReader.Read
        '                        Me.cWriteAfterItems.Add(myDataReader.GetUInt32("item_number"))
        '                        Me.cWriteAfterValues.Add(myDataReader.GetString("value"))
        '                        Me.cItemDescriptions.Add(myDataReader.GetString("item_desc"))
        '                    End While
        '                End If
        '            End With
        '        End Using
        '    Catch ex As Exception
        '        Throw New Exception(ex.Message)
        '    Finally

        '        mySQL.CloseMySQL()
        '        If Not myDataReader.IsClosed Then
        '            myDataReader.Close()
        '        End If
        '    End Try

        'End If

    End Sub

    Private Sub NewCustomer()

        'Try
        '    Using mySqlCommand As New MySqlCommand
        '        With mySqlCommand
        '            .Connection = mySQL.OpenMySQL
        '            .CommandText = "INSERT INTO customers (customer_id, name, address)  VALUES (0,'" & Me.CustomerName & "', '" & Me.CustomerAddress & "' )"
        '            .CommandType = CommandType.Text
        '            .ExecuteNonQuery()
        '        End With
        '    End Using
        'Catch ex As Exception
        '    Console.Write(ex.Message)
        'Finally

        '    'db.Dispose()
        '    'mySQL.CloseMySQL()
        'End Try

    End Sub

    'Return a collection of Customers by Name, returns -1 if theres no customers
    Public Function GetAllCustomers() As Collection
        'Dim myDataReader As MySqlDataReader = Nothing
        'Dim myDataCollection As New Collection
        'Try
        '    Using mysqlcommand As New MySqlCommand
        '        With mysqlcommand
        '            .Connection = mySQL.OpenMySQL
        '            .CommandText = "SELECT customer_id, name FROM customers ORDER BY customer_id ASC"
        '            .CommandType = CommandType.Text
        '            myDataReader = .ExecuteReader(CommandBehavior.Default)

        '            If myDataReader.HasRows Then
        '                While myDataReader.Read
        '                    Dim new_customer As New Customer
        '                    new_customer.CustomerID = myDataReader.GetString(0)
        '                    new_customer.CustomerName = myDataReader.GetString(1)
        '                    myDataCollection.Add(new_customer)
        '                End While
        '            Else
        '                myDataCollection.Add(-1)
        '            End If
        '            Return myDataCollection
        '        End With
        '    End Using
        'Catch ex As Exception
        '    Throw New Exception(ex.Message)
        'Finally
        '    myDataReader.Close()
        '    mySQL.CloseMySQL()
        '    If Not myDataReader.IsClosed Then
        '        myDataReader.Close()
        '    End If
        'End Try
    End Function


#End Region

End Class
