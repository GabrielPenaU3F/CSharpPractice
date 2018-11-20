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
                CategoriasDDList.DataSource = BusinessDataProvider.ProvideListaDeCategorias();
                OrigenesDDList.DataSource = BusinessDataProvider.ProvideListaDeOrigenes();

                CategoriasDDList.DataBind();
                OrigenesDDList.DataBind();

                CategoriasDDList.Enabled = false;
                OrigenesDDList.Enabled = false;

                CategoriaCheckBox.Checked = false;
                OrigenCheckBox.Checked = false;

                ViewState["Verificado"] = false;
                BtnModificar.Enabled = false;
            }
            else
            {
                if (CategoriaCheckBox.Checked) CategoriasDDList.Enabled = true;
                else CategoriasDDList.Enabled = false;
                if (OrigenCheckBox.Checked)
                {
                    OrigenesDDList.Enabled = true;
                    if (OrigenesDDList.SelectedValue == "NACIONAL") LblNuevoPrecio.Text = "Nuevo precio (ARS)";
                    else LblNuevoPrecio.Text = "Nuevo precio (USS)";
                }
                else OrigenesDDList.Enabled = false;

            }
        }

        protected void BtnModificar_Click(object sender, EventArgs e)
        {
            if (this.ValidarCampos())
            {
                Producto productoActual = (Producto)ViewState["ProductoBuscado"];

                int idProducto = int.Parse(IDTextBox.Text);
                string nombre, categoria, origen;
                double precio = 0;

                if (NuevoNombreTextBox.Text != "") nombre = NuevoNombreTextBox.Text;
                else nombre = productoActual.GetNombreProducto();

                if (CategoriaCheckBox.Checked) categoria = CategoriasDDList.SelectedValue;
                else categoria = productoActual.GetCategoria();

                if (OrigenCheckBox.Checked) origen = OrigenesDDList.SelectedValue;
                else origen = productoActual.GetOrigen();

                if (NuevoPrecioTextBox.Text != "") precio = double.Parse(NuevoPrecioTextBox.Text);
                else if (productoActual.GetOrigen() == "NACIONAL") precio = productoActual.GetPrecioArs();
                else if (productoActual.GetOrigen() == "IMPORTADO") precio = (double)productoActual.GetPrecioUss();

                Producto nuevoProducto = new Producto(idProducto, nombre, categoria, origen, precio);

                ProductoDAO dao = new ProductoDAO();
                if (dao.ModificarProducto(idProducto, nuevoProducto)) LblResultado.Text = "Producto modificado con éxito";

            }
            else LblResultado.Text = "Campo inválido o faltante";
            
        }

        private bool ValidarCampos()
        {
            return ((NuevoNombreTextBox.Text != "") || (NuevoPrecioTextBox.Text != "")) && IDTextBox.Text != "";
        }

        protected void BtnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Stock/StockMainPage.aspx");
        }

        protected void BtnVerificar_Click(object sender, EventArgs e)
        {
            if (IDTextBox.Text != "") {
                ProductoDAO dao = new ProductoDAO();
                List<Producto> productos = dao.BuscarProductos("ID_PRODUCTO=" + IDTextBox.Text);
                if (productos.Count == 1)
                {
                    ViewState["Verificado"] = true;
                    BtnModificar.Enabled = true;
                    ViewState["ProductoBuscado"] = productos[0];
                    if (productos[0].GetOrigen() == "NACIONAL") LblNuevoPrecio.Text = "Nuevo precio (ARS)";
                    else LblNuevoPrecio.Text = "Nuevo precio (USS)";
                    LblResultado.Text = "";
                }
                else
                {
                    LblResultado.Text = "El producto buscado es inexistente";
                    ViewState["Verificado"] = false;
                }
            }
        }
    }
}