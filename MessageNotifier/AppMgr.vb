Imports System.IO
Imports System.Text
Imports System.Threading

Friend Class AppMgr
    'Friend Shared frmsplash As New frmsplash


    <STAThread()> _
        Shared Sub main(ByVal sArgs() As String)
        Dim frmStart As Form2

        Try
            If sArgs.Length = 0 Then                'If there are no arguments
                'MsgBox("Hello World! <-no arguments passed->") 'Just output Hello World
            Else                                    'We have some arguments		
                Dim i As Integer = 0

                While i < sArgs.Length             'So with each argument
                    If i = 0 Then commandLine = sArgs(i)
                    'MsgBox("Hello " & sArgs(i) & "!") 'Print out each item
                    'MsgBox("Hello " & commandLine)
                    i = i + 1                       'Increment to the next argument
                End While

            End If

            'Dim t As Thread
            ''t = New Thread(AddressOf BackgroundProcess)
            t.Start()

            'Dim i As Integer = 1



            'Try
            '    Dim objLockWriter As System.IO.StreamWriter

            '    LoadFromINI()
            '    InitializeApp()
            '    Try
            '        CreateAppLog()
            '        objWriter.Write(Now & " ********************  Starting Application ******************** " & vbCrLf)
            '    Catch ex As Exception
            '        MsgBox("Cannot create application logfile at: " & logFileName & " (path)" & vbCrLf & "Contact System Administrator.", MsgBoxStyle.Critical, "Error")
            '        stLockFile.Close()
            '        File.Delete(Application.ProductName & "_" & stationID & ".lck")
            '        Application.Exit()
            '        End
            '    End Try
            'Catch ex As Exception
            '    Try
            '        stLockFile.Close()
            '        File.Delete(Application.ProductName & "_" & stationID & ".lck")
            '    Catch err As Exception
            '        File.Delete(Application.ProductName & "_" & stationID & ".lck")
            '    End Try
            '    Application.Exit()
            '    End
            'End Try
            Try
                'pubLicense = New ClsLicense
                'If Len(pubLicense.LicenseKey) = 0 Then
                '    frmStart.frmLicenseKey = New FrmLicenseKey
                '    Application.Run(frmStart.frmLicenseKey)
                'End If
                ''If pubLicense.ModuleCode = "T" And frmStart.frmBackEndSelect Is Nothing Then
                ''    frmStart.frmBackEndSelect = New frmBackEndSelect
                ''    Application.Run(frmStart.frmBackEndSelect)
                ''End If
                ''If Not frmStart.frmBackEndSelect Is Nothing Then
                ''    frmStart.frmBackEndSelect.Close()
                ''End If

                frmStart = New Form2
                Application.Run(frmStart)


            Catch err As Exception
                'tem 11/13/06  check for PrevInstance instead
                'Try
                '    stLockFile.Close()
                '    File.Delete(Application.ProductName & "_" & stationID & ".lck")
                'Catch exc As Exception
                '    File.Delete(Application.ProductName & "_" & stationID & ".lck")
                'End Try
                MsgBox("Error: " & err.Message & " Application must close. " & vbCrLf & "Contact your System Administrator.")
                frmStart.Close()
                Application.Exit()
                End
            End Try
        Catch ex1 As TypeInitializationException
            'tem 2/23/07
            MsgBox("TypeInitializationException Error: " & ex1.Message & ex1.InnerException.ToString)
        Catch ex As Exception
            'tem 2/23/07
            MsgBox("AppMgr Error: " & ex.Message)
        End Try



    End Sub



End Class
