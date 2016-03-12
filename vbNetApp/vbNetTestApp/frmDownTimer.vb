Imports System.Threading

Public Class frmDownTimer

    Dim seconds As Integer = 0
    Dim minutes As Integer = 0, totalMin As Integer = 1, totalHrs As Integer = 1
    Dim sweepAngle As Integer = 0, sweepAngleSec As Integer = 0, sweepAngleMin As Integer = 0, sweepAngleHrs As Integer = 0
    Dim hours As Integer = 0
    Dim isRunning As Boolean = False
    Dim fillArray() As String = New String() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9",
                                             "10", "11", "12", "13", "14", "15", "16", "17", "18", "19",
                                             "20", "21", "22", "23", "24", "25", "26", "27", "28", "29",
                                             "30", "31", "32", "33", "34", "35", "36", "37", "38", "39",
                                             "40", "41", "42", "43", "44", "45", "46", "47", "48", "49",
                                             "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 500
        Me.Height = 700
        Me.BackColor = Color.Black
        Me.CenterToScreen()
        For fillCtr As Integer = 59 To 0 Step -1
            dudSec.Items.Add(fillArray(fillCtr))
            dudMin.Items.Add(fillArray(fillCtr))
        Next
        For fillCtr As Integer = 24 To 0 Step -1
            dudHrs.Items.Add(fillArray(fillCtr))
        Next

        If totalMin = 0 Then
            sweepAngle = 0
        ElseIf totalMin > 0 And totalHrs = 0 Then
            sweepAngle = minutes * 360 \ totalMin
        ElseIf totalMin > 0 And totalHrs <> 0 Then
            totalMin = 60
            sweepAngle = minutes * 360 \ totalMin
        End If

        If totalHrs = 0 Then
            sweepAngleHrs = 0
        ElseIf totalHrs > 0 Then
            sweepAngleHrs = hours * 360 \ totalHrs
        End If
        setLabels()
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Dim penBrush As Pen = New Pen(Color.DarkOrange, 20)
        Dim penBrush2 As Pen = New Pen(Color.DarkRed, 20)
        Dim penBrush3 As Pen = New Pen(Color.DarkGreen, 20)
        Dim penBrush4 As Pen = New Pen(Color.Yellow, 2)

        e.Graphics.DrawArc(penBrush, 50, 60, 400, 400, -90, sweepAngleHrs)
        e.Graphics.DrawArc(penBrush3, 75, 85, 350, 350, -90, sweepAngle)
        e.Graphics.DrawArc(penBrush2, 100, 110, 300, 300, -90, seconds * 6)
        e.Graphics.DrawArc(penBrush4, 125, 135, 250, 250, 0, 360)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If isRunning = True Then
            If seconds = 0 And minutes <> 0 And hours <> 0 Then
                zeroSeconds()
            ElseIf seconds = 0 And minutes = 0 And hours <> 0 Then
                zeroMinutes()
                zeroSeconds()
            ElseIf seconds = 0 And minutes <> 0 And hours = 0 Then
                zeroSeconds()
            ElseIf seconds = 0 And minutes = 0 And hours = 0 Then
                Timer1.Stop()
                seconds = 1
            End If
            seconds = seconds - 1
            lblSec.Text = seconds.ToString("00")
            lblMin.Text = minutes.ToString("00")
            lblHrs.Text = hours.ToString("00")

            Me.Refresh()
        End If
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        isRunning = True
        setLabels()

        If seconds < 60 And minutes < 60 Then
            lblSec.Text = seconds.ToString("00")
            lblMin.Text = minutes.ToString("00")
            lblHrs.Text = hours.ToString("00")
        ElseIf seconds > 60 And minutes < 60 Then
            minutes = minutes + (seconds \ 60)
            seconds = seconds Mod 60
            lblSec.Text = seconds.ToString("00")
            lblMin.Text = minutes.ToString("00")
            lblHrs.Text = hours.ToString("00")
        ElseIf minutes > 60 And seconds < 60 Then
            hours = hours + (minutes \ 60)
            minutes = minutes Mod 60
            totalHrs = hours
            totalMin = 60
            lblSec.Text = seconds.ToString("00")
            lblMin.Text = minutes.ToString("00")
            lblHrs.Text = hours.ToString("00")
        ElseIf minutes > 60 And seconds > 60 Then
            Dim tempMin As Integer = minutes, tempSec As Integer = seconds
            seconds = seconds Mod 60
            minutes = (minutes + (tempSec \ 60)) Mod 60
            hours = hours + (minutes \ 60)
            totalHrs = hours
            totalMin = 60
            lblSec.Text = seconds.ToString("00")
            lblMin.Text = minutes.ToString("00")
            lblHrs.Text = hours.ToString("00")
        End If

        If hours <> 0 Then
            totalMin = 60
        Else
            totalMin = minutes
        End If
        totalHrs = hours

        If totalMin = 0 Then
            sweepAngle = 0
        ElseIf totalMin > 0 Then
            sweepAngle = minutes * 360 \ totalMin
        End If

        If totalHrs = 0 Then
            sweepAngleHrs = 0
        ElseIf totalHrs > 0 Then
            sweepAngleHrs = hours * 360 \ totalHrs
        End If

        dudSec.Enabled = False
        dudMin.Enabled = False
        dudHrs.Enabled = False
        btnStart.Enabled = False
        btnStop.Enabled = True
        Me.Refresh()
        Thread.Sleep(1000)
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        isRunning = False
        dudSec.Enabled = True
        dudSec.ResetText()
        dudMin.Enabled = True
        dudMin.ResetText()
        dudHrs.Enabled = True
        dudHrs.ResetText()
        btnStart.Enabled = True
        btnStop.Enabled = False
        Me.Refresh()
    End Sub

    Private Sub zeroSeconds()
        seconds = 60
        'Me.Refresh()
        minutes = minutes - 1
        If totalMin = 0 Then
            sweepAngle = 0
        ElseIf totalMin <> 0 Then
            sweepAngle = minutes * 360 \ totalMin
        End If
        'sweepAngleHrs = hours * 360 \ totalHrs
        lblMin.Text = minutes.ToString()
        Me.Refresh()
    End Sub

    Private Sub zeroMinutes()
        minutes = 60
        totalMin = minutes
        'Me.Refresh()
        hours = hours - 1

        If totalHrs = 0 Then
            sweepAngleHrs = 0
        ElseIf totalHrs <> 0 Then
            sweepAngleHrs = hours * 360 \ totalHrs
        End If
        'sweepAngleHrs = hours * 360 \ totalHrs
        lblHrs.Text = hours.ToString()
        Me.Refresh()
    End Sub

    Private Sub setLabels()
        seconds = Integer.Parse(dudSec.Text)
        minutes = Integer.Parse(dudMin.Text)
        hours = Integer.Parse(dudHrs.Text)
    End Sub

End Class