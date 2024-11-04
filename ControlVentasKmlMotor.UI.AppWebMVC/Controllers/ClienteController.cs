using ControlVentasKmlMotor.BL;
using ControlVentasKmlMotor.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace ControlVentasKmlMotor.UI.AppWebMVC.Controllers
{
    [AuthorizeCustom("Vendedor|Administrador|Gerente|Secretaria")]
    public class ClienteController : Controller
    {
        ClienteBL clienteBL = new ClienteBL();
        // GET: Cliente

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Modal()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Guardar(Cliente pCliente)
        {
            if (pCliente == null)
            {
                return Json(0, JsonRequestBehavior.AllowGet);
            }

            int resultado = clienteBL.Guardar(pCliente);
            return Json(resultado, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Modificar(Cliente pCliente)
        {
            if (pCliente == null || pCliente.Id <= 0)
            {
                return Json(0, JsonRequestBehavior.AllowGet);
            }

            int resultado = clienteBL.Modificar(pCliente);
            return Json(resultado, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Eliminar(Cliente pCliente)
        {
            if (pCliente == null)
            {
                return Json(0, JsonRequestBehavior.AllowGet);
            }

            int resultado = clienteBL.Eliminar(pCliente);
            return Json(resultado, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ObtenerPorId(byte pId)
        {
            if (pId <= 0)
            {
                return Json(0, JsonRequestBehavior.AllowGet);
            }

            Cliente obj = clienteBL.ObtenerPorId(pId);
            return Json(obj, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Buscar(Cliente pCliente)
        {
            if (pCliente == null)
            {
                pCliente = new Cliente();
            }
            List<Cliente> lista = clienteBL.Buscar(pCliente);

            clienteBL.CargarGeneroVirtual(lista);

            lista = lista.OrderBy(x => x.Id).ToList();
            return Json(lista, JsonRequestBehavior.AllowGet);
        }
    }
}