Public Class ItemClass

    Public Property Number As Integer
    Public Property Code As String
    Public Property Shortdescription As String
    Public Property LongDescription As String
    Public Property IsAlarm As Boolean

    Sub New(Number As Integer, Code As String, ShortDescription As String, LongDescription As String, IsAlarm As Boolean)
        Me.Number = Number
        Me.Code = Code
        Me.Shortdescription = ShortDescription
        Me.LongDescription = LongDescription
        Me.IsAlarm = IsAlarm
    End Sub



End Class
