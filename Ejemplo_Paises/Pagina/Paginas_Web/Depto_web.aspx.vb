Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Data

Partial Class Depto_web
    Inherits System.Web.UI.Page
    Public ds As DataSet

    Private Sub Page_Init(sender As Object, e As EventArgs) Handles Me.Init
        Try
            cnn = New SqlConnection
            cnn.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Paises.mdf;Integrated Security=True"
            Dim sql As String = "select * from Depto"
            Dim da As New SqlDataAdapter(sql, cnn)
            ds = New DataSet
            da.Fill(ds, "Depto")
            TextBox1.Text = ds.Tables("Depto").Rows(0).Item("id_depto")
            TextBox2.Text = ds.Tables("Depto").Rows(0).Item("Nombre")
            Call cargarcombo("select * from Pais", DropDownList1, "id_pais", "Nombre")
            DropDownList1.SelectedValue = ds.Tables("Depto").Rows(0).Item("id_pais")

        Catch ex As Exception
            MsgBox("Error de conexion :" + ex.Message, MsgBoxStyle.Information, "Error")
        End Try
    End Sub


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        contDepto = 0
        TextBox1.Text = ds.Tables("Depto").Rows(contDepto).Item("id_depto")
        TextBox2.Text = ds.Tables("Depto").Rows(contDepto).Item("Nombre")
        DropDownList1.SelectedValue = ds.Tables("Depto").Rows(contDepto).Item("id_pais")

    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        contDepto = ds.Tables("Depto").Rows.Count
        contDepto = contDepto - 1
        TextBox1.Text = ds.Tables("Depto").Rows(contDepto).Item("id_depto")
        TextBox2.Text = ds.Tables("Depto").Rows(contDepto).Item("Nombre")
        DropDownList1.SelectedValue = ds.Tables("Depto").Rows(contDepto).Item("id_pais")
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        contDepto = contDepto - 1
        If contDepto < 0 Then
            contDepto = contDepto + 1
            TextBox1.Text = ds.Tables("Depto").Rows(contDepto).Item("id_depto")
            TextBox2.Text = ds.Tables("Depto").Rows(contDepto).Item("Nombre")
            DropDownList1.SelectedValue = ds.Tables("Depto").Rows(contDepto).Item("id_pais")
        Else
            TextBox1.Text = ds.Tables("Depto").Rows(contDepto).Item("id_depto")
            TextBox2.Text = ds.Tables("Depto").Rows(contDepto).Item("Nombre")
            DropDownList1.SelectedValue = ds.Tables("Depto").Rows(contDepto).Item("id_pais")
        End If
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        contDepto = contDepto + 1
        If contDepto >= ds.Tables("Depto").Rows.Count Then
            contDepto = ds.Tables("Depto").Rows.Count
            contDepto = contDepto - 1
        End If
        TextBox1.Text = ds.Tables("Depto").Rows(contDepto).Item("id_depto")
        TextBox2.Text = ds.Tables("Depto").Rows(contDepto).Item("Nombre")
        DropDownList1.SelectedValue = ds.Tables("Depto").Rows(contDepto).Item("id_pais")
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
        Call ejecutar("insert into Depto (Nombre,id_pais) values('" & TextBox2.Text & "'," & DropDownList1.SelectedValue & ")")
        Button5.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        contDepto = 0
        Response.Redirect("Depto_web.aspx")
    End Sub

    Protected Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Call ejecutar("update Depto set Nombre='" & TextBox2.Text & "',id_pais=" & DropDownList1.SelectedValue & " where id_depto=" & TextBox1.Text & " ")
        contDepto = 0
        Response.Redirect("Depto_web.aspx")

    End Sub

    Protected Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If MsgBox("¿ Esta seguro de eliminar este registro?", MsgBoxStyle.YesNo, "Información") - MsgBoxResult.Yes Then
            Call ejecutar("delete from Depto where id_depto=" & TextBox1.Text & " ")
            contDepto = 0
            Response.Redirect("Depto_web.aspx")
        Else

        End If

    End Sub
End Class