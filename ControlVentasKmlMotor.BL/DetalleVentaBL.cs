using ControlVentasKmlMotor.DAL;
using ControlVentasKmlMotor.EN;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasKmlMotor.BL
{
    public class DetalleVentaBL
    {
        //public int Guardar(DetalleVenta pDetalle)
        //{
        //    return DetalleVentaDAL.Guardar(pDetalle);
        //}
        public int Modificar(DetalleVenta pDetalle)
        {
            return DetalleVentaDAL.Modificar(pDetalle);
        }
        public int Eliminar(DetalleVenta pDetalle)
        {
            return DetalleVentaDAL.Eliminar(pDetalle);
        }

        public DetalleVenta ObtenerPorId(long pId)
        {
            return DetalleVentaDAL.ObtenerPorId(pId);
        }
        public List<DetalleVenta> Buscar(DetalleVenta pDetalle)
        {
            pDetalle.Estado = 1; //Registros Activos
            return DetalleVentaDAL.Buscar(pDetalle);
        }
    }
}
