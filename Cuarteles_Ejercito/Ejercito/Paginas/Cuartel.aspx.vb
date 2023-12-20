Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Data
Partial Class Cuartel
    Inherits System.Web.UI.Page
    Public ds As DataSet

    Private Sub Cuartel_Init(sender As Object, e As EventArgs) Handles Me.Init
        Try
            cnn = New SqlConnection
            cnn.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Ejercito.mdf;Integrated Security=True"
            Dim sql As String = "select * from Cuartel"
            Dim da As New SqlDataAdapter(sql, cnn)
            ds = New DataSet
            da.Fill(ds, "Cuartel")
            TextBox1.Text = ds.Tables("Cuartel").Rows(0).Item("id_cuartel")
            TextBox2.Text = ds.Tables("Cuartel").Rows(0).Item("Nombre")
            TextBox3.Text = ds.Tables("Cuartel").Rows(0).Item("Ubicacion")

        Catch ex As Exception
            MsgBox("Error de Conexión" + ex.Message, MsgBoxStyle.Information, "Error")
        End Try
    End Sub


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        contCuartel = 0
        TextBox1.Text = ds.Tables("Cuartel").Rows(contCuartel).Item("id_cuartel")
        TextBox2.Text = ds.Tables("Cuartel").Rows(contCuartel).Item("Nombre")
        TextBox3.Text = ds.Tables("Cuartel").Rows(contCuartel).Item("Ubicacion")
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        contCuartel = contCuartel - 1
        If contCuartel < 0 Then
            contCuartel = contCuartel + 1
            TextBox1.Text = ds.Tables("Cuartel").Rows(contCuartel).Item("id_cuartel")
            TextBox2.Text = ds.Tables("Cuartel").Rows(contCuartel).Item("Nombre")
            TextBox3.Text = ds.Tables("Cuartel").Rows(contCuartel).Item("Ubicacion")
        Else
            TextBox1.Text = ds.Tables("Cuartel").Rows(contCuartel).Item("id_cuartel")
            TextBox2.Text = ds.Tables("Cuartel").Rows(contCuartel).Item("Nombre")
            TextBox3.Text = ds.Tables("Cuartel").Rows(contCuartel).Item("Ubicacion")
        End If

    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        contCuartel = contCuartel + 1
        If contCuartel >= ds.Tables("Cuartel").Rows.Count Then
            contCuartel = ds.Tables("Cuartel").Rows.Count
            contCuartel = contCuartel - 1
        End If
        TextBox1.Text = ds.Tables("Cuartel").Rows(contCuartel).Item("id_cuartel")
        TextBox2.Text = ds.Tables("Cuartel").Rows(contCuartel).Item("Nombre")
        TextBox3.Text = ds.Tables("Cuartel").Rows(contCuartel).Item("Ubicacion")
    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        contCuartel = ds.Tables("Cuartel").Rows.Count
        contCuartel = contCuartel - 1
        TextBox1.Text = ds.Tables("Cuartel").Rows(contCuartel).Item("id_cuartel")
        TextBox2.Text = ds.Tables("Cuartel").Rows(contCuartel).Item("Nombre")
        TextBox3.Text = ds.Tables("Cuartel").Rows(contCuartel).Item("Ubicacion")
    End Sub

    Protected Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        Button4.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        TextBox2.Focus()
    End Sub

    Protected Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Call ejecutar("insert into Cuartel (Nombre,Ubicacion) values ('" & TextBox2.Text & "', '" & TextBox3.Text & "')")
        Button4.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        contCuartel = 0
        Response.Redirect("Cuartel.aspx")
    End Sub

    Protected Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Call ejecutar("update Cuartel set Nombre='" & TextBox2.Text & "' where id_cuartel=" & TextBox1.Text & " ")
        Call ejecutar("update Cuartel set Ubicacion='" & TextBox3.Text & "' where id_cuartel=" & TextBox1.Text & " ")
        contCuartel = 0
        Response.Redirect("Cuartel.aspx")
    End Sub

    Protected Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If MsgBox("¿Esta seguro de eliminar este registro ?", MsgBoxStyle.YesNo, "Información") = MsgBoxResult.Yes Then
            Call ejecutar("delete from Cuartel where id_cuartel=" & TextBox1.Text & " ")
            contCuartel = 0
            Response.Redirect("Cuartel.aspx")
        Else
            Exit Sub
        End If
    End Sub
End Class