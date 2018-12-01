<%@ Page Title="Stock" Language="C#" AutoEventWireup="true" CodeBehind="StockMainPage.aspx.cs" Inherits="AlmacenDeBebidasRP.Stock.StockMainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <title>Gestor de stock</title>
    <script language="javascript" type="text/javascript">

        function validarBusqueda() {
            // Se inicializan validos, si el checkbox esta marcado se verifican
            var validacionId = true;
            var validacionNombre = true;
            if (document.getElementById("buscarPorIdCB").checked) validacionId = validarId();
            if (document.getElementById("buscarPorNombreCB").checked) validacionNombre = validarNombre();
            return validacionId && validacionNombre;
        }

        function validarId() {
            if (document.getElementById("buscarPorIdTextBox").value == "") {
                alert("Introduzca un id");
                return false;
            } else if (!((document.getElementById("buscarPorIdTextBox").value) == parseInt(document.getElementById("buscarPorIdTextBox").value))) {
                alert("El id debe ser un número entero");
                return false;
            }
            return true;
        }

        function validarNombre() {
            if (document.getElementById("buscarPorNombreTextBox").value == "") {
                alert("Introduzca un nombre");
                return false;
            }
            return true;
        }

        function validarControlesDeBusqueda() {
            validarBotonBuscar();
            verificarHabilitacionDelTextBoxDeId();
            verificarHabilitacionDelTextBoxDeNombre();
            verificarHabilitacionDeLaDDListDeCategorias();
            verificarHabilitacionDeLaDDListDeOrigenes();
        }

        function validarBotonBuscar() {
            if (condicionDeBusquedaElegida()) document.getElementById("btnBuscar").disabled = false;
            else document.getElementById("btnBuscar").disabled = true;
        }

        function condicionDeBusquedaElegida() {
            return (document.getElementById("buscarPorIdCB").checked || document.getElementById("buscarPorNombreCB").checked || document.getElementById("buscarPorCategoriaCB").checked || document.getElementById("buscarPorOrigenCB").checked); 
        }

        function verificarHabilitacionDelTextBoxDeId() {
            if (document.getElementById("buscarPorIdCB").checked) document.getElementById("buscarPorIdTextBox").disabled = false;
            else document.getElementById("buscarPorIdTextBox").disabled = true;
        }

        function verificarHabilitacionDelTextBoxDeNombre() {
            if (document.getElementById("buscarPorNombreCB").checked) document.getElementById("buscarPorNombreTextBox").disabled = false;
            else document.getElementById("buscarPorNombreTextBox").disabled = true;
        }

        function verificarHabilitacionDeLaDDListDeCategorias() {
            if (document.getElementById("buscarPorCategoriaCB").checked) document.getElementById("categoriasDDList").disabled = false;
            else document.getElementById("categoriasDDList").disabled = true;
        }

        function verificarHabilitacionDeLaDDListDeOrigenes() {
            if (document.getElementById("buscarPorOrigenCB").checked) document.getElementById("origenesDDList").disabled = false;
            else document.getElementById("origenesDDList").disabled = true;
        }
        
    </script>

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
        <asp:Button ID="btnBuscar" runat="server" EnableTheming="False" OnClick="btnBuscar_Click" Text="Buscar producto" OnClientClick="return validarBusqueda();" disabled="true" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="Productos"></asp:Label>
&nbsp;
        <asp:DropDownList ID="productosDDList" runat="server" Height="29px" Width="247px">
        </asp:DropDownList>
        <br />
        <asp:CheckBox ID="buscarPorIdCB" runat="server" onchange="validarControlesDeBusqueda()" Text="Por ID" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="buscarPorIdTextBox" runat="server" disabled="true"></asp:TextBox>
        <br />
        <asp:CheckBox ID="buscarPorNombreCB" runat="server" onchange="validarControlesDeBusqueda()" Text="Por nombre" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="buscarPorNombreTextBox" runat="server" disabled="true"></asp:TextBox>
        <br />
        <asp:CheckBox ID="buscarPorCategoriaCB" runat="server" onchange="validarControlesDeBusqueda()" Text="Por categoría" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="categoriasDDList" runat="server" disabled="true">
        </asp:DropDownList>
        <br />
        <asp:CheckBox ID="buscarPorOrigenCB" runat="server" onchange="validarControlesDeBusqueda()" Text="Por origen" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="origenesDDList" runat="server" disabled="true">
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <br />
    </form>
</body>
</html>
