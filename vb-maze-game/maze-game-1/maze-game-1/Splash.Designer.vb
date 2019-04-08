<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Splash
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Splash))
        Me.title1 = New System.Windows.Forms.Label()
        Me.howtoplay1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'title1
        '
        Me.title1.AutoSize = True
        Me.title1.BackColor = System.Drawing.Color.Transparent
        Me.title1.Font = New System.Drawing.Font("Chiller", 72.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title1.ForeColor = System.Drawing.Color.White
        Me.title1.Location = New System.Drawing.Point(196, 48)
        Me.title1.Name = "title1"
        Me.title1.Size = New System.Drawing.Size(914, 166)
        Me.title1.TabIndex = 0
        Me.title1.Text = "The Cursed Temple"
        Me.title1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'howtoplay1
        '
        Me.howtoplay1.AutoSize = True
        Me.howtoplay1.BackColor = System.Drawing.Color.Transparent
        Me.howtoplay1.Font = New System.Drawing.Font("Chiller", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.howtoplay1.ForeColor = System.Drawing.Color.White
        Me.howtoplay1.Location = New System.Drawing.Point(186, 214)
        Me.howtoplay1.Name = "howtoplay1"
        Me.howtoplay1.Size = New System.Drawing.Size(961, 252)
        Me.howtoplay1.TabIndex = 1
        Me.howtoplay1.Text = resources.GetString("howtoplay1.Text")
        Me.howtoplay1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.ClientSize = New System.Drawing.Size(1946, 1021)
        Me.Controls.Add(Me.howtoplay1)
        Me.Controls.Add(Me.title1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(-10, -10)
        Me.Name = "Splash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents title1 As Label
    Friend WithEvents howtoplay1 As Label

    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
