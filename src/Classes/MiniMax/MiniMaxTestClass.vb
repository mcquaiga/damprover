Public Class MiniMaxTestClass : Inherits MechanicalTestClass

    Implements IDisposable

    'The amount of volume put onto the instrument is manual, but we can read in pulses from the instrument

    Sub New(ByVal customerId As Integer)
        MyBase.New(customerId)
        Me.Instrument = New MiniMaxInstrument()
        Me.Customer.Instrument = Me.Instrument
    End Sub


#Region "Methods"


#End Region


End Class
