using ControlVentasKmlMotor.DAL;
using ControlVentasKmlMotor.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasKmlMotor.BL
{
    public class SucursalBL
    {
        public int Guardar(Sucursal pSucursal)
        {
            return SucursalDAL.Guardar(pSucursal);
        }
        public int Modificar(Sucursal pSucursal)
        {
            return SucursalDAL.Modificar(pSucursal);
        }
        public int Eliminar(Sucursal pSucursal)
        {
            return SucursalDAL.Eliminar(pSucursal);
        }

        public Sucursal ObtenerPorId(byte pId)
        {
            return SucursalDAL.ObtenerPorId(pId);
        }
        public List<Sucursal> Buscar(Sucursal pSucursal)
        {
            pSucursal.Estado = 1; //Registros Activos
            return SucursalDAL.Buscar(pSucursal);
        }
    }
}
