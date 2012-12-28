Imports System.Windows.Forms

Public Class DAPortsDialog

    Private DABoardType As DABoard.BoardType
    Private USBOutPorts As USBDataAcqClass.OutputPorts
    Private USBInPorts As MccDaq.DigitalPortType
    Private PCIInPorts As PCIDataAcqClass.InputPorts
    Private PCIOutPorts As PCIDataAcqClass.OutputPorts



    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub DAPortsDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If DABoardType = DABoard.BoardType.PCI Then

        Else
            Dim port
            'For Each port In GetType(USBInPorts)

            'Next
        End If
    End Sub
End Class
