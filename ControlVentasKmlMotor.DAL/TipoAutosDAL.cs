using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Referencias 
using ControlVentasKmlMotor.EN;
using System.Data;
using System.Data.SqlClient;

namespace ControlVentasKmlMotor.DAL
{
    public class TipoAutosDAL
    {
        #region Metodos Guardar, Modificar y Eliminar
        public static int Guardar(TipoAutos pTipoAutos )
        {
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = "INSERT INTO TipoAutos(Nombre, Estado) VALUES (@Nombre, 1)";
            comando.Parameters.AddWithValue("@Nombre", pTipoAutos.Nombre);
            return ComunDB.EjecutarComando(comando);
        }
        public static int Modificar(TipoAutos pTipoAutos)
        {
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = "UPDATE TipoAutos SET Nombre=@Nombre WHERE Id=@Id";
            comando.Parameters.AddWithValue("@Nombre", pTipoAutos.Nombre);
            comando.Parameters.AddWithValue("@Id", pTipoAutos.Id);
            return ComunDB.EjecutarComando(comando);
        }
        public static int Eliminar(TipoAutos pTiposAutos)
        {
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = "UPDATE TipoAutos SET Estado=0 WHERE Id=@Id";
            comando.Parameters.AddWithValue("@Id", pTiposAutos.Id);
            return ComunDB.EjecutarComando(comando);
        }
        #endregion
        #region METODOS DE BUSQUEDA
        public static TipoAutos ObtenerPorId(byte pId)
        {
            TipoAutos obj = new TipoAutos();

            string consulta = "SELECT t.Id, t.Nombre, t.Estado FROM TipoAutos t WHERE t.Id = @Id";
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
        #endregion
        #region Metodos de Busqueda
        public static List<TipoAutos> Buscar(TipoAutos pTipoAutos)
        {
            List<TipoAutos> lista = new List<TipoAutos>();

            #region Proceso
            using (SqlCommand comando = ComunDB.ObtenerComando())
            {
                byte contador = 0;
                string whereSQL = " ";
                string consulta = "SELECT TOP 100 t.Id, t.Nombre, t.Estado FROM TipoAutos t ";

                //Validar filtros
                if (pTipoAutos.Nombre != null && pTipoAutos.Nombre.Trim() != string.Empty)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " t.Nombre LIKE @Nombre ";
                    comando.Parameters.AddWithValue("@Nombre", "%" + pTipoAutos.Nombre + "%");
                }
                if (pTipoAutos.Estado > 0)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " t.Estado = @Estado ";
                    comando.Parameters.AddWithValue("@Estado", pTipoAutos.Estado);
                }
                if (whereSQL.Trim().Length > 0)
                {
                    whereSQL = " WHERE " + whereSQL;
                }
                comando.CommandText = consulta + whereSQL;

                SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
                while (reader.Read())
                {
                    TipoAutos obj = new TipoAutos();
                    obj.Id = reader.GetByte(0);
                    obj.Nombre = reader.GetString(1);
                    obj.Estado = reader.GetByte(2);
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

 
