using ControlVentasKmlMotor.BL;
using ControlVentasKmlMotor.EN;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ControlVentasKmlMotor.PruebasUnitarias
{
    [TestClass]
    public class ClienteUnitTest
    {
        ClienteBL clienteBL = new ClienteBL();

        [TestMethod]
        public void T1_Guardar()
        {
            Cliente cliente = new Cliente();
            cliente.IdGenero = 1;
            cliente.Nombre = "Mario";
            cliente.Apellido = "Perez";
            cliente.DUI = "774656-3";
            cliente.Telefono = "87463555";
            cliente.FechaNacimiento = new DateTime(1989, 10, 23);
            cliente.Direccion = "Colonia Palmeras";
            cliente.Estado = 1;
            int resultado = clienteBL.Guardar(cliente);

            Assert.AreEqual(1, resultado);
        }

        [TestMethod]
        public void T2_Modificar()
        {
            Cliente cliente = clienteBL.ObtenerPorId(1);
            cliente.Direccion = "Sonzacate";
            cliente.Telefono = "43555444";
            int resultado = clienteBL.Modificar(cliente);

            Assert.AreEqual(1, resultado);
        }

        [TestMethod]
        public void T3_Eliminar()
        {
            Cliente cliente = clienteBL.ObtenerPorId(1);
            int resultado = clienteBL.Eliminar(cliente);
            Assert.AreEqual(1, resultado);
        }

        [TestMethod]
        public void T4_ObtenerPorId()
        {
                Cliente cliente= clienteBL.ObtenerPorId(1);

            Assert.AreNotEqual(0, cliente.Id);
        }

        [TestMethod]
        public void T5_Buscar()
        {
            List<Cliente> lista = clienteBL.Buscar(new Cliente { Nombre = "Mario" });
            Assert.AreNotEqual(0, lista.Count);
        }
    }
}
