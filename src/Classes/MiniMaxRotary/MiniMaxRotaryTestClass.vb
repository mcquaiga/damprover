Public Class MiniMaxRotaryTestClass : Inherits RotaryTestClass

    Sub New(ByVal CustomerID As Integer)

        MyBase.New(CustomerID)
        Me.Instrument = New RotaryInstrument
        Me.Customer.Instrument = Me.Instrument

    End Sub


    Public Overrides Sub PreTest(Optional ByVal Retest As Boolean = False)
        MyBase.PreTest(Retest)

        ''This section is unique to the MiniMax Rotary
        If Me.Instrument.GetItemValue(ProverType.InputVolumeType).value = REIVolumeTypeCodes.RotaryType1 Or _
            Me.Instrument.GetItemValue(ProverType.InputVolumeType).value = REIVolumeTypeCodes.Type1Proving Then
            Instrument.InstrumentSrl.WD(ProverType.InputVolumeType, REIVolumeTypeCodes.Type1Proving)
            '    MessageBox.Show("Place Type 1 Proving Board on the Instrument.", "Type 1", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf Me.Instrument.GetItemValue(ProverType.InputVolumeType).value = REIVolumeTypeCodes.RotaryType2 Or _
           Me.Instrument.GetItemValue(ProverType.InputVolumeType).value = REIVolumeTypeCodes.Type2Proving Then
            Instrument.InstrumentSrl.WD(ProverType.InputVolumeType, REIVolumeTypeCodes.Type2Proving)
            '    MessageBox.Show("Place Type 2 Proving Board on the Instrument.", "Type 2", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub



End Class
