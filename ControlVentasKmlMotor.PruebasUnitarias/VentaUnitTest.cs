using ControlVentasKmlMotor.BL;
using ControlVentasKmlMotor.EN;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ControlVentasKmlMotor.PruebasUnitarias
{
    [TestClass]
    public class VentaUnitTest
    {
        VentaBL ventaBL = new VentaBL();

        [TestMethod]
        public void T1_Guardar()
        {
            Venta venta = new Venta();
            venta.NoFactura = 3;
            venta.IdCliente = 1;
            venta.IdEmpleado = 5;
            venta.IdVehiculo = 1;
            venta.IdSucursal = 1;
            venta.IdTipoPago = 1;
            venta.FechaHora = new DateTime(1990, 3, 3);
            venta.Precio = 16000.00M;
            venta.Total = 16500.00M;
            venta.Estatus = 2;
            venta.Estado = 1;
            int resultado = ventaBL.Guardar(venta);

            Assert.AreEqual(1, resultado);
        }

        [TestMethod]
        public void T2_Modificar()
        {
            Venta venta = ventaBL.ObtenerPorId(1);
            venta.IdSucursal = 2;
            venta.IdTipoPago = 1;
            venta.Estatus = 1;
            int resultado = ventaBL.Modificar(venta);

            Assert.AreEqual(1, resultado);
        }

        [TestMethod]
        public void T3_Eliminar()
        {
            Venta venta = ventaBL.ObtenerPorId(1);
            int resultado = ventaBL.Eliminar(venta);
            Assert.AreEqual(1, resultado);
        }

        [TestMethod]
        public void T4_ObtenerPorId()
        {
            Venta venta = ventaBL.ObtenerPorId(1);

            Assert.AreNotEqual(0, venta.NoFactura);
        }

        [TestMethod]
        public void T5_Buscar()
        {
            List<Venta> lista = ventaBL.Buscar(new Venta { IdSucursal = 1 });
            Assert.AreNotEqual(0, lista.Count);
        }
    }
}
