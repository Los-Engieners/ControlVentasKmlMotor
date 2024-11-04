using ControlVentasKmlMotor.DAL;
using ControlVentasKmlMotor.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasKmlMotor.BL
{
    public class ModuloBL
    {
        public int Guardar(Modulo pModulo)
        {
            return ModuloDAL.Guardar(pModulo);
        }
        public int Modificar(Modulo pModulo)
        {
            return ModuloDAL.Modificar(pModulo);
        }
        public int Eliminar(Modulo pModulo)
        {
            return ModuloDAL.Eliminar(pModulo);
        }

        public Modulo ObtenerPorId(byte pId)
        {
            return ModuloDAL.ObtenerPorId(pId);
        }
        public List<Modulo> Buscar(Modulo pModulo)
        {
            pModulo.Estado = 1; //Registros Activos
            return ModuloDAL.Buscar(pModulo);
        }
    }
}
