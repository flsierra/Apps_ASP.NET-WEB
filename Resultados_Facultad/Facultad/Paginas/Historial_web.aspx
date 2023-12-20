<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Paginas/Index.Master" CodeBehind="Historial_web.aspx.vb" Inherits="Facultad.Historial_web" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            width: 143px;
        }
        .auto-style4 {
            width: 92px;
        }
        .auto-style5 {
            width: 185px;
        }
        .auto-style6 {
            width: 143px;
            height: 23px;
        }
        .auto-style7 {
            width: 92px;
            height: 23px;
        }
        .auto-style8 {
            width: 185px;
            height: 23px;
        }
        .auto-style9 {
            height: 23px;
        }
    .nuevoEstilo2 {
        font-family: Georgia, "Times New Roman", Times, serif;
        font-size: 24px;
        font-weight: normal;
        font-style: italic;
        font-variant: normal;
        color: #800080;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr class="nuevoEstilo2">
            <td colspan="4">Historial</td>
        </tr>
        <tr class="nuevoEstilo2">
            <td class="auto-style6"></td>
            <td class="auto-style7"></td>
            <td class="auto-style8"></td>
            <td class="auto-style9"></td>
        </tr>
        <tr class="nuevoEstilo2">
            <td colspan="2">Id_Historial</td>
            <td colspan="2">
                <asp:TextBox ID="TextBox1" runat="server" Enabled="False"></asp:TextBox>
            </td>
        </tr>
        <tr class="nuevoEstilo2">
            <td colspan="2">Fecha Realizacion</td>
            <td colspan="2">
                <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px">
                    <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                    <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                    <OtherMonthDayStyle ForeColor="#999999" />
                    <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                    <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                    <TodayDayStyle BackColor="#CCCCCC" />
                </asp:Calendar>
            </td>
        </tr>
        <tr class="nuevoEstilo2">
            <td colspan="2">Fecha Resultados</td>
            <td colspan="2">
                <asp:Calendar ID="Calendar2" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px">
                    <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                    <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                    <OtherMonthDayStyle ForeColor="#999999" />
                    <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                    <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                    <TodayDayStyle BackColor="#CCCCCC" />
                </asp:Calendar>
            </td>
        </tr>
        <tr class="nuevoEstilo2">
            <td colspan="2">Estudiante</td>
            <td colspan="2">
                <asp:DropDownList ID="DropDownList1" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr class="nuevoEstilo2">
            <td colspan="2">Practica</td>
            <td colspan="2">
                <asp:DropDownList ID="DropDownList2" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr class="nuevoEstilo2">
            <td colspan="2">Profesor</td>
            <td colspan="2">
                <asp:DropDownList ID="DropDownList3" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr class="nuevoEstilo2">
            <td class="auto-style3">Examen</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style5">
                <asp:DropDownList ID="DropDownList4" runat="server">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6">
                </td>
            <td class="auto-style7">
                </td>
            <td class="auto-style8">
                </td>
            <td class="auto-style9">
                </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Button ID="Button1" runat="server" Text="Primer" BackColor="#CC6600" ForeColor="#999999" />
            </td>
            <td class="auto-style4">
                <asp:Button ID="Button2" runat="server" Text="Anterior" BackColor="#CC6600" ForeColor="#999999" />
            </td>
            <td class="auto-style5">
                <asp:Button ID="Button3" runat="server" Text="Siguiente" BackColor="#CC6600" ForeColor="#999999" />
            </td>
            <td>
                <asp:Button ID="Button4" runat="server" Text="Utimo" BackColor="#CC6600" ForeColor="#999999" />
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                &nbsp;</td>
            <td class="auto-style4">
                &nbsp;</td>
            <td class="auto-style5">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Button ID="Button5" runat="server" Text="Nuevo" BackColor="#CC6600" ForeColor="#999999" />
            </td>
            <td class="auto-style4">
                <asp:Button ID="Button6" runat="server" Text="Insertar" BackColor="#CC6600" ForeColor="#999999" />
            </td>
            <td class="auto-style5">
                <asp:Button ID="Button7" runat="server" Text="Actualizar" BackColor="#CC6600" ForeColor="#999999" />
            </td>
            <td>
                <asp:Button ID="Button8" runat="server" Text="Eliminar" BackColor="#CC6600" ForeColor="#999999" />
            </td>
        </tr>
    </table>
</asp:Content>
