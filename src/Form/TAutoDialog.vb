Imports System.Windows.Forms

Public Class TAutoDialog
    Dim LiveRead As Boolean
    Dim instr As miSerialProtocol.miSerialProtocolClass
    Dim instrType As miSerialProtocol.InstrumentTypeCode
    Public temp_units As TemperatureClass.UnitsEnum
    Dim Temp As Double


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        Try
            Dim temp As Double = CDbl(GaugeTempTextBox.Text)

            Me.DialogResult = System.Windows.Forms.DialogResult.OK

            instr.Disconnect()

            Me.Close()

        Catch ex As InvalidCastException
            MessageBox.Show("Temperature must be a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        instrType = Instrument.Instrument

    End Sub

    Public Sub TempChange(ByVal Temp As Double)
        Me.InstrTempTextBox.Text = Temp
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        LiveRead = True
        Try
            instr.Connect()
            Me.temp_units = instr.RD(TemperatureClass.TemperatureItems.TempUnits)

            Me.TempUnitsLabel.Text = Me.temp_units.ToString
            Do While LiveRead = True Or Me.IsDisposed
                Application.DoEvents()
                InstrTempTextBox.Text = Trim(instr.LR(26))

                Application.DoEvents()
            Loop
            'Skip if error occurs we dont really care
        Catch ex As Exception
            Console.Write(ex.Message)
        End Try

    End Sub

    Private Sub GaugeTempTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GaugeTempTextBox.TextChanged

    End Sub

    Private Sub TAutoDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GaugeTempTextBox.Focus()
        GaugeTempTextBox.SelectAll()
    End Sub
End Class
