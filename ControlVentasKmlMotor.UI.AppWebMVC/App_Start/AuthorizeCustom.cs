using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControlVentasKmlMotor.UI.AppWebMVC
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class AuthorizeCustom : AuthorizeAttribute
    {
        private string cargoSesion;
        private string nombresCargo;

        public AuthorizeCustom(string pNombresCargo)
        {
            nombresCargo = pNombresCargo;
        }

        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            try
            {
                cargoSesion = (string)HttpContext.Current.Session["CargoSesion"];
                if (cargoSesion == null)
                {
                    filterContext.Result = new RedirectResult("~/Login/Index?mensaje=Acceso denegado");
                }
                else
                {
                    if (nombresCargo.ToUpper().Contains(cargoSesion.ToUpper()) == false)
                    {
                        filterContext.Result = new RedirectResult("~/Login/Index?mensaje=Acceso denegado");
                        HttpContext.Current.Session.Abandon();
                    }
                }
            }
            catch (Exception)
            {
                filterContext.Result = new RedirectResult("~/Login/Index?mensaje=Error interno en el servidor");
            }
        }
    }
}