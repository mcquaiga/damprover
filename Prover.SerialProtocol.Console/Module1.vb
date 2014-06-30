Imports System.Console
Imports miSerialProtocol



Module Module1

    Sub Main()
        WriteLine("Enter temperature:")
        Dim temp = ReadLine()

        Dim mini = New MiniMaxClass(New SerialPort("COM3", BaudRateEnum.b38400))
        mini.Connect()
        mini.WD("26", temp)
        mini.Disconnect()


    End Sub

End Module
