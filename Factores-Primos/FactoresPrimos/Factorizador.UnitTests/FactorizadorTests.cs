using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;
using FactoresPrimosUI;

namespace FactorizadorTests
{
    [TestClass]
    public class FactorizadorTests
    {

        private Factorizador factorizador;

        [TestInitialize]
        public void InicializarFactorizador()
        {
            this.factorizador = new Factorizador();
        }

        [TestMethod]
        public void El3EsPrimo()
        {
            Assert.IsTrue(this.factorizador.EsPrimo(3));
        }

        [TestMethod]
        public void El25NoEsPrimo()
        {
            Assert.IsFalse(this.factorizador.EsPrimo(25));
        }

        [TestMethod]
        public void El6NoEsPrimo()
        {
            Assert.IsFalse(this.factorizador.EsPrimo(6));
        }

        [TestMethod]
        public void FactorizaBienElUno()
        {
            List<int> factores = this.factorizador.Factorizar(1);
            Assert.IsTrue(factores.Contains(1));
            Assert.AreEqual(1, factores.Count);
        }

        [TestMethod]
        public void FactorizaBienElDos()
        {
            List<int> factores = this.factorizador.Factorizar(2);
            Assert.IsTrue(factores.Contains(2));
            Assert.AreEqual(1, factores.Count);
        }

        [TestMethod]
        public void FactorizaBienElSeis()
        {
            List<int> factores = this.factorizador.Factorizar(6);
            Assert.IsTrue(factores.Contains(2));
            Assert.IsTrue(factores.Contains(3));
            Assert.AreEqual(2, factores.Count);
        }

        [TestMethod]
        public void FactorizaBienElTreinta()
        {
            List<int> factores = this.factorizador.Factorizar(30);
            Assert.IsTrue(factores.Contains(2));
            Assert.IsTrue(factores.Contains(3));
            Assert.IsTrue(factores.Contains(5));
            Assert.AreEqual(3, factores.Count);
        }

        [TestMethod]
        public void FactorizaBienElVeinte()
        {
            List<int> factores = factorizador.Factorizar(20);
            List<int> factoresEsperado = new List<int>();
            factoresEsperado.Add(2);
            factoresEsperado.Add(2);
            factoresEsperado.Add(5);

            ComparadorDeListas<int> comparador = new ComparadorDeListas<int>();

            Assert.IsTrue(comparador.SonIguales(factoresEsperado, factores));

        }

        [TestMethod]
        public void FactorizaBienElVeinticinto()
        {
            List<int> factores = factorizador.Factorizar(25);
            List<int> factoresEsperado = new List<int>();
            factoresEsperado.Add(5);
            factoresEsperado.Add(5);

            ComparadorDeListas<int> comparador = new ComparadorDeListas<int>();

            Assert.IsTrue(comparador.SonIguales(factoresEsperado, factores));

        }


    }

}
