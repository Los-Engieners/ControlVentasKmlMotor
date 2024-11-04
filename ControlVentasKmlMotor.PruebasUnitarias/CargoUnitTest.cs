using ControlVentasKmlMotor.BL;
using ControlVentasKmlMotor.EN;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ControlVentasKmlMotor.PruebasUnitarias
{
    [TestClass]
    public class CargoUnitTest
    {
        CargoBL carBL = new CargoBL();

        [TestMethod]
        public void T1_Guardar()
        {
            Cargo cargo = new Cargo();
            cargo.Nombre = "Administrador";
            int resultado = carBL.Guardar(cargo);

            Assert.AreEqual(1, resultado);
        }

        [TestMethod]
        public void T2_Modificar()
        {
            Cargo cargo = carBL.ObtenerPorId(1);
            cargo.Nombre = "Gerente";
            int resultado = carBL.Modificar(cargo);

            Assert.AreEqual(1, resultado);
        }

        [TestMethod]
        public void T3_Eliminar()
        {
            Cargo cargo = carBL.ObtenerPorId(1);
            int resultado = carBL.Modificar(cargo);

            Assert.AreEqual(1, resultado);
        }


        [TestMethod]
        public void T5_Buscar()
        {
            List<Cargo> lista = carBL.Buscar(new Cargo { Nombre = "Administrador" });

            Assert.AreNotEqual(0, lista.Count);
        }
    }
}
