using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
//Referencias
using ControlVentasKmlMotor.BL;
using ControlVentasKmlMotor.EN;
using System.Collections.Generic;

namespace ControlVentasKmlMotor.PruebasUnitarias
{
    [TestClass]
    public class ColorUnitTest
    {
        ColorBL colBL = new ColorBL();

        [TestMethod]
        public void T1_Guardar()
        {
            Color color = new Color();
            color.Nombre = "Azul1";
            int resultado = colBL.Guardar(color);

            Assert.AreEqual(1, resultado);
        }

        [TestMethod]
       
        public void T2_Eliminar()
        {
            Color color = colBL.ObtenerPorId(1);
            int resultado = colBL.Eliminar(color);

            Assert.AreEqual(1, resultado);
        }
        [TestMethod]
        public void T3_Modificar()
        {
            Color color = colBL.ObtenerPorId(1);
            color.Nombre = "Morado";
            int resultado = colBL.Modificar(color);

            Assert.AreEqual(1, resultado);
        }



        [TestMethod]
        public void T4_Buscar()
        {
            List<Color> lista = colBL.Buscar(new Color { Nombre = "Azul" });

            Assert.AreNotEqual(0, lista.Count);
        }

    }
}
