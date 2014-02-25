Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Prover.Instruments.Data

<TestClass()> Public Class Tachometer

    <TestMethod()> Public Sub TestParser()
        Dim value As String = "D0" + Chr(13) + "OK" + Chr(13) + "10000"

        Assert.AreEqual(TachometerClass.ParseTachValue(value), 10000)
    End Sub

End Class