Public Class Volume




    'Sub New()
    '    TempFactor = 0
    '    PressureFactor = 0
    '    Fpv2Factor = 0
    '    EndCorrected = 0
    '    StartCorrected = 0
    '    CorrectedMultiplier = 0
    '    UnCorrectedMultiplier = 0
    '    AppliedInput = 0
    '    DriveRate = 0
    'End Sub

    'Sub New(ByVal EndCorrected As Double, ByVal StartCorrected As Double, ByVal CorrectedMultiplier As Integer, ByVal PressureFactor As Double, _
    '            ByVal TemperatureFactor As Double, ByVal Fpv2 As Double, ByVal AppliedTurns As Double, ByVal DriveRate As Double, _
    '            ByVal EndUnCorrected As Double, ByVal StartUnCorrected As Double, ByVal UnCorrectedMultiplier As Integer)
    '    Me.TempFactor = TemperatureFactor
    '    Me.PressureFactor = PressureFactor
    '    Me.Fpv2Factor = Math.Pow(Fpv2, 2)
    '    Me.AppliedInput = AppliedTurns
    '    Me.EndCorrected = EndCorrected
    '    Me.StartCorrected = StartCorrected
    '    Me.CorrectedMultiplier = CorrectedMultiplier
    '    Me.DriveRate = DriveRate
    '    Me.EndUnCorrected = EndUnCorrected
    '    Me.StartUncorrected = StartUnCorrected
    '    Me.UnCorrectedMultiplier = UnCorrectedMultiplier
    'End Sub

    '#Region "Properties"
    '    Public Property EVCType() As EVCTypeEnum
    '        Get
    '            Return vEVCType
    '        End Get
    '        Set(ByVal value As EVCTypeEnum)
    '            vEVCType = value
    '        End Set
    '    End Property

    '    Public Property TempFactor() As Double
    '        Get
    '            Return vTempFactor
    '        End Get
    '        Set(ByVal value As Double)
    '            vTempFactor = value

    '        End Set
    '    End Property

    '    Public Property PressureFactor() As Double
    '        Get
    '            Return vPressureFactor
    '        End Get
    '        Set(ByVal value As Double)
    '            vPressureFactor = value

    '        End Set
    '    End Property

    '    Public Property Fpv2Factor() As Double
    '        Get
    '            Return vFpv2
    '        End Get
    '        Set(ByVal value As Double)
    '            vFpv2 = value

    '        End Set
    '    End Property

    '    Public Overridable Property DriveRate() As Double
    '        Get
    '            Return vDriveRate
    '        End Get
    '        Set(ByVal value As Double)
    '            vDriveRate = value

    '        End Set
    '    End Property

    '    Public Overridable Property MeterDisplacement() As Double
    '        Get
    '            Return vMeterDisplacement
    '        End Get
    '        Set(ByVal value As Double)
    '            Me.vMeterDisplacement = value
    '        End Set
    '    End Property
    '    Public Overridable Property EVCMeterDisplacement() As Double
    '        Get
    '            Return vEvcMeterDisplacement
    '        End Get
    '        Set(ByVal value As Double)
    '            vEvcMeterDisplacement = value

    '        End Set
    '    End Property

    '    Public Property AppliedInput() As Double
    '        Get
    '            Return vAppliedInput
    '        End Get
    '        Set(ByVal value As Double)
    '            vAppliedInput = value

    '        End Set
    '    End Property

    '    Public Property EndCorrected() As Double
    '        Get
    '            Return vEndCorrected
    '        End Get
    '        Set(ByVal value As Double)
    '            vEndCorrected = value

    '        End Set
    '    End Property

    '    Public Property StartCorrected() As Double
    '        Get
    '            Return vStartCorrected
    '        End Get
    '        Set(ByVal value As Double)
    '            vStartCorrected = value
    '        End Set
    '    End Property

    '    Public Property StartUncorrected() As Double
    '        Get
    '            Return vStartunCorrected
    '        End Get
    '        Set(ByVal value As Double)
    '            vStartunCorrected = value
    '        End Set
    '    End Property

    '    Public Property EndUnCorrected() As Double
    '        Get
    '            Return vEndUnCorrected
    '        End Get
    '        Set(ByVal value As Double)
    '            vEndUnCorrected = value
    '        End Set
    '    End Property

    '    Public Property UnCorrectedMultiplier() As Double
    '        Get
    '            Return vUncorrectedMutliplier
    '        End Get
    '        Set(ByVal value As Double)
    '            vUncorrectedMutliplier = value
    '        End Set
    '    End Property

    '    Public Property CorrectedMultiplier() As Double
    '        Get
    '            Return vCorrectedMultiplier
    '        End Get
    '        Set(ByVal value As Double)
    '            vCorrectedMultiplier = value
    '        End Set
    '    End Property

    '    Public Overridable ReadOnly Property InputUncVolume() As Double
    '        Get
    '            Return (DriveRate * AppliedInput)
    '        End Get
    '    End Property
    '    Public Overridable ReadOnly Property EVCInputUncVolume() As Double
    '        Get
    '            Return 0
    '        End Get
    '    End Property

    '    Public ReadOnly Property TrueCorrected() As Double
    '        Get
    '            If EVCType = EVCTypeEnum.Pressure Then
    '                Return (PressureFactor * InputUncVolume)
    '            ElseIf EVCType = EVCTypeEnum.Temperature Then
    '                Return (TempFactor * InputUncVolume)
    '            ElseIf EVCType = EVCTypeEnum.PressureTemperature Then
    '                Return (PressureFactor * TempFactor * Fpv2Factor * InputUncVolume)
    '            End If
    '        End Get
    '    End Property

    '    Public ReadOnly Property EvcUnCorrected() As Double
    '        Get
    '            Return (vEndUnCorrected - vStartunCorrected) * vUncorrectedMutliplier
    '        End Get
    '    End Property

    '    Public ReadOnly Property EvcCorrected() As Double
    '        Get
    '            Return (vEndCorrected - vStartCorrected) * vCorrectedMultiplier
    '        End Get
    '    End Property

    '    Public ReadOnly Property UnCorrectedPercentError() As Double
    '        Get
    '            If InputUncVolume <> 0 Then
    '                Return ((EvcUnCorrected - InputUncVolume) / InputUncVolume) * 100
    '            Else
    '                Return -100

    '            End If
    '        End Get
    '    End Property

    '    Public ReadOnly Property CorrectedPercentError() As Double
    '        Get
    '            If TrueCorrected <> 0 Then
    '                Return ((EvcCorrected - TrueCorrected) / TrueCorrected) * 100
    '            Else
    '                Return -100
    '            End If

    '        End Get
    '    End Property

    '    Public Overridable ReadOnly Property IdealAppliedInput(ByVal UncPulses As Integer) As Double
    '        Get
    '            Return 0
    '        End Get
    '    End Property

    '    Public Property PulserA()
    '        Get
    '            Return vPulserA
    '        End Get
    '        Set(ByVal value)
    '            vPulserA = value
    '        End Set
    '    End Property

    '    Public Property PulserB()
    '        Get
    '            Return vPulserB
    '        End Get
    '        Set(ByVal value)
    '            vPulserB = value
    '        End Set
    '    End Property

    '    Public Overridable Property MaxUnCorrected() As Double
    '        Get
    '            Return vMaxUnCorrected
    '        End Get
    '        Set(ByVal value As Double)
    '            vMaxUnCorrected = value
    '        End Set
    '    End Property

    '    Public Overridable ReadOnly Property MeterTypeName() As String
    '        Get
    '            'Try
    '            '    If vMeterTypeString = Nothing Then
    '            '        Dim db As New MySqlConnection
    '            '        db = mySql.OpenMySQL()
    '            '        Using mysqlcmd As New MySqlCommand
    '            '            With mysqlcmd
    '            '                .Connection = db
    '            '                .CommandText = "SELECT * FROM meter_index WHERE meter_index_id =" & MeterTypeNumber
    '            '                .CommandType = CommandType.Text
    '            '                Dim myReader As MySqlDataReader = .ExecuteReader
    '            '                If myReader.HasRows Then
    '            '                    myReader.Read()
    '            '                    vMeterTypeString = myReader.GetString("type")
    '            '                    Me.MeterDisplacement = myReader.GetDouble("meterdisplacement")
    '            '                End If
    '            '            End With
    '            '        End Using
    '            '    End If
    '            '    Return vMeterTypeString
    '            'Catch ex As Exception
    '            '    Throw New Exception(ex.Message & vbNewLine & "Function() MeterTypeName in RotaryVolumeClass")
    '            'End Try
    '            Return Nothing
    '        End Get

    '    End Property

    '    Public Overridable Property MeterTypeNumber() As Integer
    '        Get
    '            Return vMeterTypeNumber
    '        End Get
    '        Set(ByVal value As Integer)
    '            vMeterTypeNumber = value
    '        End Set
    '    End Property

    '    Public Overridable Property UncCorMultiplerCode() As InstrumentVolumeUnitsEnum
    '        Get
    '            Return vUnCorCode
    '        End Get
    '        Set(ByVal value As InstrumentVolumeUnitsEnum)
    '            vUnCorCode = value
    '        End Set
    '    End Property

    '    Public Overridable Property CorMultiplierCode() As InstrumentVolumeUnitsEnum
    '        Get
    '            Return vCorCode
    '        End Get
    '        Set(ByVal value As InstrumentVolumeUnitsEnum)
    '            vCorCode = value
    '        End Set
    '    End Property

    '    Public ReadOnly Property MeterDisplacementCubicMeters() As Double
    '        Get
    '            Return MeterDisplacement * CubicFeetToMeters
    '        End Get
    '    End Property


    '    Public Property MechanicalReading() As Integer
    '        Get
    '            Return vMechReading
    '        End Get
    '        Set(ByVal value As Integer)
    '            vMechReading = value
    '        End Set
    '    End Property
    '    Public Overridable ReadOnly Property UncCorMechVolume() As Integer
    '        Get
    '            Return Math.Abs(vMechReading * Me.UnCorrectedMultiplier)
    '        End Get
    '    End Property

    '    Public Overridable ReadOnly Property MechanicalPass() As Boolean
    '        Get
    '            If UncCorMechVolume = InputUncVolume Then
    '                Return True
    '            Else
    '                Return False
    '            End If
    '        End Get
    '    End Property
    '#End Region

    '    Public Function IsMetric(ByVal UncMultiplierCode As InstrumentVolumeUnitsEnum) As Boolean
    '        Select Case UncMultiplierCode
    '            Case InstrumentVolumeUnitsEnum.m3
    '                Return True
    '            Case InstrumentVolumeUnitsEnum.m3x10
    '                Return True
    '            Case InstrumentVolumeUnitsEnum.m3x100
    '                Return True
    '            Case InstrumentVolumeUnitsEnum.m3x1000
    '                Return True
    '            Case InstrumentVolumeUnitsEnum.m3xPoint1
    '                Return True
    '        End Select
    '    End Function

    '    Public Function GetVolumeMultipliers(ByVal MultiplierCode As InstrumentVolumeUnitsEnum) As Double

    '        Select Case MultiplierCode
    '            Case InstrumentVolumeUnitsEnum.CuFT
    '                Return 1
    '            Case InstrumentVolumeUnitsEnum.CuFTx10
    '                Return 10
    '            Case InstrumentVolumeUnitsEnum.CuFTx100
    '                Return 100
    '            Case InstrumentVolumeUnitsEnum.CF
    '                Return 1
    '            Case InstrumentVolumeUnitsEnum.CFx10
    '                Return 10
    '            Case InstrumentVolumeUnitsEnum.CFx100
    '                Return 100
    '            Case InstrumentVolumeUnitsEnum.CFx1000
    '                Return 1000
    '            Case InstrumentVolumeUnitsEnum.CCF
    '                Return 100
    '            Case InstrumentVolumeUnitsEnum.MCF
    '                Return 1000
    '            Case InstrumentVolumeUnitsEnum.m3xPoint1
    '                Return 0.1
    '            Case InstrumentVolumeUnitsEnum.m3
    '                Return 1
    '            Case InstrumentVolumeUnitsEnum.m3x10
    '                Return 10
    '            Case InstrumentVolumeUnitsEnum.m3x100
    '                Return 100
    '            Case InstrumentVolumeUnitsEnum.m3x1000
    '                Return 1000
    '            Case InstrumentVolumeUnitsEnum.CFx10000
    '                Return 10000
    '        End Select

    '    End Function

    '    Public Function GetMeterIndexRate(ByVal MeterCode As InstrumentMeterIndexCodesEnum)
    '        Select Case MeterCode
    '            Case InstrumentMeterIndexCodesEnum.CF1
    '                Return 1
    '            Case InstrumentMeterIndexCodesEnum.CF5
    '                Return 5
    '            Case InstrumentMeterIndexCodesEnum.CF10
    '                Return 10
    '            Case InstrumentMeterIndexCodesEnum.CF100
    '                Return 100
    '            Case InstrumentMeterIndexCodesEnum.CF1000
    '                Return 1000
    '            Case InstrumentMeterIndexCodesEnum.m3Point1
    '                Return 0.1
    '            Case InstrumentMeterIndexCodesEnum.m31
    '                Return 1
    '            Case InstrumentMeterIndexCodesEnum.m310
    '                Return 10
    '            Case InstrumentMeterIndexCodesEnum.m3100
    '                Return 100
    '            Case InstrumentMeterIndexCodesEnum.CF10000
    '                Return 10000
    '            Case InstrumentMeterIndexCodesEnum.CF0
    '                Return 0
    '            Case InstrumentMeterIndexCodesEnum.CF50
    '                Return 50
    '            Case InstrumentMeterIndexCodesEnum.CF500
    '                Return 500
    '            Case InstrumentMeterIndexCodesEnum.RotaryIntegeralMount
    '                Return 14
    '        End Select

    '        Return 0
    '    End Function

    '    Public Function GetCollection() As Collection

    '        Return vItems

    '    End Function

End Class
