Imports Prover.Instruments.Data
Imports miSerialProtocol

Namespace ViewModels
    Public Class InstrumentDetailsVM
        Implements IInstrumentDetailsVM

        Public Property Items As List(Of ItemClass)
        Public Property Instrument As IBaseInstrument

        Sub New()
        End Sub

        Sub New(Instrument As IBaseInstrument)
            Me.Instrument = Instrument
        End Sub

        Public ReadOnly Property IsNewInstrument As Boolean
            Get
                If Instrument Is Nothing Then Return True
                Return IsNothing(Instrument.ID)
            End Get
        End Property

        Public ReadOnly Property IsPressure As Boolean
            Get
                Return Instrument.IsLivePressure
            End Get
        End Property

        Public ReadOnly Property IsTemperature As Boolean
            Get
                Return Instrument.IsLiveTemperate
            End Get
        End Property

        Public ReadOnly Property IsSuper As Boolean
            Get
                Return Instrument.IsLiveSuper
            End Get
        End Property

        Public Sub LoadItemDescriptions()
            If Not Instrument Is Nothing Then
                If Instrument.InstrumentType = InstrumentTypeCode.MiniMax Then
                    Me.Items = MiniMaxInstrument.LoadInstrumentItems()
                End If
            End If
        End Sub
    End Class
End Namespace