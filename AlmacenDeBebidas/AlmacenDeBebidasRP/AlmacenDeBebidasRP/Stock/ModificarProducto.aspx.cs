using AlmacenDeBebidasRP.Core;
using AlmacenDeBebidasRP.DB.DAO;
using AlmacenDeBebidasRP.Domain;
using AlmacenDeBebidasRP.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlmacenDeBebidasRP.Stock
{
    public partial class ModificarProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                categoriasDDList.DataSource = BusinessDataProvider.ProvideListaDeCategorias();
                origenesDDList.DataSource = BusinessDataProvider.ProvideListaDeOrigenes();

                categoriasDDList.DataBind();
                origenesDDList.DataBind();

                categoriasDDList.Enabled = false;
                origenesDDList.Enabled = false;

                categoriaCheckBox.Checked = false;
                origenCheckBox.Checked = false;

                ViewState["Verificado"] = false;
                btnModificar.Enabled = false;
            }
            else
            {
                if (categoriaCheckBox.Checked) categoriasDDList.Enabled = true;
                else categoriasDDList.Enabled = false;
                if (origenCheckBox.Checked)
                {
                    origenesDDList.Enabled = true;
                    if (origenesDDList.SelectedValue == "NACIONAL") lblNuevoPrecio.Text = "Nuevo precio (ARS)";
                    else lblNuevoPrecio.Text = "Nuevo precio (USS)";
                }
                else origenesDDList.Enabled = false;

            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.ValidarCampos())
            {
                Producto productoActual = (Producto)ViewState["ProductoBuscado"];

                int idProducto = int.Parse(idTextBox.Text);
                string nombre, categoria, origen;
                double precio = 0;
                int cantidad = 0;

                if (nuevoNombreTextBox.Text != "") nombre = nuevoNombreTextBox.Text;
                else nombre = productoActual.GetNombreProducto();

                if (categoriaCheckBox.Checked) categoria = categoriasDDList.SelectedValue;
                else categoria = productoActual.GetCategoria();

                if (origenCheckBox.Checked) origen = origenesDDList.SelectedValue;
                else origen = productoActual.GetOrigen();

                if (nuevoPrecioTextBox.Text != "") precio = double.Parse(nuevoPrecioTextBox.Text);
                else if (productoActual.GetOrigen() == "NACIONAL") precio = productoActual.GetPrecioArs();
                else if (productoActual.GetOrigen() == "IMPORTADO") precio = (double)productoActual.GetPrecioUss();

                if (nuevaCantidadTextBox.Text != "") cantidad = int.Parse(nuevaCantidadTextBox.Text);
                else cantidad = productoActual.GetCantidad();

                Producto nuevoProducto = new Producto(idProducto, nombre, categoria, origen, precio, cantidad);

                ProductoDAO dao = new ProductoDAO();
                if (dao.ModificarProducto(idProducto, nuevoProducto)) lblResultado.Text = "Producto modificado con éxito";

            }
            else lblResultado.Text = "Campo inválido o faltante";
            
        }

        private bool ValidarCampos()
        {
            return ((nuevoNombreTextBox.Text != "") || (nuevoPrecioTextBox.Text != "") || (nuevaCantidadTextBox.Text != "")) && idTextBox.Text != "";
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Stock/StockMainPage.aspx");
        }

        protected void btnVerificar_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text != "") {
                ProductoDAO dao = new ProductoDAO();
                List<Producto> productos = dao.BuscarProductos("ID_PRODUCTO=" + idTextBox.Text);
                if (productos.Count == 1)
                {
                    ViewState["Verificado"] = true;
                    btnModificar.Enabled = true;
                    ViewState["ProductoBuscado"] = productos[0];
                    if (productos[0].GetOrigen() == "NACIONAL") lblNuevoPrecio.Text = "Nuevo precio (ARS)";
                    else lblNuevoPrecio.Text = "Nuevo precio (USS)";
                    lblResultado.Text = "";
                }
                else
                {
                    lblResultado.Text = "El producto buscado es inexistente";
                    ViewState["Verificado"] = false;
                }
            }
        }

    }
}