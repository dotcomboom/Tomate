Imports System.Media

Public Class Main

    Public timers As New Dictionary(Of String, Dictionary(Of String, Object))
    Public time As New TimeSpan
    Public v = "1.0.1"
    Public builddate = "12/7/2020"

    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Right) Then
            SwitchRight()
        End If
        If (e.KeyCode = Keys.Left) Then
            SwitchLeft()
        End If
        If (e.KeyCode = Keys.Up) Then
            SwitchTimer("Pomodoro")
        End If
        If (e.KeyCode = Keys.Enter) Then
            'Enter
            toggleTimer()
        End If
        If e.KeyCode = Keys.F1 Then
            'Soft Key 1
            MessageBox.Show("Pomodoro timer for Windows Mobile" & Environment.NewLine & builddate & Environment.NewLine & "https://dotcomboom.somnolescent.net" & Environment.NewLine & "https://github.com/dotcomboom/Tomate" & Environment.NewLine & Environment.NewLine & "Tomato icon by Pixture Studio", "Tomate " & v, MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
        End If
        If e.KeyCode = Keys.F2 Then
            'Soft Key 2
            If Me.WindowState = FormWindowState.Maximized Then
                Me.WindowState = FormWindowState.Normal
            Else
                Me.WindowState = FormWindowState.Maximized
            End If
        End If
    End Sub


    Private Sub SwitchRight() Handles RightIndicator.Click
        If TimerName.Text = "Pomodoro" Then
            SwitchTimer("Short Break")
        ElseIf TimerName.Text = "Short Break" Then
            SwitchTimer("Long Break")
        ElseIf TimerName.Text = "Long Break" Then
            SwitchTimer("Pomodoro")
        End If
    End Sub


    Private Sub SwitchLeft() Handles LeftIndicator.Click
        If TimerName.Text = "Pomodoro" Then
            SwitchTimer("Long Break")
        ElseIf TimerName.Text = "Short Break" Then
            SwitchTimer("Pomodoro")
        ElseIf TimerName.Text = "Long Break" Then
            SwitchTimer("Short Break")
        End If
    End Sub

    Public Sub SwitchTimer(ByVal timer As String)
        If TimerObject.Enabled = False Then
            Dim t = timers.Item(timer)
            Me.BackColor = t.Item("color")
            TimerName.Text = timer
            time = New TimeSpan(0, timers.Item(TimerName.Text).Item("minutes"), 0)
            updRemaining()
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Environment.OSVersion.Platform = PlatformID.WinCE Then
            Me.WindowState = FormWindowState.Maximized
        End If

        ' Initialize/add the timers
        Dim p As New Dictionary(Of String, Object)
        Dim sb As New Dictionary(Of String, Object)
        Dim lb As New Dictionary(Of String, Object)

        p.Add("minutes", 25)
        p.Add("color", Color.FromArgb(219, 82, 77))

        sb.Add("minutes", 5)
        sb.Add("color", Color.FromArgb(70, 142, 145))

        lb.Add("minutes", 15)
        lb.Add("color", Color.FromArgb(67, 126, 168))

        timers.Add("Pomodoro", p)
        timers.Add("Short Break", sb)
        timers.Add("Long Break", lb)

        SwitchTimer("Pomodoro")
    End Sub

    Private Sub toggleTimer() Handles StartIndicator.Click

        If TimerObject.Enabled = False Then
            TimerObject.Enabled = True
            StartIndicator.Text = "Stop"
            LeftIndicator.Hide()
            RightIndicator.Hide()
        Else
            TimerObject.Enabled = False
            StartIndicator.Text = "Start"
            LeftIndicator.Show()
            RightIndicator.Show()
        End If

        Try
            Dim p As SoundPlayer = New SoundPlayer("\Windows\Default.wav")
            p.Play()
        Catch ex As Exception
            Beep()
        End Try

    End Sub

    Private Sub updRemaining()
        TimerRemaining.Text = time.ToString().Replace("00:", "")
        If TimerRemaining.Text.StartsWith("0") Then
            TimerRemaining.Text = TimerRemaining.Text.Substring(1)
        End If
        If Not TimerRemaining.Text.Contains(":") Then
            TimerRemaining.Text = "00:" & TimerRemaining.Text
        End If
    End Sub

    Private Sub TimerObject_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerObject.Tick

        time = time.Subtract(New TimeSpan(0, 0, 1))
        updRemaining()

        If time.TotalSeconds = 0 Then
            TimerObject.Enabled = False

            Me.TopMost = True
            Me.TopMost = False

            Try
                Dim p As SoundPlayer = New SoundPlayer("\Windows\Default.wav")
                p.Play()
            Catch ex As Exception
                Beep()
            End Try

            StartIndicator.Text = "Start"

            LeftIndicator.Show()
            RightIndicator.Show()

            If TimerName.Text = "Pomodoro" Then
                SwitchTimer("Short Break")
            Else
                SwitchTimer("Pomodoro")
            End If

        End If
    End Sub
End Class
