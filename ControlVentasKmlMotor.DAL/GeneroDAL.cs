using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlVentasKmlMotor.EN;
using ControlVentasKmlMotor.DAL;

namespace ControlVentasKmlMotor.DAL
{
    public class GeneroDAL
    {
        #region METODO GUARDAR
        public static int Guardar (Genero pGenero)
        {
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = "INSERT INTO  Generos(Nombre, Estado) VALUES (@Nombre, 1) ";
            comando.Parameters.AddWithValue("@Nombre", pGenero.Nombre);
            return ComunDB.EjecutarComando(comando);
        }

        #region
        public static List<Genero> Buscar(Genero pGenero)
        {
            List<Genero> lista = new List<Genero>();

            #region Proceso
            using (SqlCommand comando = ComunDB.ObtenerComando())
            {
                byte contador = 0;
                string whereSQL = " ";
                string consulta = "SELECT TOP 100 g.Id, g.Nombre, g.Estado FROM Generos g ";

                // Filtros
                if (pGenero.Nombre != null && pGenero.Nombre.Trim() != string.Empty)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " g.Nombre LIKE @Nombre ";
                    comando.Parameters.AddWithValue("@Nombre", "%" + pGenero.Nombre + "%");
                }
                if (pGenero.Estado > 0)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " g.Estado = @Estado ";
                    comando.Parameters.AddWithValue("@Estado", pGenero.Estado);
                }
                //Verificar WHERE
                if (whereSQL.Trim().Length > 0)
                {
                    whereSQL = " WHERE " + whereSQL;
                }
                comando.CommandText = consulta + whereSQL;

                SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
                while (reader.Read())
                {
                    Genero obj = new Genero();
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
        }
        #endregion
        #endregion

        public static Genero ObtenerPorId(byte pId)
        {
            Genero obj = new Genero();

            string consulta = "SELECT g.Id, g.Nombre, g.Estado FROM Generos g WHERE g.Id = @Id ";
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
    }
}
