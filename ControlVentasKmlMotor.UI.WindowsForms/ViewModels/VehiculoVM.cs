using ControlVentasKmlMotor.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasKmlMotor.UI.WindowsForms.ViewModels
{
    public class VehiculoVM
    {
        public VehiculoVM(Vehiculo pVehiculo)
        {
            this.Id = pVehiculo.Id;
            this.FechaLanzamiento = pVehiculo.FechaLanzamiento;
            this.Precio = pVehiculo.Precio.ToString("$ ##.00");
            this.Existencias = pVehiculo.Existencias;

            this.Color = pVehiculo.Color != null ? pVehiculo.Color.Nombre : "N/A";
            this.Modelo = pVehiculo.Modelo != null ? pVehiculo.Modelo.Nombre : "N/A";
            this.Marca = pVehiculo.Modelo != null && pVehiculo.Modelo.Marca != null ? pVehiculo.Modelo.Marca.Nombre : "N/A";

        }

        public Int16 Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public string FechaLanzamiento { get; set; }
        public string Precio { get; set; }
        public int Existencias { get; set; }
    }
}
