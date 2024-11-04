using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
//Referencias
using ControlVentasKmlMotor.BL;
using ControlVentasKmlMotor.EN;
using System.Collections.Generic;

namespace ControlVentasKmlMotor.PruebasUnitarias
{
    [TestClass]
    public class TipoAutosUnitTest
    {
        TipoAutosBL tipBL = new TipoAutosBL();

        [TestMethod]
        public void T1_Guardar()
        {
            TipoAutos tipoAutos = new TipoAutos();
            tipoAutos.Nombre = "Cuatro por cuatro";
            int resultado = tipBL.Guardar(tipoAutos);

            Assert.AreEqual(1, resultado);
        }

        [TestMethod]

        public void T2_Eliminar()
        {
            TipoAutos tipoAutos = tipBL.ObtenerPorId(3);
            int resultado = tipBL.Eliminar(tipoAutos);

            Assert.AreEqual(1, resultado);
        }
        [TestMethod]
        public void T3_Modificar()
        {
            TipoAutos tipoAutos = tipBL.ObtenerPorId(1);
            tipoAutos.Nombre = "Sedan";
            int resultado = tipBL.Modificar(tipoAutos);

            Assert.AreEqual(1, resultado);
        }
        [TestMethod]
        public void T4_ObtenerPorId()
        {
            TipoAutos tipoAutos = tipBL.ObtenerPorId(1);

            Assert.AreNotEqual(0, tipoAutos.Id);
        }

        [TestMethod]
        public void T4_Buscar()
        {
            List<TipoAutos> lista = tipBL.Buscar(new TipoAutos { Nombre = "Camioneta" });

            Assert.AreNotEqual(0, lista.Count);
        }
    }
}


