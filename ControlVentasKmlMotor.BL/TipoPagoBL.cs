using ControlVentasKmlMotor.DAL;
using ControlVentasKmlMotor.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasKmlMotor.BL
{
    public class TipoPagoBL
    {
        public int Guardar(TipoPago pTipoPago)
        {
            return TipoPagoDAL.Guardar(pTipoPago);
        }
        public int Modificar(TipoPago pTipoPago)
        {
            return TipoPagoDAL.Modificar(pTipoPago);
        }
        public int Eliminar(TipoPago pTipoPago)
        {
            return TipoPagoDAL.Eliminar(pTipoPago);
        }

        public TipoPago ObtenerPorId(byte pId)
        {
            return TipoPagoDAL.ObtenerPorId(pId);
        }
        public List<TipoPago> Buscar(TipoPago pTipoPago)
        {
            pTipoPago.Estado = 1; //Registros Activos
            return TipoPagoDAL.Buscar(pTipoPago);
        }
    }
}
