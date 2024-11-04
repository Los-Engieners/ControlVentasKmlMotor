using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasKmlMotor.EN
{
    public class Cuota
    {
        public short Id { get; set; }
        public long IdCuenta { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaHora { get; set; }
        public byte Estado { get; set; }
       

        public virtual Cuenta Cuenta { get; set; }
    }
}
