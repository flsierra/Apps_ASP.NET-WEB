﻿Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Data
Partial Class Cuerpo_web
    Inherits System.Web.UI.Page
    Public ds As DataSet

    Private Sub Cuerpo_web_Init(sender As Object, e As EventArgs) Handles Me.Init
        Try
            cnn = New SqlConnection
            cnn.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Ejercito.mdf;Integrated Security=True"
            Dim sql As String = "select * from Cuerpo_Ejercito"
            Dim da As New SqlDataAdapter(sql, cnn)
            ds = New DataSet
            da.Fill(ds, "Cuerpo_Ejercito")
            TextBox1.Text = ds.Tables("Cuerpo_Ejercito").Rows(0).Item("id_cuerpo")
            TextBox2.Text = ds.Tables("Cuerpo_Ejercito").Rows(0).Item("Denominación")

        Catch ex As Exception
            MsgBox("Error de Conexión" + ex.Message, MsgBoxStyle.Information, "Error")
        End Try
    End Sub


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        contCuerpo = 0
        TextBox1.Text = ds.Tables("Cuerpo_Ejercito").Rows(contCuerpo).Item("id_cuerpo")
        TextBox2.Text = ds.Tables("Cuerpo_Ejercito").Rows(contCuerpo).Item("Denominación")
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        contCuerpo = contCuerpo - 1
        If contCuerpo < 0 Then
            contCuerpo = contCuerpo + 1
            TextBox1.Text = ds.Tables("Cuerpo_Ejercito").Rows(contCuerpo).Item("id_cuerpo")
            TextBox2.Text = ds.Tables("Cuerpo_Ejercito").Rows(contCuerpo).Item("Denominación")
        Else
            TextBox1.Text = ds.Tables("Cuerpo_Ejercito").Rows(contCuerpo).Item("id_cuerpo")
            TextBox2.Text = ds.Tables("Cuerpo_Ejercito").Rows(contCuerpo).Item("Denominación")
        End If

    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        contCuerpo = contCuerpo + 1
        If contCuerpo >= ds.Tables("Cuerpo_Ejercito").Rows.Count Then
            contCuerpo = ds.Tables("Cuerpo_Ejercito").Rows.Count
            contCuerpo = contCuerpo - 1
        End If
        TextBox1.Text = ds.Tables("Cuerpo_Ejercito").Rows(contCuerpo).Item("id_cuerpo")
        TextBox2.Text = ds.Tables("Cuerpo_Ejercito").Rows(contCuerpo).Item("Denominación")
    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        contCuerpo = ds.Tables("Cuerpo_Ejercito").Rows.Count
        contCuerpo = contCuerpo - 1
        TextBox1.Text = ds.Tables("Cuerpo_Ejercito").Rows(contCuerpo).Item("id_cuerpo")
        TextBox2.Text = ds.Tables("Cuerpo_Ejercito").Rows(contCuerpo).Item("Denominación")
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
        Call ejecutar("insert into Cuerpo_Ejercito (Denominación) values ('" & TextBox2.Text & "')")
        Button5.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        contCuerpo = 0
        Response.Redirect("Cuerpo_web.aspx")
    End Sub

    Protected Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Call ejecutar("update Cuerpo_Ejercito set Denominación='" & TextBox2.Text & "' where id_cuerpo=" & TextBox1.Text & " ")
        contCuerpo = 0
        Response.Redirect("Cuerpo_web.aspx")
    End Sub

    Protected Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If MsgBox("¿Esta seguro de eliminar este registro ?", MsgBoxStyle.YesNo, "Información") = MsgBoxResult.Yes Then
            Call ejecutar("delete from Cuerpo_Ejercito where id_cuerpo=" & TextBox1.Text & " ")
            contCuerpo = 0
            Response.Redirect("Cuerpo_web.aspx")
        Else
            Exit Sub
        End If
    End Sub
End Class