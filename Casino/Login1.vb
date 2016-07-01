Public Class Login1


    Private Sub Login1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtusuario.Text = "luis" And txtpass.Text = "1234" Then
            Me.Hide()
            MenuPrincipal.Show()

        Else
            MsgBox(" El Usuario y/o la Clave son Incorrectas ")
            txtusuario.Text = ""
            txtpass.Text = ""
            txtusuario.Focus()
        End If
    End Sub
End Class
