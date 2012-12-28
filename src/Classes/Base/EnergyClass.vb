Public Class EnergyClass
    Public Enum EnergyItems
        Energy = 140
        EnergyUnits = 141
        GasEnergyValue = 142
    End Enum
    Public Enum EnergyUnits
        Therms = 0
        DecaTherms = 1
        MegaJoules = 2
        GigaJoules = 3
        KiloCals = 4
        KiloWattHrs = 5
    End Enum

    Private eStart As Double
    Private eEnd As Double
    Private eEVCCorrectedVolume As Double
    Private eUnits As EnergyUnits
    Private eGasValue As Double

    Sub New(ByVal StartReading As Double, ByVal EndReading As Double, ByVal EVCCorrectedVolume As Double, _
            ByVal EnergyUnits As EnergyUnits, ByVal GasEnergyValue As Double)
        eStart = StartReading
        eEnd = EndReading
        eEVCCorrectedVolume = EVCCorrectedVolume
        eUnits = EnergyUnits
        eGasValue = GasEnergyValue
    End Sub

#Region "Properties"
    Public Property StartReading() As Double
        Get
            Return eStart
        End Get
        Set(ByVal value As Double)
            eStart = value
        End Set
    End Property

    Public Property EndReading() As Double
        Get
            Return eEnd
        End Get
        Set(ByVal value As Double)
            eEnd = value
        End Set
    End Property

    Public Property EVCCorrectedVolume() As Double
        Get
            Return eEVCCorrectedVolume
        End Get
        Set(ByVal value As Double)
            eEVCCorrectedVolume = value
        End Set
    End Property

    Public Property Units() As EnergyUnits
        Get
            Return eUnits
        End Get
        Set(ByVal value As EnergyUnits)
            eUnits = value
        End Set
    End Property

    Public Property GasValue() As Double
        Get
            Return eGasValue
        End Get
        Set(ByVal value As Double)
            eGasValue = value
        End Set
    End Property

    Public ReadOnly Property ActualEnergy()
        Get
            If EVCCorrectedVolume > 0 Then
                If eUnits = EnergyUnits.Therms Then
                    Return Math.Round(EVCCorrectedVolume * eGasValue, 5) / 100000
                ElseIf eUnits = EnergyUnits.DecaTherms Then
                    Return Math.Round(EVCCorrectedVolume * eGasValue, 6) / 1000000
                ElseIf eUnits = EnergyUnits.MegaJoules Then
                    Return Math.Round(EVCCorrectedVolume * 0.028317 * eGasValue, 3) / 1000
                ElseIf eUnits = EnergyUnits.GigaJoules Then
                    Return Math.Round(EVCCorrectedVolume * 0.028317 * eGasValue, 6) / 1000000
                ElseIf eUnits = EnergyUnits.KiloCals Then
                    Return Math.Round(EVCCorrectedVolume * 0.0283168 * eGasValue, 0)
                Else
                    Return Math.Round(EVCCorrectedVolume * 0.028317 * eGasValue, 3) / 1000
                End If
            Else
                Return 0
            End If
        End Get
    End Property

    Public ReadOnly Property PercentError()
        Get
            Return (((eEnd - eStart) - ActualEnergy) / ActualEnergy) * 100
        End Get
    End Property
#End Region


End Class
