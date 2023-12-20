<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Paginas/Index.Master" CodeBehind="Practica.aspx.vb" Inherits="Facultad.Practica" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            height: 23px;
        }
        .auto-style5 {
            height: 23px;
            width: 140px;
        }
        .auto-style6 {
            width: 140px;
        }
        .auto-style7 {
            width: 125px;
        }
        .auto-style8 {
            height: 23px;
            width: 125px;
        }
        .auto-style9 {
            width: 182px;
        }
        .auto-style10 {
            height: 23px;
            width: 182px;
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
        <tr>
            <td colspan="4">Practica</td>
        </tr>
        <tr>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr class="nuevoEstilo2">
            <td colspan="2">Id_Practica</td>
            <td colspan="2">
                <asp:TextBox ID="TextBox1" runat="server" Enabled="False"></asp:TextBox>
            </td>
        </tr>
        <tr class="nuevoEstilo2">
            <td class="auto-style3" colspan="2">Tema</td>
            <td class="auto-style3" colspan="2">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr class="nuevoEstilo2">
            <td colspan="2">Nota</td>
            <td colspan="2">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr class="nuevoEstilo2">
            <td colspan="2">Dificultad</td>
            <td colspan="2">
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr class="nuevoEstilo2">
            <td colspan="2">Fecha Realizacion</td>
            <td colspan="2">
                <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="200px" Width="220px">
                    <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                    <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                    <OtherMonthDayStyle ForeColor="#999999" />
                    <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                    <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                    <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                    <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                    <WeekendDayStyle BackColor="#CCCCFF" />
                </asp:Calendar>
            </td>
        </tr>
        <tr>
            <td class="auto-style5"></td>
            <td class="auto-style8"></td>
            <td class="auto-style10"></td>
            <td class="auto-style3"></td>
        </tr>
        <tr>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6">
                <asp:Button ID="Button1" runat="server" Text="Primer" BackColor="#FF6600" ForeColor="Gray" />
            </td>
            <td class="auto-style7">
                <asp:Button ID="Button2" runat="server" Text="Anterior" BackColor="#FF6600" ForeColor="Gray" />
            </td>
            <td class="auto-style9">
                <asp:Button ID="Button3" runat="server" Text="Siguiente" BackColor="#FF6600" ForeColor="Gray" />
            </td>
            <td>
                <asp:Button ID="Button4" runat="server" Text="Ultimo" BackColor="#FF6600" ForeColor="Gray" />
            </td>
        </tr>
        <tr>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6">
                <asp:Button ID="Button5" runat="server" Text="Nuevo" BackColor="#FF6600" ForeColor="Gray" />
            </td>
            <td class="auto-style7">
                <asp:Button ID="Button6" runat="server" Text="Insertar" BackColor="#FF6600" ForeColor="Gray" />
            </td>
            <td class="auto-style9">
                <asp:Button ID="Button7" runat="server" Text="Actualizar" BackColor="#FF6600" ForeColor="Gray" />
            </td>
            <td>
                <asp:Button ID="Button8" runat="server" style="height: 26px" Text="Eliminar" BackColor="#FF6600" ForeColor="Gray" />
            </td>
        </tr>
    </table>
</asp:Content>
