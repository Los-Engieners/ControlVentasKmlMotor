using ControlVentasKmlMotor.BL;
using ControlVentasKmlMotor.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControlVentasKmlMotor.UI.AppWebMVC.Controllers
{
    [AuthorizeCustom("Administrador| Vendedor| Secretaria| Gerente")]
    public class TipoPagoController : Controller
    {
        TipoPagoBL tipoPagoBL = new TipoPagoBL();
        // GET: TipoPago
        public ActionResult Index()
        {
            List<TipoPago> listaTipoPagos = tipoPagoBL.Buscar(new TipoPago());
            ViewBag.TipoPagos = listaTipoPagos;
            return View();
        }

        public ActionResult Buscar(TipoPago pTipoPago)
        {
            if (pTipoPago == null)
            {
                pTipoPago = new TipoPago();
            }
            List<TipoPago> lista = tipoPagoBL.Buscar(pTipoPago);

            lista = lista.OrderBy(x => x.Id).ToList();
            return Json(lista, JsonRequestBehavior.AllowGet);
        }
    }
}