using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasKmlMotor.EN
{
    public class Modelo
    {
        public byte Id { get; set; }
        public byte IdMarca { get; set; }
        public byte IdTipoAuto { get; set; }
        public string Nombre { get; set; }
        public byte Estado { get; set; }
        public virtual Marca Marca { get; set; }
        public virtual TipoAutos TipoAuto { get; set; }
    }
}
