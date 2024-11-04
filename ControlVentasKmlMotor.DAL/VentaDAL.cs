using ControlVentasKmlMotor.EN;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasKmlMotor.DAL
{
    public class VentaDAL
    {
        #region METODOS  GUARDAR MODIFICAR Y ELIMINAR
        public static int Guardar(Venta pVenta)
        {
            SqlTransaction transaccion = ComunDB.CrearTransaction();
            try
            {
                decimal total, cuota1, balancePendiente;

                total = pVenta.Precio + (pVenta.Precio * 0.13M);


                SqlCommand comando = ComunDB.ObtenerComando(transaccion);
                comando.CommandText = @"INSERT INTO Ventas (IdCliente, IdEmpleado, IdVehiculo, IdSucursal, IdTipoPago, FechaHora, Precio, Total, Estatus, Estado)
                                      VALUES ( @IdCliente, @IdEmpleado, @IdVehiculo, @IdSucursal, @IdTipoPago, @FechaHora, @Precio, @Total, @Estatus, 1);";

                //comando.Parameters.AddWithValue("@NoFactura", pVenta.NoFactura);
                comando.Parameters.AddWithValue("@IdCliente", pVenta.IdCliente);
                comando.Parameters.AddWithValue("@IdEmpleado", pVenta.IdEmpleado);
                comando.Parameters.AddWithValue("@IdVehiculo", pVenta.IdVehiculo);
                comando.Parameters.AddWithValue("@IdSucursal", pVenta.IdSucursal);
                comando.Parameters.AddWithValue("@IdTipoPago", pVenta.IdTipoPago);
                comando.Parameters.AddWithValue("@FechaHora", pVenta.FechaHora);
                comando.Parameters.AddWithValue("@Precio", pVenta.Precio);
                comando.Parameters.AddWithValue("@Total", total);
                if (pVenta.IdTipoPago == (byte)Venta.TipoPagoEnum.CREDITO)
                {
                    comando.Parameters.AddWithValue("@Estatus", (byte)Venta.EstatusEnum.PENDIENTE);
                }
                else
                {
                    comando.Parameters.AddWithValue("@Estatus", (byte)Venta.EstatusEnum.FACTURADA);
                }

                comando.ExecuteNonQuery();

                long noFactura = pVenta.NoFactura;
                //Descontar existencias del producto vendido
                SqlCommand comandoDescontar = VehiculoDAL.DescontarStock(new Vehiculo { Id = pVenta.IdVehiculo }, transaccion);
                comandoDescontar.ExecuteNonQuery();

                if (pVenta.IdTipoPago == (byte)Venta.TipoPagoEnum.CREDITO)
                {
                    cuota1 = (total * 0.20M);
                    balancePendiente = total - cuota1;
                    
                    Cuenta cuenta = new Cuenta();

                    cuenta.NoFactura = noFactura;
                    cuenta.CantidadMeses = 48;
                    cuenta.Total = total;
                    cuenta.BalancePendiente = balancePendiente;
                    cuenta.Balance = cuota1;
                    cuenta.Estatus = (byte)Cuenta.EstatusEnum.PENDIENTE;

                    SqlCommand comandoCuenta = CuentaDAL.Guardar(cuenta, transaccion);

                    long IdCuenta = Convert.ToInt64(comandoCuenta.ExecuteScalar());

                    Cuota cuota = new Cuota();
                    cuota.IdCuenta = IdCuenta;
                    cuota.Monto = cuota1;
                    cuota.FechaHora = DateTime.Now;

                    SqlCommand comandoCuota = CuotaDAL.Guardar(cuota, transaccion);
                    comandoCuota.ExecuteNonQuery();

                }
                if (pVenta.DetalleVentas != null )
                {
                    foreach (var detalle in pVenta.DetalleVentas)
                    {
                        detalle.NoFactura = noFactura;

                        detalle.Total = total;
                        SqlCommand comandoDetalle = DetalleVentaDAL.Guardar(detalle, transaccion);

                        //Confirmar guardar detalle de la venta
                        comandoDetalle.ExecuteNonQuery();
          
                    }
                }
             
                transaccion.Commit();
            }
            catch (Exception ex )
            {
                transaccion.Rollback();
                return 0;
            }
            finally
            {
                transaccion.Dispose();
            }
            return 1;
        }
        public static int Anular(Venta pVenta)
        {
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = "UPDATE Ventas SET Estado=@Estado WHERE Id=@Id";
            comando.Parameters.AddWithValue("@Estado", (byte)Venta.EstatusEnum.ANULADO);
            comando.Parameters.AddWithValue("@Id", pVenta.NoFactura);
            return ComunDB.EjecutarComando(comando);
        }
        public static int Modificar(Venta pVenta)
        {
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = @"UPDATE Ventas SET IdCliente=@IdCliente,  IdEmpleado=@IdEmpleado, IdVehiculo=@IdVehiculo, IdSucursal=@IdSucursal, IdTipoPago=@IdTipoPago, FechaHora=@FechaHora,
                                    Precio=@Precio, Total=@Total, Estatus=@Estatus WHERE NoFactura=@NoFactura";
            comando.Parameters.AddWithValue("@IdCliente", pVenta.IdCliente);
            comando.Parameters.AddWithValue("@IdEmpleado", pVenta.IdEmpleado);
            comando.Parameters.AddWithValue("@IdVehiculo", pVenta.IdVehiculo);
            comando.Parameters.AddWithValue("@IdSucursal", pVenta.IdSucursal);
            comando.Parameters.AddWithValue("@IdTipoPago", pVenta.IdTipoPago);
            comando.Parameters.AddWithValue("@FechaHora", pVenta.FechaHora);
            comando.Parameters.AddWithValue("@Precio", pVenta.Precio);
            comando.Parameters.AddWithValue("@Total", pVenta.Total);
            comando.Parameters.AddWithValue("@Estatus", pVenta.Estatus);
            comando.Parameters.AddWithValue("@NoFactura", pVenta.NoFactura);
            return ComunDB.EjecutarComando(comando);
        }

        public static int Eliminar(Venta pVenta)
        {
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = "UPDATE Ventas SET Estado=0 WHERE NoFactura=@NoFactura";
            comando.Parameters.AddWithValue("@NoFactura", pVenta.NoFactura);
            return ComunDB.EjecutarComando(comando);
        }

        #endregion

        #region Metodos de Busqueda
        public static Venta ObtenerPorId(long pNoFactura)
        {
            Venta obj = new Venta();

            string consulta = @"SELECT v.NoFactura, v.IdCliente, v.IdEmpleado, v.IdVehiculo, v.IdSucursal, v.IdTipoPago, v.FechaHora, v.Precio, v.Total, v.Estatus, v.Estado
                                FROM Ventas v 
                                WHERE v.NoFactura = @NoFactura ";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@NoFactura", pNoFactura);

            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            while (reader.Read())
            {
                obj.NoFactura = reader.GetInt64(0);
                obj.IdCliente = reader.GetInt32(1);
                obj.IdEmpleado = reader.GetByte(2);
                obj.IdVehiculo = reader.GetInt16(3);
                obj.IdSucursal = reader.GetByte(4);
                obj.IdTipoPago = reader.GetByte(5);
                obj.FechaHora = reader.GetDateTime(6);
                obj.Precio = reader.GetDecimal(7);
                obj.Total = reader.GetDecimal(8);
                obj.Estatus = reader.GetByte(9);
                obj.Estado = reader.GetByte(10);
            }
            return obj;
        }
        #endregion

        #region Lista Ventas
        public static List<Venta> Buscar(Venta pVenta)
        {
            List<Venta> lista = new List<Venta>();

            #region Proceso
            using (SqlCommand comando = ComunDB.ObtenerComando())
            {
                byte contador = 0;
                string whereSQL = " ";
                string consulta = @"SELECT TOP 100 v.NoFactura, v.IdCliente, v.IdEmpleado, v.IdVehiculo, v.IdSucursal, v.IdTipoPago, v.FechaHora, v.Precio, v.Total, v.Estatus, v.Estado
                                    FROM Ventas v ";

                // Filtros
                if (pVenta.IdCliente > 0)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " v.IdCliente = @IdCliente ";
                    comando.Parameters.AddWithValue("@IdCliente", pVenta.IdCliente);
                }
                if (pVenta.IdEmpleado > 0)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " v.IdEmpleado = @IdEmpleado ";
                    comando.Parameters.AddWithValue("@IdEmpleado", pVenta.IdEmpleado);
                }
                if (pVenta.IdSucursal > 0)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " v.IdSucursal = @IdSucursal ";
                    comando.Parameters.AddWithValue("@IdSucursal", pVenta.IdSucursal);
                }
                if (pVenta.IdVehiculo > 0)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " v.IdVehiculo = @IdVehiculo ";
                    comando.Parameters.AddWithValue("@IdVehiculo", pVenta.IdVehiculo);
                }
                if (pVenta.IdTipoPago > 0)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " v.IdTipoPago = @IdTipoPago ";
                    comando.Parameters.AddWithValue("@IdTipoPago", pVenta.IdTipoPago);
                }
                if (pVenta.FechaHora != null && pVenta.FechaHora != DateTime.MinValue)
                {
                    if (contador > 0)
                        whereSQL += " AND ";
                    contador += 1;
                    whereSQL += " v.FechaHora BETWEEN @FechaHoraIni AND @FechaHoraFin ";
                    DateTime fechaHoraIni = pVenta.FechaHora.Date + new TimeSpan(0, 0, 0);
                    DateTime fechaHoraFin = pVenta.FechaHora.Date + new TimeSpan(23, 59, 59);

                    comando.Parameters.AddWithValue("@FechaHoraIni", fechaHoraIni);
                    comando.Parameters.AddWithValue("@FechaHoraFin", fechaHoraFin);
                }
                if (pVenta.Precio > 0)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " v.Precio = @Precio";
                    comando.Parameters.AddWithValue("@Precio", pVenta.Precio);

                }
                if (pVenta.Total > 0)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " v.Total = @Total";
                    comando.Parameters.AddWithValue("@Total", pVenta.Total);

                }
                if (pVenta.Estatus > 0)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " v.Estatus = @Estatus ";
                    comando.Parameters.AddWithValue("@Estatus", pVenta.Estatus);
                }
                             
                if (pVenta.Estado > 0)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " v.Estado = @Estado ";
                    comando.Parameters.AddWithValue("@Estado", pVenta.Estado);

                }

                //AGREGAR FILTROS Verificar WHERE
                if (whereSQL.Trim().Length > 0)
                {
                    whereSQL = " WHERE " + whereSQL;
                }
                comando.CommandText = consulta + whereSQL;

                SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
                while (reader.Read())
                {
                    Venta obj = new Venta();
                    obj.NoFactura = reader.GetInt64(0);
                    obj.IdCliente = reader.GetInt32(1);
                    obj.IdEmpleado = reader.GetByte(2);
                    obj.IdVehiculo = reader.GetInt16(3);
                    obj.IdSucursal = reader.GetByte(4);
                    obj.IdTipoPago = reader.GetByte(5);
                    obj.FechaHora = reader.GetDateTime(6);
                    obj.Precio = reader.GetDecimal(7);
                    obj.Total = reader.GetDecimal(8);
                    obj.Estatus = reader.GetByte(9);
                    obj.Estado = reader.GetByte(10);
                    //Agregar a la lista
                    lista.Add(obj);
                }
                comando.Connection.Dispose();

            }
            #endregion
            return lista;
        }
        #endregion
    }
}
