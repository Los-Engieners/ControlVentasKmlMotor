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
    public class ModeloBL
    {
        
            public int Guardar(Modelo pModelo)
            {
                return ModeloDAL.Guardar(pModelo);
            }
            public int Modificar(Modelo pModelo)
            {
                return ModeloDAL.Modificar(pModelo);
            }
            public int Eliminar(Modelo pModelo)
            {
                return ModeloDAL.Eliminar(pModelo);
            }

            public Modelo ObtenerPorId(byte pId)
            {
                return ModeloDAL.ObtenerPorId(pId);
            }
             public List<Modelo> Buscar(Modelo pModelo)
             {
                 pModelo.Estado = 1; //Registros Activos
                  return ModeloDAL.Buscar(pModelo);
             }
        public void CargarMarcaVirtual(List<Modelo> pLista, Action<List<Marca>> pAccion = null)
        {
            if (pLista.Count > 0)
            {
                Dictionary<byte, Marca> diccionarioMarca = new Dictionary<byte, Marca>();

                foreach (var obj in pLista)
                {
                    if (diccionarioMarca.ContainsKey(obj.IdMarca) == true)
                    {
                        obj.Marca = diccionarioMarca[obj.IdMarca];
                    }
                    else
                    {
                        diccionarioMarca.Add(obj.IdMarca, MarcaDAL.ObtenerPorId(obj.IdMarca));
                        obj.Marca = diccionarioMarca[obj.IdMarca];
                    }
                }
                if (pAccion != null && diccionarioMarca.Count > 0)
                {
                    pAccion(diccionarioMarca.Select(x => x.Value).ToList());
                }
            }
        }
        public void CargarTipoAutosVirtual(List<Modelo> pLista, Action<List<TipoAutos>> pAccion = null)
        {
            if (pLista.Count > 0)
            {
                Dictionary<byte, TipoAutos> diccionarioTipoAutos = new Dictionary<byte, TipoAutos>();

                foreach (var obj in pLista)
                {
                    if (diccionarioTipoAutos.ContainsKey(obj.IdTipoAuto) == true)
                    {
                        obj.TipoAuto = diccionarioTipoAutos[obj.IdTipoAuto];
                    }
                    else
                    {
                        diccionarioTipoAutos.Add(obj.IdTipoAuto, TipoAutosDAL.ObtenerPorId(obj.IdTipoAuto));
                        obj.TipoAuto = diccionarioTipoAutos[obj.IdTipoAuto];
                    }
                }
                if (pAccion != null && diccionarioTipoAutos.Count > 0)
                {
                    pAccion(diccionarioTipoAutos.Select(x => x.Value).ToList());
                }
            }
        }


    }
}

