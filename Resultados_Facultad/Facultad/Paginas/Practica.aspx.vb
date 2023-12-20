Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Data
Partial Class Practica
    Inherits System.Web.UI.Page
    Public ds As DataSet

    Private Sub Practica_Init(sender As Object, e As EventArgs) Handles Me.Init
        Try
            cnn = New SqlConnection
            cnn.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Resultados.mdf;Integrated Security=True"
            Dim sql As String = "select * from Practica"
            Dim da As New SqlDataAdapter(sql, cnn)
            ds = New DataSet
            da.Fill(ds, "Practica")
            TextBox1.Text = ds.Tables("Practica").Rows(0).Item("id_practica")
            TextBox2.Text = ds.Tables("Practica").Rows(0).Item("Tema")
            TextBox3.Text = ds.Tables("Practica").Rows(0).Item("Nota")
            TextBox4.Text = ds.Tables("Practica").Rows(0).Item("Dificultad")
            Calendar1.SelectedDate = ds.Tables("Practica").Rows(0).Item("Fecha_Realizacion")
            Calendar1.VisibleDate = ds.Tables("Practica").Rows(0).Item("Fecha_Realizacion")
        Catch ex As Exception
            MsgBox("Error de conexion :" + ex.Message, MsgBoxStyle.Information, "Error")
        End Try
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        contPractica = 0
        TextBox1.Text = ds.Tables("Practica").Rows(contPractica).Item("id_practica")
        TextBox2.Text = ds.Tables("Practica").Rows(contPractica).Item("Tema")
        TextBox3.Text = ds.Tables("Practica").Rows(contPractica).Item("Nota")
        TextBox4.Text = ds.Tables("Practica").Rows(contPractica).Item("Dificultad")
        Calendar1.SelectedDate = ds.Tables("Practica").Rows(contPractica).Item("Fecha_Realizacion")
        Calendar1.VisibleDate = ds.Tables("Practica").Rows(contPractica).Item("Fecha_Realizacion")
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        contPractica = contPractica - 1
        If contPractica < 0 Then
            contPractica = contPractica + 1
            TextBox1.Text = ds.Tables("Practica").Rows(contPractica).Item("id_practica")
            TextBox2.Text = ds.Tables("Practica").Rows(contPractica).Item("Tema")
            TextBox3.Text = ds.Tables("Practica").Rows(contPractica).Item("Nota")
            TextBox4.Text = ds.Tables("Practica").Rows(contPractica).Item("Dificultad")
            Calendar1.SelectedDate = ds.Tables("Practica").Rows(contPractica).Item("Fecha_Realizacion")
            Calendar1.VisibleDate = ds.Tables("Practica").Rows(contPractica).Item("Fecha_Realizacion")
        Else
            TextBox1.Text = ds.Tables("Practica").Rows(contPractica).Item("id_practica")
            TextBox2.Text = ds.Tables("Practica").Rows(contPractica).Item("Tema")
            TextBox3.Text = ds.Tables("Practica").Rows(contPractica).Item("Nota")
            TextBox4.Text = ds.Tables("Practica").Rows(contPractica).Item("Dificultad")
            Calendar1.SelectedDate = ds.Tables("Practica").Rows(contPractica).Item("Fecha_Realizacion")
            Calendar1.VisibleDate = ds.Tables("Practica").Rows(contPractica).Item("Fecha_Realizacion")
        End If

    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        contPractica = contPractica + 1
        If contPractica >= ds.Tables("Practica").Rows.Count Then
            contPractica = ds.Tables("Practica").Rows.Count
            contPractica = contPractica - 1
        End If
        TextBox1.Text = ds.Tables("Practica").Rows(contPractica).Item("id_practica")
        TextBox2.Text = ds.Tables("Practica").Rows(contPractica).Item("Tema")
        TextBox3.Text = ds.Tables("Practica").Rows(contPractica).Item("Nota")
        TextBox4.Text = ds.Tables("Practica").Rows(contPractica).Item("Dificultad")
        Calendar1.SelectedDate = ds.Tables("Practica").Rows(contPractica).Item("Fecha_Realizacion")
        Calendar1.VisibleDate = ds.Tables("Practica").Rows(contPractica).Item("Fecha_Realizacion")
    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        contPractica = ds.Tables("Practica").Rows.Count
        contPractica = contPractica - 1
        TextBox1.Text = ds.Tables("Practica").Rows(contPractica).Item("id_practica")
        TextBox2.Text = ds.Tables("Practica").Rows(contPractica).Item("Tema")
        TextBox3.Text = ds.Tables("Practica").Rows(contPractica).Item("Nota")
        TextBox4.Text = ds.Tables("Practica").Rows(contPractica).Item("Dificultad")
        Calendar1.SelectedDate = ds.Tables("Practica").Rows(contPractica).Item("Fecha_Realizacion")
        Calendar1.VisibleDate = ds.Tables("Practica").Rows(contPractica).Item("Fecha_Realizacion")
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
        Call ejecutar("insert into Practica (Tema,Nota,Dificultad,Fecha_Realizacion) values ('" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "', '" & Calendar1.SelectedDate & "')")
        Button4.Enabled = True
        Button8.Enabled = True
        Button7.Enabled = True

        contPractica = 0

        Response.Redirect("Practica.aspx")
    End Sub

    Protected Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Call ejecutar("update Practica set Tema='" & TextBox2.Text & "' where id_practica=" & TextBox1.Text & " ")
        Call ejecutar("update Practica set Nota='" & TextBox3.Text & "' where id_practica=" & TextBox1.Text & " ")
        Call ejecutar("update Practica set Dificultad='" & TextBox4.Text & "' where id_practica=" & TextBox1.Text & " ")
        Call ejecutar("update Practica set Fecha_Realizacion='" & Calendar1.SelectedDate & "' where id_practica=" & TextBox1.Text & " ")
        contPractica = 0
        Response.Redirect("Practica.aspx")
    End Sub

    Protected Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If MsgBox("¿Esta seguro de eliminar este registro ?", MsgBoxStyle.YesNo, "Información") = MsgBoxResult.Yes Then
            Call ejecutar("delete from Practica where id_practica=" & TextBox1.Text & " ")
            contPractica = 0
            Response.Redirect("Practica.aspx")
        Else
            Exit Sub
        End If
    End Sub
End Class