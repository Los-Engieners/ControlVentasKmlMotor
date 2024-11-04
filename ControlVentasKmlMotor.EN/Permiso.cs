using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasKmlMotor.EN
{
    public class Permiso
    {
        public Int32 Id { get; set; }
        public byte IdCargo { get; set; }
        public byte IdModulo { get; set; }
        public byte Estado { get; set; }

        public virtual Cargo Cargo { get; set; }
        public virtual Modulo Modulo { get; set; }
    }
}
