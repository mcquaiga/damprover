Imports System.IO


Public Class PressureFactorClass

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

    Public Enum PressureItemsEnum
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

    Private pGaugePressure As Double
    Private pAtmosphericPressure As Double
    Private pBasePressure As Double
    Private pUnits As UnitsEnum
    Private pPreviousUnits As UnitsEnum
    Private pEVCPressure As Double
    Private pEVCFactor As Double
    Private pEVcUnsqr As Double

    Private pTransducerType As TransducerType

    Sub New()

    End Sub

    Sub New(ByVal PressureItems As Collection)
        Me.Initialize(PressureItems)
    End Sub


    Sub New(ByVal Transducer As TransducerType, ByVal PressureUnits As UnitsEnum, ByVal GaugePressure As Double, ByVal AtmosphericPressure As Double, ByVal BasePressure As Double)
        pGaugePressure = GaugePressure
        pAtmosphericPressure = AtmosphericPressure
        pBasePressure = BasePressure
        Me.PressureUnits = PressureUnits
        Me.Transducer = Transducer
    End Sub


#Region "Properties"

    Public Property PressureUnits() As UnitsEnum
        Get
            Return pUnits
        End Get
        Set(ByVal value As UnitsEnum)
            'pPreviousUnits = pUnits
            pUnits = value
            'GaugePressure = Convert(GaugePressure)
            'AtmosphericPressure = Convert(AtmosphericPressure)
            'BasePressure = Convert(BasePressure)
        End Set
    End Property

    Public Property GaugePressure() As Double
        Get
            Return pGaugePressure
        End Get
        Set(ByVal value As Double)
            pGaugePressure = value
        End Set
    End Property

    Public Property AtmosphericPressure() As Double
        Get
            Return pAtmosphericPressure
        End Get
        Set(ByVal value As Double)
            pAtmosphericPressure = value
        End Set
    End Property

    Public Property BasePressure() As Double
        Get
            Return pBasePressure
        End Get
        Set(ByVal value As Double)
            pBasePressure = value
        End Set
    End Property

    Public Property Transducer() As TransducerType
        Get
            Return pTransducerType
        End Get
        Set(ByVal value As TransducerType)
            pTransducerType = value
        End Set
    End Property

    Public Property EVCPressure()
        Get
            Return pEVCPressure
        End Get
        Set(ByVal value)
            pEVCPressure = value
        End Set
    End Property

    Public Property EVCFactor()
        Get
            Return pEVCFactor
        End Get
        Set(ByVal value)
            pEVCFactor = value
        End Set
    End Property

    Public Property EVCUnsqr() As Double
        Get
            Return pEVCUnsqr
        End Get
        Set(ByVal value As Double)
            pEVCUnsqr = value
        End Set
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
        Select Case pPreviousUnits
            Case UnitsEnum.BAR
                pValue = pValue / (6.894757 * 10 ^ -2)
            Case UnitsEnum.inWC
                pValue = pValue / 27.68067
            Case UnitsEnum.KGcm2
                pValue = pValue / (7.030696 * 10 ^ -2)
            Case UnitsEnum.kPa
                pValue = pValue / 6.894757
            Case UnitsEnum.mBAR
                pValue = pValue / (6.894757 * 10 ^ 1)
            Case UnitsEnum.mPa
                pValue = pValue / (6.894757 * 10 ^ -3)
            Case UnitsEnum.PSIA
                pValue = pValue / 1
            Case UnitsEnum.PSIG
                pValue = pValue / 1
            Case UnitsEnum.inHG
                pValue = pValue / 2.03602
            Case UnitsEnum.mmHG
                pValue = pValue / 51.71492
        End Select

        'Convert from PSI to the requested Units
        Select Case PressureUnits
            Case UnitsEnum.BAR
                pValue = pValue * (6.894757 * 10 ^ -2)
            Case UnitsEnum.inWC
                pValue = pValue * 27.68067
            Case UnitsEnum.KGcm2
                pValue = pValue * (7.030696 * 10 ^ -2)
            Case UnitsEnum.kPa
                pValue = pValue * 6.894757
            Case UnitsEnum.mBAR
                pValue = pValue * (6.894757 * 10 ^ 1)
            Case UnitsEnum.mPa
                pValue = pValue * (6.894757 * 10 ^ -3)
            Case UnitsEnum.PSIA
                pValue = pValue * 1
            Case UnitsEnum.PSIG
                pValue = pValue * 1
            Case UnitsEnum.inHG
                pValue = pValue * 2.03602
            Case UnitsEnum.mmHG
                pValue = pValue * 51.71492
        End Select

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

    Public Sub WriteToXML(ByVal XmlWriter As Xml.XmlWriter)
        XmlWriter.WriteStartElement("Pressure")

        XmlWriter.WriteElementString("Pressure", GaugePressure)
        XmlWriter.WriteElementString("AtmPressure", AtmosphericPressure)
        XmlWriter.WriteElementString("BasePressure", BasePressure)
        XmlWriter.WriteElementString("PressureUnits", PressureUnits.ToString)
        XmlWriter.WriteElementString("TransducerType", Transducer.ToString)
        XmlWriter.WriteElementString("EVCPressure", Me.EVCPressure)
        XmlWriter.WriteElementString("EVCFactor", Me.EVCFactor)
        XmlWriter.WriteElementString("PercentError", Me.PercentError)
        XmlWriter.WriteElementString("ActualPressureFactor", ActualPressureFactor)

        XmlWriter.WriteEndElement()
    End Sub

    'Call this to set the properties of this class
    'Items in the collection must correspond to the PressureEnum from the TestClass
    Public Sub Initialize(ByVal Items As Collection)
        Dim ItemNumbers As Array = System.Enum.GetValues(GetType(PressureItemsEnum))
        Dim x As Integer
        Dim ItemName As PressureItemsEnum

        If ItemNumbers.Length = Items.Count Then
            For Each item As miSerialProtocol.ItemClass In Items
                ItemName = ItemNumbers(x)
                Select Case ItemName
                    Case PressureItemsEnum.AtmPressure
                        Me.AtmosphericPressure = item.value
                    Case PressureItemsEnum.UnsquaredSuperFactor
                        Me.EVCUnsqr = item.value
                    Case PressureItemsEnum.BasePressure
                        Me.BasePressure = item.value
                    Case PressureItemsEnum.GasPressure
                        Me.EVCPressure = item.value
                    Case PressureItemsEnum.PressureUnits
                        Me.pUnits = item.value
                        Me.pPreviousUnits = item.value
                    Case PressureItemsEnum.TransducerType
                        Me.Transducer = item.value
                    Case PressureItemsEnum.PressureFactor
                        Me.EVCFactor = item.value
                End Select
                x += 1
            Next
        End If
    End Sub

#End Region

End Class