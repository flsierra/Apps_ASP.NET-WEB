<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Paginas/Index.Master" CodeBehind="Examen_web.aspx.vb" Inherits="Facultad.Examen_web" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style3 {
    }
    .auto-style4 {
    }
    .auto-style5 {
        width: 134px;
    }
    .auto-style6 {
        width: 87px;
    }
    .auto-style7 {
        width: 194px;
    }
    .auto-style8 {
        height: 26px;
    }
    .auto-style9 {
        text-align: center;
    }
    .auto-style10 {
        width: 194px;
        text-align: center;
    }
    .auto-style11 {
        width: 87px;
        text-align: center;
    }
    .auto-style12 {
        width: 134px;
        text-align: center;
    }
    .nuevoEstilo1 {
        font-family: "Gill Sans", "Gill Sans MT", Calibri, "Trebuchet MS", sans-serif;
        font-size: 24px;
        font-weight: bold;
        font-style: italic;
        font-variant: normal;
        color: #660033;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
    <tr class="nuevoEstilo1">
        <td colspan="4">Examen Escrito</td>
    </tr>
    <tr>
        <td class="nuevoEstilo1"></td>
        <td class="nuevoEstilo1"></td>
        <td class="nuevoEstilo1"></td>
        <td></td>
    </tr>
    <tr class="nuevoEstilo1">
        <td colspan="2">ID_Examen</td>
        <td colspan="2">
            <asp:TextBox ID="TextBox1" runat="server" Enabled="False"></asp:TextBox>
        </td>
    </tr>
    <tr class="nuevoEstilo1">
        <td class="auto-style3" colspan="2">Tema</td>
        <td colspan="2">
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr class="nuevoEstilo1">
        <td class="auto-style4" colspan="2">Fecha Realizacion</td>
        <td colspan="2">
            <asp:Calendar ID="Calendar1" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" ShowGridLines="True" Width="220px">
                <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                <OtherMonthDayStyle ForeColor="#CC9966" />
                <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                <SelectorStyle BackColor="#FFCC66" />
                <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
                <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
            </asp:Calendar>
        </td>
    </tr>
    <tr class="nuevoEstilo1">
        <td class="auto-style4" colspan="2">&nbsp;</td>
        <td colspan="2">
            &nbsp;</td>
    </tr>
    <tr class="nuevoEstilo1">
        <td class="auto-style4" colspan="2">Numero de Preguntas</td>
        <td colspan="2">
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr class="nuevoEstilo1">
        <td class="auto-style8" colspan="2">Nota</td>
        <td colspan="2" class="auto-style8">
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr class="nuevoEstilo1">
        <td class="auto-style4" colspan="2">Estudiante</td>
        <td colspan="2">
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="nuevoEstilo1">Profesor</td>
        <td class="nuevoEstilo1">&nbsp;</td>
        <td class="nuevoEstilo1">
            <asp:DropDownList ID="DropDownList2" runat="server">
            </asp:DropDownList>
        </td>
        <td class="auto-style9">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style12">
            &nbsp;</td>
        <td class="auto-style11">
            &nbsp;</td>
        <td class="auto-style10">
            &nbsp;</td>
        <td class="auto-style9">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style12">
            &nbsp;</td>
        <td class="auto-style11">
            &nbsp;</td>
        <td class="auto-style10">
            &nbsp;</td>
        <td class="auto-style9">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style12">
            &nbsp;</td>
        <td class="auto-style11">
            &nbsp;</td>
        <td class="auto-style10">
            &nbsp;</td>
        <td class="auto-style9">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5">
            <asp:Button ID="Button1" runat="server" Text="Primer" BackColor="#CC6600" ForeColor="#999999" />
        </td>
        <td class="auto-style6">
            <asp:Button ID="Button2" runat="server" Text="Anterior" BackColor="#CC6600" ForeColor="#999999" />
        </td>
        <td class="auto-style7">
            <asp:Button ID="Button3" runat="server" Text="Siguiente" BackColor="#CC6600" ForeColor="#999999" />
        </td>
        <td>
            <asp:Button ID="Button4" runat="server" Text="Ultimo" BackColor="#CC6600" ForeColor="#999999" />
        </td>
    </tr>
    <tr>
        <td class="auto-style12">
            &nbsp;</td>
        <td class="auto-style11">
            &nbsp;</td>
        <td class="auto-style10">
            &nbsp;</td>
        <td class="auto-style9">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5">
            <asp:Button ID="Button5" runat="server" Text="Nuevo" BackColor="#CC6600" ForeColor="#999999" />
        </td>
        <td class="auto-style6">
            <asp:Button ID="Button6" runat="server" Text="Insertar" BackColor="#CC6600" ForeColor="#999999" />
        </td>
        <td class="auto-style7">
            <asp:Button ID="Button7" runat="server" Text="Actualizar" BackColor="#CC6600" ForeColor="#999999" />
        </td>
        <td>
            <asp:Button ID="Button8" runat="server" Text="Eliminar" BackColor="#CC6600" ForeColor="#999999" />
        </td>
    </tr>
    <tr>
        <td class="auto-style5">&nbsp;</td>
        <td class="auto-style6">&nbsp;</td>
        <td class="auto-style7">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>
