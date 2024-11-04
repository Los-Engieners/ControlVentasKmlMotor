using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasKmlMotor.EN
{
    public class Venta
    {
        public long NoFactura { get; set; }
        public Int32 IdCliente { get; set; }
        public byte IdEmpleado { get; set; }
        public Int16 IdVehiculo { get; set; }
        public byte IdTipoPago { get; set; }
        public byte IdSucursal { get; set; }
        public DateTime FechaHora { get; set; }
        public decimal Precio { get; set; }
        public decimal Total { get; set; }
        public byte Estatus { get; set; }
        public byte Estado { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Empleado Empleado { get; set; }
        public virtual Vehiculo Vehiculo { get; set; }
        public virtual TipoPago TipoPago { get; set; }
        public virtual Sucursal Sucursal { get; set; }

        // Lista de detalle vinculados a la venta
        public List<DetalleVenta> DetalleVentas { get; set; } 
        public enum EstatusEnum
        {
            NINGUNO = 0,
            FACTURADA = 1,
            ANULADO = 2,
            PENDIENTE = 3
        }
        public enum TipoPagoEnum
        {
            CREDITO = 1,
            CONTADO = 2,

        }
        //Métodos
        public decimal CalcularTotal()
        {
            decimal total = 0;
            if (this.DetalleVentas != null && this.DetalleVentas.Count > 0)
            {
                total = this.DetalleVentas.Sum(x => x.CalcularSubTotal());
            }
            return total;
        }

 
    }
}
