Public Class Form2
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(48, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(136, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'Form2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 54)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub

#End Region


    ''Public thrMyThread As New System.Threading.Thread(AddressOf RunWav)
    ''Public myProcess As System.Diagnostics.Process = New System.Diagnostics.Process

    'Sub main()
    '    thrMyThread.Start()


    'End Sub
    ''Sub RunWav()
    ''    'Dim myProcess As System.Diagnostics.Process = New System.Diagnostics.Process
    ''    Dim startTime As DateTime
    ''    Dim ptrShipWindow As IntPtr
    ''    Dim ptrMainWindow As IntPtr
    ''    Dim fileType As String

    ''    Try
    ''        'UsePervasiveDriver()
    ''        myProcess.EnableRaisingEvents = True
    ''        AddHandler myProcess.Exited, AddressOf ProcessExited

    ''        Try
    ''            myProcess.StartInfo.FileName = "C:\Documents and Settings\TMahoney.EXPDOMAIN\My Documents\My Music\Billy Joel\Turnstiles\Billy Joel - All You Wanna Do Is Dance.wav"
    ''            'myProcess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal
    ''            myProcess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Minimized
    ''            myProcess.Start()
    ''            'myProcess.PriorityClass = ProcessPriorityClass.Idle
    ''        Catch ex As Exception
    ''            MsgBox(" Cannot start Starship. " & vbCrLf & " Contact your System Administrator.", MsgBoxStyle.Critical, "Error")
    ''            'tem 11/13/06  check for PrevInstance instead
    ''            'stLockFile.Close()
    ''            'File.Delete(Application.ProductName & "_" & stationID & ".lck")
    ''            Application.Exit()
    ''        End Try

    ''        myProcess.WaitForInputIdle()
    ''        startTime = Now
    ''        'objWriter.Write(Now & " While Not myProcess.Responding " & vbCrLf)  tem 2/19/07  removed
    ''        While Not myProcess.Responding Or DateDiff("s", Now, startTime) > 60

    ''        End While
    ''        'thrMyThread.Sleep(2000)
    ''        If myProcess.Responding Then
    ''            Try
    ''            Catch ex As Exception
    ''            End Try
    ''        Else
    ''            MsgBox(" Cannot start Starship. " & vbCrLf & " Contact your System Administrator.", MsgBoxStyle.Critical, "Error")
    ''            'tem 11/13/06  check for PrevInstance instead
    ''            'stLockFile.Close()
    ''            'File.Delete(Application.ProductName & "_" & stationID & ".lck")
    ''            myProcess.Kill()
    ''            Application.Exit()
    ''        End If
    ''    Catch ex As Exception
    ''        MsgBox(" Cannot start Starship. " & vbCrLf & " Contact your System Administrator.", MsgBoxStyle.Critical, "Error")
    ''        Application.Exit()
    ''    End Try

    ''    Try
    ''        Do While Not myProcess.HasExited

    ''        Loop
    ''    Catch ex As Exception

    ''    End Try

    ''End Sub
    ''Friend Sub ProcessExited(ByVal sender As Object, ByVal e As System.EventArgs)
    ''    Dim myProcess As Process = DirectCast(sender, Process)

    ''    Try
    ''        'tem 11/13/06  check for PrevInstance instead
    ''        'stLockFile.Close()
    ''        'File.Delete(Application.ProductName & "_" & stationID & ".lck")

    ''        '''tem 2/14/07  these shouldn't be necessary anymore
    ''        '''File.Delete(ADEPath & "OrderTotals_" & stationID & ".txt")

    ''        '''If rtnSvcCustRLabel Then
    ''        '''    File.Delete(ADEPath & "ReturnReceiptLabel_" & stationID & ".txt")       'tem 1/22/2007
    ''        '''End If

    ''        'objWriter.Write(Now & " Exiting Application " & vbCrLf)    'tem 2/14/07 duplicated in AppCleanUp
    ''        Application.Exit()
    ''        End
    ''    Catch ex As Exception
    ''        Try
    ''        Catch
    ''        End Try
    ''    End Try

    'End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        t.Abort()

        Me.Close()
    End Sub

    ''Private Sub Form2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
    ''    thrMyThread.Start()


    ''End Sub

    Private Sub Form2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = "***" & commandLine & "***"
    End Sub
End Class
