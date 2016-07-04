Public Class MenuPrincipal
    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If TextBox1.Text = "3" Then
            mantenedores.Enabled = False
            reportes.Enabled = True
            operaciones.Enabled = False

        ElseIf TextBox1.Text = "2" Then
            mantenedores.Enabled = False
            reportes.Enabled = False
            operaciones.Enabled = True

        ElseIf TextBox1.Text = "1" Then
            mantenedores.Enabled = True
            reportes.Enabled = True
            operaciones.Enabled = True
        End If

    End Sub

    Private Sub LoginCasinoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginCasinoToolStripMenuItem.Click
        Ventas.ShowDialog()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub
End Class