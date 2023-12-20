Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Data
Partial Class Categoria_web
    Inherits System.Web.UI.Page
    Public ds As DataSet

    Private Sub Categoria_web_Init(sender As Object, e As EventArgs) Handles Me.Init
        Try
            cnn = New SqlConnection
            cnn.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Inventario.mdf;Integrated Security=True"
            Dim sql As String = "select * from Categorias"
            Dim da As New SqlDataAdapter(sql, cnn)
            ds = New DataSet
            da.Fill(ds, "Categorias")
            TextBox1.Text = ds.Tables("Categorias").Rows(0).Item("id_categoria")
            TextBox2.Text = ds.Tables("Categorias").Rows(0).Item("Descripcion")

        Catch ex As Exception
            MsgBox("Error de Conexión" + ex.Message, MsgBoxStyle.Information, "Error")
        End Try
    End Sub


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        contCategorias = 0
        TextBox1.Text = ds.Tables("Categorias").Rows(contCategorias).Item("id_categoria")
        TextBox2.Text = ds.Tables("Categorias").Rows(contCategorias).Item("Descripcion")
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        contCategorias = contCategorias - 1
        If contCategorias < 0 Then
            contCategorias = contCategorias + 1
            TextBox1.Text = ds.Tables("Categorias").Rows(contCategorias).Item("id_categoria")
            TextBox2.Text = ds.Tables("Categorias").Rows(contCategorias).Item("Descripcion")
        Else
            TextBox1.Text = ds.Tables("Categorias").Rows(contCategorias).Item("id_categoria")
            TextBox2.Text = ds.Tables("Categorias").Rows(contCategorias).Item("Descripcion")
        End If

    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        contCategorias = contCategorias + 1
        If contCategorias >= ds.Tables("Categorias").Rows.Count Then
            contCategorias = ds.Tables("Categorias").Rows.Count
            contCategorias = contCategorias - 1
        End If
        TextBox1.Text = ds.Tables("Categorias").Rows(contCategorias).Item("id_categoria")
        TextBox2.Text = ds.Tables("Categorias").Rows(contCategorias).Item("Descripcion")
    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        contCategorias = ds.Tables("Categorias").Rows.Count
        contCategorias = contCategorias - 1
        TextBox1.Text = ds.Tables("Categorias").Rows(contCategorias).Item("id_categoria")
        TextBox2.Text = ds.Tables("Categorias").Rows(contCategorias).Item("Descripcion")
    End Sub

    Protected Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = ""
        TextBox2.Text = ""

        Button5.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        TextBox2.Focus()
    End Sub

    Protected Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Call ejecutar("insert into Categorias (Descripcion) values ('" & TextBox2.Text & "')")
        Button5.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        contCategorias = 0
        Response.Redirect("Categoria_web.aspx")
    End Sub

    Protected Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Call ejecutar("update Categorias set Descripcion='" & TextBox2.Text & "' where id_categoria=" & TextBox1.Text & " ")
        contCategorias = 0
        Response.Redirect("Categoria_web.aspx")
    End Sub

    Protected Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If MsgBox("¿Esta seguro de eliminar este registro ?", MsgBoxStyle.YesNo, "Información") = MsgBoxResult.Yes Then
            Call ejecutar("delete from Categorias where id_categoria=" & TextBox1.Text & " ")
            contUsuarios = 0
            Response.Redirect("Categoria_web.aspx")
        Else
            Exit Sub
        End If
    End Sub
End Class