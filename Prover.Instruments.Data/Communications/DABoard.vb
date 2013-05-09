Imports System.ComponentModel
'Imports MccDaq
'Imports AxDTAcq32Lib

Public Class DABoard

    Public Enum BoardType
        USB = 1
        PCI = 2
    End Enum

    Private board As String
    Private ss_num As Integer
    Private data_flow As Integer
    Private USBSys As USBDataAcqClass
    Private PCISys As PCIDataAcqClass

    Sub New()

    End Sub

    Public Overridable Sub Config()

    End Sub

    Public Overridable ReadOnly Property StartMotor() As Short
        Get
            Return 0
        End Get
    End Property

    Public Overridable ReadOnly Property StopMotor() As Short
        Get
            Return 0
        End Get
    End Property

    Public Overridable Sub PulseOut(ByVal value As Integer)

    End Sub

    Public Overridable Function CheckBoard() As Boolean
        Return False
    End Function

    'This returns a 1 integer if a pulse is detected and 0 if it is not
    Public Overridable Function ReadPulse() As Integer

    End Function

    Private disposedValue As Boolean = False        ' To detect redundant calls

    Public Overridable Overloads Sub Dispose(ByVal disposing As Boolean)

    End Sub

End Class
