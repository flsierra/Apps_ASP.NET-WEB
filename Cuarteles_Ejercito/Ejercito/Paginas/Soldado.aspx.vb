Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Data
Partial Class Soldado
    Inherits System.Web.UI.Page
    Public ds As DataSet

    Private Sub Soldado_Init(sender As Object, e As EventArgs) Handles Me.Init
        Try
            cnn = New SqlConnection
            cnn.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Ejercito.mdf;Integrated Security=True"
            Dim sql As String = "select * from Soldado"
            Dim da As New SqlDataAdapter(sql, cnn)
            ds = New DataSet
            da.Fill(ds, "Soldado")
            TextBox1.Text = ds.Tables("Soldado").Rows(0).Item("id_soldado")
            TextBox2.Text = ds.Tables("Soldado").Rows(0).Item("Nombre")
            TextBox3.Text = ds.Tables("Soldado").Rows(0).Item("Apellido")
            Calendar1.SelectedDate = ds.Tables("Soldado").Rows(0).Item("Graduacion")
            Calendar1.VisibleDate = ds.Tables("Soldado").Rows(0).Item("Graduacion")
            Call cargarcombo("select * from Cuerpo_Ejercito", DropDownList1, "id_cuerpo", "Denominación")
            Call cargarcombo("select * from Compañia", DropDownList2, "id_compañia", "Nombre")
            DropDownList1.SelectedValue = ds.Tables("Soldado").Rows(0).Item("id_cuerpo")
            DropDownList2.SelectedValue = ds.Tables("Soldado").Rows(0).Item("id_compañia")
        Catch ex As Exception
            MsgBox("Error de conexion :" + ex.Message, MsgBoxStyle.Information, "Error")
        End Try
    End Sub


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        contSoldado = 0
        TextBox1.Text = ds.Tables("Soldado").Rows(contSoldado).Item("id_soldado")
        TextBox2.Text = ds.Tables("Soldado").Rows(contSoldado).Item("Nombre")
        TextBox3.Text = ds.Tables("Soldado").Rows(contSoldado).Item("Apellido")
        Calendar1.SelectedDate = ds.Tables("Soldado").Rows(contSoldado).Item("Graduacion")
        Calendar1.VisibleDate = ds.Tables("Alquiler").Rows(contSoldado).Item("Graduacion")
        DropDownList1.SelectedValue = ds.Tables("Soldado").Rows(contSoldado).Item("id_cuerpo")
        DropDownList2.SelectedValue = ds.Tables("Soldado").Rows(contSoldado).Item("id_compañia")
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        contSoldado = contSoldado - 1
        If contSoldado < 0 Then
            contSoldado = contSoldado + 1
            TextBox1.Text = ds.Tables("Soldado").Rows(contSoldado).Item("id_soldado")
            TextBox2.Text = ds.Tables("Soldado").Rows(contSoldado).Item("Nombre")
            TextBox3.Text = ds.Tables("Soldado").Rows(contSoldado).Item("Apellido")
            Calendar1.SelectedDate = ds.Tables("Soldado").Rows(contSoldado).Item("Graduacion")
            Calendar1.VisibleDate = ds.Tables("Soldado").Rows(contSoldado).Item("Graduacion")
            DropDownList1.SelectedValue = ds.Tables("Soldado").Rows(contSoldado).Item("id_cuerpo")
            DropDownList2.SelectedValue = ds.Tables("Soldado").Rows(contSoldado).Item("id_compañia")
        Else
            TextBox1.Text = ds.Tables("Soldado").Rows(contSoldado).Item("id_soldado")
            TextBox2.Text = ds.Tables("Soldado").Rows(contSoldado).Item("Nombre")
            TextBox3.Text = ds.Tables("Soldado").Rows(contSoldado).Item("Apellido")
            Calendar1.SelectedDate = ds.Tables("Soldado").Rows(contSoldado).Item("Graduacion")
            Calendar1.VisibleDate = ds.Tables("Soldado").Rows(contSoldado).Item("Graduacion")
            DropDownList1.SelectedValue = ds.Tables("Soldado").Rows(contSoldado).Item("id_cuerpo")
            DropDownList2.SelectedValue = ds.Tables("Soldado").Rows(contSoldado).Item("id_compañia")
        End If

    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        contSoldado = contSoldado + 1
        If contSoldado >= ds.Tables("Soldado").Rows.Count Then
            contSoldado = ds.Tables("Soldado").Rows.Count
            contSoldado = contSoldado - 1
        End If
        TextBox1.Text = ds.Tables("Soldado").Rows(contSoldado).Item("id_soldado")
        TextBox2.Text = ds.Tables("Soldado").Rows(contSoldado).Item("Nombre")
        TextBox3.Text = ds.Tables("Soldado").Rows(contSoldado).Item("Apellido")
        Calendar1.SelectedDate = ds.Tables("Soldado").Rows(contSoldado).Item("Graduacion")
        Calendar1.VisibleDate = ds.Tables("Soldado").Rows(contSoldado).Item("Graduacion")
        DropDownList1.SelectedValue = ds.Tables("Soldado").Rows(contSoldado).Item("id_cuerpo")
        DropDownList2.SelectedValue = ds.Tables("Soldado").Rows(contSoldado).Item("id_compañia")
    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        contSoldado = ds.Tables("Soldado").Rows.Count
        contSoldado = contSoldado - 1
        TextBox1.Text = ds.Tables("Soldado").Rows(contSoldado).Item("id_soldado")
        TextBox2.Text = ds.Tables("Soldado").Rows(contSoldado).Item("Nombre")
        TextBox3.Text = ds.Tables("Soldado").Rows(contSoldado).Item("Apellido")
        Calendar1.SelectedDate = ds.Tables("Soldado").Rows(contSoldado).Item("Graduacion")
        Calendar1.VisibleDate = ds.Tables("Soldado").Rows(contSoldado).Item("Graduacion")
        DropDownList1.SelectedValue = ds.Tables("Soldado").Rows(contSoldado).Item("id_cuerpo")
        DropDownList2.SelectedValue = ds.Tables("Soldado").Rows(contSoldado).Item("id_compañia")
    End Sub

    Protected Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""


        Button4.Enabled = False
        Button8.Enabled = False
        Button7.Enabled = False
        TextBox2.Focus()
    End Sub

    Protected Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Call ejecutar("insert into Soldado (Nombre,Apellido,Graduacion,id_cuerpo,id_compañia) values ('" & TextBox2.Text & "', '" & TextBox3.Text & "','" & Calendar1.SelectedDate & "',  " & DropDownList1.SelectedValue & ", " & DropDownList2.SelectedValue & ")")
        Button4.Enabled = True
        Button8.Enabled = True
        Button7.Enabled = True

        contSoldado = 0

        Response.Redirect("Soldado.aspx")
    End Sub

    Protected Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Call ejecutar("update Soldado set Nombre='" & TextBox2.Text & "',id_cuerpo=" & DropDownList1.SelectedValue & ", id_compañia=" & DropDownList2.SelectedValue & " where id_soldado=" & TextBox1.Text & " ")
        Call ejecutar("update Soldado set Apellido='" & TextBox3.Text & "',id_cuerpo=" & DropDownList1.SelectedValue & ", id_compañia=" & DropDownList2.SelectedValue & " where id_soldado=" & TextBox1.Text & " ")
        Call ejecutar("update Soldado set Graduacion='" & Calendar1.SelectedDate & "',id_cuerpo=" & DropDownList1.SelectedValue & ", id_compañia=" & DropDownList2.SelectedValue & " where id_soldado=" & TextBox1.Text & " ")
        contSoldado = 0
        Response.Redirect("Soldado.aspx")
    End Sub

    Protected Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If MsgBox("¿Esta seguro de eliminar este registro ?", MsgBoxStyle.YesNo, "Información") = MsgBoxResult.Yes Then
            Call ejecutar("delete from Soldado where id_soldado=" & TextBox1.Text & " ")
            contSoldado = 0
            Response.Redirect("Soldado.aspx")
        Else
            Exit Sub
        End If
    End Sub
End Class