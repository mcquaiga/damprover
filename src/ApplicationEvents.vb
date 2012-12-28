Namespace My

    ' The following events are availble for MyApplication:
    ' 
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.

    Partial Friend Class MyApplication
        Public Shadows Event UnhandledException(ByVal sender As Object, ByVal e As UnhandledExceptionEventArgs)

        Public Sub Me_UnhandledException(ByVal Sender As Object, ByVal e As UnhandledExceptionEventArgs) Handles Me.UnhandledException
            MessageBox.Show(e.ExceptionObject, "Unhandled Exception Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            My.Application.Log.WriteException(Sender.Exception, _
                    TraceEventType.Critical, _
                    "Unhandled Exception.")
        End Sub

        Private Sub MyApplication_NetworkAvailabilityChanged(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.Devices.NetworkAvailableEventArgs) Handles Me.NetworkAvailabilityChanged
            If e.IsNetworkAvailable = False Then
                MessageBox.Show("Network connection lost." & vbNewLine & "Please check connection before continuing.", "Network Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End Sub

    End Class




End Namespace

