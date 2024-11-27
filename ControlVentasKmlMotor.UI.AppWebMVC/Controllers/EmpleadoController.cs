using ControlVentasKmlMotor.BL;
using ControlVentasKmlMotor.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControlVentasKmlMotor.UI.AppWebMVC.Controllers
{
    [Authorize]
    public class EmpleadoController : Controller
    {
        // GET: Empleado
        EmpleadoBL empleadoBL = new EmpleadoBL();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Perfil()
        {
            return View();
        }

        public ActionResult Guardar(Empleado pEmpleado)
        {
            if (pEmpleado == null)
            {
                return Json(0, JsonRequestBehavior.AllowGet);
            }

            int resultado = empleadoBL.Guardar(pEmpleado);
            return Json(resultado, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Modificar(Empleado pEmpleado)
        {
            if (pEmpleado == null || pEmpleado.Id <= 0)
            {
                return Json(0, JsonRequestBehavior.AllowGet);
            }

            int resultado = empleadoBL.Modificar(pEmpleado);
            return Json(resultado, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Eliminar(Empleado pEmpleado)
        {
            if (pEmpleado == null)
            {
                return Json(0, JsonRequestBehavior.AllowGet);
            }

            int resultado = empleadoBL.Eliminar(pEmpleado);
            return Json(resultado, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ObtenerPorId(byte pId)
        {
            if (pId <= 0)
            {
                return Json(0, JsonRequestBehavior.AllowGet);
            }

            Empleado obj = empleadoBL.ObtenerPorId(pId);
            return Json(obj, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Buscar(Empleado pEmpleado)
        {
            if (pEmpleado == null)
            {
                pEmpleado = new Empleado();
            }

            List<Empleado> lista = empleadoBL.Buscar(pEmpleado);
            empleadoBL.CargarCargoVirtual(lista);
            empleadoBL.CargarGeneroVirtual(lista);
            empleadoBL.CargarSucursalVirtual(lista);

            lista = lista.OrderBy(x => x.Id).ToList();

            return Json(lista, JsonRequestBehavior.AllowGet);
        }
    }
}