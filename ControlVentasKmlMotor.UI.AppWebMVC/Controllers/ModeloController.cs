using ControlVentasKmlMotor.BL;
using ControlVentasKmlMotor.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControlVentasKmlMotor.UI.AppWebMVC.Controllers
{
    public class ModeloController : Controller
    {
        ModeloBL modeloBL =new ModeloBL();
        // GET: Modelo
        public ActionResult Index()
        {
            List<Modelo> listaModelos = modeloBL.Buscar(new Modelo());
            ViewBag.Modelo = listaModelos;
            return View();
        }
        public ActionResult Guardar(Modelo pModelo)
        {
            if (pModelo == null)
            {
                return Json(0, JsonRequestBehavior.AllowGet);
            }

            int resultado = modeloBL.Guardar(pModelo);
            return Json(resultado, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Modificar(Modelo pModelo)
        {
            if (pModelo == null || pModelo.Id <= 0)
            {
                return Json(0, JsonRequestBehavior.AllowGet);
            }

            int resultado = modeloBL.Modificar(pModelo);
            return Json(resultado, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Eliminar(Modelo pModelo)
        {
            if (pModelo == null)
            {
                return Json(0, JsonRequestBehavior.AllowGet);
            }

            int resultado = modeloBL.Eliminar(pModelo);
            return Json(resultado, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ObtenerPorId(byte pId)
        {
            if (pId <= 0)
            {
                return Json(0, JsonRequestBehavior.AllowGet);
            }

            Modelo obj = modeloBL.ObtenerPorId(pId);
            return Json(obj, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Buscar(Modelo pModelo)
        {
            if (pModelo == null)
            {
                pModelo = new Modelo();
            }

            List<Modelo> lista = modeloBL.Buscar(pModelo);

            modeloBL.CargarMarcaVirtual(lista);
            modeloBL.CargarTipoAutosVirtual(lista);

            lista = lista.OrderBy(x => x.Id).ToList();
            return Json(lista, JsonRequestBehavior.AllowGet);
        }
    }
}