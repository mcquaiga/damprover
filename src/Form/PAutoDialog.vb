Imports System.Windows.Forms

Public Class PAutoDialog
    Dim LiveRead As Boolean
    Dim instr As miSerialProtocol.miSerialProtocolClass
    Public pressureUnits As PressureFactorClass.UnitsEnum

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Try
            Dim gpressure = CDbl(GaugePressureTextBox.Text)
            If ATMTextBox.Visible = True Then
                Dim atm = CDbl(ATMTextBox.Text)
            End If
            instr.Disconnect()
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As InvalidCastException
            MessageBox.Show("Pressure must be a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try


    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Sub New(ByVal Instrument As miSerialProtocol.miSerialProtocolClass)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.instr = Instrument
        PressureUnitsLabel.Text = pressureUnits.ToString
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        LiveRead = True
        Try
            instr.Connect()

            Me.pressureUnits = instr.RD(PressureFactorClass.PressureItemsEnum.PressureUnits)
            Me.PressureUnitsLabel.Text = Me.pressureUnits.ToString
            Do While LiveRead = True Or Me.IsDisposed
                Application.DoEvents()
                InstrPressureTextBox.Text = Trim(instr.LR(8))
                Application.DoEvents()
            Loop
            'Skip if error occurs we dont really care
        Catch ex As Exception
            Console.Write(ex.Message)
        End Try
    End Sub

    Private Sub PAutoDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GaugePressureTextBox.Focus()
    End Sub
End Class
