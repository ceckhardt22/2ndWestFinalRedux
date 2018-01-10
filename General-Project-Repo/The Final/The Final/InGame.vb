Public Class frmInGame
    Dim picPlayer As New PictureBox
    Dim movement As New Point(0, 0)
    Dim tmrShoot As New Timer
    Dim Enemies As New Object

    ' Player movement/direction declaration ...
    Dim xdir As Integer
    Dim ydir As Integer
    Dim ShotSpeed = 6

    Private Sub picPlayer_Click(sender As Object, e As EventArgs)
        ' Dim bmp As New Bitmap(picPlayer)                             
        ' bmp.MakeTransparent(Color.White)
        Me.picPlayer.BackColor = Color.Transparent      ' This allows player/bullet/enemies models to have transparent backgrounds.

    End Sub

    Private Sub playerModel_Click(sender As Object, e As EventArgs) Handles playerModel.Click
        Dim movement As New Point(0, 0)
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ' Left and Right arrow keys move player ...
        Select Case e.KeyCode
            Case Keys.Left
                Me.playerModel.Left -= 5
            Case Keys.Right
                Me.playerModel.Left -= -5
            Case Keys.Space
                picBullet.Visible = True
                Me.picBullet.Top -= 10
        End Select
    End Sub

    Private Sub timerEnemyMove_Tick(sender As Object, e As EventArgs) Handles timerEnemyMove.Tick
        ' This handles enemy movement ...
        ' This is long, but there are two many characters to handle with one variable.

        ' First (slowest) row (Enemies 1-7)

        Enemy1.Left = Enemy1.Left - 5
        If Enemy1.Left <= 5 Then
            Do
                Enemy1.Left = Enemy1.Right + 5
            Loop Until Enemy1.Left >= 750
        End If

        Enemy2.Left = Enemy2.Left - 5
        If Enemy2.Left <= 6 Then
            Do
                Enemy2.Left = Enemy2.Right + 5
            Loop Until Enemy2.Left >= 750
        End If

        Enemy3.Left = Enemy3.Left - 5
        If Enemy3.Left <= 7 Then
            Do
                Enemy3.Left = Enemy3.Right + 5
            Loop Until Enemy3.Left >= 750
        End If

        Enemy4.Left = Enemy4.Left - 5
        If Enemy4.Left <= 8 Then
            Do
                Enemy4.Left = Enemy4.Right + 5
            Loop Until Enemy4.Left >= 750
        End If

        Enemy5.Left = Enemy5.Left - 5
        If Enemy5.Left <= 9 Then
            Do
                Enemy5.Left = Enemy5.Right + 5
            Loop Until Enemy5.Left >= 775
        End If

        Enemy6.Left = Enemy6.Left - 5
        If Enemy6.Left <= 10 Then
            Do
                Enemy6.Left = Enemy6.Right + 5
            Loop Until Enemy6.Left >= 750
        End If

        Enemy7.Left = Enemy7.Left - 5
        If Enemy7.Left <= 11 Then
            Do
                Enemy7.Left = Enemy7.Right + 5
            Loop Until Enemy7.Left >= 750
        End If

        ' Second (faster) row (Enemies 8-12)

        Enemy8.Left = Enemy8.Left - 10
        If Enemy8.Left <= 5 Then
            Do
                Enemy8.Left = Enemy8.Right + 10
            Loop Until Enemy8.Left >= 780
        End If

        Enemy9.Left = Enemy9.Left - 10
        If Enemy9.Left <= 5 Then
            Do
                Enemy9.Left = Enemy9.Right + 10
            Loop Until Enemy9.Left >= 780
        End If

        Enemy10.Left = Enemy10.Left - 10
        If Enemy10.Left <= 5 Then
            Do
                Enemy10.Left = Enemy10.Right + 10
            Loop Until Enemy10.Left >= 780
        End If

        Enemy11.Left = Enemy11.Left - 10
        If Enemy11.Left <= 5 Then
            Do
                Enemy11.Left = Enemy11.Right + 10
            Loop Until Enemy11.Left >= 780
        End If

        Enemy12.Left = Enemy12.Left - 10
        If Enemy12.Left <= 5 Then
            Do
                Enemy12.Left = Enemy12.Right + 10
            Loop Until Enemy12.Left >= 780
        End If

        ' Third (fastest) row (Enemy 13)

        Enemy13.Left = Enemy13.Left - 15
        If Enemy13.Left <= 5 Then
            Do
                Enemy13.Left = Enemy13.Right + 15
            Loop Until Enemy13.Left >= 825
        End If
    End Sub

    Private Sub frmInGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Begins timerGetReady (displays starting screen) ...
        timerEnemyMove.Start()
        MessageBox.Show("Get ready to rock!")
    End Sub

    Private Sub timerPlayerFire_Tick(sender As Object, e As EventArgs) Handles timerPlayerFire.Tick

        If picBullet.Location.Y > 0 Then
            picBullet.Show()
            picBullet.Location = New Point(picBullet.Location.X, picBullet.Location.Y - 25)
        End If
    End Sub

    Sub tmrPlayerFire_stop()

        If picBullet.Location.Y < 5 Or picBullet.Bounds.IntersectsWith(Enemy1.Bounds) Then
            picBullet.Visible = False

        End If
    End Sub
End Class