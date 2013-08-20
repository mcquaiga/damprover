Public Class ItemClass

    Public Property Number As Integer
    Public Property Code As String
    Public Property ShortDescription As String
    Public Property LongDescription As String
    Public Property IsAlarm As Boolean
    Public Property IsPressure As Boolean
    Public Property IsTemperature As Boolean
    Public Property IsVolume As Boolean
    Public Property ValueDescriptions As List(Of ItemDescriptions)


    Sub New(Number As Integer, Code As String, ShortDescription As String, LongDescription As String, IsAlarm As Boolean, IsPressure As Boolean, IsTemperature As Boolean, IsVolume As Boolean, ValueDescriptions As List(Of ItemDescriptions))
        Me.Number = Number
        Me.Code = Code
        Me.ShortDescription = ShortDescription
        Me.LongDescription = LongDescription
        Me.IsAlarm = IsAlarm
        Me.IsPressure = IsPressure
        Me.IsTemperature = IsTemperature
        Me.IsVolume = IsVolume
        Me.ValueDescriptions = New List(Of ItemDescriptions)
    End Sub


#Region "Shared Stuff"
    'This will set _instrumentItems with attributes from our specific instrument xml files
    Public Shared Function LoadInstrumentItems(xmlPath As String) As List(Of ItemClass)
        If xmlPath Is Nothing OrElse xmlPath = "" Then
            Throw New Exception("Could not load instrument items.")
        End If

        Dim _xmlElement = XDocument.Load(xmlPath)
        Return (From x In _xmlElement.<InstrumentItems>.Elements("item")
                    Select New ItemClass(x.@number, x.@code, x.@shortDescription, x.@Description, Not IsNothing(x.@isAlarm), Not IsNothing(x.@isPressure), Not IsNothing(x.@isTemperature), Not IsNothing(x.@IsVolume),
                            (From y In x.Elements("value") Select New ItemDescriptions(y.@id, y.@description, y.@numericvalue)).ToList())
                ).ToList()
    End Function

    Public Shared Function GetItemNumberByCode(Items As List(Of ItemClass), Code As String) As Integer
        Try
            Return ((From i In Items Where i.Code = CStr(Code) And i IsNot Nothing Select i).First).Number
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public ReadOnly Property AlarmItems(Items As List(Of ItemClass)) As List(Of ItemClass)
        Get
            Return (From alarms In Items Where alarms.IsAlarm = True)
        End Get
    End Property
#End Region

    Public Class ItemDescriptions

        Public Sub New(ID As Integer, Description As String, Value As Decimal)
            Me.id = ID
            Me.description = Description
            Me.value = Value
        End Sub

        Public Property id As Integer
        Public Property description As String
        Public Property value As Decimal

    End Class

End Class
