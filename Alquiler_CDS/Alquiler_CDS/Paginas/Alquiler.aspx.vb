Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Data
Partial Class Alquiler
    Inherits System.Web.UI.Page
    Public ds As DataSet
    Public TextBoxs1__AL



    Private Sub Alquiler_Init(sender As Object, e As EventArgs) Handles Me.Init
        Try
            cnn = New SqlConnection
            cnn.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Inventario.mdf;Integrated Security=True"
            Dim sql As String = "select * from Alquiler"
            Dim da As New SqlDataAdapter(sql, cnn)
            ds = New DataSet
            da.Fill(ds, "Alquiler")
            TextBox1_AL.Text = ds.Tables("Alquiler").Rows(0).Item("id_alquiler")
            Calendar1.SelectedDate = ds.Tables("Alquiler").Rows(0).Item("Fecha_alquiler")
            Calendar1.VisibleDate = ds.Tables("Alquiler").Rows(0).Item("Fecha_alquiler")
            Calendar2.SelectedDate = ds.Tables("Alquiler").Rows(0).Item("Fecha_devolucion")
            Calendar2.VisibleDate = ds.Tables("Alquiler").Rows(0).Item("Fecha_devolucion")
            TextBox4__AL.Text = ds.Tables("Alquiler").Rows(0).Item("Observaciones")
            Call cargarcombo("select * from Usuarios", DropDownList1, "id_usuario", "Nombre")
            Call cargarcombo("select * from Productos", DropDownList2, "id_producto", "Nombre")
            Call cargarcombo("select * from Categorias", DropDownList3, "id_categoria", "Descripcion")
            DropDownList1.SelectedValue = ds.Tables("Alquiler").Rows(0).Item("id_usuario")
            DropDownList2.SelectedValue = ds.Tables("Alquiler").Rows(0).Item("id_producto")
            DropDownList3.SelectedValue = ds.Tables("Alquiler").Rows(0).Item("id_categoria")
        Catch ex As Exception
            MsgBox("Error de conexion :" + ex.Message, MsgBoxStyle.Information, "Error")
        End Try
    End Sub


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        contAlquiler = 0
        TextBox1_AL.Text = ds.Tables("Alquiler").Rows(contAlquiler).Item("id_alquiler")
        Calendar1.SelectedDate = ds.Tables("Alquiler").Rows(contAlquiler).Item("Fecha_alquiler")
        Calendar1.VisibleDate = ds.Tables("Alquiler").Rows(contAlquiler).Item("Fecha_alquiler")
        Calendar2.SelectedDate = ds.Tables("Alquiler").Rows(contAlquiler).Item("Fecha_devolucion")
        Calendar2.VisibleDate = ds.Tables("Alquiler").Rows(contAlquiler).Item("Fecha_devolucion")
        TextBox4__AL.Text = ds.Tables("Alquiler").Rows(contAlquiler).Item("Observaciones")
        DropDownList1.SelectedValue = ds.Tables("Alquiler").Rows(contAlquiler).Item("id_usuario")
        DropDownList2.SelectedValue = ds.Tables("Alquiler").Rows(contAlquiler).Item("id_producto")
        DropDownList3.SelectedValue = ds.Tables("Alquiler").Rows(contAlquiler).Item("id_categoria")
    End Sub

    Protected Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        contAlquiler = ds.Tables("Alquiler").Rows.Count
        contAlquiler = contAlquiler - 1
        TextBox1_AL.Text = ds.Tables("Alquiler").Rows(contAlquiler).Item("id_alquiler")
        Calendar1.SelectedDate = ds.Tables("Alquiler").Rows(contAlquiler).Item("Fecha_alquiler")
        Calendar1.VisibleDate = ds.Tables("Alquiler").Rows(contAlquiler).Item("Fecha_alquiler")
        Calendar2.SelectedDate = ds.Tables("Alquiler").Rows(contAlquiler).Item("Fecha_devolucion")
        Calendar2.VisibleDate = ds.Tables("Alquiler").Rows(contAlquiler).Item("Fecha_devolucion")
        TextBox4__AL.Text = ds.Tables("Alquiler").Rows(contAlquiler).Item("Observaciones")
        DropDownList1.SelectedValue = ds.Tables("Alquiler").Rows(contAlquiler).Item("id_usuario")
        DropDownList2.SelectedValue = ds.Tables("Alquiler").Rows(contAlquiler).Item("id_producto")
        DropDownList3.SelectedValue = ds.Tables("Alquiler").Rows(contAlquiler).Item("id_categoria")
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        contAlquiler = contAlquiler - 1
        If contAlquiler < 0 Then
            contAlquiler = contAlquiler + 1
            TextBox1_AL.Text = ds.Tables("Alquiler").Rows(contAlquiler).Item("id_alquiler")
            Calendar1.SelectedDate = ds.Tables("Alquiler").Rows(contAlquiler).Item("Fecha_alquiler")
            Calendar1.VisibleDate = ds.Tables("Alquiler").Rows(contAlquiler).Item("Fecha_alquiler")
            Calendar2.SelectedDate = ds.Tables("Alquiler").Rows(contAlquiler).Item("Fecha_devolucion")
            Calendar2.VisibleDate = ds.Tables("Alquiler").Rows(contAlquiler).Item("Fecha_devolucion")
            TextBox4__AL.Text = ds.Tables("Alquiler").Rows(contAlquiler).Item("Observaciones")
            DropDownList1.SelectedValue = ds.Tables("Alquiler").Rows(contAlquiler).Item("id_usuario")
            DropDownList2.SelectedValue = ds.Tables("Alquiler").Rows(contAlquiler).Item("id_producto")
            DropDownList3.SelectedValue = ds.Tables("Alquiler").Rows(contAlquiler).Item("id_categoria")
        Else
            TextBox1_AL.Text = ds.Tables("Alquiler").Rows(contAlquiler).Item("id_alquiler")
            Calendar1.SelectedDate = ds.Tables("Alquiler").Rows(contAlquiler).Item("Fecha_alquiler")
            Calendar1.VisibleDate = ds.Tables("Alquiler").Rows(contAlquiler).Item("Fecha_alquiler")
            Calendar2.SelectedDate = ds.Tables("Alquiler").Rows(contAlquiler).Item("Fecha_devolucion")
            Calendar2.VisibleDate = ds.Tables("Alquiler").Rows(contAlquiler).Item("Fecha_devolucion")
            TextBox4__AL.Text = ds.Tables("Alquiler").Rows(contAlquiler).Item("Observaciones")
            DropDownList1.SelectedValue = ds.Tables("Alquiler").Rows(contAlquiler).Item("id_usuario")
            DropDownList2.SelectedValue = ds.Tables("Alquiler").Rows(contAlquiler).Item("id_producto")
            DropDownList3.SelectedValue = ds.Tables("Alquiler").Rows(contAlquiler).Item("id_categoria")
        End If
    End Sub

    Protected Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        contAlquiler = contAlquiler + 1
        If contAlquiler >= ds.Tables("Alquiler").Rows.Count Then
            contAlquiler = ds.Tables("Alquiler").Rows.Count
            contAlquiler = contAlquiler - 1
        End If
        TextBox1_AL.Text = ds.Tables("Alquiler").Rows(contAlquiler).Item("id_alquiler")
        Calendar1.SelectedDate = ds.Tables("Alquiler").Rows(contAlquiler).Item("Fecha_alquiler")
        Calendar1.VisibleDate = ds.Tables("Alquiler").Rows(contAlquiler).Item("Fecha_alquiler")
        Calendar2.SelectedDate = ds.Tables("Alquiler").Rows(contAlquiler).Item("Fecha_devolucion")
        Calendar2.VisibleDate = ds.Tables("Alquiler").Rows(contAlquiler).Item("Fecha_devolucion")
        TextBox4__AL.Text = ds.Tables("Alquiler").Rows(contAlquiler).Item("Observaciones")
        DropDownList1.SelectedValue = ds.Tables("Alquiler").Rows(contAlquiler).Item("id_usuario")
        DropDownList2.SelectedValue = ds.Tables("Alquiler").Rows(contAlquiler).Item("id_producto")
        DropDownList3.SelectedValue = ds.Tables("Alquiler").Rows(contAlquiler).Item("id_categoria")
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2_AL.Click
        TextBox1_AL.Text = ""
       
        TextBox4__AL.Text = ""
        Button5.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False

    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call ejecutar("insert into Alquiler (Fecha_alquiler,Fecha_devolucion,Observaciones,id_usuario,id_producto,id_categoria) values( '" & Calendar1.SelectedDate & "','" & Calendar2.SelectedDate & "','" & TextBox4__AL.Text & "'," & DropDownList1.SelectedValue & "," & DropDownList2.SelectedValue & "," & DropDownList3.SelectedValue & ")")
        Button5.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        contAlquiler = 0
        Response.Redirect("Alquiler.aspx")
    End Sub

    Protected Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If MsgBox("¿Esta seguro de eliminar este registro ?", MsgBoxStyle.YesNo, "Información") = MsgBoxResult.Yes Then
            Call ejecutar("delete from Alquiler where id_alquiler=" & TextBox1_AL.Text & " ")
            contAlquiler = 0
            Response.Redirect("Alquiler.aspx")
        Else
            Exit Sub
        End If
    End Sub

    Protected Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Call ejecutar("update Alquiler set Fecha_alquiler='" & Calendar1.SelectedDate & "', id_usuario=" & DropDownList1.SelectedValue & ", id_producto=" & DropDownList2.SelectedValue & ", id_categoria=" & DropDownList3.SelectedValue & " where id_alquiler=" & TextBox1_AL.Text & " ")
        Call ejecutar("update Alquiler set Fecha_devolucion='" & Calendar2.SelectedDate & "', id_usuario=" & DropDownList1.SelectedValue & ", id_producto=" & DropDownList2.SelectedValue & ", id_categoria=" & DropDownList3.SelectedValue & " where id_alquiler=" & TextBox1_AL.Text & " ")
        Call ejecutar("update Alquiler set Observaciones='" & TextBox4__AL.Text & "', id_usuario=" & DropDownList1.SelectedValue & ", id_producto=" & DropDownList2.SelectedValue & ", id_categoria=" & DropDownList3.SelectedValue & " where id_alquiler=" & TextBox1_AL.Text & " ")


        contAlquiler = 0
        Response.Redirect("Alquiler.aspx")
    End Sub

    

    Protected Sub Calendar1_SelectionChanged(sender As Object, e As EventArgs) Handles Calendar1.SelectionChanged

    End Sub
End Class