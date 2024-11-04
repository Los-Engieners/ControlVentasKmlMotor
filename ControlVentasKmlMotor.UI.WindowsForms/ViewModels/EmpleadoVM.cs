using ControlVentasKmlMotor.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasKmlMotor.UI.WindowsForms.ViewModels
{
    public class EmpleadoVM
    {
        public EmpleadoVM(Empleado pEmpleado) 
        {
            this.Id = pEmpleado.Id;
            this.Nombre = pEmpleado.Nombre;
            this.Apellido = pEmpleado.Apellido;
            this.CorreoElectronico = pEmpleado.CorreoElectronico;
            

            this.Genero = pEmpleado.Genero != null ? pEmpleado.Genero.Nombre : "N/A";
            this.Sucursal = pEmpleado.Sucursal != null ? pEmpleado.Sucursal.Nombre : "N/A";
            this.Cargo = pEmpleado.Cargo != null ? pEmpleado.Cargo.Nombre : "N/A";

        }

        public byte Id { get; set; }
        public string Genero { get; set; }
        public string Sucursal { get; set; }
        public string Cargo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string CorreoElectronico { get; set; }
        
    }
}
