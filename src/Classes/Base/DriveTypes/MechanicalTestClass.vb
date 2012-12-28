Imports System.ComponentModel
Public Class MechanicalTestClass : Inherits TestClass
    Implements IDisposable

    Sub New(ByVal CustomerId As Integer)
        MyBase.New(CustomerId)
    End Sub

#Region "Methods"
    Public Overrides Sub PreTest(Optional ByVal Retest As Boolean = False)
        MyBase.PreTest(Retest)
    End Sub

    Public Overrides Function Test() As DialogResult

        Dim mFrm As New MechanicalInputDialog
        mFrm.PulseALabel.Text = "Ya - " & Instrument.PulseASelect.ToString
        mFrm.PulseBLabel.Text = "Yb - " & Instrument.PulseBSelect.ToString
        mFrm.ShowDialog()

        If mFrm.DialogResult = DialogResult.OK Then
            Instrument.Volume.PulserA = mFrm.PulseACount
            Instrument.Volume.PulserB = mFrm.PulseBCount
            Instrument.Volume.AppliedInput = mFrm.AppliedInput
            Instrument.Volume.MechanicalReading = mFrm.MechReading
        End If

    End Function


    Public Overrides Function PostTest() As DialogResult
        Return MyBase.PostTest()

    End Function
#End Region
End Class
