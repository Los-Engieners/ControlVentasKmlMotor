using ControlVentasKmlMotor.EN;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasKmlMotor.DAL
{
    public class ModuloDAL
    {
        #region METODOS GUARDAR, MODIFICAR Y ELIMINAR
        public static int Guardar(Modulo pModulo)
        {
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = "INSERT INTO Modulos(Nombre, Estado) VALUES (@Nombre, 1)";
            comando.Parameters.AddWithValue("@Nombre", pModulo.Nombre);
            return ComunDB.EjecutarComando(comando);
        }
        public static int Modificar(Modulo pModulo)
        {
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = "UPDATE Modulos SET Nombre=@Nombre WHERE Id=@Id";
            comando.Parameters.AddWithValue("@Nombre", pModulo.Nombre);
            comando.Parameters.AddWithValue("@Id", pModulo.Estado);
            return ComunDB.EjecutarComando(comando);
        }
        public static int Eliminar(Modulo pModulo)
        {
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = "UPDATE Modulos SET Estado=0 WHERE Id=@Id";
            comando.Parameters.AddWithValue("@Id", pModulo.Id);
            return ComunDB.EjecutarComando(comando);
        }
        #endregion

        public static Modulo ObtenerPorId(byte pId)
        {
            Modulo obj = new Modulo();

            string consulta = "SELECT m.Id, m.Nombre, m.Estado FROM Modulos m WHERE m.Id = @Id ";
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
        #region
        public static List<Modulo> Buscar(Modulo pModulo)
        {
            List<Modulo> lista = new List<Modulo>();

            #region Proceso
            using (SqlCommand comando = ComunDB.ObtenerComando())
            {
                byte contador = 0;
                string whereSQL = " ";
                string consulta = "SELECT TOP 100 m.Id, m.Nombre, m.Estado FROM Modulos m ";

                // Filtros
                if (pModulo.Nombre != null && pModulo.Nombre.Trim() != string.Empty)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " m.Nombre LIKE @Nombre ";
                    comando.Parameters.AddWithValue("@Nombre", "%" + pModulo.Nombre + "%");
                }
                if (pModulo.Estado > 0)
                {
                    if (contador > 0)
                        whereSQL += " AND ";

                    contador += 1;
                    whereSQL += " m.Estado = @Estado ";
                    comando.Parameters.AddWithValue("@Estado", pModulo.Estado);
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
                    Modulo obj = new Modulo();
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
    }
}
