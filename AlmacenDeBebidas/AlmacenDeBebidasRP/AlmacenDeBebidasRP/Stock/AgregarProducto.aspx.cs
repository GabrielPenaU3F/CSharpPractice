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

        protected void OrigenDDList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = OrigenDDList.SelectedItem.Value;
            if (value.Equals("NACIONAL")) LabelPrecio.Text = "Precio (ARS)";
            else LabelPrecio.Text = "Precio (US$)";
        }

        protected void BotonAceptar_Click(object sender, EventArgs e)
        {
            if (this.ValidarCampos() == false)
            {
                LblResultado.Text = "Campo invalido o faltante";
            }
            else
            {
                Producto producto = new Producto(Int32.Parse(IDTextBox.Text), NombreTextBox.Text, CategoriaDDList.SelectedValue, OrigenDDList.SelectedValue, Double.Parse(PrecioTextBox.Text));
                this.dao = new ProductoDAO();
                if (dao.AgregarProducto(producto)) LblResultado.Text = "Producto agregado con éxito";
                else LblResultado.Text = "El ID ingresado ya está en uso";
            }
        }

        private bool ValidarCampos()
        {
            return (NombreTextBox.Text != "") && (PrecioTextBox.Text != "");
        }

        private void CargarOrigenes()
        {
            OrigenDDList.DataSource = BusinessDataProvider.ProvideListaDeOrigenes();
            OrigenDDList.DataBind();
        }

        private void CargarCategorias()
        {
            CategoriaDDList.DataSource = BusinessDataProvider.ProvideListaDeCategorias();
            CategoriaDDList.DataBind();
        }

        protected void BtnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Stock/StockMainPage.aspx");
        }
    }
}