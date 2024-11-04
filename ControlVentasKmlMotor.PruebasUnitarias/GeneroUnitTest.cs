using ControlVentasKmlMotor.BL;
using ControlVentasKmlMotor.EN;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ControlVentasKmlMotor.PruebasUnitarias
{
    [TestClass]
    public class GeneroUnitTest
    {

        GeneroBL genBL = new GeneroBL();

        [TestMethod]
        public void T1_Guardar()
        {
            Genero genero = new Genero();
            genero.Nombre = "Masculino";
            int resultado = genBL.Guardar(genero);

            Assert.AreEqual(1, resultado);
        }

        [TestMethod]
        public void T2_Buscar()
        {
            List<Genero> lista = genBL.Buscar(new Genero { Nombre = "Masculino" });

            Assert.AreNotEqual(0, lista.Count);
        }
    }
}
