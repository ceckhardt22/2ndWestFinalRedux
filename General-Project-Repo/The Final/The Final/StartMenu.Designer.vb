<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartMenu
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
        Me.btnStart = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.picMainMenu = New System.Windows.Forms.PictureBox()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMainMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.AutoSize = True
        Me.btnStart.BackColor = System.Drawing.Color.Transparent
        Me.btnStart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btnStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStart.Location = New System.Drawing.Point(334, 288)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(62, 15)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start Game"
        Me.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Location = New System.Drawing.Point(334, 330)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(62, 15)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnExit.UseMnemonic = False
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.Transparent
        Me.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picLogo.Cursor = System.Windows.Forms.Cursors.Default
        Me.picLogo.Image = Global.WindowsApplication1.My.Resources.Resources.artworks_000199815334_zqnld0_original
        Me.picLogo.Location = New System.Drawing.Point(126, 144)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(474, 122)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 4
        Me.picLogo.TabStop = False
        '
        'picMainMenu
        '
        Me.picMainMenu.Image = Global.WindowsApplication1.My.Resources.Resources.menubackground
        Me.picMainMenu.InitialImage = Nothing
        Me.picMainMenu.Location = New System.Drawing.Point(-9, 3)
        Me.picMainMenu.Name = "picMainMenu"
        Me.picMainMenu.Size = New System.Drawing.Size(743, 560)
        Me.picMainMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMainMenu.TabIndex = 3
        Me.picMainMenu.TabStop = False
        '
        'StartMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 555)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.picMainMenu)
        Me.Name = "StartMenu"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Form1"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMainMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStart As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Label
    Friend WithEvents picMainMenu As System.Windows.Forms.PictureBox
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox

End Class
