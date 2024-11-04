using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasKmlMotor.EN
{
    public class Vehiculo
    {
        public Int16 Id { get; set; }
        public byte IdModelo { get; set; }
        public byte IdColor { get; set; }
        public string FechaLanzamiento { get; set; }
        public decimal Precio { get; set; }
        public byte Existencias { get; set; }
        public string Imagen { get; set; }
        public byte Estado { get; set; }

        public virtual Color Color { get; set; }
        public virtual Modelo Modelo { get; set; }


    }
}
