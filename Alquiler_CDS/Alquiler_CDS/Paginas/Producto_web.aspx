<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Paginas/Index.Master" CodeBehind="Producto_web.aspx.vb" Inherits="Alquiler_CDS.Producto_web" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style3 {
    }
    .auto-style4 {
        width: 160px;
    }
    .auto-style5 {
        width: 339px;
    }
    .auto-style6 {
        width: 167px;
    }
        .nuevoEstilo6 {
            font-size: 25px;
            font-weight: normal;
            font-style: italic;
            font-variant: normal;
            color: #FFFFFF;
        }
        .auto-style7 {
            font-size: 25px;
            font-weight: normal;
            font-style: italic;
            font-variant: normal;
            color: #FFFFFF;
            text-align: center;
        }
        .auto-style8 {
            text-align: center;
        }
        .auto-style9 {
            height: 7px;
            text-align: center;
        }
        .nuevoEstilo7 {
            font-size: 30px;
            color: #FFFFFF;
            font-weight: normal;
            font-style: italic;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
    <tr>
        <td colspan="4"><span class="nuevoEstilo7">PRODUCTOS</span></td>
    </tr>
    <tr>
        <td class="auto-style4">&nbsp;</td>
        <td class="auto-style6">&nbsp;</td>
        <td class="auto-style5">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr class="nuevoEstilo6">
        <td class="auto-style9" colspan="2">Id_Productos</td>
        <td colspan="2" class="auto-style8">
            <asp:TextBox ID="TextBox1" runat="server" Enabled="False"></asp:TextBox>
        </td>
    </tr>
    <tr class="nuevoEstilo6">
        <td class="auto-style9" colspan="2">Nombre</td>
        <td colspan="2" class="auto-style8">
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr class="nuevoEstilo6">
        <td class="auto-style9" colspan="2">Cantidad_disponible</td>
        <td colspan="2" class="auto-style8">
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr class="nuevoEstilo6">
        <td class="auto-style9" colspan="2">Categoria</td>
        <td colspan="2" class="auto-style8">
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
        </td>
    </tr>
    <tr class="nuevoEstilo6">
        <td class="auto-style9" colspan="2">Usuario</td>
        <td colspan="2" class="auto-style8">
            <asp:DropDownList ID="DropDownList2" runat="server">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="auto-style7">&nbsp;</td>
        <td class="auto-style7">&nbsp;</td>
        <td class="auto-style7">
            <asp:Button ID="Button1" runat="server" Text="Alquilar" BackColor="Gray" ForeColor="White" />
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style4">&nbsp;</td>
        <td class="auto-style6">&nbsp;</td>
        <td class="auto-style5">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style4">
            <asp:Button ID="Button2" runat="server" Text="Primer" BackColor="Gray" ForeColor="White" />
        </td>
        <td class="auto-style6">
            <asp:Button ID="Button3" runat="server" Text="Anterior" BackColor="Gray" ForeColor="White" />
        </td>
        <td class="auto-style5">
            <asp:Button ID="Button4" runat="server" Text="Siguiente" BackColor="Gray" ForeColor="White" />
        </td>
        <td>
            <asp:Button ID="Button5" runat="server" Text="Ultimo" BackColor="Gray" ForeColor="White" />
        </td>
    </tr>
    <tr>
        <td class="auto-style4">&nbsp;</td>
        <td class="auto-style6">&nbsp;</td>
        <td class="auto-style5">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style4">
            <asp:Button ID="Button6" runat="server" Text="Nuevo" BackColor="Gray" ForeColor="White" />
        </td>
        <td class="auto-style6">
            <asp:Button ID="Button7" runat="server" Text="Insertar" BackColor="Gray" ForeColor="White" />
        </td>
        <td class="auto-style5">
            <asp:Button ID="Button8" runat="server" Text="Actualizar" BackColor="Gray" ForeColor="White" />
        </td>
        <td>
            <asp:Button ID="Button9" runat="server" Text="Eliminar" BackColor="Gray" ForeColor="White" />
        </td>
    </tr>
</table>
</asp:Content>
