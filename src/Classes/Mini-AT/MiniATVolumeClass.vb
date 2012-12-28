Public Class MiniATVolumeClass : Inherits Volume

    'Author: Adam McQuaig
    'Date: November 5, 2007
    'Description: Inherits from TestClass and extends the InputUncVolume property to use meter displacement instead of drive rate
    ' This class can be used for the rotary and the tci module
    Public Shadows Enum GeneralVolumeItems
        DriveRate = 98
    End Enum

    Private vMeterDisplacement As Double
    Private vMaxUncorrected As Double
    Private vMechReading As Integer


    Sub New()
        MyBase.New()
    End Sub


    Sub New(ByVal EndCorrected As Double, ByVal StartCorrected As Double, ByVal CorrectedMultiplier As Integer, ByVal PressureFactor As Double, _
            ByVal TemperatureFactor As Double, ByVal Fpv2 As Double, ByVal AppliedTurns As Double, ByVal MeterDisplacement As Double)
        MyBase.New()
        Me.TempFactor = TemperatureFactor
        Me.PressureFactor = PressureFactor
        Me.Fpv2Factor = Fpv2
        Me.AppliedInput = AppliedTurns
        Me.EndCorrected = EndCorrected
        Me.StartCorrected = 0
        Me.CorrectedMultiplier = CorrectedMultiplier
        Me.EndUnCorrected = EndUnCorrected
        Me.StartUncorrected = StartUncorrected
        Me.UnCorrectedMultiplier = UnCorrectedMultiplier
        Me.MeterDisplacement = MeterDisplacement

    End Sub

    Public Overrides Property MaxUncorrected() As Double
        Get
            Return vMaxUncorrected
        End Get
        Set(ByVal value As Double)
            vMaxUncorrected = value
        End Set
    End Property

    Public Overrides Property MeterDisplacement() As Double
        Get
            Return vMeterDisplacement
        End Get
        Set(ByVal value As Double)
            vMeterDisplacement = value
        End Set
    End Property

    Public Overrides ReadOnly Property InputUncVolume() As Double
        Get
            Return AppliedInput * DriveRate
        End Get
    End Property

    Public Overrides ReadOnly Property UncCorMechVolume() As Integer
        Get
            Return vMechReading * Me.UnCorrectedMultiplier
        End Get
    End Property

    Public Overrides ReadOnly Property MechanicalPass() As Boolean
        Get
            If UncCorMechVolume = InputUncVolume Then
                Return True
            Else
                Return False
            End If
        End Get
    End Property

#Region "Methods"

#End Region

End Class
