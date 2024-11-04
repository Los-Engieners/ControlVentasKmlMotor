using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasKmlMotor.EN
{
    public class DetalleVenta
    {
        public long Id { get; set; }
        public long NoFactura { get; set; }
        public short IdServicioExtra { get; set; }
        public byte Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }
        public byte Estado { get; set; }

        public virtual Venta Venta { get; set; }
        public virtual ServicioExtra ServicioExtra { get; set; }
        public decimal CalcularSubTotal()
        {
            return this.Cantidad * this.Precio;
        }

    }
}
