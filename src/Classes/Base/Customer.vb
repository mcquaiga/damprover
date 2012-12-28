Imports MySql.Data.MySqlClient

Public Class Customer

    Private cName As String
    Private cId As Integer
    Private cAddress As String
    Private cInspectionID As Integer
    Private cInspectionCount As Integer
    Private cApparatusId As String
    Private cPostalCode As String
    Private cRegNumber As Integer

    Private cWriteBeforeItems As New Collection
    Private cWriteBeforeValues As New Collection
    Private cWriteAfterItems As New Collection
    Private cWriteAfterValues As New Collection
    Private cItemDescriptions As New Collection

    Private cInstrument As Instrument

    Private mySQL As New MySQLLibrary.Database
    Private db As New MySqlConnection
    Private sqlCommand As New MySqlCommand



    'By calling this constructor, no customer is being created or loaded
    'This will allow other functions to retrieve a list of all the customers
    Sub New()

        cId = -1
        cName = ""
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
        cInstrument = Instrument
        GetCustomerItems()
    End Sub

    Protected Overrides Sub Finalize()
        If db IsNot Nothing Then
            mySQL.CloseMySQL()
        End If
    End Sub


#Region "Properties"
    Public Property CustomerName() As String
        Get
            Return cName
        End Get
        Set(ByVal value As String)
            cName = value
        End Set
    End Property

    Public Property CustomerAddress() As String
        Get
            Return cAddress
        End Get
        Set(ByVal value As String)
            cAddress = value
        End Set
    End Property

    Public Overridable Property WriteAfterItems() As Collection
        Get
            Return cWriteAfterItems
        End Get
        Set(ByVal value As Collection)
            cWriteAfterItems = value
        End Set
    End Property

    Public Overridable Property WriteAfterValues() As Collection
        Get
            Return cWriteAfterValues
        End Get
        Set(ByVal value As Collection)
            cWriteAfterValues = value
        End Set
    End Property
    Public Overridable ReadOnly Property ItemDescriptions() As Collection
        Get
            Return cItemDescriptions
        End Get

    End Property

    Public Property Instrument() As Instrument
        Get
            Return cInstrument
        End Get
        Set(ByVal value As Instrument)
            cInstrument = value
        End Set
    End Property

    Public Property CustomerID() As Integer
        Get
            Return cId
        End Get

        Set(ByVal value As Integer)
            cId = value
        End Set
    End Property

    Public Property InspectionID() As Integer
        Get
            Return cInspectionID
        End Get
        Set(ByVal value As Integer)
            cInspectionID = value
        End Set
    End Property

    Public Property ApparatusID() As String
        Get
            Return cApparatusId
        End Get
        Set(ByVal value As String)
            cApparatusId = value
        End Set
    End Property

    Public Property InspectionCount() As Integer
        Get
            Return cInspectionCount
        End Get
        Set(ByVal value As Integer)
            cInspectionCount = value
        End Set
    End Property

    Public Property PostalCode() As String
        Get
            Return cPostalCode
        End Get
        Set(ByVal value As String)
            cPostalCode = value
        End Set
    End Property

    Public Property RegNumber() As Integer
        Get
            Return cRegNumber
        End Get
        Set(ByVal value As Integer)
            cRegNumber = value
        End Set
    End Property
#End Region

#Region "Methods"

    Public Sub SaveCustomerItems()
        Dim x As Integer = 1
        Try
            Using mySqlCommand As New MySqlCommand
                With mySqlCommand
                    .Connection = mySQL.OpenMySQL
                    .CommandText = "DELETE FROM write_items WHERE Customer_ID = " & Me.CustomerID & " AND instr_type_id = " & Me.Instrument.InstrumentType
                    .ExecuteNonQuery()
                    For Each item As Integer In WriteAfterItems
                        Dim value = WriteAfterValues(x)
                        .CommandText = "INSERT INTO write_items VALUES (" & Me.CustomerID & ", " & item & "," & Instrument.InstrumentType & ", '" & CStr(value) & "')"
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                        x += 1
                    Next
                End With
            End Using
        Finally
            mySQL.CloseMySQL()
        End Try
    End Sub

    Public Sub LoadCustomerInformation()
        Dim myDataReader As MySqlDataReader = Nothing

        If CustomerID <> -1 Then
            Try
                Using mysqlcommand As New MySqlCommand
                    With mysqlcommand
                        .Connection = mySQL.OpenMySQL
                        .CommandText = "SELECT * FROM customers WHERE customer_id = " & Me.CustomerID
                        .CommandType = CommandType.Text
                        myDataReader = .ExecuteReader

                        If myDataReader.HasRows Then
                            myDataReader.Read()
                            Me.CustomerName = myDataReader.GetString("name")
                            Me.CustomerAddress = myDataReader.GetString("address")
                            Me.PostalCode = myDataReader.GetString("postal_code")
                            Me.RegNumber = myDataReader.GetInt32("reg_number")
                        End If

                    End With
                End Using
            Finally
                mySQL.CloseMySQL()
                If Not myDataReader.IsClosed Then
                    myDataReader.Close()
                End If
            End Try

        End If

    End Sub

    Public Sub GetCustomerItems()
        Dim myDataReader As MySqlDataReader = Nothing
        If CustomerID <> -1 Then
            Try
                cWriteAfterItems.Clear()
                cWriteAfterValues.Clear()

                Using mySqlCommand As New MySqlCommand
                    With mySqlCommand
                        .Connection = mySQL.OpenMySQL
                        .CommandText = "SELECT w.item_number, w.value, i.item_desc FROM write_items w, items i WHERE w.customer_id = " & Me.CustomerID & " AND w.instr_type_id = " & Me.Instrument.InstrumentType & " AND w.item_number = i.item_num and w.instr_type_id = i.instr_type_id ORDER BY w.item_number"
                        .CommandType = CommandType.Text
                        myDataReader = .ExecuteReader()

                        If myDataReader.HasRows Then
                            While myDataReader.Read
                                Me.cWriteAfterItems.Add(myDataReader.GetUInt32("item_number"))
                                Me.cWriteAfterValues.Add(myDataReader.GetString("value"))
                                Me.cItemDescriptions.Add(myDataReader.GetString("item_desc"))
                            End While
                        End If
                    End With
                End Using
            Catch ex As Exception
                Throw New Exception(ex.Message)
            Finally

                mySQL.CloseMySQL()
                If Not myDataReader.IsClosed Then
                    myDataReader.Close()
                End If
            End Try

        End If

    End Sub

    Private Sub NewCustomer()

        Try
            Using mySqlCommand As New MySqlCommand
                With mySqlCommand
                    .Connection = mySQL.OpenMySQL
                    .CommandText = "INSERT INTO customers (customer_id, name, address)  VALUES (0,'" & Me.CustomerName & "', '" & Me.CustomerAddress & "' )"
                    .CommandType = CommandType.Text
                    .ExecuteNonQuery()
                End With
            End Using
        Catch ex As Exception
            Console.Write(ex.Message)
        Finally

            db.Dispose()
            mySQL.CloseMySQL()
        End Try

    End Sub

    'Return a collection of Customers by Name, returns -1 if theres no customers
    Public Function GetAllCustomers() As Collection
        Dim myDataReader As MySqlDataReader = Nothing
        Dim myDataCollection As New Collection
        Try
            Using mysqlcommand As New MySqlCommand
                With mysqlcommand
                    .Connection = mySQL.OpenMySQL
                    .CommandText = "SELECT customer_id, name FROM customers ORDER BY customer_id ASC"
                    .CommandType = CommandType.Text
                    myDataReader = .ExecuteReader(CommandBehavior.Default)

                    If myDataReader.HasRows Then
                        While myDataReader.Read
                            Dim new_customer As New Customer
                            new_customer.CustomerID = myDataReader.GetString(0)
                            new_customer.CustomerName = myDataReader.GetString(1)
                            myDataCollection.Add(new_customer)
                        End While
                    Else
                        myDataCollection.Add(-1)
                    End If
                    Return myDataCollection
                End With
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            myDataReader.Close()
            mySQL.CloseMySQL()
            If Not myDataReader.IsClosed Then
                myDataReader.Close()
            End If
        End Try
    End Function

    
#End Region

End Class
