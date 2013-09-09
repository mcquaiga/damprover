Public Class RotaryTest
    Implements ITestClass


    Public Function StartTest() As Object Implements ITestClass.StartTest
        Return Task.Run(Sub()
                            Dim x = 1
                        End Sub)
    End Function
End Class
