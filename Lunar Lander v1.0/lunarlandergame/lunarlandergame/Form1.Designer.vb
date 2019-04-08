<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblStart = New System.Windows.Forms.Label()
        Me.pbEarth = New System.Windows.Forms.PictureBox()
        Me.pbLander = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pnlMoon = New System.Windows.Forms.Panel()
        Me.lblFuel = New System.Windows.Forms.Label()
        Me.pbFlame = New System.Windows.Forms.PictureBox()
        Me.pbNeil = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.pbEarth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLander, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFlame, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbNeil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.Font = New System.Drawing.Font("OCR A Extended", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStart.ForeColor = System.Drawing.Color.White
        Me.lblStart.Location = New System.Drawing.Point(464, 269)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(523, 39)
        Me.lblStart.TabIndex = 0
        Me.lblStart.Text = "Press Space to Start..."
        '
        'pbEarth
        '
        Me.pbEarth.Image = CType(resources.GetObject("pbEarth.Image"), System.Drawing.Image)
        Me.pbEarth.Location = New System.Drawing.Point(12, 12)
        Me.pbEarth.Name = "pbEarth"
        Me.pbEarth.Size = New System.Drawing.Size(278, 176)
        Me.pbEarth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbEarth.TabIndex = 1
        Me.pbEarth.TabStop = False
        '
        'pbLander
        '
        Me.pbLander.Image = CType(resources.GetObject("pbLander.Image"), System.Drawing.Image)
        Me.pbLander.Location = New System.Drawing.Point(719, 142)
        Me.pbLander.Name = "pbLander"
        Me.pbLander.Size = New System.Drawing.Size(34, 34)
        Me.pbLander.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLander.TabIndex = 2
        Me.pbLander.TabStop = False
        '
        'Timer1
        '
        '
        'pnlMoon
        '
        Me.pnlMoon.BackColor = System.Drawing.Color.LightGray
        Me.pnlMoon.Location = New System.Drawing.Point(12, 550)
        Me.pnlMoon.Name = "pnlMoon"
        Me.pnlMoon.Size = New System.Drawing.Size(1407, 69)
        Me.pnlMoon.TabIndex = 3
        '
        'lblFuel
        '
        Me.lblFuel.AutoSize = True
        Me.lblFuel.Font = New System.Drawing.Font("OCR A Extended", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFuel.ForeColor = System.Drawing.Color.White
        Me.lblFuel.Location = New System.Drawing.Point(123, 191)
        Me.lblFuel.Name = "lblFuel"
        Me.lblFuel.Size = New System.Drawing.Size(83, 39)
        Me.lblFuel.TabIndex = 4
        Me.lblFuel.Text = "100"
        '
        'pbFlame
        '
        Me.pbFlame.Image = CType(resources.GetObject("pbFlame.Image"), System.Drawing.Image)
        Me.pbFlame.Location = New System.Drawing.Point(719, 182)
        Me.pbFlame.Name = "pbFlame"
        Me.pbFlame.Size = New System.Drawing.Size(34, 29)
        Me.pbFlame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbFlame.TabIndex = 5
        Me.pbFlame.TabStop = False
        Me.pbFlame.Visible = False
        '
        'pbNeil
        '
        Me.pbNeil.Image = CType(resources.GetObject("pbNeil.Image"), System.Drawing.Image)
        Me.pbNeil.Location = New System.Drawing.Point(781, 526)
        Me.pbNeil.Name = "pbNeil"
        Me.pbNeil.Size = New System.Drawing.Size(12, 18)
        Me.pbNeil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbNeil.TabIndex = 6
        Me.pbNeil.TabStop = False
        Me.pbNeil.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("OCR A Extended", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 191)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 39)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "FUEL"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1431, 631)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pbNeil)
        Me.Controls.Add(Me.pbFlame)
        Me.Controls.Add(Me.lblFuel)
        Me.Controls.Add(Me.pnlMoon)
        Me.Controls.Add(Me.pbLander)
        Me.Controls.Add(Me.pbEarth)
        Me.Controls.Add(Me.lblStart)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.Text = " "
        CType(Me.pbEarth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLander, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFlame, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbNeil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblStart As Label
    Friend WithEvents pbEarth As PictureBox
    Friend WithEvents pbLander As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents pnlMoon As Panel
    Friend WithEvents lblFuel As Label
    Friend WithEvents pbFlame As PictureBox
    Friend WithEvents pbNeil As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Label1 As Label
End Class
