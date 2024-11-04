using ControlVentasKmlMotor.BL;
using ControlVentasKmlMotor.EN;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControlVentasKmlMotor.UI.AppWebMVC.Controllers
{
    public class ColorController : Controller
    {
        ColorBL colorBL =  new ColorBL();
        // GET: Color
        public ActionResult Index()
        {
            List<EN.Color> listaColor = colorBL.Buscar(new EN.Color());
            ViewBag.Color = listaColor;
            return View();
        }

        public ActionResult ObtenerPorId(byte pId)
        {
            if (pId <= 0)
            {
                return Json(0, JsonRequestBehavior.AllowGet);
            }

            EN.Color obj = colorBL.ObtenerPorId(pId);
            return Json(obj, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Buscar(EN.Color pColor)
        {
            if (pColor == null)
            {
                pColor = new EN.Color();
            }

            List<EN.Color> lista = colorBL.Buscar(pColor);
            lista = lista.OrderBy(x => x.Id).ToList();
            return Json(lista, JsonRequestBehavior.AllowGet);
        }
    }
}