﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.btngenerar = New System.Windows.Forms.Button()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.lstventa = New System.Windows.Forms.ListBox()
        Me.txtsubtotal = New System.Windows.Forms.TextBox()
        Me.lblsubtotal = New System.Windows.Forms.Label()
        Me.txtdescuento = New System.Windows.Forms.TextBox()
        Me.lbldescuento = New System.Windows.Forms.Label()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.lblprecio = New System.Windows.Forms.Label()
        Me.cboproducto = New System.Windows.Forms.ComboBox()
        Me.lblproducto = New System.Windows.Forms.Label()
        Me.txtIDventas = New System.Windows.Forms.TextBox()
        Me.lblIDventas = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnagregar)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.txtsubtotal)
        Me.Panel1.Controls.Add(Me.lblsubtotal)
        Me.Panel1.Controls.Add(Me.txtdescuento)
        Me.Panel1.Controls.Add(Me.lbldescuento)
        Me.Panel1.Controls.Add(Me.txtprecio)
        Me.Panel1.Controls.Add(Me.lblprecio)
        Me.Panel1.Controls.Add(Me.cboproducto)
        Me.Panel1.Controls.Add(Me.lblproducto)
        Me.Panel1.Controls.Add(Me.txtIDventas)
        Me.Panel1.Controls.Add(Me.lblIDventas)
        Me.Panel1.Location = New System.Drawing.Point(0, 66)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(594, 343)
        Me.Panel1.TabIndex = 0
        '
        'btnagregar
        '
        Me.btnagregar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnagregar.Location = New System.Drawing.Point(21, 282)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(110, 42)
        Me.btnagregar.TabIndex = 11
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.Controls.Add(Me.txttotal)
        Me.Panel2.Controls.Add(Me.lbltotal)
        Me.Panel2.Controls.Add(Me.btngenerar)
        Me.Panel2.Controls.Add(Me.btnmodificar)
        Me.Panel2.Controls.Add(Me.lstventa)
        Me.Panel2.Location = New System.Drawing.Point(278, 11)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(301, 313)
        Me.Panel2.TabIndex = 10
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(130, 212)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(158, 20)
        Me.txttotal.TabIndex = 15
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(23, 209)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(53, 25)
        Me.lbltotal.TabIndex = 14
        Me.lbltotal.Text = "Total"
        '
        'btngenerar
        '
        Me.btngenerar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btngenerar.Location = New System.Drawing.Point(178, 258)
        Me.btngenerar.Name = "btngenerar"
        Me.btngenerar.Size = New System.Drawing.Size(110, 42)
        Me.btngenerar.TabIndex = 13
        Me.btngenerar.Text = "Generar "
        Me.btngenerar.UseVisualStyleBackColor = True
        '
        'btnmodificar
        '
        Me.btnmodificar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodificar.Location = New System.Drawing.Point(23, 258)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(110, 42)
        Me.btnmodificar.TabIndex = 12
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = True
        '
        'lstventa
        '
        Me.lstventa.FormattingEnabled = True
        Me.lstventa.Location = New System.Drawing.Point(3, 7)
        Me.lstventa.Name = "lstventa"
        Me.lstventa.Size = New System.Drawing.Size(295, 199)
        Me.lstventa.TabIndex = 0
        '
        'txtsubtotal
        '
        Me.txtsubtotal.Location = New System.Drawing.Point(112, 157)
        Me.txtsubtotal.Name = "txtsubtotal"
        Me.txtsubtotal.Size = New System.Drawing.Size(100, 20)
        Me.txtsubtotal.TabIndex = 9
        '
        'lblsubtotal
        '
        Me.lblsubtotal.AutoSize = True
        Me.lblsubtotal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsubtotal.Location = New System.Drawing.Point(25, 157)
        Me.lblsubtotal.Name = "lblsubtotal"
        Me.lblsubtotal.Size = New System.Drawing.Size(75, 21)
        Me.lblsubtotal.TabIndex = 8
        Me.lblsubtotal.Text = "Sub Total"
        '
        'txtdescuento
        '
        Me.txtdescuento.Location = New System.Drawing.Point(112, 123)
        Me.txtdescuento.Name = "txtdescuento"
        Me.txtdescuento.Size = New System.Drawing.Size(100, 20)
        Me.txtdescuento.TabIndex = 7
        '
        'lbldescuento
        '
        Me.lbldescuento.AutoSize = True
        Me.lbldescuento.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldescuento.Location = New System.Drawing.Point(21, 123)
        Me.lbldescuento.Name = "lbldescuento"
        Me.lbldescuento.Size = New System.Drawing.Size(82, 21)
        Me.lbldescuento.TabIndex = 6
        Me.lbldescuento.Text = "Descuento"
        '
        'txtprecio
        '
        Me.txtprecio.Location = New System.Drawing.Point(112, 90)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.ReadOnly = True
        Me.txtprecio.Size = New System.Drawing.Size(100, 20)
        Me.txtprecio.TabIndex = 5
        '
        'lblprecio
        '
        Me.lblprecio.AutoSize = True
        Me.lblprecio.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprecio.Location = New System.Drawing.Point(21, 90)
        Me.lblprecio.Name = "lblprecio"
        Me.lblprecio.Size = New System.Drawing.Size(53, 21)
        Me.lblprecio.TabIndex = 4
        Me.lblprecio.Text = "Precio"
        '
        'cboproducto
        '
        Me.cboproducto.FormattingEnabled = True
        Me.cboproducto.Location = New System.Drawing.Point(112, 55)
        Me.cboproducto.Name = "cboproducto"
        Me.cboproducto.Size = New System.Drawing.Size(121, 21)
        Me.cboproducto.TabIndex = 3
        '
        'lblproducto
        '
        Me.lblproducto.AutoSize = True
        Me.lblproducto.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblproducto.Location = New System.Drawing.Point(17, 56)
        Me.lblproducto.Name = "lblproducto"
        Me.lblproducto.Size = New System.Drawing.Size(73, 21)
        Me.lblproducto.TabIndex = 2
        Me.lblproducto.Text = "Producto"
        '
        'txtIDventas
        '
        Me.txtIDventas.Location = New System.Drawing.Point(112, 18)
        Me.txtIDventas.Name = "txtIDventas"
        Me.txtIDventas.ReadOnly = True
        Me.txtIDventas.Size = New System.Drawing.Size(100, 20)
        Me.txtIDventas.TabIndex = 1
        '
        'lblIDventas
        '
        Me.lblIDventas.AutoSize = True
        Me.lblIDventas.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDventas.Location = New System.Drawing.Point(13, 18)
        Me.lblIDventas.Name = "lblIDventas"
        Me.lblIDventas.Size = New System.Drawing.Size(76, 21)
        Me.lblIDventas.TabIndex = 0
        Me.lblIDventas.Text = "ID Ventas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(236, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 45)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ventas"
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(591, 453)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Ventas"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblIDventas As Label
    Friend WithEvents txtIDventas As TextBox
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents lblprecio As Label
    Friend WithEvents cboproducto As ComboBox
    Friend WithEvents lblproducto As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtsubtotal As TextBox
    Friend WithEvents lblsubtotal As Label
    Friend WithEvents txtdescuento As TextBox
    Friend WithEvents lbldescuento As Label
    Friend WithEvents btnagregar As Button
    Friend WithEvents txttotal As TextBox
    Friend WithEvents lbltotal As Label
    Friend WithEvents btngenerar As Button
    Friend WithEvents btnmodificar As Button
    Friend WithEvents lstventa As ListBox
End Class
