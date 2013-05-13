Imports System.IO


Public Class PressureFactorClass
    Inherits FactorClass

#Region "Enums"
    'Values for each enum will be the same as the values in the instrument
    Public Enum UnitsEnum
        PSIG = 0
        PSIA = 1
        kPa = 2
        mPa = 3
        BAR = 4
        mBAR = 5
        KGcm2 = 6
        inWC = 7
        inHG = 8
        mmHG = 9
    End Enum

    Public Enum TransducerType
        Gauge = 0
        Absolute = 1
    End Enum

    Public Enum ItemsEnum
        GasPressure = 8
        BasePressure = 13
        ATMPressure = 14
        PressureUnits = 87
        FixedPressureFactor = 109
        TransducerType = 112
        PressureFactor = 44
        UnsquaredSuperFactor = 47
    End Enum
#End Region

    Private _ATMPressure As Double
    Private _PreviousUnits
    Private Property _itemsXMLPath As String

    Sub New()
        MyBase.New()
    End Sub

#Region "Properties"

    Public Property GaugePressure As Double

    Public Property AtmosphericPressure() As Double
        Get
            If Items IsNot Nothing AndAlso Transducer = TransducerType.Absolute Then
                Return Items(112)
            Else
                Return _ATMPressure
            End If
        End Get
        Set(value As Double)
            _ATMPressure = value
        End Set
    End Property

    Public ReadOnly Property PressureUnits As UnitsEnum
        Get
            Return Items(87)
        End Get
    End Property

    Public ReadOnly Property Transducer() As TransducerType
        Get
            Return Items(112)
        End Get
    End Property

    Public ReadOnly Property BasePressure As Double
        Get
            Return Items(13)
        End Get
    End Property

    Public ReadOnly Property EVCPressure()
        Get
            Return Items(8)
        End Get
    End Property

    Public ReadOnly Property EVCFactor()
        Get
            Return Items(44)
        End Get
    End Property

    Public ReadOnly Property EVCUnsqr() As Double
        Get
            Return Items(47)
        End Get

    End Property

    Public ReadOnly Property PercentError() As Double
        Get
            Return ((EVCFactor - ActualPressureFactor) / ActualPressureFactor) * 100
        End Get
    End Property

    Public ReadOnly Property ActualPressureFactor() As Double
        Get
            Dim pFactor As Double

            If BasePressure <> 0 Then
                If Transducer = TransducerType.Absolute Then
                    pFactor = (GaugePressure + AtmosphericPressure) / BasePressure
                Else
                    pFactor = (GaugePressure + AtmosphericPressure) / BasePressure
                End If
            End If
            Return pFactor
        End Get
    End Property


#End Region

#Region "Methods"

    'Convert any values to PSI so we can calculate other unit values
    'I may move this to a conversion class in the future so everything can use it
    Public Function Convert(ByVal pValue As Double) As Double

        'Convert to PSI
        'Select Case pPreviousUnits
        '    Case UnitsEnum.BAR
        '        pValue = pValue / (6.894757 * 10 ^ -2)
        '    Case UnitsEnum.inWC
        '        pValue = pValue / 27.68067
        '    Case UnitsEnum.KGcm2
        '        pValue = pValue / (7.030696 * 10 ^ -2)
        '    Case UnitsEnum.kPa
        '        pValue = pValue / 6.894757
        '    Case UnitsEnum.mBAR
        '        pValue = pValue / (6.894757 * 10 ^ 1)
        '    Case UnitsEnum.mPa
        '        pValue = pValue / (6.894757 * 10 ^ -3)
        '    Case UnitsEnum.PSIA
        '        pValue = pValue / 1
        '    Case UnitsEnum.PSIG
        '        pValue = pValue / 1
        '    Case UnitsEnum.inHG
        '        pValue = pValue / 2.03602
        '    Case UnitsEnum.mmHG
        '        pValue = pValue / 51.71492
        'End Select

        ''Convert from PSI to the requested Units
        'Select Case PressureUnits
        '    Case UnitsEnum.BAR
        '        pValue = pValue * (6.894757 * 10 ^ -2)
        '    Case UnitsEnum.inWC
        '        pValue = pValue * 27.68067
        '    Case UnitsEnum.KGcm2
        '        pValue = pValue * (7.030696 * 10 ^ -2)
        '    Case UnitsEnum.kPa
        '        pValue = pValue * 6.894757
        '    Case UnitsEnum.mBAR
        '        pValue = pValue * (6.894757 * 10 ^ 1)
        '    Case UnitsEnum.mPa
        '        pValue = pValue * (6.894757 * 10 ^ -3)
        '    Case UnitsEnum.PSIA
        '        pValue = pValue * 1
        '    Case UnitsEnum.PSIG
        '        pValue = pValue * 1
        '    Case UnitsEnum.inHG
        '        pValue = pValue * 2.03602
        '    Case UnitsEnum.mmHG
        '        pValue = pValue * 51.71492
        'End Select

        Return pValue
    End Function

    Public Function ConvertToPSI(ByVal Value As Double, ByVal FromUnit As UnitsEnum) As Double

        'Convert to PSI regardless of what it is
        Select Case FromUnit
            Case UnitsEnum.BAR
                Value = Value / (6.894757 * 10 ^ -2)
            Case UnitsEnum.inWC
                Value = Value / 27.68067
            Case UnitsEnum.KGcm2
                Value = Value / (7.030696 * 10 ^ -2)
            Case UnitsEnum.kPa
                Value = Value / 6.894757
            Case UnitsEnum.mBAR
                Value = Value / (6.894757 * 10 ^ 1)
            Case UnitsEnum.mPa
                Value = Value / (6.894757 * 10 ^ -3)
            Case UnitsEnum.PSIA
                Value = Value / 1
            Case UnitsEnum.PSIG
                Value = Value / 1
            Case UnitsEnum.inHG
                Value = Value / 2.03602
            Case UnitsEnum.mmHG
                Value = Value / 51.71492
        End Select

        Return Value
    End Function

#End Region

End Class