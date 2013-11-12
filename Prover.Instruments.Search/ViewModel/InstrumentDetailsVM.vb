Imports Prover.Instruments.Data
Imports Prover
Imports Microsoft.Practices.Prism.Events
Imports Microsoft.Practices.Prism.Regions
Imports miSerialProtocol
Imports System.Linq
Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports System.Collections.ObjectModel


Namespace ViewModels
    Public Class InstrumentDetailsVM
        Implements IInstrumentDetailsVM, INotifyPropertyChanged, IRegionMemberLifetime


        Private _progress As Progress(Of Tuple(Of String, Integer))
        Private Property InstrumentType As String
        Public Property Items As List(Of ItemClass)
        Private _Instrument As IBaseInstrument
        Private _events As IEventAggregator
        Private _communications As InstrumentCommunications
        Private _provider As New InstrumentDataProvider
        Private _pressurelevelIndex As List(Of String)
        Private _templevelIndex As List(Of Integer)
        Private _volume As IVolume


        Private _irdaPort As IrDAPort
        Private _serialPort As SerialPort

        Sub New(events As IEventAggregator)
            _events = events
            _events.GetEvent(Of SelectedInstrumentChangedEvent).Subscribe(AddressOf ShowInstrument)

            _progress = New Progress(Of Tuple(Of String, Integer))(AddressOf ReportProgress)
        End Sub

        Public ReadOnly Property ItemValuesWithDescriptions As Dictionary(Of ItemClass, String)
            Get
                Dim iD As New Dictionary(Of ItemClass, String)
                If Items Is Nothing Then
                    LoadItemDescriptions()
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
                Return False
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


        Public ReadOnly Property CommPorts As List(Of String) Implements IInstrumentDetailsVM.CommPorts
            Get
                Dim ports As List(Of String) = CommunicationPorts.GetAllCommPorts().ToList()
                ports.Add("IrDA")
                Return ports
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

        Public ReadOnly Property PressureLevels As List(Of String)
            Get
                Return _pressurelevelIndex
            End Get
        End Property

        Public Property TemperatureTests As ObservableCollection(Of ITemperatureTestClass)
            Get
                If _Instrument Is Nothing Then Return Nothing
                Return _Instrument.Temperature.Tests
            End Get
            Set(value As ObservableCollection(Of ITemperatureTestClass))
                _Instrument.Temperature.Tests = value
            End Set
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
            InstrumentCommunications.CommPortName = CommPort
        End Sub

        Public Sub Save()
            _provider.UpsertInstrument(Instrument)
        End Sub

        Public Sub CreateNewMiniMaxObject()
            Me.Instrument = New MiniMaxInstrument()
        End Sub

        Sub CreateNewEC300Object()
            Me.Instrument = New EC300Instrument()
        End Sub



        Public Async Function FetchPressureItemsByLevel(LevelIndex As Integer) As Task

            'Dim p As New PressureFactorClass(LevelIndex)
            'Await InstrumentCommunications.DownloadPressureItemsAsync(Instrument, _progress)

            'Instrument.PressureTests.Remove(Instrument.PressureTests.Where(Function(x) x.LevelIndex = LevelIndex).FirstOrDefault())
            'Instrument.PressureTests.Add(p)

            'NotifyPropertyChanged("Instrument")
        End Function

        Public Async Sub FetchTemperatureItemsByLevel(LevelIndex As Integer)
            Await Instrument.DownloadTemperatureTestItems(LevelIndex)
            NotifyPropertyChanged("Instruments")
            NotifyPropertyChanged("TemperatureTests")
        End Sub

        Public Sub LoadItemDescriptions()
            'If Not Instrument Is Nothing Then
            '    If Instrument.InstrumentType = InstrumentTypeCode.MiniMax Then
            '        Me.Items = MiniMaxInstrument.LoadInstrumentItems()
            '    End If

            '    If Instrument.InstrumentType = InstrumentTypeCode.EC300 Then
            '        Me.Items = EC300Instrument.LoadInstrumentItems()
            '    End If

            '    NotifyPropertyChanged("ItemValuesWithDescriptions")
            'End If
        End Sub

        Public Async Function FetchInstrumentInformation() As Task
            If Instrument Is Nothing Then
                MessageBox.Show("Select an Instrument Type.")
                Return
            End If

            LoadItemDescriptions()
            Try
                Await Instrument.DownloadSiteInformation()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Error")
            End Try

            NotifyPropertyChanged("ItemValuesWithDescriptions")
            NotifyPropertyChanged("Volume")
            NotifyPropertyChanged("TemperatureTests")
            NotifyPropertyChanged("Instrument")

        End Function

        Public Async Function StartNewTest() As Task

            Try
                Await Instrument.VolumeTest.StartTest(Me.Instrument.InstrumentType)
            Catch ex As Exception
                MsgBox(ex.Message.ToString, MsgBoxStyle.OkOnly)
            End Try

        End Function


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

        Private _EC300Command = New Microsoft.Practices.Prism.Commands.DelegateCommand(AddressOf CreateNewEC300Object)
        Public ReadOnly Property EC300Command As ICommand Implements IInstrumentDetailsVM.EC300Command
            Get
                Return _EC300Command
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

        Private _startTestCommand = New Microsoft.Practices.Prism.Commands.DelegateCommand(AddressOf StartNewTest)
        Public ReadOnly Property StartTestCommand As ICommand Implements IInstrumentDetailsVM.StartTestsCommand
            Get
                Return _startTestCommand
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

        Private Function ReportProgress() As Object
            Console.WriteLine("Not implemented.")
            Return Nothing
        End Function

        Public ReadOnly Property KeepAlive As Boolean Implements IRegionMemberLifetime.KeepAlive
            Get
                Return False
            End Get
        End Property

    End Class
End Namespace