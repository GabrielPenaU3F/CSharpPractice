<%@ Page Title="Agregar producto" Language="C#" AutoEventWireup="true" CodeBehind="AgregarProducto.aspx.cs" Inherits="AlmacenDeBebidasRP.Stock.AgregarProductoForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #form1 {
            height: 239px;
        }
    </style>
</head>
<body style="height: 241px; width: 464px;">
    <form id="form1" runat="server">
        <div dir="ltr">
            <asp:Label ID="Label2" runat="server" Text="Ingrese los datos del producto"></asp:Label>
        </div>
        <br />
        <asp:Label ID="Label4" runat="server" Text="ID del producto"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="IDTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Nombre del producto"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="NombreTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text=" Categoría"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="CategoriaDDList" runat="server">
        </asp:DropDownList>
        <br />
        <asp:Label ID="Label6" runat="server" Text="Origen"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="OrigenDDList" runat="server" OnSelectedIndexChanged="OrigenDDList_SelectedIndexChanged" AutoPostBack="True">
        </asp:DropDownList>
        <br />
        <asp:Label ID="LabelPrecio" runat="server" Text="Precio (ARS)"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="PrecioTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        &nbsp;<asp:Button ID="BtnVolver" runat="server" OnClick="BtnVolver_Click" Text="Volver a Stock" />
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="BotonAceptar" runat="server" OnClick="BotonAceptar_Click" Text="Aceptar" />
        &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="LblResultado" runat="server"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </form>
</body>
</html>
