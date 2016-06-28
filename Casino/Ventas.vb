
Imports System.Data
Imports System.Data.SqlClient
Public Class Ventas


    Dim conexion As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=BD_CASINO2;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim da As New SqlDataAdapter
    Dim dtb As New DataTable

    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        da = New SqlDataAdapter("select * from PRODUCTO", conexion)
        dtb = New DataTable

        da.Fill(dtb)
        cboproducto.DataSource = dtb
        cboproducto.DisplayMember = "des_producto"
        cboproducto.ValueMember = "id_producto"
    End Sub
End Class
