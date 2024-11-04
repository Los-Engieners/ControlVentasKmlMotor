using ControlVentasKmlMotor.BL;
using ControlVentasKmlMotor.EN;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ControlVentasKmlMotor.PruebasUnitarias
{
    [TestClass]
    public class PermisoUnitTest
    {
       PermisoBL perBL = new PermisoBL();

        [TestMethod]
        public void T1_Guardar()
        {
            Permiso permiso = new Permiso();
            permiso.IdCargo = 1;
            permiso.IdModulo = 1;
            int resultado = perBL.Guardar(permiso);

            Assert.AreEqual(1, resultado);
        }

        [TestMethod]
        public void T2_Modificar()
        {
            Permiso permiso = perBL.ObtenerPorId(1);
            permiso.IdCargo = 2;
            int resultado = perBL.Modificar(permiso);

            Assert.AreEqual(1, resultado);
        }

        public void T3_Eliminar()
        {
            Permiso permiso = perBL.ObtenerPorId(1);
            int resultado = perBL.Eliminar(permiso);
            Assert.AreEqual(1, resultado);
        }
        [TestMethod]
        public void T4_ObtenerPorId()
        {
            Permiso permiso = perBL.ObtenerPorId(1);

            Assert.AreNotEqual(0, permiso.Id);
        }

        [TestMethod]
        public void T5_Buscar()
        {
            List<Permiso> lista = perBL.Buscar(new Permiso { Id = 1 });

            Assert.AreNotEqual(0, lista.Count);
        }
    }
}
