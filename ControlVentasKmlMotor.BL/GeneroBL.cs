using ControlVentasKmlMotor.DAL;
using ControlVentasKmlMotor.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasKmlMotor.BL
{
    public class GeneroBL
    {
        public int Guardar(Genero pGenero)
        {
            return GeneroDAL.Guardar(pGenero);
        }

        public List<Genero> Buscar(Genero pGenero)
        {
            pGenero.Estado = 1; //Registros Activos
            return GeneroDAL.Buscar(pGenero);
        }

        public Genero ObtenerPorId(byte pId)
        {
            return GeneroDAL.ObtenerPorId(pId);
        }

    }
}
