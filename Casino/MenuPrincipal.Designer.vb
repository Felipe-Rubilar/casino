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
        Me.operaciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginCasinoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mantenedores = New System.Windows.Forms.ToolStripMenuItem()
        Me.reportes = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.operaciones, Me.mantenedores, Me.reportes, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(716, 56)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'operaciones
        '
        Me.operaciones.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginCasinoToolStripMenuItem})
        Me.operaciones.Image = CType(resources.GetObject("operaciones.Image"), System.Drawing.Image)
        Me.operaciones.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.operaciones.Name = "operaciones"
        Me.operaciones.Size = New System.Drawing.Size(136, 52)
        Me.operaciones.Text = "Operaciones "
        '
        'LoginCasinoToolStripMenuItem
        '
        Me.LoginCasinoToolStripMenuItem.Image = CType(resources.GetObject("LoginCasinoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LoginCasinoToolStripMenuItem.Name = "LoginCasinoToolStripMenuItem"
        Me.LoginCasinoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LoginCasinoToolStripMenuItem.Text = "Realizar Venta"
        '
        'mantenedores
        '
        Me.mantenedores.Image = CType(resources.GetObject("mantenedores.Image"), System.Drawing.Image)
        Me.mantenedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mantenedores.Name = "mantenedores"
        Me.mantenedores.Size = New System.Drawing.Size(143, 52)
        Me.mantenedores.Text = "Mantenedores"
        '
        'reportes
        '
        Me.reportes.Image = CType(resources.GetObject("reportes.Image"), System.Drawing.Image)
        Me.reportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.reportes.Name = "reportes"
        Me.reportes.Size = New System.Drawing.Size(113, 52)
        Me.reportes.Text = "Reportes"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = CType(resources.GetObject("SalirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SalirToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(92, 52)
        Me.SalirToolStripMenuItem.Text = "Salir "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(570, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tipo de usuario conectado"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(620, 25)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(34, 13)
        Me.TextBox1.TabIndex = 3
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(716, 511)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
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
    Friend WithEvents operaciones As ToolStripMenuItem
    Friend WithEvents LoginCasinoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mantenedores As ToolStripMenuItem
    Friend WithEvents reportes As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
