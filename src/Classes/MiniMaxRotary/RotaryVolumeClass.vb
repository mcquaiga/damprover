Imports MySql.Data.MySqlClient

Public Class RotaryVolumeClass : Inherits Volume

    'Author: Adam McQuaig
    'Date: November 5, 2007
    'Description: Inherits from TestClass and extends the InputUncVolume property to use meter displacement instead of drive rate
    ' This class can be used for the rotary and the tci module
    Public Shadows Enum GeneralVolumeItems
        MeterType = 432
        MeterDisplacement = 439
    End Enum

    Private vMeterDisplacement As Double
    Private vEvcMeterDisplacement As Double
    Private vMaxUncorrected As Double
    Private vMeterType As Integer
    Private vMeterTypeString As String = Nothing
    Private mySql As New MySQLLibrary.Database


    Sub New()
        MyBase.New()
    End Sub

    Sub New(ByVal MeterType As Integer)
        MyBase.New()
        Me.MeterTypeNumber = MeterType
    End Sub

    Sub New(ByVal MeterType As Integer, ByVal EndCorrected As Double, ByVal StartCorrected As Double, ByVal CorrectedMultiplier As Integer, ByVal PressureFactor As Double, _
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

    Public Overrides Property EVCMeterDisplacement() As Double
        Get
            Return vEvcMeterDisplacement
        End Get
        Set(ByVal value As Double)
            vEvcMeterDisplacement = value
        End Set
    End Property

    Public Overrides ReadOnly Property IdealAppliedInput(ByVal UncPulses As Integer) As Double
        Get
            Return (UncPulses * UnCorrectedMultiplier / MeterDisplacement)
        End Get
    End Property

    Public Overrides ReadOnly Property InputUncVolume() As Double
        Get

            Return AppliedInput * MeterDisplacement
        End Get
    End Property

    Public Overrides ReadOnly Property EVCInputUncVolume() As Double
        Get
            Return AppliedInput * EVCMeterDisplacement
        End Get
    End Property

    Public Overrides ReadOnly Property MeterTypeName() As String
        Get
            Try
                If vMeterTypeString = Nothing Then
                    Dim db As New MySqlConnection
                    db = mySql.OpenMySQL()
                    Using mysqlcmd As New MySqlCommand
                        With mysqlcmd
                            .Connection = db
                            .CommandText = "SELECT * FROM meter_index WHERE meter_index_id =" & MeterTypeNumber
                            .CommandType = CommandType.Text
                            Dim myReader As MySqlDataReader = .ExecuteReader
                            If myReader.HasRows Then
                                myReader.Read()
                                vMeterTypeString = myReader.GetString("type")
                                Me.MeterDisplacement = myReader.GetDouble("MeterDisplacement")
                            End If
                        End With
                    End Using
                End If
                Return vMeterTypeString
            Catch ex As Exception
                Throw New Exception(ex.Message & vbNewLine & "Function() MeterTypeName in RotaryVolumeClass")
            End Try

        End Get
    End Property

    Public Overrides Property MeterTypeNumber() As Integer
        Get
            Return vMeterType
        End Get
        Set(ByVal value As Integer)
            vMeterType = value
        End Set
    End Property

#Region "Methods"

    'This will come from the Database table MeterIndex and save to the base class Volume
    'To be implemented, if we decide to have the max uncorrected pulses in the database
    Private Sub GetMaxUncorrected(ByVal InstrumentCode As Integer)
        Me.MaxUncorrected = 10
    End Sub
#End Region

End Class