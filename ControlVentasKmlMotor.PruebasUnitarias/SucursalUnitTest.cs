using ControlVentasKmlMotor.BL;
using ControlVentasKmlMotor.EN;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ControlVentasKmlMotor.PruebasUnitarias
{
    [TestClass]
    public class SucursalUnitTest
    {
        SucursalBL sucBL = new SucursalBL();

        [TestMethod]
        public void T1_Guardar()
        {
            Sucursal sucursal = new Sucursal();
            sucursal.Nombre = "KMLmotor";
            sucursal.Direccion = "Izalco,Sonsonate";
            sucursal.Estado = 1;
            int resultado = sucBL.Guardar(sucursal);

            Assert.AreEqual(1, resultado);
        }

        [TestMethod]
        public void T2_Modificar()
        {
            Sucursal sucursal = sucBL.ObtenerPorId(1);
            sucursal.Nombre = "KMLmotor Izalco";
            sucursal.Direccion = "Barrio Asuncion, Izalco";
            int resultado = sucBL.Modificar(sucursal);

            Assert.AreEqual(1, resultado);
        }

        [TestMethod]
        public void T3_Eliminar()
        {
            Sucursal sucursal = sucBL.ObtenerPorId(1);
            int resultado = sucBL.Eliminar(sucursal);
            Assert.AreEqual(1, resultado);
        }

        [TestMethod]
        public void T4_ObtenerPorId()
        {
            Sucursal sucursal = sucBL.ObtenerPorId(1);
            Assert.AreNotEqual(0, sucursal.Id);
        }

        [TestMethod]
        public void T5_Buscar()
        {
            List<Sucursal> lista = sucBL.Buscar(new Sucursal { Nombre = "KMLmotor " });
            Assert.AreNotEqual(1, lista.Count);
        }

    }
}
