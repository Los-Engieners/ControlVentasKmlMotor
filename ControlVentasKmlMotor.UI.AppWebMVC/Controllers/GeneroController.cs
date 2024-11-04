using ControlVentasKmlMotor.BL;
using ControlVentasKmlMotor.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControlVentasKmlMotor.UI.AppWebMVC.Controllers
{
    public class GeneroController : Controller
    {
        GeneroBL generoBL = new GeneroBL();
        // GET: Genero
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Buscar(Genero pGenero)
        {
            if (pGenero == null)
            {
                pGenero = new Genero();
            }
            List<Genero> lista = generoBL.Buscar(pGenero);

            lista = lista.OrderBy(x => x.Id).ToList();
            return Json(lista, JsonRequestBehavior.AllowGet);
        }
    }
}