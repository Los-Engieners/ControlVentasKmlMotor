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
    public class VentaController : Controller
    {
        VentaBL ventaBL = new VentaBL();
        // GET: Venta
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult HistorialVenta()
        {
            return View();
        }
        public ActionResult Buscar(Venta pVenta)
        {
            if (pVenta == null)
            {
                pVenta = new Venta();
            }
            List<Venta> lista = ventaBL.Buscar(pVenta);
            ventaBL.CargarClienteVirtual(lista);
            ventaBL.CargarSucursalVirtual(lista);
            ventaBL.CargarTipoPagoVirtual(lista);

            ventaBL.CargarVehiculoVirtual(lista, listaVehiculo =>
            {
                new VehiculoBL().CargarModeloVirtual(listaVehiculo);
                new VehiculoBL().CargarColorVirtual(listaVehiculo);
            });
            
            lista = lista.OrderBy(x => x.NoFactura).ToList();
            return Json(lista, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Guardar(Venta pVenta)
        {
            if (pVenta == null || pVenta != null && pVenta.IdVehiculo == 0)
                return Json(0, JsonRequestBehavior.AllowGet);

            //Obtener Id de usuario logueado
            Empleado empleadoLogueado = (Empleado)Session["Empleado"];
            pVenta.IdEmpleado = empleadoLogueado.Id;

            int resultado = ventaBL.Guardar(pVenta);
            return Json(resultado, JsonRequestBehavior.AllowGet);
                
        }
        public ActionResult ObtenerPorId(long pId)
        {
            if (pId <= 0)
            {
                return Json(0, JsonRequestBehavior.AllowGet);
            }

            Venta obj = ventaBL.ObtenerPorId(pId);
            return Json(obj, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Anular(Venta pVenta)
        {
            if (pVenta == null || pVenta != null && pVenta.NoFactura == 0)
            return Json(0, JsonRequestBehavior.AllowGet);

            //Obtener Id de usuario logueado
            pVenta.IdEmpleado = ((Empleado)Session["Empleado"]).Id;

            int resultado = ventaBL.Anular(pVenta);
            return Json(resultado, JsonRequestBehavior.AllowGet);
        }


    }

}