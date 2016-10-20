Module Module1
    Public t As New System.Threading.Thread(AddressOf BackgroundProcess)
    Public myProcess As System.Diagnostics.Process = New System.Diagnostics.Process

    Public commandLine As String


    Sub BackgroundProcess()
        Dim startTime As DateTime
        Dim ptrShipWindow As IntPtr
        Dim ptrMainWindow As IntPtr
        Dim fileType As String

        Try
            myProcess.EnableRaisingEvents = True
            AddHandler myProcess.Exited, AddressOf ProcessExited


            Try
                Select Case UCase(commandLine)
                    Case UCase("Gary")
                        myProcess.StartInfo.FileName = "C:\Users\tmahoney\Music\Frozen\Let It Go.wav"
                    Case UCase("donnahalon"), UCase("Donna")
                        myProcess.StartInfo.FileName = "C:\Users\tmahoney\Music\Wicked\For Good.wav"
                    Case UCase("expertekvp"), UCase("Paul")
                        myProcess.StartInfo.FileName = "C:\Users\tmahoney\Music\Billy Joel\Turnstiles\Billy Joel - New York State of Mind.wav"
                    Case UCase("aspencer14"), UCase("Andy")
                        myProcess.StartInfo.FileName = "C:\Users\tmahoney\Music\Wicked\Dancing Through Life.wav"
                    Case UCase("jrczmail"), UCase("Joe")
                        myProcess.StartInfo.FileName = "C:\Users\tmahoney\Music\Billy Joel\Turnstiles\Billy Joel - James.wav"
                    Case UCase("ExpertekTucker"), UCase("Tucker")
                        myProcess.StartInfo.FileName = "C:\Users\tmahoney\Music\Billy Joel\Turnstiles\Billy Joel - Prelude-Angry Young Man.wav"
                    Case UCase("ExpertekPres"), UCase("Ken")
                        myProcess.StartInfo.FileName = "C:\Users\tmahoney\Music\Billy Joel\Turnstiles\Billy Joel - Miami 2017 (Seen the Lights Go Out on Broadway).wav"
                    Case UCase("andrewmostello"), UCase("Andrew")
                        myProcess.StartInfo.FileName = "C:\Users\tmahoney\Music\Wicked\No Good Deed.wav"
                    Case UCase("AOLSystemMsg")

                    Case Else
                        myProcess.StartInfo.FileName = "C:\Users\tmahoney\Music\Wicked\No Good Deed.wav"

                End Select
                'myProcess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal
                myProcess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal
                myProcess.Start()
                'myProcess.PriorityClass = ProcessPriorityClass.Idle
            Catch ex As Exception
                MsgBox(" Cannot start Message Notifier. " & vbCrLf & " Contact your System Administrator." & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Error")
                'tem 11/13/06  check for PrevInstance instead
                'stLockFile.Close()
                'File.Delete(Application.ProductName & "_" & stationID & ".lck")
                Application.Exit()
            End Try

            'myProcess.WaitForInputIdle()
            'startTime = Now
            ''objWriter.Write(Now & " While Not myProcess.Responding " & vbCrLf)  tem 2/19/07  removed
            'While Not myProcess.Responding Or DateDiff("s", Now, startTime) > 60

            'End While
            'If myProcess.Responding Then
            '    Try
            '    Catch ex As Exception
            '    End Try
            'Else
            '    MsgBox(" Cannot start MessageNotifier. " & vbCrLf & " Contact your System Administrator.", MsgBoxStyle.Critical, "Error")
            '    'tem 11/13/06  check for PrevInstance instead
            '    'stLockFile.Close()
            '    'File.Delete(Application.ProductName & "_" & stationID & ".lck")
            '    myProcess.Kill()
            '    Application.Exit()
            'End If
        Catch ex As Exception
            MsgBox(" Cannot start MessageNotifier. " & vbCrLf & " Contact your System Administrator." & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Error")
            Application.Exit()
        End Try



    End Sub
    Friend Sub ProcessExited(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim myProcess As Process = DirectCast(sender, Process)

        Try
            'tem 11/13/06  check for PrevInstance instead
            'stLockFile.Close()
            'File.Delete(Application.ProductName & "_" & stationID & ".lck")

            '''tem 2/14/07  these shouldn't be necessary anymore
            '''File.Delete(ADEPath & "OrderTotals_" & stationID & ".txt")

            '''If rtnSvcCustRLabel Then
            '''    File.Delete(ADEPath & "ReturnReceiptLabel_" & stationID & ".txt")       'tem 1/22/2007
            '''End If

            'objWriter.Write(Now & " Exiting Application " & vbCrLf)    'tem 2/14/07 duplicated in AppCleanUp
            Application.Exit()
            End
        Catch ex As Exception
            Try
            Catch
            End Try
        End Try

    End Sub

End Module
