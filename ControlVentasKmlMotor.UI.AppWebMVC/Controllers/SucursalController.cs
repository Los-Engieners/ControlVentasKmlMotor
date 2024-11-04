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
    public class SucursalController : Controller
    {
        SucursalBL sucursalBL = new SucursalBL();
        // GET: Sucursal
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Buscar(Sucursal pSucursal)
        {
            if (pSucursal == null)
            {
                pSucursal = new Sucursal();
            }
            List<Sucursal> lista = sucursalBL.Buscar(pSucursal);

            lista = lista.OrderBy(x => x.Id).ToList();
            return Json(lista, JsonRequestBehavior.AllowGet);
        }
    }
}