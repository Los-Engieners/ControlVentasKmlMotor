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
    public class TipoAutosBL
    {
        public int Guardar(TipoAutos pTipoAutos)
        {
            return TipoAutosDAL.Guardar(pTipoAutos);
        }
        public int Modificar(TipoAutos pTipoAutos)
        {
            return TipoAutosDAL.Modificar(pTipoAutos);
        }
        public int Eliminar(TipoAutos pTipoAutos)
        {
            return TipoAutosDAL.Eliminar(pTipoAutos);
        }

        public TipoAutos ObtenerPorId(byte pId)
        {
            return TipoAutosDAL.ObtenerPorId(pId);
        }
        public List<TipoAutos> Buscar(TipoAutos pTipoAutos)
        {
            pTipoAutos.Estado = 1; //Registros Activos
            return TipoAutosDAL.Buscar(pTipoAutos);
        }
    }
}
