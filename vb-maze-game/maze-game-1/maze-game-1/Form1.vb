Public Class Form1
    Dim score As Integer = 1000

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        'CONTROLS
        If e.KeyCode = Keys.W Then
            PictureBox1.Top = PictureBox1.Top - 5
        End If
        If e.KeyCode = Keys.A Then
            PictureBox1.Left = PictureBox1.Left - 5
        End If
        If e.KeyCode = Keys.S Then
            PictureBox1.Top = PictureBox1.Top + 5
        End If
        If e.KeyCode = Keys.D Then
            PictureBox1.Left = PictureBox1.Left + 5
        End If

        'WIN
        If PictureBox1.Bounds.IntersectsWith(PictureBox7.Bounds) Then
            Timer1.Stop()
            MsgBox("Well Done! Your Score Is: " & "" & score)
            Close()
        End If

        'JEWELS
        If PictureBox1.Bounds.IntersectsWith(PictureBox6.Bounds) Then
            points()
            PictureBox1.Top = 53
            PictureBox1.Left = 125
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox8.Bounds) Then
            points()
            PictureBox1.Top = 53
            PictureBox1.Left = 125
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox9.Bounds) Then
            points()
            PictureBox1.Top = 53
            PictureBox1.Left = 125
        End If

        'OUTER WALLS
        If PictureBox1.Bounds.IntersectsWith(PictureBox2.Bounds) Then
            points()
            PictureBox1.Top = 53
            PictureBox1.Left = 125
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox3.Bounds) Then
            points()
            PictureBox1.Top = 53
            PictureBox1.Left = 125
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox4.Bounds) Then
            points()
            PictureBox1.Top = 53
            PictureBox1.Left = 125
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox5.Bounds) Then
            points()
            PictureBox1.Top = 53
            PictureBox1.Left = 125
        End If

        'FAKE WALLS: 11 & 18

        'INVISIBLE WALLS
        If PictureBox1.Bounds.IntersectsWith(PictureBox38.Bounds) Then
            points()
            PictureBox1.Top = 53
            PictureBox1.Left = 125
        End If


        'INNER WALLS
        If PictureBox1.Bounds.IntersectsWith(PictureBox10.Bounds) Then
            points()
            PictureBox1.Top = 53
            PictureBox1.Left = 125
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox12.Bounds) Then
            points()
            PictureBox1.Top = 53
            PictureBox1.Left = 125
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox13.Bounds) Then
            points()
            PictureBox1.Top = 53
            PictureBox1.Left = 125
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox14.Bounds) Then
            points()
            PictureBox1.Top = 53
            PictureBox1.Left = 125
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox15.Bounds) Then
            points()
            PictureBox1.Top = 53
            PictureBox1.Left = 125
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox16.Bounds) Then
            points()
            PictureBox1.Top = 53
            PictureBox1.Left = 125
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox17.Bounds) Then
            points()
            PictureBox1.Top = 53
            PictureBox1.Left = 125
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox19.Bounds) Then
            points()
            PictureBox1.Top = 53
            PictureBox1.Left = 125
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox20.Bounds) Then
            points()
            PictureBox1.Top = 53
            PictureBox1.Left = 125
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox21.Bounds) Then
            points()
            PictureBox1.Top = 53
            PictureBox1.Left = 125
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox22.Bounds) Then
            points()
            PictureBox1.Top = 53
            PictureBox1.Left = 125
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox23.Bounds) Then
            points()
            PictureBox1.Top = 53
            PictureBox1.Left = 125
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox24.Bounds) Then
            points()
            PictureBox1.Top = 53
            PictureBox1.Left = 125
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox25.Bounds) Then
            points()
            PictureBox1.Top = 53
            PictureBox1.Left = 125
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox26.Bounds) Then
            points()
            PictureBox1.Top = 53
            PictureBox1.Left = 125
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox27.Bounds) Then
            points()
            PictureBox1.Top = 53
            PictureBox1.Left = 125
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox28.Bounds) Then
            points()
            PictureBox1.Top = 53
            PictureBox1.Left = 125
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox29.Bounds) Then
            points()
            PictureBox1.Top = 53
            PictureBox1.Left = 125
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox30.Bounds) Then
            points()
            PictureBox1.Top = 53
            PictureBox1.Left = 125
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox31.Bounds) Then
            points()
            PictureBox1.Top = 53
            PictureBox1.Left = 125
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox32.Bounds) Then
            points()
            PictureBox1.Top = 53
            PictureBox1.Left = 125
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox33.Bounds) Then
            points()
            PictureBox1.Top = 53
            PictureBox1.Left = 125
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox34.Bounds) Then
            points()
            PictureBox1.Top = 53
            PictureBox1.Left = 125
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox35.Bounds) Then
            points()
            PictureBox1.Top = 53
            PictureBox1.Left = 125
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox36.Bounds) Then
            points()
            PictureBox1.Top = 53
            PictureBox1.Left = 125
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox37.Bounds) Then
            points()
            PictureBox1.Top = 53
            PictureBox1.Left = 125
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox39.Bounds) Then
            points()
            PictureBox1.Top = 53
            PictureBox1.Left = 125
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox40.Bounds) Then
            points()
            PictureBox1.Top = 53
            PictureBox1.Left = 125
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox41.Bounds) Then
            points()
            PictureBox1.Top = 53
            PictureBox1.Left = 125
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        points()
        lblScore.Text = CStr(score)
        If score = 0 Then
            Timer1.Stop()
            MsgBox("You Lose!!!")
            Close()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Function points()
        If score > 0 Then
            score = score - 10
        End If
    End Function
End Class
