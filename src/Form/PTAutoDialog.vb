Imports System.Windows.Forms

Public Class PTAutoDialog
    Dim LiveRead As Boolean
    Dim instr As miSerialProtocol.miSerialProtocolClass
    Public pressureUnits As PressureFactorClass.UnitsEnum
    Public tempUnits As TemperatureClass.UnitsEnum


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Try
            LiveRead = False
            Dim Pressure = CDbl(GaugePressureTextBox.Text)
            Dim TEmp = CDbl(GaugeTempTextBox.Text)
            If ATMTextBox.Visible = True Then
                Dim atm = CDbl(ATMTextBox.Text)
            End If

            instr.Disconnect()
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As InvalidCastException
            MessageBox.Show("Enter only numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub PTAutoDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Application.DoEvents()
        GaugeTempTextBox.Focus()
    End Sub

    Public Sub ReadLive()


    End Sub

    Sub New(ByVal Instrument As miSerialProtocol.miSerialProtocolClass)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.instr = Instrument

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        LiveRead = True
        Try
            instr.Connect()
            Me.tempUnits = instr.RD(TemperatureClass.TemperatureItems.TempUnits)
            Me.pressureUnits = instr.RD(PressureFactorClass.PressureItemsEnum.PressureUnits)
            Me.TempUnitsLabel.Text = Me.tempUnits.ToString
            Me.PressureUnitsLabel.Text = Me.pressureUnits.ToString
            Do While LiveRead = True Or Me.IsDisposed
                Application.DoEvents()
                InstrPressureTextBox.Text = Trim(instr.LR(8))
                Application.DoEvents()
                InstrTempTextBox.Text = Trim(instr.LR(26))
                Application.DoEvents()
            Loop
            'Skip if error occurs we dont really care
        Catch ex As Exception
            Console.Write(ex.Message)
        End Try
    End Sub
End Class
