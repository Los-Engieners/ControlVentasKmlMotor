using ControlVentasKmlMotor.BL;
using ControlVentasKmlMotor.EN;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ControlVentasKmlMotor.PruebasUnitarias
{
    [TestClass]
    public class VehiculoUnitTest
    {
        VehiculoBL vehBL = new VehiculoBL();

        [TestMethod]
        public void T1_Guardar()
        {
            Vehiculo vehiculo = new Vehiculo();
            vehiculo.IdColor = 1;
            vehiculo.IdModelo = 1;
            vehiculo.FechaLanzamiento = "2009";
            vehiculo.Precio = 12666.99M;
            vehiculo.Existencias = 6;
            int resultado = vehBL.Guardar(vehiculo);

            Assert.AreEqual(1, resultado);
        }

        [TestMethod]
        public void T2_Modificar()
        {
            Vehiculo vehiculo = vehBL.ObtenerPorId(1);
            vehiculo.IdColor= 1;
            vehiculo.Precio = 13888.90M;
            vehiculo.Existencias = 5;
            int resultado = vehBL.Modificar(vehiculo);

            Assert.AreEqual(1, resultado);
        }

        [TestMethod]
        public void T3_Eliminar()
        {
            Vehiculo vehiculo = vehBL.ObtenerPorId(1);
            int resultado = vehBL.Eliminar(vehiculo);
            Assert.AreEqual(1, resultado);
        }

        [TestMethod]
        public void T4_ObtenerPorId()
        {
            Vehiculo vehiculo = vehBL.ObtenerPorId(1);

            Assert.AreNotEqual(0, vehiculo.Id);
        }

        [TestMethod]
        public void T5_Buscar()
        {
            List<Vehiculo> lista = vehBL.Buscar(new Vehiculo { Id = 1 });
            Assert.AreNotEqual(0, lista.Count);
        }
        [TestMethod]
        public void T6_ActualizarExistencias()
        {
            Vehiculo vehiculo = vehBL.ObtenerPorId(1);
            vehiculo.Existencias = 1;
            int resultado = vehBL.ActualizarExistencias(vehiculo);
            Assert.AreEqual(1, resultado);
        }
    }
}
