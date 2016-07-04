
Imports System.Data
Imports System.Data.SqlClient
Public Class login
    Dim conexion As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=BD_CASINO2;Integrated Security=True")
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub
    Private Sub btniniciar_Click(sender As Object, e As EventArgs) Handles btniniciar.Click

        Try
            'Preguntamos si la conexion esta abierta, si lo esta la abrimo         
            If Not conexion.State = ConnectionState.Open Then
                'abrimos la conexion                
                conexion.Open()
            End If
            'hacemos una nueva consulta donde comparamos los campo de la tabla
            Dim da As New SqlDataAdapter("select * from USUARIO where nombre='" & txtusuario.Text & "' and password='" & txtpass.Text & "'", conexion)
            'creamos una variable del tipo tabla de datos
            Dim dt As New DataTable
            ' llenamos la tabla con los datos de la consulta
            da.Fill(dt)
            ' preguntamos si la cantidad de filas de la tabla es diferente de 0
            ' si es asi es porque ma misma tiene datos

            If dt.Rows.Count <> 0 Then
                ' llAMAMO NUESTRO MENU PRINCIPAL
                MenuPrincipal.TextBox1.Text = dt.Rows(0).Item("idtipo").ToString
                MenuPrincipal.Show()
                'CERRAMOS EL FORMULARIO
                Me.Close()
            Else

                ' si esta parte se ejecuta es porque el usuario no ha sido registrado o se escribieron datos incorrectos, y enviamos un mensaje informando
                MessageBox.Show("Usuario invalido o su clave es incorrecta", "Error de usuario o clave", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'limpiarmos los controles para que se escriba de nuevo
                txtpass.Clear()
                txtusuario.Clear()
                'enviamos el foco a unos de los controles nuemante
                txtusuario.Focus()
            End If
            'Cerramos al conexion para que no quede abierta
            conexion.Close()
            ' si para un error se ejecuta esta aprte que dice que paso y evita que el programa se explote      
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Err.Source)
        End Try








    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub
End Class