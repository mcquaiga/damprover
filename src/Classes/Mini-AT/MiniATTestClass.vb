Public Class MiniATTestClass : Inherits MechanicalTestClass
    Implements IDisposable

    Public Shadows Enum ItemsToSet
        CorrectedVolume = 0
        UnCorrectedVolume = 2

    End Enum

    'MiniAt test must download all the items and reset volume items
    'The amount of volume put onto the instrument is manual, but we can read in pulses from the instrument

    Sub New(ByVal customerId As Integer)
        MyBase.New(customerId)
        Me.Instrument = New MiniATInstrument()
        Me.Customer.Instrument = Me.Instrument
    End Sub

#Region "Methods"

#End Region


End Class
