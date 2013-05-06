Imports System.Collections

Public Class ItemClass

    Public Property Number As Integer
    Public Property Shortdescription As String
    Public Property LongDescription As String
    Public Property IsAlarm As Boolean
    Public Property Value As String


    Sub New(Number As Integer, ShortDescription As String, LongDescription As String, IsAlarm As Boolean)
        Me.Number = Number
        Me.Shortdescription = ShortDescription
        Me.LongDescription = LongDescription
        Me.IsAlarm = IsAlarm
    End Sub

    Sub New(Number As Integer, ShortDescription As String, LongDescription As String, IsAlarm As Boolean, Value As String)
        Me.Number = Number
        Me.Shortdescription = ShortDescription
        Me.LongDescription = LongDescription
        Me.IsAlarm = IsAlarm
        Me.Value = Value
    End Sub



End Class
