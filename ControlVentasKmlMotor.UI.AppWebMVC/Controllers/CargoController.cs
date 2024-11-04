using ControlVentasKmlMotor.BL;
using ControlVentasKmlMotor.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControlVentasKmlMotor.UI.AppWebMVC.Controllers
{
    public class CargoController : Controller
    {
        CargoBL cargoBL = new CargoBL();
        // GET: Cargo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Buscar(Cargo pCargo)
        {
            if (pCargo == null)
            {
                pCargo = new Cargo();
            }
            List<Cargo> lista = cargoBL.Buscar(pCargo);

            lista = lista.OrderBy(x => x.Id).ToList();
            return Json(lista, JsonRequestBehavior.AllowGet);
        }
    }
}