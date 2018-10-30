using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoresPrimos
{

    public class Factorizador
    {
        public ArrayList Factorizar(int numero)
        {
            ArrayList factoresPrimos = new ArrayList();

            if (this.EsPrimo(numero)) factoresPrimos.Add(numero);
            else
            {
                for (int i = numero - 1; i > 1; i--)
                {
                    if (EsDivisiblePor(numero, i))
                    {

                        int cociente = numero / i;

                        if (!factoresPrimos.Contains(i))
                        {
                            if (EsPrimo(i)) factoresPrimos.Add(i);
                            else factoresPrimos = agregarFactores(factoresPrimos, this.Factorizar(i));
                        }

                        if (!factoresPrimos.Contains(cociente))
                        {
                            if (EsPrimo(cociente)) factoresPrimos.Add(cociente);
                            else factoresPrimos = agregarFactores(factoresPrimos, this.Factorizar(cociente));
                        }

                    }
                }
            }
            return factoresPrimos;

        }

        private ArrayList agregarFactores(ArrayList listaFactores, ArrayList nuevosFactores)
        {
            foreach(int factor in nuevosFactores)
            {
                if (!listaFactores.Contains(factor)) listaFactores.Add(factor);
            }
            return listaFactores;
        }

        private static bool EsDivisiblePor(int numero, int i)
        {
            return numero % i == 0;
        }

        public bool EsPrimo(int numero)
        {
            int cantidadDivisores = 0;

            for (int i = 1; i < numero; i++)
            {
                if (numero % i == 0) cantidadDivisores++;
            }

            if (cantidadDivisores <= 2) return true;
            else return false;
        }
    }
}