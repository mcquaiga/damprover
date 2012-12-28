Public Class PCIBoardOptionsForm

    Private Sub CancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelButton.Click
        Me.Close()

    End Sub

    Private Sub PCIBoardOptionsForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim InputPorts As Array = System.Enum.GetValues(GetType(PCIDataAcqClass.InputPorts))
        Dim OutputPorts As Array = System.Enum.GetValues(GetType(PCIDataAcqClass.OutputPorts))
        Dim Lines As Array = System.Enum.GetValues(GetType(PCIDataAcqClass.Lines))

        Dim Port

        For Each Port In InputPorts
            APortComboBox.Items.Add(Port.ToString)
            BPortComboBox.Items.Add(Port.ToString)
        Next

        Dim line
        For Each line In Lines
            OutputLineComboBox.Items.Add(line.ToString)
            ALineComboBox.Items.Add(line.ToString)
            BLineComboBox.Items.Add(line.ToString)
        Next


        For Each Port In OutputPorts
            OutputPortComboBox.Items().Add(Port.ToString)
        Next
    End Sub
End Class