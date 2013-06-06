Imports Prover.Instruments.Data
Imports Microsoft.Practices.Prism.Events
Imports miSerialProtocol

Namespace ViewModels
    Public Class InstrumentDetailsVM
        Implements IInstrumentDetailsVM

        Public Property Items As List(Of ItemClass)
        Public Property Instrument As IBaseInstrument Implements IInstrumentDetailsVM.Instrument
        Private _events As IEventAggregator

        Sub New(events As IEventAggregator)
            _events = events

            _events.GetEvent(Of SelectedInstrumentChangedEvent).Subscribe(AddressOf ShowInstrument)
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

        Public Event PropertyChanged(sender As Object, e As ComponentModel.PropertyChangedEventArgs) Implements ComponentModel.INotifyPropertyChanged.PropertyChanged

        Public Sub ShowInstrument(instrument As IBaseInstrument)
            If instrument IsNot Nothing Then
                Me.Instrument = instrument

                ' LoadItemDescriptions()

            End If
        End Sub
    End Class
End Namespace