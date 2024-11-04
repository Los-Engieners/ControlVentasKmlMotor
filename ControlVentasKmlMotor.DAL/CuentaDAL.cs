using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlVentasKmlMotor.EN;
using System.Data.SqlClient;

namespace ControlVentasKmlMotor.DAL
{
    public class CuentaDAL
    {
        #region Metodos GUARDAR, MODIFICAR Y ELIMINAR
        public static SqlCommand Guardar(Cuenta pCuenta, SqlTransaction pTransaction)
        {
            SqlCommand comando = ComunDB.ObtenerComando(pTransaction);
            comando.CommandText = @"INSERT INTO Cuentas(NoFactura, CantidadMeses, Total, Balance, BalancePendiente, Estatus, Estado)
                                    VALUES (@NoFactura, @CantidadMeses, @Total, @Balance, @BalancePendiente,@Estatus, 1);
                                    SELECT SCOPE_IDENTITY()";

            comando.Parameters.AddWithValue("@NoFactura", pCuenta.NoFactura);
            comando.Parameters.AddWithValue("@CantidadMeses", pCuenta.CantidadMeses);
            comando.Parameters.AddWithValue("@Total", pCuenta.Total);
            comando.Parameters.AddWithValue("@Balance", pCuenta.Balance);
            comando.Parameters.AddWithValue("@BalancePendiente", pCuenta.BalancePendiente);
            comando.Parameters.AddWithValue("@Estatus", pCuenta.Estatus);
            return comando;
        }
        public static int Modificar(Cuenta pCuenta)
        {
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = "UPDATE Cuentas SET NoFactura=@NoFactura, CantidadMeses=@CantidadMeses, Total=@Total, Balance=@Balance, BalancePendiente=@BalancePendiente, Estatus=@Estatus";
            comando.Parameters.AddWithValue("@NoFactura", pCuenta.NoFactura);
            comando.Parameters.AddWithValue("@CantidadMeses", pCuenta.CantidadMeses);
            comando.Parameters.AddWithValue("@Total", pCuenta.Total);
            comando.Parameters.AddWithValue("@Balance", pCuenta.Balance);
            comando.Parameters.AddWithValue("@BalancePendiente", pCuenta.BalancePendiente);
            comando.Parameters.AddWithValue("@Estatus", pCuenta.Estatus);
            return ComunDB.EjecutarComando(comando);
        }
        public static int Eliminar(Cuenta pCuenta)
        {
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = "UPDATE Cuentas SET Estado=0 WHERE Id=@Id";
            comando.Parameters.AddWithValue("@Id", pCuenta.Id);
            return ComunDB.EjecutarComando(comando);
        }
        #endregion

        #region Metodos de Busqueda

        public static Cuenta ObtenerPorId(long pId)
        {
            Cuenta obj = new Cuenta();

            string consulta = @"SELECT p.NoFactura, p.CantidadMeses, p.Total, p.Balance, p.BalancePendiente, p.Estatus, p.Estado
                                FROM Cuentas p
                                WHERE p.Id = @Id";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Id", pId);

            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            while (reader.Read())
            {
                obj.Id = reader.GetInt64(0);
                obj.NoFactura = reader.GetInt64(1);
                obj.CantidadMeses = reader.GetByte(2);
                obj.Total = reader.GetDecimal(3);
                obj.Balance = reader.GetDecimal(4);
                obj.BalancePendiente = reader.GetDecimal(5);
                obj.Estatus = reader.GetByte(6);
                obj.Estado = reader.GetByte(7);
            }
            return obj;
        }

        public static List<Cuenta> Buscar(Cuenta pCuenta)
        {
            List<Cuenta> lista = new List<Cuenta>();

            #region Proceso
            using (SqlCommand comando = ComunDB.ObtenerComando())
            {
                byte contador = 0;
                string whereSQL = " ";
                string consulta = @"SELECT TOP 100 p.Id, p.NoFactura, p.CantidadMeses, p.Total, p.Balance, p.BalancePendiente, p.Estatus, p.Estado FROM Cuentas p";

                // Filtros
                if (pCuenta.NoFactura > 0)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " p.NoFactura = @NoFactura ";
                    comando.Parameters.AddWithValue("@NoFactura", pCuenta.NoFactura);

                }
                if (pCuenta.Balance > 0)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " p.Balance = @Balance";
                    comando.Parameters.AddWithValue("@Balance", pCuenta.Balance);

                }
                if (pCuenta.CantidadMeses > 0)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " p.CantidadMeses = @CantidadMeses ";
                    comando.Parameters.AddWithValue("@CantidadMeses", pCuenta.CantidadMeses);

                }
                if (pCuenta.Estatus > 0)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " p.Estatus = @Estatus ";
                    comando.Parameters.AddWithValue("@Estatus", pCuenta.Estatus);

                }
                if (pCuenta.Estado > 0)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " p.Estado = @Estado ";
                    comando.Parameters.AddWithValue("@Estado", pCuenta.Estado);

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
                    Cuenta obj = new Cuenta();
                    obj.Id = reader.GetInt64(0);
                    obj.NoFactura = reader.GetInt64(1);
                    obj.CantidadMeses = reader.GetByte(2);
                    obj.Total = reader.GetDecimal(3);
                    obj.Balance = reader.GetDecimal(4);
                    obj.BalancePendiente = reader.GetDecimal(5);
                    obj.Estatus = reader.GetByte(6);
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
