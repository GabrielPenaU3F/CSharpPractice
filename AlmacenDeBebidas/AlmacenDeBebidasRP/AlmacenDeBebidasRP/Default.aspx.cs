using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlmacenDeBebidasRP
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnStock_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Stock/StockMainPage.aspx");
        }
    }
}