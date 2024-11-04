using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlVentasKmlMotor.DAL;
using ControlVentasKmlMotor.EN;

namespace ControlVentasKmlMotor.UI.WindowsForms.ViewModels
{
    public class ModeloVM
    {
        public ModeloVM(Modelo pModelo)
        {
            this.Id = pModelo.Id;
            this.Nombre = pModelo.Nombre;
            this.Marca = pModelo.Marca != null ? pModelo.Marca.Nombre : "N/A";
            this.TipoAutos = pModelo.TipoAuto != null ? pModelo.TipoAuto.Nombre : "N/A";
        }
        public byte Id { get; set; }

        public string Marca { get; set; }
        public string TipoAutos { get; set; }
        public string Nombre { get; set; }

    }
}
