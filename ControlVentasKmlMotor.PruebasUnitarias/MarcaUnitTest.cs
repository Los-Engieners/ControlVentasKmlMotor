using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
//Referencias
using ControlVentasKmlMotor.BL;
using ControlVentasKmlMotor.EN;
using System.Collections.Generic;


namespace ControlVentasKmlMotor.PruebasUnitarias
{
    [TestClass]
    public class MarcaUnitTest
    {
        MarcaBL marBL = new MarcaBL();

        [TestMethod]
        public void T1_Guardar()
        {
            Marca marca = new Marca();
            marca.Nombre = "Toyota2621";
            int resultado = marBL.Guardar(marca);

            Assert.AreEqual(1, resultado);
        }

        [TestMethod]

        public void T2_Eliminar()
        {
            Marca marca = marBL.ObtenerPorId(1);
            int resultado = marBL.Eliminar(marca);

            Assert.AreEqual(1, resultado);
        }
        [TestMethod]
        public void T3_Modificar()
        {
            Marca marca = marBL.ObtenerPorId(1);
            marca.Nombre = "Kia";
            int resultado = marBL.Modificar(marca);

            Assert.AreEqual(1, resultado);
        }
        [TestMethod]
        public void T4_ObtenerPorId()
        {
            Marca marca = marBL.ObtenerPorId(1);

            Assert.AreNotEqual(0, marca.Id);
        }

        [TestMethod]
        public void T4_Buscar()
        {
            List<Marca> lista = marBL.Buscar(new Marca { Nombre = "Toyota" });

            Assert.AreNotEqual(0, lista.Count);
        }
    }
}
