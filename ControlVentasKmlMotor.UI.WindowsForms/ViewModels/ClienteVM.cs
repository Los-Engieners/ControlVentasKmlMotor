using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlVentasKmlMotor.EN;

namespace ControlVentasKmlMotor.UI.WindowsForms.ViewModels
{
    public class ClienteVM
    {
        public ClienteVM(Cliente pcliente)
        {
            this.Id = pcliente.Id;
            this.Nombre = pcliente.Nombre;
            this.Apellido = pcliente.Apellido;
            this.DUI = pcliente.DUI;
            this.Telefono = pcliente.Telefono;
            this.Direccion = pcliente.Direccion;
            this.FechaNacimiento = pcliente.FechaNacimiento;

            this.Genero = pcliente.Genero != null ? pcliente.Genero.Nombre : "N/A";

        }
        public int Id { get; set; }
        public string Genero { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DUI { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
