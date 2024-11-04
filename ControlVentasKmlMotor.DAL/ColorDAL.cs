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
    public class ColorDAL
    {
        #region Metodo Guardar, Modificar y Eliminar
        public static int Guardar (Color pColor)
        {
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = "INSERT INTO Colores(Nombre, Estado) VALUES (@Nombre, 1)";
            comando.Parameters.AddWithValue("@Nombre", pColor.Nombre);
            return ComunDB.EjecutarComando(comando);
        }
        public static int Modificar(Color pColor)
        {
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = "UPDATE Colores SET Nombre=@Nombre WHERE Id=@Id";
            comando.Parameters.AddWithValue("@Nombre", pColor.Nombre);
            comando.Parameters.AddWithValue("@Id", pColor.Id);
            return ComunDB.EjecutarComando(comando);
        }
        public static int Eliminar(Color pColor)
        {
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = "UPDATE Colores SET Estado=0 WHERE Id=@Id";
            comando.Parameters.AddWithValue("@Id", pColor.Id);
            return ComunDB.EjecutarComando(comando);
        }
        #endregion

        #region METODOS DE BUSQUEDA
        public static Color ObtenerPorId(byte pId)
        {
            Color obj = new Color();

            string consulta = "SELECT c.Id, c.Nombre, c.Estado FROM Colores c WHERE c.Id = @Id";
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

        #region Metodos de busqueda
        public static List<Color> Buscar(Color pColor)
        {
            List<Color> lista = new List<Color>();

            #region Proceso
            using (SqlCommand comando = ComunDB.ObtenerComando())
            {
                byte contador = 0;
                string whereSQL = " ";
                string consulta = "SELECT TOP 100 c.Id, c.Nombre, c.Estado FROM Colores c ";

                //Validar filtros
                if (pColor.Nombre != null && pColor.Nombre.Trim() != string.Empty)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " c.Nombre LIKE @Nombre ";
                    comando.Parameters.AddWithValue("@Nombre", "%" + pColor.Nombre + "%");
                }
                if (pColor.Estado > 0)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " c.Estado = @Estado ";
                    comando.Parameters.AddWithValue("@Estado", pColor.Estado);
                }
                if (whereSQL.Trim().Length > 0)
                {
                    whereSQL = " WHERE " + whereSQL;
                }
                comando.CommandText = consulta + whereSQL;

                SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
                while (reader.Read())
                {
                    Color obj = new Color();
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

