using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlVentasKmlMotor.DAL;
using ControlVentasKmlMotor.EN;

namespace ControlVentasKmlMotor.BL
{
    public class CuotaBL
    {
        public int Guardar(Cuota pcuota)
        {
            return CuotaDAL.Guardar(pcuota);
        }
        public int Modificar(Cuota pcuota)
        {
            return CuotaDAL.Modificar(pcuota);
        }
        public int Eliminar(Cuota pcuota)
        {
            return CuotaDAL.Eliminar(pcuota);
        }

        public Cuota ObtenerPorId(long pId)
        {
            return CuotaDAL.ObtenerPorId(pId);
        }
        public List<Cuota> Buscar(Cuota pcuota)
        {
            pcuota.Estado = 1; //Registros Activos
            return CuotaDAL.Buscar(pcuota);
        }
    }
}

