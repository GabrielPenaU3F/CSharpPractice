using AlmacenDeBebidasRP.Core;
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
    public partial class StockMainPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.CargarCategorias();
                this.CargarOrigenes();
            }

        }

        private void CargarOrigenes()
        {
            origenesDDList.DataSource = BusinessDataProvider.ProvideListaDeOrigenes();
            origenesDDList.DataBind();
        }

        private void CargarCategorias()
        {
            categoriasDDList.DataSource = BusinessDataProvider.ProvideListaDeCategorias();
            categoriasDDList.DataBind();
        }


        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscadorDeProductos buscadorDeProductos = this.GenerarBuscadorDeProductos();
            List<Producto> productos = buscadorDeProductos.Buscar();
            List<String> datosDeProductos = new List<String>();
            foreach (Producto p in productos)
            {
                String dato = "ID: " + p.GetIDProducto() + "\tProducto: " + p.GetNombreProducto() + "\tCategoría: " + p.GetCategoria() + "\tOrigen: " + p.GetOrigen();
                if (p.GetOrigen() == "NACIONAL")
                {
                    dato += "\tPrecio: " + p.GetPrecioArs() + " ARS";
                }
                else
                {
                    dato += "\tPrecio: " + p.GetPrecioUss() + " USS";
                }
                dato += "\tCantidad: " + p.GetCantidad();
                datosDeProductos.Add(dato);
            }
            productosDDList.DataSource = datosDeProductos;
            productosDDList.DataBind();
        }

        private BuscadorDeProductos GenerarBuscadorDeProductos()
        {
            BuscadorDeProductos buscadorDeProductos = new BuscadorDeProductos();

            if (buscarPorIdCB.Checked) buscadorDeProductos.AgregarCriterio(new AtributoDeProducto("ID_PRODUCTO", buscarPorIdTextBox.Text, TipoColumna.INT));
            if (buscarPorNombreCB.Checked) buscadorDeProductos.AgregarCriterio(new AtributoDeProducto("NOMBRE", buscarPorNombreTextBox.Text, TipoColumna.STRING));
            if (buscarPorCategoriaCB.Checked) buscadorDeProductos.AgregarCriterio(new AtributoDeProducto("CATEGORIA", categoriasDDList.SelectedValue, TipoColumna.STRING));
            if (buscarPorOrigenCB.Checked) buscadorDeProductos.AgregarCriterio(new AtributoDeProducto("ORIGEN", origenesDDList.SelectedValue, TipoColumna.STRING));

            return buscadorDeProductos;
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Stock/AgregarProducto.aspx");
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Stock/EliminarProducto.aspx");
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Stock/ModificarProducto.aspx");
        }
    }
}