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
    public class ColorBL
    {
        public int Guardar(Color pColor)
        {
            return ColorDAL.Guardar(pColor);
        }
        public int Modificar(Color pColor)
        {
            return ColorDAL.Modificar(pColor);
        }
        public int Eliminar(Color pColor)
        {
            return ColorDAL.Eliminar(pColor);
        }
        public Color ObtenerPorId(byte pId)
        {
            return ColorDAL.ObtenerPorId(pId);
        }
        public List<Color> Buscar(Color pColor)
        {
            pColor.Estado = 1; //Registros Activos
            return ColorDAL.Buscar(pColor);
        }
    }
}
