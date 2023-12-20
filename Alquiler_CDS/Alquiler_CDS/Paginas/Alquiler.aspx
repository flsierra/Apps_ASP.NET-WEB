<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Paginas/Index.Master" CodeBehind="Alquiler.aspx.vb" Inherits="Alquiler_CDS.Alquiler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style12 {
        height: 23px;
    }
        .auto-style17 {
        width: 53px;
        }
        .auto-style20 {
            width: 8px;
            height: 37px;
        }
        .auto-style21 {
            width: 37px;
            height: 37px;
        }
        .auto-style22 {
            width: 15px;
            height: 37px;
        }
        .auto-style23 {
            width: 53px;
            height: 37px;
        }
        .auto-style24 {
        height: 29px;
    }
        .auto-style25 {
            width: 37px;
            height: 29px;
        }
        .auto-style26 {
            width: 53px;
            height: 29px;
        }
    .nuevoEstilo5 {
        font-family: "Myriad Pro Cond";
        font-size: medium;
        font-weight: bold;
        font-style: italic;
        font-variant: normal;
        color: #FF3300;
    }
    .nuevoEstilo6 {
        color: #FFFFFF;
        font-family: Cambria, Cochin, Georgia, Times, "Times New Roman", serif;
        font-size: medium;
        font-weight: normal;
        font-style: italic;
    }
    .nuevoEstilo7 {
        font-size: 28px;
        font-family: Georgia, "Times New Roman", Times, serif;
        font-weight: normal;
        font-style: italic;
        font-variant: normal;
        color: #FFFFFF;
    }
    .nuevoEstilo8 {
        font-size: 20px;
        font-family: Georgia, "Times New Roman", Times, serif;
        font-weight: normal;
        font-style: oblique;
        color: #FFFFFF;
    }
    .nuevoEstilo9 {
        font-size: 20px;
        font-family: Georgia, "Times New Roman", Times, serif;
        font-weight: normal;
        font-style: italic;
        color: #FFFFFF;
    }
    .auto-style27 {
        font-size: 20px;
        font-family: Georgia, "Times New Roman", Times, serif;
        font-weight: normal;
        font-style: italic;
        color: #FFFFFF;
        text-align: center;
    }
    .nuevoEstilo10 {
        font-size: large;
        color: #FFFFFF;
        font-style: italic;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1" style="margin-right: 0px; margin-bottom: 0px;">
        <tr class="nuevoEstilo6">
            <td colspan="4"><span class="nuevoEstilo10">Alquiler</span></td>
        </tr>
        <tr>
            <td class="nuevoEstilo6">&nbsp;</td>
            <td class="nuevoEstilo6">&nbsp;</td>
            <td class="nuevoEstilo6">&nbsp;</td>
            <td class="auto-style17">&nbsp;</td>
        </tr>
        <tr class="nuevoEstilo6">
            <td class="auto-style27" colspan="2">Id</td>
            <td class="auto-style12" colspan="2">
                <asp:TextBox ID="TextBox1_AL" runat="server" Enabled="False"></asp:TextBox>
            </td>
        </tr>
        <tr class="nuevoEstilo6">
            <td colspan="2" class="auto-style27">Observaciones</td>
            <td colspan="2">
                <asp:TextBox ID="TextBox4__AL" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr class="nuevoEstilo6">
            <td colspan="2" class="auto-style27">Usuario</td>
            <td colspan="2">
                <asp:DropDownList ID="DropDownList1" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr class="nuevoEstilo6">
            <td colspan="2" class="auto-style27">Producto</td>
            <td colspan="2">
                <asp:DropDownList ID="DropDownList2" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr class="nuevoEstilo6">
            <td colspan="2" class="auto-style27">Categoria</td>
            <td colspan="2">
                <asp:DropDownList ID="DropDownList3" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr class="nuevoEstilo6">
            <td colspan="2" class="auto-style27">FECHA ALQUILER</td>
            <td colspan="2">
                <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px">
                    <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                    <NextPrevStyle VerticalAlign="Bottom" />
                    <OtherMonthDayStyle ForeColor="#808080" />
                    <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                    <SelectorStyle BackColor="#CCCCCC" />
                    <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                    <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <WeekendDayStyle BackColor="#FFFFCC" />
                </asp:Calendar>
            </td>
        </tr>
        <tr class="nuevoEstilo6">
            <td colspan="2" class="auto-style27">
                FECHA DEVOLUCION</td>
            <td colspan="2">
                <asp:Calendar ID="Calendar2" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px">
                    <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                    <NextPrevStyle VerticalAlign="Bottom" />
                    <OtherMonthDayStyle ForeColor="#808080" />
                    <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                    <SelectorStyle BackColor="#CCCCCC" />
                    <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                    <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <WeekendDayStyle BackColor="#FFFFCC" />
                </asp:Calendar>
            </td>
        </tr>
        <tr class="nuevoEstilo6">
            <td colspan="2" class="auto-style27">
                &nbsp;</td>
            <td colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style20">
                <asp:Button ID="Button1" runat="server" Text="Primer" BackColor="Gray" ForeColor="White" />
            </td>
            <td class="auto-style21">
                <asp:Button ID="Button3" runat="server" Text="Anterior" BackColor="Gray" ForeColor="White" />
            </td>
            <td class="auto-style22">
                <asp:Button ID="Button5" runat="server" Text="Siguiente" BackColor="Gray" ForeColor="White" />
            </td>
            <td class="auto-style23">
                <asp:Button ID="Button7" runat="server" Text="Ultimo" BackColor="Gray" ForeColor="White" />
            </td>
        </tr>
        <tr>
            <td class="auto-style20">
                &nbsp;</td>
            <td class="auto-style21">
                &nbsp;</td>
            <td class="auto-style22">
                &nbsp;</td>
            <td class="auto-style23">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style24">
                <asp:Button ID="Button2_AL" runat="server" Text="Nuevo" BackColor="Gray" ForeColor="White" />
            </td>
            <td class="auto-style25">
                <asp:Button ID="Button4" runat="server" Text="Insertar" BackColor="Gray" ForeColor="White" />
            </td>
            <td class="auto-style24">
                <asp:Button ID="Button6" runat="server" Text="Actualizar" Height="23px" BackColor="Gray" ForeColor="White" />
            </td>
            <td class="auto-style26">
                <asp:Button ID="Button8" runat="server" Text="Eliminar" BackColor="Gray" ForeColor="White" />
            </td>
        </tr>
    </table>
</asp:Content>
