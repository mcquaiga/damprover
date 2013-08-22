Imports Raven.Imports.Newtonsoft.Json

Public Class ItemClass

    Public Property Number As Integer
    <JsonIgnore>
    Public Property Code As String

    Public Property ShortDescription As String
    <JsonIgnore>
    Public Property LongDescription As String
    <JsonIgnore>
    Public Property Value As String
    <JsonIgnore>
    Public Property IsAlarm As Boolean?
    <JsonIgnore>
    Public Property IsPressure As Boolean?
    <JsonIgnore>
    Public Property IsTemperature As Boolean?
    <JsonIgnore>
    Public Property IsVolume As Boolean?
    <JsonIgnore>
    Private Property ValueDescriptions As List(Of ItemDescriptions)

    ReadOnly Property DescriptionValue As String
        Get
            If ValueDescriptions Is Nothing OrElse ValueDescriptions.Count = 0 Then Return Value
            Return ValueDescriptions.Where(Function(x) x.id = Me.Value).SingleOrDefault.description
        End Get
    End Property

    ReadOnly Property NumericValue As Double
        Get
            'If ValueDescriptions Is Nothing OrElse ValueDescriptions.Count = 0 Then Return Value
            Try
                Return ValueDescriptions.Where(Function(x) x.id = Me.Value).SingleOrDefault.NumericValue
            Catch ex As Exception
                Return Value
            End Try
        End Get
    End Property

    Sub New(Number As Integer, Code As String, ShortDescription As String, LongDescription As String, IsAlarm As Boolean?, IsPressure As Boolean?, IsTemperature As Boolean?, IsVolume As Boolean?, ValueDescriptions As List(Of ItemDescriptions))
        Me.Number = Number
        Me.Code = Code
        Me.ShortDescription = ShortDescription
        Me.LongDescription = LongDescription
        Me.IsAlarm = IsAlarm
        Me.IsPressure = IsPressure
        Me.IsTemperature = IsTemperature
        Me.IsVolume = IsVolume
        Me.ValueDescriptions = ValueDescriptions
    End Sub


#Region "Shared Stuff"
    'This will set _instrumentItems with attributes from our specific instrument xml files
    Public Shared Function LoadInstrumentItems(xmlPath As String) As List(Of ItemClass)
        If xmlPath Is Nothing OrElse xmlPath = "" Then
            Throw New Exception("Could not load instrument items.")
        End If

        Dim _xmlElement = XDocument.Load(xmlPath)
        Return (From x In _xmlElement.<InstrumentItems>.Elements("item")
                    Select New ItemClass(x.@number, x.@code, x.@shortDescription, x.@Description,
                                            Not IsNothing(x.@isAlarm) AndAlso x.@isAlarm,
                                            Not IsNothing(x.@isPressure) AndAlso x.@isPressure,
                                            Not IsNothing(x.@isTemperature) AndAlso x.@isTemperature,
                                            Not IsNothing(x.@isVolume) AndAlso x.@isVolume,
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

        Public Sub New(ID As Integer, Description As String, Value As Double)
            Me.id = ID
            Me.description = Description
            Me.NumericValue = Value
        End Sub

        Public Property id As Integer
        Public Property description As String
        Public Property NumericValue As Double

    End Class

End Class
