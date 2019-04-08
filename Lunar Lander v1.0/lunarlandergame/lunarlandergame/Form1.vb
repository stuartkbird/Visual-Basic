Public Class Form1

    'Creating global variables
    Dim fuel As Integer = 100
    Dim velocity As Integer
    Dim horiz As Integer
    Dim start As Boolean


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        velocity = 0
        pbFlame.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
        start = True
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Space Then
            start = True
            lblStart.Visible = False
            Timer1.Enabled = True

        End If

        If e.KeyCode = Keys.Up Then
            If start = True Then
                If fuel > 0 Then
                    velocity -= 1
                End If
                fuel -= 1
                lblFuel.Text = fuel
                pbFlame.Visible = True
            End If
        End If

        If e.KeyCode = Keys.Right Then
            'If start = True Then
            'If fuel > 0 Then
            'horiz += 1
            'End If
            'fuel -= 1
            'lblFuel.Text = fuel
            'pbFlame.Visible = True
            'End If

            If pbNeil.Visible = True Then
                pbNeil.Left += 2

            ElseIf pbNeil.Visible = False Then
                pbLander.Left += 2
                pbFlame.Left += 2

            End If
        End If

        If e.KeyCode = Keys.Left Then
            'If start = True Then
            'If fuel > 0 Then
            'horiz -= 1
            'End If
            'fuel -= 1
            'lblFuel.Text = fuel
            'pbFlame.Visible = True
            'End If

            If pbNeil.Visible = True Then
                pbNeil.Left -= 2


            ElseIf pbNeil.Visible = False Then
                pbLander.Left -= 2
                pbFlame.Left -= 2

            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        velocity += 1 'velocity = velocity +1
        'Lander movement over time
        pbLander.Top += velocity
        pbFlame.Top = pbLander.Top + pbLander.Height
        ' to adjust flame pos pbFlame.Left = pbLander.Left + 15

        'If pbLander.Top + pbLander.height, pnlMoon.top
        If (pbLander.Top + pbLander.Height) >= pnlMoon.Top Then

            '******SURVIVE****
            If velocity < 20 Then
                Timer1.Enabled = False
                MsgBox("The Eagle Has Landed!!!")
                pbNeil.Visible = True


            ElseIf velocity >= 20 Then

                '******DEATH******
                Timer1.Enabled = False
                pbLander.Image = Image.FromFile(filename:="C:\Users\sbird\Desktop\Lunar Lander v1.0\explosion.gif")
                MsgBox("You Died!!!")
            End If
        End If


    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Up Then
            pbFlame.Visible = False
        End If
    End Sub
End Class
