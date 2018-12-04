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
    public partial class AgregarProductoForm : System.Web.UI.Page
    {

        private ProductoDAO dao;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.CargarCategorias();
                this.CargarOrigenes();
            }
        }

        protected void origenDDList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = origenDDList.SelectedItem.Value;
            if (value.Equals("NACIONAL")) LabelPrecio.Text = "Precio (ARS)";
            else LabelPrecio.Text = "Precio (US$)";
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto(Int32.Parse(idTextBox.Text), nombreTextBox.Text, categoriaDDList.SelectedValue, origenDDList.SelectedValue, Double.Parse(precioTextBox.Text), Int32.Parse(cantidadTextBox.Text));
            this.dao = new ProductoDAO();
            if (dao.AgregarProducto(producto)) lblResultado.Text = "Producto agregado con éxito";
            else lblResultado.Text = "El ID ingresado ya está en uso";
        }

        private void CargarOrigenes()
        {
            origenDDList.DataSource = BusinessDataProvider.ProvideListaDeOrigenes();
            origenDDList.DataBind();
        }

        private void CargarCategorias()
        {
            categoriaDDList.DataSource = BusinessDataProvider.ProvideListaDeCategorias();
            categoriaDDList.DataBind();
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Stock/StockMainPage.aspx");
        }

    }
}