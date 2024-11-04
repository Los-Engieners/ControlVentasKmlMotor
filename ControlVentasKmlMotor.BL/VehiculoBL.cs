using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Referencias
using ControlVentasKmlMotor.DAL;
using ControlVentasKmlMotor.EN;

namespace ControlVentasKmlMotor.BL
{
    public class VehiculoBL
    {
        public int Guardar(Vehiculo pVehiculo)
        {
            return VehiculoDAL.Guardar(pVehiculo);
        }
        public int Modificar(Vehiculo pVehiculo)
        {
            return VehiculoDAL.Modificar(pVehiculo);
        }
        public int Eliminar(Vehiculo pVehiculo)
        {
            return VehiculoDAL.Eliminar(pVehiculo);
        }

        public Vehiculo ObtenerPorId(short pId)
        {
            return VehiculoDAL.ObtenerPorId(pId);
        }
        public List<Vehiculo> Buscar(Vehiculo pVehiculo)
        {
            pVehiculo.Estado = 1; //Registros Activos
            return VehiculoDAL.Buscar(pVehiculo);
        }
        public int ActualizarExistencias(Vehiculo pVehiculo)
        {
            return VehiculoDAL.ActualizarExistencias(pVehiculo);
        }

        public void CargarModeloVirtual(List<Vehiculo> pLista, Action<List<Modelo>> pAccion = null)
        {
            if (pLista.Count > 0)
            {
                Dictionary<byte, Modelo> diccionarioModelo = new Dictionary<byte, Modelo>();

                foreach (var obj in pLista)
                {
                    if (diccionarioModelo.ContainsKey(obj.IdModelo) == true)
                    {
                        obj.Modelo = diccionarioModelo[obj.IdModelo];
                    }
                    else
                    {
                        diccionarioModelo.Add(obj.IdModelo, ModeloDAL.ObtenerPorId(obj.IdModelo));
                        obj.Modelo = diccionarioModelo[obj.IdModelo];
                    }
                }
                if (pAccion != null && diccionarioModelo.Count > 0)
                {
                    pAccion(diccionarioModelo.Select(x => x.Value).ToList());
                }
            }
        }

        public void CargarColorVirtual(List<Vehiculo> pLista, Action<List<Color>> pAccion = null)
        {
            if (pLista.Count > 0)
            {
                Dictionary<byte, Color> diccionarioColor = new Dictionary<byte, Color>();

                foreach (var obj in pLista)
                {
                    if (diccionarioColor.ContainsKey(obj.IdColor) == true)
                    {
                        obj.Color = diccionarioColor[obj.IdColor];
                    }
                    else
                    {
                        diccionarioColor.Add(obj.IdColor, ColorDAL.ObtenerPorId(obj.IdColor));
                        obj.Color = diccionarioColor[obj.IdColor];
                    }
                }
                if (pAccion != null && diccionarioColor.Count > 0)
                {
                    pAccion(diccionarioColor.Select(x => x.Value).ToList());
                }
            }
        }
    }
}
