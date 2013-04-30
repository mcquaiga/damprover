Public Interface ICustomers

    ReadOnly Property CustomerID As Integer
    ReadOnly Property CustomerName As String
    ReadOnly Property CustomerAddress As String
    ReadOnly Property WriteAfterItems As Collection
    ReadOnly Property WriteAfterValues As Collection
    ReadOnly Property ItemDescriptions As Collection
    'Property Instrument As Instrument
    ReadOnly Property InspectionID As Integer
    ReadOnly Property ApparatusID As String
    ReadOnly Property InspectionCount As Integer
    ReadOnly Property PostalCode As String
    ReadOnly Property RegNumber As Integer

End Interface
