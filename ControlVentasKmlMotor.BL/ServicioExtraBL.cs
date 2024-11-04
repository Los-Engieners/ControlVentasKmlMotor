using ControlVentasKmlMotor.DAL;
using ControlVentasKmlMotor.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasKmlMotor.BL
{
    public class ServicioExtraBL
    {
        public int Guardar(ServicioExtra pServicio)
        {
            return ServicioExtraDAL.Guardar(pServicio);
        }
        public int Modificar(ServicioExtra pServicio)
        {
            return ServicioExtraDAL.Modificar(pServicio);
        }
        public int Eliminar(ServicioExtra pServicio)
        {
            return ServicioExtraDAL.Eliminar(pServicio);
        }

        public ServicioExtra ObtenerPorId(short pId)
        {
            return ServicioExtraDAL.ObtenerPorId(pId);
        }
        public List<ServicioExtra> Buscar(ServicioExtra pServicio)
        {
            pServicio.Estado = 1; //Registros Activos
            return ServicioExtraDAL.Buscar(pServicio);
        }
    }
}
