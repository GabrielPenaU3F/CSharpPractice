using FactoresPrimos;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;

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
        public void El6NoEsPrimo()
        {
            Assert.IsFalse(this.factorizador.EsPrimo(6));
        }

        [TestMethod]
        public void FactorizaBienElUno()
        {
            ArrayList factores = this.factorizador.Factorizar(1);
            Assert.IsTrue(factores.Contains(1));
            Assert.AreEqual(1, factores.Count);
        }

        [TestMethod]
        public void FactorizaBienElDos()
        {
            ArrayList factores = this.factorizador.Factorizar(2);
            Assert.IsTrue(factores.Contains(2));
            Assert.AreEqual(1, factores.Count);
        }

        [TestMethod]
        public void FactorizaBienElSeis()
        {
            ArrayList factores = this.factorizador.Factorizar(6);
            Assert.IsTrue(factores.Contains(2));
            Assert.IsTrue(factores.Contains(3));
            Assert.AreEqual(2, factores.Count);
        }

        [TestMethod]
        public void FactorizaBienElTreinta()
        {
            ArrayList factores = this.factorizador.Factorizar(30);
            Assert.IsTrue(factores.Contains(2));
            Assert.IsTrue(factores.Contains(3));
            Assert.IsTrue(factores.Contains(5));
            Assert.AreEqual(3, factores.Count);
        }

    }

}
