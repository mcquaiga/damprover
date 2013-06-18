Imports System.IO
Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Public Class PressureFactorClass
    Implements IPressureFactorClass, INotifyPropertyChanged

    Private _items As Dictionary(Of Integer, String)

    Public Property Items As Dictionary(Of Integer, String) Implements IPressureFactorClass.Items
        Get
            Return _items
        End Get
        Set(value As Dictionary(Of Integer, String))
            _items = value
            NotifyPropertyChanged("Items")
        End Set
    End Property

    Private _ATMPressure As Double
    Private _PreviousUnits
    Private Property _itemsXMLPath As String
    Private _levelIndex As Integer

    Sub New(Level As Integer)
        MyBase.New()
        _levelIndex = Level
    End Sub

#Region "Properties"

    Public Property GaugePressure As Double Implements IPressureFactorClass.GaugePressure

    Public Property AtmosphericPressure() As Double Implements IPressureFactorClass.AtmosphericPressure
        Get
            If Items IsNot Nothing AndAlso Transducer = IPressureFactorClass.TransducerType.Absolute Then
                Return Items(112)
            Else
                Return _ATMPressure
            End If
        End Get
        Set(value As Double)
            _ATMPressure = value
        End Set
    End Property

    Public ReadOnly Property PressureUnits As IPressureFactorClass.UnitsEnum Implements IPressureFactorClass.PressureUnits
        Get
            If IsNothing(Items) Then Return Nothing

            Return Items(87)
        End Get
    End Property

    Public ReadOnly Property Transducer() As IPressureFactorClass.TransducerType Implements IPressureFactorClass.Transducer
        Get
            If IsNothing(Items) Then Return Nothing
            Return Items(112)
        End Get
    End Property

    Public ReadOnly Property BasePressure As Double Implements IPressureFactorClass.BasePressure
        Get
            If IsNothing(Items) Then Return Nothing
            Return Items(13)
        End Get
    End Property

    Public ReadOnly Property EVCPressure() Implements IPressureFactorClass.EVCPressure
        Get
            If IsNothing(Items) Then Return Nothing
            Return Items(8)
        End Get
    End Property

    Public ReadOnly Property EVCFactor() Implements IPressureFactorClass.EVCFactor
        Get
            If IsNothing(Items) Then Return Nothing
            Return Items(44)
        End Get
    End Property

    Public ReadOnly Property EVCUnsqr() As Double Implements IPressureFactorClass.EVCUnsqr
        Get
            If IsNothing(Items) Then Return Nothing
            Return Items(47)
        End Get

    End Property

    Public ReadOnly Property PercentError() As Double Implements IPressureFactorClass.PercentError
        Get
            Return ((EVCFactor - ActualPressureFactor) / ActualPressureFactor) * 100
        End Get
    End Property

    Public ReadOnly Property ActualPressureFactor() As Double Implements IPressureFactorClass.ActualPressureFactor
        Get
            Dim pFactor As Double

            If BasePressure <> 0 Then
                If Transducer = IPressureFactorClass.TransducerType.Absolute Then
                    pFactor = (GaugePressure + AtmosphericPressure) / BasePressure
                Else
                    pFactor = (GaugePressure + AtmosphericPressure) / BasePressure
                End If
            End If
            Return pFactor
        End Get
    End Property

    ReadOnly Property hasPassed As Boolean Implements IPressureFactorClass.hasPassed
        Get
            If ActualPressureFactor < 1 And ActualPressureFactor > -1 Then
                Return True
            Else
                Return False
            End If
        End Get
    End Property

    Public ReadOnly Property LevelIndex As Integer Implements IPressureFactorClass.LevelIndex
        Get
            Return _levelIndex
        End Get
    End Property

    Public ReadOnly Property LevelDescription As String Implements IPressureFactorClass.LevelDescription
        Get
            Return "P" + CStr(_levelIndex)
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

    Public Function ConvertToPSI(ByVal Value As Double, ByVal FromUnit As IPressureFactorClass.UnitsEnum) As Double

        'Convert to PSI regardless of what it is
        Select Case FromUnit
            Case IPressureFactorClass.UnitsEnum.BAR
                Value = Value / (6.894757 * 10 ^ -2)
            Case IPressureFactorClass.UnitsEnum.inWC
                Value = Value / 27.68067
            Case IPressureFactorClass.UnitsEnum.KGcm2
                Value = Value / (7.030696 * 10 ^ -2)
            Case IPressureFactorClass.UnitsEnum.kPa
                Value = Value / 6.894757
            Case IPressureFactorClass.UnitsEnum.mBAR
                Value = Value / (6.894757 * 10 ^ 1)
            Case IPressureFactorClass.UnitsEnum.mPa
                Value = Value / (6.894757 * 10 ^ -3)
            Case IPressureFactorClass.UnitsEnum.PSIA
                Value = Value / 1
            Case IPressureFactorClass.UnitsEnum.PSIG
                Value = Value / 1
            Case IPressureFactorClass.UnitsEnum.inHG
                Value = Value / 2.03602
            Case IPressureFactorClass.UnitsEnum.mmHG
                Value = Value / 51.71492
        End Select

        Return Value
    End Function

#End Region


    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    ' This method is called by the Set accessor of each property. 
    ' The CallerMemberName attribute that is applied to the optional propertyName 
    ' parameter causes the property name of the caller to be substituted as an argument. 
    Private Sub NotifyPropertyChanged(<CallerMemberName()> Optional ByVal propertyName As String = Nothing)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub


End Class