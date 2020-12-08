<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Spacer = New System.Windows.Forms.PictureBox
        Me.TimerName = New System.Windows.Forms.Label
        Me.TimerRemaining = New System.Windows.Forms.Label
        Me.TimerObject = New System.Windows.Forms.Timer
        Me.StartIndicator = New System.Windows.Forms.Label
        Me.LeftIndicator = New System.Windows.Forms.Label
        Me.RightIndicator = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Spacer
        '
        Me.Spacer.Dock = System.Windows.Forms.DockStyle.Top
        Me.Spacer.Location = New System.Drawing.Point(0, 0)
        Me.Spacer.Name = "Spacer"
        Me.Spacer.Size = New System.Drawing.Size(320, 22)
        '
        'TimerName
        '
        Me.TimerName.Dock = System.Windows.Forms.DockStyle.Top
        Me.TimerName.ForeColor = System.Drawing.Color.White
        Me.TimerName.Location = New System.Drawing.Point(0, 22)
        Me.TimerName.Name = "TimerName"
        Me.TimerName.Size = New System.Drawing.Size(320, 30)
        Me.TimerName.Text = "Pomodoro"
        Me.TimerName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TimerRemaining
        '
        Me.TimerRemaining.Dock = System.Windows.Forms.DockStyle.Top
        Me.TimerRemaining.Font = New System.Drawing.Font("Segoe Condensed", 18.0!, System.Drawing.FontStyle.Bold)
        Me.TimerRemaining.ForeColor = System.Drawing.Color.White
        Me.TimerRemaining.Location = New System.Drawing.Point(0, 52)
        Me.TimerRemaining.Name = "TimerRemaining"
        Me.TimerRemaining.Size = New System.Drawing.Size(320, 63)
        Me.TimerRemaining.Text = "25:00"
        Me.TimerRemaining.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TimerObject
        '
        Me.TimerObject.Interval = 1000
        '
        'StartIndicator
        '
        Me.StartIndicator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.StartIndicator.ForeColor = System.Drawing.Color.White
        Me.StartIndicator.Location = New System.Drawing.Point(0, 201)
        Me.StartIndicator.Name = "StartIndicator"
        Me.StartIndicator.Size = New System.Drawing.Size(320, 39)
        Me.StartIndicator.Text = "Start"
        Me.StartIndicator.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LeftIndicator
        '
        Me.LeftIndicator.ForeColor = System.Drawing.Color.White
        Me.LeftIndicator.Location = New System.Drawing.Point(0, 105)
        Me.LeftIndicator.Name = "LeftIndicator"
        Me.LeftIndicator.Size = New System.Drawing.Size(30, 30)
        Me.LeftIndicator.Text = "<"
        Me.LeftIndicator.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'RightIndicator
        '
        Me.RightIndicator.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RightIndicator.ForeColor = System.Drawing.Color.White
        Me.RightIndicator.Location = New System.Drawing.Point(287, 105)
        Me.RightIndicator.Name = "RightIndicator"
        Me.RightIndicator.Size = New System.Drawing.Size(30, 30)
        Me.RightIndicator.Text = ">"
        Me.RightIndicator.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(320, 240)
        Me.Controls.Add(Me.RightIndicator)
        Me.Controls.Add(Me.LeftIndicator)
        Me.Controls.Add(Me.StartIndicator)
        Me.Controls.Add(Me.TimerRemaining)
        Me.Controls.Add(Me.TimerName)
        Me.Controls.Add(Me.Spacer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Main"
        Me.Text = "Tomate"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Spacer As System.Windows.Forms.PictureBox
    Friend WithEvents TimerName As System.Windows.Forms.Label
    Friend WithEvents TimerRemaining As System.Windows.Forms.Label
    Friend WithEvents TimerObject As System.Windows.Forms.Timer
    Friend WithEvents StartIndicator As System.Windows.Forms.Label
    Friend WithEvents LeftIndicator As System.Windows.Forms.Label
    Friend WithEvents RightIndicator As System.Windows.Forms.Label

End Class
