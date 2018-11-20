using AlmacenDeBebidasRP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlmacenDeBebidasRP.Provider
{
    public static class ServiceProvider
    {

        private static ConversionDeDivisasService conversionDeDivisasService;

        public static ConversionDeDivisasService ProvideConversionDeDivisasService()
        {
            if (conversionDeDivisasService != null) return conversionDeDivisasService;

            conversionDeDivisasService = new ConversionDeDivisasService();
            return conversionDeDivisasService;
        }

    }
}