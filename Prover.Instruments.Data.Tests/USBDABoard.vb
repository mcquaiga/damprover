Imports System.Text
Imports Prover.Instruments.Data
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class USBDABoard

    <TestMethod()> Public Sub BasicTest()

        Dim board As New USBDataAcqClass(0, MccDaq.DigitalPortType.FirstPortA, 0)

        Do
            If board.ReadPulse() = 1 Then
                MsgBox("Pulse received.")
            End If
        Loop


    End Sub

End Class