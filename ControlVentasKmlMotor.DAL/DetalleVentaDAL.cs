using ControlVentasKmlMotor.EN;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasKmlMotor.DAL
{
    public class DetalleVentaDAL
    {
        #region METODOS  GUARDAR   Y DESCONTAR
        public static SqlCommand  Guardar(DetalleVenta pDetalle, SqlTransaction pTransaction)
        {
            SqlCommand comando = ComunDB.ObtenerComando(pTransaction);

            decimal totalDetalle = pDetalle.Total + pDetalle.SubTotal;


            comando.CommandText = @"INSERT INTO DetallesVentas (NoFactura, IdServicioExtra, Cantidad, Precio, Subtotal, Total, Estado)
                                    VALUES (@NoFactura, @IdServicioExtra, @Cantidad, @Precio, @SubTotal, @Total, 1)";
            comando.Parameters.AddWithValue("@NoFactura", pDetalle.NoFactura);
            comando.Parameters.AddWithValue("@IdServicioExtra", pDetalle.IdServicioExtra);
            comando.Parameters.AddWithValue("@Cantidad", pDetalle.Cantidad);
            comando.Parameters.AddWithValue("@Precio", pDetalle.Precio);
            comando.Parameters.AddWithValue("@Subtotal", pDetalle.SubTotal);
            comando.Parameters.AddWithValue("@Total", totalDetalle);
            return comando;

        }
     
        public static int Modificar(DetalleVenta pDetalle)
        {
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = @"UPDATE DetallesVentas SET NoFactura=@NoFactura,  IdServicioExtra=@IdServicioExtra, Cantidad=@Cantidad, Precio=@Precio, Subtotal=@Subtotal, Total=@Total
                                   WHERE Id=@Id";
            comando.Parameters.AddWithValue("@NoFactura", pDetalle.NoFactura);
            comando.Parameters.AddWithValue("@IdServicioExtra", pDetalle.IdServicioExtra);
            comando.Parameters.AddWithValue("@Cantidad", pDetalle.Cantidad);
            comando.Parameters.AddWithValue("@Precio", pDetalle.Precio);
            comando.Parameters.AddWithValue("@Subtotal", pDetalle.SubTotal);
            comando.Parameters.AddWithValue("@Total", pDetalle.Total);
            comando.Parameters.AddWithValue("@Id", pDetalle.Id);
            return ComunDB.EjecutarComando(comando);
        }

        public static int Eliminar(DetalleVenta pDetalle)
        {
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = "UPDATE DetallesVentas SET Estado=0 WHERE Id=@Id";
            comando.Parameters.AddWithValue("@Id", pDetalle.Id);
            return ComunDB.EjecutarComando(comando);
        }

        #endregion

        #region Metodos de Busqueda
        public static DetalleVenta ObtenerPorId(long pId)
        {
            DetalleVenta obj = new DetalleVenta();

            string consulta = @"SELECT d.NoFactura, d.IdServicioExtra, d.Cantidad, d.Precio, d.Subtotal, d.Total, d.Estado
                                FROM DetallesVentas d 
                                WHERE d.Id = @Id ";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Id", pId);

            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            while (reader.Read())
            {
                obj.Id = reader.GetInt64(0);
                obj.NoFactura = reader.GetInt64(1);
                obj.IdServicioExtra = reader.GetInt16(2);
                obj.Cantidad = reader.GetByte(3);
                obj.Total = reader.GetDecimal(4);
                obj.SubTotal = reader.GetDecimal(5);
                obj.Estado = reader.GetByte(6);
            }
            return obj;
        }
        #endregion

        #region Lista DtallesVentas
        public static List<DetalleVenta> Buscar(DetalleVenta pDetalle)
        {
            List<DetalleVenta> lista = new List<DetalleVenta>();

            #region Proceso
            using (SqlCommand comando = ComunDB.ObtenerComando())
            {
                byte contador = 0;
                string whereSQL = " ";
                string consulta = @"SELECT TOP 100 d.Id, d.NoFactura, d.ServicioExtra, d.Cantidad, d.Precio, d.Subtotal, d.Total, d.Estado
                                    FROM DetallesVentas d ";

                // Filtros
                if (pDetalle.Id > 0)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " d.Id = @Id";
                    comando.Parameters.AddWithValue("@Id", pDetalle.Id);
                }
                if (pDetalle.NoFactura > 0)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " d.NoFactura = @NoFactura ";
                    comando.Parameters.AddWithValue("@NoFactura", pDetalle.NoFactura);
                }
                if (pDetalle.Precio > 0)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " d.Precio = @Precio";
                    comando.Parameters.AddWithValue("@Precio", pDetalle.Precio);

                }
                if (pDetalle.Total > 0)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " d.Total = @Total";
                    comando.Parameters.AddWithValue("@Total", pDetalle.Total);

                }
                if (pDetalle.Estado > 0)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " d.Estado = @Estado ";
                    comando.Parameters.AddWithValue("@Estado", pDetalle.Estado);

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
                    DetalleVenta obj = new DetalleVenta();
                    obj.Id = reader.GetInt64(0);
                    obj.NoFactura = reader.GetInt64(1);
                    obj.IdServicioExtra = reader.GetInt16(2);
                    obj.Cantidad = reader.GetByte(3);
                    obj.Precio = reader.GetDecimal(4);
                    obj.SubTotal = reader.GetDecimal(5);
                    obj.Total = reader.GetDecimal(6);
                    obj.Estado = reader.GetByte(7);
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
