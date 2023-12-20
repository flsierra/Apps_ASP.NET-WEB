Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Data
Partial Class Historial_web
    Inherits System.Web.UI.Page
    Public ds As DataSet

    Private Sub Historial_web_Init(sender As Object, e As EventArgs) Handles Me.Init
        Try
            cnn = New SqlConnection
            cnn.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Resultados.mdf;Integrated Security=True"
            Dim sql As String = "select * from Historial"
            Dim da As New SqlDataAdapter(sql, cnn)
            ds = New DataSet
            da.Fill(ds, "Historial")
            TextBox1.Text = ds.Tables("Historial").Rows(0).Item("id_Historial")
            Calendar1.SelectedDate = ds.Tables("Historial").Rows(0).Item("Fecha_Realizacion")
            Calendar1.VisibleDate = ds.Tables("Historial").Rows(0).Item("Fecha_Realizacion")
            Calendar2.SelectedDate = ds.Tables("Historial").Rows(0).Item("Fecha_Resultados")
            Calendar2.VisibleDate = ds.Tables("Historial").Rows(0).Item("Fecha_Resultados")
            Call cargarcombo("select * from Estudiante", DropDownList1, "id_estudiante", "Nombre")
            Call cargarcombo("select * from Practica", DropDownList2, "id_practica", "Tema")
            Call cargarcombo("select * from Profesor", DropDownList3, "id_profesor", "Nombre")
            Call cargarcombo("select * from Examen_Escrito", DropDownList4, "id_examen", "Tema")
            DropDownList1.SelectedValue = ds.Tables("Historial").Rows(0).Item("id_estudiante")
            DropDownList2.SelectedValue = ds.Tables("Historial").Rows(0).Item("id_practica")
            DropDownList3.SelectedValue = ds.Tables("Historial").Rows(0).Item("id_profesor")
            DropDownList4.SelectedValue = ds.Tables("Historial").Rows(0).Item("id_examen")

        Catch ex As Exception
            MsgBox("Error de conexion :" + ex.Message, MsgBoxStyle.Information, "Error")
        End Try
    End Sub


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Call ejecutar("insert into Historial (Fecha_Realizacion,Fecha_Resultados,id_estudiante,id_practica,id_profesor,id_examen) values ('" & Calendar1.SelectedDate & "','" & Calendar2.SelectedDate & "', " & DropDownList1.SelectedValue & ", " & DropDownList2.SelectedValue & "," & DropDownList3.SelectedValue & "," & DropDownList4.SelectedValue & ")")
        Button4.Enabled = True
        Button8.Enabled = True
        Button7.Enabled = True

        contHistorial = 0

        Response.Redirect("Historial_web.aspx")
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        contHistorial = 0
        TextBox1.Text = ds.Tables("Historial").Rows(contHistorial).Item("id_examen")
        Calendar1.SelectedDate = ds.Tables("Historial").Rows(contHistorial).Item("Fecha_Realizacion")
        Calendar1.VisibleDate = ds.Tables("Historial").Rows(contHistorial).Item("Fecha_Realizacion")
        Calendar2.SelectedDate = ds.Tables("Historial").Rows(contHistorial).Item("Fecha_Resultados")
        Calendar2.VisibleDate = ds.Tables("Historial").Rows(contHistorial).Item("Fecha_Resultados")
        DropDownList1.SelectedValue = ds.Tables("Historial").Rows(contHistorial).Item("id_estudiante")
        DropDownList2.SelectedValue = ds.Tables("Historial").Rows(contHistorial).Item("id_practica")
        DropDownList3.SelectedValue = ds.Tables("Historial").Rows(contHistorial).Item("id_profesor")
        DropDownList4.SelectedValue = ds.Tables("Historial").Rows(contHistorial).Item("id_examen")
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        contHistorial = contHistorial - 1
        If contHistorial < 0 Then
            contHistorial = contHistorial + 1
            TextBox1.Text = ds.Tables("Historial").Rows(contHistorial).Item("id_examen")
            Calendar1.SelectedDate = ds.Tables("Historial").Rows(contHistorial).Item("Fecha_Realizacion")
            Calendar1.VisibleDate = ds.Tables("Historial").Rows(contHistorial).Item("Fecha_Realizacion")
            Calendar2.SelectedDate = ds.Tables("Historial").Rows(contHistorial).Item("Fecha_Resultados")
            Calendar2.VisibleDate = ds.Tables("Historial").Rows(contHistorial).Item("Fecha_Resultados")
            DropDownList1.SelectedValue = ds.Tables("Historial").Rows(contHistorial).Item("id_estudiante")
            DropDownList2.SelectedValue = ds.Tables("Historial").Rows(contHistorial).Item("id_practica")
            DropDownList3.SelectedValue = ds.Tables("Historial").Rows(contHistorial).Item("id_profesor")
            DropDownList4.SelectedValue = ds.Tables("Historial").Rows(contHistorial).Item("id_examen")
        Else
            TextBox1.Text = ds.Tables("Historial").Rows(contHistorial).Item("id_examen")
            Calendar1.SelectedDate = ds.Tables("Historial").Rows(contHistorial).Item("Fecha_Realizacion")
            Calendar1.VisibleDate = ds.Tables("Historial").Rows(contHistorial).Item("Fecha_Realizacion")
            Calendar2.SelectedDate = ds.Tables("Historial").Rows(contHistorial).Item("Fecha_Resultados")
            Calendar2.VisibleDate = ds.Tables("Historial").Rows(contHistorial).Item("Fecha_Resultados")
            DropDownList1.SelectedValue = ds.Tables("Historial").Rows(contHistorial).Item("id_estudiante")
            DropDownList2.SelectedValue = ds.Tables("Historial").Rows(contHistorial).Item("id_practica")
            DropDownList3.SelectedValue = ds.Tables("Historial").Rows(contHistorial).Item("id_profesor")
            DropDownList4.SelectedValue = ds.Tables("Historial").Rows(contHistorial).Item("id_examen")
        End If

    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        contHistorial = contHistorial + 1
        If contHistorial >= ds.Tables("Historial").Rows.Count Then
            contHistorial = ds.Tables("Historial").Rows.Count
            contHistorial = contHistorial - 1
        End If
        TextBox1.Text = ds.Tables("Historial").Rows(contHistorial).Item("id_examen")
        Calendar1.SelectedDate = ds.Tables("Historial").Rows(contHistorial).Item("Fecha_Realizacion")
        Calendar1.VisibleDate = ds.Tables("Historial").Rows(contHistorial).Item("Fecha_Realizacion")
        Calendar2.SelectedDate = ds.Tables("Historial").Rows(contHistorial).Item("Fecha_Resultados")
        Calendar2.VisibleDate = ds.Tables("Historial").Rows(contHistorial).Item("Fecha_Resultados")
        DropDownList1.SelectedValue = ds.Tables("Historial").Rows(contHistorial).Item("id_estudiante")
        DropDownList2.SelectedValue = ds.Tables("Historial").Rows(contHistorial).Item("id_practica")
        DropDownList3.SelectedValue = ds.Tables("Historial").Rows(contHistorial).Item("id_profesor")
        DropDownList4.SelectedValue = ds.Tables("Historial").Rows(contHistorial).Item("id_examen")
    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        contHistorial = ds.Tables("Historial").Rows.Count
        contHistorial = contHistorial - 1
        TextBox1.Text = ds.Tables("Historial").Rows(contHistorial).Item("id_examen")
        Calendar1.SelectedDate = ds.Tables("Historial").Rows(contHistorial).Item("Fecha_Realizacion")
        Calendar1.VisibleDate = ds.Tables("Historial").Rows(contHistorial).Item("Fecha_Realizacion")
        Calendar2.SelectedDate = ds.Tables("Historial").Rows(contHistorial).Item("Fecha_Resultados")
        Calendar2.VisibleDate = ds.Tables("Historial").Rows(contHistorial).Item("Fecha_Resultados")
        DropDownList1.SelectedValue = ds.Tables("Historial").Rows(contHistorial).Item("id_estudiante")
        DropDownList2.SelectedValue = ds.Tables("Historial").Rows(contHistorial).Item("id_practica")
        DropDownList3.SelectedValue = ds.Tables("Historial").Rows(contHistorial).Item("id_profesor")
        DropDownList4.SelectedValue = ds.Tables("Historial").Rows(contHistorial).Item("id_examen")
    End Sub

    Protected Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = ""
        

        Button4.Enabled = False
        Button8.Enabled = False
        Button7.Enabled = False
        TextBox1.Focus()
    End Sub

    Protected Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Call ejecutar("update Historial set Fecha_Realizacion ='" & Calendar1.SelectedDate & "',id_estudiante=" & DropDownList1.SelectedValue & ", id_practica=" & DropDownList2.SelectedValue & ", id_profesor=" & DropDownList3.SelectedValue & ", id_examen=" & DropDownList4.SelectedValue & " where id_Historial=" & TextBox1.Text & " ")
        Call ejecutar("update Historial set Fecha_Resultados ='" & Calendar2.SelectedDate & "',id_estudiante=" & DropDownList1.SelectedValue & ", id_practica=" & DropDownList2.SelectedValue & ", id_profesor=" & DropDownList3.SelectedValue & ", id_examen=" & DropDownList4.SelectedValue & " where id_Historial=" & TextBox1.Text & " ")
        contHistorial = 0
        Response.Redirect("Historial_web.aspx")
    End Sub

    Protected Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If MsgBox("¿Esta seguro de eliminar este registro ?", MsgBoxStyle.YesNo, "Información") = MsgBoxResult.Yes Then
            Call ejecutar("delete from Historial where id_Historial=" & TextBox1.Text & " ")
            contExamen = 0
            Response.Redirect("Historial_web.aspx")
        Else
            Exit Sub
        End If
    End Sub
End Class