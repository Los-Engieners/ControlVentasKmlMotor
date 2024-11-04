using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlVentasKmlMotor.EN;
using System.Data.SqlClient;

namespace ControlVentasKmlMotor.DAL
{
    public class CuotaDAL
    {
        #region METODOS  GUARDAR MODIFICAR Y ELIMINAR
        public static int Guardar(Cuota pCuota)
        {
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = @"INSERT INTO Cuotas (IdCuenta, Monto, FechaHora, Estado)
                                    VALUES (@IdCuenta, @Monto, @FechaHora, 1)";
            comando.Parameters.AddWithValue("@IdCuenta", pCuota.IdCuenta);
            comando.Parameters.AddWithValue("@Monto", pCuota.Monto);
            comando.Parameters.AddWithValue("@FechaHora", pCuota.FechaHora);
            return ComunDB.EjecutarComando(comando);

        }

        public static SqlCommand Guardar(Cuota pCuota, SqlTransaction pTransaction)
        {
            SqlCommand comando = ComunDB.ObtenerComando(pTransaction);
            comando.CommandText = @"INSERT INTO Cuotas (IdCuenta, Monto, FechaHora, Estado)
                                    VALUES (@IdCuenta, @Monto, @FechaHora, 1)";
            comando.Parameters.AddWithValue("@IdCuenta", pCuota.IdCuenta);
            comando.Parameters.AddWithValue("@Monto", pCuota.Monto);
            comando.Parameters.AddWithValue("@FechaHora", pCuota.FechaHora);
            return comando;

        }

        public static int Modificar(Cuota pcuota)
        {
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = @"UPDATE Cuotas SET  Id=@Id, IdCuenta=@IdCuenta,  Monto=@Monto, FechaHora=@FechaHora
                                   WHERE Id=@Id";
            comando.Parameters.AddWithValue("@IdCuenta", pcuota.IdCuenta);
            comando.Parameters.AddWithValue("@Monto", pcuota.Monto);
            comando.Parameters.AddWithValue("@Id", pcuota.Id);
            return ComunDB.EjecutarComando(comando);
        }

        public static int Eliminar(Cuota pcuota)
        {
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = "UPDATE Cuotas SET Estado=0 WHERE Id=@Id";
            comando.Parameters.AddWithValue("@Id", pcuota.Id);
            return ComunDB.EjecutarComando(comando);
        }

        #endregion

        #region Metodos de Busqueda
        public static Cuota ObtenerPorId(long pId)
        {
            Cuota obj = new Cuota();

            string consulta = @"SELECT c.IdCuenta, c.Monto, c.FechaHora, c.Estado
                                FROM Cuotas c 
                                WHERE c.Id = @Id ";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Id", pId);

            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            while (reader.Read())
            {
                obj.Id = reader.GetInt16(0);
                obj.IdCuenta = reader.GetInt64(1);
                obj.Monto = reader.GetDecimal(2);
                obj.FechaHora = reader.GetDateTime(3);
                obj.Estado = reader.GetByte(4);
            }
            return obj;
        }
        #endregion

        #region Lista Cuotas
        public static List<Cuota> Buscar(Cuota pCuota)
        {
            List<Cuota> lista = new List<Cuota>();

            #region Proceso
            using (SqlCommand comando = ComunDB.ObtenerComando())
            {
                byte contador = 0;
                string whereSQL = " ";
                string consulta = @"SELECT TOP 100 c.Id, c.IdCuenta, c.Monto, c.Estado
                                    FROM Cuotas c ";

                // Filtros
                if (pCuota.Id > 0)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " c.Id = @Id";
                    comando.Parameters.AddWithValue("@Id", pCuota.Id);
                }
                if (pCuota.IdCuenta > 0)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " c.IdCuenta = @IdCuenta ";
                    comando.Parameters.AddWithValue("@IdCuenta", pCuota.IdCuenta);
                }
                if (pCuota.Monto > 0)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " c.Monto = @Monto";
                    comando.Parameters.AddWithValue("@Monto", pCuota.Monto);

                }
                if (pCuota.FechaHora != null && pCuota.FechaHora != DateTime.MinValue)
                {
                    if (contador > 0)
                        whereSQL += " AND ";
                    contador += 1;
                    whereSQL += " c.FechaHora BETWEEN @FechaHoraIni AND @FechaHoraFin ";
                    DateTime fechaHoraIni = pCuota.FechaHora.Date + new TimeSpan(0, 0, 0);
                    DateTime fechaHoraFin = pCuota.FechaHora.Date + new TimeSpan(23, 59, 59);

                    comando.Parameters.AddWithValue("@FechaHoraIni", fechaHoraIni);
                    comando.Parameters.AddWithValue("@FechaHoraFin", fechaHoraFin);
                }

                if (pCuota.Estado > 0)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " c.Estado = @Estado ";
                    comando.Parameters.AddWithValue("@Estado", pCuota.Estado);

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
                    Cuota obj = new Cuota();
                    obj.Id = reader.GetInt16(0);
                    obj.IdCuenta = reader.GetInt64(1);
                    obj.Monto = reader.GetDecimal(2);
                    obj.FechaHora = reader.GetDateTime(3);
                    obj.Estado = reader.GetByte(4);
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

