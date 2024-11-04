using ControlVentasKmlMotor.BL;
using ControlVentasKmlMotor.EN;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ControlVentasKmlMotor.PruebasUnitarias
{
    [TestClass]
    public class TipoPagoUnitTest
    {
        TipoPagoBL tpBL = new TipoPagoBL();

        [TestMethod]
        public void T1_Guardar()
        {
            TipoPago tipoPago = new TipoPago();
            tipoPago.Nombre = "CREDITO";
            int resultado = tpBL.Guardar(tipoPago);

            Assert.AreEqual(1, resultado);
        }

        [TestMethod]
        public void T2_Modificar()
        {
            TipoPago tipoPago = tpBL.ObtenerPorId(1);
            tipoPago.Nombre = "dolar";
            int resultado = tpBL.Modificar(tipoPago);

            Assert.AreEqual(1, resultado);
        }

        [TestMethod]
        public void T3_Eliminar()
        {
            TipoPago tipoPago = tpBL.ObtenerPorId(1);
            int resultado = tpBL.Eliminar(tipoPago);
            Assert.AreEqual(1, resultado);
        }

        [TestMethod]
        public void T4_ObtenerPorId()
        {
            TipoPago tipoPago = tpBL.ObtenerPorId(1);

            Assert.AreNotEqual(0, tipoPago.Id);
        }

        [TestMethod]
        public void T5_Buscar()
        {
            List<TipoPago> lista = tpBL.Buscar(new TipoPago { Id = 1 });
            Assert.AreNotEqual(0, lista.Count);
        }
    }
}
