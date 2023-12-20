<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Paginas/Index.Master" CodeBehind="Servicio_web.aspx.vb" Inherits="Ejercito.Servicio_web" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style3 {
        width: 134px;
    }
    .auto-style4 {
        width: 166px;
    }
    .auto-style5 {
        width: 160px;
    }
    .auto-style6 {
        height: 192px;
    }
    .nuevoEstilo1 {
        font-family: "Gill Sans MT";
        font-size: 24px;
        font-weight: bold;
        font-style: italic;
        font-variant: normal;
        color: #FF3300;
    }
    .nuevoEstilo2 {
        font-family: "Gill Sans MT";
        font-size: 24px;
        font-weight: bold;
        font-style: normal;
        color: #999999;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
    <tr>
        <td colspan="4"><span class="nuevoEstilo2">Servicio Ejercito</span></td>
    </tr>
    <tr>
        <td colspan="4">&nbsp;</td>
    </tr>
    <tr class="nuevoEstilo1">
        <td colspan="2">Id_Servicio</td>
        <td colspan="2">
            <asp:TextBox ID="TextBox1" runat="server" Enabled="False"></asp:TextBox>
        </td>
    </tr>
    <tr class="nuevoEstilo1">
        <td colspan="2">Nombre</td>
        <td colspan="2">
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr class="nuevoEstilo1">
        <td colspan="2">Duracion</td>
        <td colspan="2">
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr class="nuevoEstilo1">
        <td colspan="2">Lugar</td>
        <td colspan="2">
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr class="nuevoEstilo1">
        <td colspan="2">Soldado</td>
        <td colspan="2">
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
        </td>
    </tr>
    <tr class="nuevoEstilo1">
        <td colspan="2">Cuartel</td>
        <td colspan="2">
            <asp:DropDownList ID="DropDownList2" runat="server">
            </asp:DropDownList>
        </td>
    </tr>
    <tr class="nuevoEstilo1">
        <td colspan="2">Fecha Inicio</td>
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
    <tr class="nuevoEstilo1">
        <td colspan="2" class="auto-style6">Fecha Fin</td>
        <td colspan="2" class="auto-style6">
            <asp:Calendar ID="Calendar2" runat="server" BackColor="White" BorderColor="Black" DayNameFormat="Shortest" Font-Names="Times New Roman" Font-Size="10pt" ForeColor="Black" Height="220px" NextPrevFormat="FullMonth" TitleFormat="Month" Width="400px">
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
        <td class="auto-style4">&nbsp;</td>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style5">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style4">
            <asp:Button ID="Button1" runat="server" Text="Primer" BackColor="Gray" ForeColor="#FF9933" />
        </td>
        <td class="auto-style3">
            <asp:Button ID="Button2" runat="server" Text="Anterior" BackColor="Gray" ForeColor="#FF9933" />
        </td>
        <td class="auto-style5">
            <asp:Button ID="Button3" runat="server" Text="Siguiente" BackColor="Gray" ForeColor="#FF9933" />
        </td>
        <td>
            <asp:Button ID="Button4" runat="server" Text="Ultimo" BackColor="Gray" ForeColor="#FF9933" />
        </td>
    </tr>
    <tr>
        <td class="auto-style4">&nbsp;</td>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style5">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style4">
            <asp:Button ID="Button5" runat="server" Text="Nuevo" BackColor="Gray" ForeColor="#FF9933" />
        </td>
        <td class="auto-style3">
            <asp:Button ID="Button6" runat="server" Text="Insertar" BackColor="Gray" ForeColor="#FF9933" />
        </td>
        <td class="auto-style5">
            <asp:Button ID="Button7" runat="server" Text="Actualizar" BackColor="Gray" ForeColor="#FF9933" />
        </td>
        <td>
            <asp:Button ID="Button8" runat="server" Text="Eliminar" BackColor="Gray" ForeColor="#FF9933" />
        </td>
    </tr>
    <tr>
        <td class="auto-style4">&nbsp;</td>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style5">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style4">&nbsp;</td>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style5">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>
