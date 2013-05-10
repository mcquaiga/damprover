Public MustInherit Class TestClass
    ' Implements IDisposable

    '#Region "Enums"

    '    Public Enum TemperatureLevels
    '        Low = 3
    '        Mid = 2
    '        High = 1
    '    End Enum

    '    Public Enum PressureLevels
    '        High = 3
    '        Mid = 2
    '        Low = 1
    '    End Enum

    '    Public Enum SuperLevels
    '        HighPLowT = 3
    '        MidPMidT = 2
    '        LowPHighT = 1
    '    End Enum

    '    Public Enum TestLevels
    '        Before = 1
    '        After = 2
    '    End Enum

    '    Public Enum SuperFactorItemsEnum
    '        AuxFactor = 46
    '        UnSquaredSuperFactor = 47
    '    End Enum

    '    Public Enum TransducerTypesEnum
    '        Gauge = 0
    '        Absolute = 1
    '    End Enum

    '    Public Enum ItemsToSet
    '        CorrectedVolume = 0
    '        UnCorrectedVolume = 2
    '        PulseAWaiting = 5
    '        PulseBWaiting = 6
    '        Energy = 140
    '    End Enum

    '    Public Enum ProverType
    '        InputVolumeType = 433
    '    End Enum

    '    Public Enum REIVolumeTypeCodes
    '        InstrumentDrive = 0
    '        RotaryType1 = 1
    '        Type1Proving = 3
    '        BiDirectional = 4
    '        RotaryType2 = 9
    '        Type2Proving = 11
    '    End Enum

    '#End Region

    '    Private tCustomer As Customer
    '    'Protected tInstrument As Instrument

    '    Private TempItems As Collection
    '    Private PressItems As Collection
    '    Private VolItems As Collection
    '    Friend tPulserACount As Integer
    '    Friend tPulserBCount As Integer
    '    Friend tUnCorPulseCount As Integer

    '    Public Shared Event CurrentEvent()

    '    Private tPulseA As DABoard
    '    Private tPulseB As DABoard
    '    ' Private tPulseASelect As Instrument.PulseOutputValues
    '    'Private tPulseBSelect As Instrument.PulseOutputValues

    '    Public Shared Event UnCorrectedPulses(ByVal Total As Integer)
    '    Public Shared Event RcvPulseA(ByVal Count As Integer)
    '    Public Shared Event RcvPulseB(ByVal Count As Integer)
    '    Public Shared Event RcvUncorrected(ByVal Count As Integer)

    '    Sub New(ByVal CustomerID As Integer)
    '        ' Me.Customer = New Customer(CustomerID)
    '    End Sub

    '#Region "Properties"
    '    Public Property Customer() As Customer
    '        Get
    '            Return tCustomer
    '        End Get
    '        Set(ByVal value As Customer)
    '            tCustomer = value
    '        End Set
    '    End Property

    '    Public ReadOnly Property ResetItems() As Collection
    '        Get
    '            Dim myArray As Array = System.Enum.GetValues(GetType(ItemsToSet))
    '            Dim myCollection As New Collection
    '            Dim item As Integer

    '            For Each item In myArray
    '                myCollection.Add(item, item.ToString)
    '            Next

    '            Return myCollection
    '        End Get
    '    End Property

    '    Public Overridable Property Instrument() As Instrument
    '        Get
    '            Return tInstrument
    '        End Get
    '        Set(ByVal value As Instrument)
    '            tInstrument = value
    '        End Set
    '    End Property

    '    Public ReadOnly Property VolumeItems() As Collection
    '        Get
    '            Dim myArray As Array = System.Enum.GetValues(GetType(Volume.VolumeTestItems))
    '            Dim myCollection As New Collection
    '            Dim item As Integer

    '            For Each item In myArray
    '                myCollection.Add(item, item.ToString)
    '            Next

    '            Return myCollection
    '        End Get
    '    End Property

    '    Public ReadOnly Property PressureItems() As Collection
    '        Get
    '            Dim myArray As Array = System.Enum.GetValues(GetType(PressureFactorClass.PressureItemsEnum))
    '            Dim myCollection As New Collection
    '            Dim item As Integer

    '            For Each item In myArray
    '                myCollection.Add(item, item.ToString)
    '            Next

    '            Return myCollection
    '        End Get
    '    End Property

    '    Public ReadOnly Property TemperatureItems() As Collection
    '        Get
    '            Dim myArray As Array = System.Enum.GetValues(GetType(TemperatureClass.TemperatureItems))
    '            Dim myCollection As New Collection
    '            Dim item As Integer

    '            For Each item In myArray
    '                myCollection.Add(item, item.ToString)
    '            Next

    '            Return myCollection
    '        End Get
    '    End Property

    '    Public Property PulseA() As DABoard
    '        Get
    '            Return tPulseA
    '        End Get
    '        Set(ByVal value As DABoard)
    '            tPulseA = value
    '        End Set
    '    End Property

    '    Public Property PulseB() As DABoard
    '        Get
    '            Return tPulseB
    '        End Get
    '        Set(ByVal value As DABoard)
    '            tPulseB = value
    '        End Set
    '    End Property

    '    'Properties for the inherited class to use for events raised
    '    Public Property MaxUnCorrectedEvent() As Integer
    '        Get

    '        End Get
    '        Set(ByVal value As Integer)
    '            RaiseEvent UnCorrectedPulses(value)
    '        End Set
    '    End Property

    '    Public Property PulseACount() As Integer
    '        Get
    '            Return tPulserACount
    '        End Get
    '        Set(ByVal value As Integer)
    '            tPulserACount += value
    '            RaiseEvent RcvPulseA(tPulserACount)
    '        End Set
    '    End Property

    '    Public Property PulseBCount() As Integer
    '        Get
    '            Return tPulserBCount
    '        End Get
    '        Set(ByVal value As Integer)
    '            tPulserBCount += value
    '            RaiseEvent RcvPulseB(tPulserBCount)
    '        End Set
    '    End Property

    '    Public Property UnCorCount() As Integer
    '        Get
    '            Return tUnCorPulseCount
    '        End Get
    '        Set(ByVal value As Integer)
    '            tUnCorPulseCount = value
    '            RaiseEvent RcvUncorrected(tUnCorPulseCount)
    '        End Set
    '    End Property
    '#End Region

    '    Public Overridable Sub PreTest(Optional ByVal Retest As Boolean = False)

    '        'To test a corrector we must follow these steps
    '        '************************
    '        'LoadItems
    '        'Connect to Instrument
    '        'Download all items
    '        'Reset starting values
    '        'Test temperatures
    '        'Test pressures
    '        'Reset the tachometer
    '        'StartMotor
    '        'Read all pulse inputs
    '        'Stop motor when we hit the desired number
    '        'Download volume items
    '        '************************

    '        Dim VolumeCollection As New Collection
    '        Dim PressureCollection As New Collection
    '        Dim TemperatureCollection As New Collection
    '        Dim Temp As New TemperatureClass
    '        Dim Pressure As New PressureFactorClass


    '        Instrument.LoadInstrumentItems()
    '        Customer.GetCustomerItems()
    '        Instrument.Connect()
    '        'Download all items
    '        Me.Instrument.AllItems = Instrument.DownloadItems(Me.Instrument.AllItems)

    '        For Each item As Integer In ResetItems
    '            Instrument.InstrumentSrl.WD(item, 0)
    '        Next

    '        'Disconnect from instrument
    '        Me.Instrument.InstrumentSrl.Disconnect()
    '        Me.Instrument.Volume = New Volume()

    '        If Retest = False Then
    '            TestPT(Instrument, PressureLevels.Low, TemperatureLevels.High)
    '            TestPT(Instrument, PressureLevels.Mid, TemperatureLevels.Mid)
    '        End If


    '        Instrument.PulseASelect = Me.Instrument.GetItemValue(Instrument.PulseOutputItems.PulserA).value
    '        Instrument.PulseBSelect = Me.Instrument.GetItemValue(Instrument.PulseOutputItems.PulserB).value
    '    End Sub

    '    Public Overridable Function PostTest() As DialogResult
    '        'End of test we need to: 
    '        '   test 80% pressure and 32F temperature 
    '        '   download items
    '        '   reset the desired items
    '        '   calculate all factors
    '        '   display an end of test dialog
    '        '   either display inspection certificate or close test
    '        Dim VolumeColl As New Collection


    '        TestPT(Instrument, PressureLevels.High, TemperatureLevels.Low)

    '        'Get Volume Items
    '        Instrument.InstrumentSrl.Connect()
    '        VolumeColl = Instrument.DownloadItems(VolumeItems)
    '        Instrument.WriteItems(Customer.WriteAfterItems, Customer.WriteAfterValues)
    '        'Set Instrument Date and Time
    '        If My.Settings.SetInstrumentDateTime = True Then
    '            If Instrument.SetInstrumentDateTime() = False Then
    '                MessageBox.Show("Failed to set instrument date and time.", "Date & Time", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            End If
    '        End If

    '        Instrument.InstrumentSrl.Disconnect()
    '        If Instrument.InstrumentDriveType = Instrument.DriveType.Mechanical Then
    '            Instrument.Energy = New EnergyClass(0, VolumeColl.Item(CStr(Volume.VolumeTestItems.Energy)).value, Instrument.Volume.EvcCorrected, Instrument.GetItemValue(EnergyClass.EnergyItems.EnergyUnits).value, Instrument.GetItemValue(EnergyClass.EnergyItems.GasEnergyValue).value)
    '        End If

    '        Me.Instrument.Volume.EndCorrected = VolumeColl.Item(CStr(Volume.VolumeTestItems.CorrectedVolume)).value + Mid(VolumeColl.Item(CStr(Volume.VolumeTestItems.HighResCorrected)).value, 4)
    '        Try
    '            Me.Instrument.Volume.EndUnCorrected = VolumeColl.Item(CStr(Volume.VolumeTestItems.UnCorrectedVolume)).value + Mid(VolumeColl.Item(CStr(Volume.VolumeTestItems.HighResUnCorrected)).value, 4)
    '        Catch ex As Exception
    '            Me.Instrument.Volume.EndUnCorrected = VolumeColl.Item(CStr(Volume.VolumeTestItems.UnCorrectedVolume)).value
    '        End Try

    '        Me.Instrument.FillInstrumentVolume()

    '        Dim TestStatus As New TestCompleteDialog
    '        TestStatus.Instrument = Me.Instrument
    '        TestStatus.StartPosition = FormStartPosition.CenterParent
    '        TestStatus.ShowDialog()

    '        If TestStatus.DialogResult = DialogResult.Yes Then
    '            Instrument.SaveInstrument()
    '            Return DialogResult.OK
    '        ElseIf TestStatus.DialogResult = DialogResult.Retry Then
    '            Return DialogResult.Retry
    '        Else
    '            Return DialogResult.OK
    '        End If
    '    End Function


    '    Public Sub TestPT(ByRef Instrument As Instrument, ByVal PressureLevel As PressureLevels, ByVal TempLevel As TemperatureLevels)

    '        Dim VolumeCollection As New Collection
    '        Dim PressureCollection As New Collection
    '        Dim TemperatureCollection As New Collection
    '        Dim Temp As New TemperatureClass
    '        Dim Pressure As New PressureFactorClass
    '        Dim Super As New SuperFactorClass

    '        Dim retry As Boolean = False

    '        If My.Settings.UncVolumeOnly = False Then
    '            If Instrument.LivePressure = Instrument.FixedFactors.Live Then
    '                If Instrument.LiveTemp = Instrument.FixedFactors.Live Then
    '                    'Test low pressure and high temperature together, first
    '                    'Instrument.Temperatures(TemperatureLevels.High) = New TemperatureClass
    '                    'Need a dialog box to pop up here, first figure out if user wants manual or automatic,
    '                    'then check for transducer type
    '                    If My.Settings.LowPressureHighTemp = "Auto" Then
    '                        Dim frm As New PTAutoDialog(Instrument.InstrumentSrl)
    '                        frm.Text = PressureLevel.ToString & " Pressure & " & TempLevel.ToString & " Temperature"
    '                        If Instrument.GetItemValue(Instrument.ItemsEnum.TransducerType).value = TransducerTypesEnum.Absolute Then
    '                            frm.ATMTextBox.Visible = True
    '                            frm.ATMLabel.Visible = True
    '                        Else
    '                            frm.ATMLabel.Visible = False
    '                            frm.ATMTextBox.Visible = False
    '                        End If
    '                        frm.pressureUnits = Me.Instrument.GetItemValue(PressureFactorClass.PressureItemsEnum.PressureUnits).value
    '                        frm.tempUnits = Me.Instrument.GetItemValue(TemperatureClass.TemperatureItems.TempUnits).value
    '                        frm.ShowDialog()
    '                        System.Threading.Thread.Sleep(1000)
    '                        Instrument.InstrumentSrl.Connect()
    '                        PressureCollection = Instrument.DownloadItems(Me.PressureItems)
    '                        TemperatureCollection = Instrument.DownloadItems(Me.TemperatureItems)
    '                        Instrument.Disconnect()

    '                        'Pressure Items
    '                        If Instrument.GetItemValue(Instrument.ItemsEnum.TransducerType).value = TransducerTypesEnum.Absolute Then
    '                            Pressure.AtmosphericPressure = frm.ATMTextBox.Text
    '                        Else
    '                            Pressure.AtmosphericPressure = Me.Instrument.GetItemValue(Instrument.ItemsEnum.AtmosphericPressure).value
    '                        End If
    '                        Pressure.BasePressure = Me.Instrument.GetItemValue(Instrument.ItemsEnum.BasePressure).value
    '                        Pressure.PressureUnits = Me.Instrument.GetItemValue(Instrument.ItemsEnum.PressureUnits).value
    '                        Pressure.Transducer = Me.Instrument.GetItemValue(Instrument.ItemsEnum.TransducerType).value
    '                        Pressure.EVCPressure = PressureCollection.Item(CStr(PressureFactorClass.PressureItemsEnum.GasPressure)).value
    '                        Pressure.EVCFactor = PressureCollection.Item(CStr(PressureFactorClass.PressureItemsEnum.PressureFactor)).value
    '                        Pressure.EVCUnsqr = PressureCollection.Item(CStr(PressureFactorClass.PressureItemsEnum.UnsquaredSuperFactor)).value

    '                        'Temp Items
    '                        Temp.BaseTemperature = Me.Instrument.GetItemValue(Instrument.ItemsEnum.BaseTemp).value
    '                        Temp.TemperatureUnits = Me.Instrument.GetItemValue(Instrument.ItemsEnum.TempUnits).value
    '                        Temp.EVCTemperature = TemperatureCollection.Item(CStr(TemperatureClass.TemperatureItems.GasTemp)).value
    '                        Temp.EVCFactor = TemperatureCollection.Item(CStr(TemperatureClass.TemperatureItems.TempFactor)).value

    '                        Pressure.GaugePressure = frm.GaugePressureTextBox.Text
    '                        Temp.GaugeTemperature = frm.GaugeTempTextBox.Text

    '                        'Super Factor Items
    '                        Super.CO2 = Instrument.GetItemValue(SuperFactorClass.SuperFactorItems.CO2).value
    '                        Super.N2 = Instrument.GetItemValue(SuperFactorClass.SuperFactorItems.N2).value
    '                        Super.SpecGr = Instrument.GetItemValue(SuperFactorClass.SuperFactorItems.SpecGR).value
    '                        Super.GaugePressure = Pressure.ConvertToPSI(Pressure.GaugePressure, Pressure.PressureUnits)
    '                        Super.GaugeTemp = Temp.ConvertToF(Temp.GaugeTemperature, Temp.TemperatureUnits)
    '                        Super.EVCUnsqrSuper = Pressure.EVCUnsqr
    '                        Super.CalculatePercentError()



    '                        If Temp.PercentError <= My.Settings.TempPercentageMax And Temp.PercentError >= (-My.Settings.TempPercentageMax) Then
    '                        Else
    '                            Dim input As DialogResult = MessageBox.Show("Percent error: " & Format(Temp.PercentError, "#0.0000") & vbNewLine & "Would you like to retry?", "Temp Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error)
    '                            If input = DialogResult.Retry Then
    '                                retry = True
    '                                TestPT(Instrument, PressureLevel, TempLevel)
    '                            ElseIf input = DialogResult.Abort Then
    '                                Me.Dispose()
    '                            End If
    '                        End If

    '                        If Pressure.PercentError <= My.Settings.PressurePercentageMax And Pressure.PercentError >= (-My.Settings.PressurePercentageMax) Then

    '                        Else
    '                            Dim input As DialogResult = MessageBox.Show("Percent error: " & Format(Pressure.PercentError, "#0.0000") & vbNewLine & "Would you like to retry?", "Pressure Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error)
    '                            If input = DialogResult.Retry Then
    '                                retry = True
    '                                TestPT(Instrument, PressureLevel, TempLevel)
    '                            ElseIf input = DialogResult.Abort Then
    '                                Throw New Exception("Test Cancelled.")
    '                            End If
    '                        End If
    '                        If retry = False Then
    '                            Instrument.Pressures.Add(Pressure, PressureLevel)
    '                            Instrument.Temperatures.Add(Temp, TempLevel)
    '                            Instrument.SuperFactors.Add(Super, TempLevel)
    '                        End If
    '                    Else
    '                        'If manual test settings are selected
    '                    End If
    '                Else
    '                    'Just test the Pressure Factors
    '                    If My.Settings.LowPressureHighTemp = "Auto" Then
    '                        Dim frm As New PAutoDialog(Instrument.InstrumentSrl)
    '                        frm.Text = PressureLevel.ToString
    '                        If Instrument.GetItemValue(Instrument.ItemsEnum.TransducerType).value = TransducerTypesEnum.Absolute Then
    '                            frm.ATMTextBox.Visible = True
    '                            frm.ATMLabel.Visible = True
    '                        Else
    '                            frm.ATMLabel.Visible = False
    '                            frm.ATMTextBox.Visible = False
    '                        End If
    '                        frm.pressureUnits = Me.Instrument.GetItemValue(PressureFactorClass.PressureItemsEnum.PressureUnits).value
    '                        frm.ShowDialog()
    '                        System.Threading.Thread.Sleep(1000)
    '                        If Instrument.GetItemValue(Instrument.ItemsEnum.TransducerType).value = TransducerTypesEnum.Absolute Then
    '                            Pressure.AtmosphericPressure = frm.ATMTextBox.Text
    '                        Else
    '                            Pressure.AtmosphericPressure = Instrument.GetItemValue(Instrument.ItemsEnum.AtmosphericPressure).value
    '                        End If

    '                        Instrument.Connect()
    '                        PressureCollection = Instrument.DownloadItems(Me.PressureItems)
    '                        Instrument.Disconnect()

    '                        'Pressure Items
    '                        Pressure.BasePressure = Me.Instrument.GetItemValue(Instrument.ItemsEnum.BasePressure).value
    '                        Pressure.PressureUnits = Me.Instrument.GetItemValue(Instrument.ItemsEnum.PressureUnits).value
    '                        Pressure.Transducer = Me.Instrument.GetItemValue(Instrument.ItemsEnum.TransducerType).value
    '                        Pressure.EVCPressure = PressureCollection.Item(CStr(PressureFactorClass.PressureItemsEnum.GasPressure)).value
    '                        Pressure.EVCFactor = PressureCollection.Item(CStr(PressureFactorClass.PressureItemsEnum.PressureFactor)).value
    '                        Pressure.EVCUnsqr = PressureCollection.Item(CStr(PressureFactorClass.PressureItemsEnum.UnsquaredSuperFactor)).value
    '                        Pressure.GaugePressure = frm.GaugePressureTextBox.Text
    '                        If Pressure.PercentError <= My.Settings.PressurePercentageMax And Pressure.PercentError >= (-My.Settings.PressurePercentageMax) Then
    '                            Instrument.Pressures.Add(Pressure, PressureLevel)
    '                        Else
    '                            Dim input As DialogResult = MessageBox.Show("Percent error: " & Format(Pressure.PercentError, "#0.0000") & vbNewLine & "Would you like to retry?", "Pressure Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error)
    '                            If input = DialogResult.Retry Then
    '                                TestPT(Instrument, PressureLevel, TempLevel)
    '                            ElseIf input = DialogResult.Ignore Then
    '                                Instrument.Pressures.Add(Pressure, PressureLevel)
    '                            ElseIf input = DialogResult.Abort Then
    '                                Throw New Exception("Test Cancelled.")
    '                            End If
    '                        End If
    '                    End If
    '                End If

    '            ElseIf Instrument.LiveTemp = Instrument.FixedFactors.Live Then
    '                'Just test temperature factors\
    '                If My.Settings.LowPressureHighTemp = "Auto" Then
    '                    Dim frm As New TAutoDialog(Instrument.InstrumentSrl)
    '                    frm.temp_units = Instrument.GetItemValue(TemperatureClass.TemperatureItems.TempUnits).value
    '                    frm.Text = TempLevel.ToString
    '                    frm.ShowDialog()

    '                    System.Threading.Thread.Sleep(1000)
    '                    Temp.GaugeTemperature = frm.GaugeTempTextBox.Text
    '                    Instrument.Connect()
    '                    TemperatureCollection = Instrument.DownloadItems(Me.TemperatureItems)
    '                    Instrument.Disconnect()

    '                    'Temp Items
    '                    Temp.BaseTemperature = Me.Instrument.GetItemValue(Instrument.ItemsEnum.BaseTemp).value
    '                    Temp.TemperatureUnits = Me.Instrument.GetItemValue(Instrument.ItemsEnum.TempUnits).value
    '                    Temp.EVCTemperature = TemperatureCollection.Item(CStr(TemperatureClass.TemperatureItems.GasTemp)).value
    '                    Temp.EVCFactor = TemperatureCollection.Item(CStr(TemperatureClass.TemperatureItems.TempFactor)).value
    '                    If Temp.PercentError <= My.Settings.TempPercentageMax And Temp.PercentError >= (-My.Settings.TempPercentageMax) Then
    '                        Instrument.Temperatures.Add(Temp, TempLevel)
    '                    Else
    '                        Dim input As DialogResult = MessageBox.Show("Percent error: " & Format(Temp.PercentError, "#0.0000") & vbNewLine & "Would you like to retry?", "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error)
    '                        If input = DialogResult.Retry Then
    '                            TestPT(Instrument, PressureLevel, TempLevel)
    '                        ElseIf input = DialogResult.Ignore Then
    '                            Instrument.Temperatures.Add(Temp, TempLevel)
    '                        ElseIf input = DialogResult.Abort Then
    '                            Throw New Exception("Test Cancelled.")
    '                        End If
    '                    End If
    '                End If

    '            End If
    '        End If

    '    End Sub



    '#Region " IDisposable Support "
    '    Private disposedValue As Boolean = False        ' To detect redundant calls

    '    ' IDisposable
    '    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
    '        If disposing Then
    '            ' TODO: free unmanaged resources when explicitly called
    '            Instrument.Dispose()
    '        End If
    '        ' TODO: free shared unmanaged resources

    '        Me.disposedValue = True
    '    End Sub

    '    ' This code added by Visual Basic to correctly implement the disposable pattern.
    '    Public Overridable Sub Dispose() Implements IDisposable.Dispose
    '        ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
    '        Dispose(True)
    '        GC.SuppressFinalize(Me)
    '    End Sub
    '#End Region

End Class
