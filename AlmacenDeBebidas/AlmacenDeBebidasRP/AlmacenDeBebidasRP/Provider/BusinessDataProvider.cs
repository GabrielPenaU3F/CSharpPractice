using AlmacenDeBebidasRP.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlmacenDeBebidasRP.Provider
{
    public static class BusinessDataProvider
    {

        private static List<String> listaDeCategorias;
        private static List<String> listaDeOrigenes;

        public static List<String> ProvideListaDeCategorias()
        {
            if (listaDeCategorias != null) return listaDeCategorias;
            listaDeCategorias = new List<String>();
            listaDeCategorias.Add("CERVEZAS");
            listaDeCategorias.Add("VINOS");
            listaDeCategorias.Add("LICORES");
            listaDeCategorias.Add("WHISKIES");
            listaDeCategorias.Add("BEBIDAS_DESTILADAS");
            listaDeCategorias.Add("OTROS");
            return listaDeCategorias;
        }

        public static List<String> ProvideListaDeOrigenes()
        {
            if (listaDeOrigenes != null) return listaDeOrigenes;
            listaDeOrigenes = new List<String>();
            listaDeOrigenes.Add("NACIONAL");
            listaDeOrigenes.Add("IMPORTADO");
            return listaDeOrigenes;
        }

    }
}