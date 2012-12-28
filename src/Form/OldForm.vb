'Imports miSerialProtocol.miSerialProtocolClass

Public Class OldForm
    Public Enum ItemNum
        TempItem = 26
        PressureItem = 8
        SerialNumber = 62
    End Enum

    'With these public we can receive events from them in our form
    Public CustomerID As Integer = 3
    Public Test As TestClass
    Private WithEvents InstrumentSrl As miSerialProtocol.miSerialProtocolClass

    'Public Event InstrumentEvents As miSerialProtocol.miSerialProtocolClass.CommStateChangedEventHandler
    'Public Event InstrumentItems As miSerialProtocol.miSerialProtocolClass.ItemCountEventHandler
    'Public Event InstrumentItemProgress As miSerialProtocol.miSerialProtocolClass.CurrentItemProgressEventHandler
    Public WithEvents Instrument As TCIInstrument

    Private InstrumentType As miSerialProtocol.InstrumentTypeCode
    Private State As miSerialProtocol.CommStateEnum
    Private TestStarted = False
    Private Quitting As Boolean = False

    Private Sub OldForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub



    Private Sub PulseACount(ByVal Count As Integer)
        Me.PulseATextBox.Text = Count
    End Sub

    Private Sub PulseBCount(ByVal Count As Integer)
        Me.PulseBTextBox.Text = Count
    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        AddHandler TestClass.RcvPulseA, AddressOf PulseACount
        AddHandler TestClass.RcvPulseB, AddressOf PulseBCount
        Me.Button2.Enabled = False
        Try
            Test = New MiniMaxRotaryTestClass(CustomerID)
            Dim frm As New OldStatusForm
            frm.StatusLabel.Text = "Connecting..."
            frm.Show()

            Me.Test.PreTest()
            Application.DoEvents()
            frm.Close()

            Test.Instrument.Disconnect()
            Test.Test()
            Application.DoEvents()

            Test.PostTest()

            Me.Close()
        Catch ex As Exception
            If Quitting = False Then
                MessageBox.Show(ex.Message)
            End If

        End Try


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
            Quitting = True
            Test.Dispose()
            Test = Nothing
            Me.Close()
        End If
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsToolStripMenuItem.Click
        NewTestForm.ShowDialog()
    End Sub
End Class