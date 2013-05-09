
Class DigitalInputSubsystem

    Private _p1 As Object
    Private _pSubSys As Integer

    Sub New(p1 As Object, pSubSys As Integer)
        ' TODO: Complete member initialization 
        _p1 = p1
        _pSubSys = pSubSys
    End Sub

    Property StopOnError As Boolean

    Property DataFlow As Integer

    Sub Config()
        Throw New NotImplementedException
    End Sub

    Function GetSingleValue() As Integer
        Throw New NotImplementedException
    End Function

    Function State() As Object
        Throw New NotImplementedException
    End Function

End Class
