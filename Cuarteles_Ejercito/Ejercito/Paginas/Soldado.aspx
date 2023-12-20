<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Paginas/Index.Master" CodeBehind="Soldado.aspx.vb" Inherits="Ejercito.Soldado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
        }
        .auto-style4 {
            width: 103px;
        }
        .auto-style5 {
            width: 163px;
        }
    .nuevoEstilo1 {
        font-family: Georgia;
        font-size: 24px;
        font-weight: normal;
        font-style: italic;
        font-variant: normal;
        color: #993300;
    }
    .nuevoEstilo2 {
        font-family: "Gill Sans MT";
        font-size: 24px;
        font-weight: bold;
        font-style: italic;
        font-variant: normal;
        color: #808080;
    }
    .nuevoEstilo3 {
        font-family: "Gill Sans MT";
        font-size: 24px;
        font-weight: bold;
        font-style: italic;
        font-variant: normal;
        color: #CC3300;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr class="nuevoEstilo2">
            <td colspan="4">SOLDADO</td>
        </tr>
        <tr class="nuevoEstilo2">
            <td class="auto-style3" colspan="4">&nbsp;</td>
        </tr>
        <tr class="nuevoEstilo3">
            <td colspan="2">Id_Soldado</td>
            <td colspan="2">
                <asp:TextBox ID="TextBox1" runat="server" Enabled="False"></asp:TextBox>
            </td>
        </tr>
        <tr class="nuevoEstilo3">
            <td colspan="2">Nombre</td>
            <td colspan="2">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr class="nuevoEstilo3">
            <td colspan="2">Apellido</td>
            <td colspan="2">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr class="nuevoEstilo3">
            <td colspan="2">Cuerpo Ejercito</td>
            <td colspan="2">
                <asp:DropDownList ID="DropDownList1" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr class="nuevoEstilo3">
            <td colspan="2">Compañia</td>
            <td colspan="2">
                <asp:DropDownList ID="DropDownList2" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr class="nuevoEstilo3">
            <td colspan="2">Graduación</td>
            <td colspan="2">
                <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="Black" DayNameFormat="Shortest" Font-Names="Times New Roman" Font-Size="10pt" ForeColor="Black" Height="220px" NextPrevFormat="FullMonth" TitleFormat="Month" Width="400px">
                    <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" ForeColor="#333333" Height="10pt" />
                    <DayStyle Width="14%" />
                    <NextPrevStyle Font-Size="8pt" ForeColor="White" />
                    <OtherMonthDayStyle ForeColor="#999999" />
                    <SelectedDayStyle BackColor="#CC3333" ForeColor="White" />
                    <SelectorStyle BackColor="#CCCCCC" Font-Bold="True" Font-Names="Verdana" Font-Size="8pt" ForeColor="#333333" Width="1%" />
                    <TitleStyle BackColor="Black" Font-Bold="True" Font-Size="13pt" ForeColor="White" Height="14pt" />
                    <TodayDayStyle BackColor="#CCCC99" />
                </asp:Calendar>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Button ID="Button1" runat="server" Text="Primer" BackColor="Gray" ForeColor="#FF3300" />
            </td>
            <td class="auto-style4">
                <asp:Button ID="Button2" runat="server" Text="Anterior" BackColor="Gray" ForeColor="#FF3300" />
            </td>
            <td class="auto-style5">
                <asp:Button ID="Button3" runat="server" Text="Siguiente" BackColor="Gray" ForeColor="#FF3300" />
            </td>
            <td>
                <asp:Button ID="Button4" runat="server" Text="Ultimo" BackColor="Gray" ForeColor="#FF3300" />
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Button ID="Button5" runat="server" Text="Nuevo" BackColor="Gray" ForeColor="#FF3300" />
            </td>
            <td class="auto-style4">
                <asp:Button ID="Button6" runat="server" Text="Insertar" BackColor="Gray" ForeColor="#FF3300" />
            </td>
            <td class="auto-style5">
                <asp:Button ID="Button7" runat="server" Text="Actualizar" BackColor="Gray" ForeColor="#FF3300" />
            </td>
            <td>
                <asp:Button ID="Button8" runat="server" Text="Eliminar" BackColor="Gray" ForeColor="#FF3300" />
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
