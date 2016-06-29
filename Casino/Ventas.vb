
Imports System.Data
Imports System.Data.SqlClient
Public Class Ventas


    Dim conexion As New SqlConnection("Data Source=.;Initial Catalog=BD_CASINO2;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim da As New SqlDataAdapter
    Dim dtb As New DataTable
    Dim leer As SqlDataReader
    Dim listadt As New DataTable
    Dim dt As New DataTable

    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        da = New SqlDataAdapter("select * from PRODUCTO", conexion)
        dtb = New DataTable

        da.Fill(dtb)
        cboproducto.DataSource = dtb
        cboproducto.DisplayMember = "des_producto"
        cboproducto.ValueMember = "id_producto"
        cboproducto.SelectedIndex = -1
        conexion.Close()

        dt.Columns.Add("TOTAL")
        dt.Columns.Add("PRODUCTO")
        dt.Columns.Add("CANTIDAD")
        dt.Columns.Add("ID")
        dt.Columns.Add("PRECIO UNITARIO")

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
                dt.Rows.Add(txtsubtotal.Text, leer.Item("des_producto"), txtcantidad.Text, leer.Item("id_producto"), txtprecio.Text)

            End While
            leer.Close()
            conexion.Close()
            Me.DataGridView1.DataSource = dt


            Dim Col = Me.DataGridView1.CurrentCell.ColumnIndex
            For Each row As DataGridViewRow In Me.DataGridView1.Rows
                total += Val(row.Cells(Col).Value)
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
        visualisaciondeboleta.ShowDialog()
    End Sub

    Private Sub txtcantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcantidad.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtdescuento.Enabled = True
            txtdescuento.Focus()
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        MenuPrincipal.Show()
    End Sub
End Class
