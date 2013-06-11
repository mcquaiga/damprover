Imports Prover.Instruments.Data
Imports Microsoft.Practices.Prism.Events
Imports System.ComponentModel
Imports miSerialProtocol
Imports System.Linq

Namespace ViewModels
    Public Class InstrumentDetailsVM
        Implements IInstrumentDetailsVM



        Private Property InstrumentType As String
        Public Property Items As List(Of ItemClass)
        Private _Instrument As IBaseInstrument
        Private _events As IEventAggregator
        Private _communications As InstrumentCommunications


        Sub New(events As IEventAggregator)
            _events = events
            _events.GetEvent(Of SelectedInstrumentChangedEvent).Subscribe(AddressOf ShowInstrument)
        End Sub

        Public Property Instrument As IBaseInstrument Implements IInstrumentDetailsVM.Instrument
            Get
                Return _Instrument
            End Get
            Set(value As IBaseInstrument)
                _Instrument = value
                LoadItemDescriptions()
                NotifyPropertyChanged("Instrument")
            End Set
        End Property

        Public ReadOnly Property IsNewInstrument As Boolean
            Get
                If Instrument Is Nothing Then Return True
                Return IsNothing(Instrument.ID)
            End Get
        End Property

        Public ReadOnly Property IsPressure As Boolean
            Get
                Return Not IsNothing(Instrument.IsLivePressure)
            End Get
        End Property

        Public ReadOnly Property IsTemperature As Boolean
            Get
                Return Not IsNothing(Instrument.IsLiveTemperate)
            End Get
        End Property

        Public ReadOnly Property IsSuper As Boolean
            Get
                Return Not IsNothing(Instrument.IsLiveSuper)
            End Get
        End Property

        Public Sub LoadItemDescriptions()
            If Not Instrument Is Nothing Then
                If Instrument.InstrumentType = InstrumentTypeCode.MiniMax Then
                    Me.Items = MiniMaxInstrument.LoadInstrumentItems()
                End If
            End If
        End Sub

        Public Sub FetchInstrumentInformation()
            If Instrument Is Nothing Then
                Instrument = New MiniMaxInstrument()
                Instrument.ItemFile = InstrumentCommunications.DownloadItemFile(Instrument)
            End If
        End Sub

        Public Event PropertyChanged(ByVal sender As Object, ByVal e As System.ComponentModel.PropertyChangedEventArgs) Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        Private Sub NotifyPropertyChanged(ByVal propname As String)
            RaiseEvent PropertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propname))
        End Sub

        Public Sub ShowInstrument(instrument As IBaseInstrument)
            If instrument IsNot Nothing Then
                Me.Instrument = instrument
            End If
        End Sub

        Public Sub SetBaudRate(BaudRate As Integer)
            InstrumentCommunications.BaudRate = BaudRate
        End Sub

        Public ReadOnly Property CommPorts As ObjectModel.ReadOnlyCollection(Of String) Implements IInstrumentDetailsVM.CommPorts
            Get
                Return CommunicationPorts.GetAllCommPorts()
            End Get
        End Property

        Public ReadOnly Property BaudRates As miSerialProtocol.BaudRateEnum Implements IInstrumentDetailsVM.BaudRates
            Get
                Return
            End Get

        Public ReadOnly Property ShowCommButtons As String
            Get
                If IsNewInstrument = True Then
                    Return "Visible"
                Else
                    Return "Hidden"
                End If
            End Get
        End Property

#Region "Commands"
        Private _fetchInstrumentCommand = New Microsoft.Practices.Prism.Commands.DelegateCommand(AddressOf FetchInstrumentInformation)
        Public ReadOnly Property FetchInstrumentInfoCommand As ICommand Implements IInstrumentDetailsVM.FetchInstrumentInfoCommand
            Get
                Return _fetchInstrumentCommand
            End Get
        End Property


        Private _setBaudRateCommand = New Microsoft.Practices.Prism.Commands.DelegateCommand(Of Integer)(AddressOf SetBaudRate)

        Public ReadOnly Property SetBaudRateCommand As ICommand Implements IInstrumentDetailsVM.SetBaudRateCommand
            Get
                Return _setBaudRateCommand
            End Get
        End Property

#End Region


    End Class
End Namespace