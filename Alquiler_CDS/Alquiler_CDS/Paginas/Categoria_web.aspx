<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Paginas/Index.Master" CodeBehind="Categoria_web.aspx.vb" Inherits="Alquiler_CDS.Categoria_web" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style5 {
        width: 63px;
        text-align: center;
    }
        .auto-style6 {
        width: 110px;
        text-align: center;
    }
        .auto-style8 {
        width: 89px;
        text-align: center;
    }
        .auto-style9 {
        width: 124px;
        text-align: center;
    }
    .auto-style10 {
        text-align: center;
    }
        .nuevoEstilo6 {
            color: #FFFFFF;
        }
        .nuevoEstilo7 {
            font-size: 25px;
            color: #FFFFFF;
            font-weight: normal;
            font-style: italic;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr class="nuevoEstilo7">
            <td colspan="4" class="auto-style10">CATEGORIAS</td>
        </tr>
        <tr>
            <td class="nuevoEstilo7">&nbsp;</td>
            <td class="nuevoEstilo7">&nbsp;</td>
            <td class="nuevoEstilo7">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
        </tr>
        <tr class="nuevoEstilo7">
            <td colspan="2" class="auto-style10">Id_Categoria</td>
            <td colspan="2" class="auto-style10">
                <asp:TextBox ID="TextBox1" runat="server" Enabled="False"></asp:TextBox>
            </td>
        </tr>
        <tr class="nuevoEstilo7">
            <td class="auto-style10" colspan="2">Descripcion</td>
            <td colspan="2" class="auto-style10">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">
                <asp:Button ID="Button1" runat="server" Text="Primer" BackColor="Gray" ForeColor="White" />
            </td>
            <td class="auto-style5">
                <asp:Button ID="Button2" runat="server" Text="Anterior" BackColor="Gray" ForeColor="White" />
            </td>
            <td class="auto-style6">
                <asp:Button ID="Button3" runat="server" Text="Siguiente" BackColor="Gray" ForeColor="White" />
            </td>
            <td class="auto-style9">
                <asp:Button ID="Button4" runat="server" Text="Ultimo" BackColor="Gray" ForeColor="White" />
            </td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">
                <asp:Button ID="Button5" runat="server" Text="Nuevo" BackColor="Gray" ForeColor="White" />
            </td>
            <td class="auto-style5">
                <asp:Button ID="Button6" runat="server" Text="Insertar" BackColor="Gray" ForeColor="White" />
            </td>
            <td class="auto-style6">
                <asp:Button ID="Button7" runat="server" Text="Actualizar" BackColor="Gray" ForeColor="White" />
            </td>
            <td class="auto-style9">
                <asp:Button ID="Button8" runat="server" Text="Eliminar" BackColor="Gray" ForeColor="White" />
            </td>
        </tr>
    </table>
</asp:Content>
