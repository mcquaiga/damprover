Imports MySql.Data.MySqlClient

Namespace MySQLLibrary
    Public Class Database
        Inherits ObjectDisposeClass

        Dim mySqlConn As MySqlConnection

        Sub New()
            mySqlConn = New MySqlConnection(ConnectionString)
        End Sub

        ReadOnly Property ConnectionString()
            Get
                Return "Server=" & My.Settings.DB_server & ";Database=" & My.Settings.DB _
                                    & ";Uid=" & My.Settings.UserID & ";Pwd=" & My.Settings.Password & "; Pooling = false;"
            End Get
        End Property

        Public Function OpenMySQL(Optional ByRef ErrorValue As Integer = 0) As MySqlConnection
            Try

                If mySqlConn.State = ConnectionState.Closed Then
                    mySqlConn.Open()
                ElseIf mySqlConn Is Nothing Then
                    mySqlConn = New MySqlConnection(ConnectionString)
                    mySqlConn.Open()
                End If
                ErrorValue = 0
            Catch ex As MySqlException
                Throw New Exception(ex.Message, ex.InnerException)
            End Try

            Return mySqlConn

        End Function

        Public Sub CloseMySQL()
            Try
                mySqlConn.Close()
                mySqlConn.Dispose()

            Catch exError As MySqlException
                MessageBox.Show(exError.Message)
                Console.Write(exError.Message)
            End Try
        End Sub
    End Class

    Public Class ObjectDisposeClass
        Implements IDisposable

        Private disposedValue As Boolean = False

        Public Sub Dispose() Implements IDisposable.Dispose
            Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub

        Protected Overridable Sub Dispose(ByVal disposing As Boolean)
            If Not Me.disposedValue Then
                If disposing Then

                End If
                'TODO: free shared unmanaged resources
            End If
            Me.disposedValue = True
        End Sub
    End Class

End Namespace