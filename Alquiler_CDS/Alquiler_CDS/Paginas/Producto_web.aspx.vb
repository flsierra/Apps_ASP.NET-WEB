Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Data
Partial Class Producto_web
    Inherits System.Web.UI.Page
    Public ds As DataSet

    Private Sub Producto_web_Init(sender As Object, e As EventArgs) Handles Me.Init
        Try
            cnn = New SqlConnection
            cnn.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Inventario.mdf;Integrated Security=True"
            Dim sql As String = "select * from Productos"
            Dim da As New SqlDataAdapter(sql, cnn)
            ds = New DataSet
            da.Fill(ds, "Productos")
            TextBox1.Text = ds.Tables("Productos").Rows(0).Item("id_producto")
            TextBox2.Text = ds.Tables("Productos").Rows(0).Item("Nombre")
            TextBox3.Text = ds.Tables("Productos").Rows(0).Item("Cantidad_disponible")
            Call cargarcombo("select * from Categorias", DropDownList1, "id_categoria", "Descripcion")
            Call cargarcombo("select * from Usuarios", DropDownList2, "id_usuario", "Nombre")
            DropDownList1.SelectedValue = ds.Tables("Productos").Rows(0).Item("id_categoria")
            DropDownList2.SelectedValue = ds.Tables("Productos").Rows(0).Item("id_usuario")
        Catch ex As Exception
            MsgBox("Error de conexion :" + ex.Message, MsgBoxStyle.Information, "Error")
        End Try
    End Sub


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Response.Redirect("Alquiler.aspx")
    End Sub

    Protected Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Call ejecutar("update Productos set Nombre='" & TextBox2.Text & "',id_categoria=" & DropDownList1.SelectedValue & ", id_usuario=" & DropDownList2.SelectedValue & " where id_producto=" & TextBox1.Text & " ")
        Call ejecutar("update Productos set Cantidad_disponible='" & TextBox3.Text & "',id_categoria=" & DropDownList1.SelectedValue & ", id_usuario=" & DropDownList2.SelectedValue & " where id_producto=" & TextBox1.Text & " ")
        contProductos = 0
        Response.Redirect("Producto_web.aspx")
    End Sub

    Protected Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        

        Button5.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False
        TextBox2.Focus()
    End Sub

    Protected Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Call ejecutar("insert into Productos (Nombre,Cantidad_disponible,id_categoria,id_usuario) values ('" & TextBox2.Text & "', '" & TextBox3.Text & "', " & DropDownList1.SelectedValue & ", " & DropDownList2.SelectedValue & ")")
        Button5.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True

        contProductos = 0

        Response.Redirect("Producto_web.aspx")
    End Sub

    Protected Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        contProductos = ds.Tables("Productos").Rows.Count
        contProductos = contProductos - 1
        TextBox1.Text = ds.Tables("Productos").Rows(contProductos).Item("id_producto")
        TextBox2.Text = ds.Tables("Productos").Rows(contProductos).Item("Nombre")
        TextBox3.Text = ds.Tables("Productos").Rows(contProductos).Item("Cantidad_disponible")
        DropDownList1.SelectedValue = ds.Tables("Productos").Rows(contProductos).Item("id_categoria")
        DropDownList2.SelectedValue = ds.Tables("Productos").Rows(contProductos).Item("id_usuario")
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        contProductos = 0
        TextBox1.Text = ds.Tables("Productos").Rows(contProductos).Item("id_producto")
        TextBox2.Text = ds.Tables("Productos").Rows(contProductos).Item("Nombre")
        TextBox3.Text = ds.Tables("Productos").Rows(contProductos).Item("Cantidad_disponible")
        DropDownList1.SelectedValue = ds.Tables("Productos").Rows(contProductos).Item("id_categoria")
        DropDownList2.SelectedValue = ds.Tables("Productos").Rows(contProductos).Item("id_usuario")
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        contProductos = contProductos - 1
        If contProductos < 0 Then
            contProductos = contProductos + 1
            TextBox1.Text = ds.Tables("Productos").Rows(contProductos).Item("id_producto")
            TextBox2.Text = ds.Tables("Productos").Rows(contProductos).Item("Nombre")
            TextBox3.Text = ds.Tables("Productos").Rows(contProductos).Item("Cantidad_disponible")
            DropDownList1.SelectedValue = ds.Tables("Productos").Rows(contProductos).Item("id_categoria")
            DropDownList2.SelectedValue = ds.Tables("Productos").Rows(contProductos).Item("id_usuario")
        Else
            TextBox1.Text = ds.Tables("Productos").Rows(contProductos).Item("id_producto")
            TextBox2.Text = ds.Tables("Productos").Rows(contProductos).Item("Nombre")
            TextBox3.Text = ds.Tables("Productos").Rows(contProductos).Item("Cantidad_disponible")
            DropDownList1.SelectedValue = ds.Tables("Productos").Rows(contProductos).Item("id_categoria")
            DropDownList2.SelectedValue = ds.Tables("Productos").Rows(contProductos).Item("id_usuario")
        End If

    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        contProductos = contProductos + 1
        If contProductos >= ds.Tables("Productos").Rows.Count Then
            contProductos = ds.Tables("Productos").Rows.Count
            contProductos = contProductos - 1
        End If
        TextBox1.Text = ds.Tables("Productos").Rows(contProductos).Item("id_producto")
        TextBox2.Text = ds.Tables("Productos").Rows(contProductos).Item("Nombre")
        TextBox3.Text = ds.Tables("Productos").Rows(contProductos).Item("Cantidad_disponible")
        DropDownList1.SelectedValue = ds.Tables("Productos").Rows(contProductos).Item("id_categoria")
        DropDownList2.SelectedValue = ds.Tables("Productos").Rows(contProductos).Item("id_usuario")
    End Sub
End Class