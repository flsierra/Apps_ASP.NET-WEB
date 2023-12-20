Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Data
Partial Class Profesor_web
    Inherits System.Web.UI.Page
    Public ds As DataSet

    Private Sub Profesor_web_Init(sender As Object, e As EventArgs) Handles Me.Init
        Try
            cnn = New SqlConnection
            cnn.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Resultados.mdf;Integrated Security=True"
            Dim sql As String = "select * from Profesor"
            Dim da As New SqlDataAdapter(sql, cnn)
            ds = New DataSet
            da.Fill(ds, "Profesor")
            TextBox1.Text = ds.Tables("Profesor").Rows(0).Item("id_profesor")
            TextBox2.Text = ds.Tables("Profesor").Rows(0).Item("Nombre")
            TextBox3.Text = ds.Tables("Profesor").Rows(0).Item("Apellido")
            TextBox4.Text = ds.Tables("Profesor").Rows(0).Item("Documento")
           

        Catch ex As Exception
            MsgBox("Error de conexion :" + ex.Message, MsgBoxStyle.Information, "Error")
        End Try
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        contProfesor = 0
        TextBox1.Text = ds.Tables("Profesor").Rows(contProfesor).Item("id_profesor")
        TextBox2.Text = ds.Tables("Profesor").Rows(contProfesor).Item("Nombre")
        TextBox3.Text = ds.Tables("Profesor").Rows(contProfesor).Item("Apellido")
        TextBox4.Text = ds.Tables("Profesor").Rows(contProfesor).Item("Documento")
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        contProfesor = contProfesor - 1
        If contProfesor < 0 Then
            contProfesor = contProfesor + 1
            TextBox1.Text = ds.Tables("Profesor").Rows(contProfesor).Item("id_profesor")
            TextBox2.Text = ds.Tables("Profesor").Rows(contProfesor).Item("Nombre")
            TextBox3.Text = ds.Tables("Profesor").Rows(contProfesor).Item("Apellido")
            TextBox4.Text = ds.Tables("Profesor").Rows(contProfesor).Item("Documento")
        Else
            TextBox1.Text = ds.Tables("Profesor").Rows(contProfesor).Item("id_profesor")
            TextBox2.Text = ds.Tables("Profesor").Rows(contProfesor).Item("Nombre")
            TextBox3.Text = ds.Tables("Profesor").Rows(contProfesor).Item("Apellido")
            TextBox4.Text = ds.Tables("Profesor").Rows(contProfesor).Item("Documento")
        End If

    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        contProfesor = contProfesor + 1
        If contProfesor >= ds.Tables("Profesor").Rows.Count Then
            contProfesor = ds.Tables("Profesor").Rows.Count
            contProfesor = contProfesor - 1
        End If
        TextBox1.Text = ds.Tables("Profesor").Rows(contProfesor).Item("id_profesor")
        TextBox2.Text = ds.Tables("Profesor").Rows(contProfesor).Item("Nombre")
        TextBox3.Text = ds.Tables("Profesor").Rows(contProfesor).Item("Apellido")
        TextBox4.Text = ds.Tables("Profesor").Rows(contProfesor).Item("Documento")
    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        contProfesor = ds.Tables("Profesor").Rows.Count
        contProfesor = contProfesor - 1
        TextBox1.Text = ds.Tables("Profesor").Rows(contProfesor).Item("id_profesor")
        TextBox2.Text = ds.Tables("Profesor").Rows(contProfesor).Item("Nombre")
        TextBox3.Text = ds.Tables("Profesor").Rows(contProfesor).Item("Apellido")
        TextBox4.Text = ds.Tables("Profesor").Rows(contProfesor).Item("Documento")
    End Sub

    Protected Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""

        Button4.Enabled = False
        Button8.Enabled = False
        Button7.Enabled = False
        TextBox2.Focus()
    End Sub

    Protected Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Call ejecutar("insert into Profesor (Nombre,Apellido,Documento) values ('" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "')")
        Button4.Enabled = True
        Button8.Enabled = True
        Button7.Enabled = True

        contProfesor = 0

        Response.Redirect("Profesor_web.aspx")
    End Sub

    Protected Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Call ejecutar("update Profesor set Nombre='" & TextBox2.Text & "'  where id_profesor=" & TextBox1.Text & " ")
        Call ejecutar("update Profesor set Apellido='" & TextBox3.Text & "' where id_profesor=" & TextBox1.Text & " ")
        Call ejecutar("update Profesor set Documento='" & TextBox4.Text & "' where id_profesor=" & TextBox1.Text & " ")
        contProfesor = 0
        Response.Redirect("Profesor_web.aspx")
    End Sub

    Protected Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If MsgBox("¿Esta seguro de eliminar este registro ?", MsgBoxStyle.YesNo, "Información") = MsgBoxResult.Yes Then
            Call ejecutar("delete from Profesor where id_profesor=" & TextBox1.Text & " ")
            contUsuario = 0
            Response.Redirect("Profesor_web.aspx")
        Else
            Exit Sub
        End If
    End Sub
End Class