<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Paginas_Web/Index.Master" CodeBehind="Pais_web.aspx.vb" Inherits="Pagina.Pais_web" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style4 {
    }
    .auto-style5 {
        width: 74px;
    }
    .auto-style6 {
        width: 84px;
    }
    .auto-style8 {
        width: 92px;
    }
    .auto-style9 {
        width: 80px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
    <tr>
        <td colspan="4">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Pais&nbsp;</td>
    </tr>
    <tr>
        <td colspan="2">Id</td>
        <td colspan="2">
            <asp:TextBox ID="TextBox1" runat="server" Enabled="False"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style4" colspan="2">Nombre</td>
        <td colspan="2">
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style5">&nbsp;</td>
        <td class="auto-style6">&nbsp;</td>
        <td class="auto-style8">&nbsp;</td>
        <td class="auto-style9">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5">
            <asp:Button ID="Button1" runat="server" Text="Primer" />
        </td>
        <td class="auto-style6">
            <asp:Button ID="Button2" runat="server" Text="Anterior" />
        </td>
        <td class="auto-style8">
            <asp:Button ID="Button3" runat="server" Text="Siguiente" />
        </td>
        <td class="auto-style9">
            <asp:Button ID="Button4" runat="server" Text="Ultimo" />
        </td>
    </tr>
    <tr>
        <td class="auto-style5">&nbsp;</td>
        <td class="auto-style6">&nbsp;</td>
        <td class="auto-style8">&nbsp;</td>
        <td class="auto-style9">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5">
            <asp:Button ID="Button5" runat="server" Text="Nuevo" />
        </td>
        <td class="auto-style6">
            <asp:Button ID="Button6" runat="server" Text="Insertar" />
        </td>
        <td class="auto-style8">
            <asp:Button ID="Button7" runat="server" Text="Actualizar" />
        </td>
        <td class="auto-style9">
            <asp:Button ID="Button8" runat="server" Text="Eliminar" />
        </td>
    </tr>
    <tr>
        <td class="auto-style5">&nbsp;</td>
        <td class="auto-style6">&nbsp;</td>
        <td class="auto-style8">&nbsp;</td>
        <td class="auto-style9">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5">&nbsp;</td>
        <td class="auto-style6">&nbsp;</td>
        <td class="auto-style8">&nbsp;</td>
        <td class="auto-style9">&nbsp;</td>
    </tr>
</table>
</asp:Content>
