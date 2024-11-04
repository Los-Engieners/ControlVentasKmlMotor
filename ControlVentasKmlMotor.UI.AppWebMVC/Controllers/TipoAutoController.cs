using ControlVentasKmlMotor.BL;
using ControlVentasKmlMotor.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControlVentasKmlMotor.UI.AppWebMVC.Controllers
{
    public class TipoAutoController : Controller
    {
        TipoAutosBL tipoAutosBL = new TipoAutosBL();
        // GET: TipoAuto
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Buscar(TipoAutos pTipoAutos)
        {
            if (pTipoAutos == null)
            {
                pTipoAutos = new TipoAutos();
            }
            List<TipoAutos> lista = tipoAutosBL.Buscar(pTipoAutos);

            lista = lista.OrderBy(x => x.Id).ToList();
            return Json(lista, JsonRequestBehavior.AllowGet);
        }
    }
}