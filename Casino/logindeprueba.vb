Imports System.Data
Public Class LogindePrueba
    Private Sub btnaceptarcasino_Click(sender As Object, e As EventArgs) Handles btnaceptarcasino.Click
        If txtusuariocasino.Text = "luis" And txtusuariocasino.Text = "1234" Then
            Ventas.ShowDialog()
        Else
            MsgBox(" El Usuario y/o la Clave son Incorrect@s ")
        End If
    End Sub

    Private Sub pnl1login_Paint(sender As Object, e As PaintEventArgs) Handles pnl1login.Paint

    End Sub
End Class