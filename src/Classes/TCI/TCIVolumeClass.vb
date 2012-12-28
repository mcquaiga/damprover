Public Class TCIVolumeClass : Inherits Volume

    'Author: Adam McQuaig
    'Date: January 9, 2009
    'Description: Inherits from TestClass and extends the InputUncVolume property to use meter displacement instead of drive rate
    ' This class can be used for the rotary and the tci module
    Public Enum MeterType
        NotApplicable = 0
        Roots2M = 1
        Roots3M = 2
        Roots5M = 3
        Roots7M = 4
        Roots11M = 5
        Roots16M = 6
        Roots23M = 7
        Roots38M = 8
        Roots56M = 9
        Roots102M = 10
        RM1000 = 11
        RM1500 = 12
        RM2000 = 13
        RM3000 = 14
        RM5000 = 15
        RM7000 = 16
        RM11000 = 17
        RM16000 = 18
        B38C = 19
        B311C = 20
        B315C = 21
        B32M = 22
        B33M = 23
        B35M = 24
    End Enum

    Public Shadows Enum GeneralVolumeItems
        MeterType = 433
        MeterDisplacement = 439
    End Enum

    Private vMeterDisplacement As Double
    Private vMaxUncorrected As Double


    Sub New()
        MyBase.New()
    End Sub

    Sub New(ByVal MeterType As MeterType)
        MyBase.New()
    End Sub

    Sub New(ByVal MeterType As Integer, ByVal EndCorrected As Double, ByVal StartCorrected As Double, ByVal CorrectedMultiplier As Integer, _
            ByVal TemperatureFactor As Double, ByVal AppliedTurns As Double, ByVal MeterDisplacement As Double)
        MyBase.New()
        Me.TempFactor = TemperatureFactor
        'Me.PressureFactor = PressureFactor
        'Me.Fpv2Factor = Fpv2
        Me.AppliedInput = AppliedTurns
        Me.EndCorrected = EndCorrected
        Me.StartCorrected = 0
        Me.CorrectedMultiplier = CorrectedMultiplier
        Me.EndUnCorrected = EndUnCorrected
        Me.StartUncorrected = StartUncorrected
        Me.UnCorrectedMultiplier = UnCorrectedMultiplier
        Me.DriveRate = driverate
        GetMaxUncorrected(MeterType)
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
            Return AppliedInput * MeterDisplacement
        End Get
    End Property


#Region "Methods"

    'This will come from the Database table MeterIndex and save to the base class Volume
    Private Sub GetMaxUncorrected(ByVal InstrumentCode As Integer)
        Me.MaxUncorrected = 10
    End Sub
#End Region
End Class
