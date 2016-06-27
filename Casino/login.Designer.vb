<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btniniciarsesion = New System.Windows.Forms.Button()
        Me.txtingresesupassword = New System.Windows.Forms.TextBox()
        Me.txtingresesuusuario = New System.Windows.Forms.TextBox()
        Me.lbliniciarsesion = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btniniciarsesion)
        Me.Panel1.Controls.Add(Me.txtingresesupassword)
        Me.Panel1.Controls.Add(Me.txtingresesuusuario)
        Me.Panel1.Location = New System.Drawing.Point(12, 109)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(356, 217)
        Me.Panel1.TabIndex = 0
        Me.Panel1.Visible = False
        '
        'btniniciarsesion
        '
        Me.btniniciarsesion.BackColor = System.Drawing.Color.Black
        Me.btniniciarsesion.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.btniniciarsesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btniniciarsesion.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btniniciarsesion.Location = New System.Drawing.Point(16, 149)
        Me.btniniciarsesion.Name = "btniniciarsesion"
        Me.btniniciarsesion.Size = New System.Drawing.Size(327, 37)
        Me.btniniciarsesion.TabIndex = 7
        Me.btniniciarsesion.Text = "Iniciar sesion"
        Me.btniniciarsesion.UseVisualStyleBackColor = False
        '
        'txtingresesupassword
        '
        Me.txtingresesupassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtingresesupassword.Location = New System.Drawing.Point(16, 83)
        Me.txtingresesupassword.Name = "txtingresesupassword"
        Me.txtingresesupassword.Size = New System.Drawing.Size(327, 26)
        Me.txtingresesupassword.TabIndex = 6
        Me.txtingresesupassword.Text = "Ingrese Su Password"
        '
        'txtingresesuusuario
        '
        Me.txtingresesuusuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtingresesuusuario.Location = New System.Drawing.Point(16, 12)
        Me.txtingresesuusuario.Name = "txtingresesuusuario"
        Me.txtingresesuusuario.Size = New System.Drawing.Size(327, 26)
        Me.txtingresesuusuario.TabIndex = 5
        Me.txtingresesuusuario.Text = "Ingrese  Su Usuario"
        '
        'lbliniciarsesion
        '
        Me.lbliniciarsesion.AutoSize = True
        Me.lbliniciarsesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbliniciarsesion.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbliniciarsesion.Location = New System.Drawing.Point(164, 41)
        Me.lbliniciarsesion.Name = "lbliniciarsesion"
        Me.lbliniciarsesion.Size = New System.Drawing.Size(191, 33)
        Me.lbliniciarsesion.TabIndex = 1
        Me.lbliniciarsesion.Text = "Iniciar Sesion"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(316, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(27, 26)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Location = New System.Drawing.Point(316, 83)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(27, 26)
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.Location = New System.Drawing.Point(75, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(83, 78)
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(385, 350)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.lbliniciarsesion)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "login"
        Me.Text = "login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btniniciarsesion As Button
    Friend WithEvents txtingresesupassword As TextBox
    Friend WithEvents txtingresesuusuario As TextBox
    Friend WithEvents lbliniciarsesion As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
