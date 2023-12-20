<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Paginas_Web/Index.Master" CodeBehind="Depto_web.aspx.vb" Inherits="Pagina.Depto_web" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style4 {
            width: 32px;
        }
        .auto-style7 {
            width: 99px;
        }
        .auto-style8 {
            width: 24px;
        }
        .auto-style9 {
            width: 19px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td colspan="4">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; DEPARTAMENTO&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">Id</td>
            <td colspan="2">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">Nombre</td>
            <td colspan="2">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">Pais</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style9">
                <asp:DropDownList ID="DropDownList1" runat="server">
                </asp:DropDownList>
            </td>
            <td class="auto-style7">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Button ID="Button1" runat="server" Text="Primer" />
            </td>
            <td class="auto-style8">
                <asp:Button ID="Button2" runat="server" style="height: 26px" Text="Anterior" />
            </td>
            <td class="auto-style9">
                <asp:Button ID="Button3" runat="server" Text="Siguiente" />
            </td>
            <td class="auto-style7">
                <asp:Button ID="Button4" runat="server" style="margin-left: 0px" Text="Ultimo" />
            </td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Button ID="Button5" runat="server" Text="Nuevo" />
            </td>
            <td class="auto-style8">
                <asp:Button ID="Button6" runat="server" Text="Insertar" />
            </td>
            <td class="auto-style9">
                <asp:Button ID="Button7" runat="server" Text="Actualizar" />
            </td>
            <td class="auto-style7">
                <asp:Button ID="Button8" runat="server" Text="Eliminar" style="height: 26px" />
            </td>
        </tr>
    </table>
</asp:Content>
