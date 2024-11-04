using ControlVentasKmlMotor.BL;
using ControlVentasKmlMotor.EN;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ControlVentasKmlMotor.UI.AppWebMVC.Controllers
{
    [AuthorizeCustom("Administrador| Vendedor| Secretaria| Gerente")]
    public class VehiculoController : Controller
    {
        VehiculoBL vehiculoBL = new VehiculoBL();
        // GET: Vehiculo


        // Método para guardar la imagen en la carpeta "Images"
        private string GuardarImagen(HttpPostedFileBase file)
        {
            if (file != null && file.ContentLength > 0)
            {
                // Definir la carpeta donde se guardarán las imágenes
                string carpetaDestino = Server.MapPath("~/assets/vehiculos");

                // Crear la carpeta si no existe
                if (!Directory.Exists(carpetaDestino))
                {
                    Directory.CreateDirectory(carpetaDestino);
                }

                // Generar un nombre único para la imagen usando un GUID
                string nombreArchivo = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);

                // Obtener la ruta completa donde se guardará la imagen
                string rutaCompleta = Path.Combine(carpetaDestino, nombreArchivo);

                // Guardar el archivo en la ruta especificada
                file.SaveAs(rutaCompleta);

                // Retornar la ruta relativa que se guardará en la base de datos
                return "/assets/vehiculos/" + nombreArchivo; // Esto es correcto.
            }

            return null;
        }


        public ActionResult Index()
        {
            return View();

        }

        public ActionResult Modal()
        {
            return View();
        }

        public ActionResult Guardar(Vehiculo pVehiculo, HttpPostedFileBase Imagen)
        {
            if (pVehiculo == null)
            {
                return Json(0, JsonRequestBehavior.AllowGet);
            }

            // Guardar la imagen y obtener la ruta
            if (Imagen != null)
            {
                string rutaImagen = GuardarImagen(Imagen);
                pVehiculo.Imagen = rutaImagen;
            }

            int resultado = vehiculoBL.Guardar(pVehiculo);
            return Json(resultado, JsonRequestBehavior.AllowGet);
        }



        public ActionResult Modificar(Vehiculo pVehiculo, HttpPostedFileBase Imagen)
        {
            if (pVehiculo == null || pVehiculo.Id <= 0)
            {
                return Json(0, JsonRequestBehavior.AllowGet);
            }

            var vehiculoExistente = vehiculoBL.ObtenerPorId(pVehiculo.Id);

            if (vehiculoExistente == null)
            {
                return Json(0, JsonRequestBehavior.AllowGet); 
            }

            if (Imagen != null)
            {
                string nuevaRutaImagen = GuardarImagen(Imagen);

                if (!string.IsNullOrEmpty(vehiculoExistente.Imagen))
                {
                    string rutaImagenAnterior = Server.MapPath(vehiculoExistente.Imagen);
                    if (System.IO.File.Exists(rutaImagenAnterior))
                    {
                        System.IO.File.Delete(rutaImagenAnterior);
                    }
                }

                pVehiculo.Imagen = nuevaRutaImagen;
            }
            else
            {
                pVehiculo.Imagen = vehiculoExistente.Imagen;
            }

            int resultado = vehiculoBL.Modificar(pVehiculo);
            return Json(resultado, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Eliminar(Vehiculo pVehiculo)
        {
            if (pVehiculo == null)
            {
                return Json(0, JsonRequestBehavior.AllowGet);
            }

            int resultado = vehiculoBL.Eliminar(pVehiculo);
            return Json(resultado, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ObtenerPorId(byte pId)
        {
            if (pId <= 0)
            {
                return Json(0, JsonRequestBehavior.AllowGet);
            }

            Vehiculo obj = vehiculoBL.ObtenerPorId(pId);
            return Json(obj, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Buscar(Vehiculo pVehiculo)
        {
            if (pVehiculo == null)
            {
                pVehiculo = new Vehiculo();
            }
            List<Vehiculo> lista = vehiculoBL.Buscar(pVehiculo);

            vehiculoBL.CargarModeloVirtual(lista, listaModelo =>
            {
                new ModeloBL().CargarMarcaVirtual(listaModelo);
                new ModeloBL().CargarTipoAutosVirtual(listaModelo);
            });
            vehiculoBL.CargarColorVirtual(lista);

            lista = lista.OrderBy(x => x.Id).ToList();
            return Json(lista, JsonRequestBehavior.AllowGet);
        }
      
    }



}
//}