using ControlVentasKmlMotor.BL;
using ControlVentasKmlMotor.EN;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ControlVentasKmlMotor.PruebasUnitarias
{
    [TestClass]
    public class ModeloUnitTest
    {
        ModeloBL modBL = new ModeloBL();

        [TestMethod]
        public void T1_Guardar()
        {
            Modelo modelo = new Modelo();
            modelo.IdMarca = 1;
            modelo.IdTipoAuto = 1;
            modelo.Nombre = "Familiar";
            modelo.Estado = 1;
            int resultado = modBL.Guardar(modelo);          
        }

        [TestMethod]
        public void T2_Modificar()
        {
            Modelo modelo = modBL.ObtenerPorId(1 );
            modelo.IdMarca = 2;
            modelo.IdTipoAuto = 2;
            modelo.Nombre= "Descapotable";
            int resultado = modBL.Modificar(modelo);

            Assert.AreEqual(1, resultado);
        }
        [TestMethod]
        public void T3_Eliminar()
        {
            Modelo modelo = modBL.ObtenerPorId(1);
            int resultado = modBL.Eliminar(modelo);
            Assert.AreEqual(1, resultado);
        }
        [TestMethod]
        public void T4_ObtenerPorId()
        {
            Modelo modelo = modBL.ObtenerPorId(1);

            Assert.AreNotEqual(0, modelo.Id);
        }

        [TestMethod]
        public void T5_Buscar()
        {
            List<Modelo> lista = modBL.Buscar(new Modelo { Nombre = "Descapotable" });
            Assert.AreNotEqual(1, lista.Count);
        }
        
    }
}
