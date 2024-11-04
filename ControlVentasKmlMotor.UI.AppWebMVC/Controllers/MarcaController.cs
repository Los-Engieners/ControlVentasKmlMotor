using ControlVentasKmlMotor.BL;
using ControlVentasKmlMotor.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControlVentasKmlMotor.UI.AppWebMVC.Controllers
{
    public class MarcaController : Controller
    {

        MarcaBL marcaBL = new MarcaBL();
        // GET: Marca
        public ActionResult Index()
        {
            List<Marca> listaMarcas = marcaBL.Buscar(new Marca());
            ViewBag.Marca = listaMarcas;
            return View();
        }

        public ActionResult Buscar(Marca pMarca)
        {
            if (pMarca == null )
            {
                pMarca = new Marca();
            }
            List<Marca> lista = marcaBL.Buscar(pMarca);
            lista = lista.OrderBy(x => x.Id).ToList();
            return Json(lista, JsonRequestBehavior.AllowGet);
        }

    }
}