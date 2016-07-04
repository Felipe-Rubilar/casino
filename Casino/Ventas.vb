
Imports System.Data
Imports System.Data.SqlClient
Public Class Ventas


    Dim conexion As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=BD_CASINO2;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim da As New SqlDataAdapter
    Dim dtb As New DataTable
    Dim leer As SqlDataReader
    Dim listadt As New DataTable
    Dim dt As New DataTable
    Dim dt2 As New DataTable

    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        TextBox2.Text = Date.Today


        conexion.Open()
        da = New SqlDataAdapter("select * from PRODUCTO", conexion)
        dtb = New DataTable

        da.Fill(dtb)
        cboproducto.DataSource = dtb
        cboproducto.DisplayMember = "des_producto"
        cboproducto.ValueMember = "id_producto"
        cboproducto.SelectedIndex = -1
        conexion.Close()



        dt.Columns.Add("ID")
        dt.Columns.Add("PRODUCTO")
        dt.Columns.Add("PRECIO UNITARIO")
        dt.Columns.Add("CANTIDAD")
        dt.Columns.Add("TOTAL")





        txtdescuento.Enabled = False
        txtdescuento2.Enabled = False
        txtpunitario.Enabled = False
        txtsubtotal.Enabled = False
        btnagregar.Enabled = False
        txtcantidad.Enabled = False
    End Sub

    Private Sub cboproducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboproducto.SelectedIndexChanged
        Try


            conexion.Open()

            Dim cmd As New SqlCommand("select * from PRODUCTO where id_producto =" & cboproducto.SelectedValue, conexion)
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                'Dim row As DataRow = dt.Rows(0)

                txtIDventas.Text = dt.Rows(0).Item("id_producto").ToString
                txtprecio.Text = dt.Rows(0).Item("precio").ToString
                txtstock.Text = dt.Rows(0).Item("stock").ToString
            End If
            conexion.Close()
            txtcantidad.Enabled = True
            txtcantidad.Focus()

        Catch ex As Exception
        End Try
    End Sub



    Private Sub txtdescuento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdescuento.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsSymbol(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        Me.txtdescuento.Text = Trim(Replace(Me.txtdescuento.Text, " ", " "))
        txtdescuento.Select(txtdescuento.Text.Length, 0)

        Dim val1 As Integer = 0
        Dim val2 As Integer = 0
        Dim total As Integer = 0
        Dim val11 As Integer = 0
        Dim val22 As Integer = 0
        Int32.TryParse(txtprecio.Text, val1)
        Int32.TryParse(txtdescuento.Text, val2)
        Int32.TryParse(txtpunitario.Text, val11)
        Int32.TryParse(txtcantidad.Text, val22)

        If Asc(e.KeyChar) = 13 Then
            txtdescuento2.Text = CStr(val1 * val2) / 100
            txtpunitario.Text = CStr(Val(txtprecio.Text)) - CStr(Val(txtdescuento2.Text))
            txtsubtotal.Text = CStr(Val(txtpunitario.Text)) * CStr(Val(txtcantidad.Text))
            txtdescuento2.Enabled = False
            btnagregar.Enabled = True
            btnagregar.Focus()
        End If

    End Sub


    Private Sub txtdescuento2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdescuento2.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsSymbol(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        Dim val11 As Integer = 0
        Dim val22 As Integer = 0
        Dim val1 As Integer = 0
        Dim val2 As Integer = 0
        Int32.TryParse(txtprecio.Text, val1)
        Int32.TryParse(txtdescuento.Text, val2)
        Int32.TryParse(txtpunitario.Text, val11)
        Int32.TryParse(txtcantidad.Text, val22)
        If Asc(e.KeyChar) = 13 Then

            txtpunitario.Text = CStr(Val(txtprecio.Text)) - CStr(Val(txtdescuento2.Text))
            txtsubtotal.Text = CStr(Val(txtpunitario.Text)) * CStr(Val(txtcantidad.Text))
            txtdescuento.Enabled = False
        End If
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click

        Dim total As Integer = 0


        If Val(txtcantidad.Text) < Val(txtstock.Text) Then

            listadt.Rows.Clear()

            conexion.Open()

            Dim cmd As New SqlCommand("select * from PRODUCTO where id_producto= '" & txtIDventas.Text & "'", conexion)
            leer = cmd.ExecuteReader
            While leer.Read
                dt.Rows.Add(leer.Item("id_producto"), leer.Item("des_producto"), txtprecio.Text, txtcantidad.Text, txtsubtotal.Text)

            End While
            leer.Close()
            conexion.Close()
            Me.DataGridView1.DataSource = dt


            Dim Col = Me.DataGridView1.CurrentCell.ColumnIndex
            For Each row As DataGridViewRow In Me.DataGridView1.Rows
                total += Val(row.Cells(4).Value)
            Next
            Me.txttotal.Text = total.ToString
            txtcantidad.Text = ""
            txtdescuento.Text = ""
            txtdescuento2.Text = ""

            txtIDventas.Text = ""
            txtprecio.Text = ""
            txtstock.Text = ""
            txtpunitario.Text = ""
            txtsubtotal.Text = ""
        Else
            MessageBox.Show("El stock del producto es menor a la cantidad solicitada, No puede realizar la venta", "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If

    End Sub

    Private Sub btngenerar_Click(sender As Object, e As EventArgs) Handles btngenerar.Click


        conexion.Open()
        Dim comm As New SqlCommand("Select count(num_factura) from FACTURA", conexion)
        Dim nFact As Integer
        nFact = comm.ExecuteScalar
        nFact = nFact + 1
        TextBox1.Text = (nFact)

        conexion.Close()

        If DataGridView1.Rows.Count = 0 Then
            Return
        End If
        conexion.Open()

        Dim query2 As String = "INSERT INTO FACTURA (fecha, total, id_usuario) VALUES (@item, @id_producto, @cantidad, @subtotal)"
        Dim cmd2 As New SqlCommand(query2, conexion)

        For Each row As DataGridViewRow In DataGridView1.Rows

            cmd2.Parameters.Clear()

            cmd2.Parameters.AddWithValue("@item", Convert.ToString(row.Cells("PRODUCTO").Value))
            cmd2.Parameters.AddWithValue("@id_producto", Convert.ToInt32(row.Cells("ID").Value))
            cmd2.Parameters.AddWithValue("@cantidad", Convert.ToInt32(row.Cells("CANTIDAD").Value))
            cmd2.Parameters.AddWithValue("@subtotal", Convert.ToString(row.Cells("TOTAL").Value))
            cmd2.ExecuteNonQuery()
        Next

        Dim query As String = "INSERT INTO VENTA (item, id_producto, cantidad, subtotal) VALUES (@item, @id_producto, @cantidad, @subtotal)"
        Dim cmd As New SqlCommand(query, conexion)

        For Each row As DataGridViewRow In DataGridView1.Rows

            cmd.Parameters.Clear()

            cmd.Parameters.AddWithValue("@item", Convert.ToString(row.Cells("PRODUCTO").Value))
            cmd.Parameters.AddWithValue("@id_producto", Convert.ToInt32(row.Cells("ID").Value))
            cmd.Parameters.AddWithValue("@cantidad", Convert.ToInt32(row.Cells("CANTIDAD").Value))
            cmd.Parameters.AddWithValue("@subtotal", Convert.ToString(row.Cells("TOTAL").Value))
            cmd.ExecuteNonQuery()
        Next

        conexion.Close()


    End Sub

    Private Sub txtcantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcantidad.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtdescuento.Enabled = True
            txtdescuento.Focus()
        End If
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        MenuPrincipal.Show()
    End Sub

End Class
