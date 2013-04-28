

Public Class Customer
    Implements ICustomers

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

    Private _Instrument As Instrument


    'By calling this constructor, no customer is being created or loaded
    'This will allow other functions to retrieve a list of all the customers
    Sub New()
        _Name = ""
    End Sub

    Sub New(ByVal CustomerID As Integer)

        Me.CustomerID = CustomerID
        LoadCustomerInformation()
    End Sub

    Sub New(ByVal CustomerName As String)

        CustomerID = 0
        Me.CustomerName = CustomerName
        NewCustomer()
    End Sub

    Sub New(ByVal CustomerId As Integer, ByVal Instrument As Instrument)

        Me.CustomerID = CustomerId
        _Instrument = Instrument
        GetCustomerItems()
    End Sub


    Public Property CustomerName() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property

    Public Property CustomerAddress() As String
        Get
            Return _Address
        End Get
        Set(ByVal value As String)
            _Address = value
        End Set
    End Property

    Public Overridable Property WriteAfterItems() As Collection
        Get
            Return _WriteAfterItems
        End Get
        Set(ByVal value As Collection)
            _WriteAfterItems = value
        End Set
    End Property

    Public Overridable Property WriteAfterValues() As Collection
        Get
            Return _WriteAfterValues
        End Get
        Set(ByVal value As Collection)
            _WriteAfterValues = value
        End Set
    End Property
    Public Overridable ReadOnly Property ItemDescriptions() As Collection
        Get
            Return _ItemDescriptions
        End Get

    End Property

    Public Property Instrument() As Instrument
        Get
            Return _Instrument
        End Get
        Set(ByVal value As Instrument)
            _Instrument = value
        End Set
    End Property

    Public Property CustomerID() As Integer
        Get
            Return _Id
        End Get

        Set(ByVal value As Integer)
            _Id = value
        End Set
    End Property

    Public Property InspectionID() As Integer
        Get
            Return _InspectionID
        End Get
        Set(ByVal value As Integer)
            _InspectionID = value
        End Set
    End Property

    Public Property ApparatusID() As String
        Get
            Return _ApparatusId
        End Get
        Set(ByVal value As String)
            _ApparatusId = value
        End Set
    End Property

    Public Property InspectionCount() As Integer
        Get
            Return _InspectionCount
        End Get
        Set(ByVal value As Integer)
            _InspectionCount = value
        End Set
    End Property

    Public Property PostalCode() As String
        Get
            Return _PostalCode
        End Get
        Set(ByVal value As String)
            _PostalCode = value
        End Set
    End Property

    Public Property RegNumber() As Integer
        Get
            Return _RegNumber
        End Get
        Set(ByVal value As Integer)
            _RegNumber = value
        End Set
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
