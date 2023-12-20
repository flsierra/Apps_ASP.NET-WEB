Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Data
Partial Class Historial_web
    Inherits System.Web.UI.Page
    Public ds As DataSet

    Private Sub Historial_web_Init(sender As Object, e As EventArgs) Handles Me.Init
        Try
            cnn = New SqlConnection
            cnn.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Inventario.mdf;Integrated Security=True"
            Dim sql As String = "select * from Alquiler"
            Dim da As New SqlDataAdapter(sql, cnn)
            ds = New DataSet
            da.Fill(ds, "Alquiler")
            TextBox1.Text = ds.Tables("Alquiler").Rows(0).Item("id_usuario")
        Catch ex As Exception

        End Try
    End Sub


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call ejecutar("select * from Alquiler, where id_usuario= '" & TextBox1.Text & "' from Usuario")

    End Sub
End Class