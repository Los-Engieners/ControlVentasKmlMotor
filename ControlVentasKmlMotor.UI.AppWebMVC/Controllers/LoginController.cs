using ControlVentasKmlMotor.BL;
using ControlVentasKmlMotor.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ControlVentasKmlMotor.UI.AppWebMVC.Controllers
{
    public class LoginController : Controller
    {
        EmpleadoBL empleadoBL = new EmpleadoBL();
        // GET: Login
        public ActionResult Index(string mensaje = null)
        {
            ViewBag.msg = mensaje;

            FormsAuthentication.SignOut();

            return View(new Empleado());
        }

        [HttpPost]
        public ActionResult Index(Empleado pEmpleado)
        {
            if (pEmpleado == null) { return View(pEmpleado); }

            Empleado empleadoSesion = empleadoBL.Login(pEmpleado);

            if (empleadoSesion != null && empleadoSesion.Id > 0)
            {
                Session["Empleado"] = empleadoSesion;

                Cargo cargo = new CargoBL().ObtenerPorId(empleadoSesion.IdCargo);
                Session["CargoSesion"] = cargo.Nombre;

                FormsAuthentication.RedirectFromLoginPage(empleadoSesion.CorreoElectronico, false);
                return RedirectToAction("Dashboard", "Home");
            }
            else
            {
                ViewBag.msg = "Credenciales Incorrectas, por favor intente de nuevo";
            }
            return View(pEmpleado);

        }

        public ActionResult Salir()
        {
            Session.Abandon();
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Login");
        }
    }
}