using ControlVentasKmlMotor.DAL;
using ControlVentasKmlMotor.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasKmlMotor.BL
{
    public class CuentaBL
    {
        //public int Guardar(Cuenta pCuenta)
        //{
        //    return CuentaDAL.Guardar(pCuenta);
        //}
        public int Modificar(Cuenta pCuenta)
        {
            return CuentaDAL.Modificar(pCuenta);
        }
        public int Eliminar(Cuenta pCuenta)
        {
            return CuentaDAL.Eliminar(pCuenta);
        }
        public Cuenta ObtenerPorId(long pId)
        {
            return CuentaDAL.ObtenerPorId(pId);
        }
        public List<Cuenta> Buscar(Cuenta pCuenta)
        {
            pCuenta.Estado = 1; //Registros Activos
            return CuentaDAL.Buscar(pCuenta);
        }
    }
}
