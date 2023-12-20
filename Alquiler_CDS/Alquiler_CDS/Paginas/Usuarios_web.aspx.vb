Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Data
Partial Class Usuarios_web
    Inherits System.Web.UI.Page
    Public ds As DataSet

    Private Sub Usuarios_web_Init(sender As Object, e As EventArgs) Handles Me.Init
        Try
            cnn = New SqlConnection
            cnn.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Inventario.mdf;Integrated Security=True"
            Dim sql As String = "select * from Usuarios"
            Dim da As New SqlDataAdapter(sql, cnn)
            ds = New DataSet
            da.Fill(ds, "Usuarios")
            TextBox1.Text = ds.Tables("Usuarios").Rows(0).Item("id_usuario")
            TextBox2.Text = ds.Tables("Usuarios").Rows(0).Item("Nombre")
            TextBox3.Text = ds.Tables("Usuarios").Rows(0).Item("Apellido")
            TextBox5.Text = ds.Tables("Usuarios").Rows(0).Item("Telefono")
            TextBox6.Text = ds.Tables("Usuarios").Rows(0).Item("Dirección ")

        Catch ex As Exception
            MsgBox("Error de conexión:" + ex.Message, MsgBoxStyle.Information, "Error")
        End Try
    End Sub


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        contUsuarios = 0
        TextBox1.Text = ds.Tables("Usuarios").Rows(contUsuarios).Item("id_usuario")
        TextBox2.Text = ds.Tables("Usuarios").Rows(contUsuarios).Item("Nombre")
        TextBox3.Text = ds.Tables("Usuarios").Rows(contUsuarios).Item("Apellido")
        TextBox5.Text = ds.Tables("Usuarios").Rows(contUsuarios).Item("Telefono")
        TextBox6.Text = ds.Tables("Usuarios").Rows(contUsuarios).Item("Dirección ")
    End Sub

    Protected Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        contUsuarios = ds.Tables("Usuarios").Rows.Count
        contUsuarios = contUsuarios - 1
        TextBox1.Text = ds.Tables("Usuarios").Rows(contUsuarios).Item("id_usuario")
        TextBox2.Text = ds.Tables("Usuarios").Rows(contUsuarios).Item("Nombre")
        TextBox3.Text = ds.Tables("Usuarios").Rows(contUsuarios).Item("Apellido")
        TextBox5.Text = ds.Tables("Usuarios").Rows(contUsuarios).Item("Telefono")
        TextBox6.Text = ds.Tables("Usuarios").Rows(contUsuarios).Item("Dirección ")
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        contUsuarios = contUsuarios - 1
        If contUsuarios < 0 Then
            contUsuarios = contUsuarios + 1
            TextBox1.Text = ds.Tables("Usuarios").Rows(contUsuarios).Item("id_usuario")
            TextBox2.Text = ds.Tables("Usuarios").Rows(contUsuarios).Item("Nombre")
            TextBox3.Text = ds.Tables("Usuarios").Rows(contUsuarios).Item("Apellido")
            TextBox5.Text = ds.Tables("Usuarios").Rows(contUsuarios).Item("Telefono")
            TextBox6.Text = ds.Tables("Usuarios").Rows(contUsuarios).Item("Dirección ")

        Else
            TextBox1.Text = ds.Tables("Usuarios").Rows(contUsuarios).Item("id_usuario")
            TextBox2.Text = ds.Tables("Usuarios").Rows(contUsuarios).Item("Nombre")
            TextBox3.Text = ds.Tables("Usuarios").Rows(contUsuarios).Item("Apellido")
            TextBox5.Text = ds.Tables("Usuarios").Rows(contUsuarios).Item("Telefono")
            TextBox6.Text = ds.Tables("Usuarios").Rows(contUsuarios).Item("Dirección ")
        End If
    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        contUsuarios = contUsuarios + 1
        If contUsuarios >= ds.Tables("Usuarios").Rows.Count Then
            contUsuarios = ds.Tables("Usuarios").Rows.Count
            contUsuarios = contUsuarios - 1
        End If
        TextBox1.Text = ds.Tables("Usuarios").Rows(contUsuarios).Item("id_usuario")
        TextBox2.Text = ds.Tables("Usuarios").Rows(contUsuarios).Item("Nombre")
        TextBox3.Text = ds.Tables("Usuarios").Rows(contUsuarios).Item("Apellido")
        TextBox5.Text = ds.Tables("Usuarios").Rows(contUsuarios).Item("Telefono")
        TextBox6.Text = ds.Tables("Usuarios").Rows(contUsuarios).Item("Dirección ")
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""

        Button5.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        TextBox2.Focus()
        
    End Sub

    Protected Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Call ejecutar("insert into Usuarios (Nombre,Apellido,Dirección ,Telefono) values ('" & TextBox2.Text & "' , '" & TextBox3.Text & "' , '" & TextBox6.Text & "'  , '" & TextBox5.Text & "') ")


        Button5.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        contUsuarios = 0
        Response.Redirect("Usuarios_web.aspx")
    End Sub

    Protected Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Call ejecutar("update Usuarios set Nombre ='" & TextBox2.Text & "'  where id_usuario= " & TextBox1.Text & " ")
        Call ejecutar("update Usuarios set Apellido ='" & TextBox3.Text & "'  where id_usuario= " & TextBox1.Text & " ")
        Call ejecutar("update Usuarios set Dirección  ='" & TextBox6.Text & "'  where id_usuario= " & TextBox1.Text & " ")
        Call ejecutar("update Usuarios set Telefono ='" & TextBox5.Text & "'  where id_usuario= " & TextBox1.Text & " ")
        contUsuarios = 0
        Response.Redirect("Usuarios_web.aspx")
    End Sub

    Protected Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If MsgBox("¿Esta seguro de eliminar este registro ?", MsgBoxStyle.YesNo, "Información") = MsgBoxResult.Yes Then
            Call ejecutar("delete from Usuarios where id_usuario=" & TextBox1.Text & " ")
            contUsuarios = 0
            Response.Redirect("Usuarios_web.aspx")
        Else
            Exit Sub
        End If

    End Sub
End Class