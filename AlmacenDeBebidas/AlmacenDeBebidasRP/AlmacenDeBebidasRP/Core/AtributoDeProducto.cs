using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlmacenDeBebidasRP.Core
{
    public class AtributoDeProducto
    {

        private String nombreAtributo;
        private String contenido;
        private TipoColumna tipo;

        public AtributoDeProducto(String nombreAtributo, String contenido, TipoColumna tipo)
        {
            this.nombreAtributo = nombreAtributo;
            this.contenido = contenido;
            this.tipo = tipo;
        }

        public String GetNombreCriterio() { return this.nombreAtributo; }

        public String GetContenido() { return this.contenido; }

        public TipoColumna GetTipo() { return this.tipo; }

    }
}