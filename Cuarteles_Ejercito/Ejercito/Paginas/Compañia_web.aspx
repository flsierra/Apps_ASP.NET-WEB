<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Paginas/Index.Master" CodeBehind="Compañia_web.aspx.vb" Inherits="Ejercito.Compañia_web" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style3 {
    }
    .auto-style4 {
        width: 135px;
    }
    .auto-style5 {
        width: 138px;
    }
        .nuevoEstilo1 {
            font-family: "Gill Sans MT";
            font-size: 24px;
            font-weight: bold;
            font-style: italic;
            color: #FF3300;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
    <tr class="nuevoEstilo1">
        <td colspan="4">Compañia Ejercito</td>
    </tr>
    <tr class="nuevoEstilo1">
        <td colspan="4">&nbsp;</td>
    </tr>
    <tr class="nuevoEstilo1">
        <td class="auto-style3" colspan="2">Id_Compañia</td>
        <td colspan="2">
            <asp:TextBox ID="TextBox1" runat="server" Enabled="False"></asp:TextBox>
        </td>
    </tr>
    <tr class="nuevoEstilo1">
        <td class="auto-style3" colspan="2">Nombre</td>
        <td colspan="2">
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr class="nuevoEstilo1">
        <td class="auto-style3" colspan="2">Cuartel</td>
        <td colspan="2">
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="auto-style4">&nbsp;</td>
        <td class="auto-style5">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style4">
            <asp:Button ID="Button1" runat="server" Text="Primer" BackColor="#999999" ForeColor="#FF6600" />
        </td>
        <td class="auto-style5">
            <asp:Button ID="Button2" runat="server" Text="Anterior" BackColor="#999999" ForeColor="#FF6600" />
        </td>
        <td>
            <asp:Button ID="Button3" runat="server" Text="Siguiente" BackColor="#999999" ForeColor="#FF6600" />
        </td>
        <td>
            <asp:Button ID="Button4" runat="server" Text="Ultimo" BackColor="#999999" ForeColor="#FF6600" />
        </td>
    </tr>
    <tr>
        <td class="auto-style4">&nbsp;</td>
        <td class="auto-style5">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style4">
            <asp:Button ID="Button5" runat="server" Text="Nuevo" BackColor="#999999" ForeColor="#FF6600" />
        </td>
        <td class="auto-style5">
            <asp:Button ID="Button6" runat="server" Text="Insertar" BackColor="#999999" ForeColor="#FF6600" />
        </td>
        <td>
            <asp:Button ID="Button7" runat="server" Text="Actualizar" BackColor="#999999" ForeColor="#FF6600" />
        </td>
        <td>
            <asp:Button ID="Button8" runat="server" Text="Eliminar" BackColor="#999999" ForeColor="#FF6600" />
        </td>
    </tr>
    <tr>
        <td class="auto-style4">
            &nbsp;</td>
        <td class="auto-style5">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style4">
            &nbsp;</td>
        <td class="auto-style5">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style4">
            &nbsp;</td>
        <td class="auto-style5">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style4">
            &nbsp;</td>
        <td class="auto-style5">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style4">
            &nbsp;</td>
        <td class="auto-style5">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style4">
            &nbsp;</td>
        <td class="auto-style5">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style4">
            &nbsp;</td>
        <td class="auto-style5">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style4">
            &nbsp;</td>
        <td class="auto-style5">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
</table>
</asp:Content>
