using ControlVentasKmlMotor.DAL;
using ControlVentasKmlMotor.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ControlVentasKmlMotor.BL
{
    public class CargoBL
    {
        public int Guardar(Cargo pCargo)
        {
            return CargoDAL.Guardar(pCargo);
        }
        public int Modificar(Cargo pCargo)
        {
            return CargoDAL.Modificar(pCargo);
        }
        public int Eliminar(Cargo pCargo)
        {
            return CargoDAL.Eliminar(pCargo);
        }

        public Cargo ObtenerPorId(byte pId)
        {
            return CargoDAL.ObtenerPorId(pId);
        }
        public List<Cargo> Buscar(Cargo pCargo)
        {
            pCargo.Estado = 1; //Registros Activos
            return CargoDAL.Buscar(pCargo);
        }

      
    }
}
