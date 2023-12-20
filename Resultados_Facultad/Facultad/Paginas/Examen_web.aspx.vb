Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Data
Partial Class Examen_web
    Inherits System.Web.UI.Page
    Public ds As DataSet

    Private Sub Examen_web_Init(sender As Object, e As EventArgs) Handles Me.Init
        Try
            cnn = New SqlConnection
            cnn.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Resultados.mdf;Integrated Security=True"
            Dim sql As String = "select * from Examen_Escrito"
            Dim da As New SqlDataAdapter(sql, cnn)
            ds = New DataSet
            da.Fill(ds, "Examen_Escrito")
            TextBox1.Text = ds.Tables("Examen_Escrito").Rows(0).Item("id_examen")
            TextBox2.Text = ds.Tables("Examen_Escrito").Rows(0).Item("Tema")
            Calendar1.SelectedDate = ds.Tables("Examen_Escrito").Rows(0).Item("Fecha_Realizacion")
            Calendar1.VisibleDate = ds.Tables("Examen_Escrito").Rows(0).Item("Fecha_Realizacion")
            TextBox4.Text = ds.Tables("Examen_Escrito").Rows(0).Item("Numero_Preguntas")
            TextBox5.Text = ds.Tables("Examen_Escrito").Rows(0).Item("Nota")
            Call cargarcombo("select * from Estudiante", DropDownList1, "id_estudiante", "Nombre")
            Call cargarcombo("select * from Profesor", DropDownList2, "id_profesor", "Nombre")
            DropDownList1.SelectedValue = ds.Tables("Examen_Escrito").Rows(0).Item("id_estudiante")
            DropDownList2.SelectedValue = ds.Tables("Examen_Escrito").Rows(0).Item("id_profesor")

        Catch ex As Exception
            MsgBox("Error de conexion :" + ex.Message, MsgBoxStyle.Information, "Error")
        End Try
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        contExamen = 0
        TextBox1.Text = ds.Tables("Examen_Escrito").Rows(contExamen).Item("id_examen")
        TextBox2.Text = ds.Tables("Examen_Escrito").Rows(contExamen).Item("Tema")
        Calendar1.SelectedDate = ds.Tables("Examen_Escrito").Rows(contExamen).Item("Fecha_Realizacion")
        Calendar1.VisibleDate = ds.Tables("Examen_Escrito").Rows(contExamen).Item("Fecha_Realizacion")
        TextBox4.Text = ds.Tables("Examen_Escrito").Rows(contExamen).Item("Numero_Preguntas")
        TextBox5.Text = ds.Tables("Examen_Escrito").Rows(contExamen).Item("Nota")
        DropDownList1.SelectedValue = ds.Tables("Examen_Escrito").Rows(contExamen).Item("id_estudiante")
        DropDownList2.SelectedValue = ds.Tables("Examen_Escrito").Rows(contExamen).Item("id_profesor")
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        contExamen = contExamen - 1
        If contExamen < 0 Then
            contExamen = contExamen + 1
            TextBox1.Text = ds.Tables("Examen_Escrito").Rows(contExamen).Item("id_examen")
            TextBox2.Text = ds.Tables("Examen_Escrito").Rows(contExamen).Item("Tema")
            Calendar1.SelectedDate = ds.Tables("Examen_Escrito").Rows(contExamen).Item("Fecha_Realizacion")
            Calendar1.VisibleDate = ds.Tables("Examen_Escrito").Rows(contExamen).Item("Fecha_Realizacion")
            TextBox4.Text = ds.Tables("Examen_Escrito").Rows(contExamen).Item("Numero_Preguntas")
            TextBox5.Text = ds.Tables("Examen_Escrito").Rows(contExamen).Item("Nota")
            DropDownList1.SelectedValue = ds.Tables("Examen_Escrito").Rows(contExamen).Item("id_estudiante")
            DropDownList2.SelectedValue = ds.Tables("Examen_Escrito").Rows(contExamen).Item("id_profesor")
        Else
            TextBox1.Text = ds.Tables("Examen_Escrito").Rows(contExamen).Item("id_examen")
            TextBox2.Text = ds.Tables("Examen_Escrito").Rows(contExamen).Item("Tema")
            Calendar1.SelectedDate = ds.Tables("Examen_Escrito").Rows(contExamen).Item("Fecha_Realizacion")
            Calendar1.VisibleDate = ds.Tables("Examen_Escrito").Rows(contExamen).Item("Fecha_Realizacion")
            TextBox4.Text = ds.Tables("Examen_Escrito").Rows(contExamen).Item("Numero_Preguntas")
            TextBox5.Text = ds.Tables("Examen_Escrito").Rows(contExamen).Item("Nota")
            DropDownList1.SelectedValue = ds.Tables("Examen_Escrito").Rows(contExamen).Item("id_estudiante")
            DropDownList2.SelectedValue = ds.Tables("Examen_Escrito").Rows(contExamen).Item("id_profesor")
        End If

    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        contExamen = contExamen + 1
        If contExamen >= ds.Tables("Examen_Escrito").Rows.Count Then
            contExamen = ds.Tables("Examen_Escrito").Rows.Count
            contExamen = contExamen - 1
        End If
        TextBox1.Text = ds.Tables("Examen_Escrito").Rows(contExamen).Item("id_examen")
        TextBox2.Text = ds.Tables("Examen_Escrito").Rows(contExamen).Item("Tema")
        Calendar1.SelectedDate = ds.Tables("Examen_Escrito").Rows(contExamen).Item("Fecha_Realizacion")
        Calendar1.VisibleDate = ds.Tables("Examen_Escrito").Rows(contExamen).Item("Fecha_Realizacion")
        TextBox4.Text = ds.Tables("Examen_Escrito").Rows(contExamen).Item("Numero_Preguntas")
        TextBox5.Text = ds.Tables("Examen_Escrito").Rows(contExamen).Item("Nota")
        DropDownList1.SelectedValue = ds.Tables("Examen_Escrito").Rows(contExamen).Item("id_estudiante")
        DropDownList2.SelectedValue = ds.Tables("Examen_Escrito").Rows(contExamen).Item("id_profesor")
    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        contExamen = ds.Tables("Examen_Escrito").Rows.Count
        contExamen = contExamen - 1
        TextBox1.Text = ds.Tables("Examen_Escrito").Rows(contExamen).Item("id_examen")
        TextBox2.Text = ds.Tables("Examen_Escrito").Rows(contExamen).Item("Tema")
        Calendar1.SelectedDate = ds.Tables("Examen_Escrito").Rows(contExamen).Item("Fecha_Realizacion")
        Calendar1.VisibleDate = ds.Tables("Examen_Escrito").Rows(contExamen).Item("Fecha_Realizacion")
        TextBox4.Text = ds.Tables("Examen_Escrito").Rows(contExamen).Item("Numero_Preguntas")
        TextBox5.Text = ds.Tables("Examen_Escrito").Rows(contExamen).Item("Nota")
        DropDownList1.SelectedValue = ds.Tables("Examen_Escrito").Rows(contExamen).Item("id_estudiante")
        DropDownList2.SelectedValue = ds.Tables("Examen_Escrito").Rows(contExamen).Item("id_profesor")
    End Sub

    Protected Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        
        TextBox4.Text = ""
        TextBox5.Text = ""

        Button4.Enabled = False
        Button8.Enabled = False
        Button7.Enabled = False
        TextBox2.Focus()
    End Sub

    Protected Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Call ejecutar("insert into Examen_Escrito (Tema,Fecha_Realizacion,Numero_Preguntas,Nota,id_estudiante,id_profesor) values ('" & TextBox2.Text & "', '" & Calendar1.SelectedDate & "', '" & TextBox4.Text & "','" & TextBox5.Text & "', " & DropDownList1.SelectedValue & ", " & DropDownList2.SelectedValue & ")")
        Button4.Enabled = True
        Button8.Enabled = True
        Button7.Enabled = True

        contExamen = 0

        Response.Redirect("Examen_web.aspx")
    End Sub

    Protected Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Call ejecutar("update Examen_Escrito set Tema='" & TextBox2.Text & "',id_estudiante=" & DropDownList1.SelectedValue & ", id_profesor=" & DropDownList2.SelectedValue & " where id_examen=" & TextBox1.Text & " ")
        Call ejecutar("update Examen_Escrito set Fecha_Realizacion='" & Calendar1.SelectedDate & "',id_estudiante=" & DropDownList1.SelectedValue & ", id_profesor=" & DropDownList2.SelectedValue & " where id_examen=" & TextBox1.Text & " ")
        Call ejecutar("update Examen_Escrito set Numero_Preguntas='" & TextBox4.Text & "',id_estudiante=" & DropDownList1.SelectedValue & ", id_profesor=" & DropDownList2.SelectedValue & " where id_examen=" & TextBox1.Text & " ")
        Call ejecutar("update Examen_Escrito set Nota='" & TextBox5.Text & "',id_estudiante=" & DropDownList1.SelectedValue & ", id_profesor=" & DropDownList2.SelectedValue & " where id_examen=" & TextBox1.Text & " ")
        contExamen = 0
        Response.Redirect("Examen_web.aspx")
    End Sub

    Protected Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If MsgBox("¿Esta seguro de eliminar este registro ?", MsgBoxStyle.YesNo, "Información") = MsgBoxResult.Yes Then
            Call ejecutar("delete from Examen_Escrito where id_examen=" & TextBox1.Text & " ")
            contExamen = 0
            Response.Redirect("Examen_web.aspx")
        Else
            Exit Sub
        End If
    End Sub

    Protected Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub
End Class