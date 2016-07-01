<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MantenedorStockProductos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MantenedorStockProductos))
        Me.DGVMantenedorStockProductos = New System.Windows.Forms.DataGridView()
        Me.PNL1MantenedorStockProductos = New System.Windows.Forms.Panel()
        Me.PNL03MantenedorStockProductos = New System.Windows.Forms.Panel()
        Me.PNL01MantenddorStockProductos = New System.Windows.Forms.Panel()
        Me.PNL02MantenedorStockProductos = New System.Windows.Forms.Panel()
        Me.lblCodigoProducto = New System.Windows.Forms.Label()
        Me.lblDescripcionProducto = New System.Windows.Forms.Label()
        Me.lblStockProducto = New System.Windows.Forms.Label()
        Me.lblUnidadesVendidosPorMes = New System.Windows.Forms.Label()
        Me.lblListadoProductos = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        CType(Me.DGVMantenedorStockProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PNL01MantenddorStockProductos.SuspendLayout()
        Me.PNL02MantenedorStockProductos.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVMantenedorStockProductos
        '
        Me.DGVMantenedorStockProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVMantenedorStockProductos.Location = New System.Drawing.Point(3, 86)
        Me.DGVMantenedorStockProductos.Name = "DGVMantenedorStockProductos"
        Me.DGVMantenedorStockProductos.Size = New System.Drawing.Size(753, 301)
        Me.DGVMantenedorStockProductos.TabIndex = 0
        '
        'PNL1MantenedorStockProductos
        '
        Me.PNL1MantenedorStockProductos.Location = New System.Drawing.Point(0, 89)
        Me.PNL1MantenedorStockProductos.Name = "PNL1MantenedorStockProductos"
        Me.PNL1MantenedorStockProductos.Size = New System.Drawing.Size(32, 282)
        Me.PNL1MantenedorStockProductos.TabIndex = 1
        '
        'PNL03MantenedorStockProductos
        '
        Me.PNL03MantenedorStockProductos.BackColor = System.Drawing.Color.CadetBlue
        Me.PNL03MantenedorStockProductos.Location = New System.Drawing.Point(0, 388)
        Me.PNL03MantenedorStockProductos.Name = "PNL03MantenedorStockProductos"
        Me.PNL03MantenedorStockProductos.Size = New System.Drawing.Size(897, 132)
        Me.PNL03MantenedorStockProductos.TabIndex = 2
        '
        'PNL01MantenddorStockProductos
        '
        Me.PNL01MantenddorStockProductos.BackColor = System.Drawing.Color.CadetBlue
        Me.PNL01MantenddorStockProductos.Controls.Add(Me.TextBox4)
        Me.PNL01MantenddorStockProductos.Controls.Add(Me.TextBox3)
        Me.PNL01MantenddorStockProductos.Controls.Add(Me.TextBox2)
        Me.PNL01MantenddorStockProductos.Controls.Add(Me.TextBox1)
        Me.PNL01MantenddorStockProductos.Controls.Add(Me.lblUnidadesVendidosPorMes)
        Me.PNL01MantenddorStockProductos.Controls.Add(Me.lblStockProducto)
        Me.PNL01MantenddorStockProductos.Controls.Add(Me.lblDescripcionProducto)
        Me.PNL01MantenddorStockProductos.Controls.Add(Me.lblCodigoProducto)
        Me.PNL01MantenddorStockProductos.Controls.Add(Me.PNL1MantenedorStockProductos)
        Me.PNL01MantenddorStockProductos.Location = New System.Drawing.Point(3, 0)
        Me.PNL01MantenddorStockProductos.Name = "PNL01MantenddorStockProductos"
        Me.PNL01MantenddorStockProductos.Size = New System.Drawing.Size(894, 89)
        Me.PNL01MantenddorStockProductos.TabIndex = 4
        '
        'PNL02MantenedorStockProductos
        '
        Me.PNL02MantenedorStockProductos.BackColor = System.Drawing.Color.LightSlateGray
        Me.PNL02MantenedorStockProductos.Controls.Add(Me.btnEliminar)
        Me.PNL02MantenedorStockProductos.Controls.Add(Me.btnModificar)
        Me.PNL02MantenedorStockProductos.Controls.Add(Me.btnIngresar)
        Me.PNL02MantenedorStockProductos.Controls.Add(Me.lblListadoProductos)
        Me.PNL02MantenedorStockProductos.Location = New System.Drawing.Point(745, 89)
        Me.PNL02MantenedorStockProductos.Name = "PNL02MantenedorStockProductos"
        Me.PNL02MantenedorStockProductos.Size = New System.Drawing.Size(152, 301)
        Me.PNL02MantenedorStockProductos.TabIndex = 5
        '
        'lblCodigoProducto
        '
        Me.lblCodigoProducto.AutoSize = True
        Me.lblCodigoProducto.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoProducto.Location = New System.Drawing.Point(18, 19)
        Me.lblCodigoProducto.Name = "lblCodigoProducto"
        Me.lblCodigoProducto.Size = New System.Drawing.Size(24, 20)
        Me.lblCodigoProducto.TabIndex = 2
        Me.lblCodigoProducto.Text = "ID"
        '
        'lblDescripcionProducto
        '
        Me.lblDescripcionProducto.AutoSize = True
        Me.lblDescripcionProducto.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcionProducto.Location = New System.Drawing.Point(18, 45)
        Me.lblDescripcionProducto.Name = "lblDescripcionProducto"
        Me.lblDescripcionProducto.Size = New System.Drawing.Size(88, 20)
        Me.lblDescripcionProducto.TabIndex = 3
        Me.lblDescripcionProducto.Text = "Descripción"
        '
        'lblStockProducto
        '
        Me.lblStockProducto.AutoSize = True
        Me.lblStockProducto.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStockProducto.Location = New System.Drawing.Point(268, 19)
        Me.lblStockProducto.Name = "lblStockProducto"
        Me.lblStockProducto.Size = New System.Drawing.Size(46, 20)
        Me.lblStockProducto.TabIndex = 4
        Me.lblStockProducto.Text = "Stock"
        '
        'lblUnidadesVendidosPorMes
        '
        Me.lblUnidadesVendidosPorMes.AutoSize = True
        Me.lblUnidadesVendidosPorMes.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnidadesVendidosPorMes.Location = New System.Drawing.Point(268, 45)
        Me.lblUnidadesVendidosPorMes.Name = "lblUnidadesVendidosPorMes"
        Me.lblUnidadesVendidosPorMes.Size = New System.Drawing.Size(143, 20)
        Me.lblUnidadesVendidosPorMes.TabIndex = 5
        Me.lblUnidadesVendidosPorMes.Text = "Unidades Vendidas "
        '
        'lblListadoProductos
        '
        Me.lblListadoProductos.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListadoProductos.Location = New System.Drawing.Point(17, 26)
        Me.lblListadoProductos.Name = "lblListadoProductos"
        Me.lblListadoProductos.Size = New System.Drawing.Size(124, 42)
        Me.lblListadoProductos.TabIndex = 6
        Me.lblListadoProductos.Text = "Listar"
        Me.lblListadoProductos.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(116, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 10
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(116, 45)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 11
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(417, 19)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 12
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(417, 45)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 13
        '
        'btnIngresar
        '
        Me.btnIngresar.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresar.Location = New System.Drawing.Point(17, 96)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(124, 42)
        Me.btnIngresar.TabIndex = 7
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Location = New System.Drawing.Point(17, 165)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(124, 42)
        Me.btnModificar.TabIndex = 8
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(17, 240)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(124, 42)
        Me.btnEliminar.TabIndex = 9
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'MantenedorStockProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 482)
        Me.Controls.Add(Me.PNL02MantenedorStockProductos)
        Me.Controls.Add(Me.PNL01MantenddorStockProductos)
        Me.Controls.Add(Me.PNL03MantenedorStockProductos)
        Me.Controls.Add(Me.DGVMantenedorStockProductos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MantenedorStockProductos"
        Me.Text = "Mantenedor Stock Productos"
        CType(Me.DGVMantenedorStockProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PNL01MantenddorStockProductos.ResumeLayout(False)
        Me.PNL01MantenddorStockProductos.PerformLayout()
        Me.PNL02MantenedorStockProductos.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGVMantenedorStockProductos As DataGridView
    Friend WithEvents PNL1MantenedorStockProductos As Panel
    Friend WithEvents PNL03MantenedorStockProductos As Panel
    Friend WithEvents PNL01MantenddorStockProductos As Panel
    Friend WithEvents PNL02MantenedorStockProductos As Panel
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblUnidadesVendidosPorMes As Label
    Friend WithEvents lblStockProducto As Label
    Friend WithEvents lblDescripcionProducto As Label
    Friend WithEvents lblCodigoProducto As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnIngresar As Button
    Friend WithEvents lblListadoProductos As Button
End Class
