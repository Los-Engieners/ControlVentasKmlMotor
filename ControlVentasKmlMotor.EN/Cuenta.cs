using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasKmlMotor.EN
{
    public class Cuenta
    {
        public long Id { get; set; }
        public long NoFactura { get; set; }
        public byte CantidadMeses { get; set; }
        public decimal Total { get; set; }
        public decimal Balance { get; set; }
        public decimal BalancePendiente { get; set; }
        public byte Estatus { get; set; }
        public byte Estado { get; set; }
        public virtual Venta Venta { get; set; }

        public List<Cuota> Cuotas { get; set; }
        public enum EstatusEnum
        {
            NINGUNO = 0,
            PENDIENTE = 1,
            CERRADA = 2,
            ANULADA = 3
        }

    }
}
