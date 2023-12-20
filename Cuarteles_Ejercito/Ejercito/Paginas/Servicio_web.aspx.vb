Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Data
Partial Class Servicio_web
    Inherits System.Web.UI.Page
    Public ds As DataSet

    Private Sub Servicio_web_Init(sender As Object, e As EventArgs) Handles Me.Init
        Try
            cnn = New SqlConnection
            cnn.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Ejercito.mdf;Integrated Security=True"
            Dim sql As String = "select * from Servicio"
            Dim da As New SqlDataAdapter(sql, cnn)
            ds = New DataSet
            da.Fill(ds, "Servicio")
            TextBox1.Text = ds.Tables("Servicio").Rows(0).Item("id_servicio")
            TextBox2.Text = ds.Tables("Servicio").Rows(0).Item("Nombre")
            TextBox3.Text = ds.Tables("Servicio").Rows(0).Item("Duracion")
            Calendar1.SelectedDate = ds.Tables("Servicio").Rows(0).Item("Fecha_inicio")
            Calendar1.VisibleDate = ds.Tables("Servicio").Rows(0).Item("Fecha_inicio")
            Calendar2.SelectedDate = ds.Tables("Servicio").Rows(0).Item("Fecha_fin")
            Calendar2.VisibleDate = ds.Tables("Servicio").Rows(0).Item("Fecha_fin")
            TextBox6.Text = ds.Tables("Servicio").Rows(0).Item("Lugar")
            Call cargarcombo("select * from Soldado", DropDownList1, "id_soldado", "Nombre")
            Call cargarcombo("select * from Cuartel", DropDownList2, "id_cuartel", "Nombre")
            DropDownList1.SelectedValue = ds.Tables("Servicio").Rows(0).Item("id_soldado")
            DropDownList2.SelectedValue = ds.Tables("Servicio").Rows(0).Item("id_cuartel")
        Catch ex As Exception
            MsgBox("Error de conexion :" + ex.Message, MsgBoxStyle.Information, "Error")
        End Try
    End Sub


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        contServicio = 0
        TextBox1.Text = ds.Tables("Servicio").Rows(contServicio).Item("id_servicio")
        TextBox2.Text = ds.Tables("Servicio").Rows(contServicio).Item("Nombre")
        TextBox3.Text = ds.Tables("Servicio").Rows(contServicio).Item("Duracion")
        Calendar1.SelectedDate = ds.Tables("Servicio").Rows(contServicio).Item("Fecha_inicio")
        Calendar1.VisibleDate = ds.Tables("Servicio").Rows(contServicio).Item("Fecha_inicio")
        Calendar2.SelectedDate = ds.Tables("Servicio").Rows(contServicio).Item("Fecha_fin")
        Calendar2.VisibleDate = ds.Tables("Servicio").Rows(contServicio).Item("Fecha_fin")
        TextBox6.Text = ds.Tables("Servicio").Rows(contServicio).Item("Lugar")
        DropDownList1.SelectedValue = ds.Tables("Servicio").Rows(contServicio).Item("id_soldado")
        DropDownList2.SelectedValue = ds.Tables("Servicio").Rows(contServicio).Item("id_cuartel")
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        contServicio = contServicio - 1
        If contServicio < 0 Then
            contServicio = contServicio + 1
            TextBox1.Text = ds.Tables("Servicio").Rows(contServicio).Item("id_servicio")
            TextBox2.Text = ds.Tables("Servicio").Rows(contServicio).Item("Nombre")
            TextBox3.Text = ds.Tables("Servicio").Rows(contServicio).Item("Duracion")
            Calendar1.SelectedDate = ds.Tables("Servicio").Rows(contServicio).Item("Fecha_inicio")
            Calendar1.VisibleDate = ds.Tables("Servicio").Rows(contServicio).Item("Fecha_inicio")
            Calendar2.SelectedDate = ds.Tables("Servicio").Rows(contServicio).Item("Fecha_fin")
            Calendar2.VisibleDate = ds.Tables("Servicio").Rows(contServicio).Item("Fecha_fin")
            TextBox6.Text = ds.Tables("Servicio").Rows(contServicio).Item("Lugar")
            DropDownList1.SelectedValue = ds.Tables("Servicio").Rows(contServicio).Item("id_soldado")
            DropDownList2.SelectedValue = ds.Tables("Servicio").Rows(contServicio).Item("id_cuartel")
        Else
            TextBox1.Text = ds.Tables("Servicio").Rows(contServicio).Item("id_servicio")
            TextBox2.Text = ds.Tables("Servicio").Rows(contServicio).Item("Nombre")
            TextBox3.Text = ds.Tables("Servicio").Rows(contServicio).Item("Duracion")
            Calendar1.SelectedDate = ds.Tables("Servicio").Rows(contServicio).Item("Fecha_inicio")
            Calendar1.VisibleDate = ds.Tables("Servicio").Rows(contServicio).Item("Fecha_inicio")
            Calendar2.SelectedDate = ds.Tables("Servicio").Rows(contServicio).Item("Fecha_fin")
            Calendar2.VisibleDate = ds.Tables("Servicio").Rows(contServicio).Item("Fecha_fin")
            TextBox6.Text = ds.Tables("Servicio").Rows(contServicio).Item("Lugar")
            DropDownList1.SelectedValue = ds.Tables("Servicio").Rows(contServicio).Item("id_soldado")
            DropDownList2.SelectedValue = ds.Tables("Servicio").Rows(contServicio).Item("id_cuartel")
        End If

    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        contServicio = contServicio + 1
        If contServicio >= ds.Tables("Servicio").Rows.Count Then
            contServicio = ds.Tables("Servicio").Rows.Count
            contServicio = contServicio - 1
        End If
        TextBox1.Text = ds.Tables("Servicio").Rows(contServicio).Item("id_servicio")
        TextBox2.Text = ds.Tables("Servicio").Rows(contServicio).Item("Nombre")
        TextBox3.Text = ds.Tables("Servicio").Rows(contServicio).Item("Duracion")
        Calendar1.SelectedDate = ds.Tables("Servicio").Rows(contServicio).Item("Fecha_inicio")
        Calendar1.VisibleDate = ds.Tables("Servicio").Rows(contServicio).Item("Fecha_inicio")
        Calendar2.SelectedDate = ds.Tables("Servicio").Rows(contServicio).Item("Fecha_fin")
        Calendar2.VisibleDate = ds.Tables("Servicio").Rows(contServicio).Item("Fecha_fin")
        TextBox6.Text = ds.Tables("Servicio").Rows(contServicio).Item("Lugar")
        DropDownList1.SelectedValue = ds.Tables("Servicio").Rows(contServicio).Item("id_soldado")
        DropDownList2.SelectedValue = ds.Tables("Servicio").Rows(contServicio).Item("id_cuartel")
    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        contServicio = ds.Tables("Servicio").Rows.Count
        contServicio = contServicio - 1
        TextBox1.Text = ds.Tables("Servicio").Rows(contServicio).Item("id_servicio")
        TextBox2.Text = ds.Tables("Servicio").Rows(contServicio).Item("Nombre")
        TextBox3.Text = ds.Tables("Servicio").Rows(contServicio).Item("Duracion")
        Calendar1.SelectedDate = ds.Tables("Servicio").Rows(contServicio).Item("Fecha_inicio")
        Calendar1.VisibleDate = ds.Tables("Servicio").Rows(contServicio).Item("Fecha_inicio")
        Calendar2.SelectedDate = ds.Tables("Servicio").Rows(contServicio).Item("Fecha_fin")
        Calendar2.VisibleDate = ds.Tables("Servicio").Rows(contServicio).Item("Fecha_fin")
        TextBox6.Text = ds.Tables("Servicio").Rows(contServicio).Item("Lugar")
        DropDownList1.SelectedValue = ds.Tables("Servicio").Rows(contServicio).Item("id_soldado")
        DropDownList2.SelectedValue = ds.Tables("Servicio").Rows(contServicio).Item("id_cuartel")
    End Sub

    Protected Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox6.Text = ""

        Button4.Enabled = False
        Button8.Enabled = False
        Button7.Enabled = False
        TextBox2.Focus()
    End Sub

    Protected Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Call ejecutar("insert into Servicio (Nombre,Duracion,Fecha_inicio,Fecha_fin,Lugar,id_soldado,id_cuartel) values ('" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & Calendar1.SelectedDate & "','" & Calendar2.SelectedDate & "', '" & TextBox6.Text & "', " & DropDownList1.SelectedValue & ", " & DropDownList2.SelectedValue & ")")
        Button4.Enabled = True
        Button8.Enabled = True
        Button7.Enabled = True

        contServicio = 0

        Response.Redirect("Servicio_web.aspx")
    End Sub

    Protected Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Call ejecutar("update Servicio set Nombre='" & TextBox2.Text & "',id_soldado=" & DropDownList1.SelectedValue & ", id_cuartel=" & DropDownList2.SelectedValue & " where id_servicio=" & TextBox1.Text & " ")
        Call ejecutar("update Servicio set Duracion='" & TextBox3.Text & "',id_soldado=" & DropDownList1.SelectedValue & ", id_cuartel=" & DropDownList2.SelectedValue & " where id_servicio=" & TextBox1.Text & " ")
        Call ejecutar("update Servicio set Fecha_inicio='" & Calendar1.SelectedDate & "',id_soldado=" & DropDownList1.SelectedValue & ", id_cuartel=" & DropDownList2.SelectedValue & " where id_servicio=" & TextBox1.Text & " ")
        Call ejecutar("update Servicio set Fecha_fin= ,id_soldado='" & Calendar2.SelectedDate & "', " & DropDownList1.SelectedValue & ", id_cuartel=" & DropDownList2.SelectedValue & " where id_servicio=" & TextBox1.Text & " ")
        Call ejecutar("update Servicio set Lugar='" & TextBox6.Text & "',id_soldado=" & DropDownList1.SelectedValue & ", id_cuartel=" & DropDownList2.SelectedValue & " where id_servicio=" & TextBox1.Text & " ")
        contServicio = 0
        Response.Redirect("Servicio_web.aspx")
    End Sub

    Protected Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If MsgBox("¿Esta seguro de eliminar este registro ?", MsgBoxStyle.YesNo, "Información") = MsgBoxResult.Yes Then
            Call ejecutar("delete from Servicio where id_servicio=" & TextBox1.Text & " ")
            contServicio = 0
            Response.Redirect("Servicio_web.aspx")
        Else
            Exit Sub
        End If
    End Sub
End Class