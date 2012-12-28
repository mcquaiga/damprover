Imports System.Windows.Forms

Public Class TestCompleteDialog

    Public Instrument As Instrument

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub TestCompleteDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim UnCorPerc, CorPerc As Double
        Dim APulses, BPulses As Integer
        Dim PassTrue As Boolean = True


        UnCorPerc = Instrument.Volume.UnCorrectedPercentError
        Me.UnCorPercErrorLabel.Text = Format(UnCorPerc, "##0.00")

        If UnCorPerc > My.Settings.UncVolumeTolerance Or UnCorPerc < -(My.Settings.UncVolumeTolerance) Then PassTrue = False

        If My.Settings.UncVolumeOnly = True Then
            Me.CorPercErrorLabel.Text = "---"
        Else
            CorPerc = Instrument.Volume.CorrectedPercentError
            Me.CorPercErrorLabel.Text = Format(CorPerc, "##0.00")

            If CorPerc > My.Settings.CorVolumeTolerance Or CorPerc < -(My.Settings.CorVolumeTolerance) Then PassTrue = False
        End If

        If Instrument.InstrumentDriveType = DAM_Prover.Instrument.DriveType.Mechanical Then
            If Instrument.Volume.MechanicalPass = True Then
                MechLabel.ForeColor = Color.DarkGreen
                MechLabel.Text = "PASS"
            Else
                MechLabel.ForeColor = Color.Red
                MechLabel.Text = "FAIL"
                PassTrue = False
            End If
        Else
            MechLabel.Text = "N/A"
            MechLabel.ForeColor = Color.Black
        End If

        If Instrument.PulseASelect = DAM_Prover.Instrument.PulseOutputValues.CorVol Then
            APulses = Int(Instrument.Volume.EndCorrected)
        ElseIf Instrument.PulseASelect = DAM_Prover.Instrument.PulseOutputValues.UncVol Then
            APulses = Int(Instrument.Volume.EndUnCorrected)
        End If

        If Instrument.PulseBSelect = DAM_Prover.Instrument.PulseOutputValues.CorVol Then
            BPulses = Int(Instrument.Volume.EndCorrected)
        ElseIf Instrument.PulseBSelect = DAM_Prover.Instrument.PulseOutputValues.UncVol Then
            BPulses = Int(Instrument.Volume.EndUnCorrected)
        End If

        Dim ADifference = Math.Abs(APulses - Instrument.Volume.PulserA)
        Dim BDifference = Math.Abs(BPulses - Instrument.Volume.PulserB)

        If ADifference < 3 Then
            Me.YaPulsesPassLabel.Text = "PASS"
            Me.YaPulsesPassLabel.ForeColor = Color.DarkGreen
        Else
            Me.YaPulsesPassLabel.Text = "FAIL"
            PassTrue = False
            Me.YaPulsesPassLabel.ForeColor = Color.Red
        End If

        If BDifference < 3 Then
            Me.YbPulsesPassLabel.Text = "PASS"
            Me.YbPulsesPassLabel.ForeColor = Color.DarkGreen
        Else
            Me.YbPulsesPassLabel.Text = "FAIL"
            PassTrue = False
            Me.YbPulsesPassLabel.ForeColor = Color.Red
        End If

        If PassTrue = True Then
            ConfirmedStatusLabel.Text = "PASS"
            ConfirmedStatusLabel.ForeColor = Color.DarkGreen
        Else
            ConfirmedStatusLabel.Text = "FAIL"
            ConfirmedStatusLabel.ForeColor = Color.Red
        End If
    End Sub

    Private Sub ViewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewButton.Click
        Dim excel As New ExcelWriterClass(Me.Instrument)
    End Sub

    Private Sub RetryButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RetryButton.Click
        Me.DialogResult = Windows.Forms.DialogResult.Retry
        Me.Close()
    End Sub

    Public Sub FillListView(ByVal ItemListView As ListView, ByVal ItemCollection As Collection)

        For Each item As CalculatedValues In ItemCollection
            ItemListView.Items.Add(item.Name & ":   " & item.Value)
        Next item

    End Sub


End Class
