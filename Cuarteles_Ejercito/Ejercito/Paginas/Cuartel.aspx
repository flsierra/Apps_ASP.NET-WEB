<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Paginas/Index.Master" CodeBehind="Cuartel.aspx.vb" Inherits="Ejercito.Cuartel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style3 {
        width: 133px;
    }
    .auto-style4 {
        height: 23px;
    }
    .auto-style5 {
        width: 150px;
    }
        .nuevoEstilo1 {
            font-family: "Gill Sans MT";
            font-size: 24px;
            font-weight: bold;
            font-style: italic;
            font-variant: normal;
            color: #FF9900;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
    <tr class="nuevoEstilo1">
        <td colspan="4">Cuartel</td>
    </tr>
    <tr class="nuevoEstilo1">
        <td colspan="4">&nbsp;</td>
    </tr>
    <tr class="nuevoEstilo1">
        <td colspan="2">Id_Cuartel</td>
        <td colspan="2">
            <asp:TextBox ID="TextBox1" runat="server" Enabled="False"></asp:TextBox>
        </td>
    </tr>
    <tr class="nuevoEstilo1">
        <td class="auto-style4" colspan="2">Nombre</td>
        <td class="auto-style4" colspan="2">
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr class="nuevoEstilo1">
        <td colspan="2">Ubicacion</td>
        <td colspan="2">
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style5">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">
            <asp:Button ID="Button1" runat="server" Text="Primer" BackColor="Gray" ForeColor="#FF9900" />
        </td>
        <td class="auto-style5">
            <asp:Button ID="Button2" runat="server" Text="Anterior" BackColor="Gray" ForeColor="#FF9900" />
        </td>
        <td>
            <asp:Button ID="Button3" runat="server" Text="Siguiente" BackColor="Gray" ForeColor="#FF9900" />
        </td>
        <td>
            <asp:Button ID="Button4" runat="server" Text="Ultimo" BackColor="Gray" ForeColor="#FF9900" />
        </td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style5">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">
            <asp:Button ID="Button5" runat="server" style="height: 26px" Text="Nuevo" BackColor="Gray" ForeColor="#FF9900" />
        </td>
        <td class="auto-style5">
            <asp:Button ID="Button6" runat="server" Text="Insertar" BackColor="Gray" ForeColor="#FF9900" />
        </td>
        <td>
            <asp:Button ID="Button7" runat="server" Text="Actualizar" BackColor="Gray" ForeColor="#FF9900" />
        </td>
        <td>
            <asp:Button ID="Button8" runat="server" Text="Eliminar" BackColor="Gray" ForeColor="#FF9900" />
        </td>
    </tr>
</table>
</asp:Content>
