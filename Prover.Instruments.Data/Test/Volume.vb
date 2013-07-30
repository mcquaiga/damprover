Imports Newtonsoft.Json

Public Class Volume
    Implements IVolume


    Sub New()
        MyBase.New()
    End Sub

#Region "Properties"

    Public Const CubicFeetToMeters = 0.0283168466


    <JsonIgnore>
    Public Property BeforeItems As Dictionary(Of Integer, String) Implements IVolume.BeforeItems

    <JsonIgnore>
    Public Property AfterItems As Dictionary(Of Integer, String) Implements IVolume.AfterItems

    Public Property EVCType() As IVolume.EVCTypeEnum Implements IVolume.EVCType
    Public Property TempFactor() As Double Implements IVolume.TempFactor
    Public Property PressureFactor() As Double Implements IVolume.PressureFactor
    Public Property Fpv2Factor() As Double Implements IVolume.Fpv2
    Public Overridable Property DriveRate() As Double Implements IVolume.DriveRate
    Public Overridable Property MeterDisplacement() As Double Implements IVolume.MeterDisplacement
    Public Overridable Property EVCMeterDisplacement() As Double Implements IVolume.EvcMeterDisplacement
    Public Property AppliedInput() As Double Implements IVolume.AppliedInput

    Public ReadOnly Property EndCorrected() As Double Implements IVolume.EndCorrected
        Get
            If IsNothing(AfterItems) Then Return Nothing
            Return AfterItems(0)
        End Get
    End Property

    Public ReadOnly Property StartCorrected() As Double Implements IVolume.StartCorrected
        Get
            If IsNothing(BeforeItems) Then Return Nothing
            Return BeforeItems(0) '+ BeforeItems(113)
        End Get
    End Property

    Public ReadOnly Property StartUncorrected() As Double Implements IVolume.StartunCorrected
        Get
            If IsNothing(BeforeItems) Then Return Nothing
            Return BeforeItems(2)
        End Get
    End Property

    Public ReadOnly Property EndUnCorrected() As Double Implements IVolume.EndUnCorrected
        Get
            If IsNothing(AfterItems) Then Return Nothing
            Return AfterItems(2)
        End Get
    End Property

    Public ReadOnly Property UnCorrectedMultiplier() As Double Implements IVolume.UncorrectedMutliplier
        Get
            If IsNothing(BeforeItems) Then Return Nothing
            Return BeforeItems(92)
        End Get
    End Property

    Public ReadOnly Property CorrectedMultiplier() As Double Implements IVolume.CorrectedMultiplier
        Get
            If IsNothing(BeforeItems) Then Return Nothing
            Return BeforeItems(90)
        End Get
    End Property

    Public Overridable ReadOnly Property InputUncVolume() As Double Implements IVolume.InputUncVolume
        Get
            Return (DriveRate * AppliedInput)
        End Get
    End Property
    Public Overridable ReadOnly Property EVCInputUncVolume() As Double
        Get
            Return 0
        End Get
    End Property

    Public ReadOnly Property TrueCorrected() As Double Implements IVolume.TrueCorrected
        Get
            If EVCType = IVolume.EVCTypeEnum.Pressure Then
                Return (PressureFactor * InputUncVolume)
            ElseIf EVCType = IVolume.EVCTypeEnum.Temperature Then
                Return (TempFactor * InputUncVolume)
            ElseIf EVCType = IVolume.EVCTypeEnum.PressureTemperature Then
                Return (PressureFactor * TempFactor * Fpv2Factor * InputUncVolume)
            End If
            Return Nothing
        End Get
    End Property

    Public ReadOnly Property EvcUnCorrected() As Double
        Get
            Return (EndUnCorrected - StartUncorrected) * UnCorrectedMultiplier

        End Get
    End Property

    Public ReadOnly Property EvcCorrected() As Double Implements IVolume.EvcCorrected
        Get
            Return (EndCorrected - StartCorrected) * CorrectedMultiplier
        End Get
    End Property

    Public ReadOnly Property UnCorrectedPercentError() As Double
        Get
            If InputUncVolume <> 0 Then
                Return ((EvcUnCorrected - InputUncVolume) / InputUncVolume) * 100
            Else
                Return -100

            End If
        End Get
    End Property

    Public ReadOnly Property CorrectedPercentError() As Double
        Get
            If TrueCorrected <> 0 Then
                Return ((EvcCorrected - TrueCorrected) / TrueCorrected) * 100
            Else
                Return -100
            End If

        End Get
    End Property

    Public Overridable ReadOnly Property IdealAppliedInput(ByVal UncPulses As Integer) As Double
        Get
            Return 0
        End Get
    End Property

    'Public Overridable Property MaxUnCorrected() As Double
    '    Get
    '        Return MaxUnCorrected
    '    End Get

    'End Property

    Public Overridable ReadOnly Property MeterTypeName() As String
        Get
            Return Nothing
        End Get

    End Property

    Public Overridable ReadOnly Property MeterTypeNumber() As Integer
        Get
            If IsNothing(BeforeItems) Then Return Nothing
            Return BeforeItems(33)
        End Get

    End Property

    Public Overridable ReadOnly Property UncCorMultiplerCode() As IVolume.InstrumentVolumeUnitsEnum
        Get
            If IsNothing(BeforeItems) Then Return Nothing
            Return BeforeItems(92)
        End Get
    End Property

    Public Overridable ReadOnly Property CorMultiplierCode() As IVolume.InstrumentVolumeUnitsEnum
        Get
            If IsNothing(BeforeItems) Then Return Nothing
            Return BeforeItems(90)
        End Get

    End Property

    Public ReadOnly Property MeterDisplacementCubicMeters() As Double
        Get
            Return MeterDisplacement * CubicFeetToMeters
        End Get
    End Property


    Public Property MechanicalReading() As Integer
    Public Overridable ReadOnly Property UncCorMechVolume() As Integer
        Get
            Return Math.Abs(MechanicalReading * Me.UnCorrectedMultiplier)
        End Get
    End Property

    Public Overridable ReadOnly Property MechanicalPass() As Boolean
        Get
            If UncCorMechVolume = InputUncVolume Then
                Return True
            Else
                Return False
            End If
        End Get
    End Property
#End Region

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


    Public Property CorCode As IVolume.InstrumentVolumeUnitsEnum Implements IVolume.CorCode


    Public Property MaxUnCorrected As Double Implements IVolume.MaxUnCorrected

    Public Property MechReading As Integer Implements IVolume.MechReading

    Public Property MeterTypeNumber1 As Integer Implements IVolume.MeterTypeNumber

    Public Property MeterTypeString As String Implements IVolume.MeterTypeString

    Public Property PulserA As Double Implements IVolume.PulserA

    Public Property PulserB As Double Implements IVolume.PulserB

    Public Property UnCorCode As IVolume.InstrumentVolumeUnitsEnum Implements IVolume.UnCorCode

    Public Property VolumeData As String Implements IVolume.VolumeData
End Class
