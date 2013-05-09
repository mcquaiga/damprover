
Public Class TemperatureClass

    Public Enum UnitsEnum
        C = 1
        F = 0
        R = 2
        K = 3
    End Enum

    Public Enum TemperatureItems
        GasTemp = 26
        BaseTemp = 34
        TempFactor = 45
        TempUnits = 89
        FixedTempFactor = 111
    End Enum

    Private tUnits As UnitsEnum
    Private tPreviousUnits As UnitsEnum
    Private tGaugeTemperature As Double
    Private tBaseTemperature As Double
    Private tTempFactor As Double
    Private tEvcTemp As Double
    Private tEvcFactor As Double

    Private TempCorrection As Double = 459.67
    Private MetericTempCorrection As Double = 273.15

    Sub New()

    End Sub

    Sub New(ByVal TempItems As Collection)
        Me.Initialize(TempItems)
    End Sub

    Sub New(ByVal TemperatureUnits As UnitsEnum, ByVal GaugeTemperature As Double, ByVal BaseTemperature As Double)
        Me.TemperatureUnits = TemperatureUnits
        Me.GaugeTemperature = GaugeTemperature
        Me.BaseTemperature = BaseTemperature
        Me.EVCFactor = 0
        Me.EVCTemperature = 0
    End Sub

#Region "Properties"

    Public Property TemperatureUnits() As UnitsEnum
        Get
            Return tUnits
        End Get
        Set(ByVal value As UnitsEnum)
            'tPreviousUnits = tUnits
            tUnits = value
            'GaugeTemperature = Convert(GaugeTemperature)
            'BaseTemperature = Convert(BaseTemperature)
        End Set
    End Property

    Public Property GaugeTemperature() As Double
        Get
            Return tGaugeTemperature
        End Get
        Set(ByVal value As Double)
            tGaugeTemperature = value

        End Set
    End Property

    Public Property EVCTemperature() As Double
        Get
            Return tEvcTemp
        End Get
        Set(ByVal value As Double)
            tEvcTemp = value
        End Set
    End Property

    Public Property EVCFactor() As Double
        Get
            Return tEvcFactor
        End Get
        Set(ByVal value As Double)
            tEvcFactor = value
        End Set
    End Property

    Public Property BaseTemperature() As Double
        Get
            Return tBaseTemperature
        End Get
        Set(ByVal value As Double)
            tBaseTemperature = value
        End Set
    End Property

    Public ReadOnly Property TemperatureFactor() As Double
        Get
            If TemperatureUnits = UnitsEnum.C Or TemperatureUnits = UnitsEnum.K Then
                Return (MetericTempCorrection + BaseTemperature) / (GaugeTemperature + MetericTempCorrection)
            ElseIf TemperatureUnits = UnitsEnum.F Or TemperatureUnits = UnitsEnum.R Then
                Return (TempCorrection + BaseTemperature) / (GaugeTemperature + TempCorrection)
            End If

        End Get
    End Property

    Public ReadOnly Property PercentError() As Double
        Get
            Return ((EVCFactor - TemperatureFactor) / TemperatureFactor) * 100
        End Get
    End Property
#End Region

#Region "Methods"

    Public Function Convert(ByVal Value As Double) As Double

        'Convert to Fahrenheit first
        Select Case tPreviousUnits
            Case UnitsEnum.C
                Value = (Value * 1.8) + 32
            Case UnitsEnum.F
                Value = Value / 1
            Case UnitsEnum.K
                Value = ((Value - 273.15) * 1.8) + 32
            Case UnitsEnum.R
                Value = Value - 459.67
        End Select

        'And then to the current Units
        Select Case tUnits
            Case UnitsEnum.C
                Value = (Value - 32) / 1.8
            Case UnitsEnum.F
                Value = Value * 1
            Case UnitsEnum.K
                Value = ((Value - 32) / 1.8) + 273.15
            Case UnitsEnum.R
                Value = Value + 459.67
        End Select

        Return Math.Round(Value, 2)
    End Function

    Public Function ConvertToF(ByVal Value As Double, ByVal FromUnit As UnitsEnum) As Double
        'Convert to Fahrenheit first
        Select Case FromUnit
            Case UnitsEnum.C
                Value = (Value * 1.8) + 32
            Case UnitsEnum.F
                Value = Value / 1
            Case UnitsEnum.K
                Value = ((Value - 273.15) * 1.8) + 32
            Case UnitsEnum.R
                Value = Value - 459.67
        End Select
        Return Value
    End Function

    Public Function CalculateTemperature() As Double
        Dim Units As UnitsEnum
        Dim Temp As Double
        If TemperatureFactor <> 0 Then
            'Convert our BaseTemperature to farenheit for the calculation
            Units = Me.TemperatureUnits
            Me.TemperatureUnits = UnitsEnum.F

            Temp = (Convert(BaseTemperature) + TempCorrection - (TempCorrection * Me.TemperatureFactor)) / Me.TemperatureFactor
            'Set units back to what it was
            Me.tPreviousUnits = UnitsEnum.F
            Me.TemperatureUnits = Units
            Return Convert(Temp)
        Else
            Return 0
        End If
    End Function

    Public Sub WriteToXml(ByVal XmlWriter As Xml.XmlWriter)
        XmlWriter.WriteStartElement("Temperature")

        XmlWriter.WriteElementString("TemperatureUnits", Me.TemperatureUnits.ToString)
        XmlWriter.WriteElementString("Temperature", Me.GaugeTemperature)
        XmlWriter.WriteElementString("BaseTemp", Me.BaseTemperature)
        XmlWriter.WriteElementString("EVCTemp", Me.EVCTemperature)
        XmlWriter.WriteElementString("EVCFactor", Me.EVCFactor)
        XmlWriter.WriteElementString("PercentError", Format(Me.PercentError, "0.00"))
        XmlWriter.WriteElementString("TemperatureFactor", Me.TemperatureFactor)

        XmlWriter.WriteEndElement()
    End Sub

    Public Sub Initialize(ByVal Items As Collection)
        Dim ItemNumbers As Array = System.Enum.GetValues(GetType(TemperatureItems))
        Dim x As Integer
        Dim ItemName As TemperatureItems

        'If ItemNumbers.Length = Items.Count Then
        '    For Each item As ItemClass In Items
        '        Select Case 
        '            Case TemperatureItems.BaseTemp
        '                Me.BaseTemperature = item.value
        '            Case TemperatureItems.GasTemp
        '                Me.EVCTemperature = item.value
        '            Case TemperatureItems.TempFactor
        '                Me.EVCFactor = item.value
        '            Case TemperatureItems.TempUnits
        '                Me.tUnits = item.value
        '                Me.tPreviousUnits = item.value
        '        End Select
        '        x += 1
        '    Next
        'End If
    End Sub
#End Region

End Class
