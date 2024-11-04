using ControlVentasKmlMotor.BL;
using ControlVentasKmlMotor.EN;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ControlVentasKmlMotor.PruebasUnitarias
{
    [TestClass]
    public class ModuloUnitTest
    {
        ModuloBL modBL = new ModuloBL();

        [TestMethod]
        public void T1_Guardar()
        {
            Modulo modulo = new Modulo();
            modulo.Nombre = "menuUsuario";
            int resultado = modBL.Guardar(modulo);

            Assert.AreEqual(1, resultado);
        }

        [TestMethod]
        public void T2_Modificar()
        {
            Modulo modulo = modBL.ObtenerPorId(1);
            modulo.Nombre = "menuCliente";
            int resultado = modBL.Modificar(modulo);

            Assert.AreEqual(1, resultado);
        }

        [TestMethod]
        public void T3_Eliminar()
        {
            Modulo modulo = modBL.ObtenerPorId(1);
            int resultado = modBL.Modificar(modulo);

            Assert.AreEqual(1, resultado);
        }


        [TestMethod]
        public void T5_Buscar()
        {
            List<Modulo> lista = modBL.Buscar(new Modulo { Nombre = "menuCliente" });

            Assert.AreEqual(1, lista.Count);
        }
    }
}
