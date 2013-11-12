Imports System.ComponentModel

Public Interface IBoard
    Enum BoardType
        USB = 1
        PCI = 2
    End Enum

    Property board As String
    Property ss_num As Integer
    Property data_flow As Integer
    Property disposedValue As Boolean     ' To detect redundant calls

    Sub StartMotor()
    Sub StopMotor()
    Sub Config()
    Sub PulseOut(ByVal value As Integer)

    Function CheckBoard() As Boolean

'This returns a 1 integer if a pulse is detected and 0 if it is not
    Function ReadPulse() As Integer
    Sub Dispose(ByVal disposing As Boolean)

End Interface
