using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlmacenDeBebidasRP.Services
{
    public class ConversionDeDivisasService
    {

        //Actualizado al 12/11/2018
        private double valorPeso = 0.028; 

        public double ConvertirDolaresAPesos(double precioDolares)
        {
            return precioDolares * valorPeso;
        }
    }
}