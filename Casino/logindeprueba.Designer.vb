<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogindePrueba
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LogindePrueba))
        Me.pnl2login = New System.Windows.Forms.Panel()
        Me.txtclavecasino = New System.Windows.Forms.TextBox()
        Me.txtusuariocasino = New System.Windows.Forms.TextBox()
        Me.lblclave = New System.Windows.Forms.Label()
        Me.lblusuario = New System.Windows.Forms.Label()
        Me.pnl3login = New System.Windows.Forms.Panel()
        Me.btnaceptarcasino = New System.Windows.Forms.Button()
        Me.pnl1login = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbltitulocasino = New System.Windows.Forms.Label()
        Me.pnl2login.SuspendLayout()
        Me.pnl3login.SuspendLayout()
        Me.pnl1login.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl2login
        '
        Me.pnl2login.BackgroundImage = Global.Casino.My.Resources.Resources.android_honeycomb_background_by_iride113_d42fcbs
        Me.pnl2login.Controls.Add(Me.txtclavecasino)
        Me.pnl2login.Controls.Add(Me.txtusuariocasino)
        Me.pnl2login.Controls.Add(Me.lblclave)
        Me.pnl2login.Controls.Add(Me.lblusuario)
        Me.pnl2login.Location = New System.Drawing.Point(0, 98)
        Me.pnl2login.Name = "pnl2login"
        Me.pnl2login.Size = New System.Drawing.Size(684, 190)
        Me.pnl2login.TabIndex = 0
        '
        'txtclavecasino
        '
        Me.txtclavecasino.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtclavecasino.Font = New System.Drawing.Font("Papyrus", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtclavecasino.ForeColor = System.Drawing.Color.White
        Me.txtclavecasino.Location = New System.Drawing.Point(243, 112)
        Me.txtclavecasino.Name = "txtclavecasino"
        Me.txtclavecasino.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtclavecasino.Size = New System.Drawing.Size(300, 37)
        Me.txtclavecasino.TabIndex = 3
        '
        'txtusuariocasino
        '
        Me.txtusuariocasino.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtusuariocasino.Font = New System.Drawing.Font("Papyrus", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusuariocasino.ForeColor = System.Drawing.Color.White
        Me.txtusuariocasino.Location = New System.Drawing.Point(243, 44)
        Me.txtusuariocasino.Name = "txtusuariocasino"
        Me.txtusuariocasino.Size = New System.Drawing.Size(300, 37)
        Me.txtusuariocasino.TabIndex = 2
        '
        'lblclave
        '
        Me.lblclave.AutoSize = True
        Me.lblclave.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblclave.Font = New System.Drawing.Font("Papyrus", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblclave.ForeColor = System.Drawing.SystemColors.Control
        Me.lblclave.Location = New System.Drawing.Point(53, 107)
        Me.lblclave.Name = "lblclave"
        Me.lblclave.Size = New System.Drawing.Size(95, 42)
        Me.lblclave.TabIndex = 1
        Me.lblclave.Text = "Clave"
        '
        'lblusuario
        '
        Me.lblusuario.AutoSize = True
        Me.lblusuario.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblusuario.Font = New System.Drawing.Font("Papyrus", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusuario.ForeColor = System.Drawing.SystemColors.Control
        Me.lblusuario.Location = New System.Drawing.Point(53, 39)
        Me.lblusuario.Name = "lblusuario"
        Me.lblusuario.Size = New System.Drawing.Size(116, 42)
        Me.lblusuario.TabIndex = 0
        Me.lblusuario.Text = "Usuario"
        '
        'pnl3login
        '
        Me.pnl3login.BackgroundImage = Global.Casino.My.Resources.Resources.black_pattern_squares_wallpaper_12
        Me.pnl3login.Controls.Add(Me.btnaceptarcasino)
        Me.pnl3login.Location = New System.Drawing.Point(0, 285)
        Me.pnl3login.Name = "pnl3login"
        Me.pnl3login.Size = New System.Drawing.Size(684, 78)
        Me.pnl3login.TabIndex = 2
        '
        'btnaceptarcasino
        '
        Me.btnaceptarcasino.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnaceptarcasino.Font = New System.Drawing.Font("Papyrus", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaceptarcasino.ForeColor = System.Drawing.SystemColors.Control
        Me.btnaceptarcasino.Location = New System.Drawing.Point(485, 23)
        Me.btnaceptarcasino.Name = "btnaceptarcasino"
        Me.btnaceptarcasino.Size = New System.Drawing.Size(148, 41)
        Me.btnaceptarcasino.TabIndex = 0
        Me.btnaceptarcasino.Text = "Aceptar"
        Me.btnaceptarcasino.UseVisualStyleBackColor = False
        '
        'pnl1login
        '
        Me.pnl1login.BackgroundImage = Global.Casino.My.Resources.Resources.black_pattern_squares_wallpaper_12
        Me.pnl1login.Controls.Add(Me.PictureBox1)
        Me.pnl1login.Controls.Add(Me.lbltitulocasino)
        Me.pnl1login.ForeColor = System.Drawing.Color.White
        Me.pnl1login.Location = New System.Drawing.Point(0, 0)
        Me.pnl1login.Name = "pnl1login"
        Me.pnl1login.Size = New System.Drawing.Size(684, 109)
        Me.pnl1login.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Casino.My.Resources.Resources.Coffeshop_Hipster_80x80
        Me.PictureBox1.Location = New System.Drawing.Point(57, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 80)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'lbltitulocasino
        '
        Me.lbltitulocasino.AutoSize = True
        Me.lbltitulocasino.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbltitulocasino.Font = New System.Drawing.Font("Papyrus", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulocasino.ForeColor = System.Drawing.SystemColors.Control
        Me.lbltitulocasino.Location = New System.Drawing.Point(298, 16)
        Me.lbltitulocasino.Name = "lbltitulocasino"
        Me.lbltitulocasino.Size = New System.Drawing.Size(286, 76)
        Me.lbltitulocasino.TabIndex = 0
        Me.lbltitulocasino.Text = "CASINO"
        '
        'LogindePrueba
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 361)
        Me.Controls.Add(Me.pnl2login)
        Me.Controls.Add(Me.pnl3login)
        Me.Controls.Add(Me.pnl1login)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LogindePrueba"
        Me.Text = "Login"
        Me.TopMost = True
        Me.pnl2login.ResumeLayout(False)
        Me.pnl2login.PerformLayout()
        Me.pnl3login.ResumeLayout(False)
        Me.pnl1login.ResumeLayout(False)
        Me.pnl1login.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl2login As Panel
    Friend WithEvents pnl1login As Panel
    Friend WithEvents pnl3login As Panel
    Friend WithEvents lblclave As Label
    Friend WithEvents lblusuario As Label
    Friend WithEvents lbltitulocasino As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtclavecasino As TextBox
    Friend WithEvents txtusuariocasino As TextBox
    Friend WithEvents btnaceptarcasino As Button
End Class
