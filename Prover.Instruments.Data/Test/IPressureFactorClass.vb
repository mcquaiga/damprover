Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Public Interface IPressureFactorClass
#Region "Enums"
    'Values for each enum will be the same as the values in the instrument
    Enum UnitsEnum
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

    Enum TransducerType
        Gauge = 0
        Absolute = 1
    End Enum

    Enum ItemsEnum
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

    Property Items As Dictionary(Of Integer, String)
    Property GaugePressure As Double
    Property AtmosphericPressure() As Double

    ReadOnly Property PressureUnits As UnitsEnum
    ReadOnly Property Transducer() As TransducerType
    ReadOnly Property BasePressure As Double
    ReadOnly Property EVCPressure()
    ReadOnly Property EVCFactor()
    ReadOnly Property EVCUnsqr() As Double
    ReadOnly Property PercentError() As Double
    ReadOnly Property ActualPressureFactor() As Double
    ReadOnly Property hasPassed As Boolean

    ReadOnly Property LevelIndex As Integer
    ReadOnly Property LevelDescription As String

    Sub NotifyPropertyChanged(<CallerMemberName()> Optional ByVal propertyName As String = Nothing)

End Interface
