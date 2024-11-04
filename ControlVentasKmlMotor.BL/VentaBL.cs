using ControlVentasKmlMotor.DAL;
using ControlVentasKmlMotor.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasKmlMotor.BL
{
    public class VentaBL
    {
        public int Guardar(Venta pVenta)
        {
            pVenta.FechaHora = DateTime.Now;
            return VentaDAL.Guardar(pVenta);
        }
        public int Anular(Venta pVenta)
        {
            return VentaDAL.Anular(pVenta);
        }
        public int Modificar(Venta pVenta)
        {
            return VentaDAL.Modificar(pVenta);
        }
        public int Eliminar(Venta pVenta)
        {
            return VentaDAL.Eliminar(pVenta);
        }

        public Venta ObtenerPorId(long pNoFactura)
        {
            return VentaDAL.ObtenerPorId(pNoFactura);
        }
        public List<Venta> Buscar(Venta pVenta)
        {
            pVenta.Estado = 1; //Registros Activos
            return VentaDAL.Buscar(pVenta);
        }

         public void CargarSucursalVirtual(List<Venta> pLista, Action<List<Sucursal>> pAccion = null)
         {
            if (pLista.Count > 0)
            {
                Dictionary<byte, Sucursal> diccionarioSucursal = new Dictionary<byte, Sucursal>();

                foreach (var obj in pLista)
                {
                    if (diccionarioSucursal.ContainsKey(obj.IdSucursal) == true)
                    {
                        obj.Sucursal = diccionarioSucursal[obj.IdSucursal];
                    }
                    else
                    {
                        diccionarioSucursal.Add(obj.IdSucursal, SucursalDAL.ObtenerPorId(obj.IdSucursal));
                        obj.Sucursal = diccionarioSucursal[obj.IdSucursal];
                    }
                }
                if (pAccion != null && diccionarioSucursal.Count > 0)
                {
                    pAccion(diccionarioSucursal.Select(x => x.Value).ToList());
                }
            }
        }

        public void CargarClienteVirtual(List<Venta> pLista, Action<List<Cliente>> pAccion = null)
        {
            if (pLista.Count > 0)
            {
                Dictionary<int, Cliente> diccionarioCliente = new Dictionary<int, Cliente>();

                foreach (var obj in pLista)
                {
                    if (diccionarioCliente.ContainsKey(obj.IdCliente) == true)
                    {
                        obj.Cliente = diccionarioCliente[obj.IdCliente];
                    }
                    else
                    {
                        diccionarioCliente.Add(obj.IdCliente, ClienteDAL.ObtenerPorId(obj.IdCliente));
                        obj.Cliente = diccionarioCliente[obj.IdCliente];
                    }
                }
                if (pAccion != null && diccionarioCliente.Count > 0)
                {
                    pAccion(diccionarioCliente.Select(x => x.Value).ToList());
                }
            }
        }

        public void CargarVehiculoVirtual(List<Venta> pLista, Action<List<Vehiculo>> pAccion = null)
        {
            if (pLista.Count > 0)
            {
                Dictionary<int, Vehiculo> diccionarioVehiculo = new Dictionary<int, Vehiculo>();

                foreach (var obj in pLista)
                {
                    if (diccionarioVehiculo.ContainsKey(obj.IdVehiculo) == true)
                    {
                        obj.Vehiculo = diccionarioVehiculo[obj.IdVehiculo];
                    }
                    else
                    {
                        diccionarioVehiculo.Add(obj.IdVehiculo, VehiculoDAL.ObtenerPorId(obj.IdVehiculo));
                        obj.Vehiculo = diccionarioVehiculo[obj.IdVehiculo];
                    }
                }
                if (pAccion != null && diccionarioVehiculo.Count > 0)
                {
                    pAccion(diccionarioVehiculo.Select(x => x.Value).ToList());
                }
            }
        }

        public void CargarTipoPagoVirtual(List<Venta> pLista, Action<List<TipoPago>> pAccion = null)
        {
            if (pLista.Count > 0)
            {
                Dictionary<int, TipoPago> diccionarioTipoPago = new Dictionary<int, TipoPago>();

                foreach (var obj in pLista)
                {
                    if (diccionarioTipoPago.ContainsKey(obj.IdTipoPago) == true)
                    {
                        obj.TipoPago = diccionarioTipoPago[obj.IdTipoPago];
                    }
                    else
                    {
                        diccionarioTipoPago.Add(obj.IdTipoPago, TipoPagoDAL.ObtenerPorId(obj.IdTipoPago));
                        obj.TipoPago = diccionarioTipoPago[obj.IdTipoPago];
                    }
                }
                if (pAccion != null && diccionarioTipoPago.Count > 0)
                {
                    pAccion(diccionarioTipoPago.Select(x => x.Value).ToList());
                }
            }
        }



    }

}
