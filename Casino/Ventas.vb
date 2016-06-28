
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

        dt.Columns.Add("ID")
        dt.Columns.Add("PRODUCTO")
        dt.Columns.Add("PRECIO")




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
            txtdescuento.Focus()

        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtdescuento_TextChanged(sender As Object, e As EventArgs) Handles txtdescuento.TextChanged

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
        Int32.TryParse(txtprecio.Text, val1)
        Int32.TryParse(txtdescuento.Text, val2)

        If Asc(e.KeyChar) = 13 Then
            txtdescuento2.Text = CStr(val1 * val2) / 100
            txtsubtotal.Text = CStr(Val(txtprecio.Text)) - CStr(Val(txtdescuento2.Text))
            btnagregar.Focus()
            txtdescuento2.Enabled = False

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
        Dim val1 As Integer = 0
        Dim val2 As Integer = 0
        Int32.TryParse(txtprecio.Text, val1)
        Int32.TryParse(txtdescuento.Text, val2)

        If Asc(e.KeyChar) = 13 Then

            txtsubtotal.Text = CStr(Val(txtprecio.Text)) - CStr(Val(txtdescuento2.Text))
            btnagregar.Focus()
            txtdescuento.Enabled = False
        End If
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click

        Dim total As Integer = 0




        listadt.Rows.Clear()

        conexion.Open()

        Dim cmd As New SqlCommand("select * from PRODUCTO where id_producto= '" & txtIDventas.Text & "'", conexion)
        leer = cmd.ExecuteReader
        While leer.Read
            dt.Rows.Add(leer.Item("id_producto"), leer.Item("des_producto"), txtsubtotal.Text)

        End While
        leer.Close()
        conexion.Close()
        Me.DataGridView1.DataSource = dt


        Dim Col = Me.DataGridView1.CurrentCell.ColumnIndex
        For Each row As DataGridViewRow In Me.DataGridView1.Rows
            total += Val(row.Cells(Col).Value)
        Next
        Me.txttotal.Text = total.ToString

    End Sub



End Class
