using System;
using System.Collections.Generic;
using FactoresPrimosUI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ComparadorDeListas.UnitTests
{
    [TestClass]
    public class ComparadorDeListasTests
    {

        [TestMethod]
        public void ComparaBienLaListaDeEnteros1_1_2ConsigoMisma()
        {
            List<int> lista1 = new List<int>();
            lista1.Add(1);
            lista1.Add(1);
            lista1.Add(2);

            List<int> lista2 = new List<int>();
            lista2.Add(1);
            lista2.Add(1);
            lista2.Add(2);

            ComparadorDeListas<int> comparador = new ComparadorDeListas<int>();
            Assert.IsTrue(comparador.SonIguales(lista1, lista2));
        }

        [TestMethod]
        public void CompararLaListaDeEnteros1_1_2Con2_2_1DaFalso()
        {
            List<int> lista1 = new List<int>();
            lista1.Add(1);
            lista1.Add(1);
            lista1.Add(2);

            List<int> lista2 = new List<int>();
            lista2.Add(2);
            lista2.Add(2);
            lista2.Add(1);

            ComparadorDeListas<int> comparador = new ComparadorDeListas<int>();
            Assert.IsFalse(comparador.SonIguales(lista1, lista2));
        }

    }

}

