<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInGame
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
        Me.Enemy1 = New System.Windows.Forms.PictureBox()
        Me.Enemy2 = New System.Windows.Forms.PictureBox()
        Me.Enemy3 = New System.Windows.Forms.PictureBox()
        Me.Enemy4 = New System.Windows.Forms.PictureBox()
        Me.Enemy5 = New System.Windows.Forms.PictureBox()
        Me.Enemy6 = New System.Windows.Forms.PictureBox()
        Me.Enemy7 = New System.Windows.Forms.PictureBox()
        Me.playerModel = New System.Windows.Forms.PictureBox()
        Me.Enemy10 = New System.Windows.Forms.PictureBox()
        Me.Enemy11 = New System.Windows.Forms.PictureBox()
        Me.Enemy12 = New System.Windows.Forms.PictureBox()
        Me.Enemy8 = New System.Windows.Forms.PictureBox()
        Me.Enemy9 = New System.Windows.Forms.PictureBox()
        Me.Enemy13 = New System.Windows.Forms.PictureBox()
        Me.timerEnemyMove = New System.Windows.Forms.Timer(Me.components)
        Me.picBullet = New System.Windows.Forms.PictureBox()
        Me.picLeftBorder = New System.Windows.Forms.PictureBox()
        Me.picRightBorder = New System.Windows.Forms.PictureBox()
        Me.picTopBorder = New System.Windows.Forms.PictureBox()
        Me.picBottomBorder = New System.Windows.Forms.PictureBox()
        Me.timerPlayerFire = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Enemy1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.playerModel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBullet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLeftBorder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRightBorder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTopBorder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBottomBorder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Enemy1
        '
        Me.Enemy1.BackColor = System.Drawing.Color.Transparent
        Me.Enemy1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.enemy_sprite31
        Me.Enemy1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Enemy1.Location = New System.Drawing.Point(157, 43)
        Me.Enemy1.Name = "Enemy1"
        Me.Enemy1.Size = New System.Drawing.Size(34, 36)
        Me.Enemy1.TabIndex = 2
        Me.Enemy1.TabStop = False
        '
        'Enemy2
        '
        Me.Enemy2.BackColor = System.Drawing.Color.Transparent
        Me.Enemy2.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.enemy_sprite31
        Me.Enemy2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Enemy2.Location = New System.Drawing.Point(217, 43)
        Me.Enemy2.Name = "Enemy2"
        Me.Enemy2.Size = New System.Drawing.Size(34, 36)
        Me.Enemy2.TabIndex = 3
        Me.Enemy2.TabStop = False
        '
        'Enemy3
        '
        Me.Enemy3.BackColor = System.Drawing.Color.Transparent
        Me.Enemy3.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.enemy_sprite31
        Me.Enemy3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Enemy3.Location = New System.Drawing.Point(278, 43)
        Me.Enemy3.Name = "Enemy3"
        Me.Enemy3.Size = New System.Drawing.Size(34, 36)
        Me.Enemy3.TabIndex = 4
        Me.Enemy3.TabStop = False
        '
        'Enemy4
        '
        Me.Enemy4.BackColor = System.Drawing.Color.Transparent
        Me.Enemy4.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.enemy_sprite31
        Me.Enemy4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Enemy4.Location = New System.Drawing.Point(342, 43)
        Me.Enemy4.Name = "Enemy4"
        Me.Enemy4.Size = New System.Drawing.Size(34, 36)
        Me.Enemy4.TabIndex = 5
        Me.Enemy4.TabStop = False
        '
        'Enemy5
        '
        Me.Enemy5.BackColor = System.Drawing.Color.Transparent
        Me.Enemy5.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.enemy_sprite31
        Me.Enemy5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Enemy5.Location = New System.Drawing.Point(409, 43)
        Me.Enemy5.Name = "Enemy5"
        Me.Enemy5.Size = New System.Drawing.Size(34, 36)
        Me.Enemy5.TabIndex = 6
        Me.Enemy5.TabStop = False
        '
        'Enemy6
        '
        Me.Enemy6.BackColor = System.Drawing.Color.Transparent
        Me.Enemy6.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.enemy_sprite31
        Me.Enemy6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Enemy6.Location = New System.Drawing.Point(471, 43)
        Me.Enemy6.Name = "Enemy6"
        Me.Enemy6.Size = New System.Drawing.Size(34, 36)
        Me.Enemy6.TabIndex = 7
        Me.Enemy6.TabStop = False
        '
        'Enemy7
        '
        Me.Enemy7.BackColor = System.Drawing.Color.Transparent
        Me.Enemy7.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.enemy_sprite31
        Me.Enemy7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Enemy7.Location = New System.Drawing.Point(528, 43)
        Me.Enemy7.Name = "Enemy7"
        Me.Enemy7.Size = New System.Drawing.Size(34, 36)
        Me.Enemy7.TabIndex = 8
        Me.Enemy7.TabStop = False
        '
        'playerModel
        '
        Me.playerModel.BackColor = System.Drawing.Color.Transparent
        Me.playerModel.Image = Global.WindowsApplication1.My.Resources.Resources.player_sprite1
        Me.playerModel.Location = New System.Drawing.Point(345, 469)
        Me.playerModel.Name = "playerModel"
        Me.playerModel.Size = New System.Drawing.Size(31, 37)
        Me.playerModel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.playerModel.TabIndex = 10
        Me.playerModel.TabStop = False
        '
        'Enemy10
        '
        Me.Enemy10.BackColor = System.Drawing.Color.Transparent
        Me.Enemy10.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.enemy_sprite31
        Me.Enemy10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Enemy10.Location = New System.Drawing.Point(342, 106)
        Me.Enemy10.Name = "Enemy10"
        Me.Enemy10.Size = New System.Drawing.Size(34, 36)
        Me.Enemy10.TabIndex = 12
        Me.Enemy10.TabStop = False
        '
        'Enemy11
        '
        Me.Enemy11.BackColor = System.Drawing.Color.Transparent
        Me.Enemy11.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.enemy_sprite31
        Me.Enemy11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Enemy11.Location = New System.Drawing.Point(409, 106)
        Me.Enemy11.Name = "Enemy11"
        Me.Enemy11.Size = New System.Drawing.Size(34, 36)
        Me.Enemy11.TabIndex = 13
        Me.Enemy11.TabStop = False
        '
        'Enemy12
        '
        Me.Enemy12.BackColor = System.Drawing.Color.Transparent
        Me.Enemy12.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.enemy_sprite31
        Me.Enemy12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Enemy12.Location = New System.Drawing.Point(471, 106)
        Me.Enemy12.Name = "Enemy12"
        Me.Enemy12.Size = New System.Drawing.Size(34, 36)
        Me.Enemy12.TabIndex = 14
        Me.Enemy12.TabStop = False
        '
        'Enemy8
        '
        Me.Enemy8.BackColor = System.Drawing.Color.Transparent
        Me.Enemy8.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.enemy_sprite31
        Me.Enemy8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Enemy8.Location = New System.Drawing.Point(217, 106)
        Me.Enemy8.Name = "Enemy8"
        Me.Enemy8.Size = New System.Drawing.Size(34, 36)
        Me.Enemy8.TabIndex = 17
        Me.Enemy8.TabStop = False
        '
        'Enemy9
        '
        Me.Enemy9.BackColor = System.Drawing.Color.Transparent
        Me.Enemy9.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.enemy_sprite31
        Me.Enemy9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Enemy9.Location = New System.Drawing.Point(278, 106)
        Me.Enemy9.Name = "Enemy9"
        Me.Enemy9.Size = New System.Drawing.Size(34, 36)
        Me.Enemy9.TabIndex = 18
        Me.Enemy9.TabStop = False
        '
        'Enemy13
        '
        Me.Enemy13.BackColor = System.Drawing.Color.Transparent
        Me.Enemy13.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.enemy_sprite31
        Me.Enemy13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Enemy13.Location = New System.Drawing.Point(342, 171)
        Me.Enemy13.Name = "Enemy13"
        Me.Enemy13.Size = New System.Drawing.Size(34, 36)
        Me.Enemy13.TabIndex = 19
        Me.Enemy13.TabStop = False
        '
        'timerEnemyMove
        '
        '
        'picBullet
        '
        Me.picBullet.BackColor = System.Drawing.Color.Transparent
        Me.picBullet.Image = Global.WindowsApplication1.My.Resources.Resources.player_lazer
        Me.picBullet.Location = New System.Drawing.Point(350, 476)
        Me.picBullet.Name = "picBullet"
        Me.picBullet.Size = New System.Drawing.Size(21, 24)
        Me.picBullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBullet.TabIndex = 24
        Me.picBullet.TabStop = False
        Me.picBullet.Visible = False
        '
        'picLeftBorder
        '
        Me.picLeftBorder.BackColor = System.Drawing.Color.Transparent
        Me.picLeftBorder.Location = New System.Drawing.Point(1, 21)
        Me.picLeftBorder.Name = "picLeftBorder"
        Me.picLeftBorder.Size = New System.Drawing.Size(24, 463)
        Me.picLeftBorder.TabIndex = 25
        Me.picLeftBorder.TabStop = False
        '
        'picRightBorder
        '
        Me.picRightBorder.BackColor = System.Drawing.Color.Transparent
        Me.picRightBorder.Location = New System.Drawing.Point(718, 21)
        Me.picRightBorder.Name = "picRightBorder"
        Me.picRightBorder.Size = New System.Drawing.Size(24, 463)
        Me.picRightBorder.TabIndex = 26
        Me.picRightBorder.TabStop = False
        '
        'picTopBorder
        '
        Me.picTopBorder.BackColor = System.Drawing.Color.Transparent
        Me.picTopBorder.Location = New System.Drawing.Point(31, 2)
        Me.picTopBorder.Name = "picTopBorder"
        Me.picTopBorder.Size = New System.Drawing.Size(681, 20)
        Me.picTopBorder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTopBorder.TabIndex = 27
        Me.picTopBorder.TabStop = False
        '
        'picBottomBorder
        '
        Me.picBottomBorder.BackColor = System.Drawing.Color.Transparent
        Me.picBottomBorder.Location = New System.Drawing.Point(31, 450)
        Me.picBottomBorder.Name = "picBottomBorder"
        Me.picBottomBorder.Size = New System.Drawing.Size(681, 20)
        Me.picBottomBorder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBottomBorder.TabIndex = 28
        Me.picBottomBorder.TabStop = False
        '
        'timerPlayerFire
        '
        '
        'frmInGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.gamebackground
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(743, 529)
        Me.Controls.Add(Me.picBottomBorder)
        Me.Controls.Add(Me.picTopBorder)
        Me.Controls.Add(Me.picRightBorder)
        Me.Controls.Add(Me.picLeftBorder)
        Me.Controls.Add(Me.picBullet)
        Me.Controls.Add(Me.Enemy13)
        Me.Controls.Add(Me.Enemy9)
        Me.Controls.Add(Me.Enemy8)
        Me.Controls.Add(Me.Enemy12)
        Me.Controls.Add(Me.Enemy11)
        Me.Controls.Add(Me.Enemy10)
        Me.Controls.Add(Me.playerModel)
        Me.Controls.Add(Me.Enemy7)
        Me.Controls.Add(Me.Enemy6)
        Me.Controls.Add(Me.Enemy5)
        Me.Controls.Add(Me.Enemy4)
        Me.Controls.Add(Me.Enemy3)
        Me.Controls.Add(Me.Enemy2)
        Me.Controls.Add(Me.Enemy1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.DoubleBuffered = True
        Me.Name = "frmInGame"
        Me.Text = "InGame"
        CType(Me.Enemy1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.playerModel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBullet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLeftBorder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRightBorder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTopBorder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBottomBorder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Enemy1 As System.Windows.Forms.PictureBox
    Friend WithEvents Enemy2 As System.Windows.Forms.PictureBox
    Friend WithEvents Enemy3 As System.Windows.Forms.PictureBox
    Friend WithEvents Enemy4 As System.Windows.Forms.PictureBox
    Friend WithEvents Enemy5 As System.Windows.Forms.PictureBox
    Friend WithEvents Enemy6 As System.Windows.Forms.PictureBox
    Friend WithEvents Enemy7 As System.Windows.Forms.PictureBox
    Friend WithEvents playerModel As System.Windows.Forms.PictureBox
    Friend WithEvents Enemy10 As System.Windows.Forms.PictureBox
    Friend WithEvents Enemy11 As System.Windows.Forms.PictureBox
    Friend WithEvents Enemy12 As System.Windows.Forms.PictureBox
    Friend WithEvents Enemy8 As System.Windows.Forms.PictureBox
    Friend WithEvents Enemy9 As System.Windows.Forms.PictureBox
    Friend WithEvents Enemy13 As System.Windows.Forms.PictureBox
    Friend WithEvents timerEnemyMove As System.Windows.Forms.Timer
    Friend WithEvents picBullet As System.Windows.Forms.PictureBox
    Friend WithEvents picLeftBorder As System.Windows.Forms.PictureBox
    Friend WithEvents picRightBorder As System.Windows.Forms.PictureBox
    Friend WithEvents picTopBorder As System.Windows.Forms.PictureBox
    Friend WithEvents picBottomBorder As System.Windows.Forms.PictureBox
    Friend WithEvents timerPlayerFire As System.Windows.Forms.Timer
End Class
