using ControlVentasKmlMotor.BL;
using ControlVentasKmlMotor.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControlVentasKmlMotor.UI.AppWebMVC.Controllers
{
    public class CuotaController : Controller
    {
        CuotaBL cuotaBL = new CuotaBL();
        // GET: Cuota
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Guardar(Cuota pCuota)
        {
            if (pCuota == null)
            {
                return Json(0, JsonRequestBehavior.AllowGet);
            }

            int resultado = cuotaBL.Guardar(pCuota);
            return Json(resultado, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Modificar(Cuota pCuota)
        {
            if (pCuota == null || pCuota.Id <= 0)
            {
                return Json(0, JsonRequestBehavior.AllowGet);
            }

            int resultado = cuotaBL.Modificar(pCuota);
            return Json(resultado, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Eliminar(Cuota pCuota)
        {
            if (pCuota == null)
            {
                return Json(0, JsonRequestBehavior.AllowGet);
            }

            int resultado = cuotaBL.Eliminar(pCuota);
            return Json(resultado, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ObtenerPorId(byte pId)
        {
            if (pId <= 0)
            {
                return Json(0, JsonRequestBehavior.AllowGet);
            }

            Cuota obj = cuotaBL.ObtenerPorId(pId);
            return Json(obj, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Buscar(Cuota pCuota)
        {
            if (pCuota == null)
            {
                pCuota = new Cuota();
            }

            List<Cuota> lista = cuotaBL.Buscar(pCuota);

            lista = lista.OrderBy(x => x.Id).ToList();

            return Json(lista, JsonRequestBehavior.AllowGet);
        }

    }
}