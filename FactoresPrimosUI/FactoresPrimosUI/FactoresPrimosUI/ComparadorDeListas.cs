using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoresPrimosUI
{
    public class ComparadorDeListas<T>
    {

        public bool SonIguales(List<T> lista1, List<T> lista2)
        {
            if (lista1.Count() != lista2.Count()) return false;
            else
            {
                for (int i=0; i < lista1.Count(); i++) {
                    if (!lista1[i].Equals(lista2[i])) return false;
                }
                return true;
            }
        }

    }
}
