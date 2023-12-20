<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Paginas/Index.Master" CodeBehind="Profesor_web.aspx.vb" Inherits="Facultad.Profesor_web" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style3 {
        height: 23px;
    }
    .auto-style4 {
    }
    .auto-style5 {
        width: 130px;
    }
    .auto-style6 {
        width: 169px;
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
        <td class="auto-style3" colspan="4">Usuario Profesor</td>
    </tr>
    <tr class="nuevoEstilo2">
        <td colspan="4">&nbsp;</td>
    </tr>
    <tr class="nuevoEstilo2">
        <td class="auto-style4" colspan="2">Id_Profesor</td>
        <td colspan="2">
            <asp:TextBox ID="TextBox1" runat="server" Enabled="False"></asp:TextBox>
        </td>
    </tr>
    <tr class="nuevoEstilo2">
        <td class="auto-style4" colspan="2">Nombre</td>
        <td colspan="2">
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr class="nuevoEstilo2">
        <td class="auto-style4" colspan="2">Apellido</td>
        <td colspan="2">
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr class="nuevoEstilo2">
        <td class="auto-style4" colspan="2">Documento</td>
        <td colspan="2">
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style6">&nbsp;</td>
        <td class="auto-style5">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style6">&nbsp;</td>
        <td class="auto-style5">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style6">
            <asp:Button ID="Button1" runat="server" Text="Primer" BackColor="#FF6600" ForeColor="Gray" />
        </td>
        <td class="auto-style5">
            <asp:Button ID="Button2" runat="server" Text="Anterior" BackColor="#FF6600" ForeColor="Gray" />
        </td>
        <td>
            <asp:Button ID="Button3" runat="server" Text="Siguiente" BackColor="#FF6600" ForeColor="Gray" />
        </td>
        <td>
            <asp:Button ID="Button4" runat="server" Text="Ultimo" BackColor="#FF6600" ForeColor="Gray" />
        </td>
    </tr>
    <tr>
        <td class="auto-style6">&nbsp;</td>
        <td class="auto-style5">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style6">
            <asp:Button ID="Button5" runat="server" Text="Nuevo" BackColor="#FF6600" ForeColor="Gray" />
        </td>
        <td class="auto-style5">
            <asp:Button ID="Button6" runat="server" Text="Insertar" BackColor="#FF6600" ForeColor="Gray" />
        </td>
        <td>
            <asp:Button ID="Button7" runat="server" Text="Actualizar" BackColor="#FF6600" ForeColor="Gray" />
        </td>
        <td>
            <asp:Button ID="Button8" runat="server" Text="Eliminar" BackColor="#FF6600" ForeColor="Gray" />
        </td>
    </tr>
    <tr>
        <td class="auto-style6">&nbsp;</td>
        <td class="auto-style5">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>
