Imports Prover.Prover.IVolume
Imports Prover.IVolume

Public Class Volume
    Inherits FactorClass

    Public Enum EVCTypeEnum
        Pressure
        Temperature
        PressureTemperature
    End Enum



    Sub New()
        MyBase.New()
    End Sub

#Region "Properties"

    Public Const CubicFeetToMeters = 0.0283168466

    Public Property BeforeItems As Dictionary(Of Integer, String)
    Public Property AfterItems As Dictionary(Of Integer, String)

    Public Property EVCType() As EVCTypeEnum
    Public Property TempFactor() As Double
    Public Property PressureFactor() As Double
    Public Property Fpv2Factor() As Double
    Public Overridable Property DriveRate() As Double
    Public Overridable Property MeterDisplacement() As Double
    Public Overridable Property EVCMeterDisplacement() As Double
    Public Property AppliedInput() As Double
    Public ReadOnly Property EndCorrected() As Double
        Get
            Return AfterItems(0)
        End Get
    End Property

    Public ReadOnly Property StartCorrected() As Double
        Get
            Return BeforeItems(0)
        End Get
    End Property

    Public ReadOnly Property StartUncorrected() As Double
        Get
            Return BeforeItems(2)
        End Get
    End Property

    Public ReadOnly Property EndUnCorrected() As Double
        Get
            Return AfterItems(2)
        End Get
    End Property

    Public ReadOnly Property UnCorrectedMultiplier() As Double
        Get
            Return BeforeItems(92)
        End Get
    End Property

    Public ReadOnly Property CorrectedMultiplier() As Double
        Get
            Return BeforeItems(90)
        End Get
    End Property

    Public Overridable ReadOnly Property InputUncVolume() As Double
        Get
            Return (DriveRate * AppliedInput)
        End Get
    End Property
    Public Overridable ReadOnly Property EVCInputUncVolume() As Double
        Get
            Return 0
        End Get
    End Property

    Public ReadOnly Property TrueCorrected() As Double
        Get
            If EVCType = EVCTypeEnum.Pressure Then
                Return (PressureFactor * InputUncVolume)
            ElseIf EVCType = EVCTypeEnum.Temperature Then
                Return (TempFactor * InputUncVolume)
            ElseIf EVCType = EVCTypeEnum.PressureTemperature Then
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

    Public ReadOnly Property EvcCorrected() As Double
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
            Return Items(33)
        End Get

    End Property

    Public Overridable ReadOnly Property UncCorMultiplerCode() As InstrumentVolumeUnitsEnum
        Get
            Return Items(92)
        End Get
    End Property

    Public Overridable ReadOnly Property CorMultiplierCode() As InstrumentVolumeUnitsEnum
        Get
            Return Items(90)
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

    Public Function IsMetric(ByVal UncMultiplierCode As InstrumentVolumeUnitsEnum) As Boolean
        Select Case UncMultiplierCode
            Case InstrumentVolumeUnitsEnum.m3
                Return True
            Case InstrumentVolumeUnitsEnum.m3x10
                Return True
            Case InstrumentVolumeUnitsEnum.m3x100
                Return True
            Case InstrumentVolumeUnitsEnum.m3x1000
                Return True
            Case InstrumentVolumeUnitsEnum.m3xPoint1
                Return True
        End Select
    End Function

    Public Function GetVolumeMultipliers(ByVal MultiplierCode As InstrumentVolumeUnitsEnum) As Double

        Select Case MultiplierCode
            Case InstrumentVolumeUnitsEnum.CuFT
                Return 1
            Case InstrumentVolumeUnitsEnum.CuFTx10
                Return 10
            Case InstrumentVolumeUnitsEnum.CuFTx100
                Return 100
            Case InstrumentVolumeUnitsEnum.CF
                Return 1
            Case InstrumentVolumeUnitsEnum.CFx10
                Return 10
            Case InstrumentVolumeUnitsEnum.CFx100
                Return 100
            Case InstrumentVolumeUnitsEnum.CFx1000
                Return 1000
            Case InstrumentVolumeUnitsEnum.CCF
                Return 100
            Case InstrumentVolumeUnitsEnum.MCF
                Return 1000
            Case InstrumentVolumeUnitsEnum.m3xPoint1
                Return 0.1
            Case InstrumentVolumeUnitsEnum.m3
                Return 1
            Case InstrumentVolumeUnitsEnum.m3x10
                Return 10
            Case InstrumentVolumeUnitsEnum.m3x100
                Return 100
            Case InstrumentVolumeUnitsEnum.m3x1000
                Return 1000
            Case InstrumentVolumeUnitsEnum.CFx10000
                Return 10000
        End Select

    End Function

    Public Function GetMeterIndexRate(ByVal MeterCode As InstrumentMeterIndexCodesEnum)
        Select Case MeterCode
            Case InstrumentMeterIndexCodesEnum.CF1
                Return 1
            Case InstrumentMeterIndexCodesEnum.CF5
                Return 5
            Case InstrumentMeterIndexCodesEnum.CF10
                Return 10
            Case InstrumentMeterIndexCodesEnum.CF100
                Return 100
            Case InstrumentMeterIndexCodesEnum.CF1000
                Return 1000
            Case InstrumentMeterIndexCodesEnum.m3Point1
                Return 0.1
            Case InstrumentMeterIndexCodesEnum.m31
                Return 1
            Case InstrumentMeterIndexCodesEnum.m310
                Return 10
            Case InstrumentMeterIndexCodesEnum.m3100
                Return 100
            Case InstrumentMeterIndexCodesEnum.CF10000
                Return 10000
            Case InstrumentMeterIndexCodesEnum.CF0
                Return 0
            Case InstrumentMeterIndexCodesEnum.CF50
                Return 50
            Case InstrumentMeterIndexCodesEnum.CF500
                Return 500
            Case InstrumentMeterIndexCodesEnum.RotaryIntegeralMount
                Return 14
        End Select

        Return 0
    End Function

End Class
