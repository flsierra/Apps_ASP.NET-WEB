Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Data
Partial Class Compañia_web
    Inherits System.Web.UI.Page
    Public ds As DataSet

    Private Sub Compañia_web_Init(sender As Object, e As EventArgs) Handles Me.Init
        Try
            cnn = New SqlConnection
            cnn.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Ejercito.mdf;Integrated Security=True"
            Dim sql As String = "select * from Compañia"
            Dim da As New SqlDataAdapter(sql, cnn)
            ds = New DataSet
            da.Fill(ds, "Compañia")
            TextBox1.Text = ds.Tables("Compañia").Rows(0).Item("id_compañia")
            TextBox2.Text = ds.Tables("Compañia").Rows(0).Item("Nombre")
            Call cargarcombo("select * from Cuartel", DropDownList1, "id_cuartel", "Nombre")
            DropDownList1.SelectedValue = ds.Tables("Compañia").Rows(0).Item("id_cuartel")
        Catch ex As Exception
            MsgBox("Error de conexion :" + ex.Message, MsgBoxStyle.Information, "Error")
        End Try
    End Sub


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        contCompañia = 0
        TextBox1.Text = ds.Tables("Compañia").Rows(contCompañia).Item("id_compañia")
        TextBox2.Text = ds.Tables("Compañia").Rows(contCompañia).Item("Nombre")
        DropDownList1.SelectedValue = ds.Tables("Compañia").Rows(contCompañia).Item("id_cuartel")
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        contCompañia = contCompañia - 1
        If contCompañia < 0 Then
            contCompañia = contCompañia + 1
            TextBox1.Text = ds.Tables("Compañia").Rows(contCompañia).Item("id_compañia")
            TextBox2.Text = ds.Tables("Compañia").Rows(contCompañia).Item("Nombre")
            DropDownList1.SelectedValue = ds.Tables("Compañia").Rows(contCompañia).Item("id_cuartel")
        Else
            TextBox1.Text = ds.Tables("Compañia").Rows(contCompañia).Item("id_compañia")
            TextBox2.Text = ds.Tables("Compañia").Rows(contCompañia).Item("Nombre")
            DropDownList1.SelectedValue = ds.Tables("Compañia").Rows(contCompañia).Item("id_cuartel")
        End If

    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        contCompañia = contCompañia + 1
        If contCompañia >= ds.Tables("Compañia").Rows.Count Then
            contCompañia = ds.Tables("Compañia").Rows.Count
            contCompañia = contCompañia - 1
        End If
        TextBox1.Text = ds.Tables("Compañia").Rows(contCompañia).Item("id_compañia")
        TextBox2.Text = ds.Tables("Compañia").Rows(contCompañia).Item("Nombre")
        DropDownList1.SelectedValue = ds.Tables("Compañia").Rows(contCompañia).Item("id_cuartel")
    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        contCompañia = ds.Tables("Compañia").Rows.Count
        contCompañia = contCompañia - 1
        TextBox1.Text = ds.Tables("Compañia").Rows(contCompañia).Item("id_compañia")
        TextBox2.Text = ds.Tables("Compañia").Rows(contCompañia).Item("Nombre")
        DropDownList1.SelectedValue = ds.Tables("Compañia").Rows(contCompañia).Item("id_cuartel")
    End Sub

    Protected Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        

        Button4.Enabled = False
        Button8.Enabled = False
        Button7.Enabled = False
        TextBox2.Focus()
    End Sub

    Protected Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Call ejecutar("insert into Compañia (Nombre,id_cuartel) values ('" & TextBox2.Text & "',  " & DropDownList1.SelectedValue & ")")
        Button4.Enabled = True
        Button8.Enabled = True
        Button7.Enabled = True

        contCompañia = 0

        Response.Redirect("Compañia_web.aspx")
    End Sub

    Protected Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Call ejecutar("update Compañia set Nombre='" & TextBox2.Text & "',id_cuartel=" & DropDownList1.SelectedValue & " where id_compañia=" & TextBox1.Text & " ")
        contCompañia = 0
        Response.Redirect("Compañia_web.aspx")
    End Sub

    Protected Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If MsgBox("¿Esta seguro de eliminar este registro ?", MsgBoxStyle.YesNo, "Información") = MsgBoxResult.Yes Then
            Call ejecutar("delete from Compañia where id_compañia=" & TextBox1.Text & " ")
            contCompañia = 0
            Response.Redirect("Compañia_web.aspx")
        Else
            Exit Sub
        End If
    End Sub
End Class