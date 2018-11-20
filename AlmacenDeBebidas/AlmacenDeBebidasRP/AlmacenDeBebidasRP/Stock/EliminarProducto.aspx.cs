using AlmacenDeBebidasRP.DB.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlmacenDeBebidasRP.Stock
{
    public partial class EliminarProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            ProductoDAO dao = new ProductoDAO();
            if (dao.EliminarProducto(int.Parse(IDTextBox.Text))) LblResultado.Text = "Eliminado con exito";
            else LblResultado.Text = "El producto solicitado no existe";
        }

        protected void BtnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Stock/StockMainPage.aspx");
        }
    }
}