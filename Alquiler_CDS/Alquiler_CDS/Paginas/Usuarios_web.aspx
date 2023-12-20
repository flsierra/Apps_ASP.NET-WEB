<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Paginas/Index.Master" CodeBehind="Usuarios_web.aspx.vb" Inherits="Alquiler_CDS.Usuarios_web" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style4 {
    }
    .auto-style8 {
            text-align: center;
        }
    .auto-style9 {
        width: 42px;
    }
    .auto-style11 {
        width: 40px;
    }
    .auto-style12 {
        width: 4px;
    }
    .auto-style13 {
        width: 37px;
    }
        .nuevoEstilo6 {
            font-size: 25px;
            font-weight: normal;
            font-style: italic;
            font-variant: normal;
            color: #FFFFFF;
        }
        .nuevoEstilo7 {
            font-size: 25px;
            color: #FFFFFF;
        }
        .auto-style14 {
            color: #FF3300;
            height: 41px;
            text-align: center;
        }
        .auto-style15 {
            width: 42px;
            text-align: center;
        }
        .auto-style16 {
            width: 4px;
            text-align: center;
        }
        .nuevoEstilo8 {
            font-size: 40px;
            font-weight: normal;
            font-style: italic;
            color: #FFFFFF;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1" style="margin-top: 5px">
    <tr>
        <td colspan="4"><span class="nuevoEstilo8">USUARIO</span></td>
    </tr>
    <tr>
        <td class="auto-style11">&nbsp;</td>
        <td class="auto-style12">&nbsp;</td>
        <td class="auto-style9">&nbsp;</td>
        <td class="auto-style13">&nbsp;</td>
    </tr>
    <tr class="nuevoEstilo6">
        <td class="auto-style14" colspan="2"><span class="nuevoEstilo7">id_usuario</span></td>
        <td colspan="2" class="auto-style8">
            <asp:TextBox ID="TextBox1" runat="server" Enabled="False"></asp:TextBox>
        </td>
    </tr>
    <tr class="nuevoEstilo6">
        <td class="auto-style8" colspan="2">Nombre</td>
        <td class="auto-style8" colspan="2">
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr class="nuevoEstilo6">
        <td class="auto-style8" colspan="2">Apellido</td>
        <td class="auto-style8" colspan="2">
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr class="nuevoEstilo6">
        <td class="auto-style8" colspan="2">Dirección </td>
        <td class="auto-style8" colspan="2">
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr class="nuevoEstilo6">
        <td class="auto-style8" colspan="2">Telefono</td>
        <td class="auto-style8" colspan="2">
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style11">&nbsp;</td>
        <td class="auto-style16">&nbsp;</td>
        <td class="auto-style15">&nbsp;</td>
        <td class="auto-style13">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style11">&nbsp;</td>
        <td class="auto-style12">&nbsp;</td>
        <td class="auto-style9">&nbsp;</td>
        <td class="auto-style13">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style11">
            <asp:Button ID="Button1" runat="server" Text="Primer" BackColor="Gray" ForeColor="White" />
        </td>
        <td class="auto-style12">
            <asp:Button ID="Button3" runat="server" Text="Anterior" BackColor="Gray" ForeColor="White" />
        </td>
        <td class="auto-style9">
            <asp:Button ID="Button4" runat="server" Text="Siguiente" BackColor="Gray" ForeColor="White" />
        </td>
        <td class="auto-style13">
            <asp:Button ID="Button5" runat="server" Text="Ultimo" BackColor="Gray" ForeColor="White" />
        </td>
    </tr>
    <tr>
        <td class="auto-style11">
            &nbsp;</td>
        <td class="auto-style12">
            &nbsp;</td>
        <td class="auto-style9">
            &nbsp;</td>
        <td class="auto-style13">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style11">
            &nbsp;</td>
        <td class="auto-style12">
            &nbsp;</td>
        <td class="auto-style9">
            &nbsp;</td>
        <td class="auto-style13">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style11">
            <asp:Button ID="Button2" runat="server" Text="Nuevo" BackColor="Gray" ForeColor="White" />
        </td>
        <td class="auto-style12">
            <asp:Button ID="Button6" runat="server" Text="Insertar" BackColor="Gray" ForeColor="White" />
        </td>
        <td class="auto-style9">
            <asp:Button ID="Button7" runat="server" Text="Actualizar" BackColor="Gray" ForeColor="White" />
        </td>
        <td class="auto-style13">
            <asp:Button ID="Button8" runat="server" Text="Eliminar" BackColor="Gray" ForeColor="White" />
        </td>
    </tr>
</table>
</asp:Content>
