using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlVentasKmlMotor.DAL;
using ControlVentasKmlMotor.EN;

namespace ControlVentasKmlMotor.BL
{
    public class ClienteBL
    {
        public int Guardar(Cliente pCliente)
        {
            return ClienteDAL.Guardar(pCliente);
        }
        public int Modificar(Cliente pCliente)
        {
            return ClienteDAL.Modificar(pCliente);
        }
        public int Eliminar(Cliente pCliente)
        {
            return ClienteDAL.Eliminar(pCliente);
        }

        public Cliente ObtenerPorId(byte pId)
        {
            return ClienteDAL.ObtenerPorId(pId);
        }
        public List<Cliente> Buscar(Cliente pCliente)
        {
            pCliente.Estado = 1; //Registros Activos
            return ClienteDAL.Buscar(pCliente);
        }

      

        public void CargarGeneroVirtual(List<Cliente> pLista, Action<List<Genero>> pAccion = null)
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
    }
}
