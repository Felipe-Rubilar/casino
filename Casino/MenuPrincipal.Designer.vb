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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginCasinoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NosotrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.NosotrosToolStripMenuItem, Me.ContactoToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(534, 56)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginCasinoToolStripMenuItem})
        Me.InicioToolStripMenuItem.Image = CType(resources.GetObject("InicioToolStripMenuItem.Image"), System.Drawing.Image)
        Me.InicioToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(136, 52)
        Me.InicioToolStripMenuItem.Text = "Operaciones "
        '
        'LoginCasinoToolStripMenuItem
        '
        Me.LoginCasinoToolStripMenuItem.Image = CType(resources.GetObject("LoginCasinoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LoginCasinoToolStripMenuItem.Name = "LoginCasinoToolStripMenuItem"
        Me.LoginCasinoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LoginCasinoToolStripMenuItem.Text = "Realizar Venta"
        '
        'NosotrosToolStripMenuItem
        '
        Me.NosotrosToolStripMenuItem.Image = CType(resources.GetObject("NosotrosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NosotrosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.NosotrosToolStripMenuItem.Name = "NosotrosToolStripMenuItem"
        Me.NosotrosToolStripMenuItem.Size = New System.Drawing.Size(143, 52)
        Me.NosotrosToolStripMenuItem.Text = "Mantenedores"
        '
        'ContactoToolStripMenuItem
        '
        Me.ContactoToolStripMenuItem.Image = CType(resources.GetObject("ContactoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ContactoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ContactoToolStripMenuItem.Name = "ContactoToolStripMenuItem"
        Me.ContactoToolStripMenuItem.Size = New System.Drawing.Size(113, 52)
        Me.ContactoToolStripMenuItem.Text = "Reportes"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = CType(resources.GetObject("SalirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SalirToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(92, 52)
        Me.SalirToolStripMenuItem.Text = "Salir "
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(534, 511)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MenuPrincipal"
        Me.Text = "                                                                         Menu Pri" &
    "ncipal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginCasinoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NosotrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
