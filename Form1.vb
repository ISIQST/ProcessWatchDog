Public Class Form1

    Private myProc As Process = Nothing

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles cmdStartMonitor.Click
        Dim pn$ = txtProcessName.Text
        Try
            Dim myProcesses() As Process
            'myProcesses = Process.GetProcesses
            myProcesses = Process.GetProcessesByName(pn)
            If myProcesses.Count = 0 Then
                MsgBox("Could not find running process with the name " & pn)
                Return
            ElseIf myProcesses.Count > 1 Then
                MsgBox("More than one " & pn & " process found, please leave only one instance running")
                Return
            End If
            myProc = myProcesses(0)
        Catch ex As Exception

        End Try

        cmdStartMonitor.Enabled = False
        cmdStopMonitor.Enabled = True
        tmr.Interval = CInt(1000 * CSng(txtInterval.Text))
        tmr.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles cmdStopMonitor.Click
        cmdStartMonitor.Enabled = True
        cmdStopMonitor.Enabled = False
        tmr.Enabled = False
    End Sub

    Dim retryCounter As Integer = 0
    Private Sub tmr_Tick(sender As Object, e As System.EventArgs) Handles tmr.Tick
        tmr.Enabled = False

        txtLastCheckAt.Text = Now.ToString
        If myProc.HasExited Then
            Button2_Click(Nothing, New System.EventArgs)
            Return
        ElseIf Not myProc.Responding Then
            Beep()
            retryCounter += 1
            If retryCounter > Integer.Parse(txtREtry.Text) Then
                If chkAutoKillProc.Checked OrElse MsgBox("Process Stopped Responding. do you wish to kill it?", vbYesNo) = MsgBoxResult.Yes Then
                    ' Forces the process to close if the Responding value is False.
                    ' myProc.StartInfo
                    Dim mm$ = myProc.MainModule.FileName
                    myProc.Kill()
                    Process.Start(mm)
                End If
                retryCounter = 0
            End If
        Else
            retryCounter = 0
        End If
        tmr.Enabled = True
    End Sub

 
End Class
