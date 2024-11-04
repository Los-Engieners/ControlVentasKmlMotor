using System;
using ControlVentasKmlMotor.EN;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasKmlMotor.UI.WindowsForms.ViewModels
{
    public class VentaVM
    {
        public VentaVM(Venta pVenta) 
        {
            this.NoFactura = pVenta.NoFactura;
            this.FechaHora = pVenta.FechaHora.ToString("");
            this.Precio = pVenta.Precio.ToString("$ ##.00"); ;
            this.Total = pVenta.Total.ToString("$ ##.00");
            this.Estatus = pVenta.Estatus.ToString("");
          


            this.Empleado = pVenta.Empleado != null ? pVenta.Empleado.Nombre + pVenta.Empleado.Apellido : "N/A";
            this.Cliente = pVenta.Cliente != null ? pVenta.Cliente.Nombre + pVenta.Cliente.Apellido : "N/A";
            this.Sucursal = pVenta.Sucursal != null ? pVenta.Sucursal.Nombre : "N/A";
            this.Vehiculo = pVenta.Vehiculo != null ? pVenta.Vehiculo.FechaLanzamiento : "N/A";
            this.TipoPago = pVenta.TipoPago != null ? pVenta.TipoPago.Nombre : "N/A";


        }

        public long NoFactura { get; set; }
        public string Cliente { get; set; }
        public string Empleado { get; set; }
        public string Vehiculo { get; set; }
        public string TipoPago { get; set; }
        public string Sucursal { get; set; }
        public string FechaHora { get; set; }
        public string Precio { get; set; }
        public string Total { get; set; }
        public string Estatus { get; set; }
        public string Estado { get; set; }

       
    }
}
