<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Paginas_Web/Index.Master" CodeBehind="Ciudad_web.aspx.vb" Inherits="Pagina.Ciudad_web" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style3 {
        width: 84px;
    }
    .auto-style4 {
        width: 96px;
    }
    .auto-style8 {
    }
    .auto-style9 {
        height: 24px;
    }
    .auto-style10 {
        width: 115px;
    }
    .auto-style11 {
        width: 232px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
    <tr>
        <td colspan="4">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Ciudad&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style8" colspan="4">&nbsp;</td>
    </tr>
    <tr>
        <td colspan="2">Id_ciudad</td>
        <td colspan="2">
            <asp:TextBox ID="TextBox1" runat="server" Enabled="False"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td colspan="2">Nombre</td>
        <td colspan="2">
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td colspan="2">Departamento</td>
        <td colspan="2">
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="auto-style9" colspan="4"></td>
    </tr>
    <tr>
        <td class="auto-style10">
            <asp:Button ID="Button1" runat="server" Text="Primer" />
        </td>
        <td class="auto-style4">
            <asp:Button ID="Button2" runat="server" Text="Anterior" />
        </td>
        <td class="auto-style3">
            <asp:Button ID="Button3" runat="server" Text="Siguiente" />
        </td>
        <td class="auto-style11">
            <asp:Button ID="Button4" runat="server" style="margin-left: 1px" Text="Ultimo" />
        </td>
    </tr>
    <tr>
        <td class="auto-style10">&nbsp;</td>
        <td class="auto-style4">&nbsp;</td>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style11">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style10">
            <asp:Button ID="Button5" runat="server" Text="Nuevo" />
        </td>
        <td class="auto-style4">
            <asp:Button ID="Button6" runat="server" Text="Insertar" />
        </td>
        <td class="auto-style3">
            <asp:Button ID="Button7" runat="server" Text="Actualizar" />
        </td>
        <td class="auto-style11">
            <asp:Button ID="Button8" runat="server" Text="Eliminar" />
        </td>
    </tr>
</table>
</asp:Content>
