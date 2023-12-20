<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Paginas/Index.Master" CodeBehind="Usuario_web.aspx.vb" Inherits="Facultad.Usuario_web" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style4 {
        width: 109px;
    }
    .auto-style5 {
        width: 176px;
    }
    .auto-style6 {
        width: 128px;
    }
        .auto-style7 {
            width: 176px;
            height: 7px;
        }
        .auto-style8 {
            width: 109px;
            height: 7px;
        }
        .auto-style9 {
            width: 128px;
            height: 7px;
        }
        .auto-style10 {
            height: 7px;
        }
        .auto-style11 {
            text-align: center;
        }
        .auto-style15 {
            text-align: left;
        }
    .nuevoEstilo2 {
        font-family: "Gill Sans", "Gill Sans MT", Calibri, "Trebuchet MS", sans-serif;
        font-size: 24px;
        font-weight: bold;
        font-style: italic;
        font-variant: normal;
        color: #800080;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
    <tr class="nuevoEstilo2">
        <td colspan="4" class="auto-style15">USUARIO ESTUDIANTE</td>
    </tr>
    <tr class="nuevoEstilo2">
        <td colspan="4" class="auto-style11">&nbsp;</td>
    </tr>
    <tr class="nuevoEstilo2">
        <td colspan="2" class="auto-style11">Id_Usuario</td>
        <td colspan="2" class="auto-style11">
            <asp:TextBox ID="TextBox1" runat="server" Enabled="False"></asp:TextBox>
        </td>
    </tr>
    <tr class="nuevoEstilo2">
        <td class="auto-style11" colspan="2">Nombre</td>
        <td colspan="2" class="auto-style11">
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr class="nuevoEstilo2">
        <td class="auto-style11" colspan="2">Apellido</td>
        <td colspan="2" class="auto-style11">
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr class="nuevoEstilo2">
        <td class="auto-style11" colspan="2">Documento</td>
        <td colspan="2" class="auto-style11">
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr class="nuevoEstilo2">
        <td class="auto-style11" colspan="2">Numero Matricula</td>
        <td colspan="2" class="auto-style11">
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr class="nuevoEstilo2">
        <td class="auto-style11" colspan="2">Grupo</td>
        <td colspan="2" class="auto-style11">
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style11" colspan="2">&nbsp;</td>
        <td colspan="2" class="auto-style11">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5">
            <asp:Button ID="Button1" runat="server" Text="Primer" BackColor="#FF3300" ForeColor="Gray" />
        </td>
        <td class="auto-style4">
            <asp:Button ID="Button2" runat="server" Text="Anterior" style="height: 26px" BackColor="#FF3300" ForeColor="Gray" />
        </td>
        <td class="auto-style6">
            <asp:Button ID="Button3" runat="server" Text="Siguiente" BackColor="#FF3300" ForeColor="Gray" />
        </td>
        <td>
            <asp:Button ID="Button4" runat="server" Text="Ultimo" BackColor="#FF3300" ForeColor="Gray" />
        </td>
    </tr>
    <tr>
        <td class="auto-style7">
            </td>
        <td class="auto-style8">
            </td>
        <td class="auto-style9">
            </td>
        <td class="auto-style10">
            </td>
    </tr>
    <tr>
        <td class="auto-style5">
            <asp:Button ID="Button5" runat="server" Text="Nuevo" style="text-align: center" BackColor="#FF3300" ForeColor="Gray" />
        </td>
        <td class="auto-style4">
            <asp:Button ID="Button6" runat="server" Text="Insertar" BackColor="#FF3300" ForeColor="Gray" />
        </td>
        <td class="auto-style6">
            <asp:Button ID="Button7" runat="server" Text="Actualizar" BackColor="#FF3300" ForeColor="Gray" />
        </td>
        <td>
            <asp:Button ID="Button8" runat="server" Text="Eliminar" BackColor="#FF3300" ForeColor="Gray" />
        </td>
    </tr>
</table>
</asp:Content>
