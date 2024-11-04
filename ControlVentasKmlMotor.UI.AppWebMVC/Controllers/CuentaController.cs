using ControlVentasKmlMotor.BL;
using ControlVentasKmlMotor.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControlVentasKmlMotor.UI.AppWebMVC.Controllers
{
    public class CuentaController : Controller
    {
        CuentaBL cuentaBL = new CuentaBL();
        // GET: Cuenta
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Buscar(Cuenta pCuenta)
        {
            if (pCuenta == null)
            {
                pCuenta = new Cuenta();
            }
            List<Cuenta> lista = cuentaBL.Buscar(pCuenta);

            lista = lista.OrderBy(x => x.Id).ToList();
            return Json(lista, JsonRequestBehavior.AllowGet);
        }
       
    }
}