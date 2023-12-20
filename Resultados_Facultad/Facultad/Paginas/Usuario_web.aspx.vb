Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Data
Partial Class Usuario_web
    Inherits System.Web.UI.Page
    Public ds As DataSet

    Private Sub Page_Init(sender As Object, e As EventArgs) Handles Me.Init
        Try
            cnn = New SqlConnection
            cnn.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Resultados.mdf;Integrated Security=True"
            Dim sql As String = "select * from Estudiante"
            Dim da As New SqlDataAdapter(sql, cnn)
            ds = New DataSet
            da.Fill(ds, "Estudiante")
            TextBox1.Text = ds.Tables("Estudiante").Rows(0).Item("id_estudiante")
            TextBox2.Text = ds.Tables("Estudiante").Rows(0).Item("Nombre")
            TextBox3.Text = ds.Tables("Estudiante").Rows(0).Item("Apellido")
            TextBox4.Text = ds.Tables("Estudiante").Rows(0).Item("Documento")
            TextBox5.Text = ds.Tables("Estudiante").Rows(0).Item("Numero_Matricula")
            TextBox6.Text = ds.Tables("Estudiante").Rows(0).Item("Grupo")
         
        Catch ex As Exception
            MsgBox("Error de conexion :" + ex.Message, MsgBoxStyle.Information, "Error")
        End Try
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        contUsuario = 0
        TextBox1.Text = ds.Tables("Estudiante").Rows(contUsuario).Item("id_estudiante")
        TextBox2.Text = ds.Tables("Estudiante").Rows(contUsuario).Item("Nombre")
        TextBox3.Text = ds.Tables("Estudiante").Rows(contUsuario).Item("Apellido")
        TextBox4.Text = ds.Tables("Estudiante").Rows(contUsuario).Item("Documento")
        TextBox5.Text = ds.Tables("Estudiante").Rows(contUsuario).Item("Numero_Matricula")
        TextBox6.Text = ds.Tables("Estudiante").Rows(contUsuario).Item("Grupo")

    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        contUsuario = contUsuario - 1
        If contUsuario < 0 Then
            contUsuario = contUsuario + 1
            TextBox1.Text = ds.Tables("Estudiante").Rows(contUsuario).Item("id_estudiante")
            TextBox2.Text = ds.Tables("Estudiante").Rows(contUsuario).Item("Nombre")
            TextBox3.Text = ds.Tables("Estudiante").Rows(contUsuario).Item("Apellido")
            TextBox4.Text = ds.Tables("Estudiante").Rows(contUsuario).Item("Documento")
            TextBox5.Text = ds.Tables("Estudiante").Rows(contUsuario).Item("Numero_Matricula")
            TextBox6.Text = ds.Tables("Estudiante").Rows(contUsuario).Item("Grupo")

        Else
            TextBox1.Text = ds.Tables("Estudiante").Rows(contUsuario).Item("id_estudiante")
            TextBox2.Text = ds.Tables("Estudiante").Rows(contUsuario).Item("Nombre")
            TextBox3.Text = ds.Tables("Estudiante").Rows(contUsuario).Item("Apellido")
            TextBox4.Text = ds.Tables("Estudiante").Rows(contUsuario).Item("Documento")
            TextBox5.Text = ds.Tables("Estudiante").Rows(contUsuario).Item("Numero_Matricula")
            TextBox6.Text = ds.Tables("Estudiante").Rows(contUsuario).Item("Grupo")

        End If

    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        contUsuario = contUsuario + 1
        If contUsuario >= ds.Tables("Estudiante").Rows.Count Then
            contUsuario = ds.Tables("Estudiante").Rows.Count
            contUsuario = contUsuario - 1
        End If
        TextBox1.Text = ds.Tables("Estudiante").Rows(contUsuario).Item("id_estudiante")
        TextBox2.Text = ds.Tables("Estudiante").Rows(contUsuario).Item("Nombre")
        TextBox3.Text = ds.Tables("Estudiante").Rows(contUsuario).Item("Apellido")
        TextBox4.Text = ds.Tables("Estudiante").Rows(contUsuario).Item("Documento")
        TextBox5.Text = ds.Tables("Estudiante").Rows(contUsuario).Item("Numero_Matricula")
        TextBox6.Text = ds.Tables("Estudiante").Rows(contUsuario).Item("Grupo")

    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        contUsuario = ds.Tables("Estudiante").Rows.Count
        contUsuario = contUsuario - 1
        TextBox1.Text = ds.Tables("Estudiante").Rows(contUsuario).Item("id_estudiante")
        TextBox2.Text = ds.Tables("Estudiante").Rows(contUsuario).Item("Nombre")
        TextBox3.Text = ds.Tables("Estudiante").Rows(contUsuario).Item("Apellido")
        TextBox4.Text = ds.Tables("Estudiante").Rows(contUsuario).Item("Documento")
        TextBox5.Text = ds.Tables("Estudiante").Rows(contUsuario).Item("Numero_Matricula")
        TextBox6.Text = ds.Tables("Estudiante").Rows(contUsuario).Item("Grupo")

    End Sub

    Protected Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""

        Button4.Enabled = False
        Button8.Enabled = False
        Button7.Enabled = False
        TextBox2.Focus()
    End Sub

    Protected Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Call ejecutar("insert into Estudiante (Nombre,Apellido,Documento,Numero_Matricula,Grupo) values ('" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "')")
        Button4.Enabled = True
        Button8.Enabled = True
        Button7.Enabled = True

        contUsuario = 0

        Response.Redirect("Usuario_web.aspx")
    End Sub

    Protected Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Call ejecutar("update Estudiante set Nombre='" & TextBox2.Text & "'  where id_estudiante=" & TextBox1.Text & " ")
        Call ejecutar("update Estudiante set Apellido='" & TextBox3.Text & "' where id_estudiante=" & TextBox1.Text & " ")
        Call ejecutar("update Estudiante set Documento='" & TextBox4.Text & "' where id_estudiante=" & TextBox1.Text & " ")
        Call ejecutar("update Estudiante set Numero_Matricula='" & TextBox5.Text & "' where id_estudiante=" & TextBox1.Text & " ")
        Call ejecutar("update Estudiante set Grupo='" & TextBox6.Text & "' where id_estudiante=" & TextBox1.Text & " ")

        contUsuario = 0
        Response.Redirect("Usuario_web.aspx")
    End Sub

    Protected Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If MsgBox("¿Esta seguro de eliminar este registro ?", MsgBoxStyle.YesNo, "Información") = MsgBoxResult.Yes Then
            Call ejecutar("delete from Estudiante where id_estudiante=" & TextBox1.Text & " ")
            contUsuario = 0
            Response.Redirect("Usuario_web.aspx")
        Else
            Exit Sub
        End If
    End Sub

    Protected Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub
End Class