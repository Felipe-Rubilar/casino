Imports System.Data
Public Class LogindePrueba
    Private Sub btnaceptarcasino_Click(sender As Object, e As EventArgs) Handles btnaceptarcasino.Click
        If txtusuariocasino.Text = "luis" And txtusuariocasino.Text = "1234" Then
            MenuPrincipal.ShowDialog()
        Else
            MsgBox(" El Usuario y/o la Clave son Incorrect@s ")
        End If
    End Sub


End Class

