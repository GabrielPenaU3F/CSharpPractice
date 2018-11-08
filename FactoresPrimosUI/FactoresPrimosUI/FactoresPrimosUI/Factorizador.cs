using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoresPrimosUI
{

    public class Factorizador
    {
        public List<int> Factorizar(int numero)
        {
            List<int> factoresPrimos = new List<int>();

            if (this.EsPrimo(numero)) factoresPrimos.Add(numero);
            else
            {
                int mayorDivisorEntero = this.BuscarMayorDivisor(numero);

                int cociente = numero / mayorDivisorEntero;

                if (this.EsPrimo(cociente)) factoresPrimos.Add(cociente);
                else
                {
                    List<int> factoresPrimosDelCociente = this.Factorizar(cociente);
                    this.AgregarFactores(factoresPrimos, factoresPrimosDelCociente);
                }

                if (this.EsPrimo(mayorDivisorEntero)) factoresPrimos.Add(mayorDivisorEntero);
                else
                {
                    List<int> factoresPrimosDelDivisor = this.Factorizar(mayorDivisorEntero);
                    this.AgregarFactores(factoresPrimos, factoresPrimosDelDivisor);
                }

            }
            return factoresPrimos;

        }

        private int BuscarMayorDivisor(int numero)
        {
            for (int i=numero-1; i>1; i--)
            {
                if (EsDivisiblePor(numero, i)) return i;
            }
            return 1;
        }

        private List<int> AgregarFactores(List<int> listaFactores, List<int> nuevosFactores)
        {
            foreach(int factor in nuevosFactores) listaFactores.Add(factor);
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

            if (cantidadDivisores < 2) return true;
            else return false;
        }
    }
}