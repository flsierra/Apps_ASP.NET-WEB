Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Data
Partial Class Ciudad_web
    Inherits System.Web.UI.Page
    Public ds As DataSet

    Private Sub Ciudad_web_Init(sender As Object, e As EventArgs) Handles Me.Init
        Try
            cnn = New SqlConnection
            cnn.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Paises.mdf;Integrated Security=True"
            Dim sql As String = "select * from Ciudad"
            Dim da As New SqlDataAdapter(sql, cnn)
            ds = New DataSet
            da.Fill(ds, "Ciudad")
            TextBox1.Text = ds.Tables("Ciudad").Rows(0).Item("id_ciudad")
            TextBox2.Text = ds.Tables("Ciudad").Rows(0).Item("Nombre")
            Call cargarcombo("select * from Depto", DropDownList1, "id_depto", "Nombre")
            DropDownList1.SelectedValue = ds.Tables("Ciudad").Rows(0).Item("id_depto")

        Catch ex As Exception
            MsgBox("Error de conexion :" + ex.Message, MsgBoxStyle.Information, "Error")
        End Try
    End Sub


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        contCiudad = 0
        TextBox1.Text = ds.Tables("Ciudad").Rows(contCiudad).Item("id_ciudad")
        TextBox2.Text = ds.Tables("Ciudad").Rows(contCiudad).Item("Nombre")
        DropDownList1.SelectedValue = ds.Tables("Ciudad").Rows(contCiudad).Item("id_depto")
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        contCiudad = contCiudad - 1
        If contCiudad < 0 Then
            contCiudad = contCiudad + 1
            TextBox1.Text = ds.Tables("Ciudad").Rows(contCiudad).Item("id_ciudad")
            TextBox2.Text = ds.Tables("Ciudad").Rows(contCiudad).Item("Nombre")
            DropDownList1.SelectedValue = ds.Tables("Ciudad").Rows(contCiudad).Item("id_depto")
        Else
            TextBox1.Text = ds.Tables("Ciudad").Rows(contCiudad).Item("id_ciudad")
            TextBox2.Text = ds.Tables("Ciudad").Rows(contCiudad).Item("Nombre")
            DropDownList1.SelectedValue = ds.Tables("Ciudad").Rows(contCiudad).Item("id_depto")
        End If


    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        contCiudad = contCiudad + 1
        If contCiudad >= ds.Tables("Ciudad").Rows.Count Then
            contCiudad = ds.Tables("Ciudad").Rows.Count
            contCiudad = contCiudad - 1
        End If
        TextBox1.Text = ds.Tables("Ciudad").Rows(contCiudad).Item("id_ciudad")
        TextBox2.Text = ds.Tables("Ciudad").Rows(contCiudad).Item("Nombre")
        DropDownList1.SelectedValue = ds.Tables("Ciudad").Rows(contCiudad).Item("id_depto")
    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        contCiudad = ds.Tables("Ciudad").Rows.Count
        contCiudad = contCiudad - 1
        TextBox1.Text = ds.Tables("Ciudad").Rows(contCiudad).Item("id_ciudad")
        TextBox2.Text = ds.Tables("Ciudad").Rows(contCiudad).Item("Nombre")
        DropDownList1.SelectedValue = ds.Tables("Ciudad").Rows(contCiudad).Item("id_depto")
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
        Call ejecutar("insert into Ciudad (Nombre,id_depto) values('" & TextBox2.Text & "'," & DropDownList1.SelectedValue & ")")
        Button5.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        contCiudad = 0
        Response.Redirect("Ciudad_web.aspx")
    End Sub

    Protected Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Call ejecutar("update Ciudad set Nombre='" & TextBox2.Text & "',id_depto=" & DropDownList1.SelectedValue & " where id_ciudad=" & TextBox1.Text & " ")
        contCiudad = 0
        Response.Redirect("Ciudad_web.aspx")
    End Sub

    Protected Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If MsgBox("¿ Esta seguro de eliminar este registro?", MsgBoxStyle.YesNo, "Información") - MsgBoxResult.Yes Then
            Call ejecutar("delete from Ciudad where id_ciudad=" & TextBox1.Text & " ")
            contCiudad = 0
            Response.Redirect("Ciudad_web.aspx")
        Else

        End If

    End Sub
End Class