<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDownTimer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblSec = New System.Windows.Forms.Label()
        Me.dudHrs = New System.Windows.Forms.DomainUpDown()
        Me.dudMin = New System.Windows.Forms.DomainUpDown()
        Me.dudSec = New System.Windows.Forms.DomainUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dudLblSec = New System.Windows.Forms.Label()
        Me.dudLblMin = New System.Windows.Forms.Label()
        Me.dudLblHrs = New System.Windows.Forms.Label()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.lblHrs = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.OliveDrab
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Font = New System.Drawing.Font("Miramonte", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(127, 554)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(232, 27)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "START"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.Color.Firebrick
        Me.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStop.Font = New System.Drawing.Font("Miramonte", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStop.Location = New System.Drawing.Point(127, 587)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(232, 27)
        Me.btnStop.TabIndex = 4
        Me.btnStop.Text = "STOP"
        Me.btnStop.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'lblSec
        '
        Me.lblSec.AutoSize = True
        Me.lblSec.BackColor = System.Drawing.Color.Transparent
        Me.lblSec.Font = New System.Drawing.Font("Not Just Groovy", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSec.ForeColor = System.Drawing.Color.Transparent
        Me.lblSec.Location = New System.Drawing.Point(249, 275)
        Me.lblSec.Name = "lblSec"
        Me.lblSec.Size = New System.Drawing.Size(81, 57)
        Me.lblSec.TabIndex = 13
        Me.lblSec.Text = "00"
        '
        'dudHrs
        '
        Me.dudHrs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dudHrs.Font = New System.Drawing.Font("Miramonte", 10.0!)
        Me.dudHrs.Location = New System.Drawing.Point(127, 499)
        Me.dudHrs.Name = "dudHrs"
        Me.dudHrs.Size = New System.Drawing.Size(60, 24)
        Me.dudHrs.TabIndex = 5
        Me.dudHrs.Text = "0"
        '
        'dudMin
        '
        Me.dudMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dudMin.Font = New System.Drawing.Font("Miramonte", 10.0!)
        Me.dudMin.Location = New System.Drawing.Point(213, 499)
        Me.dudMin.Name = "dudMin"
        Me.dudMin.Size = New System.Drawing.Size(60, 24)
        Me.dudMin.TabIndex = 6
        Me.dudMin.Text = "0"
        '
        'dudSec
        '
        Me.dudSec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dudSec.Font = New System.Drawing.Font("Miramonte", 10.0!)
        Me.dudSec.Location = New System.Drawing.Point(299, 499)
        Me.dudSec.Name = "dudSec"
        Me.dudSec.Size = New System.Drawing.Size(60, 24)
        Me.dudSec.TabIndex = 7
        Me.dudSec.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Miramonte", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(193, 497)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 24)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = ":"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Miramonte", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(279, 497)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 24)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = ":"
        '
        'dudLblSec
        '
        Me.dudLblSec.AutoSize = True
        Me.dudLblSec.BackColor = System.Drawing.Color.Transparent
        Me.dudLblSec.Font = New System.Drawing.Font("Miramonte", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dudLblSec.ForeColor = System.Drawing.Color.White
        Me.dudLblSec.Location = New System.Drawing.Point(315, 524)
        Me.dudLblSec.Name = "dudLblSec"
        Me.dudLblSec.Size = New System.Drawing.Size(27, 16)
        Me.dudLblSec.TabIndex = 10
        Me.dudLblSec.Text = "Sec"
        '
        'dudLblMin
        '
        Me.dudLblMin.AutoSize = True
        Me.dudLblMin.BackColor = System.Drawing.Color.Transparent
        Me.dudLblMin.Font = New System.Drawing.Font("Miramonte", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dudLblMin.ForeColor = System.Drawing.Color.White
        Me.dudLblMin.Location = New System.Drawing.Point(228, 524)
        Me.dudLblMin.Name = "dudLblMin"
        Me.dudLblMin.Size = New System.Drawing.Size(30, 16)
        Me.dudLblMin.TabIndex = 11
        Me.dudLblMin.Text = "Min"
        '
        'dudLblHrs
        '
        Me.dudLblHrs.AutoSize = True
        Me.dudLblHrs.BackColor = System.Drawing.Color.Transparent
        Me.dudLblHrs.Font = New System.Drawing.Font("Miramonte", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dudLblHrs.ForeColor = System.Drawing.Color.White
        Me.dudLblHrs.Location = New System.Drawing.Point(138, 524)
        Me.dudLblHrs.Name = "dudLblHrs"
        Me.dudLblHrs.Size = New System.Drawing.Size(36, 16)
        Me.dudLblHrs.TabIndex = 12
        Me.dudLblHrs.Text = "Hour"
        '
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.BackColor = System.Drawing.Color.Transparent
        Me.lblMin.Font = New System.Drawing.Font("Not Just Groovy", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMin.ForeColor = System.Drawing.Color.Transparent
        Me.lblMin.Location = New System.Drawing.Point(178, 275)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(81, 57)
        Me.lblMin.TabIndex = 14
        Me.lblMin.Text = "00"
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'lblHrs
        '
        Me.lblHrs.AutoSize = True
        Me.lblHrs.BackColor = System.Drawing.Color.Transparent
        Me.lblHrs.Font = New System.Drawing.Font("Not Just Groovy", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHrs.ForeColor = System.Drawing.Color.Transparent
        Me.lblHrs.Location = New System.Drawing.Point(177, 183)
        Me.lblHrs.Name = "lblHrs"
        Me.lblHrs.Size = New System.Drawing.Size(159, 112)
        Me.lblHrs.TabIndex = 15
        Me.lblHrs.Text = "00"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(484, 662)
        Me.Controls.Add(Me.lblMin)
        Me.Controls.Add(Me.lblSec)
        Me.Controls.Add(Me.dudLblHrs)
        Me.Controls.Add(Me.dudLblMin)
        Me.Controls.Add(Me.dudLblSec)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dudSec)
        Me.Controls.Add(Me.dudMin)
        Me.Controls.Add(Me.dudHrs)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblHrs)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblSec As System.Windows.Forms.Label
    Friend WithEvents dudHrs As System.Windows.Forms.DomainUpDown
    Friend WithEvents dudMin As System.Windows.Forms.DomainUpDown
    Friend WithEvents dudSec As System.Windows.Forms.DomainUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dudLblSec As System.Windows.Forms.Label
    Friend WithEvents dudLblMin As System.Windows.Forms.Label
    Friend WithEvents dudLblHrs As System.Windows.Forms.Label
    Friend WithEvents lblMin As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents lblHrs As System.Windows.Forms.Label

End Class
