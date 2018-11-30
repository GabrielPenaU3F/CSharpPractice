using AlmacenDeBebidasRP.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlmacenDeBebidasRP.Domain
{
    [Serializable()]
    public class Producto
    {

        private int idProducto;
        private String nombreProducto;
        private String categoria;
        private String origen;
        private double precioArs;
        private Nullable<double> precioUss;
        private int cantidad;

        public Producto(int idProducto, String nombreProducto, String categoria, String origen, double precio, int cantidad)
        {
            this.idProducto = idProducto;
            this.nombreProducto = nombreProducto;
            this.categoria = categoria;
            this.origen = origen;
            if (origen.Equals("NACIONAL"))
            {
                this.precioArs = precio;
                this.precioUss = null;
            }
            else if (origen.Equals("IMPORTADO"))
            {
                this.precioUss = precio;
                this.precioArs = ServiceProvider.ProvideConversionDeDivisasService().ConvertirDolaresAPesos(precio);
            }
            this.cantidad = cantidad;
        }

        internal int GetIDProducto()
        {
            return this.idProducto;
        }

        internal String GetNombreProducto()
        {
            return this.nombreProducto;
        }

        internal String GetCategoria()
        {
            return this.categoria;
        }

        internal String GetOrigen()
        {
            return this.origen;
        }

        internal double GetPrecioArs()
        {
            return this.precioArs;
        }

        internal Nullable<double> GetPrecioUss()
        {
            return this.precioUss;
        }

        internal int GetCantidad()
        {
            return this.cantidad;
        }
    }

}