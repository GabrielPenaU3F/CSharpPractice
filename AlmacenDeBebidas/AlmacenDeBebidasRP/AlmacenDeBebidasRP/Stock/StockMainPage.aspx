<%@ Page Title="Stock" Language="C#" AutoEventWireup="true" CodeBehind="StockMainPage.aspx.cs" Inherits="AlmacenDeBebidasRP.Stock.StockMainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="formStockMainPage" runat="server">
        <div>
        </div>
        <asp:Button ID="btnAgregar" runat="server" OnClick="btnAgregar_Click" Text="Agregar producto" />
        <asp:Button ID="btnModificar" runat="server" Text="Modificar producto" OnClick="btnModificar_Click" />
        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar producto" OnClick="btnEliminar_Click" />
        <br />
        <br />
        <br />
        <asp:Button ID="btnBuscar" runat="server" EnableTheming="False" OnClick="btnBuscar_Click" Text="Buscar producto" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="Productos"></asp:Label>
&nbsp;
        <asp:DropDownList ID="ProductosDDList" runat="server" Height="29px" Width="247px">
        </asp:DropDownList>
        <br />
        <asp:CheckBox ID="BuscarPorIdCB" runat="server" AutoPostBack="True" Text="Por ID" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="BuscarPorIdTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:CheckBox ID="BuscarPorNombreCB" runat="server" AutoPostBack="True" Text="Por nombre" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="BuscarPorNombreTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:CheckBox ID="BuscarPorCategoriaCB" runat="server" AutoPostBack="True" Text="Por categoría" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="CategoriasDDList" runat="server">
        </asp:DropDownList>
        <br />
        <asp:CheckBox ID="BuscarPorOrigenCB" runat="server" AutoPostBack="True" Text="Por origen" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="OrigenesDDList" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <br />
    </form>
</body>
</html>
