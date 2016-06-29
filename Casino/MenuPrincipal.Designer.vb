<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GaleriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NosotrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginCasinoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.NosotrosToolStripMenuItem, Me.GaleriaToolStripMenuItem, Me.ContactoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(614, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginCasinoToolStripMenuItem})
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'GaleriaToolStripMenuItem
        '
        Me.GaleriaToolStripMenuItem.Name = "GaleriaToolStripMenuItem"
        Me.GaleriaToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.GaleriaToolStripMenuItem.Text = "Galeria"
        '
        'NosotrosToolStripMenuItem
        '
        Me.NosotrosToolStripMenuItem.Name = "NosotrosToolStripMenuItem"
        Me.NosotrosToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.NosotrosToolStripMenuItem.Text = "Nosotros"
        '
        'ContactoToolStripMenuItem
        '
        Me.ContactoToolStripMenuItem.Name = "ContactoToolStripMenuItem"
        Me.ContactoToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.ContactoToolStripMenuItem.Text = "Contacto"
        '
        'LoginCasinoToolStripMenuItem
        '
        Me.LoginCasinoToolStripMenuItem.Name = "LoginCasinoToolStripMenuItem"
        Me.LoginCasinoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LoginCasinoToolStripMenuItem.Text = "Login Casino"
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Casino.My.Resources.Resources.black_pattern_squares_wallpaper_12
        Me.ClientSize = New System.Drawing.Size(614, 372)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MenuPrincipal"
        Me.Text = "                                                                         Menu Pri" &
    "ncipal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginCasinoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NosotrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GaleriaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactoToolStripMenuItem As ToolStripMenuItem
End Class
