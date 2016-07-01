<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MantenedorStock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MantenedorStock))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnStockVolver = New System.Windows.Forms.Button()
        Me.btnStockOnline = New System.Windows.Forms.Button()
        Me.btnStockPedido = New System.Windows.Forms.Button()
        Me.btnStockModificar = New System.Windows.Forms.Button()
        Me.btnStockBuscar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbStockID = New System.Windows.Forms.ComboBox()
        Me.txtStockID = New System.Windows.Forms.TextBox()
        Me.lblStockDescripcion = New System.Windows.Forms.Label()
        Me.lblStockID = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblSolicitudPedidoStock = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(1, 84)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(704, 241)
        Me.DataGridView1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnStockVolver)
        Me.Panel2.Controls.Add(Me.btnStockOnline)
        Me.Panel2.Controls.Add(Me.btnStockPedido)
        Me.Panel2.Controls.Add(Me.btnStockModificar)
        Me.Panel2.Controls.Add(Me.btnStockBuscar)
        Me.Panel2.Location = New System.Drawing.Point(701, 84)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(142, 241)
        Me.Panel2.TabIndex = 2
        '
        'btnStockVolver
        '
        Me.btnStockVolver.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStockVolver.Location = New System.Drawing.Point(0, 190)
        Me.btnStockVolver.Name = "btnStockVolver"
        Me.btnStockVolver.Size = New System.Drawing.Size(139, 51)
        Me.btnStockVolver.TabIndex = 4
        Me.btnStockVolver.Text = "Volver"
        Me.btnStockVolver.UseVisualStyleBackColor = True
        '
        'btnStockOnline
        '
        Me.btnStockOnline.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStockOnline.Location = New System.Drawing.Point(0, 142)
        Me.btnStockOnline.Name = "btnStockOnline"
        Me.btnStockOnline.Size = New System.Drawing.Size(139, 51)
        Me.btnStockOnline.TabIndex = 3
        Me.btnStockOnline.Text = "Online"
        Me.btnStockOnline.UseVisualStyleBackColor = True
        '
        'btnStockPedido
        '
        Me.btnStockPedido.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStockPedido.Location = New System.Drawing.Point(0, 94)
        Me.btnStockPedido.Name = "btnStockPedido"
        Me.btnStockPedido.Size = New System.Drawing.Size(139, 51)
        Me.btnStockPedido.TabIndex = 2
        Me.btnStockPedido.Text = "Pedir"
        Me.btnStockPedido.UseVisualStyleBackColor = True
        '
        'btnStockModificar
        '
        Me.btnStockModificar.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStockModificar.Location = New System.Drawing.Point(0, 48)
        Me.btnStockModificar.Name = "btnStockModificar"
        Me.btnStockModificar.Size = New System.Drawing.Size(139, 51)
        Me.btnStockModificar.TabIndex = 1
        Me.btnStockModificar.Text = "Modificar"
        Me.btnStockModificar.UseVisualStyleBackColor = True
        '
        'btnStockBuscar
        '
        Me.btnStockBuscar.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStockBuscar.Location = New System.Drawing.Point(0, 0)
        Me.btnStockBuscar.Name = "btnStockBuscar"
        Me.btnStockBuscar.Size = New System.Drawing.Size(139, 51)
        Me.btnStockBuscar.TabIndex = 0
        Me.btnStockBuscar.Text = "Buscar"
        Me.btnStockBuscar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Controls.Add(Me.cmbStockID)
        Me.Panel1.Controls.Add(Me.txtStockID)
        Me.Panel1.Controls.Add(Me.lblStockDescripcion)
        Me.Panel1.Controls.Add(Me.lblStockID)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(842, 84)
        Me.Panel1.TabIndex = 0
        '
        'cmbStockID
        '
        Me.cmbStockID.FormattingEnabled = True
        Me.cmbStockID.Location = New System.Drawing.Point(114, 41)
        Me.cmbStockID.Name = "cmbStockID"
        Me.cmbStockID.Size = New System.Drawing.Size(590, 21)
        Me.cmbStockID.TabIndex = 3
        '
        'txtStockID
        '
        Me.txtStockID.Location = New System.Drawing.Point(114, 9)
        Me.txtStockID.Name = "txtStockID"
        Me.txtStockID.Size = New System.Drawing.Size(189, 20)
        Me.txtStockID.TabIndex = 2
        '
        'lblStockDescripcion
        '
        Me.lblStockDescripcion.AutoSize = True
        Me.lblStockDescripcion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStockDescripcion.Location = New System.Drawing.Point(11, 41)
        Me.lblStockDescripcion.Name = "lblStockDescripcion"
        Me.lblStockDescripcion.Size = New System.Drawing.Size(90, 21)
        Me.lblStockDescripcion.TabIndex = 1
        Me.lblStockDescripcion.Text = "Descripción"
        '
        'lblStockID
        '
        Me.lblStockID.AutoSize = True
        Me.lblStockID.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStockID.Location = New System.Drawing.Point(11, 8)
        Me.lblStockID.Name = "lblStockID"
        Me.lblStockID.Size = New System.Drawing.Size(25, 21)
        Me.lblStockID.TabIndex = 0
        Me.lblStockID.Text = "ID"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel3.Location = New System.Drawing.Point(1, 357)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(842, 125)
        Me.Panel3.TabIndex = 3
        '
        'lblSolicitudPedidoStock
        '
        Me.lblSolicitudPedidoStock.AutoSize = True
        Me.lblSolicitudPedidoStock.Font = New System.Drawing.Font("Segoe UI", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSolicitudPedidoStock.Location = New System.Drawing.Point(26, 6)
        Me.lblSolicitudPedidoStock.Name = "lblSolicitudPedidoStock"
        Me.lblSolicitudPedidoStock.Size = New System.Drawing.Size(208, 25)
        Me.lblSolicitudPedidoStock.TabIndex = 0
        Me.lblSolicitudPedidoStock.Text = "Solicitud Pedido Stock"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.lblSolicitudPedidoStock)
        Me.Panel4.Location = New System.Drawing.Point(1, 322)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(253, 37)
        Me.Panel4.TabIndex = 4
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(260, 328)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(220, 20)
        Me.DateTimePicker1.TabIndex = 0
        '
        'MantenedorStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(845, 484)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MantenedorStock"
        Me.Text = " Mantenedor Stock"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnStockVolver As Button
    Friend WithEvents btnStockOnline As Button
    Friend WithEvents btnStockPedido As Button
    Friend WithEvents btnStockModificar As Button
    Friend WithEvents btnStockBuscar As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblStockID As Label
    Friend WithEvents lblStockDescripcion As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmbStockID As ComboBox
    Friend WithEvents txtStockID As TextBox
    Friend WithEvents lblSolicitudPedidoStock As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
