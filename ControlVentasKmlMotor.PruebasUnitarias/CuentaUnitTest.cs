using ControlVentasKmlMotor.BL;
using ControlVentasKmlMotor.EN;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ControlVentasKmlMotor.PruebasUnitarias
{
    [TestClass]
    public class CuentaUnitTest
    {
        CuentaBL cuBL = new CuentaBL();

        //[TestMethod]
        //public void T1_Guardar()
        //{
        //    Cuenta cuenta = new Cuenta();
        //    cuenta.NoFactura = 1 ;
        //    cuenta.CantidadMeses = 4 ;
        //    cuenta.Total = 120M;
        //    cuenta.Balance = 10M;
        //    cuenta.BalancePendiente = 110M;
        //    cuenta.Estatus = 2;
        //    int resultado = cuBL.Guardar(cuenta);

        //    Assert.AreEqual(1, resultado);
        //}

        [TestMethod]
        public void T2_Modificar()
        {
            Cuenta cuenta = cuBL.ObtenerPorId(1);
            cuenta.NoFactura = 2;
            cuenta.CantidadMeses = 5;
            cuenta.Total = 150M;
            cuenta.Balance = 20M;
            cuenta.BalancePendiente = 110M;
            cuenta.Estatus = 3;
            int resultado = cuBL.Modificar(cuenta);

            Assert.AreEqual(0, resultado);
        }

        [TestMethod]
        public void T3_Eliminar()
        {
            Cuenta cuenta = cuBL.ObtenerPorId(1);
            int resultado = cuBL.Eliminar(cuenta);
            Assert.AreEqual(0, resultado);
        }

        [TestMethod]
        public void T4_ObtenerPorId()
        {
           Cuenta cuenta = cuBL.ObtenerPorId(1);

            Assert.AreNotEqual(1, cuenta.Id);
        }

        [TestMethod]
        public void T5_Buscar()
        {
            List<Cuenta> lista = cuBL.Buscar(new Cuenta { Id = 1 });
            Assert.AreNotEqual(1, lista.Count);
        }

    }
}
