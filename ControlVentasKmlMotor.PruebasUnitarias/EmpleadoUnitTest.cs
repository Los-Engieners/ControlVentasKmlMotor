using ControlVentasKmlMotor.BL;
using ControlVentasKmlMotor.EN;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ControlVentasKmlMotor.PruebasUnitarias
{
    [TestClass]
    public class EmpleadoUnitTest
    {
        EmpleadoBL empBL = new EmpleadoBL();

        [TestMethod]
        public void T1_Guardar()
        {
            Empleado empleado = new Empleado();
            empleado.IdGenero = 1;
            empleado.IdSucursal = 1;
            empleado.IdCargo = 2;
            empleado.Nombre = "Mario Oscar";
            empleado.Apellido = "Sanchez Veltran";
            empleado.CorreoElectronico = "MSKm2l@Gmail.com";
            empleado.Clave = "123";        
            empleado.Estado = 1;
            int resultado = empBL.Guardar(empleado);

            Assert.AreEqual(1, resultado);
        }

        [TestMethod]
        public void T2_Modificar()
        {
            Empleado empleado = empBL.ObtenerPorId(1);
            empleado.IdSucursal = 2 ;
            empleado.CorreoElectronico = "OVKMLmotor@gmai.com";
            empleado.CorreoElectronico = "1234";
            int resultado = empBL.Modificar(empleado);

            Assert.AreEqual(1, resultado);
        }

        [TestMethod]
        public void T3_Eliminar()
        {
            Empleado empleado = empBL.ObtenerPorId(1);
            int resultado = empBL.Eliminar(empleado);
            Assert.AreEqual(1, resultado);
        }

        [TestMethod]
        public void T4_ObtenerPorId()
        {
            Empleado empleado = empBL.ObtenerPorId(1);

            Assert.AreNotEqual(0, empleado.Id);
        }

        [TestMethod]
        public void T5_Buscar()
        {
            List<Empleado> lista = empBL.Buscar(new Empleado { Nombre = "Oscar" });
            Assert.AreNotEqual(0, lista.Count);
        }
    }
}
