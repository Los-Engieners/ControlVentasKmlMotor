using ControlVentasKmlMotor.EN;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasKmlMotor.DAL
{
    public class TipoPagoDAL
    {
        #region METODOS GUARDAR, MODIFICAR Y ELIMINAR
        public static int Guardar(TipoPago pTipoPago)
        {
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = "INSERT INTO TiposPago (Nombre, Estado) VALUES (@Nombre, 1)";
            comando.Parameters.AddWithValue("@Nombre", pTipoPago.Nombre);
            return ComunDB.EjecutarComando(comando);
        }
        public static int Modificar(TipoPago pTipoPago)
        {
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = "UPDATE TiposPago SET Nombre=@Nombre WHERE Id=@Id";
            comando.Parameters.AddWithValue("@Nombre", pTipoPago.Nombre);
            comando.Parameters.AddWithValue("@Id", pTipoPago.Id);
            return ComunDB.EjecutarComando(comando);
        }
        public static int Eliminar(TipoPago pTipoPago)
        {
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = "UPDATE TiposPago SET Estado=0 WHERE Id=@Id";
            comando.Parameters.AddWithValue("@Id", pTipoPago.Id);
            return ComunDB.EjecutarComando(comando);
        }
        #endregion

        #region Metodos de buscada
        public static TipoPago ObtenerPorId(byte pId)
        {
            TipoPago obj = new TipoPago();

            string consulta = "SELECT t.Id, t.Nombre, t.Estado FROM TiposPago t WHERE t.Id = @Id ";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Id", pId);

            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            while (reader.Read())
            {
                obj.Id = reader.GetByte(0);
                obj.Nombre = reader.GetString(1);
                obj.Estado = reader.GetByte(2);

            }
            return obj;
        }

        public static List<TipoPago> Buscar(TipoPago pTipoPago)
        {
            List<TipoPago> lista = new List<TipoPago>();

            #region Proceso
            using (SqlCommand comando = ComunDB.ObtenerComando())
            {
                byte contador = 0;
                string whereSQL = " ";
                string consulta = @"SELECT TOP 100 t.Id, t.Nombre, t.Estado FROM TiposPago t ";

                // Filtros

                if (pTipoPago.Nombre != null && pTipoPago.Nombre.Trim() != string.Empty)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " t.Nombre = @Nombre ";
                    comando.Parameters.AddWithValue("@Nombre", pTipoPago.Nombre);

                }
                if (pTipoPago.Estado > 0)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " t.Estado = @Estado ";
                    comando.Parameters.AddWithValue("@Estado", pTipoPago.Estado);

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
                    TipoPago obj = new TipoPago();
                    obj.Id = reader.GetByte(0);
                    obj.Nombre = reader.GetString(1);
                    obj.Estado = reader.GetByte(2);
                    //Agregar a la lista
                    lista.Add(obj);
                }
                comando.Connection.Dispose();

            }
            #endregion
            return lista;


            #endregion
        }
 }   }
