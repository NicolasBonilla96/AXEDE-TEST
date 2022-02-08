<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Aplicación_Hoteles.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 74px;
        }
    </style>
</head>
<body style="width: 800px; height: 29px; padding-left:300px; font-family:sans-serif; font-size:20pt; font-weight:700; align-content:center">
    <form id="form1" runat="server">
        <div style="padding-left:150px">
            Consulta Disponibilidad Hoteles
        </div>
        <table>
            <tr style="padding-right: 200px; font-size:12pt; padding-bottom:10px">
                <td class="auto-style1">
                    <asp:Label ID="lblFechaInicio" runat="server" Text="Fecha CheckIn: ">
                    </asp:Label>
                </td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtFechaInicio" runat="server">
                    </asp:TextBox>
                </td>
                <td class="auto-style1">
                    <asp:Label ID="lblFechaFin" runat="server" Text="Fecha CheckOut: ">
                    </asp:Label>
                </td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtFechaFin" runat="server">
                    </asp:TextBox>
                </td>
            </tr>
            <tr style="padding-right: 200px; font-size:12pt">
                <td class="auto-style1">
                    <asp:Label ID="lblHotel" runat="server" Text="Destino: ">
                    </asp:Label>
                </td>
                <td class="auto-style1">
                    <asp:DropDownList ID="ddlHotel" runat="server" Width="175px"></asp:DropDownList>
                </td>
                <td class="auto-style1">
                    <asp:Label ID="lblTipoHab" runat="server" Text="Tipo de Habitación: ">
                    </asp:Label>
                </td>
                <td class="auto-style1">
                    <asp:DropDownList ID="ddlTipoHab" runat="server" Width="175px"></asp:DropDownList>
                </td>
            </tr>
            <tr style="padding-right: 200px; font-size:12pt">
                <td class="auto-style1">
                    <asp:Label ID="lblCupo" runat="server" Text="Cantidad de Personas: ">
                    </asp:Label>
                </td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtCupo" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
        <tr>
            <asp:Button ID="ibtnBuscar" runat="server" text="BUSCAR" OnClick="btnBuscar_click" />
        </tr>
        <tr>
        </tr>
        <tr>
            <asp:GridView ID="gvHotel" runat="server">
            </asp:GridView>
        </tr>
    </form>
</body>
</html>
