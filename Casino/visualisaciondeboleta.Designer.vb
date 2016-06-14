<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class visualisaciondeboleta
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
        Me.lblpreboleta = New System.Windows.Forms.Label()
        Me.btnconfirmar = New System.Windows.Forms.Button()
        Me.btnvolver = New System.Windows.Forms.Button()
        Me.btnimprimir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(12, 69)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(342, 319)
        Me.Panel1.TabIndex = 0
        '
        'lblpreboleta
        '
        Me.lblpreboleta.AutoSize = True
        Me.lblpreboleta.BackColor = System.Drawing.Color.LightSeaGreen
        Me.lblpreboleta.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpreboleta.Location = New System.Drawing.Point(120, 23)
        Me.lblpreboleta.Name = "lblpreboleta"
        Me.lblpreboleta.Size = New System.Drawing.Size(112, 30)
        Me.lblpreboleta.TabIndex = 1
        Me.lblpreboleta.Text = "Pre Boleta"
        '
        'btnconfirmar
        '
        Me.btnconfirmar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconfirmar.ForeColor = System.Drawing.Color.Black
        Me.btnconfirmar.Location = New System.Drawing.Point(12, 394)
        Me.btnconfirmar.Name = "btnconfirmar"
        Me.btnconfirmar.Size = New System.Drawing.Size(110, 42)
        Me.btnconfirmar.TabIndex = 13
        Me.btnconfirmar.Text = "Confirmar"
        Me.btnconfirmar.UseVisualStyleBackColor = True
        '
        'btnvolver
        '
        Me.btnvolver.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnvolver.ForeColor = System.Drawing.Color.Black
        Me.btnvolver.Location = New System.Drawing.Point(128, 394)
        Me.btnvolver.Name = "btnvolver"
        Me.btnvolver.Size = New System.Drawing.Size(110, 42)
        Me.btnvolver.TabIndex = 14
        Me.btnvolver.Text = "Volver"
        Me.btnvolver.UseVisualStyleBackColor = True
        '
        'btnimprimir
        '
        Me.btnimprimir.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnimprimir.ForeColor = System.Drawing.Color.Black
        Me.btnimprimir.Location = New System.Drawing.Point(244, 394)
        Me.btnimprimir.Name = "btnimprimir"
        Me.btnimprimir.Size = New System.Drawing.Size(110, 42)
        Me.btnimprimir.TabIndex = 15
        Me.btnimprimir.Text = "Imprimir"
        Me.btnimprimir.UseVisualStyleBackColor = True
        '
        'visualisaciondeboleta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(371, 453)
        Me.Controls.Add(Me.btnimprimir)
        Me.Controls.Add(Me.btnvolver)
        Me.Controls.Add(Me.btnconfirmar)
        Me.Controls.Add(Me.lblpreboleta)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "visualisaciondeboleta"
        Me.Text = "visualisaciondeboleta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblpreboleta As Label
    Friend WithEvents btnconfirmar As Button
    Friend WithEvents btnvolver As Button
    Friend WithEvents btnimprimir As Button
End Class
