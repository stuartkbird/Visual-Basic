Public Class Form1
    Dim collided As Boolean
    Dim up, down, left, right As Boolean
    Dim gotKey As Boolean
    'new'''''''''
    Dim foundWizard As Boolean
    'end-new'''''''''

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.Image = My.Resources.pacman_right
        collided = False
        up = False
        down = False
        left = False
        right = False
        gotKey = False
        foundWizard = False
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        collided = False
        'for player controls
        'up
        If e.KeyCode = Keys.Up Then
            up = True
            down = False
            left = False
            right = False
            PictureBox1.Image.Dispose()
            PictureBox1.Image = My.Resources.pacman_up
            CollisionDetection()
            If collided = False Then
                PictureBox1.Top -= 20
            End If

        End If
        'down
        If e.KeyCode = Keys.Down Then
            up = False
            down = True
            left = False
            right = False
            PictureBox1.Image.Dispose()
            PictureBox1.Image = My.Resources.pacman_down
            CollisionDetection()
            If collided = False Then
                PictureBox1.Top += 20
            End If
        End If
        'left
        If e.KeyCode = Keys.Left Then
            up = False
            down = False
            left = True
            right = False
            PictureBox1.Image.Dispose()
            PictureBox1.Image = My.Resources.pacman_left
            CollisionDetection()
            If collided = False Then
                PictureBox1.Left -= 20
            End If
        End If
        'right
        If e.KeyCode = Keys.Right Then
            up = False
            down = False
            left = False
            right = True
            PictureBox1.Image.Dispose()
            PictureBox1.Image = My.Resources.pacman_right
            CollisionDetection()
            If collided = False Then
                PictureBox1.Left += 20
            End If
        End If
        'escape
        If e.KeyCode = Keys.Escape Then
            End
            'Close()
        End If
        'restart
        If e.KeyCode = Keys.F1 Then
            'Close()

            Me.Dispose()
            Me.Refresh()
            'End
            'Me.ShowDialog()
        End If
    End Sub

    Public Sub CollisionDetection()
        '''''''''''''''''''''
        If PictureBox1.Bounds.IntersectsWith(Pnldoor.Bounds) Then
            collided = True
            If gotKey = False Then
                MsgBox("You need the key to open the door")

            ElseIf gotKey = True Then
                Pnldoor.Enabled = False
                Pnldoor.Visible = False
                collided = False
            End If
        End If
        'new'''''''''
        If PictureBox1.Bounds.IntersectsWith(pbwiz1.Bounds) Then
            collided = True
            If foundWizard = False Then
                MsgBox("Find the real wizard!!!")

            ElseIf foundWizard = True Then
                pbwiz1.Enabled = False

                collided = False
            End If
        End If
        'new'''''''''
        If PictureBox1.Bounds.IntersectsWith(pbwiz2.Bounds) Then
            collided = True
            If foundWizard = False Then
                MsgBox("Find the real wizard!!!")

            ElseIf foundWizard = True Then
                pbwiz2.Enabled = False

                collided = False
            End If
        End If
        'new'''''''''
        If PictureBox1.Bounds.IntersectsWith(pbrealwiz.Bounds) Then
            collided = True
            If foundWizard = False Then
                MsgBox("Ah you found me!!!")
                bounce()
            ElseIf foundWizard = True Then
                pbwiz1.Enabled = False

                pbwiz2.Enabled = False

                collided = False
            End If
        End If

        'end-new'''''''''

        '''''''''''''''''''''
        If PictureBox1.Bounds.IntersectsWith(Panel1.Bounds) Then
            collided = True
        End If
        If PictureBox1.Bounds.IntersectsWith(Panel2.Bounds) Then
            collided = True
        End If
        If PictureBox1.Bounds.IntersectsWith(Panel3.Bounds) Then
            collided = True
        End If
        If PictureBox1.Bounds.IntersectsWith(Panel4.Bounds) Then
            collided = True
        End If
        If PictureBox1.Bounds.IntersectsWith(Panel5.Bounds) Then
            collided = True
        End If
        If PictureBox1.Bounds.IntersectsWith(Panel6.Bounds) Then
            collided = True
        End If
        If PictureBox1.Bounds.IntersectsWith(Panel7.Bounds) Then
            collided = True
        End If
        If PictureBox1.Bounds.IntersectsWith(Panel8.Bounds) Then
            collided = True
        End If
        If PictureBox1.Bounds.IntersectsWith(Panel9.Bounds) Then
            collided = True
        End If
        If PictureBox1.Bounds.IntersectsWith(Panel10.Bounds) Then
            collided = True
        End If
        If PictureBox1.Bounds.IntersectsWith(Panel11.Bounds) Then
            collided = True
        End If
        If PictureBox1.Bounds.IntersectsWith(Panel12.Bounds) Then
            collided = True
        End If
        If PictureBox1.Bounds.IntersectsWith(Panel13.Bounds) Then
            collided = True
        End If
        If PictureBox1.Bounds.IntersectsWith(Panel14.Bounds) Then
            collided = True
        End If
        If PictureBox1.Bounds.IntersectsWith(Panel15.Bounds) Then
            collided = True
        End If
        If PictureBox1.Bounds.IntersectsWith(Panel16.Bounds) Then
            collided = True
        End If
        If PictureBox1.Bounds.IntersectsWith(Panel17.Bounds) Then
            collided = True
        End If
        If PictureBox1.Bounds.IntersectsWith(Panel18.Bounds) Then
            collided = True
        End If
        If PictureBox1.Bounds.IntersectsWith(Panel19.Bounds) Then
            collided = True
        End If
        If PictureBox1.Bounds.IntersectsWith(Panel20.Bounds) Then
            collided = True
        End If
        If PictureBox1.Bounds.IntersectsWith(Panel21.Bounds) Then
            collided = True
        End If
        If PictureBox1.Bounds.IntersectsWith(Panel22.Bounds) Then
            collided = True
        End If
        If PictureBox1.Bounds.IntersectsWith(Panel23.Bounds) Then
            collided = True
        End If
        If PictureBox1.Bounds.IntersectsWith(Panel24.Bounds) Then
            collided = True
        End If
        If PictureBox1.Bounds.IntersectsWith(Panel25.Bounds) Then
            collided = True
        End If
        If PictureBox1.Bounds.IntersectsWith(Panel26.Bounds) Then
            collided = True
        End If
        If PictureBox1.Bounds.IntersectsWith(Panel27.Bounds) Then
            collided = True
        End If
        If PictureBox1.Bounds.IntersectsWith(Panel28.Bounds) Then
            collided = True
            MsgBox("You have won the game!")
            End
        End If

        If PictureBox1.Bounds.IntersectsWith(pbKey.Bounds) Then
            collided = True
            pbKey.Enabled = False
            pbKey.Visible = False
            Form2.ShowDialog()
            gotKey = True
            pbInvKey.Visible = True

        End If
        Bounce()

        If PictureBox1.Bounds.IntersectsWith(pbrealwiz.Bounds) Then
            collided = True
            pbwiz1.Enabled = False

            pbwiz2.Enabled = False

            'pbKey.Visible = False
            'Form2.ShowDialog()
            foundWizard = True
            'pbInvKey.Visible = True

        End If

    End Sub
    Public Sub Bounce()
        If up = True Then
            PictureBox1.Top += 10
        End If
        If down = True Then
            PictureBox1.Top -= 10
        End If
        If left = True Then
            PictureBox1.Left += 10
        End If
        If right = True Then
            PictureBox1.Left -= 10
        End If
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Up Then
            collided = False
        End If
        If e.KeyCode = Keys.Down Then
            collided = False
        End If
        If e.KeyCode = Keys.Left Then
            collided = False
        End If
        If e.KeyCode = Keys.Right Then
            collided = False
        End If
    End Sub


End Class
