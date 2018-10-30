using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoresPrimos
{

    class Program { 

        static void Main(string[] args)
        {
            Console.WriteLine("Factores primos \n");
            while (true)
            {
                Console.WriteLine("Introduzca un número entero");
                int numero = int.Parse(Console.ReadLine());
                Factorizador factorizador = new Factorizador();
                ArrayList factoresPrimos = factorizador.Factorizar(numero);
                string stringFactores = EscribirFactores(factoresPrimos);
                Console.WriteLine(numero.ToString() + " = " + stringFactores);
                Console.WriteLine("\n\n");
            }
        }

        private static string EscribirFactores(ArrayList factoresPrimos)
        {
            string stringFactores = "";
            foreach (int factor in factoresPrimos)
            {
                stringFactores += (factor.ToString() + "\t");
            }
            return stringFactores;
        }

    }

}
