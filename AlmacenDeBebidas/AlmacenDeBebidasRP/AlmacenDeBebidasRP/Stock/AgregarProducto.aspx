<%@ Page Title="Agregar producto" Language="C#" AutoEventWireup="true" CodeBehind="AgregarProducto.aspx.cs" Inherits="AlmacenDeBebidasRP.Stock.AgregarProductoForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #form1 {
            height: 301px;
            width: 457px;
        }
    </style>
</head>
<body style="height: 301px; width: 458px;">
    <form id="form1" runat="server">
        <div dir="ltr">
            <asp:Label ID="Label2" runat="server" Text="Ingrese los datos del producto"></asp:Label>
        </div>
        <br />
        ID del producto&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="idTextBox" runat="server"></asp:TextBox>
        <br />
        Nombre del producto&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="nombreTextBox" runat="server"></asp:TextBox>
        <br />
        Categoría&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="categoriaDDList" runat="server">
        </asp:DropDownList>
        <br />
        Origen&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="origenDDList" runat="server" OnSelectedIndexChanged="origenDDList_SelectedIndexChanged" AutoPostBack="True">
        </asp:DropDownList>
        <br />
        <asp:Label ID="LabelPrecio" runat="server" Text="Precio (ARS)"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="precioTextBox" runat="server"></asp:TextBox>
        <br />
        Cantidad&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="cantidadTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        &nbsp;<asp:Button ID="btnVolver" runat="server" OnClick="btnVolver_Click" Text="Volver a Stock" />
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnAceptar" runat="server" OnClick="btnAceptar_Click" Text="Aceptar" />
        &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblResultado" runat="server"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </form>
</body>
</html>
