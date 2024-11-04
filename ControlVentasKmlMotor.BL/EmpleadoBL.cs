using ControlVentasKmlMotor.DAL;
using ControlVentasKmlMotor.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasKmlMotor.BL
{
    public class EmpleadoBL
    {
        public int Guardar(Empleado pEmpleado)
        {
            return EmpleadoDAL.Guardar(pEmpleado);
        }
        public int Modificar(Empleado pEmpleado)
        {
            return EmpleadoDAL.Modificar(pEmpleado);
        }
        public int Eliminar(Empleado pEmpleado)
        {
            return EmpleadoDAL.Eliminar(pEmpleado);
        }

        public Empleado ObtenerPorId(byte pId)
        {
            return EmpleadoDAL.ObtenerPorId(pId);
        }
        public List<Empleado> Buscar(Empleado pEmpleado)
        {
            pEmpleado.Estado = 1; //Registros Activos
            return EmpleadoDAL.Buscar(pEmpleado);
        }

        public Empleado Login(Empleado pUsuario)
        {
            return EmpleadoDAL.Login(pUsuario);
        }

        public void CargarGeneroVirtual(List<Empleado> pLista, Action<List<Genero>> pAccion = null)
        {
            if (pLista.Count > 0)
            {
                Dictionary<byte, Genero> diccionarioGenero = new Dictionary<byte, Genero>();

                foreach (var obj in pLista)
                {
                    if (diccionarioGenero.ContainsKey(obj.IdGenero) == true)
                    {
                        obj.Genero = diccionarioGenero[obj.IdGenero];
                    }
                    else
                    {
                        diccionarioGenero.Add(obj.IdGenero, GeneroDAL.ObtenerPorId(obj.IdGenero));
                        obj.Genero = diccionarioGenero[obj.IdGenero];
                    }
                }
                if (pAccion != null && diccionarioGenero.Count > 0)
                {
                    pAccion(diccionarioGenero.Select(x => x.Value).ToList());
                }
            }
        }

        public void CargarSucursalVirtual(List<Empleado> pLista, Action<List<Sucursal>> pAccion = null)
        {
            if (pLista.Count > 0)
            {
                Dictionary<byte, Sucursal> diccionarioSucursal = new Dictionary<byte, Sucursal>();

                foreach (var obj in pLista)
                {
                    if (diccionarioSucursal.ContainsKey(obj.IdSucursal) == true)
                    {
                        obj.Sucursal = diccionarioSucursal[obj.IdSucursal];
                    }
                    else
                    {
                        diccionarioSucursal.Add(obj.IdSucursal, SucursalDAL.ObtenerPorId(obj.IdSucursal));
                        obj.Sucursal = diccionarioSucursal[obj.IdSucursal];
                    }
                }
                if (pAccion != null && diccionarioSucursal.Count > 0)
                {
                    pAccion(diccionarioSucursal.Select(x => x.Value).ToList());
                }
            }
        }

        public void CargarCargoVirtual(List<Empleado> pLista, Action<List<Cargo>> pAccion = null)
        {
            if (pLista.Count > 0)
            {
                Dictionary<byte, Cargo> diccionarioCargo = new Dictionary<byte, Cargo>();

                foreach (var obj in pLista)
                {
                    if (diccionarioCargo.ContainsKey(obj.IdCargo) == true)
                    {
                        obj.Cargo = diccionarioCargo[obj.IdCargo];
                    }
                    else
                    {
                        diccionarioCargo.Add(obj.IdCargo, CargoDAL.ObtenerPorId(obj.IdCargo));
                        obj.Cargo = diccionarioCargo[obj.IdCargo];
                    }
                }
                if (pAccion != null && diccionarioCargo.Count > 0)
                {
                    pAccion(diccionarioCargo.Select(x => x.Value).ToList());
                }
            }
        }
    }
}
