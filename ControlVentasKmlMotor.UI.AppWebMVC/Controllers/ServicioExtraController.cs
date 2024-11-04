using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ControlVentasKmlMotor.BL;
using ControlVentasKmlMotor.EN;

namespace ControlVentasKmlMotor.UI.AppWebMVC.Controllers
{
    public class ServicioExtraController : Controller
    {
        ServicioExtraBL servicioExtraBL = new ServicioExtraBL();
        // GET: ServicioExtra
        public ActionResult Index()
        {
            List<ServicioExtra> listaServicioExtras = servicioExtraBL.Buscar(new ServicioExtra());
            ViewBag.ServicioExtras = listaServicioExtras;
            return View();
        }
        public ActionResult Buscar(ServicioExtra pServicioExtra)
        {
            if (pServicioExtra == null)
            {
                pServicioExtra = new ServicioExtra();
            }
            List<ServicioExtra> lista = servicioExtraBL.Buscar(pServicioExtra);

            lista = lista.OrderBy(x => x.Id).ToList();
            return Json(lista, JsonRequestBehavior.AllowGet);
        }
    }
}