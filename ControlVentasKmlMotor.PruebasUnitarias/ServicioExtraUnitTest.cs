using ControlVentasKmlMotor.BL;
using ControlVentasKmlMotor.EN;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ControlVentasKmlMotor.PruebasUnitarias
{
    [TestClass]
    public class ServicioExtraUnitTest
    {
        ServicioExtraBL seBL = new ServicioExtraBL();

        [TestMethod]
        public void T1_Guardar()
        {
            ServicioExtra servicioExtra = new ServicioExtra();
            servicioExtra.Nombre = "Servicio";
            servicioExtra.Precio = 126.99M;
            int resultado = seBL.Guardar(servicioExtra);

            Assert.AreEqual(1, resultado);
        }

        [TestMethod]
        public void T2_Modificar()
        {
            ServicioExtra servicio = seBL.ObtenerPorId(1);
            servicio.Precio = 138.90M;
            int resultado = seBL.Modificar(servicio);

            Assert.AreEqual(1, resultado);
        }

        [TestMethod]
        public void T3_Eliminar()
        {
            ServicioExtra servicio = seBL.ObtenerPorId(1);
            int resultado = seBL.Eliminar(servicio);
            Assert.AreEqual(1, resultado);
        }

        [TestMethod]
        public void T4_ObtenerPorId()
        {
            ServicioExtra servicio = seBL.ObtenerPorId(1);

            Assert.AreNotEqual(0, servicio.Id);
        }

        [TestMethod]
        public void T5_Buscar()
        {
            List<ServicioExtra> lista = seBL.Buscar(new ServicioExtra { Id = 1 });
            Assert.AreNotEqual(0, lista.Count);
        }
      
    }
}
