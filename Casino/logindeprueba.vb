Imports System.Data
Public Class LogindePrueba
    Private Sub btnaceptarcasino_Click(sender As Object, e As EventArgs) Handles btnaceptarcasino.Click
        If txtusuariocasino.Text = "luis" And txtclavecasino.Text = "1234" Then
            Me.Hide()
            MenuPrincipal.Show()

        Else
            MsgBox(" El Usuario y/o la Clave son Incorrect@s ")
            txtusuariocasino.Text = ""
            txtclavecasino.Text = ""
            txtusuariocasino.Focus()
        End If
    End Sub

    Private Sub LogindePrueba_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

