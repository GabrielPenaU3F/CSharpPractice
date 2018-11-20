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
            this.DefinirEstadoDelBotonBuscar();
            this.DefinirEstadoDeLosControlesDeBusqueda();

        }

        private void DefinirEstadoDeLosControlesDeBusqueda()
        {
            if (BuscarPorIdCB.Checked) BuscarPorIdTextBox.Enabled = true;
            else BuscarPorIdTextBox.Enabled = false;

            if (BuscarPorNombreCB.Checked) BuscarPorNombreTextBox.Enabled = true;
            else BuscarPorNombreTextBox.Enabled = false;

            if (BuscarPorCategoriaCB.Checked) CategoriasDDList.Enabled = true;
            else CategoriasDDList.Enabled = false;

            if (BuscarPorOrigenCB.Checked) OrigenesDDList.Enabled = true;
            else OrigenesDDList.Enabled = false;
        }

        private void DefinirEstadoDelBotonBuscar()
        {
            if (CondicionDeBusquedaElegida()) btnBuscar.Enabled = true;
            else btnBuscar.Enabled = false;
        }

        private void CargarOrigenes()
        {
            OrigenesDDList.DataSource = BusinessDataProvider.ProvideListaDeOrigenes();
            OrigenesDDList.DataBind();
        }

        private void CargarCategorias()
        {
            CategoriasDDList.DataSource = BusinessDataProvider.ProvideListaDeCategorias();
            CategoriasDDList.DataBind();
        }

        private bool CondicionDeBusquedaElegida()
        {
            return (BuscarPorIdCB.Checked || BuscarPorNombreCB.Checked || BuscarPorCategoriaCB.Checked || BuscarPorOrigenCB.Checked); 
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
                datosDeProductos.Add(dato);
            }
            ProductosDDList.DataSource = datosDeProductos;
            ProductosDDList.DataBind();
        }

        private BuscadorDeProductos GenerarBuscadorDeProductos()
        {
            BuscadorDeProductos buscadorDeProductos = new BuscadorDeProductos();

            if (BuscarPorIdCB.Checked) buscadorDeProductos.AgregarCriterio(new AtributoDeProducto("ID_PRODUCTO", BuscarPorIdTextBox.Text, TipoColumna.INT));
            if (BuscarPorNombreCB.Checked) buscadorDeProductos.AgregarCriterio(new AtributoDeProducto("NOMBRE", BuscarPorNombreTextBox.Text, TipoColumna.STRING));
            if (BuscarPorCategoriaCB.Checked) buscadorDeProductos.AgregarCriterio(new AtributoDeProducto("CATEGORIA", CategoriasDDList.SelectedValue, TipoColumna.STRING));
            if (BuscarPorOrigenCB.Checked) buscadorDeProductos.AgregarCriterio(new AtributoDeProducto("ORIGEN", OrigenesDDList.SelectedValue, TipoColumna.STRING));

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