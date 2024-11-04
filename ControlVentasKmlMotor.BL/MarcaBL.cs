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
    public class MarcaBL
    {
        public int Guardar(Marca pMarca)
        {
            return MarcaDAL.Guardar(pMarca);
        }
        public int Modificar(Marca pMarca)
        {
            return MarcaDAL.Modificar(pMarca);
        }
        public int Eliminar(Marca pMarca)
        {
            return MarcaDAL.Eliminar(pMarca);
        }

        public Marca ObtenerPorId(byte pId)
        {
            return MarcaDAL.ObtenerPorId(pId);
        }
        public List<Marca> Buscar(Marca pMarca)
        {
            pMarca.Estado = 1; //Registros Activos
            return MarcaDAL.Buscar(pMarca);
        }
    }
}
