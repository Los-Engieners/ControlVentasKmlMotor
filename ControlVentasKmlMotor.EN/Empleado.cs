using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasKmlMotor.EN
{
    public class Empleado
    {
        public byte Id { get; set; }
        public byte IdGenero { get; set; }
        public byte IdSucursal { get; set; }
        public byte IdCargo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string CorreoElectronico { get; set; }
        public string Clave { get; set; }
        public byte Estado { get; set; }

        public virtual Genero Genero { get; set; }
        public virtual Cargo Cargo { get; set; }
        public virtual Sucursal Sucursal { get; set; }
    }
}
