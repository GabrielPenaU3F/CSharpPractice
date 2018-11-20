using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AlmacenDeBebidasRP.DB.DAO;
using AlmacenDeBebidasRP.Domain;

namespace AlmacenDeBebidasRP.Core
{
    public class BuscadorDeProductos
    {

        private List<AtributoDeProducto> criterios;

        public BuscadorDeProductos()
        {
            this.criterios = new List<AtributoDeProducto>();
        }

        public void AgregarCriterio(AtributoDeProducto criterio)
        {
            this.criterios.Add(criterio);
        }

        public List<Producto> Buscar()
        {
            ProductoDAO dao = new ProductoDAO();
            String where = "";
            foreach (AtributoDeProducto criterio in this.criterios)
            {
                where += (criterio.GetNombreCriterio() + "=");
                if (criterio.GetTipo() == TipoColumna.STRING)
                {
                    where += ("'" + criterio.GetContenido() + "'");
                }
                else
                {
                    where += (criterio.GetContenido());
                }
                where += " AND ";
            }
            where = where.Substring(0, where.Length - 5);

            return dao.BuscarProductos(where);
        }
    }
}