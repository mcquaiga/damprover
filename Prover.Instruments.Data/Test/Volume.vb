Imports Newtonsoft.Json
Imports Prover.Instruments.Data
Imports miSerialProtocol
Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Public Class Volume
    Implements IVolume, INotifyPropertyChanged

    Private _appliedInput As Decimal
    Private _meterIndexpulses As MeterIndexInputPulses

    Sub New()
    End Sub

    Sub New(ByVal Items As List(Of ItemClass))
        MyBase.New()

        BeforeItems = (From i In Items Select i
                      Where i.IsVolume = True
                      Select New ItemClass With {.Code = i.Code, .IsVolume = i.IsVolume,
                                                .LongDescription = i.LongDescription, .Number = i.Number,
                                                 .ShortDescription = i.ShortDescription, .Value = i.Value,
                                                 .ValueDescriptions = i.ValueDescriptions}).ToList()

        AfterItems = (From i In Items Select i
                      Where i.IsVolume = True
                      Select New ItemClass With {.Code = i.Code, .IsVolume = i.IsVolume,
                                                 .LongDescription = i.LongDescription, .Number = i.Number,
                                                 .ShortDescription = i.ShortDescription, .Value = i.Value,
                                                  .ValueDescriptions = i.ValueDescriptions}).ToList()


        'We need to setup three subsystems, 1 output (motor), 2 inputs (pulses A/B)
        InputABoard = New USBDataAcqClass(0, MccDaq.DigitalPortType.FirstPortA, 0)
        InputBBoard = New USBDataAcqClass(0, MccDaq.DigitalPortType.FirstPortB, 1)
        OutputBoard = New USBDataAcqClass(0, 0, 0)

        'TachometerComm = New TachometerClass()

        Dim _xmlElement = XDocument.Load(My.Application.Info.DirectoryPath + "\MeterInputPulses.xml")
        _meterIndexpulses = (From x In _xmlElement.<MeterIndexes>.Elements("value")
                        Where x.@id = Me.MeterTypeID
                        Select New MeterIndexInputPulses(x.@id, x.@UnCorPulsesX10, x.@UnCorPulsesX100, x.@MeterDisplacement)).FirstOrDefault

    End Sub

#Region "Properties"

    Public Const CubicFeetToMeters = 0.0283168466

    Public Property BeforeItems As List(Of ItemClass) Implements IVolume.BeforeItems

    Public Property AfterItems As List(Of ItemClass) Implements IVolume.AfterItems


    Public Property PressureFactor() As Double Implements IVolume.PressureFactor
    Public Property Fpv2Factor() As Double Implements IVolume.Fpv2
    Public Property AppliedInput() As Double Implements IVolume.AppliedInput
        Get
            Return _appliedInput
        End Get
        Set(value As Double)
            _appliedInput = value
            NotifyPropertyChanged("AppliedInput")
            NotifyPropertyChanged("CorrectedPercentError")
            NotifyPropertyChanged("UnCorrectedPercentError")
        End Set
    End Property
    Public Property PulserACount As Double Implements IVolume.PulserACount
    Public Property PulserBCount As Double Implements IVolume.PulserBCount

    Public Property TemperatureTest As TemperatureTestClass Implements IVolume.TemperatureTest

    <JsonIgnore>
    Public Property OutputBoard As IBoard Implements IVolume.OutputBoard
    <JsonIgnore>
    Public Property InputABoard As IBoard Implements IVolume.InputABoard
    <JsonIgnore>
    Public Property InputBBoard As IBoard Implements IVolume.InputBBoard
    <JsonIgnore>
    Public Property TachometerComm As TachometerClass Implements IVolume.TachometerComm
    <JsonIgnore>
    Private Property TachResetBoard As IBoard Implements IVolume.TachResetBoard

    Public ReadOnly Property EVCType() As IVolume.EVCTypeEnum Implements IVolume.EVCType
        Get
            If IsNothing(BeforeItems) Then Return Nothing
            If BeforeItems.Where(Function(x) x.Number = 109).SingleOrDefault.DescriptionValue = "Live" And BeforeItems.Where(Function(x) x.Number = 111).SingleOrDefault.DescriptionValue = "Live" Then
                Return IVolume.EVCTypeEnum.PressureTemperature
            ElseIf BeforeItems.Where(Function(x) x.Number = 109).SingleOrDefault.DescriptionValue = "Live" Then
                Return IVolume.EVCTypeEnum.Pressure
            Else
                Return IVolume.EVCTypeEnum.Temperature
            End If
        End Get
    End Property

    Public ReadOnly Property EVCMeterDisplacement() As Double Implements IVolume.EvcMeterDisplacement
        Get
            If IsNothing(BeforeItems) Then Return Nothing
            Return BeforeItems.Where(Function(x) x.Number = 439).SingleOrDefault.NumericValue
        End Get
    End Property

    Public ReadOnly Property MeterTypeID As Integer Implements IVolume.MeterTypeID
        Get
            If IsNothing(BeforeItems) Then Return Nothing
            Return CInt(BeforeItems.Where(Function(x) x.Number = 432).SingleOrDefault.Value)
        End Get
    End Property

    Public ReadOnly Property MeterType As String Implements IVolume.MeterType
        Get
            If IsNothing(BeforeItems) Then Return Nothing
            Return BeforeItems.Where(Function(x) x.Number = 432).SingleOrDefault.DescriptionValue
        End Get
    End Property

    Public ReadOnly Property DriveRate() As Double Implements IVolume.DriveRate
        Get
            If IsNothing(BeforeItems) Then Return Nothing
            Return BeforeItems.Where(Function(x) x.Number = 98).SingleOrDefault.NumericValue
        End Get
    End Property
    Public ReadOnly Property DriveRateDescription() As String Implements IVolume.DriveRateDescription
        Get
            If IsNothing(BeforeItems) Then Return Nothing
            Return BeforeItems.Where(Function(x) x.Number = 98).SingleOrDefault.DescriptionValue
        End Get
    End Property

    Public ReadOnly Property StartCorrected() As Double Implements IVolume.StartCorrected
        Get
            If IsNothing(BeforeItems) Then Return Nothing

            Return BeforeItems.Where(Function(x) x.Number = 0).SingleOrDefault.NumericValue + ParseHighResReading(BeforeItems.Where(Function(x) x.Number = 113).SingleOrDefault.NumericValue)

        End Get
    End Property

    Public ReadOnly Property EndCorrected() As Double Implements IVolume.EndCorrected
        Get
            If IsNothing(AfterItems) Then Return Nothing

            Return AfterItems.Where(Function(x) x.Number = 0).SingleOrDefault.NumericValue + ParseHighResReading(AfterItems.Where(Function(x) x.Number = 113).SingleOrDefault.NumericValue)

        End Get
    End Property

    Public ReadOnly Property StartUncorrected() As Double Implements IVolume.StartunCorrected
        Get
            If IsNothing(BeforeItems) Then Return Nothing

            Return BeforeItems.Where(Function(x) x.Number = 2).SingleOrDefault.NumericValue + ParseHighResReading(BeforeItems.Where(Function(x) x.Number = 892).SingleOrDefault.NumericValue)

        End Get
    End Property

    Public ReadOnly Property EndUnCorrected() As Double Implements IVolume.EndUnCorrected
        Get
            If IsNothing(AfterItems) Then Return Nothing

            Return AfterItems.Where(Function(x) x.Number = 2).SingleOrDefault.NumericValue + ParseHighResReading(AfterItems.Where(Function(x) x.Number = 892).SingleOrDefault.NumericValue)
           

        End Get
    End Property

    Public ReadOnly Property UnCorrectedMultiplier() As Decimal Implements IVolume.UncorrectedMutliplier
        Get
            If IsNothing(BeforeItems) Then Return Nothing
            Return BeforeItems.Where(Function(x) x.Number = 92).SingleOrDefault.NumericValue
        End Get
    End Property

    Public ReadOnly Property CorrectedMultiplier() As Decimal Implements IVolume.CorrectedMultiplier
        Get
            If IsNothing(BeforeItems) OrElse BeforeItems.Count = 0 Then Return Nothing
            Return BeforeItems.Where(Function(x) x.Number = 90).SingleOrDefault.NumericValue
        End Get
    End Property

    Public ReadOnly Property UnCorrectedMultiplierDescription() As String Implements IVolume.UncorrectedMutliplierDescription
        Get
            If IsNothing(BeforeItems) Then Return Nothing
            Return BeforeItems.Where(Function(x) x.Number = 92).SingleOrDefault.DescriptionValue
        End Get
    End Property

    Public ReadOnly Property CorrectedMultiplierDescription() As String Implements IVolume.CorrectedMultiplierDescription
        Get
            If IsNothing(BeforeItems) OrElse BeforeItems.Count = 0 Then Return Nothing
            Return BeforeItems.Where(Function(x) x.Number = 90).SingleOrDefault.DescriptionValue
        End Get
    End Property

    Public Overridable ReadOnly Property InputUncVolume() As Double Implements IVolume.InputUncVolume
        Get
            Return (MeterDisplacement * AppliedInput)
        End Get
    End Property

    <JsonIgnore>
    Public ReadOnly Property PulseASelect() As String Implements IVolume.PulseASelect
        Get
            Try
                Return BeforeItems.Where(Function(x) x.Number = 93).SingleOrDefault.DescriptionValue

            Catch ex As Exception
                Return Nothing
            End Try
        End Get
    End Property

    <JsonIgnore>
    Public ReadOnly Property PulseBSelect() As String Implements IVolume.PulseBSelect
        Get
            Try
                Return BeforeItems.Where(Function(x) x.Number = 94).SingleOrDefault.DescriptionValue
            Catch ex As Exception
                Return Nothing
            End Try
        End Get
    End Property

    Public ReadOnly Property TrueCorrected() As Double Implements IVolume.TrueCorrected
        Get
            If TemperatureTest Is Nothing Then Return Nothing

            If EVCType = IVolume.EVCTypeEnum.Pressure Then
                Return (PressureFactor * InputUncVolume)
            ElseIf EVCType = IVolume.EVCTypeEnum.Temperature Then
                Return (TemperatureTest.TemperatureFactor * InputUncVolume)
            ElseIf EVCType = IVolume.EVCTypeEnum.PressureTemperature Then
                Return (PressureFactor * TemperatureTest.TemperatureFactor * Fpv2Factor * InputUncVolume)
            End If
            Return Nothing
        End Get
    End Property

    Public ReadOnly Property EvcUnCorrected() As Double
        Get
            Return Math.Round((EndUnCorrected - StartUncorrected) * UnCorrectedMultiplier, 4)

        End Get
    End Property

    Public ReadOnly Property EvcCorrected() As Double Implements IVolume.EvcCorrected
        Get
            Return Math.Round((EndCorrected - StartCorrected) * CorrectedMultiplier, 4)
        End Get
    End Property

    Public ReadOnly Property UnCorrectedPercentError() As Double
        Get
            If InputUncVolume <> 0 Then
                Return Math.Round(((EvcUnCorrected - InputUncVolume) / InputUncVolume) * 100, 2)
            Else
                Return -100

            End If
        End Get
    End Property

    Public ReadOnly Property CorrectedPercentError() As Double
        Get
            If TrueCorrected <> 0 Then
                Return Math.Round(((EvcCorrected - TrueCorrected) / TrueCorrected) * 100, 2)
            Else
                Return -100
            End If

        End Get
    End Property

    Public Overridable ReadOnly Property IdealAppliedInput(ByVal UncPulses As Integer) As Double
        Get
            Return (UncPulses * UnCorrectedMultiplier / MeterDisplacement)
        End Get
    End Property

    <JsonIgnore>
    Public Overridable ReadOnly Property MaxUnCorrected() As Double Implements IVolume.MaxUnCorrected
        Get
            If Me.UnCorrectedMultiplier = 10 Then
                Return _meterIndexpulses.UnCorPulsesX10
            ElseIf Me.UnCorrectedMultiplier = 100 Then
                Return _meterIndexpulses.UnCorPulsesX100
            End If
            Return 15
        End Get
    End Property

    Public ReadOnly Property HasPassed As Boolean Implements IVolume.HasPassed
        Get
            If UnCorrectedPercentError < 1 And UnCorrectedPercentError > -1 And CorrectedPercentError < 1 And CorrectedPercentError > -1 Then
                Return True
            Else
                Return False
            End If

        End Get
    End Property


    Public ReadOnly Property MeterDisplacementCubicMeters() As Double
        Get
            Return MeterDisplacement * CubicFeetToMeters
        End Get
    End Property

    Public ReadOnly Property UncPulseCounter As Integer
        Get
            If PulseASelect = "UncVol" Then
                Return PulserACount
            ElseIf PulseBSelect = "UncVol" Then
                Return PulserBCount
            Else
                Return PulseASelect
            End If
        End Get
    End Property

    Public ReadOnly Property MeterDisplacement As Decimal
        Get
            If _meterIndexpulses Is Nothing Then
                Return CDbl(BeforeItems.Where(Function(x) x.Number = 439).SingleOrDefault.NumericValue)
            End If
            Return _meterIndexpulses.MeterDisplacement
        End Get

    End Property
#End Region

#Region "Methods"


    'Returns 0.XXXX
    Private Function ParseHighResReading(HighResReading As Decimal) As Decimal

        Dim HighResString As String

        If HighResReading = 0 Then Return 0

        HighResString = HighResReading

        If HighResReading > 0 AndAlso HighResString.IndexOf(".") > -1 Then
            Return HighResString.Substring(HighResString.IndexOf("."), HighResString.Length() - HighResString.IndexOf("."))
        Else
            Return 0
        End If

    End Function


    Public Function RunTest(InstrumentType As InstrumentTypeCode, TemperatureTest As ITemperatureTestClass) As Task Implements IVolume.RunTest

        Me.TemperatureTest = TemperatureTest

        Return Task.Run(Async Function()
                            'Reset Tachometer
                            TachometerClass.ResetTach()
                            System.Threading.Thread.Sleep(1000)

                            PulserACount = 0
                            PulserBCount = 0

                            'Start Motor with Output Pulse
                            OutputBoard.PulseOut(USBDataAcqClass.MotorValues.mStart)

                            System.Threading.Thread.Sleep(500)


                            'Begin Listening for incoming pulses
                            Do
                                Me.PulserACount += InputABoard.ReadPulse()
                                NotifyPropertyChanged("PulserACount")
                                Me.PulserBCount += InputBBoard.ReadPulse()
                                NotifyPropertyChanged("PulserBCount")
                            Loop While UncPulseCounter < MaxUnCorrected

                            'Stop motor
                            OutputBoard.PulseOut(USBDataAcqClass.MotorValues.mStop)
                            System.Threading.Thread.Sleep(2000)

                            'Finally read tachometer
                            Me.AppliedInput = TachometerClass.ReadTach()



                            'Download post test items
                            AfterItems = Await BaseInstrument.DownloadItems(InstrumentType, AfterItems)
                            NotifyPropertyChanged("AppliedInput")
                            NotifyPropertyChanged("EndCorrected")
                            NotifyPropertyChanged("EndUnCorrected")
                            NotifyPropertyChanged("EvcUnCorrected")
                            NotifyPropertyChanged("EvcCorrected")
                            NotifyPropertyChanged("CorrectedPercentError")
                            NotifyPropertyChanged("UnCorrectedPercentError")
                        End Function)

    End Function


    Public Function IsMetric(ByVal UncMultiplierCode As IVolume.InstrumentVolumeUnitsEnum) As Boolean
        Select Case UncMultiplierCode
            Case IVolume.InstrumentVolumeUnitsEnum.m3
                Return True
            Case IVolume.InstrumentVolumeUnitsEnum.m3x10
                Return True
            Case IVolume.InstrumentVolumeUnitsEnum.m3x100
                Return True
            Case IVolume.InstrumentVolumeUnitsEnum.m3x1000
                Return True
            Case IVolume.InstrumentVolumeUnitsEnum.m3xPoint1
                Return True
        End Select
        Return False
    End Function

    Public Function GetVolumeMultipliers(ByVal MultiplierCode As IVolume.InstrumentVolumeUnitsEnum) As Double

        Select Case MultiplierCode
            Case IVolume.InstrumentVolumeUnitsEnum.CuFT
                Return 1
            Case IVolume.InstrumentVolumeUnitsEnum.CuFTx10
                Return 10
            Case IVolume.InstrumentVolumeUnitsEnum.CuFTx100
                Return 100
            Case IVolume.InstrumentVolumeUnitsEnum.CF
                Return 1
            Case IVolume.InstrumentVolumeUnitsEnum.CFx10
                Return 10
            Case IVolume.InstrumentVolumeUnitsEnum.CFx100
                Return 100
            Case IVolume.InstrumentVolumeUnitsEnum.CFx1000
                Return 1000
            Case IVolume.InstrumentVolumeUnitsEnum.CCF
                Return 100
            Case IVolume.InstrumentVolumeUnitsEnum.MCF
                Return 1000
            Case IVolume.InstrumentVolumeUnitsEnum.m3xPoint1
                Return 0.1
            Case IVolume.InstrumentVolumeUnitsEnum.m3
                Return 1
            Case IVolume.InstrumentVolumeUnitsEnum.m3x10
                Return 10
            Case IVolume.InstrumentVolumeUnitsEnum.m3x100
                Return 100
            Case IVolume.InstrumentVolumeUnitsEnum.m3x1000
                Return 1000
            Case IVolume.InstrumentVolumeUnitsEnum.CFx10000
                Return 10000
        End Select
        Return 0
    End Function

    Public Function GetMeterIndexRate(ByVal MeterCode As IVolume.InstrumentMeterIndexCodesEnum)
        Select Case MeterCode
            Case IVolume.InstrumentMeterIndexCodesEnum.CF1
                Return 1
            Case IVolume.InstrumentMeterIndexCodesEnum.CF5
                Return 5
            Case IVolume.InstrumentMeterIndexCodesEnum.CF10
                Return 10
            Case IVolume.InstrumentMeterIndexCodesEnum.CF100
                Return 100
            Case IVolume.InstrumentMeterIndexCodesEnum.CF1000
                Return 1000
            Case IVolume.InstrumentMeterIndexCodesEnum.m3Point1
                Return 0.1
            Case IVolume.InstrumentMeterIndexCodesEnum.m31
                Return 1
            Case IVolume.InstrumentMeterIndexCodesEnum.m310
                Return 10
            Case IVolume.InstrumentMeterIndexCodesEnum.m3100
                Return 100
            Case IVolume.InstrumentMeterIndexCodesEnum.CF10000
                Return 10000
            Case IVolume.InstrumentMeterIndexCodesEnum.CF0
                Return 0
            Case IVolume.InstrumentMeterIndexCodesEnum.CF50
                Return 50
            Case IVolume.InstrumentMeterIndexCodesEnum.CF500
                Return 500
            Case IVolume.InstrumentMeterIndexCodesEnum.RotaryIntegeralMount
                Return 14
        End Select

        Return 0
    End Function





#End Region

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    ' This method is called by the Set accessor of each property. 
    ' The CallerMemberName attribute that is applied to the optional propertyName 
    ' parameter causes the property name of the caller to be substituted as an argument. 
    Private Sub NotifyPropertyChanged(<CallerMemberName()> Optional ByVal propertyName As String = Nothing)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub


    Private Class MeterIndexInputPulses

        Sub New(ID As Integer, UnCorPulsesX10 As Integer, UnCorPulsesX100 As Integer, MeterDisplacement As Decimal)
            Me.Id = ID
            Me.UnCorPulsesX10 = UnCorPulsesX10
            Me.UnCorPulsesX100 = UnCorPulsesX100
            Me.MeterDisplacement = MeterDisplacement
        End Sub

        Public Property Id As Integer
        Public Property UnCorPulsesX10 As Integer
        Public Property UnCorPulsesX100 As Integer
        Public Property MeterDisplacement As Decimal
    End Class

End Class
