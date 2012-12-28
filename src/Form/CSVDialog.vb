Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class CSVDialog

    Dim inspectionID As Integer
    Dim NewIC


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub CSVDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim db As New MySQLLibrary.Database
        Dim myDataReader As MySqlDataReader
        Dim txtWriter As IO.StreamWriter
        Dim SizeCode As String
        Dim InspecType As String = "N"

        Try
            txtWriter = New IO.StreamWriter("\\crwall-01\company\Enbridge CSV files\Instr_CR_Wall_" & inspectionID & "_" & Format(Date.Now(), "MMddyyyy") & ".csv")

            Using mySqlCommand As New MySqlCommand
                With mySqlCommand
                    .Connection = db.OpenMySQL
                    .CommandText = "SELECT * FROM inspection_cert WHERE inspection_id = " & inspectionID
                    myDataReader = .ExecuteReader(CommandBehavior.Default)
                    If myDataReader.HasRows Then
                        InspecType = myDataReader.GetString("insp_type")
                    End If
                    .CommandText = "SELECT * FROM instr WHERE inspection_id = " & inspectionID
                    myDataReader = .ExecuteReader(CommandBehavior.Default)
                    If myDataReader.HasRows Then
                        Do While myDataReader.Read
                            Dim Instrument As New Instrument
                            Instrument.LoadFromDB(myDataReader.GetInt32("instr_id"))

                            If Instrument.InstrumentDriveType = DAM_Prover.Instrument.DriveType.Rotary Then
                                SizeCode = "MIN"
                                Select Case Instrument.Volume.MeterTypeNumber
                                    Case 1 Or 13    'Roots 2M LMMA or Romet RM2000
                                        SizeCode = "MMA"
                                    Case 2 Or 14    'Roots 3M LMMA or Romet RM3000
                                        SizeCode = "MMB"
                                    Case 3 Or 15    'Roots 5M LMMA or Romet RM5000
                                        SizeCode = "MMC"
                                    Case 4 Or 16    'Roots 7M LMMA or Romet RM7000
                                        SizeCode = "MMD"
                                    Case 5 Or 17    'Roots 11M LMMA or Romet RM11000
                                        SizeCode = "MME"
                                    Case 6 Or 18    'Roots 16M LMMA or Romet RM16000
                                        SizeCode = "MMF"
                                End Select
                            Else
                                SizeCode = "MIN"
                            End If
                            Dim Value = ",,"
                            If Instrument.GetItemValue(Instrument.FixedFactorItems.FixedPressure).value = Instrument.FixedFactors.Live And Instrument.GetItemValue(Instrument.FixedFactorItems.FixedTempFactor).value = Instrument.FixedFactors.Live Then
                                Value = "0.00" & "," & Format(Instrument.GetPressureObject(TestClass.PressureLevels.Mid).PercentError, "0.00") & "," & Format(Instrument.GetTemperatureObject(TestClass.TemperatureLevels.Mid).PercentError, "0.00")
                            ElseIf Instrument.GetItemValue(Instrument.FixedFactorItems.FixedTempFactor).value = Instrument.FixedFactors.Live Then
                                Value = Format(Instrument.GetTemperatureObject(TestClass.TemperatureLevels.Low).PercentError, "0.00") & "," & Format(Instrument.GetTemperatureObject(TestClass.TemperatureLevels.Mid).PercentError, "0.00") & "," & Format(Instrument.GetTemperatureObject(TestClass.TemperatureLevels.High).PercentError, "0.00")
                            End If
                            Dim txt As String = Instrument.GetItemValue(201).value & "," & Instrument.GetItemValue(62).value _
                                & "," & SizeCode & "," & Value & "," & Format(Date.Now(), "MM") & "/" & Format(Date.Now(), "dd") _
                                & "/" & Date.Now().Year() & "," & InspecType & "," & "74"
                            txtWriter.Write(txt)
                            If NewIC = True Then
                                txtWriter.Write("," & "13" & "," & "S3" & "," & "200701")
                            End If
                            txtWriter.WriteLine()
                        Loop

                        txtWriter.Flush()
                        txtWriter.Close()

                    End If
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Me.Close()
    End Sub

    Sub New(ByVal InspectionID As Integer, ByVal NewIC As Boolean)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.inspectionID = InspectionID
        Me.NewIC = NewIC
    End Sub
End Class
