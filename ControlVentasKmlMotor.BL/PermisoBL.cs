using ControlVentasKmlMotor.DAL;
using ControlVentasKmlMotor.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasKmlMotor.BL
{
    public class PermisoBL
    {
        public int Guardar(Permiso pPermiso)
        {
            return PermisoDAL.Guardar(pPermiso);
        }
        public int Modificar(Permiso pPermiso)
        {
            return PermisoDAL.Modificar(pPermiso);
        }
        public int Eliminar(Permiso pPermiso)
        {
            return PermisoDAL.Eliminar(pPermiso);
        }

        public Permiso ObtenerPorId(byte pId)
        {
            return PermisoDAL.ObtenerPorId(pId);
        }
        public List<Permiso> Buscar(Permiso pPermiso)
        {
            pPermiso.Estado = 1; //Registros Activos
            return PermisoDAL.Buscar(pPermiso);
        }

        private PermisoDAL permisoDAL = new PermisoDAL(); //Instancia = llamar a un metodo

        public List<Permiso> Lista(byte idEmpleado)
        {
            return permisoDAL.Lista(idEmpleado); //Retornaa lista de EmpleadosDAL
        }

    }
}
