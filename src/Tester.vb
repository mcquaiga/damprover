Module Tester

    Sub main()

        Try
            '  Dim instr As New Instrument()
            Dim xmlwriter As XMLWriterClass
            xmlwriter = New XMLWriterClass(69)
            xmlwriter.LoadInstrumentsAndWriteXML()
        Catch ex As Exception

        End Try



    End Sub




End Module
