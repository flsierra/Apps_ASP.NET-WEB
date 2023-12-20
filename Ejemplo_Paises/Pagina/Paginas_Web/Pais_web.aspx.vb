Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Data

Partial Class Pais_web
    Inherits System.Web.UI.Page
    Public ds As DataSet


    Private Sub Pais_web_Init(sender As Object, e As EventArgs) Handles Me.Init
        Try
            cnn = New SqlConnection
            cnn.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Paises.mdf;Integrated Security=True"
            Dim sql As String = "select * from Pais"
            Dim da As New SqlDataAdapter(sql, cnn)
            ds = New DataSet
            da.Fill(ds, "Pais")
            TextBox1.Text = ds.Tables("Pais").Rows(0).Item("id_pais")
            TextBox2.Text = ds.Tables("Pais").Rows(0).Item("Nombre")

        Catch ex As Exception
            MsgBox("Error de Conexión" + ex.Message, MsgBoxStyle.Information, "Error")
        End Try
    End Sub


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = ""
        TextBox2.Text = ""

        Button5.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        TextBox2.Focus()
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        contPais = 0
        TextBox1.Text = ds.Tables("Pais").Rows(contPais).Item("id_pais")
        TextBox2.Text = ds.Tables("Pais").Rows(contPais).Item("Nombre")
    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        contPais = ds.Tables("Pais").Rows.Count
        contPais = contPais - 1
        TextBox1.Text = ds.Tables("Pais").Rows(contPais).Item("id_pais")
        TextBox2.Text = ds.Tables("Pais").Rows(contPais).Item("Nombre")
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        contPais = contPais - 1
        If contPais < 0 Then
            contPais = contPais + 1
            TextBox1.Text = ds.Tables("Pais").Rows(contPais).Item("id_pais")
            TextBox2.Text = ds.Tables("Pais").Rows(contPais).Item("Nombre")

        Else
            TextBox1.Text = ds.Tables("Pais").Rows(contPais).Item("id_pais")
            TextBox2.Text = ds.Tables("Pais").Rows(contPais).Item("Nombre")
        End If
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        contPais = contPais + 1
        If contPais >= ds.Tables("Pais").Rows.Count Then
            contPais = ds.Tables("Pais").Rows.Count
            contPais = contPais - 1
        End If
        TextBox1.Text = ds.Tables("Pais").Rows(contPais).Item("id_pais")
        TextBox2.Text = ds.Tables("Pais").Rows(contPais).Item("Nombre")

    End Sub

    Protected Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Call ejecutar("insert into Pais (Nombre) values ('" & TextBox2.Text & "')")
        Button5.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        contPais = 0
        Response.Redirect("Pais_web.aspx")
    End Sub

    Protected Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Call ejecutar("update Pais set Nombre='" & TextBox2.Text & "' where id_pais=" & TextBox1.Text & " ")
        contPais = 0
        Response.Redirect("Pais_web.aspx")
    End Sub

    Protected Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If MsgBox("¿ Esta seguro de eliminar este registro?", MsgBoxStyle.YesNo, "Información") - MsgBoxResult.Yes Then
            Call ejecutar("delete from Pais where id_pais=" & TextBox1.Text & " ")
            contPais = 0
            Response.Redirect("Pais_web.aspx")
        Else

        End If

    End Sub
End Class