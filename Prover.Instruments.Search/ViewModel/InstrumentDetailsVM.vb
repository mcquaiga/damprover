Imports Prover.Instruments.Data
Imports Microsoft.Practices.Prism.Events
Imports miSerialProtocol
Imports System.Linq
Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Namespace ViewModels
    Public Class InstrumentDetailsVM
        Implements IInstrumentDetailsVM, INotifyPropertyChanged




        Private Property InstrumentType As String
        Public Property Items As List(Of ItemClass)
        Private _Instrument As IBaseInstrument
        Private _events As IEventAggregator
        Private _communications As InstrumentCommunications
        Private _provider As New InstrumentDataProvider


        Sub New(events As IEventAggregator)
            _events = events
            _events.GetEvent(Of SelectedInstrumentChangedEvent).Subscribe(AddressOf ShowInstrument)
        End Sub

        Public ReadOnly Property ItemValuesWithDescriptions As Dictionary(Of ItemClass, String)
            Get
                Dim iD As New Dictionary(Of ItemClass, String)
                If Items Is Nothing Then
                    LoadItemDescriptions()
                End If
                If Items IsNot Nothing Then
                    For Each i In Items
                        If Instrument.ItemFile.Count > 0 Then
                            iD.Add(i, Instrument.ItemFile(i.Number))
                        Else
                            iD.Add(i, Nothing)
                        End If

                    Next
                End If
                Return iD
            End Get
        End Property


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

                NotifyPropertyChanged("ItemValuesWithDescriptions")
            End If
        End Sub

        Public Sub FetchInstrumentInformation()
            If Instrument Is Nothing Then MessageBox.Show("Select an Instrument Type.")

            Instrument = New MiniMaxInstrument()
            LoadItemDescriptions()

            Instrument.ItemFile = InstrumentCommunications.DownloadItemFile(Instrument)
            NotifyPropertyChanged("ItemValuesWithDescriptions")
            NotifyPropertyChanged("Instrument")

        End Sub

        Public ReadOnly Property CommPorts As ObjectModel.ReadOnlyCollection(Of String) Implements IInstrumentDetailsVM.CommPorts
            Get
                Return CommunicationPorts.GetAllCommPorts()
            End Get
        End Property

        Public ReadOnly Property BaudRates As List(Of String) Implements IInstrumentDetailsVM.BaudRates
            Get
                Return System.Enum.GetNames(GetType(miSerialProtocol.BaudRateEnum)).ToList()
            End Get
        End Property

        Public ReadOnly Property ShowCommButtons As String
            Get
                If IsNewInstrument = True Then
                    Return "Visible"
                Else
                    Return "Hidden"
                End If
            End Get
        End Property

#Region "Methods"

        Public Sub ShowInstrument(instrument As IBaseInstrument)
            If instrument IsNot Nothing Then
                Me.Instrument = instrument

            End If
        End Sub

        Public Sub SetBaudRate(BaudRate As String)
            InstrumentCommunications.BaudRate = [Enum].Parse(GetType(miSerialProtocol.BaudRateEnum), BaudRate)
        End Sub

        Public Sub SetCommPort(CommPort As String)
            InstrumentCommunications.CommPort = CommPort
        End Sub

        Public Sub Save()
            _provider.UpsetNewInstrument(Instrument)
        End Sub

        Public Sub CreateNewMiniMaxObject()
            Me.Instrument = New MiniMaxInstrument()
        End Sub

        Public Sub FetchPressureItemsByLevel(LevelIndex As Integer)
            Me.Instrument.PressureTests.Where(Function(x) x.LevelIndex = LevelIndex).FirstOrDefault.Items = InstrumentCommunications.DownloadPressureItems(Me.Instrument)
            NotifyPropertyChanged("Instrument")
        End Sub

        Public Sub FetchTemperatureItemsByLevel(LevelIndex As Integer)
            Me.Instrument.TemperateTests.Where(Function(x) (x.LevelIndex = LevelIndex)).FirstOrDefault.Items = InstrumentCommunications.DownloadTemperatureItems(Me.Instrument)
            NotifyPropertyChanged("Instrument")
        End Sub

#End Region

#Region "Commands"
        Private _fetchInstrumentCommand = New Microsoft.Practices.Prism.Commands.DelegateCommand(AddressOf FetchInstrumentInformation)
        Public ReadOnly Property FetchInstrumentInfoCommand As ICommand Implements IInstrumentDetailsVM.FetchInstrumentInfoCommand
            Get
                Return _fetchInstrumentCommand
            End Get
        End Property


        Private _setBaudRateCommand = New Microsoft.Practices.Prism.Commands.DelegateCommand(Of String)(AddressOf SetBaudRate)

        Public ReadOnly Property SetBaudRateCommand As ICommand Implements IInstrumentDetailsVM.SetBaudRateCommand
            Get
                Return _setBaudRateCommand
            End Get
        End Property

        Private _setCommPortCommand = New Microsoft.Practices.Prism.Commands.DelegateCommand(Of String)(AddressOf SetCommPort)

        Public ReadOnly Property SetCommPortCommand As ICommand Implements IInstrumentDetailsVM.setCommPortCommand
            Get
                Return _setCommPortCommand
            End Get
        End Property

        Private _SaveCommand = New Microsoft.Practices.Prism.Commands.DelegateCommand(AddressOf Save)
        Public ReadOnly Property SaveCommand As ICommand Implements IInstrumentDetailsVM.SaveCommand
            Get
                Return _SaveCommand
            End Get
        End Property

        Private _MiniMaxCommand = New Microsoft.Practices.Prism.Commands.DelegateCommand(AddressOf CreateNewMiniMaxObject)
        Public ReadOnly Property MiniMaxCommand As ICommand Implements IInstrumentDetailsVM.MiniMaxCommand
            Get
                Return _MiniMaxCommand
            End Get
        End Property

        Private _fetchPressureCommand = New Microsoft.Practices.Prism.Commands.DelegateCommand(Of Integer?)(AddressOf FetchPressureItemsByLevel)
        Public ReadOnly Property fetchPressureCommand As ICommand Implements IInstrumentDetailsVM.FetchPressureItemsByLevelCommand
            Get
                Return _fetchPressureCommand
            End Get
        End Property

        Private _fetchTemperatureCommand = New Microsoft.Practices.Prism.Commands.DelegateCommand(Of Integer?)(AddressOf FetchTemperatureItemsByLevel)
        Public ReadOnly Property fetchTemperatureCommand As ICommand Implements IInstrumentDetailsVM.FetchTemperatureItemsByLevelCommand
            Get
                Return _fetchTemperatureCommand
            End Get
        End Property
#End Region


        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        ' This method is called by the Set accessor of each property. 
        ' The CallerMemberName attribute that is applied to the optional propertyName 
        ' parameter causes the property name of the caller to be substituted as an argument. 
        Private Sub NotifyPropertyChanged(<CallerMemberName()> Optional ByVal propertyName As String = Nothing)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End Sub




    End Class
End Namespace